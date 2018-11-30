using InfluxBD.Sdk;
using InfluxDB.Net.Models;
using System;
using System.Collections.Generic;

namespace InfluxBD
{
    /// <summary>
    /// InfluxDB时序数据库操作HTTP客户端
    /// 参考:https://www.cnblogs.com/dehai/p/4887309.html
    /// </summary>
    public class HttpInfluxDBClient
    {
        string _baseAddress;
        string _username;
        string _password;
        InfluxDBSdkHelper influxDBSdkHelper;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="baseAddress"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public HttpInfluxDBClient(string baseAddress, string username, string password)
        {
            this._baseAddress = baseAddress;
            this._username = username;
            this._password = password;
        }

        public async System.Threading.Tasks.Task<string> CreateDatabaseAsync(string database)
        {
            string sql = "CREATE DATABASE " + database;
            string url = _baseAddress + string.Format("/query", "");
            string result = await HttpHelper.PostAsync(url, _username, _password, sql);
            return result;
        }


        public async System.Threading.Tasks.Task<string> DeleteDatabaseAsync(string database)
        {
            string sql = "DROP DATABASE " + database;
            string url = _baseAddress + string.Format("/query", "");
            string result = await HttpHelper.PostAsync(url, _username, _password, sql);
            return result;
        }


        public async System.Threading.Tasks.Task<string> GetDatabasesAsync()
        {
            string sql = "SHOW DATABASES";
            string url = _baseAddress + string.Format("/query?q={0}", sql);
            string result =await HttpHelper.GetAsync(url, _username, _password);
            return result;
        }

        /// <summary>
        /// 读取数据
        /// </summary>
        /// <param name="database"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<string> QueryAsync(string database, string sql)
        {
            string url = _baseAddress + string.Format("/query?db={0}&q={1}", database, sql);
            string result = await HttpHelper.GetAsync(url, _username, _password);
            return result;
        }

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="database"></param>
        /// <param name="sql">示例:test,tag=logs Field0=10,Field1=10,Field2=20</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<string> WriteAsync(string database, string sql)
        {
            string rp = "20_days";
            string url = _baseAddress + string.Format("/write?db={0}&q={1}", database, sql);
            string result = await HttpHelper.PostAsync(url, database,  _username, _password,sql,rp);
            return result;
        }

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="database"></param>
        /// <param name="sql"></param>
        /// <param name="timestamp"></param>
        public async System.Threading.Tasks.Task<string> WriteAsync(string database, string sql, DateTime timestamp)
        {
            if (influxDBSdkHelper == null)
            {
                influxDBSdkHelper = new InfluxDBSdkHelper(_baseAddress, _username, _password);
            }
            var result = await influxDBSdkHelper.WriteAsync(database, this.ParsePoint(sql, timestamp), null);
            return result;
        }

        /// <summary>
        /// Ping服务是否能够打开
        /// </summary>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<bool> PingAsync()
        {
            string url = _baseAddress + string.Format("/ping", "");
            string result = await HttpHelper.GetAsync(url, _username, _password);
            return string.IsNullOrEmpty(result);
        }

        /// <summary>
        /// 解析sql拆解标签字段表等
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="timestamp"></param>
        /// <returns></returns>
        private Point ParsePoint(string sql, DateTime timestamp)
        {
            string[] parts = sql.Split(' ');

            // 表和标签
            string table_tags = parts[0];
            string[] table_tags_parts = table_tags.Split(',');
            string tableName = table_tags_parts[0];
            Dictionary<string, object> Tags = new Dictionary<string, object>();
            Dictionary<string, object> Fields = new Dictionary<string, object>();
            if (table_tags_parts.Length > 1)
            {
                int index = 0;
                foreach (string tag in table_tags_parts)
                {
                    if (index > 0)
                    {
                        var tv = tag.Split('=');
                        Tags.Add(tv[0], tv[1]);
                    }
                    index++;
                }
            }
            // 字段和值
            string table_values = parts[1];
            string[] table_values_parts = table_values.Split(',');
            foreach (string val in table_values_parts)
            {
                var tv = val.Split('=');
                Fields.Add(tv[0], tv[1]);
            }
            // 时间戳
            if (parts.Length == 3)
            {
                try
                {
                    timestamp = new DateTime(long.Parse(parts[2]));
                }
                catch
                {
                    timestamp = DateTime.Now;
                }
            }

            var point = new Point()
            {
                Measurement = tableName,//表名
                Tags = Tags,// 标签
                Fields = Fields,// 字段和值
                Timestamp = timestamp// 时间戳
            };
            return point;
        }
    }
}
