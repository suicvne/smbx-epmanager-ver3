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
using Microsoft.VisualBasic.Devices;
using System.Threading;

namespace EpisodeManager_WinForms
{
    public partial class SettingsForm : MetroForm
    {
        public SettingsForm(Main_NEW _Main_NEW)
        {
            mf = _Main_NEW;
            InitializeComponent();
        }
        static bool hasIndexGenerator;
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
            indexGeneratorGb.BackColor = Color.White;
            smbxSettingsGb.BackColor = Color.White;
            cacheManagerGb.BackColor = Color.White;
            metroTabControl1.SelectedIndex = 0;

            try
            {
                checkIndexGeneratorVersion();
            }
            catch
            {

            }

            smbxPathTb.Text = Main_NEW.smbxDir;
            worldPathTb.Text = Main_NEW.smbxWorldsDir;
            execLocTb.Text = Main_NEW.smbxExeLoc;

            if (File.Exists(Main_NEW.smbxExeLoc) == true)
            {
                string ver = GetFileVersionInfo(Main_NEW.smbxExeLoc).ToString();
                if(!String.IsNullOrEmpty(ver))
                { 
                    smbxversionlabel.Text = "SMBX Found: " + GetFileVersionInfo(Main_NEW.smbxExeLoc).ToString();
                }
                else if(ver == "1.03")
                {
                    smbxversionlabel.Text = "SMBX Found: 1.3";
                }
                else
                {
                    smbxversionlabel.Text = "SMBX Found! Version Unknown." + GetFileVersionInfo(Main_NEW.smbxExeLoc).ToString();
                }
                smbxversionlabel.ForeColor = Color.DarkGreen;
            }
            else
            {
                smbxversionlabel.Text = "Couldn't find SMBX!";
                smbxversionlabel.ForeColor = Color.DarkRed;
            }
            //
            totalCacheLabel.Text = "Calculating...";
            Thread t = new Thread(calculateSize);
            t.Start();
            
        }

        private void calculateSize()
        {
            DirectoryInfo dInfo = new DirectoryInfo(Environment.CurrentDirectory + @"\temp\Server\Cache");
            long sizeOfDir = DirectorySize(dInfo, true);
            totalCacheLabel.Text = string.Format("Total Cache Size: {0}MB", Math.Round(((double)sizeOfDir) / (1024 * 1024), 2));
        }

        static long DirectorySize(DirectoryInfo dInfo, bool includeSubDir)
        {
            // Enumerate all the files
            long totalSize = dInfo.EnumerateFiles()
                         .Sum(file => file.Length);

            // If Subdirectories are to be included
            if (includeSubDir)
            {
                // Enumerate all sub-directories
                totalSize += dInfo.EnumerateDirectories()
                         .Sum(dir => DirectorySize(dir, true));
            }
            return totalSize;
        }

        private void checkIndexGeneratorVersion()
        {

            if(File.Exists(Environment.CurrentDirectory + @"\IndexGenerator.exe"))
            {
                string curVer = GetFileVersionInfo(Environment.CurrentDirectory + @"\IndexGenerator.exe").ToString();
                indexGenVerLabel.Text = "Downloaded Index Generator Version: " + curVer;
                updateIndexGen.Enabled = false;
                updateIndexGen.Text = "Checking for updates...";
                igVerCheckSpinner.Visible = true;
                checkIndexGeneratorUpdates.RunWorkerAsync();
            }
            else
            {
                indexGenVerLabel.Text = "Index Generator not available!";
                availIgVerLabel.Text = "";
                updateIndexGen.Text = "DOWNLOAD NOW";
                updateIndexGen.Enabled = true;
                igVerCheckSpinner.Visible = false;
                hasIndexGenerator = false;
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
                String ver = GetFileVersionInfo(execLocTb.Text).ToString();
                if(!String.IsNullOrEmpty(ver))
                {
                    smbxversionlabel.Text = "SMBX Found: " + ver;
                }
                else if (ver == "1.03")
                {
                    smbxversionlabel.Text = "SMBX Found: 1.3";
                }
                else
                {
                    smbxversionlabel.Text = "SMBX Found! Version Unknown." + GetFileVersionInfo(execLocTb.Text).ToString();
                }
                smbxversionlabel.ForeColor = Color.DarkGreen;
            }
            else
            {
                smbxversionlabel.Text = "Couldn't find SMBX!";
                smbxversionlabel.ForeColor = Color.DarkRed;
            }
        }

        private void checkIndexGeneratorUpdates_DoWork(object sender, DoWorkEventArgs e)
        {
            string availVer;
            string currentVer = GetFileVersionInfo(Environment.CurrentDirectory + @"\IndexGenerator.exe").ToString();
            int curVerInt;
            int availVerInt;
            //try
            //{
                Computer myComputer = new Computer();
                myComputer.Network.DownloadFile("http://mrmiketheripper.x10.mx/epmanager3/igver.txt", Environment.CurrentDirectory + @"\temp\igver.txt", null, null, false, 30000, true);
                using(StreamReader sr = new StreamReader(Environment.CurrentDirectory + @"\temp\igver.txt"))
                {
                    availVer = sr.ReadLine().ToString();
                    availVerInt = verStringToInt(availVer);
                    availIgVerLabel.Text = "Available Index Generator Version: " + availVer;
                }
                curVerInt = verStringToInt(currentVer);
                if(availVerInt > curVerInt)
                {
                    //update 
                    updateIndexGen.Enabled = true;
                    updateIndexGen.Text = "UPDATE AVAILABLE!";
                    igVerCheckSpinner.Visible = false;
                    hasIndexGenerator = true;
                    metroTabPage2.Text = "Index Generator +1";
                }
                else
                {
                    updateIndexGen.Enabled = false;
                    updateIndexGen.Text = "No update needed! :)";
                    igVerCheckSpinner.Visible = false;
                    hasIndexGenerator = true;
                }

            //}
            //catch(Exception ex)
            //{
             //   MessageBox.Show(ex.Message);
            //}
        }

        private int verStringToInt(string ver)
        {
            string[] split = ver.Split(new Char[] { '.' });
            string together = split[0].ToString() + split[1].ToString() + split[2].ToString() + split[3].ToString();
            return int.Parse(together);
        }

        private void updateIndexGen_Click(object sender, EventArgs e)
        {
            try
            {
                Computer myComputer = new Computer();
                myComputer.Network.DownloadFile("http://mrmiketheripper.x10.mx/epmanager3/IndexGenerator.exe", Environment.CurrentDirectory + @"\IndexGenerator.exe", null, null, true, 30000, true);
                checkIndexGeneratorVersion();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void clearCacheButton_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(Environment.CurrentDirectory + @"\temp\Server\Cache", true);
                MessageBox.Show("Cache deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                totalCacheLabel.Text = "0.00 MB";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error when trying to delete cache!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showCacheButton_Click(object sender, EventArgs e)
        {
            PopulateTree(Environment.CurrentDirectory + @"\temp\Server\Cache", cacheTreeView.Nodes.Add("Cache"));
            showCacheButton.Enabled = false;
        }

        public void PopulateTree(string dir, TreeNode node)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(dir);
                foreach (DirectoryInfo d in directory.GetDirectories())
                {
                    TreeNode t = new TreeNode(d.Name);
                    PopulateTree(d.FullName, t);
                    node.Nodes.Add(t);
                }
                foreach (FileInfo f in directory.GetFiles())
                {
                    if (f.ToString().Contains(".db") != true)
                    {
                        TreeNode t = new TreeNode(f.Name);
                        if (t.Text.Contains(".png"))
                        {
                            t.ToolTipText = "PNG Image";
                        }
                        else if (t.Text.Contains(".index"))
                        {
                            t.ToolTipText = "Index File";
                        }
                        else
                        {
                            t.ToolTipText = "Other";
                        }
                        node.Nodes.Add(t);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Cache doesn't exist!");
            }
            
        }

        private void execLocTb_Click(object sender, EventArgs e)
        {

        }
    
    }
}
