namespace Image_Resizer
{
    partial class starting_page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(starting_page));
            this.lbltp = new System.Windows.Forms.Label();
            this.pictureboxtp = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxtp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltp
            // 
            this.lbltp.AutoSize = true;
            this.lbltp.Font = new System.Drawing.Font("Stencil", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltp.Location = new System.Drawing.Point(152, 531);
            this.lbltp.Name = "lbltp";
            this.lbltp.Size = new System.Drawing.Size(468, 61);
            this.lbltp.TabIndex = 0;
            this.lbltp.Text = "Talay Solutions";
            // 
            // pictureboxtp
            // 
            this.pictureboxtp.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxtp.Image")));
            this.pictureboxtp.Location = new System.Drawing.Point(48, 189);
            this.pictureboxtp.Name = "pictureboxtp";
            this.pictureboxtp.Size = new System.Drawing.Size(320, 308);
            this.pictureboxtp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxtp.TabIndex = 1;
            this.pictureboxtp.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(412, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // starting_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureboxtp);
            this.Controls.Add(this.lbltp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "starting_page";
            this.Text = "TP Photo Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxtp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltp;
        private System.Windows.Forms.PictureBox pictureboxtp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}