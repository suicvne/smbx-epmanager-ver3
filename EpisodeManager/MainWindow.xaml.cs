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
using IndexReader;

namespace EpisodeManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        IndexReaderClass inReader = new IndexReaderClass();
        public static int randomNumber;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void populateListView()
        {
            ListViewItem lvi = new ListViewItem();
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\SMBX\worlds");
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

            if (File.Exists(@"C:\SMBX\worlds\" + lvi.Content.ToString() + @"\project.index") == true)
            {
                string pathToLoadFrom = @"C:\SMBX\worlds\" + lvi.Content.ToString();
                string indexToLoad = pathToLoadFrom + @"\project.index";
                episodeName.Text = inReader.episodeName(indexToLoad);
                authorLabel.Text = "by: " + inReader.authorName(indexToLoad);
                descriptionLabel.Text = inReader.descriptionText(indexToLoad);

                rng();

                if(randomNumber == 0)
                {
                    bgss.Source = new BitmapImage(new Uri(pathToLoadFrom + @"\image1.png"));
                }
                else if(randomNumber == 1)
                {
                    bgss.Source = new BitmapImage(new Uri(pathToLoadFrom + @"\image2.png"));
                }
                else if(randomNumber == 2)
                {
                    bgss.Source = new BitmapImage(new Uri(pathToLoadFrom + @"\image3.png"));
                }
                else if(randomNumber == 3)
                {
                    bgss.Source = new BitmapImage(new Uri(pathToLoadFrom + @"\image4.png"));
                }
                
                //bgss.Source = new BitmapImage(new Uri(indexToLoad + @"\image1.png"));
                ss1.Source = new BitmapImage(new Uri(pathToLoadFrom + @"\image1.png"));
                ss2.Source = new BitmapImage(new Uri(pathToLoadFrom + @"\image2.png"));
                ss3.Source = new BitmapImage(new Uri(pathToLoadFrom + @"\image3.png"));
                ss4.Source = new BitmapImage(new Uri(pathToLoadFrom + @"\image4.png"));

            }
            else
            {
                episodeName.Text = lvi.Content.ToString();
                authorLabel.Text = "";
                descriptionLabel.Text = "This episode doesn't seem to have an index file associated with it. :(";
                ss1.Source = null;
                ss2.Source = null;
                ss3.Source = null;
                ss4.Source = null;
                bgss.Source = null;
            }
        }
        static Random ran = new Random();
        static void rng()
        {
            int n = ran.Next(3);
            randomNumber = n;
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            populateListView();
            localEpisodesList.SelectedIndex = 0;
            bgss.Source = null;
        }

        
    }
}
