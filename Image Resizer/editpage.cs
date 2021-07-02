using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ImageProcessor;


namespace Image_Resizer
{
    public partial class formEditpage : Form
    {

        Image img2;
        string loc;
        public formEditpage(string imgloc,Image img)
        {
            InitializeComponent();
            pictureBox1.Image = img;
            loc = imgloc;
            img2 = img;
        
            
        }

        private void finalimage_Load(object sender, EventArgs e)
        {
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            this.Hide();
            btnSave.Visible = true;
            ResizePage resizepage = new ResizePage(loc,img2);
            resizepage.Show();
        
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            
            
            this.Hide();
            btnSave.Visible = true;
            Rotate rotatepagr = new Rotate(loc,img2);
            rotatepagr.Show();
        }

      
        private void btnRounded_Click(object sender, EventArgs e)
        {
            this.Hide();
            btnSave.Visible = true;
            RoundForm rform = new RoundForm(img2, loc);
            rform.Show();
        }

        private void btnBrightness_Click(object sender, EventArgs e)
        {
            this.Hide();
            btnSave.Visible = true;
            BrightnessPage pgbrightness = new BrightnessPage(img2,loc);
            pgbrightness.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("You Sure?", "Close Editor", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)

                Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            pgSave save = new pgSave(loc, img2);
            save.Show();
        }
    
    }
}
