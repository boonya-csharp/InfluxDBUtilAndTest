using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace InfluxDB.Utils
{
    /// <summary>
    /// InfluxDB工作队列
    /// </summary>
    public class InfluxDBThreadWorkQueue
    {
        private static bool isRun = false;

        private static ConcurrentQueue<InfluxDBThreadTask> queue = new ConcurrentQueue<InfluxDBThreadTask>();

        /// <summary>
        /// 加入队列
        /// </summary>
        /// <param name="threadExecute"></param>
        /// <returns></returns>
        public static bool Enqueue(InfluxDBThreadTask threadExecute)
        {
            if (isRun)
            {
                queue.Enqueue(threadExecute);
                return true;
            }
            return false;
        }

        /// <summary>
        /// 启动队列
        /// </summary>
        public static void Start()
        {
            if (isRun)
            {
                return;
            }
            isRun = true;
            var thread = new Thread(async ()=> {
                while (isRun)
                {
                    if (queue.Count > 0)
                    {
                        InfluxDBThreadTask threadExcute;
                        if (queue.TryDequeue(out threadExcute))
                        {
                           await threadExcute.ExecuteThreadAsync();
                        }
                    }
                    Thread.Sleep(10);
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }

        /// <summary>
        /// 停止队列
        /// </summary>
        public static void Stop()
        {
            isRun = false;
        }
    }
}
