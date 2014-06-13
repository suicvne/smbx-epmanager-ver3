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

namespace EpisodeManager_WinForms
{
    public partial class LocalEpisodesControl : UserControl
    {
        //
        IndexReaderClass inReader = new IndexReaderClass();
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

        #region Controls Functions
        private void viewFilesButton_Click(object sender, EventArgs e)
        {

        }

        private void forumTopicButton_Click(object sender, EventArgs e)
        {/*
            try
            {
                Process.Start(MainForm_BACKUP.forumLink);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void checkServerButton_Click(object sender, EventArgs e)
        {

        }
        
        private void ss1_Click(object sender, EventArgs e)
        {/*
            if (ss1.BackgroundImage != null)
            {
                ScreenshotViewer sv = new ScreenshotViewer();
                sv.BackgroundImage = ss1.BackgroundImage;
                sv.ShowDialog();
            }*/
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
        {/*
            string indexToLoad;
            string pathToLoad;
            if (localEpisodesListview.SelectedItems.Count == 1)
            {
                episodeNameLabel.Text = localEpisodesListview.SelectedItems[0].Text;
                indexToLoad = MainForm_BACKUP.smbxWorldsDir + @"\" + localEpisodesListview.SelectedItems[0].Text + @"\project.index";
                pathToLoad = MainForm_BACKUP.smbxWorldsDir + @"\" + localEpisodesListview.SelectedItems[0].Text;
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
                MainForm_BACKUP.forumLink = inReader.forumLink(indexToLoad);
                MainForm_BACKUP.serverUrl = inReader.serverUrl(indexToLoad);
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
                checkServerButton.Enabled = true;
                viewFilesButton.Enabled = true;
                forumTopicButton.Enabled = true;
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

                checkServerButton.Enabled = false;
                viewFilesButton.Enabled = false;
                forumTopicButton.Enabled = false;

            }*/
        }
        #endregion

    }
}
