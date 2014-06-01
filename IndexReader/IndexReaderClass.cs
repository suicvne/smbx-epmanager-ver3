using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IndexReader
{
    public class IndexReaderClass
    {
        /// <summary>
        /// The main void to read the index files with the following information in it
        /// episodeName - the name of the episode, as a string
        /// author - the name of who made it, as a string
        /// description - a description, as a string
        /// version - as a 4-digit number
        /// images - unknown, probably going to be packaged
        /// filesList - each file name as a string
        /// </summary>
        /// <param name="fileToRead">As a string, the index to read from.</param>

        public void readMainIndex(string fileToRead)
        {
            Console.WriteLine("Reading index from '" + fileToRead.ToString() + "'");
            using (StreamReader sr = new StreamReader(fileToRead.ToString()))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("episodeName"))
                    {
                        var split = line.Split(new char[] { '=' }, 2);
                        //To access, we use split[0] for the param and split[1] for the data
                        Console.WriteLine("The episode's name is: " + split[1].ToString());
                    }

                    if (line.Contains("author"))
                    {

                    }

                    if (line.Contains("description"))
                    {

                    }

                    if (line.Contains("version"))
                    {

                    }
                    if (line.Contains("images"))
                    {

                    }
                    if (line.Contains("filesList"))
                    {

                    }

                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileToRead"></param>
        public void returnEpisodeName(string fileToRead)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileToRead"></param>
        public void returnFileList(string fileToRead)
        {
            using (StreamReader sr = new StreamReader(fileToRead))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("filesList"))
                    {
                        var split = line.Split(new char[] { '=' }, 2);

                    }
                }
            }
        }
    }
}
