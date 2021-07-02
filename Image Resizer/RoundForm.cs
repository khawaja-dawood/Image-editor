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
    public partial class RoundForm : Form
    {
        Image img2;
        string imgloc;

        public RoundForm(Image img, string loc)
        {
            InitializeComponent();
            img2 = img;
            imgloc = loc;
            pictureBox1.Image = img2;
        }

        private void trackBarBrightness_ValueChanged(object sender, EventArgs e)
        {
            int value = trackBarRound.Value;
            trackBarValue_textBox.Text = value.ToString();

            ImageFactory pic = new ImageFactory();
            pic.Load(img2);

            if (value != 0)
            {
                pic = pic.RoundedCorners(value * 50);
            }

            pictureBox1.Image = pic.Image;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            pgSave save = new pgSave(imgloc,img2);
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
