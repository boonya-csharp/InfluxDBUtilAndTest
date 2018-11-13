using InfluxBD.Sdk;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace InfluxDBTest
{
    public partial class FormSdkTest : Form
    {
        InfluxDBSdkHelper influxDBSdkHelper;
        public FormSdkTest()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var thread = new Thread(() =>{
                influxDBSdkHelper = new InfluxDBSdkHelper(tbxBaseUrl.Text, tbxUsername.Text,tbxPassword.Text);
            });
            thread.IsBackground = true;
            thread.Start();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => {
                influxDBSdkHelper = new InfluxDBSdkHelper(tbxBaseUrl.Text, tbxUsername.Text, tbxPassword.Text);
            });
            thread.IsBackground = true;
            thread.Start();
        }

        private void btnGetBds_Click(object sender, EventArgs e)
        {
            influxDBSdkHelper.GetDatabases((json) => {
                tbxDbsInfo.Text = json;
            });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var point = new InfluxDB.Net.Models.Point()
            {
                Measurement = "logs",//表名
                //Tags = new Dictionary<string, object>()
                //{
                //   { "Id", 158}
                //},
                Fields = new Dictionary<string, object>()
                {
                   { "Field0",  "Field0-"+new Random().Next() },
                   { "Field1",  "Field1-" +new Random().Next() },
                   { "Field2",  "Field2-"+new Random().Next() }
                },
                Timestamp = DateTime.UtcNow
            };
            influxDBSdkHelper.Write("rtvsweb", point, (status) => {
                MessageBox.Show(status ? "保存成功!" : "保存失败!", "保存消息:");
            });
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            influxDBSdkHelper.Query("rtvsweb", tbxSqlQuery.Text, (json) => {
                tbxQueryResult.Text = json;
            });
        }
    }
}
