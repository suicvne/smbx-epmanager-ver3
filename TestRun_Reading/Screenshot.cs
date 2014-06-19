using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace IndexGenerator
{
    public partial class Screenshot : UserControl
    {
        ViewScreenshot vs = new ViewScreenshot();
        public Screenshot()
        {
            InitializeComponent();
        }

        private void screenshot1_Click(object sender, EventArgs e)
        {
            if (screenshot1.Image != null)
            {
                //ViewScreenshot vs = new ViewScreenshot();
                vs.pictureBox1.Image = screenshot1.Image;
                vs.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files (*.jpg, *.png, *.bmp, *.jpeg)|*.jpg;*.png;*.bmp;*.jpeg)";
            if(of.ShowDialog() == DialogResult.OK)
            {
                string imageLoc = of.FileName;
                using (Image sourceImg = Image.FromFile(of.FileName))
                {
                    Image clonedImg = new Bitmap(sourceImg.Width, sourceImg.Height, PixelFormat.Format32bppArgb);
                    using (var copy = Graphics.FromImage(clonedImg))
                    {
                        copy.DrawImage(sourceImg, 0, 0);
                    }
                    screenshot1.InitialImage = null;
                    screenshot1.Image = clonedImg;
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            screenshot1.Image = null;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
