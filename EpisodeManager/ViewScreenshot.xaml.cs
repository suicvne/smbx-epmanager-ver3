using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EpisodeManager
{
    /// <summary>
    /// Interaction logic for ViewScreenshot.xaml
    /// </summary>
    public partial class ViewScreenshot : Window
    {
        public ViewScreenshot()
        {
            InitializeComponent();
        }

        private void ss_view_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
