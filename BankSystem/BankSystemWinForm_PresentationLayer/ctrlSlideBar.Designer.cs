namespace BankSystemWinForm_PresentationLayer
{
    partial class ctrlSlideBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panSlideBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panSlideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panSlideBar
            // 
            this.panSlideBar.BackColor = System.Drawing.Color.SteelBlue;
            this.panSlideBar.Controls.Add(this.label1);
            this.panSlideBar.Controls.Add(this.pictureBox2);
            this.panSlideBar.Controls.Add(this.lblUserLogin);
            this.panSlideBar.Controls.Add(this.pictureBox1);
            this.panSlideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSlideBar.Location = new System.Drawing.Point(0, 0);
            this.panSlideBar.Name = "panSlideBar";
            this.panSlideBar.Size = new System.Drawing.Size(185, 510);
            this.panSlideBar.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BankSystemWinForm_PresentationLayer.Properties.Resources.working;
            this.pictureBox2.Location = new System.Drawing.Point(10, 240);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogin.ForeColor = System.Drawing.Color.White;
            this.lblUserLogin.Location = new System.Drawing.Point(87, 197);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(54, 24);
            this.lblUserLogin.TabIndex = 2;
            this.lblUserLogin.Text = "????";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankSystemWinForm_PresentationLayer.Properties.Resources.bank;
            this.pictureBox1.Location = new System.Drawing.Point(3, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "User:";
            // 
            // ctrlSlideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panSlideBar);
            this.Name = "ctrlSlideBar";
            this.Size = new System.Drawing.Size(210, 510);
            this.Load += new System.EventHandler(this.ctrlSlideBar_Load);
            this.panSlideBar.ResumeLayout(false);
            this.panSlideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSlideBar;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}
