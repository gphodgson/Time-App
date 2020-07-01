using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeApp.models;
using System.Net.Http;

namespace TimeApp
{
    public partial class FirstTimeSetup : Form
    {
        static HttpClient http = new HttpClient();

        public FirstTimeSetup()
        {
            InitializeComponent();
        }

        private async void btnRunFirstTimeSetup_Click(object sender, EventArgs e)
        {
            btnRunFirstTimeSetup.Text = "Setting up...";

            GameSetupRequest gameSetupRequest = new GameSetupRequest();
            TimeResponse gameSetupResponse = await gameSetupRequest.sendRequest(http);

            EventSetupRequest eventSetupRequest = new EventSetupRequest();
            TimeResponse eventSetupResponse = await eventSetupRequest.sendRequest(http);

            Helper.configOff("firstTimeSetup");

            Close();
        }
    }
}
