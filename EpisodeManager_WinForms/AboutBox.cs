using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Diagnostics;
using System.Reflection;

namespace EpisodeManager_WinForms
{
    public partial class AboutBox : MetroForm
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fileVersionInfo.ProductVersion;
            metroLabel3.Text = version;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Process.Start("http://supermariobrosx.org/forums/");
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Process.Start("http://icons8.com/");
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Process.Start("http://thielj.github.io/MetroFramework/");
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Luigifan/smbx-epmanager-ver3");
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Process.Start("http://twitter.com/basedcoregod");
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Process.Start("http://smbxepmanager.tumblr.com/");
        }
    }
}
