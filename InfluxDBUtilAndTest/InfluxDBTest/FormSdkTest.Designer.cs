namespace InfluxDBTest
{
    partial class FormSdkTest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCtl = new System.Windows.Forms.TabControl();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxBaseUrl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageDatabasesInfo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetBds = new System.Windows.Forms.Button();
            this.tbxDbsInfo = new System.Windows.Forms.TextBox();
            this.tabPageSaveData = new System.Windows.Forms.TabPage();
            this.tbxSqlWrite = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPageQueryData = new System.Windows.Forms.TabPage();
            this.tbxSqlQuery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.tbxQueryResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabCtl.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.tabPageDatabasesInfo.SuspendLayout();
            this.tabPageSaveData.SuspendLayout();
            this.tabPageQueryData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtl
            // 
            this.tabCtl.Controls.Add(this.tabPageConnection);
            this.tabCtl.Controls.Add(this.tabPageDatabasesInfo);
            this.tabCtl.Controls.Add(this.tabPageSaveData);
            this.tabCtl.Controls.Add(this.tabPageQueryData);
            this.tabCtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtl.Location = new System.Drawing.Point(0, 0);
            this.tabCtl.Name = "tabCtl";
            this.tabCtl.SelectedIndex = 0;
            this.tabCtl.Size = new System.Drawing.Size(638, 403);
            this.tabCtl.TabIndex = 17;
            // 
            // tabPageConnection
            // 
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
            this.tabPageConnection.Size = new System.Drawing.Size(630, 377);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "数据库连接信息";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(219, 224);
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
            this.tabPageDatabasesInfo.Size = new System.Drawing.Size(630, 377);
            this.tabPageDatabasesInfo.TabIndex = 1;
            this.tabPageDatabasesInfo.Text = "数据库信息";
            this.tabPageDatabasesInfo.UseVisualStyleBackColor = true;
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
            // btnGetBds
            // 
            this.btnGetBds.Location = new System.Drawing.Point(274, 29);
            this.btnGetBds.Name = "btnGetBds";
            this.btnGetBds.Size = new System.Drawing.Size(75, 23);
            this.btnGetBds.TabIndex = 11;
            this.btnGetBds.Text = "获取数据库信息";
            this.btnGetBds.UseVisualStyleBackColor = true;
            this.btnGetBds.Click += new System.EventHandler(this.btnGetBds_Click);
            // 
            // tbxDbsInfo
            // 
            this.tbxDbsInfo.Location = new System.Drawing.Point(22, 76);
            this.tbxDbsInfo.Multiline = true;
            this.tbxDbsInfo.Name = "tbxDbsInfo";
            this.tbxDbsInfo.Size = new System.Drawing.Size(596, 128);
            this.tbxDbsInfo.TabIndex = 12;
            // 
            // tabPageSaveData
            // 
            this.tabPageSaveData.Controls.Add(this.tbxSqlWrite);
            this.tabPageSaveData.Controls.Add(this.btnSave);
            this.tabPageSaveData.Location = new System.Drawing.Point(4, 22);
            this.tabPageSaveData.Name = "tabPageSaveData";
            this.tabPageSaveData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSaveData.Size = new System.Drawing.Size(630, 377);
            this.tabPageSaveData.TabIndex = 2;
            this.tabPageSaveData.Text = "保存数据";
            this.tabPageSaveData.UseVisualStyleBackColor = true;
            // 
            // tbxSqlWrite
            // 
            this.tbxSqlWrite.Location = new System.Drawing.Point(28, 35);
            this.tbxSqlWrite.Multiline = true;
            this.tbxSqlWrite.Name = "tbxSqlWrite";
            this.tbxSqlWrite.Size = new System.Drawing.Size(539, 108);
            this.tbxSqlWrite.TabIndex = 7;
            this.tbxSqlWrite.Text = "此处保存与HTTP方式不同请参见源码";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(245, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabPageQueryData
            // 
            this.tabPageQueryData.Controls.Add(this.tbxSqlQuery);
            this.tabPageQueryData.Controls.Add(this.label2);
            this.tabPageQueryData.Controls.Add(this.btnQuery);
            this.tabPageQueryData.Controls.Add(this.tbxQueryResult);
            this.tabPageQueryData.Controls.Add(this.label3);
            this.tabPageQueryData.Location = new System.Drawing.Point(4, 22);
            this.tabPageQueryData.Name = "tabPageQueryData";
            this.tabPageQueryData.Size = new System.Drawing.Size(630, 377);
            this.tabPageQueryData.TabIndex = 3;
            this.tabPageQueryData.Text = "查询数据";
            this.tabPageQueryData.UseVisualStyleBackColor = true;
            // 
            // tbxSqlQuery
            // 
            this.tbxSqlQuery.Location = new System.Drawing.Point(68, 31);
            this.tbxSqlQuery.Name = "tbxSqlQuery";
            this.tbxSqlQuery.Size = new System.Drawing.Size(470, 21);
            this.tbxSqlQuery.TabIndex = 14;
            this.tbxSqlQuery.Text = "select * from logs";
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
            // tbxQueryResult
            // 
            this.tbxQueryResult.Location = new System.Drawing.Point(5, 135);
            this.tbxQueryResult.Multiline = true;
            this.tbxQueryResult.Name = "tbxQueryResult";
            this.tbxQueryResult.Size = new System.Drawing.Size(617, 223);
            this.tbxQueryResult.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "SQL语句:";
            // 
            // FormSdkTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 403);
            this.Controls.Add(this.tabCtl);
            this.Name = "FormSdkTest";
            this.Text = "FormSdkTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabCtl.ResumeLayout(false);
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            this.tabPageDatabasesInfo.ResumeLayout(false);
            this.tabPageDatabasesInfo.PerformLayout();
            this.tabPageSaveData.ResumeLayout(false);
            this.tabPageSaveData.PerformLayout();
            this.tabPageQueryData.ResumeLayout(false);
            this.tabPageQueryData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtl;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxBaseUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageDatabasesInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetBds;
        private System.Windows.Forms.TextBox tbxDbsInfo;
        private System.Windows.Forms.TabPage tabPageSaveData;
        private System.Windows.Forms.TextBox tbxSqlWrite;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabPageQueryData;
        private System.Windows.Forms.TextBox tbxSqlQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox tbxQueryResult;
        private System.Windows.Forms.Label label3;
    }
}

