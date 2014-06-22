using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EpisodeManager_WinForms
{
    public partial class LoadingIndexDialog : MetroForm
    {
        public LoadingIndexDialog(AvailableEpisodesControl _Available)
        {
            aec = _Available;
            InitializeComponent();
        }
        AvailableEpisodesControl aec { get; set; }
        private void LoadingIndexDialog_Load(object sender, EventArgs e)
        {
            try
            {
                XDocument docu = XDocument.Load("https://dl.dropboxusercontent.com/u/62304851/index.xml");
                aec.queryData(docu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
