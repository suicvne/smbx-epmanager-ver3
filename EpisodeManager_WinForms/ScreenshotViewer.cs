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
    public partial class ScreenshotViewer : Form
    {
        public ScreenshotViewer()
        {
            InitializeComponent();
        }

        private void ScrenshotViewer_Load(object sender, EventArgs e)
        {

        }

        private void ScrenshotViewer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
