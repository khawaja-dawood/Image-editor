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
    
    public partial class ResizePage : Form
    {
        Image img;
        string loc;
        public ResizePage(string loc2,Image img2)
        {
            InitializeComponent();
            pictureBox1.Image = img2;
            img = pictureBox1.Image;
            loc = loc2;

        }

        private void ResizePage_Load(object sender, EventArgs e)
        {

        }

        public void btnResize_Click(object sender, EventArgs e)
        {
            int w = Convert.ToInt32(txtboxWidth.Text);
            int h = Convert.ToInt32(txtboxheight.Text);
            img = Resize(img, w, h);
            ((Button)sender).Enabled = false;
            MessageBox.Show("image resized");
            btnForward.Visible = true;
        }
        Image Resize(Image image, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(image, 0, 0, w, h);
            graphic.Dispose();
            return bmp;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            formEditpage back = new formEditpage(loc,img);
            this.Hide();
            back.Show();
        }

        private void btnForward_Click(object sender, EventArgs e)
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
