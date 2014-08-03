using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;

namespace EpisodeManager_WinForms
{
    class ZipReading
    {
        /*
        /// <summary>
        /// This is where we read the information of the zipfile that's being dropped into the program.
        /// </summary>
        /// <param name="fileName"></param>
        public void readZipFile(string fileName)
        {
            //we'll be using the temp directory that's created in the directory the program is executed in
            string extractionPath = Environment.CurrentDirectory + @"\temp\ZipReading";
            using (ZipArchive archive = ZipFile.OpenRead(fileName))
            {
                foreach(ZipArchiveEntry entry in archive.Entries )
                {
                    if(entry.FullName == "project.index")
                    {
                        entry.ExtractToFile(Path.Combine(extractionPath, entry.FullName));
                    }
                }
            }
            readZipForImages(fileName);

        }

        private void readZipForImages(string fileName)
        {
            //we try to extract the images
            string extractionPath = Environment.CurrentDirectory + @"\temp\ZipReading";
            using(ZipArchive archive = ZipFile.OpenRead(fileName))
            {
                foreach(ZipArchiveEntry entry in archive.Entries)
                {
                    switch (entry.Name)
                    {
                        case "image1.png":
                            entry.ExtractToFile(Path.Combine(extractionPath, entry.FullName));
                            break;
                        case "image2.png":
                            entry.ExtractToFile(Path.Combine(extractionPath, entry.FullName));
                            break;
                        case "image3.png":
                            entry.ExtractToFile(Path.Combine(extractionPath, entry.FullName));
                            break;
                        case "image4.png":
                            entry.ExtractToFile(Path.Combine(extractionPath, entry.FullName));
                            break;
                        case "icon.png":
                            entry.ExtractToFile(Path.Combine(extractionPath, entry.FullName));
                            break;
                    }
                }
            }
        }*/


    }
}
