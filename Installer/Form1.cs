using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _2_DependencyCheck depend = new _2_DependencyCheck();
            depend.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fileVersionInfo.ProductVersion;
            label2.Text = string.Format("Design by Pixy // v{0}", version);
            //
            Computer MyComputer = new Computer();
            string ver = MyComputer.Info.OSVersion;
            string[] split = ver.Split(new char[] { '.' });
            string final = split[0].ToString() + "." + split[1].ToString();
            decimal finall = decimal.Parse(final);
            Console.WriteLine(string.Format("OS Version is {0}", finall.ToString()));
            if(finall > new decimal(5.2) != true)
            {
                MessageBox.Show("This software is not compatible with you current OS version.\nPlease upgrade to Windows Vista or above.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }
    }
}
