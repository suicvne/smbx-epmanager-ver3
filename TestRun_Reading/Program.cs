using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TestRun_Reading
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            foreach(string s in args)
            {
                if (Directory.Exists(s))
                {
                    Application.Run(new MainForm(s));
                }
                else
                {
                    Application.Run(new MainForm(null));
                }
            }

            //run this last
            
            //
        }
    }
}
