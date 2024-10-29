namespace BankSystemWinForm_PresentationLayer
{
    partial class frmTransactionsClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabCtrlTransactions = new System.Windows.Forms.TabControl();
            this.tpDeposit = new System.Windows.Forms.TabPage();
            this.lblCurrentBalanceDeposit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2btnUpdateClient = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2DepositNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2FindAccNumberToDeposit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tpWithDraw = new System.Windows.Forms.TabPage();
            this.lblCurrentBalanceWithdraw = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2btnWithDrawBalance = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2WithdrawNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2txtFindAccNumberToWithdraw = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpTotalBalances = new System.Windows.Forms.TabPage();
            this.lblTotalBalances = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tpTransferBalances = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2TransferAmountNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblTransferToBalance = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTransferFromBalance = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2btnTransferBalance = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Transferfrom = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2txtTransferFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Transferto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2txtTransferTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tpTransferLog = new System.Windows.Forms.TabPage();
            this.dgvTransferLog = new System.Windows.Forms.DataGridView();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblClientsCountTransferLog = new System.Windows.Forms.Label();
            this.guna2SerachAccountNumberForTransferLog = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ctrlSlideBar1 = new BankSystemWinForm_PresentationLayer.ctrlSlideBar();
            this.tabCtrlTransactions.SuspendLayout();
            this.tpDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DepositNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.tpWithDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2WithdrawNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.tpTotalBalances.SuspendLayout();
            this.tpTransferBalances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2TransferAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2Transferfrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2Transferto)).BeginInit();
            this.tpTransferLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlTransactions
            // 
            this.tabCtrlTransactions.Controls.Add(this.tpDeposit);
            this.tabCtrlTransactions.Controls.Add(this.tpWithDraw);
            this.tabCtrlTransactions.Controls.Add(this.tpTotalBalances);
            this.tabCtrlTransactions.Controls.Add(this.tpTransferBalances);
            this.tabCtrlTransactions.Controls.Add(this.tpTransferLog);
            this.tabCtrlTransactions.Location = new System.Drawing.Point(190, 2);
            this.tabCtrlTransactions.Name = "tabCtrlTransactions";
            this.tabCtrlTransactions.SelectedIndex = 0;
            this.tabCtrlTransactions.Size = new System.Drawing.Size(544, 517);
            this.tabCtrlTransactions.TabIndex = 1;
            // 
            // tpDeposit
            // 
            this.tpDeposit.Controls.Add(this.lblCurrentBalanceDeposit);
            this.tpDeposit.Controls.Add(this.label2);
            this.tpDeposit.Controls.Add(this.guna2btnUpdateClient);
            this.tpDeposit.Controls.Add(this.guna2DepositNumericUpDown);
            this.tpDeposit.Controls.Add(this.label1);
            this.tpDeposit.Controls.Add(this.guna2CirclePictureBox2);
            this.tpDeposit.Controls.Add(this.guna2FindAccNumberToDeposit);
            this.tpDeposit.Controls.Add(this.label16);
            this.tpDeposit.Location = new System.Drawing.Point(4, 22);
            this.tpDeposit.Name = "tpDeposit";
            this.tpDeposit.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeposit.Size = new System.Drawing.Size(536, 491);
            this.tpDeposit.TabIndex = 0;
            this.tpDeposit.Text = "Deposit";
            this.tpDeposit.UseVisualStyleBackColor = true;
            // 
            // lblCurrentBalanceDeposit
            // 
            this.lblCurrentBalanceDeposit.AutoSize = true;
            this.lblCurrentBalanceDeposit.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalanceDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCurrentBalanceDeposit.Location = new System.Drawing.Point(262, 173);
            this.lblCurrentBalanceDeposit.Name = "lblCurrentBalanceDeposit";
            this.lblCurrentBalanceDeposit.Size = new System.Drawing.Size(51, 31);
            this.lblCurrentBalanceDeposit.TabIndex = 40;
            this.lblCurrentBalanceDeposit.Text = "$ 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(81, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 26);
            this.label2.TabIndex = 39;
            this.label2.Text = "Current Balane is:";
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
            this.guna2btnUpdateClient.Location = new System.Drawing.Point(85, 376);
            this.guna2btnUpdateClient.Name = "guna2btnUpdateClient";
            this.guna2btnUpdateClient.Size = new System.Drawing.Size(144, 43);
            this.guna2btnUpdateClient.TabIndex = 38;
            this.guna2btnUpdateClient.Tag = "2";
            this.guna2btnUpdateClient.Text = "Deposit";
            this.guna2btnUpdateClient.Click += new System.EventHandler(this.guna2btnUpdateClient_Click);
            // 
            // guna2DepositNumericUpDown
            // 
            this.guna2DepositNumericUpDown.BackColor = System.Drawing.Color.Transparent;
            this.guna2DepositNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2DepositNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2DepositNumericUpDown.Location = new System.Drawing.Point(85, 292);
            this.guna2DepositNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.guna2DepositNumericUpDown.Name = "guna2DepositNumericUpDown";
            this.guna2DepositNumericUpDown.Size = new System.Drawing.Size(185, 33);
            this.guna2DepositNumericUpDown.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(82, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Deposit Amount:";
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox2.Image = global::BankSystemWinForm_PresentationLayer.Properties.Resources.search2;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(298, 108);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(27, 38);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 35;
            this.guna2CirclePictureBox2.TabStop = false;
            this.guna2CirclePictureBox2.Click += new System.EventHandler(this.guna2CirclePictureBox2_Click);
            // 
            // guna2FindAccNumberToDeposit
            // 
            this.guna2FindAccNumberToDeposit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2FindAccNumberToDeposit.DefaultText = "";
            this.guna2FindAccNumberToDeposit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2FindAccNumberToDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2FindAccNumberToDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2FindAccNumberToDeposit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2FindAccNumberToDeposit.FillColor = System.Drawing.Color.LightGray;
            this.guna2FindAccNumberToDeposit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2FindAccNumberToDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2FindAccNumberToDeposit.ForeColor = System.Drawing.Color.Black;
            this.guna2FindAccNumberToDeposit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2FindAccNumberToDeposit.Location = new System.Drawing.Point(85, 113);
            this.guna2FindAccNumberToDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2FindAccNumberToDeposit.Name = "guna2FindAccNumberToDeposit";
            this.guna2FindAccNumberToDeposit.PasswordChar = '\0';
            this.guna2FindAccNumberToDeposit.PlaceholderText = "";
            this.guna2FindAccNumberToDeposit.SelectedText = "";
            this.guna2FindAccNumberToDeposit.Size = new System.Drawing.Size(185, 29);
            this.guna2FindAccNumberToDeposit.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(81, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(211, 22);
            this.label16.TabIndex = 33;
            this.label16.Text = "Search Account Number:\r\n";
            // 
            // tpWithDraw
            // 
            this.tpWithDraw.Controls.Add(this.lblCurrentBalanceWithdraw);
            this.tpWithDraw.Controls.Add(this.label4);
            this.tpWithDraw.Controls.Add(this.guna2btnWithDrawBalance);
            this.tpWithDraw.Controls.Add(this.guna2WithdrawNumericUpDown);
            this.tpWithDraw.Controls.Add(this.label5);
            this.tpWithDraw.Controls.Add(this.guna2CirclePictureBox1);
            this.tpWithDraw.Controls.Add(this.guna2txtFindAccNumberToWithdraw);
            this.tpWithDraw.Controls.Add(this.label6);
            this.tpWithDraw.Location = new System.Drawing.Point(4, 22);
            this.tpWithDraw.Name = "tpWithDraw";
            this.tpWithDraw.Padding = new System.Windows.Forms.Padding(3);
            this.tpWithDraw.Size = new System.Drawing.Size(536, 491);
            this.tpWithDraw.TabIndex = 1;
            this.tpWithDraw.Text = "WithDraw";
            this.tpWithDraw.UseVisualStyleBackColor = true;
            // 
            // lblCurrentBalanceWithdraw
            // 
            this.lblCurrentBalanceWithdraw.AutoSize = true;
            this.lblCurrentBalanceWithdraw.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalanceWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCurrentBalanceWithdraw.Location = new System.Drawing.Point(270, 177);
            this.lblCurrentBalanceWithdraw.Name = "lblCurrentBalanceWithdraw";
            this.lblCurrentBalanceWithdraw.Size = new System.Drawing.Size(51, 31);
            this.lblCurrentBalanceWithdraw.TabIndex = 48;
            this.lblCurrentBalanceWithdraw.Text = "$ 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(89, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 26);
            this.label4.TabIndex = 47;
            this.label4.Text = "Current Balane is:";
            // 
            // guna2btnWithDrawBalance
            // 
            this.guna2btnWithDrawBalance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnWithDrawBalance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnWithDrawBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnWithDrawBalance.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnWithDrawBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2btnWithDrawBalance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2btnWithDrawBalance.ForeColor = System.Drawing.Color.White;
            this.guna2btnWithDrawBalance.Location = new System.Drawing.Point(93, 380);
            this.guna2btnWithDrawBalance.Name = "guna2btnWithDrawBalance";
            this.guna2btnWithDrawBalance.Size = new System.Drawing.Size(144, 43);
            this.guna2btnWithDrawBalance.TabIndex = 46;
            this.guna2btnWithDrawBalance.Tag = "2";
            this.guna2btnWithDrawBalance.Text = "Withdraw";
            this.guna2btnWithDrawBalance.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2WithdrawNumericUpDown
            // 
            this.guna2WithdrawNumericUpDown.BackColor = System.Drawing.Color.Transparent;
            this.guna2WithdrawNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2WithdrawNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2WithdrawNumericUpDown.Location = new System.Drawing.Point(93, 296);
            this.guna2WithdrawNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.guna2WithdrawNumericUpDown.Name = "guna2WithdrawNumericUpDown";
            this.guna2WithdrawNumericUpDown.Size = new System.Drawing.Size(185, 33);
            this.guna2WithdrawNumericUpDown.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(90, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "Withdraw Amount:";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox1.Image = global::BankSystemWinForm_PresentationLayer.Properties.Resources.search2;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(306, 112);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(27, 38);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 43;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // guna2txtFindAccNumberToWithdraw
            // 
            this.guna2txtFindAccNumberToWithdraw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtFindAccNumberToWithdraw.DefaultText = "";
            this.guna2txtFindAccNumberToWithdraw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtFindAccNumberToWithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtFindAccNumberToWithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtFindAccNumberToWithdraw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtFindAccNumberToWithdraw.FillColor = System.Drawing.Color.LightGray;
            this.guna2txtFindAccNumberToWithdraw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtFindAccNumberToWithdraw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2txtFindAccNumberToWithdraw.ForeColor = System.Drawing.Color.Black;
            this.guna2txtFindAccNumberToWithdraw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtFindAccNumberToWithdraw.Location = new System.Drawing.Point(93, 117);
            this.guna2txtFindAccNumberToWithdraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2txtFindAccNumberToWithdraw.Name = "guna2txtFindAccNumberToWithdraw";
            this.guna2txtFindAccNumberToWithdraw.PasswordChar = '\0';
            this.guna2txtFindAccNumberToWithdraw.PlaceholderText = "";
            this.guna2txtFindAccNumberToWithdraw.SelectedText = "";
            this.guna2txtFindAccNumberToWithdraw.Size = new System.Drawing.Size(185, 29);
            this.guna2txtFindAccNumberToWithdraw.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(89, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 22);
            this.label6.TabIndex = 41;
            this.label6.Text = "Search Account Number:\r\n";
            // 
            // tpTotalBalances
            // 
            this.tpTotalBalances.BackColor = System.Drawing.Color.White;
            this.tpTotalBalances.Controls.Add(this.lblTotalBalances);
            this.tpTotalBalances.Controls.Add(this.label3);
            this.tpTotalBalances.Location = new System.Drawing.Point(4, 22);
            this.tpTotalBalances.Name = "tpTotalBalances";
            this.tpTotalBalances.Padding = new System.Windows.Forms.Padding(3);
            this.tpTotalBalances.Size = new System.Drawing.Size(536, 491);
            this.tpTotalBalances.TabIndex = 2;
            this.tpTotalBalances.Text = "TotalBalances";
            // 
            // lblTotalBalances
            // 
            this.lblTotalBalances.AutoSize = true;
            this.lblTotalBalances.BackColor = System.Drawing.Color.White;
            this.lblTotalBalances.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalBalances.Location = new System.Drawing.Point(369, 186);
            this.lblTotalBalances.Name = "lblTotalBalances";
            this.lblTotalBalances.Size = new System.Drawing.Size(74, 46);
            this.lblTotalBalances.TabIndex = 1;
            this.lblTotalBalances.Text = "$ 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(41, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Balance is:";
            // 
            // tpTransferBalances
            // 
            this.tpTransferBalances.Controls.Add(this.label9);
            this.tpTransferBalances.Controls.Add(this.guna2TransferAmountNumericUpDown);
            this.tpTransferBalances.Controls.Add(this.lblTransferToBalance);
            this.tpTransferBalances.Controls.Add(this.label12);
            this.tpTransferBalances.Controls.Add(this.lblTransferFromBalance);
            this.tpTransferBalances.Controls.Add(this.label10);
            this.tpTransferBalances.Controls.Add(this.guna2btnTransferBalance);
            this.tpTransferBalances.Controls.Add(this.guna2Transferfrom);
            this.tpTransferBalances.Controls.Add(this.guna2txtTransferFrom);
            this.tpTransferBalances.Controls.Add(this.label8);
            this.tpTransferBalances.Controls.Add(this.guna2Transferto);
            this.tpTransferBalances.Controls.Add(this.guna2txtTransferTo);
            this.tpTransferBalances.Controls.Add(this.label7);
            this.tpTransferBalances.Location = new System.Drawing.Point(4, 22);
            this.tpTransferBalances.Name = "tpTransferBalances";
            this.tpTransferBalances.Padding = new System.Windows.Forms.Padding(3);
            this.tpTransferBalances.Size = new System.Drawing.Size(536, 491);
            this.tpTransferBalances.TabIndex = 3;
            this.tpTransferBalances.Text = "Transfer Balances";
            this.tpTransferBalances.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(89, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 22);
            this.label9.TabIndex = 56;
            this.label9.Text = "Transfer Amount";
            // 
            // guna2TransferAmountNumericUpDown
            // 
            this.guna2TransferAmountNumericUpDown.BackColor = System.Drawing.Color.Transparent;
            this.guna2TransferAmountNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TransferAmountNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TransferAmountNumericUpDown.Location = new System.Drawing.Point(77, 383);
            this.guna2TransferAmountNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.guna2TransferAmountNumericUpDown.Name = "guna2TransferAmountNumericUpDown";
            this.guna2TransferAmountNumericUpDown.Size = new System.Drawing.Size(185, 33);
            this.guna2TransferAmountNumericUpDown.TabIndex = 55;
            // 
            // lblTransferToBalance
            // 
            this.lblTransferToBalance.AutoSize = true;
            this.lblTransferToBalance.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferToBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTransferToBalance.Location = new System.Drawing.Point(430, 276);
            this.lblTransferToBalance.Name = "lblTransferToBalance";
            this.lblTransferToBalance.Size = new System.Drawing.Size(31, 19);
            this.lblTransferToBalance.TabIndex = 54;
            this.lblTransferToBalance.Text = "$ 0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(293, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 19);
            this.label12.TabIndex = 53;
            this.label12.Text = "Current Balane is:";
            // 
            // lblTransferFromBalance
            // 
            this.lblTransferFromBalance.AutoSize = true;
            this.lblTransferFromBalance.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferFromBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTransferFromBalance.Location = new System.Drawing.Point(428, 134);
            this.lblTransferFromBalance.Name = "lblTransferFromBalance";
            this.lblTransferFromBalance.Size = new System.Drawing.Size(31, 19);
            this.lblTransferFromBalance.TabIndex = 52;
            this.lblTransferFromBalance.Text = "$ 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(291, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 19);
            this.label10.TabIndex = 51;
            this.label10.Text = "Current Balane is:";
            // 
            // guna2btnTransferBalance
            // 
            this.guna2btnTransferBalance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnTransferBalance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnTransferBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnTransferBalance.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnTransferBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2btnTransferBalance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2btnTransferBalance.ForeColor = System.Drawing.Color.White;
            this.guna2btnTransferBalance.Location = new System.Drawing.Point(298, 376);
            this.guna2btnTransferBalance.Name = "guna2btnTransferBalance";
            this.guna2btnTransferBalance.Size = new System.Drawing.Size(204, 43);
            this.guna2btnTransferBalance.TabIndex = 50;
            this.guna2btnTransferBalance.Tag = "2";
            this.guna2btnTransferBalance.Text = "Transfer Balance";
            this.guna2btnTransferBalance.Click += new System.EventHandler(this.guna2btnTransferBalance_Click);
            // 
            // guna2Transferfrom
            // 
            this.guna2Transferfrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transferfrom.Image = global::BankSystemWinForm_PresentationLayer.Properties.Resources.search2;
            this.guna2Transferfrom.ImageRotate = 0F;
            this.guna2Transferfrom.Location = new System.Drawing.Point(248, 123);
            this.guna2Transferfrom.Name = "guna2Transferfrom";
            this.guna2Transferfrom.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2Transferfrom.Size = new System.Drawing.Size(27, 38);
            this.guna2Transferfrom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2Transferfrom.TabIndex = 49;
            this.guna2Transferfrom.TabStop = false;
            this.guna2Transferfrom.Click += new System.EventHandler(this.guna2Transferfrom_Click);
            // 
            // guna2txtTransferFrom
            // 
            this.guna2txtTransferFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtTransferFrom.DefaultText = "";
            this.guna2txtTransferFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtTransferFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtTransferFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtTransferFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtTransferFrom.FillColor = System.Drawing.Color.LightGray;
            this.guna2txtTransferFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtTransferFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2txtTransferFrom.ForeColor = System.Drawing.Color.Black;
            this.guna2txtTransferFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtTransferFrom.Location = new System.Drawing.Point(43, 126);
            this.guna2txtTransferFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2txtTransferFrom.Name = "guna2txtTransferFrom";
            this.guna2txtTransferFrom.PasswordChar = '\0';
            this.guna2txtTransferFrom.PlaceholderText = "";
            this.guna2txtTransferFrom.SelectedText = "";
            this.guna2txtTransferFrom.Size = new System.Drawing.Size(185, 29);
            this.guna2txtTransferFrom.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(36, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(350, 44);
            this.label8.TabIndex = 47;
            this.label8.Text = "Search Account Number to Transfer from:\r\n\r\n";
            // 
            // guna2Transferto
            // 
            this.guna2Transferto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transferto.Image = global::BankSystemWinForm_PresentationLayer.Properties.Resources.search2;
            this.guna2Transferto.ImageRotate = 0F;
            this.guna2Transferto.Location = new System.Drawing.Point(250, 266);
            this.guna2Transferto.Name = "guna2Transferto";
            this.guna2Transferto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2Transferto.Size = new System.Drawing.Size(27, 38);
            this.guna2Transferto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2Transferto.TabIndex = 46;
            this.guna2Transferto.TabStop = false;
            this.guna2Transferto.Click += new System.EventHandler(this.guna2Transferto_Click);
            // 
            // guna2txtTransferTo
            // 
            this.guna2txtTransferTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtTransferTo.DefaultText = "";
            this.guna2txtTransferTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtTransferTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtTransferTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtTransferTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtTransferTo.FillColor = System.Drawing.Color.LightGray;
            this.guna2txtTransferTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtTransferTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2txtTransferTo.ForeColor = System.Drawing.Color.Black;
            this.guna2txtTransferTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtTransferTo.Location = new System.Drawing.Point(45, 269);
            this.guna2txtTransferTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2txtTransferTo.Name = "guna2txtTransferTo";
            this.guna2txtTransferTo.PasswordChar = '\0';
            this.guna2txtTransferTo.PlaceholderText = "";
            this.guna2txtTransferTo.SelectedText = "";
            this.guna2txtTransferTo.Size = new System.Drawing.Size(185, 29);
            this.guna2txtTransferTo.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(36, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 44);
            this.label7.TabIndex = 44;
            this.label7.Text = "Search Account Number to Transfer to:\r\n\r\n";
            // 
            // tpTransferLog
            // 
            this.tpTransferLog.Controls.Add(this.dgvTransferLog);
            this.tpTransferLog.Controls.Add(this.guna2CirclePictureBox3);
            this.tpTransferLog.Controls.Add(this.lblClientsCountTransferLog);
            this.tpTransferLog.Controls.Add(this.guna2SerachAccountNumberForTransferLog);
            this.tpTransferLog.Controls.Add(this.label11);
            this.tpTransferLog.Location = new System.Drawing.Point(4, 22);
            this.tpTransferLog.Name = "tpTransferLog";
            this.tpTransferLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpTransferLog.Size = new System.Drawing.Size(536, 491);
            this.tpTransferLog.TabIndex = 4;
            this.tpTransferLog.Text = "TransferLog";
            this.tpTransferLog.UseVisualStyleBackColor = true;
            // 
            // dgvTransferLog
            // 
            this.dgvTransferLog.AllowUserToAddRows = false;
            this.dgvTransferLog.AllowUserToDeleteRows = false;
            this.dgvTransferLog.AllowUserToOrderColumns = true;
            this.dgvTransferLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransferLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransferLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransferLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferLog.Location = new System.Drawing.Point(24, 175);
            this.dgvTransferLog.Name = "dgvTransferLog";
            this.dgvTransferLog.ReadOnly = true;
            this.dgvTransferLog.Size = new System.Drawing.Size(493, 306);
            this.dgvTransferLog.TabIndex = 10;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox3.Image = global::BankSystemWinForm_PresentationLayer.Properties.Resources.search2;
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(218, 61);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(37, 64);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox3.TabIndex = 9;
            this.guna2CirclePictureBox3.TabStop = false;
            this.guna2CirclePictureBox3.Click += new System.EventHandler(this.guna2CirclePictureBox3_Click);
            // 
            // lblClientsCountTransferLog
            // 
            this.lblClientsCountTransferLog.AutoSize = true;
            this.lblClientsCountTransferLog.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientsCountTransferLog.ForeColor = System.Drawing.Color.Blue;
            this.lblClientsCountTransferLog.Location = new System.Drawing.Point(40, 125);
            this.lblClientsCountTransferLog.Name = "lblClientsCountTransferLog";
            this.lblClientsCountTransferLog.Size = new System.Drawing.Size(159, 22);
            this.lblClientsCountTransferLog.TabIndex = 8;
            this.lblClientsCountTransferLog.Text = "Number of Clients";
            // 
            // guna2SerachAccountNumberForTransferLog
            // 
            this.guna2SerachAccountNumberForTransferLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2SerachAccountNumberForTransferLog.DefaultText = "";
            this.guna2SerachAccountNumberForTransferLog.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2SerachAccountNumberForTransferLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2SerachAccountNumberForTransferLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2SerachAccountNumberForTransferLog.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2SerachAccountNumberForTransferLog.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2SerachAccountNumberForTransferLog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2SerachAccountNumberForTransferLog.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2SerachAccountNumberForTransferLog.Location = new System.Drawing.Point(44, 78);
            this.guna2SerachAccountNumberForTransferLog.Name = "guna2SerachAccountNumberForTransferLog";
            this.guna2SerachAccountNumberForTransferLog.PasswordChar = '\0';
            this.guna2SerachAccountNumberForTransferLog.PlaceholderText = "";
            this.guna2SerachAccountNumberForTransferLog.SelectedText = "";
            this.guna2SerachAccountNumberForTransferLog.Size = new System.Drawing.Size(155, 27);
            this.guna2SerachAccountNumberForTransferLog.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(40, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 22);
            this.label11.TabIndex = 6;
            this.label11.Text = "Search Account Number";
            // 
            // ctrlSlideBar1
            // 
            this.ctrlSlideBar1.Location = new System.Drawing.Point(2, 2);
            this.ctrlSlideBar1.Name = "ctrlSlideBar1";
            this.ctrlSlideBar1.Size = new System.Drawing.Size(210, 510);
            this.ctrlSlideBar1.TabIndex = 0;
            // 
            // frmTransactionsClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 517);
            this.Controls.Add(this.tabCtrlTransactions);
            this.Controls.Add(this.ctrlSlideBar1);
            this.Name = "frmTransactionsClient";
            this.Text = "Transactions Client";
            this.Load += new System.EventHandler(this.frmTransactionsClient_Load);
            this.tabCtrlTransactions.ResumeLayout(false);
            this.tpDeposit.ResumeLayout(false);
            this.tpDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DepositNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.tpWithDraw.ResumeLayout(false);
            this.tpWithDraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2WithdrawNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.tpTotalBalances.ResumeLayout(false);
            this.tpTotalBalances.PerformLayout();
            this.tpTransferBalances.ResumeLayout(false);
            this.tpTransferBalances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2TransferAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2Transferfrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2Transferto)).EndInit();
            this.tpTransferLog.ResumeLayout(false);
            this.tpTransferLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSlideBar ctrlSlideBar1;
        private System.Windows.Forms.TabControl tabCtrlTransactions;
        private System.Windows.Forms.TabPage tpDeposit;
        private System.Windows.Forms.TabPage tpWithDraw;
        private System.Windows.Forms.TabPage tpTotalBalances;
        private System.Windows.Forms.TabPage tpTransferBalances;
        private System.Windows.Forms.TabPage tpTransferLog;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2FindAccNumberToDeposit;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2DepositNumericUpDown;
        private Guna.UI2.WinForms.Guna2GradientButton guna2btnUpdateClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentBalanceDeposit;
        private System.Windows.Forms.Label lblCurrentBalanceWithdraw;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2btnWithDrawBalance;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2WithdrawNumericUpDown;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtFindAccNumberToWithdraw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalBalances;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2Transferfrom;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtTransferFrom;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2Transferto;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtTransferTo;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GradientButton guna2btnTransferBalance;
        private System.Windows.Forms.Label lblTransferToBalance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTransferFromBalance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2TransferAmountNumericUpDown;
        private System.Windows.Forms.Label lblClientsCountTransferLog;
        private Guna.UI2.WinForms.Guna2TextBox guna2SerachAccountNumberForTransferLog;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private System.Windows.Forms.DataGridView dgvTransferLog;
    }
}