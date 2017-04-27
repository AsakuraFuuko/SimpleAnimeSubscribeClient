using AnimeSubscribeClient.plugins;
using AnimeSubscribeClient.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeSubscribeClient
{
    public partial class Form1 : Form
    {
        private Watcher watcher = null;
        private DownloadTool tool = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        public void Init()
        {
            cbDownTool.SelectedIndex = 0;

            this.Visible = false;
            this.ShowInTaskbar = false;
        }

        public void InitOther()
        {
            if (tool == null)
            {
                tool = new QBittorrent(Settings.Default.DownHost, int.Parse(Settings.Default.DownPort), Settings.Default.DownUser, Settings.Default.DownPass);
            }
            watcher = new Watcher(Settings.Default.ServerAddress, Settings.Default.Token, Settings.Default.DownPath, tool);
        }

        private void btnBrowserDownloadPath_Click(object sender, EventArgs e)
        {
            if (fbdDownloadPath.ShowDialog() == DialogResult.OK)
            {
                txtDownToolPath.Text = fbdDownloadPath.SelectedPath;
            }
        }

        private void CheckFirstRun()
        {
            if (Settings.Default.FirstRun)
            {
                this.Visible = true;
            }
            else
            {
                this.Hide();
                InitOther();
                watcher.Start();
                SetStatus();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            CheckFirstRun();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            e.Cancel = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowOrHide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Settings.Default.FirstRun = false;
            Settings.Default.Save();

            InitOther();
            watcher.Start();
            SetStatus();
        }

        private void SetStatus()
        {
            if (watcher != null)
            {
                var status = watcher.IsRunuing;
                this.btnStart.Enabled = !status;
                this.btnStop.Enabled = status;
                this.lbStatus.Text = status ? "运行中" : "已停止";
                this.notifyIcon1.Text = "新番订阅(" + (status ? "运行中" : "已停止") + ")";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            watcher.Stop();
            SetStatus();
        }

        private void mShowOrHide_Click(object sender, EventArgs e)
        {
            ShowOrHide();
        }

        private void ShowOrHide()
        {
            this.Visible = !this.Visible;
            if (this.Visible)
            {
                this.Activate();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void mQuit_Click(object sender, EventArgs e)
        {
            if (watcher != null)
            {
                watcher.Stop();
            }

            Settings.Default.Save();
            Environment.Exit(0);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }
    }
}