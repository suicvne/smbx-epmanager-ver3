using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Components;
using MetroFramework.Interfaces;
using Setting;
using IndexReader;

namespace EpisodeManager_WinForms
{
    public partial class Form1 : MetroForm
    {
        //import the indexreader class
        IniFile settingsIni = new IniFile(Environment.CurrentDirectory + @"\settings.ini");
        public static string forumLink;
        public static string serverUrl;
        public static string smbxDir;
        public static string smbxExeLoc;
        public static string smbxWorldsDir;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            epInfoPanel.BackgroundImage = null;
            smbxWorldsDir = settingsIni.ReadValue("Settings", "worldlocation");
            smbxDir = settingsIni.ReadValue("Settings", "smbxpath");
            smbxExeLoc = settingsIni.ReadValue("Settings", "executableloc");
        }

        private void populateListView()
        {
            ListViewItem lvi = new ListViewItem();
            
        }
    }
}
