using MetroFramework.Forms;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpisodeManager_WinForms
{
    public partial class Changelog : MetroForm
    {
        string curVer { get; set; }
        string newVer { get; set; }

        public Changelog(string currentVer, string newestVer)
        {
            curVer = currentVer;
            newVer = newestVer;
            InitializeComponent();
        }

        private void Changelog_Load(object sender, EventArgs e)
        {
            currentVersionLabel.Text = "Your Version: " + curVer;
            availableVersionLabel.Text = "Newest Version: " + newVer;
            Computer myComputer = new Computer();
            myComputer.Network.DownloadFile("http://mrmiketheripper.x10.mx/epmanager3/changelog.rtf", Environment.CurrentDirectory + @"\temp\changelog.rtf", null, null, false, 10000, true);
            changelogTextBox.LoadFile(Environment.CurrentDirectory + @"\temp\changelog.rtf");
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
