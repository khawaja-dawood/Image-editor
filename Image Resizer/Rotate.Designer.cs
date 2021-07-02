namespace Image_Resizer
{
    partial class Rotate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rotate));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLeftRotate = new System.Windows.Forms.Button();
            this.btnRightRotate = new System.Windows.Forms.Button();
            this.btnflip2 = new System.Windows.Forms.Button();
            this.btnflip = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(156, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnLeftRotate
            // 
            this.btnLeftRotate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLeftRotate.BackgroundImage")));
            this.btnLeftRotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeftRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftRotate.Location = new System.Drawing.Point(168, 528);
            this.btnLeftRotate.Name = "btnLeftRotate";
            this.btnLeftRotate.Size = new System.Drawing.Size(75, 75);
            this.btnLeftRotate.TabIndex = 2;
            this.btnLeftRotate.UseVisualStyleBackColor = true;
            this.btnLeftRotate.Click += new System.EventHandler(this.btnLeftRotate_Click);
            // 
            // btnRightRotate
            // 
            this.btnRightRotate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRightRotate.BackgroundImage")));
            this.btnRightRotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRightRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightRotate.Location = new System.Drawing.Point(283, 528);
            this.btnRightRotate.Name = "btnRightRotate";
            this.btnRightRotate.Size = new System.Drawing.Size(75, 75);
            this.btnRightRotate.TabIndex = 3;
            this.btnRightRotate.UseVisualStyleBackColor = true;
            this.btnRightRotate.Click += new System.EventHandler(this.btnRightRotate_Click);
            // 
            // btnflip2
            // 
            this.btnflip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnflip2.BackgroundImage")));
            this.btnflip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnflip2.Location = new System.Drawing.Point(513, 528);
            this.btnflip2.Name = "btnflip2";
            this.btnflip2.Size = new System.Drawing.Size(75, 75);
            this.btnflip2.TabIndex = 11;
            this.btnflip2.UseVisualStyleBackColor = true;
            this.btnflip2.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnflip
            // 
            this.btnflip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnflip.BackgroundImage")));
            this.btnflip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnflip.Location = new System.Drawing.Point(398, 528);
            this.btnflip.Name = "btnflip";
            this.btnflip.Size = new System.Drawing.Size(75, 75);
            this.btnflip.TabIndex = 10;
            this.btnflip.UseVisualStyleBackColor = true;
            this.btnflip.Click += new System.EventHandler(this.btnflip_Click);
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnback.Location = new System.Drawing.Point(30, 62);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 69);
            this.btnback.TabIndex = 12;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Location = new System.Drawing.Point(666, 62);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 69);
            this.btnClose.TabIndex = 16;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(316, 635);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 58);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // Rotate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnflip2);
            this.Controls.Add(this.btnflip);
            this.Controls.Add(this.btnRightRotate);
            this.Controls.Add(this.btnLeftRotate);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rotate";
            this.Text = "TP Photo Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLeftRotate;
        private System.Windows.Forms.Button btnRightRotate;
        private System.Windows.Forms.Button btnflip2;
        private System.Windows.Forms.Button btnflip;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}