using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace InfluxBD
{
    public class HttpHelper
    {

        /// <summary>
        /// GET
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<string> GetAsync(string url,string username,string password)
        {
            using (var client = new HttpClient())
            {
                HttpHelper.SetRequestHeaders(client, username, password);
                string responseString = await client.GetStringAsync(url);
                return responseString;
            }
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <param name="url"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<string> PostAsync(string url, string username, string password, string sql)
        {
            using (var client = new HttpClient())
            {
                HttpHelper.SetRequestHeaders(client, username, password);
                var values = new List<System.Collections.Generic.KeyValuePair<string, string>>();
                values.Add(new KeyValuePair<string, string>("u", username));
                values.Add(new KeyValuePair<string, string>("p", password));
                values.Add(new KeyValuePair<string, string>("q", sql));

                var content = new FormUrlEncodedContent(values);

                var response = await client.PostAsync(url, content);

                var responseString = await response.Content.ReadAsStringAsync();

                return responseString;
            }
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <param name="url"></param>
        /// <param name="database"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="sql"></param>
        /// <param name="rp"></param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<string> PostAsync(string url,string database, string username, string password,string sql,string rp)
        {
            using (var client = new HttpClient())
            {
                HttpHelper.SetRequestHeaders(client,username,password);
                var values = new List<System.Collections.Generic.KeyValuePair<string, string>>();
                values.Add(new KeyValuePair<string, string>("db", database));
                values.Add(new KeyValuePair<string, string>("u", username));
                values.Add(new KeyValuePair<string, string>("p", password));
                values.Add(new KeyValuePair<string, string>("q", sql));
                values.Add(new KeyValuePair<string, string>("rp", rp));
                var content = new FormUrlEncodedContent(values);

                var response = await client.PostAsync(url, content);

                var responseString = await response.Content.ReadAsStringAsync();

                return responseString;
            }
        }

        private static void SetRequestHeaders(HttpClient client, string username, string password)
        {
            client.Timeout = TimeSpan.FromSeconds(30);
            client.DefaultRequestHeaders.Add("User-Agent", @"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36");
            client.DefaultRequestHeaders.Add("Accept", @"text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
            //client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip");
            string authorization= string.Format("{0}:{1}", username, password);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authorization);
        }
    }
}
