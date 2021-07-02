namespace Image_Resizer
{
    partial class ResizePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResizePage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtboxheight = new System.Windows.Forms.TextBox();
            this.lblH = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.txtboxWidth = new System.Windows.Forms.TextBox();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
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
            // txtboxheight
            // 
            this.txtboxheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxheight.Location = new System.Drawing.Point(305, 538);
            this.txtboxheight.Name = "txtboxheight";
            this.txtboxheight.Size = new System.Drawing.Size(133, 39);
            this.txtboxheight.TabIndex = 2;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(145, 538);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(98, 32);
            this.lblH.TabIndex = 3;
            this.lblH.Text = "Height";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW.Location = new System.Drawing.Point(145, 597);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(88, 32);
            this.lblW.TabIndex = 5;
            this.lblW.Text = "Width";
            // 
            // txtboxWidth
            // 
            this.txtboxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxWidth.Location = new System.Drawing.Point(305, 597);
            this.txtboxWidth.Name = "txtboxWidth";
            this.txtboxWidth.Size = new System.Drawing.Size(133, 39);
            this.txtboxWidth.TabIndex = 4;
            // 
            // btnResize
            // 
            this.btnResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResize.Location = new System.Drawing.Point(541, 580);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(129, 49);
            this.btnResize.TabIndex = 6;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnback.Location = new System.Drawing.Point(42, 62);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 69);
            this.btnback.TabIndex = 7;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnForward.BackgroundImage")));
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnForward.Location = new System.Drawing.Point(645, 62);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 69);
            this.btnForward.TabIndex = 8;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Visible = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Location = new System.Drawing.Point(645, 159);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 69);
            this.btnClose.TabIndex = 16;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ResizePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.txtboxWidth);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.txtboxheight);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResizePage";
            this.Text = "TP Photo Editor";
            this.Load += new System.EventHandler(this.ResizePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtboxheight;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.TextBox txtboxWidth;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnClose;
    }
}