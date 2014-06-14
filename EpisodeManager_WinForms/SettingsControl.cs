using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Setting;

namespace EpisodeManager_WinForms
{
    public partial class SettingsControl : UserControl
    {
        
        Main_NEW mf = new Main_NEW();

        public SettingsControl()
        {
            
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.Description = "Select the SMBX folder (not worlds)";
            if (fb.ShowDialog() == DialogResult.OK)
            {
                smbxPathTb.Text = fb.SelectedPath.ToString();
                worldPathTb.Text = fb.SelectedPath.ToString() + @"\worlds";
                execLocTb.Text = fb.SelectedPath.ToString() + @"\smbx.exe";
            }
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {
        }
        private void writeInitialIni()
        {
            IniFile settingsIni = new IniFile(Environment.CurrentDirectory + @"\settings.ini");
        
            if (File.Exists(Environment.CurrentDirectory + @"\settings.ini") != true)
            {
                settingsIni.WriteValue("Settings", "worldlocation", @"C:\SMBX\worlds");
                settingsIni.WriteValue("Settings", "smbxpath", @"C:\SMBX\");
                settingsIni.WriteValue("Settings", "executableloc", @"C:\SMBX\smbx.exe");
            }
        }
        public string GetFileVersionInfo(string fileName)
        {
            if (File.Exists(fileName))
            {
                var versionInfo = FileVersionInfo.GetVersionInfo(fileName);
                string version = versionInfo.ProductVersion;

                return version;
            }
            else
            {
                return "null";
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            IniFile settingsIni = new IniFile(Environment.CurrentDirectory + @"\settings.ini");
        
            if (smbxPathTb.Text != null)
            {
                settingsIni.WriteValue("Settings", "smbxpath", smbxPathTb.Text);
            }

            if (worldPathTb.Text != null)
            {
                settingsIni.WriteValue("Settings", "worldlocation", worldPathTb.Text);
            }
            
            if (execLocTb.Text != null)
            {
                settingsIni.WriteValue("Settings", "executableloc", execLocTb.Text);
            }
            Main_NEW.smbxExeLoc = execLocTb.Text;
            Main_NEW.smbxWorldsDir = worldPathTb.Text;
            Main_NEW.smbxDir = smbxPathTb.Text;
            mf.populateListView();
            //populateListView
            MessageBox.Show("Settings saved sucessfully!");
        }
    }
}
