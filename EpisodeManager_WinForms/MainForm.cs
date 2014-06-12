using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Components;
using MetroFramework.Interfaces;
using Setting;
using IndexReader;
using System.IO;
using EpisodeManager_WinForms;
using System.Diagnostics;


namespace EpisodeManager_WinForms
{
    public partial class MainForm : MetroForm
    {
        //import the indexreader class
        IniFile settingsIni = new IniFile(Environment.CurrentDirectory + @"\settings.ini");
        IndexReaderClass inReader = new IndexReaderClass();
        public static string forumLink;
        public static string serverUrl;
        public static string smbxDir;
        public static string smbxExeLoc;
        public static string smbxWorldsDir;
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            epInfoPanel.BackgroundImage = null;
            episodeNameLabel.Text = "";
            descriptionLabel.Text = "";
            authorName.Text = "";
            ss1.BackgroundImage = null;
            ss2.BackgroundImage = null;
            ss3.BackgroundImage = null;
            ss4.BackgroundImage = null;
            writeInitialIni();
            smbxWorldsDir = settingsIni.ReadValue("Settings", "worldlocation");
            smbxDir = settingsIni.ReadValue("Settings", "smbxpath");
            smbxExeLoc = settingsIni.ReadValue("Settings", "executableloc");
            //
            settingsPanelLoading();
            //Make sure this happens last!
            populateListView();
        }

        private void writeInitialIni()
        {
            if(File.Exists(Environment.CurrentDirectory + @"\settings.ini") != true)
            {
                settingsIni.WriteValue("Settings", "worldlocation", @"C:\SMBX\worlds");
                settingsIni.WriteValue("Settings", "smbxpath", @"C:\SMBX\");
                settingsIni.WriteValue("Settings", "executableloc", @"C:\SMBX\smbx.exe");
            }
        }

        private void populateListView()
        {
            ListViewItem lvi = new ListViewItem();
            DirectoryInfo dinfo = new DirectoryInfo(smbxWorldsDir);
            try
            {
                foreach (var d in dinfo.GetDirectories())
                {
                    lvi = new ListViewItem();
                    lvi.Text = d.ToString();
                    localEpisodesListview.Items.Add(lvi);
                }
            }
            catch(DirectoryNotFoundException dx)
            {
                MessageBox.Show("Directory not found: " + smbxWorldsDir + "\nPlease configure the proper SMBX Directories\n\n" + dx.Message, 
                    "Error!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
        }

        public void settingsPanelLoading()
        {
            smbxPathTb.Text = smbxDir;
            worldPathTb.Text = smbxWorldsDir;
            execLocTb.Text = smbxExeLoc;

            if (File.Exists(smbxExeLoc) == true)
            {
                smbxversionlabel.Text = "SMBX Found: " + GetFileVersionInfo(smbxExeLoc).ToString();
                smbxversionlabel.ForeColor = Color.DarkGreen;
            }
            else
            {
                smbxversionlabel.Text = "Couldn't find SMBX!";
                smbxversionlabel.ForeColor = Color.DarkRed;
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
            //saving stuff
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

            MessageBox.Show("Settings saved sucessfully");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.Description = "Select the folder SMBX is in";
            if(fb.ShowDialog() == DialogResult.OK)
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
                smbxversionlabel.Text = "SMBX Found: " + GetFileVersionInfo(smbxExeLoc).ToString();
                smbxversionlabel.ForeColor = Color.DarkGreen;
            }
            else
            {
                smbxversionlabel.Text = "Couldn't find SMBX!";
                smbxversionlabel.ForeColor = Color.DarkRed;
            }
        }

        private void localEpisodesListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indexToLoad;
            string pathToLoad;
            if (localEpisodesListview.SelectedItems.Count == 1)
            {
                episodeNameLabel.Text = localEpisodesListview.SelectedItems[0].Text;
                indexToLoad = smbxWorldsDir + @"\" + localEpisodesListview.SelectedItems[0].Text + @"\project.index";
                pathToLoad = smbxWorldsDir + @"\" + localEpisodesListview.SelectedItems[0].Text;
            }
            else
            {
                indexToLoad = null;
                pathToLoad = null;
            }
            if (File.Exists(indexToLoad) == true)
            {
                episodeNameLabel.Text = inReader.episodeName(indexToLoad);
                authorName.Text = "by: " + inReader.authorName(indexToLoad);
                descriptionLabel.Text = inReader.descriptionText(indexToLoad);
                try
                {
                    Image art = Image.FromFile(pathToLoad + @"\image1.png");
                    ss1.BackgroundImage = art;
                }
                catch(FileNotFoundException fnex)
                {

                }

                try
                {
                    Image art = Image.FromFile(pathToLoad + @"\image2.png");
                    ss2.BackgroundImage = art;
                }
                catch (FileNotFoundException fnex)
                {

                }

                try
                {
                    Image art = Image.FromFile(pathToLoad + @"\image3.png");
                    ss3.BackgroundImage = art;
                }
                catch (FileNotFoundException fnex)
                {

                }

                try
                {
                    Image art = Image.FromFile(pathToLoad + @"\image4.png");
                    ss4.BackgroundImage = art;
                }
                catch (FileNotFoundException fnex)
                {

                }
            }
            else
            {
                authorName.Text = "This episode doesn't seem to have an index file associated with it :(";
                descriptionLabel.Text = "";
                ss1.BackgroundImage = null;
                ss2.BackgroundImage = null;
                ss3.BackgroundImage = null;
                ss4.BackgroundImage = null;

            }
            //MessageBox.Show(localEpisodesListview.SelectedItems[0].Text);
        }

    }
}
