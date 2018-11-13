using InfluxBD;
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
                string result = httpInfluxDBClient.Write("rtvsweb", tbxSqlWrite.Text);
                Console.WriteLine("写入数据库数据:" + result);
                MessageBox.Show("保存成功!", "保存消息");
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.Message,"保存异常");
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            tbxQueryResult.Text=httpInfluxDBClient.Query("rtvsweb", tbxSqlQuery.Text);
        }

        private void FormHttpTest_Load(object sender, EventArgs e)
        {
            var thread = new Thread(() => {
                httpInfluxDBClient = new HttpInfluxDBClient(tbxBaseUrl.Text, tbxUsername.Text, tbxPassword.Text);
            });
            thread.IsBackground = true;
            thread.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbxDbsInfo.Text=httpInfluxDBClient.GetDatabases();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => {
                httpInfluxDBClient = new HttpInfluxDBClient(tbxBaseUrl.Text, tbxUsername.Text, tbxPassword.Text);
            });
            thread.IsBackground = true;
            thread.Start();
        }
    }
}
