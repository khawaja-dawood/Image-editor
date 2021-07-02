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
    public partial class starting_page : Form
    {
        public int a = 0;
        public starting_page()
        {
           
            InitializeComponent();
         
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            if (a>1)
            {
                lbltp.Hide();
                pictureboxtp.Hide();
                timer1.Stop();
                    this.Hide();
                DialogResult dialog =  MessageBox.Show("Allow SYSTEM to access Pictures", "Grant Permission", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    image_select img = new image_select();
                    img.Show();
                }
                else
                {
                    DialogResult dialog1 = MessageBox.Show("Allow SYSTEM to access Pictures", "Grant Permission", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog1 == DialogResult.Yes)
                    {
                        image_select img = new image_select();
                        img.Show();
                    }
                    else
                    {
                        DialogResult dialog3 = MessageBox.Show("Allow SYSTEM to access Pictures", "Grant Permission", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialog3 == DialogResult.Yes)
                        {
                            image_select img = new image_select();
                            img.Show();
                        }
                        else
                        {
                            DialogResult dialog2 = MessageBox.Show("Allow SYSTEM to access Pictures", "Grant Permission", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dialog2 == DialogResult.Yes)
                            {
                                image_select img = new image_select();
                                img.Show();
                            }
                        }
                    }
                }
            }
            a++;
        }
        
    }
}
