namespace InfluxDBTest
{
    partial class FormHttpTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxQueryResult = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGetBds = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDbsInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSqlQuery = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabCtl = new System.Windows.Forms.TabControl();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.btnPing = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxBaseUrl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageDatabasesInfo = new System.Windows.Forms.TabPage();
            this.tabPageSaveData = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxDbSave = new System.Windows.Forms.TextBox();
            this.tbxSqlWrite = new System.Windows.Forms.TextBox();
            this.tabPageQueryData = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxDbQuery = new System.Windows.Forms.TextBox();
            this.tabPageReadFile = new System.Windows.Forms.TabPage();
            this.tbxFilePath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxReadResult = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numEnd = new System.Windows.Forms.NumericUpDown();
            this.numStart = new System.Windows.Forms.NumericUpDown();
            this.btnRead = new System.Windows.Forms.Button();
            this.tabPageHttpPost = new System.Windows.Forms.TabPage();
            this.btnHttpPost = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxParam_url = new System.Windows.Forms.TextBox();
            this.btnSdk = new System.Windows.Forms.Button();
            this.tabCtl.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.tabPageDatabasesInfo.SuspendLayout();
            this.tabPageSaveData.SuspendLayout();
            this.tabPageQueryData.SuspendLayout();
            this.tabPageReadFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
            this.tabPageHttpPost.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxQueryResult
            // 
            this.tbxQueryResult.Location = new System.Drawing.Point(5, 135);
            this.tbxQueryResult.Multiline = true;
            this.tbxQueryResult.Name = "tbxQueryResult";
            this.tbxQueryResult.Size = new System.Drawing.Size(617, 223);
            this.tbxQueryResult.TabIndex = 8;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(263, 75);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(246, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGetBds
            // 
            this.btnGetBds.Location = new System.Drawing.Point(274, 29);
            this.btnGetBds.Name = "btnGetBds";
            this.btnGetBds.Size = new System.Drawing.Size(75, 23);
            this.btnGetBds.TabIndex = 11;
            this.btnGetBds.Text = "获取数据库信息";
            this.btnGetBds.UseVisualStyleBackColor = true;
            this.btnGetBds.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "数据库信息:";
            // 
            // tbxDbsInfo
            // 
            this.tbxDbsInfo.Location = new System.Drawing.Point(22, 76);
            this.tbxDbsInfo.Multiline = true;
            this.tbxDbsInfo.Name = "tbxDbsInfo";
            this.tbxDbsInfo.Size = new System.Drawing.Size(596, 128);
            this.tbxDbsInfo.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "查询结果:";
            // 
            // tbxSqlQuery
            // 
            this.tbxSqlQuery.Location = new System.Drawing.Point(87, 31);
            this.tbxSqlQuery.Name = "tbxSqlQuery";
            this.tbxSqlQuery.Size = new System.Drawing.Size(470, 21);
            this.tbxSqlQuery.TabIndex = 14;
            this.tbxSqlQuery.Text = "select * from test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "SQL语句:";
            // 
            // tabCtl
            // 
            this.tabCtl.Controls.Add(this.tabPageConnection);
            this.tabCtl.Controls.Add(this.tabPageDatabasesInfo);
            this.tabCtl.Controls.Add(this.tabPageSaveData);
            this.tabCtl.Controls.Add(this.tabPageQueryData);
            this.tabCtl.Controls.Add(this.tabPageReadFile);
            this.tabCtl.Controls.Add(this.tabPageHttpPost);
            this.tabCtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtl.Location = new System.Drawing.Point(0, 0);
            this.tabCtl.Name = "tabCtl";
            this.tabCtl.SelectedIndex = 0;
            this.tabCtl.Size = new System.Drawing.Size(634, 392);
            this.tabCtl.TabIndex = 16;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.btnSdk);
            this.tabPageConnection.Controls.Add(this.btnPing);
            this.tabPageConnection.Controls.Add(this.btnReset);
            this.tabPageConnection.Controls.Add(this.tbxUsername);
            this.tabPageConnection.Controls.Add(this.tbxPassword);
            this.tabPageConnection.Controls.Add(this.tbxBaseUrl);
            this.tabPageConnection.Controls.Add(this.label6);
            this.tabPageConnection.Controls.Add(this.label5);
            this.tabPageConnection.Controls.Add(this.label4);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(626, 366);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "数据库连接信息";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(272, 233);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 23);
            this.btnPing.TabIndex = 13;
            this.btnPing.Text = "Ping服务";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_ClickAsync);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(161, 233);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(143, 94);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(278, 21);
            this.tbxUsername.TabIndex = 5;
            this.tbxUsername.Text = "admin";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(143, 147);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(278, 21);
            this.tbxPassword.TabIndex = 4;
            this.tbxPassword.Text = "admin";
            // 
            // tbxBaseUrl
            // 
            this.tbxBaseUrl.Location = new System.Drawing.Point(143, 47);
            this.tbxBaseUrl.Name = "tbxBaseUrl";
            this.tbxBaseUrl.Size = new System.Drawing.Size(278, 21);
            this.tbxBaseUrl.TabIndex = 3;
            this.tbxBaseUrl.Text = "http://172.16.9.229:8086";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "密码:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "用户名:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "基础连接地址:";
            // 
            // tabPageDatabasesInfo
            // 
            this.tabPageDatabasesInfo.Controls.Add(this.label1);
            this.tabPageDatabasesInfo.Controls.Add(this.btnGetBds);
            this.tabPageDatabasesInfo.Controls.Add(this.tbxDbsInfo);
            this.tabPageDatabasesInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageDatabasesInfo.Name = "tabPageDatabasesInfo";
            this.tabPageDatabasesInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDatabasesInfo.Size = new System.Drawing.Size(626, 366);
            this.tabPageDatabasesInfo.TabIndex = 1;
            this.tabPageDatabasesInfo.Text = "数据库信息";
            this.tabPageDatabasesInfo.UseVisualStyleBackColor = true;
            // 
            // tabPageSaveData
            // 
            this.tabPageSaveData.Controls.Add(this.label8);
            this.tabPageSaveData.Controls.Add(this.tbxDbSave);
            this.tabPageSaveData.Controls.Add(this.tbxSqlWrite);
            this.tabPageSaveData.Controls.Add(this.btnSave);
            this.tabPageSaveData.Location = new System.Drawing.Point(4, 22);
            this.tabPageSaveData.Name = "tabPageSaveData";
            this.tabPageSaveData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSaveData.Size = new System.Drawing.Size(626, 366);
            this.tabPageSaveData.TabIndex = 2;
            this.tabPageSaveData.Text = "保存数据";
            this.tabPageSaveData.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "数据库名称:";
            // 
            // tbxDbSave
            // 
            this.tbxDbSave.Location = new System.Drawing.Point(120, 40);
            this.tbxDbSave.Name = "tbxDbSave";
            this.tbxDbSave.Size = new System.Drawing.Size(167, 21);
            this.tbxDbSave.TabIndex = 11;
            this.tbxDbSave.Text = "rtvsweb";
            // 
            // tbxSqlWrite
            // 
            this.tbxSqlWrite.Location = new System.Drawing.Point(24, 101);
            this.tbxSqlWrite.Multiline = true;
            this.tbxSqlWrite.Name = "tbxSqlWrite";
            this.tbxSqlWrite.Size = new System.Drawing.Size(539, 108);
            this.tbxSqlWrite.TabIndex = 7;
            this.tbxSqlWrite.Text = "test,type=logs Field0=10,Field1=10,Field2=20";
            // 
            // tabPageQueryData
            // 
            this.tabPageQueryData.Controls.Add(this.label9);
            this.tabPageQueryData.Controls.Add(this.tbxDbQuery);
            this.tabPageQueryData.Controls.Add(this.tbxSqlQuery);
            this.tabPageQueryData.Controls.Add(this.label2);
            this.tabPageQueryData.Controls.Add(this.btnQuery);
            this.tabPageQueryData.Controls.Add(this.tbxQueryResult);
            this.tabPageQueryData.Controls.Add(this.label3);
            this.tabPageQueryData.Location = new System.Drawing.Point(4, 22);
            this.tabPageQueryData.Name = "tabPageQueryData";
            this.tabPageQueryData.Size = new System.Drawing.Size(626, 366);
            this.tabPageQueryData.TabIndex = 3;
            this.tabPageQueryData.Text = "查询数据";
            this.tabPageQueryData.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "数据库名称:";
            // 
            // tbxDbQuery
            // 
            this.tbxDbQuery.Location = new System.Drawing.Point(87, 6);
            this.tbxDbQuery.Name = "tbxDbQuery";
            this.tbxDbQuery.Size = new System.Drawing.Size(204, 21);
            this.tbxDbQuery.TabIndex = 16;
            this.tbxDbQuery.Text = "rtvsweb";
            // 
            // tabPageReadFile
            // 
            this.tabPageReadFile.Controls.Add(this.tbxFilePath);
            this.tabPageReadFile.Controls.Add(this.label11);
            this.tabPageReadFile.Controls.Add(this.tbxReadResult);
            this.tabPageReadFile.Controls.Add(this.label10);
            this.tabPageReadFile.Controls.Add(this.numEnd);
            this.tabPageReadFile.Controls.Add(this.numStart);
            this.tabPageReadFile.Controls.Add(this.btnRead);
            this.tabPageReadFile.Location = new System.Drawing.Point(4, 22);
            this.tabPageReadFile.Name = "tabPageReadFile";
            this.tabPageReadFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReadFile.Size = new System.Drawing.Size(626, 366);
            this.tabPageReadFile.TabIndex = 4;
            this.tabPageReadFile.Text = "读文件行";
            this.tabPageReadFile.UseVisualStyleBackColor = true;
            // 
            // tbxFilePath
            // 
            this.tbxFilePath.Location = new System.Drawing.Point(176, 16);
            this.tbxFilePath.Name = "tbxFilePath";
            this.tbxFilePath.Size = new System.Drawing.Size(278, 21);
            this.tbxFilePath.TabIndex = 24;
            this.tbxFilePath.Click += new System.EventHandler(this.tbxFilePath_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "文件路径:";
            // 
            // tbxReadResult
            // 
            this.tbxReadResult.Location = new System.Drawing.Point(28, 107);
            this.tbxReadResult.Multiline = true;
            this.tbxReadResult.Name = "tbxReadResult";
            this.tbxReadResult.Size = new System.Drawing.Size(577, 241);
            this.tbxReadResult.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "读文件开启和结束行:";
            // 
            // numEnd
            // 
            this.numEnd.Location = new System.Drawing.Point(334, 64);
            this.numEnd.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numEnd.Name = "numEnd";
            this.numEnd.Size = new System.Drawing.Size(120, 21);
            this.numEnd.TabIndex = 20;
            this.numEnd.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numStart
            // 
            this.numStart.Location = new System.Drawing.Point(176, 64);
            this.numStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStart.Name = "numStart";
            this.numStart.Size = new System.Drawing.Size(120, 21);
            this.numStart.TabIndex = 19;
            this.numStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(489, 64);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 18;
            this.btnRead.Text = "读取指定行数据";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // tabPageHttpPost
            // 
            this.tabPageHttpPost.Controls.Add(this.tbxParam_url);
            this.tabPageHttpPost.Controls.Add(this.label7);
            this.tabPageHttpPost.Controls.Add(this.btnHttpPost);
            this.tabPageHttpPost.Location = new System.Drawing.Point(4, 22);
            this.tabPageHttpPost.Name = "tabPageHttpPost";
            this.tabPageHttpPost.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHttpPost.Size = new System.Drawing.Size(626, 366);
            this.tabPageHttpPost.TabIndex = 5;
            this.tabPageHttpPost.Text = "测试HttpPost";
            this.tabPageHttpPost.UseVisualStyleBackColor = true;
            // 
            // btnHttpPost
            // 
            this.btnHttpPost.Location = new System.Drawing.Point(205, 121);
            this.btnHttpPost.Name = "btnHttpPost";
            this.btnHttpPost.Size = new System.Drawing.Size(133, 23);
            this.btnHttpPost.TabIndex = 0;
            this.btnHttpPost.Text = "发起Post请求";
            this.btnHttpPost.UseVisualStyleBackColor = true;
            this.btnHttpPost.Click += new System.EventHandler(this.btnHttpPost_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Http URL:";
            // 
            // tbxParam_url
            // 
            this.tbxParam_url.Location = new System.Drawing.Point(100, 47);
            this.tbxParam_url.Name = "tbxParam_url";
            this.tbxParam_url.Size = new System.Drawing.Size(369, 21);
            this.tbxParam_url.TabIndex = 2;
            this.tbxParam_url.Text = "http://localhost:5000/WebService/Test";
            // 
            // btnSdk
            // 
            this.btnSdk.Location = new System.Drawing.Point(398, 233);
            this.btnSdk.Name = "btnSdk";
            this.btnSdk.Size = new System.Drawing.Size(75, 23);
            this.btnSdk.TabIndex = 14;
            this.btnSdk.Text = "SDK测试";
            this.btnSdk.UseVisualStyleBackColor = true;
            this.btnSdk.Click += new System.EventHandler(this.btnSdk_Click);
            // 
            // FormHttpTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 392);
            this.Controls.Add(this.tabCtl);
            this.Name = "FormHttpTest";
            this.Text = "FormHttpTest";
            this.Load += new System.EventHandler(this.FormHttpTest_Load);
            this.tabCtl.ResumeLayout(false);
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            this.tabPageDatabasesInfo.ResumeLayout(false);
            this.tabPageDatabasesInfo.PerformLayout();
            this.tabPageSaveData.ResumeLayout(false);
            this.tabPageSaveData.PerformLayout();
            this.tabPageQueryData.ResumeLayout(false);
            this.tabPageQueryData.PerformLayout();
            this.tabPageReadFile.ResumeLayout(false);
            this.tabPageReadFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
            this.tabPageHttpPost.ResumeLayout(false);
            this.tabPageHttpPost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbxQueryResult;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGetBds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDbsInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSqlQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabCtl;
        private System.Windows.Forms.TabPage tabPageDatabasesInfo;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.TabPage tabPageSaveData;
        private System.Windows.Forms.TextBox tbxSqlWrite;
        private System.Windows.Forms.TabPage tabPageQueryData;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxBaseUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxDbSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxDbQuery;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.TabPage tabPageReadFile;
        private System.Windows.Forms.TextBox tbxReadResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numEnd;
        private System.Windows.Forms.NumericUpDown numStart;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox tbxFilePath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPageHttpPost;
        private System.Windows.Forms.TextBox tbxParam_url;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHttpPost;
        private System.Windows.Forms.Button btnSdk;
    }
}