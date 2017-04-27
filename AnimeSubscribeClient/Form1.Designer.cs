namespace AnimeSubscribeClient
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowserDownloadPath = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDownTool = new System.Windows.Forms.ComboBox();
            this.fbdDownloadPath = new System.Windows.Forms.FolderBrowserDialog();
            this.txtDownToolPath = new System.Windows.Forms.TextBox();
            this.txtDownToolPass = new System.Windows.Forms.TextBox();
            this.txtDownToolUser = new System.Windows.Forms.TextBox();
            this.txtDownToolPort = new System.Windows.Forms.TextBox();
            this.txtDownToolHost = new System.Windows.Forms.TextBox();
            this.txtServerToken = new System.Windows.Forms.TextBox();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mShowOrHide = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtServerToken);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtServerAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Token";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "地址";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 368);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(60, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowserDownloadPath);
            this.groupBox2.Controls.Add(this.txtDownToolPath);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDownToolPass);
            this.groupBox2.Controls.Add(this.txtDownToolUser);
            this.groupBox2.Controls.Add(this.txtDownToolPort);
            this.groupBox2.Controls.Add(this.txtDownToolHost);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbDownTool);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "下载工具";
            // 
            // btnBrowserDownloadPath
            // 
            this.btnBrowserDownloadPath.Location = new System.Drawing.Point(177, 201);
            this.btnBrowserDownloadPath.Name = "btnBrowserDownloadPath";
            this.btnBrowserDownloadPath.Size = new System.Drawing.Size(17, 21);
            this.btnBrowserDownloadPath.TabIndex = 13;
            this.btnBrowserDownloadPath.Text = "B";
            this.btnBrowserDownloadPath.UseVisualStyleBackColor = true;
            this.btnBrowserDownloadPath.Click += new System.EventHandler(this.btnBrowserDownloadPath_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "下载路径";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "用户名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "端口";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "地址";
            // 
            // cbDownTool
            // 
            this.cbDownTool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDownTool.FormattingEnabled = true;
            this.cbDownTool.Items.AddRange(new object[] {
            "qBittorrent"});
            this.cbDownTool.Location = new System.Drawing.Point(8, 20);
            this.cbDownTool.Name = "cbDownTool";
            this.cbDownTool.Size = new System.Drawing.Size(186, 20);
            this.cbDownTool.TabIndex = 2;
            // 
            // txtDownToolPath
            // 
            this.txtDownToolPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AnimeSubscribeClient.Properties.Settings.Default, "DownPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDownToolPath.Location = new System.Drawing.Point(65, 201);
            this.txtDownToolPath.Name = "txtDownToolPath";
            this.txtDownToolPath.Size = new System.Drawing.Size(106, 21);
            this.txtDownToolPath.TabIndex = 12;
            this.txtDownToolPath.Text = global::AnimeSubscribeClient.Properties.Settings.Default.DownPath;
            // 
            // txtDownToolPass
            // 
            this.txtDownToolPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AnimeSubscribeClient.Properties.Settings.Default, "DownPass", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDownToolPass.Location = new System.Drawing.Point(65, 163);
            this.txtDownToolPass.Name = "txtDownToolPass";
            this.txtDownToolPass.PasswordChar = '*';
            this.txtDownToolPass.Size = new System.Drawing.Size(129, 21);
            this.txtDownToolPass.TabIndex = 10;
            this.txtDownToolPass.Text = global::AnimeSubscribeClient.Properties.Settings.Default.DownPass;
            // 
            // txtDownToolUser
            // 
            this.txtDownToolUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AnimeSubscribeClient.Properties.Settings.Default, "DownUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDownToolUser.Location = new System.Drawing.Point(65, 127);
            this.txtDownToolUser.Name = "txtDownToolUser";
            this.txtDownToolUser.Size = new System.Drawing.Size(129, 21);
            this.txtDownToolUser.TabIndex = 9;
            this.txtDownToolUser.Text = global::AnimeSubscribeClient.Properties.Settings.Default.DownUser;
            // 
            // txtDownToolPort
            // 
            this.txtDownToolPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AnimeSubscribeClient.Properties.Settings.Default, "DownPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDownToolPort.Location = new System.Drawing.Point(65, 91);
            this.txtDownToolPort.Name = "txtDownToolPort";
            this.txtDownToolPort.Size = new System.Drawing.Size(129, 21);
            this.txtDownToolPort.TabIndex = 8;
            this.txtDownToolPort.Text = global::AnimeSubscribeClient.Properties.Settings.Default.DownPort;
            // 
            // txtDownToolHost
            // 
            this.txtDownToolHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AnimeSubscribeClient.Properties.Settings.Default, "DownHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDownToolHost.Location = new System.Drawing.Point(65, 55);
            this.txtDownToolHost.Name = "txtDownToolHost";
            this.txtDownToolHost.Size = new System.Drawing.Size(129, 21);
            this.txtDownToolHost.TabIndex = 7;
            this.txtDownToolHost.Text = global::AnimeSubscribeClient.Properties.Settings.Default.DownHost;
            // 
            // txtServerToken
            // 
            this.txtServerToken.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AnimeSubscribeClient.Properties.Settings.Default, "Token", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtServerToken.Location = new System.Drawing.Point(53, 65);
            this.txtServerToken.Name = "txtServerToken";
            this.txtServerToken.PasswordChar = '*';
            this.txtServerToken.Size = new System.Drawing.Size(141, 21);
            this.txtServerToken.TabIndex = 4;
            this.txtServerToken.Text = global::AnimeSubscribeClient.Properties.Settings.Default.Token;
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AnimeSubscribeClient.Properties.Settings.Default, "ServerAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtServerAddress.Location = new System.Drawing.Point(53, 26);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(141, 21);
            this.txtServerAddress.TabIndex = 2;
            this.txtServerAddress.Text = global::AnimeSubscribeClient.Properties.Settings.Default.ServerAddress;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "新番订阅(已停止)";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mShowOrHide,
            this.mQuit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 48);
            // 
            // mQuit
            // 
            this.mQuit.Name = "mQuit";
            this.mQuit.Size = new System.Drawing.Size(144, 22);
            this.mQuit.Text = "退出(&q)";
            this.mQuit.Click += new System.EventHandler(this.mQuit_Click);
            // 
            // mShowOrHide
            // 
            this.mShowOrHide.Name = "mShowOrHide";
            this.mShowOrHide.Size = new System.Drawing.Size(144, 22);
            this.mShowOrHide.Text = "显示/隐藏(&h)";
            this.mShowOrHide.Click += new System.EventHandler(this.mShowOrHide_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(78, 368);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(60, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(165, 373);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(41, 12);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "已停止";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 403);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新番订阅";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtServerToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDownTool;
        private System.Windows.Forms.TextBox txtDownToolPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDownToolPass;
        private System.Windows.Forms.TextBox txtDownToolUser;
        private System.Windows.Forms.TextBox txtDownToolPort;
        private System.Windows.Forms.TextBox txtDownToolHost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowserDownloadPath;
        private System.Windows.Forms.FolderBrowserDialog fbdDownloadPath;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mQuit;
        private System.Windows.Forms.ToolStripMenuItem mShowOrHide;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbStatus;
    }
}

