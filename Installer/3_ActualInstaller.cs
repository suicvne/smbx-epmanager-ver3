using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.IO;
using IWshRuntimeLibrary;

namespace Installer
{
    public partial class _3_ActualInstaller : Form
    {
        public _3_ActualInstaller()
        {
            InitializeComponent();
        }

        private void _3_ActualInstaller_Load(object sender, EventArgs e)
        {
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            textBox2.Text = documentsFolder + @"\SMBX Episode Manager";
            label2.Text = "Install SMBX Episode Manager";
        }

        private void changeDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = fbd.SelectedPath.ToString() + @"\SMBX Episode Manager";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox2.Enabled = false;
            changeDirectory.Enabled = false;
            addIndexGenerator.Enabled = false;
            Computer MyComputer = new Computer();
            string[] filePaths = null;
            try
            {
                 filePaths = Directory.GetFiles(textBox2.Text);
                 foreach (string filePath in filePaths)
                 {
                     var name = new FileInfo(filePath).Name;
                     name = name.ToLower();
                     if (name != "settings.ini")
                     {
                         System.IO.File.Delete(filePath);
                     }
                 }
            }
            catch(Exception ignore)
            {
                Console.WriteLine("No files needed to delete");
            }
            
            textBox1.Text = "Downloading latest SMBX Episode Manager...\n";
            if(Directory.Exists(textBox2.Text) != true)
            {
                Directory.CreateDirectory(textBox2.Text);
            }
            MyComputer.Network.DownloadFile("http://mrmiketheripper.x10.mx/epmanager3/SMBXEpisodeManager_Latest.exe", textBox2.Text + @"\SMBXEpisodeManager.exe", null, null, true, 1000, true);
            if(addIndexGenerator.Checked == true)
            {
                textBox1.Text = textBox1.Text + "\nDownloading Index Generator...\n";
                MyComputer.Network.DownloadFile("http://mrmiketheripper.x10.mx/epmanager3/IndexGenerator.exe", textBox2.Text + @"\IndexGenerator.exe", null, null, true, 10000, true);
            }
            textBox1.Text = textBox1.Text + "\nWriting shortcut to desktop..\n";
            string ver = MyComputer.Info.OSVersion;
            string[] split = ver.Split(new char[] { '.' });
            string final = split[0].ToString() + "." + split[1].ToString();
            decimal finall = decimal.Parse(final);
            if(finall == new decimal(5.1) || finall == new decimal(5.2))
            {
                textBox1.Text = textBox1.Text + "\nInstalling XP specific fonts...\n";
                MyComputer.Network.DownloadFile("http://mrmiketheripper.x10.mx/epmanager3/Open_Sans.ttf", textBox2.Text + @"\Open_Sans.ttf", null, null, true, 10000, true);
                System.IO.File.Move(textBox2.Text + @"\Open_Sans.ttf", @"C:\WINDOWS\Fonts\Open_Sans.ttf");
                MyComputer.Network.DownloadFile("http://mrmiketheripper.x10.mx/epmanager3/Open_Sans_Light.ttf", textBox2.Text + @"\Open_Sans_Light.ttf", null, null, true, 10000, true);
                System.IO.File.Move(textBox2.Text + @"\Open_Sans.ttf", @"C:\WINDOWS\Fonts\Open_Sans_Light.ttf");
                MyComputer.Network.DownloadFile("http://mrmiketheripper.x10.mx/epmanager3/Open_Sans_Bold.ttf", textBox2.Text + @"\Open_Sans_Bold.ttf", null, null, true, 10000, true);
                System.IO.File.Move(textBox2.Text + @"\Open_Sans.ttf", @"C:\WINDOWS\Fonts\Open_Sans_Bold.ttf");
            }
            CreateShortcut();
            MessageBox.Show("Installer completed successfully!");
            Environment.Exit(0);
        }

        private void appShortcutToDesktop(string linkName)
        {
            string deskDir = "";


            using (StreamWriter writer = new StreamWriter(deskDir + "\\" + linkName + ".url"))
            {
                string app = textBox2.Text + @"\SMBXEpisodeManager.exe";
                writer.WriteLine("[InternetShortcut]");
                writer.WriteLine("URL=file:///" + app);
                writer.WriteLine("IconIndex=0");
                string icon = app.Replace('\\', '/');
                writer.WriteLine("IconFile=" + icon);
                writer.Flush();
            }
        }

        private void CreateShortcut()
        {
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\SMBX Episode Manager.lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "SMBX Episode Manager";
            shortcut.TargetPath = textBox2.Text + @"\SMBXEpisodeManager.exe";
            shortcut.WorkingDirectory = textBox2.Text;
            shortcut.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want to quit the installer?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Yes:
                    Environment.Exit(0);
                    break;
                case DialogResult.No:
                    break;
            }
        }

    }
}
