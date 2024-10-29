namespace BankSystemWinForm_PresentationLayer
{
    partial class frmManageClients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlSlideBar1 = new BankSystemWinForm_PresentationLayer.ctrlSlideBar();
            this.tpUpdateClient = new System.Windows.Forms.TabPage();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2btnUpdateClient = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2UpNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2txtUpPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2txtUpEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2UpLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2txtUpFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2UpPinCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2FindAccNumberToUpdate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tpAddNewClient = new System.Windows.Forms.TabPage();
            this.guna2btnAddNewClient = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PinCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2txtAccNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.tpShowClientList = new System.Windows.Forms.TabPage();
            this.lblClientsCount = new System.Windows.Forms.Label();
            this.guna2SerachAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbctrlManageClient = new System.Windows.Forms.TabControl();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpUpdateClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2UpNumericUpDown)).BeginInit();
            this.tpAddNewClient.SuspendLayout();
            this.tpShowClientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.tbctrlManageClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateClientToolStripMenuItem,
            this.deleteClientToolStripMenuItem,
            this.depositToolStripMenuItem,
            this.withdrawToolStripMenuItem,
            this.transferToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 114);
            // 
            // updateClientToolStripMenuItem
            // 
            this.updateClientToolStripMenuItem.Name = "updateClientToolStripMenuItem";
            this.updateClientToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.updateClientToolStripMenuItem.Text = "UpdateClient";
            this.updateClientToolStripMenuItem.Click += new System.EventHandler(this.updateClientToolStripMenuItem_Click);
            // 
            // deleteClientToolStripMenuItem
            // 
            this.deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            this.deleteClientToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.deleteClientToolStripMenuItem.Text = "DeleteClient";
            this.deleteClientToolStripMenuItem.Click += new System.EventHandler(this.deleteClientToolStripMenuItem_Click);
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlSlideBar1
            // 
            this.ctrlSlideBar1.Location = new System.Drawing.Point(1, 2);
            this.ctrlSlideBar1.Name = "ctrlSlideBar1";
            this.ctrlSlideBar1.Size = new System.Drawing.Size(210, 510);
            this.ctrlSlideBar1.TabIndex = 0;
            // 
            // tpUpdateClient
            // 
            this.tpUpdateClient.Controls.Add(this.guna2CirclePictureBox2);
            this.tpUpdateClient.Controls.Add(this.guna2btnUpdateClient);
            this.tpUpdateClient.Controls.Add(this.guna2UpNumericUpDown);
            this.tpUpdateClient.Controls.Add(this.label10);
            this.tpUpdateClient.Controls.Add(this.guna2txtUpPhone);
            this.tpUpdateClient.Controls.Add(this.guna2txtUpEmail);
            this.tpUpdateClient.Controls.Add(this.guna2UpLastName);
            this.tpUpdateClient.Controls.Add(this.guna2txtUpFirstName);
            this.tpUpdateClient.Controls.Add(this.guna2UpPinCode);
            this.tpUpdateClient.Controls.Add(this.guna2FindAccNumberToUpdate);
            this.tpUpdateClient.Controls.Add(this.label11);
            this.tpUpdateClient.Controls.Add(this.label12);
            this.tpUpdateClient.Controls.Add(this.label13);
            this.tpUpdateClient.Controls.Add(this.label14);
            this.tpUpdateClient.Controls.Add(this.label15);
            this.tpUpdateClient.Controls.Add(this.label16);
            this.tpUpdateClient.Location = new System.Drawing.Point(4, 22);
            this.tpUpdateClient.Name = "tpUpdateClient";
            this.tpUpdateClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateClient.Size = new System.Drawing.Size(933, 484);
            this.tpUpdateClient.TabIndex = 2;
            this.tpUpdateClient.Text = "UpdateClient";
            this.tpUpdateClient.UseVisualStyleBackColor = true;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox2.Image = global::BankSystemWinForm_PresentationLayer.Properties.Resources.search2;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(471, 58);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(27, 38);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 32;
            this.guna2CirclePictureBox2.TabStop = false;
            this.guna2CirclePictureBox2.Click += new System.EventHandler(this.guna2CirclePictureBox2_Click);
            // 
            // guna2btnUpdateClient
            // 
            this.guna2btnUpdateClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnUpdateClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnUpdateClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnUpdateClient.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnUpdateClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2btnUpdateClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2btnUpdateClient.ForeColor = System.Drawing.Color.White;
            this.guna2btnUpdateClient.Location = new System.Drawing.Point(551, 317);
            this.guna2btnUpdateClient.Name = "guna2btnUpdateClient";
            this.guna2btnUpdateClient.Size = new System.Drawing.Size(200, 45);
            this.guna2btnUpdateClient.TabIndex = 31;
            this.guna2btnUpdateClient.Tag = "2";
            this.guna2btnUpdateClient.Text = "Update Client";
            this.guna2btnUpdateClient.Click += new System.EventHandler(this.guna2btnUpdateClient_Click);
            // 
            // guna2UpNumericUpDown
            // 
            this.guna2UpNumericUpDown.BackColor = System.Drawing.Color.Transparent;
            this.guna2UpNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2UpNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2UpNumericUpDown.Location = new System.Drawing.Point(273, 313);
            this.guna2UpNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.guna2UpNumericUpDown.Name = "guna2UpNumericUpDown";
            this.guna2UpNumericUpDown.Size = new System.Drawing.Size(185, 33);
            this.guna2UpNumericUpDown.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(44, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 22);
            this.label10.TabIndex = 29;
            this.label10.Text = "Account Balance:";
            // 
            // guna2txtUpPhone
            // 
            this.guna2txtUpPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtUpPhone.DefaultText = "";
            this.guna2txtUpPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtUpPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtUpPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtUpPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtUpPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtUpPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2txtUpPhone.ForeColor = System.Drawing.Color.Black;
            this.guna2txtUpPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtUpPhone.Location = new System.Drawing.Point(711, 232);
            this.guna2txtUpPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2txtUpPhone.Name = "guna2txtUpPhone";
            this.guna2txtUpPhone.PasswordChar = '\0';
            this.guna2txtUpPhone.PlaceholderText = "";
            this.guna2txtUpPhone.SelectedText = "";
            this.guna2txtUpPhone.Size = new System.Drawing.Size(185, 29);
            this.guna2txtUpPhone.TabIndex = 28;
            // 
            // guna2txtUpEmail
            // 
            this.guna2txtUpEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtUpEmail.DefaultText = "";
            this.guna2txtUpEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtUpEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtUpEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtUpEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtUpEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtUpEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2txtUpEmail.ForeColor = System.Drawing.Color.Black;
            this.guna2txtUpEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtUpEmail.Location = new System.Drawing.Point(273, 229);
            this.guna2txtUpEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2txtUpEmail.Name = "guna2txtUpEmail";
            this.guna2txtUpEmail.PasswordChar = '\0';
            this.guna2txtUpEmail.PlaceholderText = "";
            this.guna2txtUpEmail.SelectedText = "";
            this.guna2txtUpEmail.Size = new System.Drawing.Size(185, 29);
            this.guna2txtUpEmail.TabIndex = 27;
            // 
            // guna2UpLastName
            // 
            this.guna2UpLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2UpLastName.DefaultText = "";
            this.guna2UpLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2UpLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2UpLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2UpLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2UpLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2UpLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2UpLastName.ForeColor = System.Drawing.Color.Black;
            this.guna2UpLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2UpLastName.Location = new System.Drawing.Point(711, 146);
            this.guna2UpLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2UpLastName.Name = "guna2UpLastName";
            this.guna2UpLastName.PasswordChar = '\0';
            this.guna2UpLastName.PlaceholderText = "";
            this.guna2UpLastName.SelectedText = "";
            this.guna2UpLastName.Size = new System.Drawing.Size(185, 29);
            this.guna2UpLastName.TabIndex = 26;
            // 
            // guna2txtUpFirstName
            // 
            this.guna2txtUpFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtUpFirstName.DefaultText = "";
            this.guna2txtUpFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtUpFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtUpFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtUpFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtUpFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtUpFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2txtUpFirstName.ForeColor = System.Drawing.Color.Black;
            this.guna2txtUpFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtUpFirstName.Location = new System.Drawing.Point(273, 143);
            this.guna2txtUpFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2txtUpFirstName.Name = "guna2txtUpFirstName";
            this.guna2txtUpFirstName.PasswordChar = '\0';
            this.guna2txtUpFirstName.PlaceholderText = "";
            this.guna2txtUpFirstName.SelectedText = "";
            this.guna2txtUpFirstName.Size = new System.Drawing.Size(185, 29);
            this.guna2txtUpFirstName.TabIndex = 25;
            // 
            // guna2UpPinCode
            // 
            this.guna2UpPinCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2UpPinCode.DefaultText = "";
            this.guna2UpPinCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2UpPinCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2UpPinCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2UpPinCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2UpPinCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2UpPinCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2UpPinCode.ForeColor = System.Drawing.Color.Black;
            this.guna2UpPinCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2UpPinCode.Location = new System.Drawing.Point(711, 60);
            this.guna2UpPinCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2UpPinCode.Name = "guna2UpPinCode";
            this.guna2UpPinCode.PasswordChar = '\0';
            this.guna2UpPinCode.PlaceholderText = "";
            this.guna2UpPinCode.SelectedText = "";
            this.guna2UpPinCode.Size = new System.Drawing.Size(185, 29);
            this.guna2UpPinCode.TabIndex = 24;
            // 
            // guna2FindAccNumberToUpdate
            // 
            this.guna2FindAccNumberToUpdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2FindAccNumberToUpdate.DefaultText = "";
            this.guna2FindAccNumberToUpdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2FindAccNumberToUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2FindAccNumberToUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2FindAccNumberToUpdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2FindAccNumberToUpdate.FillColor = System.Drawing.Color.LightGray;
            this.guna2FindAccNumberToUpdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2FindAccNumberToUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2FindAccNumberToUpdate.ForeColor = System.Drawing.Color.Black;
            this.guna2FindAccNumberToUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2FindAccNumberToUpdate.Location = new System.Drawing.Point(273, 62);
            this.guna2FindAccNumberToUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2FindAccNumberToUpdate.Name = "guna2FindAccNumberToUpdate";
            this.guna2FindAccNumberToUpdate.PasswordChar = '\0';
            this.guna2FindAccNumberToUpdate.PlaceholderText = "";
            this.guna2FindAccNumberToUpdate.SelectedText = "";
            this.guna2FindAccNumberToUpdate.Size = new System.Drawing.Size(185, 29);
            this.guna2FindAccNumberToUpdate.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(547, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "Phone:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(44, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 22);
            this.label12.TabIndex = 21;
            this.label12.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(547, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 22);
            this.label13.TabIndex = 20;
            this.label13.Text = "LastName:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(44, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 22);
            this.label14.TabIndex = 19;
            this.label14.Text = "FirstName:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(547, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 22);
            this.label15.TabIndex = 18;
            this.label15.Text = "PinCode:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(44, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(211, 22);
            this.label16.TabIndex = 17;
            this.label16.Text = "Search Account Number:\r\n";
            // 
            // tpAddNewClient
            // 
            this.tpAddNewClient.Controls.Add(this.guna2btnAddNewClient);
            this.tpAddNewClient.Controls.Add(this.guna2NumericUpDown1);
            this.tpAddNewClient.Controls.Add(this.label9);
            this.tpAddNewClient.Controls.Add(this.guna2txtPhone);
            this.tpAddNewClient.Controls.Add(this.guna2txtEmail);
            this.tpAddNewClient.Controls.Add(this.guna2txtLastName);
            this.tpAddNewClient.Controls.Add(this.guna2txtFirstName);
            this.tpAddNewClient.Controls.Add(this.guna2PinCode);
            this.tpAddNewClient.Controls.Add(this.guna2txtAccNumber);
            this.tpAddNewClient.Controls.Add(this.label8);
            this.tpAddNewClient.Controls.Add(this.label7);
            this.tpAddNewClient.Controls.Add(this.label6);
            this.tpAddNewClient.Controls.Add(this.label5);
            this.tpAddNewClient.Controls.Add(this.label4);
            this.tpAddNewClient.Controls.Add(this.label3);
            this.tpAddNewClient.Controls.Add(this.label2);
            this.tpAddNewClient.Controls.Add(this.guna2CircleProgressBar1);
            this.tpAddNewClient.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAddNewClient.Location = new System.Drawing.Point(4, 22);
            this.tpAddNewClient.Name = "tpAddNewClient";
            this.tpAddNewClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddNewClient.Size = new System.Drawing.Size(933, 484);
            this.tpAddNewClient.TabIndex = 1;
            this.tpAddNewClient.Text = "AddNewClient";
            this.tpAddNewClient.UseVisualStyleBackColor = true;
            // 
            // guna2btnAddNewClient
            // 
            this.guna2btnAddNewClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnAddNewClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnAddNewClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnAddNewClient.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnAddNewClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2btnAddNewClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2btnAddNewClient.ForeColor = System.Drawing.Color.White;
            this.guna2btnAddNewClient.Location = new System.Drawing.Point(533, 341);
            this.guna2btnAddNewClient.Name = "guna2btnAddNewClient";
            this.guna2btnAddNewClient.Size = new System.Drawing.Size(200, 45);
            this.guna2btnAddNewClient.TabIndex = 17;
            this.guna2btnAddNewClient.Tag = "2";
            this.guna2btnAddNewClient.Text = "Add New Client";
            this.guna2btnAddNewClient.Click += new System.EventHandler(this.guna2btnAddNewClient_Click);
            // 
            // guna2txtPhone
            // 
            this.guna2txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtPhone.DefaultText = "";
            this.guna2txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtPhone.Location = new System.Drawing.Point(243, 341);
            this.guna2txtPhone.Name = "guna2txtPhone";
            this.guna2txtPhone.PasswordChar = '\0';
            this.guna2txtPhone.PlaceholderText = "";
            this.guna2txtPhone.SelectedText = "";
            this.guna2txtPhone.Size = new System.Drawing.Size(185, 29);
            this.guna2txtPhone.TabIndex = 14;
            this.guna2txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.guna2txtPhone_Validating);
            // 
            // guna2txtEmail
            // 
            this.guna2txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtEmail.DefaultText = "";
            this.guna2txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtEmail.Location = new System.Drawing.Point(243, 283);
            this.guna2txtEmail.Name = "guna2txtEmail";
            this.guna2txtEmail.PasswordChar = '\0';
            this.guna2txtEmail.PlaceholderText = "";
            this.guna2txtEmail.SelectedText = "";
            this.guna2txtEmail.Size = new System.Drawing.Size(185, 29);
            this.guna2txtEmail.TabIndex = 12;
            this.guna2txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.guna2txtEmail_Validating);
            // 
            // guna2txtLastName
            // 
            this.guna2txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtLastName.DefaultText = "";
            this.guna2txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtLastName.Location = new System.Drawing.Point(243, 217);
            this.guna2txtLastName.Name = "guna2txtLastName";
            this.guna2txtLastName.PasswordChar = '\0';
            this.guna2txtLastName.PlaceholderText = "";
            this.guna2txtLastName.SelectedText = "";
            this.guna2txtLastName.Size = new System.Drawing.Size(185, 29);
            this.guna2txtLastName.TabIndex = 11;
            this.guna2txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.guna2txtLastName_Validating);
            // 
            // guna2txtFirstName
            // 
            this.guna2txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtFirstName.DefaultText = "";
            this.guna2txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtFirstName.Location = new System.Drawing.Point(243, 151);
            this.guna2txtFirstName.Name = "guna2txtFirstName";
            this.guna2txtFirstName.PasswordChar = '\0';
            this.guna2txtFirstName.PlaceholderText = "";
            this.guna2txtFirstName.SelectedText = "";
            this.guna2txtFirstName.Size = new System.Drawing.Size(185, 29);
            this.guna2txtFirstName.TabIndex = 10;
            this.guna2txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.guna2txtFirstName_Validating);
            // 
            // guna2PinCode
            // 
            this.guna2PinCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2PinCode.DefaultText = "";
            this.guna2PinCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2PinCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2PinCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2PinCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2PinCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2PinCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2PinCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2PinCode.Location = new System.Drawing.Point(243, 92);
            this.guna2PinCode.Name = "guna2PinCode";
            this.guna2PinCode.PasswordChar = '\0';
            this.guna2PinCode.PlaceholderText = "";
            this.guna2PinCode.SelectedText = "";
            this.guna2PinCode.Size = new System.Drawing.Size(185, 29);
            this.guna2PinCode.TabIndex = 9;
            this.guna2PinCode.Validating += new System.ComponentModel.CancelEventHandler(this.guna2PinCode_Validating);
            // 
            // guna2txtAccNumber
            // 
            this.guna2txtAccNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtAccNumber.DefaultText = "";
            this.guna2txtAccNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtAccNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtAccNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtAccNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtAccNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtAccNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2txtAccNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtAccNumber.Location = new System.Drawing.Point(243, 27);
            this.guna2txtAccNumber.Name = "guna2txtAccNumber";
            this.guna2txtAccNumber.PasswordChar = '\0';
            this.guna2txtAccNumber.PlaceholderText = "";
            this.guna2txtAccNumber.SelectedText = "";
            this.guna2txtAccNumber.Size = new System.Drawing.Size(185, 29);
            this.guna2txtAccNumber.TabIndex = 8;
            this.guna2txtAccNumber.Validating += new System.ComponentModel.CancelEventHandler(this.guna2txtAccNumber_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(79, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(79, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(79, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "LastName:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(79, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "FirstName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(79, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "PinCode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(79, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(582, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profile";
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.Animated = true;
            this.guna2CircleProgressBar1.AnimationSpeed = 0.22F;
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(554, 47);
            this.guna2CircleProgressBar1.Minimum = 0;
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.Blue;
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.ShowText = true;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(151, 151);
            this.guna2CircleProgressBar1.TabIndex = 0;
            this.guna2CircleProgressBar1.Text = "fgf";
            // 
            // tpShowClientList
            // 
            this.tpShowClientList.Controls.Add(this.lblClientsCount);
            this.tpShowClientList.Controls.Add(this.guna2SerachAccountNumber);
            this.tpShowClientList.Controls.Add(this.label1);
            this.tpShowClientList.Controls.Add(this.guna2DataGridView1);
            this.tpShowClientList.Location = new System.Drawing.Point(4, 22);
            this.tpShowClientList.Name = "tpShowClientList";
            this.tpShowClientList.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowClientList.Size = new System.Drawing.Size(933, 484);
            this.tpShowClientList.TabIndex = 0;
            this.tpShowClientList.Text = "ShowClientList";
            this.tpShowClientList.UseVisualStyleBackColor = true;
            // 
            // lblClientsCount
            // 
            this.lblClientsCount.AutoSize = true;
            this.lblClientsCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientsCount.ForeColor = System.Drawing.Color.Blue;
            this.lblClientsCount.Location = new System.Drawing.Point(41, 122);
            this.lblClientsCount.Name = "lblClientsCount";
            this.lblClientsCount.Size = new System.Drawing.Size(159, 22);
            this.lblClientsCount.TabIndex = 4;
            this.lblClientsCount.Text = "Number of Clients";
            // 
            // guna2SerachAccountNumber
            // 
            this.guna2SerachAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2SerachAccountNumber.DefaultText = "";
            this.guna2SerachAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2SerachAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2SerachAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2SerachAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2SerachAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2SerachAccountNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2SerachAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2SerachAccountNumber.IconRight = global::BankSystemWinForm_PresentationLayer.Properties.Resources.search2;
            this.guna2SerachAccountNumber.Location = new System.Drawing.Point(45, 80);
            this.guna2SerachAccountNumber.Name = "guna2SerachAccountNumber";
            this.guna2SerachAccountNumber.PasswordChar = '\0';
            this.guna2SerachAccountNumber.PlaceholderText = "";
            this.guna2SerachAccountNumber.SelectedText = "";
            this.guna2SerachAccountNumber.Size = new System.Drawing.Size(178, 27);
            this.guna2SerachAccountNumber.TabIndex = 2;
            this.guna2SerachAccountNumber.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Account Number";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 25;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(25, 161);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(884, 304);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tbctrlManageClient
            // 
            this.tbctrlManageClient.Controls.Add(this.tpShowClientList);
            this.tbctrlManageClient.Controls.Add(this.tpAddNewClient);
            this.tbctrlManageClient.Controls.Add(this.tpUpdateClient);
            this.tbctrlManageClient.Location = new System.Drawing.Point(188, 2);
            this.tbctrlManageClient.Name = "tbctrlManageClient";
            this.tbctrlManageClient.SelectedIndex = 0;
            this.tbctrlManageClient.Size = new System.Drawing.Size(941, 510);
            this.tbctrlManageClient.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(79, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Account Balance:";
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(243, 405);
            this.guna2NumericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(185, 33);
            this.guna2NumericUpDown1.TabIndex = 16;
            // 
            // frmManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 515);
            this.Controls.Add(this.tbctrlManageClient);
            this.Controls.Add(this.ctrlSlideBar1);
            this.Name = "frmManageClients";
            this.Text = "frmManageClients";
            this.Load += new System.EventHandler(this.frmManageClients_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpUpdateClient.ResumeLayout(false);
            this.tpUpdateClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2UpNumericUpDown)).EndInit();
            this.tpAddNewClient.ResumeLayout(false);
            this.tpAddNewClient.PerformLayout();
            this.tpShowClientList.ResumeLayout(false);
            this.tpShowClientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.tbctrlManageClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSlideBar ctrlSlideBar1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem;
        private System.Windows.Forms.TabControl tbctrlManageClient;
        private System.Windows.Forms.TabPage tpShowClientList;
        private System.Windows.Forms.Label lblClientsCount;
        private Guna.UI2.WinForms.Guna2TextBox guna2SerachAccountNumber;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.TabPage tpAddNewClient;
        private Guna.UI2.WinForms.Guna2GradientButton guna2btnAddNewClient;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtFirstName;
        private Guna.UI2.WinForms.Guna2TextBox guna2PinCode;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtAccNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private System.Windows.Forms.TabPage tpUpdateClient;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2btnUpdateClient;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2UpNumericUpDown;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtUpPhone;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtUpEmail;
        private Guna.UI2.WinForms.Guna2TextBox guna2UpLastName;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtUpFirstName;
        private Guna.UI2.WinForms.Guna2TextBox guna2UpPinCode;
        private Guna.UI2.WinForms.Guna2TextBox guna2FindAccNumberToUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private System.Windows.Forms.Label label9;
    }
}