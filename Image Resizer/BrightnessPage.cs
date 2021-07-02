using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ImageProcessor;

namespace Image_Resizer
{
    public partial class BrightnessPage : Form
    {
        string imgloc;
        Image img2;
        public BrightnessPage(Image img, string loc2)
        {
            InitializeComponent();
            pictureBox1.Image = img;
            img2 = img;
            imgloc = loc2;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBarBrightness_ValueChanged(object sender, EventArgs e)
        {
            int value = trackBarBrightness.Value;
            trackBarValue_textBox.Text = value.ToString();

            ImageFactory pic = new ImageFactory();
            pic.Load(img2);

            if (value != 0)
            {
                pic = pic.Brightness(value * 10);
            }

            pictureBox1.Image = pic.Image;
           
         
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            pgSave save = new pgSave(imgloc, img2);
            save.Show();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            img2 = pictureBox1.Image;
            formEditpage frm = new formEditpage(imgloc, img2);
            this.Hide();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("You Sure?", "Close Editor", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            
                Application.Exit();
        }
    }
}
