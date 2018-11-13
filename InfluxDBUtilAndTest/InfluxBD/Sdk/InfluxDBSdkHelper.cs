using InfluxDB.Net;
using InfluxDB.Net.Enums;
using InfluxDB.Net.Infrastructure.Configuration;
using InfluxDB.Net.Infrastructure.Influx;
using InfluxDB.Net.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InfluxBD.Sdk
{
    public class InfluxDBSdkHelper
    {
        private InfluxDb _client;

        /// <summary>
        /// 操作状态回调
        /// </summary>
        /// <param name="status"></param>
        public delegate void StatusCallBack(bool status);

        /// <summary>
        /// 操作结果回调
        /// </summary>
        /// <param name="json"></param>
        public delegate void ResultCallBack(string json);

        public InfluxDBSdkHelper(string baseUrl, string username, string password)
        {
            _client = new InfluxDb(baseUrl, username, password);
        }

        public async void CreateDatabase(string database, StatusCallBack statusCallBack)
        {
            InfluxDbApiResponse response = await _client.CreateDatabaseAsync(database);
            statusCallBack?.Invoke(response.Success);
        }


        public async void DeleteDatabase(string database, StatusCallBack statusCallBack)
        {   
            InfluxDbApiResponse deleteResponse = await _client.DropDatabaseAsync(database);
            statusCallBack?.Invoke(deleteResponse.Success);
        }


        public async void GetDatabases(ResultCallBack resultCallBack)
        { 
            List<Database> databases = await _client.ShowDatabasesAsync();
            string result = Newtonsoft.Json.JsonConvert.SerializeObject(databases);
            resultCallBack?.Invoke(result);
        }

        public async void Write(string database, InfluxDB.Net.Models.Point point, StatusCallBack statusCallBack)
        {
            //基于InfluxData.Net.InfluxDb.Models.Point实体准备数据
            //var point = new Point()
            //{
            //    Measurement = "logs",//表名
            //    Tags = new Dictionary<string, object>()
            //    {
            //       { "Id", 158}
            //    },
            //    Fields = new Dictionary<string, object>()
            //    {
            //       { "Val", "webInfo" }
            //    },
            //    Timestamp = DateTime.UtcNow
            //};
            InfluxDbApiResponse writeResponse = await _client.WriteAsync(database, point);
            statusCallBack?.Invoke(writeResponse.Success);
        }

        public async void Query(string database,string sql, ResultCallBack resultCallBack)
        {
            List<Serie> series = await _client.QueryAsync(database, sql);
            string result = Newtonsoft.Json.JsonConvert.SerializeObject(series); 
            resultCallBack?.Invoke(result);
        }

    }
}
