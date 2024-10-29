namespace BankSystemWinForm_PresentationLayer
{
    partial class frmLoginScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.ctrlSlideBar1 = new BankSystemWinForm_PresentationLayer.ctrlSlideBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(272, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To Our Bank";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guna2txtPassword);
            this.groupBox1.Controls.Add(this.guna2txtUserName);
            this.groupBox1.Controls.Add(this.guna2btnLogin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(278, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 338);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login To Your Account";
            // 
            // guna2txtPassword
            // 
            this.guna2txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtPassword.DefaultText = "";
            this.guna2txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2txtPassword.ForeColor = System.Drawing.Color.Black;
            this.guna2txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtPassword.Location = new System.Drawing.Point(15, 197);
            this.guna2txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2txtPassword.Name = "guna2txtPassword";
            this.guna2txtPassword.PasswordChar = '*';
            this.guna2txtPassword.PlaceholderText = "";
            this.guna2txtPassword.SelectedText = "";
            this.guna2txtPassword.Size = new System.Drawing.Size(186, 29);
            this.guna2txtPassword.TabIndex = 7;
            // 
            // guna2txtUserName
            // 
            this.guna2txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtUserName.DefaultText = "";
            this.guna2txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2txtUserName.ForeColor = System.Drawing.Color.Black;
            this.guna2txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtUserName.Location = new System.Drawing.Point(15, 103);
            this.guna2txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2txtUserName.Name = "guna2txtUserName";
            this.guna2txtUserName.PasswordChar = '\0';
            this.guna2txtUserName.PlaceholderText = "";
            this.guna2txtUserName.SelectedText = "";
            this.guna2txtUserName.Size = new System.Drawing.Size(186, 29);
            this.guna2txtUserName.TabIndex = 6;
            // 
            // guna2btnLogin
            // 
            this.guna2btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2btnLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2btnLogin.ForeColor = System.Drawing.Color.White;
            this.guna2btnLogin.Location = new System.Drawing.Point(92, 257);
            this.guna2btnLogin.Name = "guna2btnLogin";
            this.guna2btnLogin.Size = new System.Drawing.Size(127, 45);
            this.guna2btnLogin.TabIndex = 5;
            this.guna2btnLogin.Text = "Login";
            this.guna2btnLogin.Click += new System.EventHandler(this.guna2btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(11, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "UserName:";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Black;
            this.lblErrorMessage.Location = new System.Drawing.Point(285, 457);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 19);
            this.lblErrorMessage.TabIndex = 4;
            // 
            // ctrlSlideBar1
            // 
            this.ctrlSlideBar1.Location = new System.Drawing.Point(2, 3);
            this.ctrlSlideBar1.Name = "ctrlSlideBar1";
            this.ctrlSlideBar1.Size = new System.Drawing.Size(210, 566);
            this.ctrlSlideBar1.TabIndex = 0;
            // 
            // frmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 509);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlSlideBar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmLoginScreen";
            this.Text = "Login Screen";
            this.Load += new System.EventHandler(this.frmLoginScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlSlideBar ctrlSlideBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtPassword;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}