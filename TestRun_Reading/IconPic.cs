using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace TestRun_Reading
{
    public partial class IconPic : UserControl
    {
        public IconPic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files (*.jpg, *.png, *.bmp, *.jpeg, *.gif)|*.jpg;*.png;*.bmp;*.jpeg;*.gif)";
            if (of.ShowDialog() == DialogResult.OK)
            {
                using (Image sourceImg = Image.FromFile(of.FileName))
                {
                    Image clonedImg = new Bitmap(sourceImg.Width, sourceImg.Height, PixelFormat.Format32bppArgb);
                    using (var copy = Graphics.FromImage(clonedImg))
                    {
                        copy.DrawImage(sourceImg, 0, 0);
                    }
                    icon1.InitialImage = null;
                    icon1.Image = clonedImg;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            icon1.Image = null;
        }
    }
}
