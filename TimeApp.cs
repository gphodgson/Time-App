using System;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;
using TimeApp.src;

namespace TimeApp
{
    public partial class TimeApp : Form
    {
        static HttpClient http = new HttpClient();
        static ManualResetEvent mrse = new ManualResetEvent(false);

        Thread updateThread = new Thread(new ThreadStart(updateLoop));
        bool startup = true;

        public TimeApp()
        {
            InitializeComponent();
            if (System.Configuration.ConfigurationManager.AppSettings["runOnStartUp"] == "true") 
            {
                btnUpdateTime_Click(this, null);
                chkRunOnStartUp.Checked = true;
                lblUpdating.Visible = true;
            }

            if (System.Configuration.ConfigurationManager.AppSettings["minimizeOnStartUp"] == "true")
            {
                this.WindowState = FormWindowState.Minimized;
                Hide();
                chkMiniOnStartUP.Checked = true;
            }

            if (System.Configuration.ConfigurationManager.AppSettings["firstTimeSetup"] == "true")
            {
                FirstTimeSetup setup = new FirstTimeSetup();
                setup.ShowDialog();
            }

            startup = false;
        }


        private static async void updateLoop() 
        {
            while(true)
            {
                try
                {
                    mrse.WaitOne();
                    EventRequest timeEvent = new EventRequest();
                    TimeResponse response = await timeEvent.sendRequest(http);
                    Thread.Sleep(1000);
                }
                catch (Exception) {}
            }
        }

        private void btnUpdateTime_Click(object sender, EventArgs e)
        {
            try
            {
                updateThread.Start();
                mrse.Set();
            }
            catch (Exception) 
            {
                mrse.Set();
            }

            btnStopUpdate.Enabled = true;
            btnUpdateTime.Enabled = false;
            lblUpdating.Visible = true;
        }

        private void btnStopUpdate_Click(object sender, EventArgs e)
        {
            mrse.Reset();

            btnStopUpdate.Enabled = false;
            btnUpdateTime.Enabled = true;
            lblUpdating.Visible = false;
        }

        private void TimeApp_Resize(object sender, EventArgs e)
        {
            Hide();
            ntfyIcon.Visible = true;
        }

        private void ntfyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            ntfyIcon.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void chkRunOnStartUp_CheckedChanged(object sender, EventArgs e)
        {
            if(!startup)
                Helper.configOnOff("runOnStartUp");
        }

        private void chkMiniOnStartUP_CheckedChanged(object sender, EventArgs e)
        {
            if(!startup)
                Helper.configOnOff("minimizeOnStartUp");
        }

        private void runFirstTimeSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstTimeSetup setup = new FirstTimeSetup();
            setup.ShowDialog();
        }

        private void stopUpdatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUpdateTime_Click(this, null);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
