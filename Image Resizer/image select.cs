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

namespace Image_Resizer
{  
    public partial class image_select : Form
    {
   
       public  Image img;
       public string location;
      
        public image_select()
        {
            InitializeComponent();
        }
        
        private void image_select_Load(object sender, EventArgs e)
        {

        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofn = new OpenFileDialog();
            ofn.Filter = " Images|*.png; *.jpg; *.jpeg; *.gif";
            if (ofn.ShowDialog() == DialogResult.OK)
            {

                pictureBox3.ImageLocation = ofn.FileName;
                location = ofn.FileName;
                
             
                img = Image.FromFile(ofn.FileName);
                btnNext.Visible = true;
            }
        }
        
        public void btnNext_Click(object sender, EventArgs e)
        {
            formEditpage formeditpage = new formEditpage(location,img);
            this.Hide();
            formeditpage.Show();
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
