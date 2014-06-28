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
using System.Text.RegularExpressions;
using System.Drawing.Imaging;

namespace EpisodeManager_WinForms
{
    public partial class AvailableEpisodesControl : UserControl
    {
        public static string avail_ServerUrl;
        public static string avail_DownloadUrl;

        public Main_NEW parentForm { get; set; }

        public AvailableEpisodesControl()
        {
            InitializeComponent();
        }

        private void AvailableEpisodesControl_Load(object sender, EventArgs e)
        {
            if(this.DesignMode != true)
            {
                loadTimeEvents();
            }
           
        }

        public void loadTimeEvents()
        {
            try
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
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        public void queryData(XDocument doc)
        {
            var data = from item in doc.Descendants("Episode")
                       select new
                       {
                           episodeName = item.Element("episodeName").Value,
                           serverUrl = item.Element("serverUrl").Value,
                           downloadUrl = item.Element("downloadUrl").Value
                       };
            ListViewItem lvi;
            foreach (var info in data)
            {
                lvi = new ListViewItem();
                lvi.Text = info.episodeName.ToString();
                lvi.SubItems.Add(info.serverUrl.ToString());
                lvi.SubItems.Add(info.downloadUrl.ToString());
                availEpisodesListview.Items.Add(lvi);
            }
        }

        private void availEpisodesListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main_NEW mf = new Main_NEW();
            if (availEpisodesListview.SelectedItems.Count == 1)
            {
                avail_ServerUrl = availEpisodesListview.SelectedItems[0].SubItems[1].Text;
                avail_DownloadUrl = availEpisodesListview.SelectedItems[0].SubItems[2].Text;
                //MessageBox.Show(availServerUrl);
                loadingProg.Visible = true;
                
                ThreadStart threadDelegate = new ThreadStart(loadInformationTwoPointO);
                Thread t = new Thread(threadDelegate);
                t.Start();
            }
            else
            {
                avail_ServerUrl = null;
            }
            foreach (ListViewItem lvi in mf.localEpisodes.localEpisodesListview.Items)
            {
                compareStrings(lvi);
            }
                
        }

        void compareStrings(ListViewItem lviii)
        {
            if (string.Equals(lviii.Text, availEpisodesListview.SelectedItems[0].Text, StringComparison.CurrentCultureIgnoreCase) == true)
            {
                installEpisodeButton.Text = "INSTALLED";
            }
            else
            {
                installEpisodeButton.Text = "INSTALL EPISODE";
            }
        }

        void loadInformationTwoPointO()
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
            string folderName = isValidPathName(availEpisodesListview.SelectedItems[0].Text.ToLower());
            string tempPath = Environment.CurrentDirectory + @"\temp\Server\Cache" + @"\" + folderName;
            if (Directory.Exists(tempPath) != true)
            {
                Directory.CreateDirectory(tempPath);
            }

            compareCaches();

            //
            try{ss1.Image = Image.FromFile(tempPath + @"\image1.png");}
            catch {ss1.Image = null;}
            try { ss2.Image = Image.FromFile(tempPath + @"\image2.png"); }
            catch { ss2.Image = null; }
            try { ss3.Image = Image.FromFile(tempPath + @"\image3.png"); }
            catch { ss3.Image = null; }
            try { ss4.Image = Image.FromFile(tempPath + @"\image4.png"); }
            catch { ss4.Image = null; }
            try { iconPicture.Image = Image.FromFile(tempPath + @"\icon.png"); iconFrame.Visible = true; iconPicture.Visible = true; }
            catch { iconPicture.Image = null; iconFrame.Visible = false; iconPicture.Visible = false; }
            //

            IndexReaderClass inReader = new IndexReaderClass();
            try
            {
                episodeNameLabel.Text = inReader.episodeName(tempPath + @"\project.index");
                authorName.Text = "by " + inReader.authorName(tempPath + @"\project.index");
                descLabel.Text = inReader.descriptionText(tempPath + @"\project.index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (installEpisodeButton.Text == "INSTALLED")
            {
                installEpisodeButton.Enabled = false;
            }
            else
            {
                installEpisodeButton.Enabled = true;
            }
            loadingProg.Visible = false;
            availEpisodesListview.Enabled = true;
        }

        void compareCaches()
        {
            WebClient wc = new WebClient();
            string folderName = isValidPathName(availEpisodesListview.SelectedItems[0].Text.ToLower());
            string tempPath = Environment.CurrentDirectory + @"\temp\Server\Cache" + @"\" + folderName;

            if (File.Exists(tempPath + @"\project.index") != true)
            {
                wc.DownloadFile(avail_ServerUrl + "project.index", tempPath + @"\project.index");
            }
            else
            {
                wc.DownloadFile(avail_ServerUrl + "project.index", tempPath + @"\_project.index");
                if (compareIndex(tempPath + @"\project.index", tempPath + @"\_project.index") == false)
                {
                    File.Delete(tempPath + @"\project.index");
                    File.Move(tempPath + @"\_project.index", tempPath + @"\project.index");
                }
            }
            if (File.Exists(tempPath + @"\image1.png") != true)
            {
                wc.DownloadFile(avail_ServerUrl + "image1.png", tempPath + @"\image1.png");
            }
            else
            {
                wc.DownloadFile(avail_ServerUrl + "image1.png", tempPath + @"\_image1.png");
                if (compareIndex(tempPath + @"\image1.png", tempPath + @"\_image1.png") == false)
                {
                    File.Delete(tempPath + @"\image1.png");
                    File.Move(tempPath + @"\_image1.png", tempPath + @"\image1.png");
                    
                }
            }
            if (File.Exists(tempPath + @"\image2.png") != true)
            {
                wc.DownloadFile(avail_ServerUrl + "image2.png", tempPath + @"\image2.png");
                
            }
            else
            {
                wc.DownloadFile(avail_ServerUrl + "image2.png", tempPath + @"\_image2.png");
                if (compareIndex(tempPath + @"\image2.png", tempPath + @"\_image2.png") == false)
                {
                    File.Delete(tempPath + @"\image2.png");
                    File.Move(tempPath + @"\_image2.png", tempPath + @"\image2.png");
                    
                }
            }
            if (File.Exists(tempPath + @"\image3.png") != true)
            {
                wc.DownloadFile(avail_ServerUrl + "image3.png", tempPath + @"\image3.png");
                
            }
            else
            {
                wc.DownloadFile(avail_ServerUrl + "image3.png", tempPath + @"\_image3.png");
                if (compareIndex(tempPath + @"\image3.png", tempPath + @"\_image3.png") == false)
                {
                    File.Delete(tempPath + @"\image3.png");
                    File.Move(tempPath + @"\_image3.png", tempPath + @"\image3.png");
                   
                }
            }
            if (File.Exists(tempPath + @"\image4.png") != true)
            {
                wc.DownloadFile(avail_ServerUrl + "image4.png", tempPath + @"\image4.png");
               
            }
            else
            {
                wc.DownloadFile(avail_ServerUrl + "image4.png", tempPath + @"\_image4.png");
                if (compareIndex(tempPath + @"\image4.png", tempPath + @"\_image4.png") == false)
                {
                    File.Delete(tempPath + @"\image4.png");
                    File.Move(tempPath + @"\_image4.png", tempPath + @"\image4.png");
                }
                
            }
            if (File.Exists(tempPath + @"\icon.png") != true)
            {
                wc.DownloadFile(avail_ServerUrl + "icon.png", tempPath + @"\icon.png");
                
            }
            else
            {
                wc.DownloadFile(avail_ServerUrl + "icon.png", tempPath + @"\_icon.png");
                if (compareIndex(tempPath + @"\icon.png", tempPath + @"\_icon.png") == false)
                {
                    File.Delete(tempPath + @"\icon.png");
                    File.Move(tempPath + @"\_icon.png", tempPath + @"\icon.png");
                    
                }
            }
        }

        bool compareIndex(string cacheIndex, string checkedIndex)
        {
            int cacheByte;
            int checkedByte;
            FileStream fs1;
            FileStream fs2;

            if(cacheIndex == checkedIndex)
            {
                return true;
            }

            fs1 = new FileStream(cacheIndex, FileMode.Open, FileAccess.Read);
            fs2 = new FileStream(cacheIndex, FileMode.Open, FileAccess.Read);

            if(fs1.Length != fs2.Length)
            {
                fs1.Close();
                fs2.Close();
                return false;
            }

            do
            {
                // Read one byte from each file.
                cacheByte = fs1.ReadByte();
                checkedByte = fs2.ReadByte();
            }
            while ((cacheByte == checkedByte) && (cacheByte != -1));

            // Close the files.
            fs1.Close();
            fs2.Close();

            // Return the success of the comparison. "file1byte" is 
            // equal to "file2byte" at this point only if the files are 
            // the same.
            return ((cacheByte - checkedByte) == 0);
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
            string folderName = isValidPathName(availEpisodesListview.SelectedItems[0].Text.ToLower());
            string tempPath = Environment.CurrentDirectory + @"\temp\Server\Cache" +@"\" + folderName;
            if (Directory.Exists(tempPath) != true)
            {
                Directory.CreateDirectory(tempPath);
            }
            try
            {
                wc.DownloadFile(avail_ServerUrl + "project.index", tempPath + @"\project.index");

                ss1.ImageLocation = avail_ServerUrl + "image1.png";
                ss2.ImageLocation = avail_ServerUrl + "image2.png";
                ss3.ImageLocation = avail_ServerUrl + "image3.png";
                ss4.ImageLocation = avail_ServerUrl + "image4.png";
                iconPicture.ImageLocation = avail_ServerUrl + "icon.png";
                iconFrame.Visible = true;
                iconPicture.Visible = true;

                Image image = ss1.Image;
                image.Save(tempPath + @"\image1.png", ImageFormat.Png);
                //
                image = ss2.Image;
                image.Save(tempPath + @"\image2.png", ImageFormat.Png);
                //
                image = ss3.Image;
                image.Save(tempPath + @"\image3.png", ImageFormat.Png);
                //
                image = ss4.Image;
                image.Save(tempPath + @"\image4.png", ImageFormat.Png);
                //
                image = iconPicture.Image;
                image.Save(tempPath + @"\icon.png", ImageFormat.Png);
                image.Dispose();
                
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
            IndexReaderClass inReader = new IndexReaderClass();
            try
            {
                episodeNameLabel.Text = inReader.episodeName(tempPath + @"\project.index");
                authorName.Text = "by " + inReader.authorName(tempPath + @"\project.index");
                descLabel.Text = inReader.descriptionText(tempPath + @"\project.index");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (installEpisodeButton.Text == "INSTALLED")
            {
                installEpisodeButton.Enabled = false;
            }
            else
            { 
                installEpisodeButton.Enabled = true; 
            }
            loadingProg.Visible = false;
            availEpisodesListview.Enabled = true;
        }

        string isValidPathName(string path)
        {
            string badChars = System.IO.Path.GetInvalidPathChars().ToString();
            string regexSearch = ":";
            Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));

            if (r.IsMatch(path))
            {
                path = r.Replace(path, "");
                return path;
            }

            return path;
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

        private void installEpisodeButton_Click(object sender, EventArgs e)
        {
            LoadingIndexDialog li = new LoadingIndexDialog(parentForm);
            li.ShowDialog();
        }
    }
}

