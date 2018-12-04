using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace InfluxBD.Utils
{
    /// <summary>
    /// 读取指定行的内容
    /// </summary>
    public class TxtFileReader
    {
        DataBuffer dataBuffer;
        string filePath;

        public TxtFileReader(string filePath)
        {
            this.filePath = filePath;
        }

        public void Open()
        {
            this.dataBuffer = new DataBuffer(filePath);
            lock (this)
            {
                this.dataBuffer.Open();
                while (!this.dataBuffer.dataFile.done)
                {
                    Thread.Sleep(20);
                }
                Console.WriteLine("文件总行数:{0}", this.dataBuffer.dataFile.Lines);
            }
        }

        public List<string> FromStartReadLine(int start, int end)
        {
            List<string> list = new List<string>();
            List<int> listId = new List<int>();
            try
            {
                int total = this.dataBuffer.dataFile.Lines;
                if (end > total)
                {
                    throw new Exception("索引超过日志文件行");
                }
                for (int i = start, j = end; i <= j; i++)
                {
                    listId.Add(i);
                    list.Add(this.dataBuffer.ReadLine(i));
                }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("文件多行读取异常:{0}", ex);
                return list;
            }
        }

        public List<string> FromEndReadLine(int start, int end)
        {
            List<string> list = new List<string>();
            try
            {
                int total = this.dataBuffer.dataFile.Lines;
                if (end > total)
                {
                    throw new Exception("索引超过日志文件行");
                }
                int i = start == 1 ? total : total - start + 1, j = end == total ? 1 : total - end + 1;
                for (; i >= j; i--)
                {
                    list.Add(this.dataBuffer.ReadLine(i));
                }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("文件多行读取异常:{0}", ex);
                return list;
            }
        }

        public DataBuffer GetDataBuffer()
        {
            return this.dataBuffer;
        }

        public void Close()
        {
            this.dataBuffer.Close();
        }
    }

    public static class FileConfig
    {
        public static int STREAM_BUFFER_SIZE = 1024000;
        public static int MAP_DISTANCE = 10;
    }

    public class DataFile
    {
        /// 
        /// 数据文件名 
        /// 
        public string fileName = "";
        /// 
        /// 初始化读取完标志 
        /// 
        public bool done = false;

        /// 
        /// 当前流位置 
        /// 
        public long Position = 0;

        /// 
        /// 文件头部信息 
        /// 
        private Hashtable head = new Hashtable();
        public Hashtable Head { get { return head; } set { head = value; } }

        /// 
        /// 文件地图 
        ///        
        private ArrayList map = new ArrayList();
        public ArrayList Map { get { return map; } set { map = value; } }

        /// 
        /// 文件数据行行数 
        ///        
        private int lines = 0;
        public int Lines { get { return lines; } set { lines = value; } }
    }

    public class DataBuffer
    {
        private FileStream fs = null;
        private BufferedStream bs = null;
        private StreamReader sr = null;
        private StreamWriter sw = null;
        /// 
        /// 文件信息数据结构 
        /// 
        public DataFile dataFile = new DataFile();

        public DataBuffer(string name)
        {
            dataFile.fileName = name;
        }

        /// 
        /// 打开文件 
        /// 
        public bool Open()
        {
            try
            {
                //初始化各流 
                fs = new FileStream(dataFile.fileName, FileMode.Open, FileAccess.ReadWrite);
                bs = new BufferedStream(fs, FileConfig.STREAM_BUFFER_SIZE);
                sr = new StreamReader(fs);
                sw = new StreamWriter(fs);
                Thread initFile = new Thread(new ThreadStart(InitDataFile));
                initFile.Start();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("文件打开异常:{0}",ex);
                return false;
            }
        }

        private void InitDataFile()
        {
            //另开一个读取流 
            BufferedStream bs = new BufferedStream(fs);
            StreamReader sr = new StreamReader(bs);

            //读入数据文件头信息。共14行 
            string thisLine = NextLine(ref sr);
            dataFile.Head.Add("Subject", thisLine.Substring(11));

            thisLine = NextLine(ref sr);
            dataFile.Head.Add("Date", thisLine.Substring(8));

            thisLine = NextLine(ref sr);
            dataFile.Head.Add("Time", thisLine.Substring(8));

            thisLine = NextLine(ref sr);
            dataFile.Head.Add("Channels", thisLine.Substring(12));

            thisLine = NextLine(ref sr);
            dataFile.Head.Add("Rate", thisLine.Substring(8));

            thisLine = NextLine(ref sr);
            dataFile.Head.Add("Type", thisLine.Substring(8));

            thisLine = NextLine(ref sr);
            dataFile.Head.Add("Rows", thisLine.Substring(8));

            thisLine = NextLine(ref sr);
            thisLine = NextLine(ref sr);
            dataFile.Head.Add("Electrode Labels", thisLine);
            thisLine = NextLine(ref sr);
            thisLine = NextLine(ref sr);
            thisLine = NextLine(ref sr);
            thisLine = NextLine(ref sr);
            thisLine = NextLine(ref sr);
            //降低自己的优先级 
            Thread.CurrentThread.Priority = ThreadPriority.BelowNormal;

            //数行数，建立地图 
            int lines = 1;
            //在地图中加入首条数据的位置信息 
            dataFile.Map.Add(dataFile.Position);
            //顺序建立文件地图 
            while (!sr.EndOfStream)
            {
                thisLine = NextLine(ref sr);
                if ((++lines) % FileConfig.MAP_DISTANCE == 0)
                {
                    dataFile.Map.Add(dataFile.Position);
                }
            }
            dataFile.Lines = lines;
            dataFile.done = true;
        }

        /// 
        /// 文件关闭 
        /// 
        public bool Close()
        {
            try
            {
                //顺序关闭各流 
                sw.Close();
                sr.Close();
                bs.Close();
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("文件关闭异常:{0}", ex);
                return false;
            }
        }

        /// 
        /// 顺序读取下一行。效率低不建议大规模使用，只在打开文件的时候使用一次 
        /// 
        /// 
        public string NextLine(ref StreamReader sr)
        {
            string next = sr.ReadLine();
            //+2是指Windows换行回车。Linux下要改为+1 
            dataFile.Position += next.Length + 2;
            return next;
        }

        //指定的目标行内容 
        public string ReadLine(long line)
        {
            try
            {
                //如果载入完毕 
                if (dataFile.done)
                {
                    //确定数据块索引号 
                    int index = (int)line / FileConfig.MAP_DISTANCE;
                    //移动到指定位置 
                    bs.Seek(long.Parse(dataFile.Map[index].ToString()), SeekOrigin.Begin);
                    //创建流读取器 
                    sr = new StreamReader(bs, Encoding.GetEncoding("gb2312"));
                    //移动到指定行 
                    for (int i = 1; i <= (line - index * FileConfig.MAP_DISTANCE); i++)
                    {
                        sr.ReadLine();
                    }
                    //返回指定行的值 
                    return sr.ReadLine();
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("文件读取异常:{0}", ex);
                return "";
            }
        }
    }
}
