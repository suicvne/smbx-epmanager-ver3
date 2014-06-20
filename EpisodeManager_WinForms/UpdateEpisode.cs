using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using IndexReader;

namespace EpisodeManager_WinForms
{
    public partial class UpdateEpisode : MetroForm
    {
        public UpdateEpisode()
        {
            InitializeComponent();
        }

        bool serverOn;
        string serverUrl = Main_NEW.serverUrl + "changes/";
        string webFriendlyText = "";
        string toReplace = "";
        IndexReaderClass inReader = new IndexReaderClass();
        private void UpdateEpisode_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Main_NEW mf = new Main_NEW();
            updatingToLabel.Text = "Updating to Version " + Main_NEW.availVer;
            iconPicture.BackgroundImage = Main_NEW.bgImage;
            
            try
            {
                using (StreamReader sr = new StreamReader(Environment.CurrentDirectory + @"\temp\Update\changes.index"))
                {
                    string line;
                    ListViewItem lvi = new ListViewItem();
                    while ((line = sr.ReadLine()) != null)
                    {
                        if(line.Contains("changedFiles"))
                        {
                            var split = line.Split(new char[] { '=' }, 2);
                            string[] fileslist = split[1].Split(',');
                            foreach(var item in fileslist)
                            {
                                if(item != "")
                                {
                                    lvi = new ListViewItem();
                                    lvi.Text = item.ToString();
                                    if(item.Contains(".lvl"))
                                    {
                                        lvi.SubItems.Add("Level File");
                                    }
                                    else if(item.Contains(".gif"))
                                    {
                                        lvi.SubItems.Add("Custom Graphic");
                                    }
                                    else if(item.Contains(".wld"))
                                    {
                                        lvi.SubItems.Add("World File");
                                    }
                                    else if(item.Contains(".mp3"))
                                    {
                                        lvi.SubItems.Add("MP3 Music File");
                                    }
                                    else if(item.Contains(".wav"))
                                    {
                                        lvi.SubItems.Add("WAV Music File");
                                    }
                                    else if(item.Contains(".txt"))
                                    {
                                        lvi.SubItems.Add("NPC Code File");
                                    }
                                    lvi.SubItems.Add("Queued");
                                    changesListView.Items.Add(lvi);
                                }
                            }
                        }
                    }
                }
            }
            catch(FileNotFoundException fnex)
            {
                MessageBox.Show("The changes file could not be loaded\n" + fnex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void updateProcess()
        {
            
            //calculate changes

            //wait for user to confirm

            //update

        }

        private void pingServerBgWork_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            isOkGroup.Visible = false;
            //
            downloadFilesBgWorker.RunWorkerAsync();
            updateFiles();
            MessageBox.Show("Episode was updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void updateFiles()
        {
            WebClient client = new WebClient();
            List<Task> tasks = new List<Task>();

            foreach (ListViewItem lvi in changesListView.Items)
            {
                
                toReplace = Main_NEW.smbxWorldsDir + @"\" + Main_NEW.selectedFolderName + @"\" + lvi.Text;

                if (File.Exists(Main_NEW.smbxWorldsDir + @"\" + Main_NEW.selectedFolderName + @"\" + lvi.Text))
                {
                    File.Delete(Main_NEW.smbxWorldsDir + @"\" + Main_NEW.selectedFolderName + @"\" + lvi.Text);
                }

                if (lvi.Text.Contains(@"\") == true)
                {
                    webFriendlyText = lvi.Text.Replace(@"\", "/");
                }
                else
                {
                    webFriendlyText = lvi.Text;
                }
                string urlToDownload = serverUrl + webFriendlyText;
                Computer myComputer = new Computer();
                myComputer.Network.DownloadFile(urlToDownload, toReplace, null, null, true, 10000, true);
                lvi.SubItems[2].Text = "Completed";
            }
            string indexToRead = Main_NEW.smbxWorldsDir + @"\" + Main_NEW.selectedFolderName + @"\project.index";
            string epName = inReader.episodeName(indexToRead);
            string aut = inReader.authorName(indexToRead);
            string descrip = inReader.descriptionText(indexToRead);
            string version = "version=" + Main_NEW.availVer.ToString();
            string serv = inReader.serverUrl(indexToRead);
            string forumUrl = inReader.forumLink(indexToRead);
            string fileList = inReader.filesList(indexToRead);

            if(File.Exists(indexToRead) == true)
            {
                File.Delete(indexToRead);
            }
            using(StreamWriter sw = new StreamWriter(indexToRead))
            {
                /*
                sw.WriteLine("episodeName=" + epName);
                sw.WriteLine("description=" + descrip);
                sw.WriteLine(version);
                sw.WriteLine("server=" + serv);
                sw.WriteLine("forumUrl=" + forumUrl);
                sw.WriteLine("filesList=" + fileList);*/
                Computer myComputer = new Computer();
                try
                {
                    myComputer.Network.DownloadFile(Main_NEW.serverUrl + "/project.index", indexToRead, null, null, true, 10000, true);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        /*
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Completed download");
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            progressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
        }*/

        private void downloadFilesBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
