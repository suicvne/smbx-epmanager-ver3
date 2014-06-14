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
using Setting;
using System.Diagnostics;
using System.IO;

namespace EpisodeManager_WinForms
{
    public partial class SettingsForm : MetroForm
    {
        public SettingsForm(Main_NEW _Main_NEW)
        {
            mf = _Main_NEW;
            InitializeComponent();
        }

        Main_NEW mf { get; set; }
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
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            smbxPathTb.Text = Main_NEW.smbxDir;
            worldPathTb.Text = Main_NEW.smbxWorldsDir;
            execLocTb.Text = Main_NEW.smbxExeLoc;

            if (File.Exists(Main_NEW.smbxExeLoc) == true)
            {
                smbxversionlabel.Text = "SMBX Found: " + GetFileVersionInfo(Main_NEW.smbxExeLoc).ToString();
                smbxversionlabel.ForeColor = Color.DarkGreen;
            }
            else
            {
                smbxversionlabel.Text = "Couldn't find SMBX!";
                smbxversionlabel.ForeColor = Color.DarkRed;
            }
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
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
            
            //populateListView
            MessageBox.Show("Settings saved sucessfully!");
            mf.populateListView();
            this.Close();
        }
        public void populateListView()
        {
            Main_NEW main = new Main_NEW();

            main.localEpisodes.localEpisodesListview.Items.Clear();
            ListViewItem lvi = new ListViewItem();
            DirectoryInfo dinfo = new DirectoryInfo(Main_NEW.smbxWorldsDir);
            try
            {
                foreach (var d in dinfo.GetDirectories())
                {
                    lvi = new ListViewItem();
                    lvi.Text = d.ToString();
                    main.localEpisodes.localEpisodesListview.Items.Add(lvi);
                }
            }
            catch (DirectoryNotFoundException dx)
            {
                main.localEpisodes.localEpisodesListview.Items.Clear();
                MessageBox.Show("Directory not found: " + Main_NEW.smbxWorldsDir + "\nPlease configure the proper SMBX Directories\n\n" + dx.Message,
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);


            }

        }
        private void metroButton2_Click_1(object sender, EventArgs e)
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

        private void execLocTb_TextChanged(object sender, EventArgs e)
        {
            //check if it exists and change the version if needed.
            if (File.Exists(execLocTb.Text) == true)
            {
                smbxversionlabel.Text = "SMBX Found: " + GetFileVersionInfo(execLocTb.Text).ToString();
                smbxversionlabel.ForeColor = Color.DarkGreen;
            }
            else
            {
                smbxversionlabel.Text = "Couldn't find SMBX!";
                smbxversionlabel.ForeColor = Color.DarkRed;
            }
        }
    
    }
}
