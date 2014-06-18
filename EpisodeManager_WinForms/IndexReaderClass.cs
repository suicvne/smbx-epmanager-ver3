using System;
using System.IO;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IndexReader
{
    public class IndexReaderClass
    {
        public string versionNumber(string fileToRead)
        {
            using (StreamReader sr = new StreamReader(fileToRead))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if(line.Contains("version"))
                    {
                        var split = line.Split(new char[] { '=' }, 2);
                        return split[1].ToString();
                    }
                }
            }
            return null;
        }

        public string filesList(string fileToRead)
        {
            using(StreamReader sr = new StreamReader(fileToRead))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    if(line.Contains("filesList"))
                    {
                        var split = line.Split(new char[] { '=' }, 2);
                        return split[1].ToString();
                    }
                }
            }
            return null;
        }

        public string episodeName(string fileToRead)
        {
            string ep;
            using (StreamReader sr = new StreamReader(fileToRead))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("episodeName"))
                    {
                        var split = line.Split(new char[] { '=' }, 2);
                        ep = split[1].ToString();
                        return ep;
                    }
                }
            }
            return null;
        }
        //
        public string authorName(string fileToRead)
        {
            using (StreamReader sr = new StreamReader(fileToRead))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("author"))
                    {
                        var split = line.Split(new char[] { '=' }, 2);
                        return split[1].ToString();
                    }
                }
            }
            return null;
        }
        //
        public string descriptionText(string fileToRead)
        {
            using (StreamReader sr = new StreamReader(fileToRead))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("description"))
                    {
                        var split = line.Split(new char[] { '=' }, 2);
                        return split[1].ToString();
                    }
                }
            }
            return null;
        }
        //
        public string forumLink(string fileToRead)
        {
            using (StreamReader sr = new StreamReader(fileToRead))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("forumUrl"))
                    {
                        var split = line.Split(new char[] { '=' }, 2);
                        return split[1].ToString();
                    }
                }
            }
            return null;
        }
        //
        public string serverUrl(string fileToRead)
        {
            using (StreamReader sr = new StreamReader(fileToRead))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("server"))
                    {
                        var split = line.Split(new char[] { '=' }, 2);
                        return split[1].ToString();
                    }
                }
            }
            return null;
        }
        //


    }
}
