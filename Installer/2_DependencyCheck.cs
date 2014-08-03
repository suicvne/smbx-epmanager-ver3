
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;


namespace Installer
{
    public partial class _2_DependencyCheck : Form
    {
        bool isConnected;
        bool newestNet;

        public _2_DependencyCheck()
        {
            InitializeComponent();
        }

        private void _2_DependencyCheck_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;

            worker.RunWorkerAsync();

            checkNetVersion();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            internetConnectionSpinner.Visible = true;

            if(CheckForInternetConnection() == true)
            {
                internetConnection.Checked = true;
                isConnected = true;
            }
            else
            {
                isConnected = false;
                internetConnection.Checked = false;
                label1.Text = "Internet Connection Check Failed";
                label1.ForeColor = Color.DarkRed;
            }

            internetConnectionSpinner.Visible = false;

            if (isConnected == true)
            {
                if (newestNet == true)
                {
                    nextButton.Enabled = true;
                }
            }
        }

        void checkNetVersion()
        {
            /*try
            {
                using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine,
                        RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\"))
                {
                    int releaseKey = (int)ndpKey.GetValue("Release");
                    {
                        if (releaseKey == 378389)
                        {
                            Console.WriteLine("The .NET Framework version 4.5 is installed");
                            label2.Text = ".NET Framework Version 4.5 Installed. Please Update";
                            label2.ForeColor = Color.DarkRed;
                            linkLabel1.Visible = true;
                        }
                        else if (releaseKey == 378758)
                        {
                            Console.WriteLine("The .NET Framework version 4.5.1  is installed");
                            label2.Text = ".NET Framework 4.5.1 Installed";
                            netInstalled.Checked = true;
                            newestNet = true;
                        }
                        else if (releaseKey == 378675)
                        {
                            Console.WriteLine("The .NET Framework version 4.5.1  is installed");
                            label2.Text = ".NET Framework 4.5.1 Installed";
                            netInstalled.Checked = true;
                            newestNet = true;
                        }
                        else if (releaseKey == 379893)
                        {
                            Console.WriteLine(".NET Framework version 4.5.2+ is installed");
                            label2.Text = ".NET Framework 4.5.2 Installed";
                            netInstalled.Checked = true;
                            newestNet = true;
                        }
                        else
                        {
                            Console.WriteLine("Unknown version");
                            label2.Text = "Please install .NET Framwork 4.5.1 or higher.";
                            label2.ForeColor = Color.DarkRed;
                            linkLabel1.Visible = true;
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }*/
            earlier();
        }

        void earlier()
        {
            using (RegistryKey ndpKey =
            RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, "").
            OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
            {
                // As an alternative, if you know the computers you will query are running .NET Framework 4.5  
                // or later, you can use: 
                // using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine,  
                // RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
                foreach (string versionKeyName in ndpKey.GetSubKeyNames())
                {
                    if (versionKeyName.StartsWith("v"))
                    {
                        if(versionKeyName == ("v4"))
                        {
                            Console.WriteLine("v4 installed!");
                            netInstalled.Checked = true;
                            newestNet = true;
                        }
                    }
                }
            }
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want to quit the installer?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Yes:
                    Environment.Exit(0);
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            _3_ActualInstaller install = new _3_ActualInstaller();
            install.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.microsoft.com/en-us/download/details.aspx?id=17851");
        }
    }
}
