namespace BankSystemWinForm_PresentationLayer
{
    partial class frmHome
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
            this.guna2btnManageClients = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2btnClientsTransactions = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2btnManageUsers = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ctrlSlideBar1 = new BankSystemWinForm_PresentationLayer.ctrlSlideBar();
            this.SuspendLayout();
            // 
            // guna2btnManageClients
            // 
            this.guna2btnManageClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnManageClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnManageClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnManageClients.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnManageClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2btnManageClients.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2btnManageClients.ForeColor = System.Drawing.Color.White;
            this.guna2btnManageClients.Location = new System.Drawing.Point(341, 70);
            this.guna2btnManageClients.Name = "guna2btnManageClients";
            this.guna2btnManageClients.Size = new System.Drawing.Size(245, 60);
            this.guna2btnManageClients.TabIndex = 1;
            this.guna2btnManageClients.Tag = "1";
            this.guna2btnManageClients.Text = "Manage Clients";
            this.guna2btnManageClients.Click += new System.EventHandler(this.guna2btnManageClients_Click);
            // 
            // guna2btnClientsTransactions
            // 
            this.guna2btnClientsTransactions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnClientsTransactions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnClientsTransactions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnClientsTransactions.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnClientsTransactions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2btnClientsTransactions.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2btnClientsTransactions.ForeColor = System.Drawing.Color.White;
            this.guna2btnClientsTransactions.Location = new System.Drawing.Point(341, 201);
            this.guna2btnClientsTransactions.Name = "guna2btnClientsTransactions";
            this.guna2btnClientsTransactions.Size = new System.Drawing.Size(245, 60);
            this.guna2btnClientsTransactions.TabIndex = 2;
            this.guna2btnClientsTransactions.Tag = "2";
            this.guna2btnClientsTransactions.Text = "Clients Transactions";
            this.guna2btnClientsTransactions.Click += new System.EventHandler(this.guna2btnClientsTransactions_Click);
            // 
            // guna2btnManageUsers
            // 
            this.guna2btnManageUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnManageUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnManageUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnManageUsers.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnManageUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2btnManageUsers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.guna2btnManageUsers.Location = new System.Drawing.Point(341, 337);
            this.guna2btnManageUsers.Name = "guna2btnManageUsers";
            this.guna2btnManageUsers.Size = new System.Drawing.Size(245, 60);
            this.guna2btnManageUsers.TabIndex = 4;
            this.guna2btnManageUsers.Tag = "4";
            this.guna2btnManageUsers.Text = "Manage Users";
            this.guna2btnManageUsers.Click += new System.EventHandler(this.guna2btnManageUsers_Click);
            // 
            // ctrlSlideBar1
            // 
            this.ctrlSlideBar1.Location = new System.Drawing.Point(2, 0);
            this.ctrlSlideBar1.Name = "ctrlSlideBar1";
            this.ctrlSlideBar1.Size = new System.Drawing.Size(210, 510);
            this.ctrlSlideBar1.TabIndex = 0;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.guna2btnManageUsers);
            this.Controls.Add(this.guna2btnClientsTransactions);
            this.Controls.Add(this.guna2btnManageClients);
            this.Controls.Add(this.ctrlSlideBar1);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSlideBar ctrlSlideBar1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2btnManageClients;
        private Guna.UI2.WinForms.Guna2GradientButton guna2btnClientsTransactions;
        private Guna.UI2.WinForms.Guna2GradientButton guna2btnManageUsers;
    }
}