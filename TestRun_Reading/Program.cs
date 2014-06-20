using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace IndexGenerator
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

            if(args.Length == 0)
            {
                Application.Run(new MainForm("null"));
            }

            for (int i = 0; i < args.Length; i++)
            {
                //MessageBox.Show(args[0].ToString());
                if (Directory.Exists(args[0].ToString()))
                {
                    Application.Run(new MainForm(args[0].ToString()));
                }
            }
        }
    }
}
