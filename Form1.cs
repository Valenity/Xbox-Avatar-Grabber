using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avatar_Grabber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "http://avatar.xboxlive.com/avatar/" + textBox1.Text + "/avatar-body.png";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // save the image in picturebox
            pictureBox1.Image.Save(textBox1.Text + ".jpg", ImageFormat.Jpeg);
            MessageBox.Show("Downloaded!");
        }
    }
}
