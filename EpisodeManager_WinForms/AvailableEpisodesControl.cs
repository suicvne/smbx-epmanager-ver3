using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Net;
using System.Threading;
using IndexReader;

namespace EpisodeManager_WinForms
{
    public partial class AvailableEpisodesControl : UserControl
    {
        public static string availServerUrl;

        public AvailableEpisodesControl()
        {
            InitializeComponent();
        }

        private void AvailableEpisodesControl_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            ss1.Image = null;
            ss2.Image = null;
            ss3.Image = null;
            ss4.Image = null;
            iconFrame.Visible = false;
            iconPicture.Visible = false;
            episodeNameLabel.Text = "";
            authorName.Text = "";
            descLabel.Text = "";
            this.BackColor = Color.White;
            try
            {
                XDocument docu = XDocument.Load("https://dl.dropboxusercontent.com/u/62304851/index.xml");
                queryData(docu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            availEpisodesListview.Items[0].Selected = true;
            availEpisodesListview.Focus();
        }

        public void queryData(XDocument doc)
        {
            var data = from item in doc.Descendants("Episode")
                       select new
                       {
                           episodeName = item.Element("episodeName").Value,
                           serverUrl = item.Element("serverUrl").Value
                       };
            ListViewItem lvi;
            foreach (var info in data)
            {
                lvi = new ListViewItem();
                lvi.Text = info.episodeName.ToString();
                lvi.SubItems.Add(info.serverUrl.ToString());
                availEpisodesListview.Items.Add(lvi);
            }
        }

        private void availEpisodesListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (availEpisodesListview.SelectedItems.Count == 1)
            {
                availServerUrl = availEpisodesListview.SelectedItems[0].SubItems[1].Text;
                //MessageBox.Show(availServerUrl);
                loadingProg.Visible = true;

                
                ThreadStart threadDelegate = new ThreadStart(loadInformation);
                Thread t = new Thread(threadDelegate);
                t.Start();
            }
            else
            {
                availServerUrl = null;
            }
            
        }
        void loadInformation()
        {
            installEpisodeButton.Enabled = false;
            iconFrame.Visible = false;
            iconPicture.Visible = false;
            availEpisodesListview.Enabled = false;
            loadingProg.Visible = true;
            ss1.Image = null;
            ss2.Image = null;
            ss3.Image = null;
            ss4.Image = null;
            episodeNameLabel.Text = "";
            authorName.Text = "";
            descLabel.Text = "";

            WebClient wc = new WebClient();
            string tempPath = Environment.CurrentDirectory + @"\temp\Server";
            if (Directory.Exists(Environment.CurrentDirectory + @"\temp\Server") != true)
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\temp\Server");
            }
            try
            {
                wc.DownloadFile(availServerUrl + "project.index", tempPath + @"\project.index");

                ss1.ImageLocation = availServerUrl + "image1.png";
                ss2.ImageLocation = availServerUrl + "image2.png";
                ss3.ImageLocation = availServerUrl + "image3.png";
                ss4.ImageLocation = availServerUrl + "image4.png";
                iconPicture.ImageLocation = availServerUrl + "icon.png";
                iconFrame.Visible = true;
                iconPicture.Visible = true;
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
            IndexReaderClass inReader = new IndexReaderClass();

            episodeNameLabel.Text = inReader.episodeName(tempPath + @"\project.index");
            authorName.Text = "by " + inReader.authorName(tempPath + @"\project.index");
            descLabel.Text = inReader.descriptionText(tempPath + @"\project.index");

            installEpisodeButton.Enabled = true;
            loadingProg.Visible = false;
            availEpisodesListview.Enabled = true;
        }

        private void ss1_Click(object sender, EventArgs e)
        {
            if (ss1.Image != null)
            {
                ScreenshotViewer sv = new ScreenshotViewer();
                sv.BackgroundImage = ss1.Image;
                sv.ShowDialog();
            }
        }

        private void ss2_Click(object sender, EventArgs e)
        {
            if (ss2.Image != null)
            {
                ScreenshotViewer sv = new ScreenshotViewer();
                sv.BackgroundImage = ss2.Image;
                sv.ShowDialog();
            }
        }

        private void ss3_Click(object sender, EventArgs e)
        {
            if (ss3.Image != null)
            {
                ScreenshotViewer sv = new ScreenshotViewer();
                sv.BackgroundImage = ss3.Image;
                sv.ShowDialog();
            }
        }

        private void ss4_Click(object sender, EventArgs e)
        {
            if (ss4.Image != null)
            {
                ScreenshotViewer sv = new ScreenshotViewer();
                sv.BackgroundImage = ss4.Image;
                sv.ShowDialog();
            }
        }
    }
}

