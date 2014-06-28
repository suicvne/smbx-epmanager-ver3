using MetroFramework.Forms;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpisodeManager_WinForms
{
    public partial class WhichEpisode : MetroForm
    {
        public WhichEpisode(LocalEpisodesControl _LocalEpisodesControl, string serverUrl)
        {
            le = _LocalEpisodesControl;
            url = serverUrl;
            InitializeComponent();
        }
        LocalEpisodesControl le { get; set; }
        string url { get; set; }
        private void WhichEpisode_Load(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in le.localEpisodesListview.Items)
            {
                listView1.Items.Add((ListViewItem)lvi.Clone());
            }
        }

        private void lockInButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you wish to download project files for '" + listView1.SelectedItems[0].Text + 
                "'?\nThis will download the project's Index, Screenshots, and Icon from the project you selected in the Available Episodes tab", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch(dr)
            {
                case(DialogResult.Yes):
                    downloadFiles();
                    break;
                case(DialogResult.No):
                    break;
            }
        }

        private void downloadFiles()
        {
            Computer myComputer = new Computer();
            string destination = Main_NEW.smbxWorldsDir + @"\" + listView1.SelectedItems[0].Text;
            string file = null;
            try
            {
                file = "project.index";
                myComputer.Network.DownloadFile(url + "project.index", destination + @"\project.index", null, null, true, 30000, true);
                file = "image1.png";
                myComputer.Network.DownloadFile(url + "image1.png", destination + @"\image1.png", null, null, true, 30000, true);
                file = "image2.png";
                myComputer.Network.DownloadFile(url + "image2.png", destination + @"\image2.png", null, null, true, 30000, true);
                file = "image3.png";
                myComputer.Network.DownloadFile(url + "image3.png", destination + @"\image3.png", null, null, true, 30000, true);
                file = "image4.png";
                myComputer.Network.DownloadFile(url + "image4.png", destination + @"\image4.png", null, null, true, 30000, true);
                file = "icon.png";
                myComputer.Network.DownloadFile(url + "icon.png", destination + @"\icon.png", null, null, true, 30000, true);

                MessageBox.Show("Process completed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an error downloading '" + file + "'\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
