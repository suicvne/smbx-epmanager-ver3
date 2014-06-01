using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestRun_Reading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
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
            FileInfo[] Files = dinfo.GetFiles("*.gif", SearchOption.AllDirectories);
            foreach (FileInfo file in Files)
            {
                lvi = new ListViewItem();
                string fullPath = file.FullName.ToString();
                string folderName = Path.GetDirectoryName(fullPath);
                string justPath = new DirectoryInfo(folderName).Name;
                
                lvi.Text = justPath + @"\" + file.Name.ToString();
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
                addMp3(directoryText.Text);
                addWav(directoryText.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(directoryText.Text + @"\project.index");
            if(epNameText.Text != null)
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
            if(serverLinkText.Text != null)
            {
                sw.WriteLine("server=" + serverLinkText.Text);
            }
            if(forumLinkText.Text != null)
            {
                sw.WriteLine("forumUrl=" + forumLinkText.Text);
            }

            //write images
            if(screenshot1.screenshot1.Image != null)
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
            sw.Write("filesList=");
            foreach (ListViewItem item in listView1.Items)
            {
                string fileName = item.Text;
                sw.Write(fileName + ",");
            }
            sw.Close();
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
            of.Filter = "Index Files (*.index)|*.index";

            if(of.ShowDialog() == DialogResult.OK)
            {
                resetListView();
                using (StreamReader sr = new StreamReader(of.FileName))
                {
                    string line;
                    ListViewItem lvi = new ListViewItem();
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

                        if (File.Exists(directoryText.Text + @"\image1.png"))
                        {
                            Image art = Image.FromFile(directoryText.Text + @"\image1.png");
                            screenshot1.screenshot1.Image = art;
                        }
                        else
                        {
                            screenshot1.screenshot1.Image = null;
                        }
                        if (File.Exists(directoryText.Text + @"\image2.png"))
                        {
                            Image art = Image.FromFile(directoryText.Text + @"\image2.png");
                            screenshot2.screenshot1.Image = art;
                        }
                        else
                        {
                            screenshot2.screenshot1.Image = null;
                        }
                        if (File.Exists(directoryText.Text + @"\image3.png"))
                        {
                            Image art = Image.FromFile(directoryText.Text + @"\image3.png");
                            screenshot3.screenshot1.Image = art;
                        }
                        else
                        {
                            screenshot3.screenshot1.Image = null;
                        }
                        if (File.Exists(directoryText.Text + @"\image4.png"))
                        {
                            Image art = Image.FromFile(directoryText.Text + @"\image4.png");
                            screenshot4.screenshot1.Image = art;
                        }
                        else
                        {
                            screenshot4.screenshot1.Image = null;
                        }
                    }
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
            textEdit.textBox1.Text = descText.Text;
            textEdit.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in listView1.Items)
            {
                lvi.Remove();
            }
            try
            {
                addLvl(directoryText.Text);
                addWld(directoryText.Text);
                addGif(directoryText.Text);
                addMp3(directoryText.Text);
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }

                sww.Write("changedFiles=");
                foreach(ListViewItem lvi in listView1.Items)
                {
                    if (lvi.Checked == true)
                    {
                        sww.Write(lvi.Text + ",");
                    }
                }
            }
            MessageBox.Show("Done!");
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
