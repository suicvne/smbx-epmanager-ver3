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
using OutlinedTextBlock;
using System.Diagnostics;
using Setting;
using Microsoft.Win32;

namespace EpisodeManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        IndexReaderClass inReader = new IndexReaderClass();
        IniFile settingsIni = new IniFile(Environment.CurrentDirectory + @"\settings.ini");
        public static int randomNumber;
        public static string forumLink;
        public static string serverUrl;
        public static string smbxWorldsDir;

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

        private void obtainWorldsLoc()
        {
            smbxWorldsDir = settingsIni.ReadValue("Settings", "worldlocation");
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
                forumLink = inReader.forumLink(indexToLoad);
                serverUrl = inReader.serverUrl(indexToLoad);

                rng();
                /*
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
                }*/
                
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
                //bgss.Source = null;
            }
        }
        /// <summary>
        /// Random number generating.
        /// </summary>
        static Random ran = new Random();
        static void rng()
        {
            int n = ran.Next(3);
            randomNumber = n;
        }

        #region Misc Stuff.
        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + @"\settings.ini") != true)
            {
                StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + @"\settings.ini");
                sw.WriteLine("[Settings]");
                sw.WriteLine(@"worldlocation=C:\SMBX\worlds");
            }

            populateListView();
            localEpisodesList.SelectedIndex = 0;
            obtainWorldsLoc();
            //bgss.Source = null;
        }

        private void ss1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (ss1.Source != null)
            {
                ViewScreenshot vs = new ViewScreenshot();
                vs.ss_view.Source = ss1.Source;
                vs.ShowDialog();
            }
        }

        private void ss2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (ss1.Source != null)
            {
                ViewScreenshot vs = new ViewScreenshot();
                vs.ss_view.Source = ss2.Source;
                vs.ShowDialog();
            }
        }

        private void ss3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (ss1.Source != null)
            {
                ViewScreenshot vs = new ViewScreenshot();
                vs.ss_view.Source = ss3.Source;
                vs.ShowDialog();
            }
        }

        private void ss4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (ss1.Source != null)
            {
                ViewScreenshot vs = new ViewScreenshot();
                vs.ss_view.Source = ss4.Source;
                vs.ShowDialog();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(forumLink != null)
            {
                Process.Start(forumLink);
            }
        }
        #endregion

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
        
    }
}
