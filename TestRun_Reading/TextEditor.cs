using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestRun_Reading
{
    public partial class TextEditor : Form
    {
        MainForm form = new MainForm();

        public TextEditor()
        {
            InitializeComponent();
        }

        private void TextEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            form.descText.Text = textBox1.Text;
        }
    }
}
