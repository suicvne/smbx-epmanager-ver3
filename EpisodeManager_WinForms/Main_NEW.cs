using MetroFramework.Forms;
using Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
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
            this.Size = new System.Drawing.Size(771, 586);
            
            this.AvailableEpisodes.parentForm = this;

            metroTabControl1.SelectedTab = metroTabPage1;
            
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
            try
            {
                localEpisodes.localEpisodesListview.Items[0].Selected = true;
            }
            catch
            {

            }
            checkForUpdates();
            //
            try
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\temp");
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\temp\Server");
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\temp\Server\Cache");
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\temp\ZipReading");
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\temp\Update");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //
        }
        
        private void checkForUpdates()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string newestVersion;
            string currentVersion = fileVersionInfo.ProductVersion;
            int newestVersionInt;
            int currentVersionInt;


            Console.WriteLine("Checking for updates..");
            Console.WriteLine("Current version: " + currentVersion);

            try
            {
                WebClient wc = new WebClient();
                wc.DownloadFile("http://mrmiketheripper.x10.mx/epmanager3/version.txt", Environment.CurrentDirectory + @"\temp\version.txt");
                using(StreamReader sr = new StreamReader(Environment.CurrentDirectory + @"\temp\version.txt"))
                {
                    newestVersion = sr.ReadLine();
                    Console.WriteLine("Newest Version: " + newestVersion);
                    newestVersionInt = verStringToInt(newestVersion);
                    currentVersionInt = verStringToInt(currentVersion);
                    if(newestVersionInt > currentVersionInt)
                    {
                        /*
                         * WebClient wc = new WebClient();
            updateConfirmLabel.Text = "Downloading updater..";
            wc.DownloadFile("http://mrmiketheripper.x10.mx/epmanager3/SMBXUpdater_Latest.exe", Environment.CurrentDirectory + @"\Updater.exe");
            Process.Start(Environment.CurrentDirectory + @"\Updater.exe");
            Environment.Exit(0);*/
                        DialogResult dr = new Changelog(currentVersion, newestVersion).ShowDialog();
                        switch(dr)
                        {
                            case DialogResult.Yes:
                                //WebClient wcs = new WebClient();
                                wc.DownloadFile("http://mrmiketheripper.x10.mx/epmanager3/SMBXUpdater_Latest.exe", Environment.CurrentDirectory + @"\Updater.exe");
                                Process.Start(Environment.CurrentDirectory + @"\Updater.exe");
                                Environment.Exit(0);
                                break;
                            case DialogResult.No:
                                break;
                        }
                        updatedLabel.Text = "Update Available: " + newestVersion;
                    }
                    else
                    {
                        Console.WriteLine("No updates available!");
                        updatedLabel.Text = "Up to date: " + currentVersion;
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        private int verStringToInt(string ver)
        {
            string[] split = ver.Split(new Char[] { '.' });
            string together = split[0].ToString() + split[1].ToString() + split[2].ToString() + split[3].ToString();
            return int.Parse(together);
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
            if(localEpisodes.localEpisodesListview.Items.Count == 0)
            {
                localEpisodes.episodeNameLabel.Text = "No episodes found! :(";
                localEpisodes.authorName.Text = "Install some manually or by going to the 'Available Episodes' tab";
                localEpisodes.forumTopicButton.Visible = false;
                localEpisodes.updateButton.Visible = false;
            }
            
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

        private void menuItem1_Click(object sender, EventArgs e)
        {
            //delete
            DialogResult dr = MessageBox.Show("Are you sure you'd like to delete '" + Main_NEW.selectedFolderName + "'?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dr)
            {
                case (DialogResult.Yes):
                    deleteEpisode();
                    break;
                case(DialogResult.No):
                    break;
            }
        }

        private void deleteEpisode()
        {
            LoadingIndex de = new LoadingIndex(Main_NEW.smbxWorldsDir + @"\" + Main_NEW.selectedFolderName, this);
            de.ShowDialog();
            //MessageBox.Show("Episode deleted!");
        }

        private void episodesMoreButton_Click_1(object sender, EventArgs e)
        {
            string dir = Main_NEW.smbxWorldsDir + @"\" + Main_NEW.selectedFolderName;
            if(File.Exists(dir + @"\save1.sav"))
            {
                deleteSave1Menu.Enabled = true;
            }
            if (File.Exists(dir + @"\save2.sav"))
            {
                deleteSave2Menu.Enabled = true;
            }
            if (File.Exists(dir + @"\save3.sav"))
            {
                deleteSave3Menu.Enabled = true;
            }
            if(File.Exists(smbxExeLoc))
            {
                launchSMBXMenu.Enabled = true;
                launchSMBXMenu.Text = "Launch SMBX " + GetFileVersionInfo(smbxExeLoc);
            }
            episodeContext.Show(episodesMoreButton, new System.Drawing.Point(0, 40));
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

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //0 for main, 1 for available
        }

        private void AvailableEpisodes_Load(object sender, EventArgs e)
        {
            
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            populateListView();
        }

        private void deleteSave1Menu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you'd like to delete 'save1.sav' for episode '" + Main_NEW.selectedFolderName + "'?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch(dr)
            {
                case DialogResult.Yes:
                    File.Delete(Main_NEW.smbxWorldsDir + @"\" + Main_NEW.selectedFolderName + @"\save1.sav");
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void deleteSave2Menu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you'd like to delete 'save2.sav' for episode '" + Main_NEW.selectedFolderName + "'?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Yes:
                    File.Delete(Main_NEW.smbxWorldsDir + @"\" + Main_NEW.selectedFolderName + @"\save2.sav");
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void deleteSave3Menu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you'd like to delete 'save3.sav' for episode '" + Main_NEW.selectedFolderName + "'?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Yes:
                    File.Delete(Main_NEW.smbxWorldsDir + @"\" + Main_NEW.selectedFolderName + @"\save3.sav");
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void availEpisodesOverflow_Click(object sender, EventArgs e)
        {
            availContext.Show(availEpisodesOverflow, new System.Drawing.Point(0, 40));
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            if (sender == AvailableEpisodes)
            {
                AvailableEpisodesControl av = this.AvailableEpisodes;
                av.loadTimeEvents();
            }
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            WhichEpisode we = new WhichEpisode(localEpisodes, AvailableEpisodes.availEpisodesListview.SelectedItems[0].SubItems[1].Text);
            we.ShowDialog();
        }
    }
}
