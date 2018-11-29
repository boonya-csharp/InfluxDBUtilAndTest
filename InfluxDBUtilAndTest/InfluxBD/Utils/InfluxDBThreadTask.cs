using InfluxBD;
using System.Threading;
using System.Threading.Tasks;

namespace InfluxDB.Utils
{
    /// <summary>
    /// InfluxDB存储数据任务类
    /// </summary>
    public class InfluxDBThreadTask
    {
        public delegate void ThreadCallBack(string result);

        public InfluxDBThreadTask(HttpInfluxDBClient influxDBClient, DBOptsType type, string database, string sql, ThreadCallBack threadCallBack)
        {
            this.influxDBClient = influxDBClient;
            this.type = type;
            this.database = database;
            this.sql = sql;
            this.threadCallBack = threadCallBack;
        }
        public enum DBOptsType
        {
            Write=1,
            Query=2,
            Ping=3
        }
        public HttpInfluxDBClient influxDBClient { get; set; }
        public ThreadCallBack threadCallBack { get; set; }
        public DBOptsType type { get; set; }
        public string database { get; set; }
        public string sql { get; set; }
        public async Task ExecuteThreadAsync()
        {
            if (influxDBClient == null)
            {
                threadCallBack?.Invoke(null);
                return;
            }
            if (type == DBOptsType.Write)
            {
                var result =await influxDBClient.WriteAsync(database, sql);
                threadCallBack?.Invoke(result);
            }
            if (type == DBOptsType.Query)
            {
                var result =await influxDBClient.QueryAsync(database, sql);
                threadCallBack?.Invoke(result);
            }
            if (type == DBOptsType.Ping)
            {
                var result = await influxDBClient.PingAsync();
                threadCallBack?.Invoke(result?"服务器成功开启":"服务器未开启");
            }
        }
    }
}
