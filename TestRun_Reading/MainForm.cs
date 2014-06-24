using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace IndexGenerator
{
    public partial class MainForm : Form
    {
        public static string pathToTryLoad = null;

        public MainForm(string path)
        {
            pathToTryLoad = path;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetListView();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                directoryText.Text = fbd.SelectedPath.ToString();
                
                //listView1.Clear();
                addLvl(fbd.SelectedPath.ToString());
                addWld(fbd.SelectedPath.ToString());
                addGif(fbd.SelectedPath.ToString());
                addTxt(directoryText.Text);
                addMp3(fbd.SelectedPath.ToString());
            }
            else
            {
                //abort abort its a trap
            }
        }
        //lvl
        public void addLvl(string path)
        {
            
                ListViewItem lvi = new ListViewItem();
                //lvl files first
                DirectoryInfo dinfo = new DirectoryInfo(path);
                FileInfo[] Files = dinfo.GetFiles("*.lvl", SearchOption.AllDirectories);
                foreach (FileInfo file in Files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = file.Name.ToString();
                    listView1.Items.Add(lvi);
                }
            
            
        }
        //wld
        public void addWld(string path)
        {
            ListViewItem lvi = new ListViewItem();
            //lvl files first
            DirectoryInfo dinfo = new DirectoryInfo(path);
            FileInfo[] Files = dinfo.GetFiles("*.wld");
            foreach (FileInfo file in Files)
            {
                lvi = new ListViewItem();
                lvi.Text = file.Name.ToString();
                listView1.Items.Add(lvi);
            }
        }
        //gif
        public void addGif(string path)
        {
            ListViewItem lvi = new ListViewItem();
            //lvl files first
            DirectoryInfo dinfo = new DirectoryInfo(path);
            //Get name of Folder, to check stuff
            string name = path.Remove(0, path.LastIndexOf('\\') + 1);
            //MessageBox.Show(name);
            //
            FileInfo[] Files = dinfo.GetFiles("*.gif", SearchOption.AllDirectories);
            foreach (FileInfo file in Files)
            {
                lvi = new ListViewItem();
                string fullPath = file.FullName.ToString();
                string folderName = Path.GetDirectoryName(fullPath);
                string justPath = new DirectoryInfo(folderName).Name;
                string combined = justPath + @"\" + file.Name.ToString();
                var split = combined.Split(new char[] { '\\' }, 2);
                if(split[0].ToString() == name)
                {
                    lvi.Text = split[1].ToString();
                }
                else
                {
                    lvi.Text = combined;
                }

                listView1.Items.Add(lvi);
            }
        }
        //txt, npc codes
        public void addTxt(string path)
        {
            ListViewItem lvi = new ListViewItem();
            //lvl files first
            DirectoryInfo dinfo = new DirectoryInfo(path);
            //Get name of Folder, to check stuff
            string name = path.Remove(0, path.LastIndexOf('\\') + 1);
            //MessageBox.Show(name);
            //
            FileInfo[] Files = dinfo.GetFiles("*.txt", SearchOption.AllDirectories);
            foreach (FileInfo file in Files)
            {
                lvi = new ListViewItem();
                string fullPath = file.FullName.ToString();
                string folderName = Path.GetDirectoryName(fullPath);
                string justPath = new DirectoryInfo(folderName).Name;
                string combined = justPath + @"\" + file.Name.ToString();
                var split = combined.Split(new char[] { '\\' }, 2);
                if (split[0].ToString() == name)
                {
                    lvi.Text = split[1].ToString();
                }
                else
                {
                    lvi.Text = combined;
                }

                listView1.Items.Add(lvi);
            }
        }
        //mp3
        public void addMp3(string path)
        {
            ListViewItem lvi = new ListViewItem();
            //lvl files first
            DirectoryInfo dinfo = new DirectoryInfo(path);
            FileInfo[] Files = dinfo.GetFiles("*.mp3");
            foreach (FileInfo file in Files)
            {
                lvi = new ListViewItem();
                lvi.Text = file.Name.ToString();
                listView1.Items.Add(lvi);
            }
        }
        public void addWav(string path)
        {
            ListViewItem lvi = new ListViewItem();
            //lvl files first
            DirectoryInfo dinfo = new DirectoryInfo(path);
            FileInfo[] Files = dinfo.GetFiles("*.wav");
            foreach (FileInfo file in Files)
            {
                lvi = new ListViewItem();
                lvi.Text = file.Name.ToString();
                listView1.Items.Add(lvi);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetListView();

            if (Directory.Exists(directoryText.Text))
            {
                addLvl(directoryText.Text);
                addWld(directoryText.Text);
                addGif(directoryText.Text);
                addTxt(directoryText.Text);
                addMp3(directoryText.Text);
                addWav(directoryText.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveChanges();
        }

        private void saveChanges()
        {
            StreamWriter sw = new StreamWriter(directoryText.Text + @"\project.index");
            if (epNameText.Text != null)
            {
                sw.WriteLine("episodeName=" + epNameText.Text);
            }
            if (authorText.Text != null)
            {
                sw.WriteLine("author=" + authorText.Text);
            }
            if (descText.Text != null)
            {
                sw.WriteLine("description=" + descText.Text);
            }
            if (verText.Text != null)
            {
                sw.WriteLine("version=" + verText.Text);
            }
            if (serverLinkText.Text != null)
            {
                sw.WriteLine("server=" + serverLinkText.Text);
            }
            if (forumLinkText.Text != null)
            {
                sw.WriteLine("forumUrl=" + forumLinkText.Text);
            }
            //
            sw.Write("filesList=");
            foreach (ListViewItem item in listView1.Items)
            {
                string fileName = item.Text;
                sw.Write(fileName + ",");
            }
            sw.Dispose();
            sw.Close();
            //write images
            if (screenshot1.screenshot1.Image != null)
            {
                if (File.Exists(directoryText.Text + @"\image1.png"))
                {
                    File.Delete(directoryText.Text + @"\image1.png");
                }
                screenshot1.screenshot1.Image.Save(directoryText.Text + @"\image1.png", ImageFormat.Png);
            }
            if (screenshot2.screenshot1.Image != null)
            {
                if (File.Exists(directoryText.Text + @"\image2.png"))
                {
                    File.Delete(directoryText.Text + @"\image2.png");
                }
                screenshot2.screenshot1.Image.Save(directoryText.Text + @"\image2.png", ImageFormat.Png);
            }
            if (screenshot3.screenshot1.Image != null)
            {
                if (File.Exists(directoryText.Text + @"\image3.png"))
                {
                    File.Delete(directoryText.Text + @"\image3.png");
                }
                screenshot3.screenshot1.Image.Save(directoryText.Text + @"\image3.png", ImageFormat.Png);
            }
            if (screenshot4.screenshot1.Image != null)
            {
                if (File.Exists(directoryText.Text + @"\image4.png"))
                {
                    File.Delete(directoryText.Text + @"\image4.png");
                }
                screenshot4.screenshot1.Image.Save(directoryText.Text + @"\image4.png", ImageFormat.Png);
            }
            //
            if (iconPic1.icon1.Image != null)
            {
                if (File.Exists(directoryText.Text + @"\icon.png"))
                {
                    File.Delete(directoryText.Text + @"\icon.png");
                }
                iconPic1.icon1.Image.Save(directoryText.Text + @"\icon.png", ImageFormat.Png);
            }
            //
            MessageBox.Show("Done.");
        }

        private void resetListView()
        {
            foreach(ListViewItem lvi in listView1.Items)
            {
                lvi.Remove();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Project Index Files (project.index)|project.index|All Index Files (*.index)|*.index";

            if(of.ShowDialog() == DialogResult.OK)
            {
                resetListView();
                string dirToLoad = Path.GetDirectoryName(of.FileName).ToString();
                using (StreamReader sr = new StreamReader(of.FileName))
                {
                    string line;
                    
                    ListViewItem lvi = new ListViewItem();
                    Console.WriteLine();
                    directoryText.Text = Path.GetDirectoryName(of.FileName).ToString();

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("filesList"))
                        {
                            var split = line.Split(new char[] { '=' }, 2);
                            string[] fileslist = split[1].Split(',');
                            foreach(var item in fileslist)
                            {
                                if (item != "")
                                {
                                    lvi = new ListViewItem();
                                    lvi.Text = item.ToString();
                                    listView1.Items.Add(lvi);
                                }
                            }
                        }
                        if (line.Contains("episodeName"))
                        {
                            var split = line.Split(new char[] { '=' }, 2);
                            epNameText.Text = split[1].ToString();
                        }
                        if (line.Contains("author"))
                        {
                            var split = line.Split(new char[] { '=' }, 2);
                            authorText.Text = split[1].ToString();
                        }
                        if (line.Contains("description"))
                        {
                            var split = line.Split(new char[] { '=' }, 2);
                            descText.Text = split[1].ToString();
                        }
                        if (line.Contains("version"))
                        {
                            var split = line.Split(new char[] { '=' }, 2);
                            verText.Text = split[1].ToString();
                        }
                        if (line.Contains("server"))
                        {
                            var split = line.Split(new char[] { '=' }, 2);
                            serverLinkText.Text = split[1].ToString();
                        }
                        if (line.Contains("forumUrl"))
                        {
                            var split = line.Split(new char[] { '=' }, 2);
                            forumLinkText.Text = split[1].ToString();
                        }

                       
                        //
                    }
                }

                if (File.Exists(dirToLoad + @"\image1.png"))
                {
                    using (Image sourceImg = Image.FromFile(directoryText.Text + @"\image1.png"))
                    {
                        Image clonedImg = new Bitmap(sourceImg.Width, sourceImg.Height, PixelFormat.Format32bppArgb);
                        using (var copy = Graphics.FromImage(clonedImg))
                        {
                            copy.DrawImage(sourceImg, 0, 0);
                        }
                        screenshot1.screenshot1.Image = null;
                        screenshot1.screenshot1.Image = clonedImg;
                        sourceImg.Dispose();
                    }
                }
                else
                {
                    screenshot1.screenshot1.Image = null;
                }
                if (File.Exists(dirToLoad + @"\image2.png"))
                {
                    using (Image sourceImg = Image.FromFile(directoryText.Text + @"\image2.png"))
                    {
                        Image clonedImg = new Bitmap(sourceImg.Width, sourceImg.Height, PixelFormat.Format32bppArgb);
                        using (var copy = Graphics.FromImage(clonedImg))
                        {
                            copy.DrawImage(sourceImg, 0, 0);
                        }
                        screenshot2.screenshot1.Image = null;
                        screenshot2.screenshot1.Image = clonedImg;
                        sourceImg.Dispose();
                    }
                }
                else
                {
                    screenshot2.screenshot1.Image = null;
                }
                if (File.Exists(dirToLoad + @"\image3.png"))
                {
                    using (Image sourceImg = Image.FromFile(directoryText.Text + @"\image3.png"))
                    {
                        Image clonedImg = new Bitmap(sourceImg.Width, sourceImg.Height, PixelFormat.Format32bppArgb);
                        using (var copy = Graphics.FromImage(clonedImg))
                        {
                            copy.DrawImage(sourceImg, 0, 0);
                        }
                        screenshot3.screenshot1.Image = null;
                        screenshot3.screenshot1.Image = clonedImg;
                    }
                }
                else
                {
                    screenshot3.screenshot1.Image = null;
                }
                if (File.Exists(dirToLoad + @"\image4.png"))
                {
                    using (Image sourceImg = Image.FromFile(directoryText.Text + @"\image4.png"))
                    {
                        Image clonedImg = new Bitmap(sourceImg.Width, sourceImg.Height, PixelFormat.Format32bppArgb);
                        using (var copy = Graphics.FromImage(clonedImg))
                        {
                            copy.DrawImage(sourceImg, 0, 0);
                        }
                        screenshot4.screenshot1.Image = null;
                        screenshot4.screenshot1.Image = clonedImg;
                    }
                }
                else
                {
                    screenshot4.screenshot1.Image = null;
                }
                //
                if (File.Exists(dirToLoad + @"\icon.png"))
                {
                    using (Image sourceImg = Image.FromFile(directoryText.Text + @"\icon.png"))
                    {
                        Image clonedImg = new Bitmap(sourceImg.Width, sourceImg.Height, PixelFormat.Format32bppArgb);
                        using (var copy = Graphics.FromImage(clonedImg))
                        {
                            copy.DrawImage(sourceImg, 0, 0);
                        }
                        iconPic1.icon1.Image = null;
                        iconPic1.icon1.Image = clonedImg;
                        sourceImg.Dispose();
                    }
                }
                else
                {
                    iconPic1.icon1.Image = null;
                }
            }
            else
            {
                //abort lmao
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            TextEditor textEdit = new TextEditor();
            
            textEdit.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(directoryText.Text == "")
            {
                MessageBox.Show("No directory has been input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(Directory.Exists(directoryText.Text))
                {
                    foreach (ListViewItem lvi in listView1.Items)
                    {
                        lvi.Remove();
                    }
                    try
                    {
                        addLvl(directoryText.Text);
                        addWld(directoryText.Text);
                        addGif(directoryText.Text);
                        addTxt(directoryText.Text);
                        addMp3(directoryText.Text);
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (StreamWriter sww = new StreamWriter(directoryText.Text + @"\changes.index"))
            {
                
                EnterVersion ev = new EnterVersion();
                if(ev.ShowDialog() == DialogResult.OK)
                {
                    sww.WriteLine("version=" + ev.newVers.ToString());
                    verText.Text = ev.newVers.ToString();
                }

                sww.Write("changedFiles=");
                foreach(ListViewItem lvi in listView1.Items)
                {
                    if (lvi.Checked == true)
                    {
                        sww.Write(lvi.Text + ",");
                    }
                }
                sww.Flush();
                sww.Dispose();
                DialogResult dr = MessageBox.Show("Would you like to copy the changed files to a directory on the desktop?", 
                    "Question", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);
                switch(dr)
                {
                    case DialogResult.Yes:
                        copyChanged();
                        break;

                    case DialogResult.No:
                        break;
                }
                
            }
            saveChanges();
            MessageBox.Show("Done!");
        }

        private void copyChanged()
        {
            

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            MessageBox.Show(desktopPath);
            string copyFromUrl = directoryText.Text;
            string copyToUrl = desktopPath + @"\SMBX Changes\" + epNameText.Text;
            Directory.Delete(copyToUrl, true);
            try
            {
                //epNameText
                Directory.CreateDirectory(copyToUrl + @"\" + epNameText.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach(ListViewItem lvi in listView1.Items)
            {
                if(lvi.Checked == true)
                {
                    try
                    {
                        try
                        {
                            File.Copy(copyFromUrl + @"\" + lvi.Text, copyToUrl + @"\" + lvi.Text, true);
                        }
                        catch(DirectoryNotFoundException dx)
                        {
                            //"bonus1\npc-1.gif"
                            string dirToCopyFrom = lvi.Text;
                            var dir = dirToCopyFrom.Split(new char[] { '\\' }, 2);
                            string dirr = dir[0].ToString();
                            //
                            if (Directory.Exists(copyToUrl + @"\" + dirr) != true)
                            {
                                Directory.CreateDirectory(copyToUrl + @"\" + dirr);
                            }
                            //
                            File.Copy(copyFromUrl + @"\" + lvi.Text, copyToUrl + @"\" + lvi.Text, true);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            File.Copy(copyFromUrl + @"\changes.index", copyToUrl + @"\changes.index", true);
        }
        private void screenshot1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fileVersionInfo.ProductVersion;
            vLabel.Text = "Version " + version;

            if(pathToTryLoad != "null")
            {
                directoryText.Text = pathToTryLoad;
                foreach (ListViewItem lvi in listView1.Items)
                {
                    lvi.Remove();
                }
                
                    try
                    {
                        addLvl(directoryText.Text);
                        addWld(directoryText.Text);
                        addGif(directoryText.Text);
                        addTxt(directoryText.Text);
                        addMp3(directoryText.Text);
                        if (File.Exists(pathToTryLoad + @"\image1.png"))
                        {
                            using (Image sourceImg = Image.FromFile(directoryText.Text + @"\image1.png"))
                            {
                                Image clonedImg = new Bitmap(sourceImg.Width, sourceImg.Height, PixelFormat.Format32bppArgb);
                                using (var copy = Graphics.FromImage(clonedImg))
                                {
                                    copy.DrawImage(sourceImg, 0, 0);
                                }
                                screenshot1.screenshot1.Image = null;
                                screenshot1.screenshot1.Image = clonedImg;
                            }
                        }
                        if (File.Exists(pathToTryLoad + @"\image2.png"))
                        {
                            using (Image sourceImg = Image.FromFile(directoryText.Text + @"\image1.png"))
                            {
                                Image clonedImg = new Bitmap(sourceImg.Width, sourceImg.Height, PixelFormat.Format32bppArgb);
                                using (var copy = Graphics.FromImage(clonedImg))
                                {
                                    copy.DrawImage(sourceImg, 0, 0);
                                }
                                screenshot1.screenshot1.Image = null;
                                screenshot1.screenshot1.Image = clonedImg;
                            }
                        }
                        if (File.Exists(pathToTryLoad + @"\image3.png"))
                        {
                            using (Image sourceImg = Image.FromFile(directoryText.Text + @"\image1.png"))
                            {
                                Image clonedImg = new Bitmap(sourceImg.Width, sourceImg.Height, PixelFormat.Format32bppArgb);
                                using (var copy = Graphics.FromImage(clonedImg))
                                {
                                    copy.DrawImage(sourceImg, 0, 0);
                                }
                                screenshot1.screenshot1.Image = null;
                                screenshot1.screenshot1.Image = clonedImg;
                            }
                        }
                        if (File.Exists(pathToTryLoad + @"\image4.png"))
                        {
                            using (Image sourceImg = Image.FromFile(directoryText.Text + @"\image1.png"))
                            {
                                Image clonedImg = new Bitmap(sourceImg.Width, sourceImg.Height, PixelFormat.Format32bppArgb);
                                using (var copy = Graphics.FromImage(clonedImg))
                                {
                                    copy.DrawImage(sourceImg, 0, 0);
                                }
                                screenshot1.screenshot1.Image = null;
                                screenshot1.screenshot1.Image = clonedImg;
                            }
                        }
                        if (File.Exists(pathToTryLoad + @"\icon.png"))
                        {
                            using (Image sourceImg = Image.FromFile(directoryText.Text + @"\icon.png"))
                            {
                                Image clonedImg = new Bitmap(sourceImg.Width, sourceImg.Height, PixelFormat.Format32bppArgb);
                                using (var copy = Graphics.FromImage(clonedImg))
                                {
                                    copy.DrawImage(sourceImg, 0, 0);
                                }
                                screenshot1.screenshot1.Image = null;
                                screenshot1.screenshot1.Image = clonedImg;
                            }
                        }
                    }
                    catch (DirectoryNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in listView1.Items)
            {
                lvi.Checked = true;
            }
        }
        #region Language Changes
        CultureInfo CurrentLocale;
        private void selectLanguageButton_Click(object sender, EventArgs e)
        {
            switch(languageComboBox.Text)
            {
                case("English"):
                    ChangeLanguage("en-US");
                    break;
                case("Portuguese"):
                    ChangeLanguage("pt-BR");
                    break;
            }
        }
        private void ChangeLanguage(string lang)
        {
            CurrentLocale = new CultureInfo(lang);
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
                resources.ApplyResources(c, "$this");
                RefreshResources(this, resources);
            }

        }
        private void RefreshResources(Control ctrl, ComponentResourceManager res)
        {
            ctrl.SuspendLayout();
            res.ApplyResources(ctrl, ctrl.Name, CurrentLocale);
            foreach (Control control in ctrl.Controls)
            {
                if (control == screenshot1)
                {

                }
                else if (control == screenshot2)
                {

                }
                else if (control == screenshot3)
                {

                }
                else if (control == screenshot4)
                {

                }
                else if (control == iconPic1)
                {

                }
                else
                {
                    RefreshResources(control, res); // recursion
                }
            }
                
            ctrl.ResumeLayout(false);
        }
        #endregion

        private void menuItem5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to quit?", "Index Generator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch(dr)
            {
                case DialogResult.Yes:
                    Environment.Exit(0);
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.supermariobrosx.org/forums/viewtopic.php?f=69&t=455#p3247");
        }

        private void uncheckAllButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.Items)
            {
                lvi.Checked = false;
            }
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }
        /*
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if(lvlCb.Checked == true)
                {
                    string itemstring = item.ToString();
                    var split = itemstring.Split(new char[] { '.' }, 2);
                    if (split[1].ToString() == "lvl")
                    {
                        //keep item
                    }
                    else
                    {
                        if (wldCb.Checked == true)
                        {
                            string itemstring3 = item.ToString();
                            var split3 = itemstring.Split(new char[] { '.' }, 2);
                            if (split3[1].ToString() == "wld")
                            {
                                //keep item
                            }
                            else
                            {
                                if (gifCb.Checked == true)
                                {
                                    string itemstring1 = item.ToString();
                                    var split1 = itemstring.Split(new char[] { '.' }, 2);
                                    if (split1[1].ToString() == "gif")
                                    {
                                        //keep item
                                    }
                                    else
                                    {
                                        if (mp3Cb.Checked == true)
                                        {
                                            string itemstring2 = item.ToString();
                                            var split2 = itemstring.Split(new char[] { '.' }, 2);
                                            if (split2[1].ToString() == "mp3")
                                            {
                                                //keep item
                                            }
                                            else
                                            {
                                                listView1.Items.Remove(item);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                
                
                

            }
        }*/


    }
}
