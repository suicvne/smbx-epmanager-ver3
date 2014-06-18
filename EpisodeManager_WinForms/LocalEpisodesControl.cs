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
using IndexReader;
using System.Net.NetworkInformation;
using System.Net;

namespace EpisodeManager_WinForms
{
    public partial class LocalEpisodesControl : UserControl
    {
        //
        IndexReaderClass inReader = new IndexReaderClass();
        public static string availVer;
        //

        public LocalEpisodesControl()
        {
            InitializeComponent();
        }

        private void populateListView()
        {
            /*
            ListViewItem lvi = new ListViewItem();
            DirectoryInfo dinfo = new DirectoryInfo(MainForm_BACKUP.smbxWorldsDir);
            try
            {
                foreach (var d in dinfo.GetDirectories())
                {
                    lvi = new ListViewItem();
                    lvi.Text = d.ToString();
                    localEpisodesListview.Items.Add(lvi);
                }
            }
            catch (DirectoryNotFoundException dx)
            {
                MessageBox.Show("Directory not found: " + MainForm_BACKUP.smbxWorldsDir + "\nPlease configure the proper SMBX Directories\n\n" + dx.Message,
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }*/
        }

        private bool Ping(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Timeout = 3000;
                request.AllowAutoRedirect = false;
                request.Method = "HEAD";
                using (var response = request.GetResponse())
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        #region Controls Functions
        private void viewFilesButton_Click(object sender, EventArgs e)
        {

        }

        private void forumTopicButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Main_NEW.forumLink);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        private void ss1_Click(object sender, EventArgs e)
        {
            if (ss1.BackgroundImage != null)
            {
                ScreenshotViewer sv = new ScreenshotViewer();
                sv.BackgroundImage = ss1.BackgroundImage;
                sv.ShowDialog();
            }
        }

        private void ss2_Click(object sender, EventArgs e)
        {
            if (ss2.BackgroundImage != null)
            {
                ScreenshotViewer sv = new ScreenshotViewer();
                sv.BackgroundImage = ss2.BackgroundImage;
                sv.ShowDialog();
            }
        }

        private void ss3_Click(object sender, EventArgs e)
        {
            if (ss3.BackgroundImage != null)
            {
                ScreenshotViewer sv = new ScreenshotViewer();
                sv.BackgroundImage = ss3.BackgroundImage;
                sv.ShowDialog();
            }
        }

        private void ss4_Click(object sender, EventArgs e)
        {
            if (ss4.BackgroundImage != null)
            {
                ScreenshotViewer sv = new ScreenshotViewer();
                sv.BackgroundImage = ss4.BackgroundImage;
                sv.ShowDialog();
            }
        }

        private void localEpisodesListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indexToLoad;
            string pathToLoad;
            if (localEpisodesListview.SelectedItems.Count == 1)
            {
                episodeNameLabel.Text = localEpisodesListview.SelectedItems[0].Text;
                indexToLoad = Main_NEW.smbxWorldsDir + @"\" + localEpisodesListview.SelectedItems[0].Text + @"\project.index";
                pathToLoad = Main_NEW.smbxWorldsDir + @"\" + localEpisodesListview.SelectedItems[0].Text;
            }
            else
            {
                indexToLoad = null;
                pathToLoad = null;
            }
            if (File.Exists(indexToLoad) == true)
            {
                Main_NEW.selectedFolderName = localEpisodesListview.SelectedItems[0].Text;

                episodeNameLabel.Text = inReader.episodeName(indexToLoad);
                authorName.Text = "by: " + inReader.authorName(indexToLoad);
                descriptionLabel.Text = inReader.descriptionText(indexToLoad);
                Main_NEW.forumLink = inReader.forumLink(indexToLoad);
                Main_NEW.serverUrl = inReader.serverUrl(indexToLoad);
                try
                {
                    Image art = Image.FromFile(pathToLoad + @"\image1.png");
                    ss1.BackgroundImage = art;
                }
                catch (FileNotFoundException fnex)
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
                if (File.Exists(pathToLoad + @"\icon.png") == true)
                {
                    iconFrame.Visible = true;
                    iconPicture.Visible = true;
                    Image icon = Image.FromFile(pathToLoad + @"\icon.png");
                    iconPicture.BackgroundImage = icon;
                }
                //checkServerButton.Enabled = true;
                //EpisodeManager_WinForms.Properties.Resources.ok_32
                /*if (serverOn(Main_NEW.serverUrl) == true)
                {
                    serverStatusOnPb.Visible = true;
                    serverStatusOffPb.Visible = false;
                }
                else
                {
                    serverStatusOnPb.Visible = false;
                    serverStatusOffPb.Visible = true;
                }*/
                viewFilesButton.Enabled = true;
                forumTopicButton.Enabled = true;
                if (inReader.versionNumber(indexToLoad) != null)
                {
                    versionLabel.Visible = true;
                    versionLabel.Text = "v" + inReader.versionNumber(indexToLoad);
                    Main_NEW.epVer = Int32.Parse(inReader.versionNumber(indexToLoad));
                }
                checkForUpdatesBgWork.RunWorkerAsync();
            }
            else
            {
                authorName.Text = "This episode doesn't seem to have an index file associated with it :(";
                descriptionLabel.Text = "";
                ss1.BackgroundImage = null;
                ss2.BackgroundImage = null;
                ss3.BackgroundImage = null;
                ss4.BackgroundImage = null;
                iconFrame.Visible = false;
                iconPicture.Visible = false;
                //
                //serverStatusOffPb.Visible = true;
                //serverStatusOnPb.Visible = false;
                //checkServerButton.Enabled = false;
                viewFilesButton.Enabled = false;
                forumTopicButton.Enabled = false;
                versionLabel.Visible = false;

            }
        }
        //
        private void LocalEpisodesControl_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            authorName.RightToLeft = RightToLeft.Yes;
        }
        private void checkForUpdatesBgWork_DoWork(object sender, DoWorkEventArgs e)
        {
            updateButton.Enabled = false;
            updateButton.Text = "Checking for \nupdates..";
            updateCheckSpinner.Visible = true;

            if(serverOn(Main_NEW.serverUrl) == false)
            {
                updateButton.Text = "Server offline\nCan't update";
                updateCheckSpinner.Visible = false;
            }
            else //true
            {
                try
                {
                    WebClient wc = new WebClient();
                    wc.DownloadFile(Main_NEW.serverUrl + @"changes.index", Environment.CurrentDirectory + @"\temp\Update\changes.index");
                    int avVer = Int32.Parse(inReader.versionNumber(Environment.CurrentDirectory + @"\temp\Update\changes.index"));
                    if(avVer > Main_NEW.epVer == true)
                    {
                        updateButton.Enabled = true;
                        updateButton.Text = "Update Available!\nv" + avVer;
                        updateCheckSpinner.Visible = false;
                        Main_NEW.availVer = avVer;
                        Main_NEW.bgImage = iconPicture.BackgroundImage;
                    }
                    else
                    {
                        updateButton.Enabled = false;
                        updateButton.Text = "No updates\navailable :)";
                        updateCheckSpinner.Visible = false;
                    }
                }
                catch (WebException we)
                {
                    updateButton.Enabled = false;
                    updateButton.Text = "No updates \navailable";
                    updateCheckSpinner.Visible = false;
                    MessageBox.Show(we.Message);
                }
            }
        }
        #endregion
        public bool serverOn(string url)
        {
            if (Ping(url) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateEpisode ue = new UpdateEpisode();
            ue.ShowDialog();
        }

        
        

    }
}
