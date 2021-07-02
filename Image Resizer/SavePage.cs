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
    public partial class pgSave : Form
    {
        string hb;
        string[] exten = { ".PNG", ".JPEG", ".JPG", ".GIF" };
        Image img12;
        public pgSave(string loc,Image img2)
        {
            InitializeComponent();
            img12 = img2;
            hb = loc;
            pictureBox1.Image = img12;
            image_select locationtx = new image_select();
            

             textBox1.Text = loc;
        }
        

        private void pgSave_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < exten.Length; i++)
                comboBox.Items.Add(exten[i]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
       
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int dot = 0, slash = 0;
            for (int j = hb.Length - 1; j >= 0; j--)
                if (hb[j] == '.')
                    dot = j;
                else if (hb[j] == '\\')
                {
                    slash = j;
                    break;
                }

            img12.Save(txtsv.Text + "\\" + hb.Substring(slash + 1, dot - slash - 1) + exten[comboBox.SelectedIndex]);
            ((Button)sender).Enabled = false;
            MessageBox.Show("image saved");
            Application.Exit();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                txtsv.Text = fbd.SelectedPath;

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
