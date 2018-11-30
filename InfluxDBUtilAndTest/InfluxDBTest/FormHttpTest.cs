using InfluxBD;
using InfluxBD.Utils;
using InfluxDB.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InfluxDB.Utils.InfluxDBThreadTask;

namespace InfluxDBTest
{
    public partial class FormHttpTest : Form
    {
        HttpInfluxDBClient httpInfluxDBClient;
        public FormHttpTest()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var task = new InfluxDBThreadTask(httpInfluxDBClient, InfluxDBThreadTask.DBOptsType.Write, tbxDbSave.Text, tbxSqlWrite.Text, (result) => {
                    Console.WriteLine("数据库写入数据:result=" + result);
                    MessageBox.Show(string.IsNullOrEmpty(result) ? "保存成功!" : "保存失败:" + result, "保存消息");
                });
                InfluxDBThreadWorkQueue.Enqueue(task);

            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.Message,"保存异常");
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            var task = new InfluxDBThreadTask(httpInfluxDBClient, InfluxDBThreadTask.DBOptsType.Query, tbxDbQuery.Text, tbxSqlQuery.Text, (result) => {
                Console.WriteLine("数据库查询数据:" + result);
                MessageBox.Show("查询成功!", "查询消息");
                tbxQueryResult.Text = result;
            });
            InfluxDBThreadWorkQueue.Enqueue(task);
        }

        private void FormHttpTest_Load(object sender, EventArgs e)
        {
            // 允许跨线程调用
            Control.CheckForIllegalCrossThreadCalls = false;
            var thread = new Thread(() => {
                httpInfluxDBClient = new HttpInfluxDBClient(tbxBaseUrl.Text, tbxUsername.Text, tbxPassword.Text);
            });
            thread.IsBackground = true;
            thread.Start();
            // 开启工作队列线程
            InfluxDBThreadWorkQueue.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbxDbsInfo.Text = httpInfluxDBClient.GetDatabasesAsync().Result;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => {
                httpInfluxDBClient = new HttpInfluxDBClient(tbxBaseUrl.Text, tbxUsername.Text, tbxPassword.Text);
            });
            thread.IsBackground = true;
            thread.Start();
        }

        private void btnPing_ClickAsync(object sender, EventArgs e)
        {
            var task = new InfluxDBThreadTask(httpInfluxDBClient, InfluxDBThreadTask.DBOptsType.Ping, tbxDbQuery.Text, tbxSqlQuery.Text, (result) => {
                Console.WriteLine("PING结果:" + result);
                MessageBox.Show(result, "PING消息");
            });
            InfluxDBThreadWorkQueue.Enqueue(task);

        }

        private void tbxFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\Users\\Administrator\\Desktop";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "文本文件|*.txt";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbxFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            TxtFileReader reader = new TxtFileReader(this.tbxFilePath.Text);
            try
            {
                reader.Open();
                List<string> list = reader.ReadLine((int)this.numStart.Value, (int)this.numEnd.Value);
                this.tbxReadResult.Text = "";
                foreach (var s in list)
                {
                    this.tbxReadResult.AppendText(s);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "读取异常");
            }
            finally
            {
                reader.Close();
            }
        }

        private void btnHttpPost_Click(object sender, EventArgs e)
        {
            var thread = new Thread(async ()=> {
                //var result=await HttpHelper.PostAsync(this.tbxParam_url.Text,"rtvsweb","admin","admin","this is a sql");
                //MessageBox.Show(result, "POST结果");
            });
            thread.IsBackground = true;
            thread.Start();
        }

        private void btnSdk_Click(object sender, EventArgs e)
        {
            FormSdkTest sdkTest = new FormSdkTest();
            sdkTest.Show();
        }
    }
}
