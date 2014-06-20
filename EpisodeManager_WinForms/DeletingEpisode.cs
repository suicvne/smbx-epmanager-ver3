using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpisodeManager_WinForms
{
    public partial class DeletingEpisode : MetroForm
    {
        string epToDelete;
        public DeletingEpisode(string episodeToDelete, Main_NEW _Main_NEW)
        {
            mf = _Main_NEW;
            epToDelete = episodeToDelete;
            InitializeComponent();
        }
        Main_NEW mf { get; set; }
        private void DeletingEpisode_Load(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.RunWorkerAsync();

        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Directory.Delete(epToDelete, true);
                mf.populateListView();
                MessageBox.Show("Episode deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error deleting the episode!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
