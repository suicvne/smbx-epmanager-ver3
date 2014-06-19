using MetroFramework.Forms;
using Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpisodeManager_WinForms
{
    public partial class Main_NEW : MetroForm
    {
        IniFile settingsIni = new IniFile(Environment.CurrentDirectory + @"\settings.ini");
        public static string forumLink;
        public static string serverUrl;
        public static Image bgImage;
        public static int availVer;
        public static int epVer;
        public static string selectedFolderName;
        public static string smbxDir;
        public static string smbxExeLoc;
        public static string smbxWorldsDir;


        public Main_NEW()
        {
            InitializeComponent();
        }

        private void Main_NEW_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            localEpisodes.updateCheckSpinner.Visible = false;
            localEpisodes.epInfoPanel.BackgroundImage = null;
            localEpisodes.episodeNameLabel.Text = "";
            localEpisodes.descLabel.Text = "";
            localEpisodes.authorName.Text = "";
            localEpisodes.ss1.BackgroundImage = null;
            localEpisodes.ss2.BackgroundImage = null;
            localEpisodes.ss3.BackgroundImage = null;
            localEpisodes.ss4.BackgroundImage = null;
            localEpisodes.iconFrame.Visible = false;
            localEpisodes.iconPicture.Visible = false;
            writeInitialIni();
            writeInitialPaths();
            smbxWorldsDir = settingsIni.ReadValue("Settings", "worldlocation");
            smbxDir = settingsIni.ReadValue("Settings", "smbxpath");
            smbxExeLoc = settingsIni.ReadValue("Settings", "executableloc");
            //
            //settingspanelloading
            populateListView();
            localEpisodes.localEpisodesListview.Focus();
            localEpisodes.localEpisodesListview.Items[0].Selected = true;
        }
        
        private void writeInitialIni()
        {
            if (File.Exists(Environment.CurrentDirectory + @"\settings.ini") != true)
            {
                settingsIni.WriteValue("Settings", "worldlocation", @"C:\SMBX\worlds");
                settingsIni.WriteValue("Settings", "smbxpath", @"C:\SMBX\");
                settingsIni.WriteValue("Settings", "executableloc", @"C:\SMBX\smbx.exe");
            }
        }
        private void writeInitialPaths()
        {
            try
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\temp");
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\temp\Update");
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\temp\ZipReading");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void populateListView()
        {
            localEpisodes.localEpisodesListview.Items.Clear();
            ListViewItem lvi = new ListViewItem();
            DirectoryInfo dinfo = new DirectoryInfo(smbxWorldsDir);
            try
            {
                foreach (var d in dinfo.GetDirectories())
                {
                    lvi = new ListViewItem();
                    lvi.Text = d.ToString();
                    localEpisodes.localEpisodesListview.Items.Add(lvi);
                }
            }
            catch(DirectoryNotFoundException dx)
            {
                localEpisodes.localEpisodesListview.Items.Clear();
                MessageBox.Show("Directory not found: " + smbxWorldsDir + "\nPlease configure the proper SMBX Directories\n\n" + dx.Message, 
                    "Error!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                

            }
            
        }

        private void localEpisodes_Load(object sender, EventArgs e)
        {

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm(this);
            sf.ShowDialog();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

    }
}
