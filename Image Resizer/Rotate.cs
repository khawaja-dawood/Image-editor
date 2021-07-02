using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Resizer
{
    public partial class Rotate : Form
    {
        Image img;
        string loc;
        public Rotate(string loc2 ,Image img2)
        {
            InitializeComponent();
            pictureBox1.Image = img2;
            loc = loc2;
            img = pictureBox1.Image;
        }

        private void btnLeftRotate_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                img.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pictureBox1.Image = img;
                btnSave.Visible = true;
            }
        }

        private void btnRightRotate_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                img.RotateFlip(RotateFlipType.Rotate270FlipXY);
                pictureBox1.Image = img;
                btnSave.Visible = true;
            }
        }

        private void btnflip_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                img.RotateFlip(RotateFlipType.Rotate180FlipY);
                pictureBox1.Image = img;
                btnSave.Visible = true;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (img != null)
            {
                img.RotateFlip(RotateFlipType.Rotate180FlipX);
                pictureBox1.Image = img;
                btnSave.Visible = true;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            formEditpage back = new formEditpage(loc, img);
            this.Hide();
            back.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            pgSave save = new pgSave(loc,img);
            save.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("You Sure?", "Close Editor", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
