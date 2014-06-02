using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EpisodeManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void populateListView()
        {
            ListViewItem lvi = new ListViewItem();
            DirectoryInfo dinfo = new DirectoryInfo(@"E:\SMBX\worlds");
            foreach (var d in dinfo.GetDirectories())
            {
                lvi = new ListViewItem();
                lvi.Content = d.ToString();
                localEpisodesList.Items.Add(lvi);
            }
        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListViewItem lvi = ((sender as ListView).SelectedItem as ListViewItem);

            if (File.Exists(@"E:\SMBX\worlds\" + lvi.Content.ToString() + @"\project.index") == true)
            {
                string pathToLoadFrom = @"E:\SMBX\worlds\" + lvi.Content.ToString();
                
                

            }
            else
            {
                episodeName.Text = lvi.Content.ToString();
                authorLabel.Text = "";
                descriptionLabel.Text = "This episode doesn't seem to have an index file associated with it. :(";
            }
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            populateListView();
            localEpisodesList.SelectedIndex = 0;
        }

    }
}
