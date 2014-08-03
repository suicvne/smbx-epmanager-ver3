using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Ionic.Zip;

namespace EpisodeManager_WinForms
{
    public partial class LoadingIndexDialog : MetroForm
    {
        public LoadingIndexDialog(Main_NEW _Main_NEW)
        {
            mf = _Main_NEW;
            InitializeComponent();
        }
        Main_NEW mf { get; set; }
        private void LoadingIndexDialog_Load(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += (s, ec) =>
            {
                metroProgressBar1.Value = ec.ProgressPercentage;
            };
            webClient.DownloadFileCompleted += (s, ec) =>
            {
                metroProgressBar1.Visible = false;
                Thread extract = new Thread(() => extractFile(Environment.CurrentDirectory + @"\temp\Server\download.zip"));
                extract.Start();
                //extractFile(Environment.CurrentDirectory + @"\temp\Server\download.zip");
            };
            webClient.DownloadFileAsync(new Uri(AvailableEpisodesControl.avail_DownloadUrl),
                Environment.CurrentDirectory + @"\temp\Server\download.zip");
            

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

        void extractFile(string file)
        {
            this.Text = "Extracting...";
            statusLabel.Text = "Extracting...";
            try
            {
                string folderName = isValidPathName(mf.AvailableEpisodes.availEpisodesListview.SelectedItems[0].Text);
                string extractionPath = Main_NEW.smbxWorldsDir + @"\" + folderName;
                if(!Directory.Exists(extractionPath))
                {
                    Directory.CreateDirectory(extractionPath);
                }
                using(ZipFile zipzip = ZipFile.Read(file))
                {
                    foreach(ZipEntry entry in zipzip)
                    {
                        entry.Extract(extractionPath, ExtractExistingFileAction.OverwriteSilently);
                    }
                }
                MessageBox.Show("Episode installed sucessfully!");
                mf.populateListView();
                this.Close();
            }
            catch(Exception ex)
            {
                if (ex.Message == "Central Directory corrupt.")
                {
                    MessageBox.Show("Episode is being uploaded; try again later!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occurred while processing the zip file!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }

        /*void extractFile(string file)
        {
            /*this.Text = "Extracting..";
            statusLabel.Text = "Extracting...";
            Stream zipFile = new FileStream(Environment.CurrentDirectory + @"\temp\Server\download.zip", FileMode.OpenOrCreate);
            try
            {
                using (var archive = new ZipArchive(zipFile))
                {
                    metroProgressBar1.Value = 0;
                    metroProgressBar1.Maximum = archive.Entries.Count();

                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        if (entry.Name != "")
                        {
                            string folderName = isValidPathName(mf.AvailableEpisodes.availEpisodesListview.SelectedItems[0].Text);

                            string extractionPath = Main_NEW.smbxWorldsDir + @"\"
                                + folderName;
                            if(Directory.Exists(extractionPath) != true)
                            {
                                Directory.CreateDirectory(extractionPath);
                            }
                            var split = entry.FullName.Split(new char[] { '/' }, 2);
                            if (entry.FullName.Contains("/") == true)
                            {

                                try
                                {
                                    Directory.CreateDirectory(extractionPath + @"\" + split[0].ToString());
                                    //MessageBox.Show(extractionPath + @"\" + split[0].ToString() + @"\" + split[1].ToString());
                                    entry.ExtractToFile(extractionPath + @"\" + split[0].ToString() + @"\" + split[1].ToString());
                                }
                                catch
                                {
                                    Console.WriteLine("Needed directory already exists (" + split[0].ToString() + ")");
                                }
                            }
                            else
                            {
                                //MessageBox.Show(Path.Combine(extractionPath, entry.Name));
                                entry.ExtractToFile(Path.Combine(extractionPath, entry.Name), true);
                            }


                            metroProgressBar1.Value += 1;
                            Console.WriteLine("Extracted " + entry.FullName + " to " + Path.Combine(Main_NEW.smbxWorldsDir + @"\" + mf.AvailableEpisodes.availEpisodesListview.SelectedItems[0].Text));
                        }
                    }
                }
                MessageBox.Show("Episode installed sucessfully!");
                mf.populateListView();
                this.Close();
            }
            catch(Exception ex)
            {
                if (ex.Message == "Central Directory corrupt.")
                {
                    MessageBox.Show("Episode is being uploaded; try again later!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occurred while processing the zip file!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }*/
    }
}
