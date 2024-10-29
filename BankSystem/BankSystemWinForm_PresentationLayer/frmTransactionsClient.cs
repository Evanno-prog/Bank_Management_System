using BankSystem_BussinnesLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemWinForm_PresentationLayer
{
    public partial class frmTransactionsClient : Form
    {
        public frmTransactionsClient(string accNum)
        {
            InitializeComponent();
            _AccNum = accNum;
        }

        private string _AccNum = string.Empty;

        private clsClients _Client;
       
        private clsClients _TransferFromClient;
      
        private clsClients _TransferToClient;

        DataView Dv = clsTransferLog.GetAllTransferLogs().DefaultView;

        public void SetTabControl(string TabName)
        {

            if (TabName == "Deposit")
                tabCtrlTransactions.SelectedIndex = 0;
            else if (TabName == "Withdraw")
                tabCtrlTransactions.SelectedIndex = 1;
            else if (TabName == "TransferBalance")
                tabCtrlTransactions.SelectedIndex = 3;

        }

        public void FindClientToDeposite()
        {
            _Client = clsClients.Find(_AccNum);
            guna2FindAccNumberToDeposit.Text = _AccNum;
            lblCurrentBalanceDeposit.Text = "$ " + _Client.Balance.ToString();
        }

        public void FindClientToWithdraw()
        {
            _Client = clsClients.Find(_AccNum);
            guna2txtFindAccNumberToWithdraw.Text = _AccNum;
            lblCurrentBalanceWithdraw.Text = "$ " + _Client.Balance.ToString();
        }  
 
        public void FindClientToTransfer()
        {
            _TransferFromClient = clsClients.Find(_AccNum);
            guna2txtTransferFrom.Text = _AccNum;
            lblTransferFromBalance.Text = "$ " + _TransferFromClient.Balance.ToString();
        }

        private void _RefereshTransferLogList()
        {
            DataView dv = clsTransferLog.GetAllTransferLogs().DefaultView;
            dgvTransferLog.DataSource = dv;
            lblClientsCountTransferLog.Text = $"{dv.Count} Client(s) found";
        }

        private int _GetAllTotalBalances()
        {
            int Balance = 0;
            DataView dt = clsClients.GetAllClients().DefaultView;
            for (int i = 0; i < dt.Count; i++)
            {
                Balance += Convert.ToInt16(dt[i][6]);
            }
            return Balance;
        }

        private void _FillTotalBalancesLabel()
        {
            lblTotalBalances.Text = "$ " + _GetAllTotalBalances().ToString();
        }

        private void frmTransactionsClient_Load(object sender, EventArgs e)
        {
            ctrlSlideBar1.CurrentUserLogin();
            _RefereshTransferLogList();
            _FillTotalBalancesLabel();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {


            if (!clsClients.IsClientExist(guna2FindAccNumberToDeposit.Text))
            {
                MessageBox.Show("Account number is not Exist! choose another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Client = clsClients.Find(guna2FindAccNumberToDeposit.Text);
            lblCurrentBalanceDeposit.Text = "$ " + _Client.Balance.ToString();

        }

        private void guna2btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Deposit balance to this Client ?","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (_Client.Deposit((int)guna2DepositNumericUpDown.Value))
                {
                    MessageBox.Show($"Amount has been Deposited ({(int)guna2DepositNumericUpDown.Value}) Succfully","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    lblCurrentBalanceDeposit.Text = "$ " + _Client.Balance.ToString();
                }
                else
                {
                    MessageBox.Show($"Amount not Deposited", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

            if (!clsClients.IsClientExist(guna2txtFindAccNumberToWithdraw.Text))
            {
                MessageBox.Show("Account number is not Exist! choose another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Client = clsClients.Find(guna2txtFindAccNumberToWithdraw.Text);
            if (_Client.Balance == 0)
            {
                MessageBox.Show("Sorry! Account balance is empty", "Empty balance!", MessageBoxButtons.OK);
                _Client = null;
                return;
            }

            lblCurrentBalanceWithdraw.Text = "$ " + _Client.Balance.ToString();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Withdraw balance to this Client ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (_Client.Withdraw((int)guna2WithdrawNumericUpDown.Value))
                {
                    MessageBox.Show($"Amount has been Withdrawed ({(int)guna2WithdrawNumericUpDown.Value}) Succfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblCurrentBalanceWithdraw.Text = "$ " + _Client.Balance.ToString();
                }
                else
                {
                    MessageBox.Show($"Amount not WithDrawed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void guna2Transferfrom_Click(object sender, EventArgs e)
        {
            if (!clsClients.IsClientExist(guna2txtTransferFrom.Text))
            {
                MessageBox.Show("Account number is not Exist! choose another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TransferFromClient = clsClients.Find(guna2txtTransferFrom.Text);
            if (_TransferFromClient.Balance == 0)
            {
                MessageBox.Show("Sorry! Account balance is empty", "Empty balance!", MessageBoxButtons.OK);
                _TransferFromClient = null;
                return;
            }

            lblTransferFromBalance.Text = "$ " + _TransferFromClient.Balance.ToString();
        }

        private void guna2Transferto_Click(object sender, EventArgs e)
        {

            if (!clsClients.IsClientExist(guna2txtTransferTo.Text))
            {
                MessageBox.Show("Account number is not Exist! choose another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TransferToClient = clsClients.Find(guna2txtTransferTo.Text);
           
            lblTransferToBalance.Text = "$ " + _TransferToClient.Balance.ToString();
        }

        private void guna2btnTransferBalance_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure you want to Transfer Balance ?","Confirm!",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {

                if (_TransferFromClient.Transfer((int)guna2TransferAmountNumericUpDown.Value, ref _TransferToClient))
                {
                    MessageBox.Show("Transfer Done succfully :-)", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblTransferFromBalance.Text = "$ " + _TransferFromClient.Balance.ToString();
                    lblTransferToBalance.Text = "$" + _TransferToClient.Balance.ToString();
                    clsTransferLog.AddTransferLog(_TransferFromClient.ClientID, _TransferToClient.ClientID, (int)guna2TransferAmountNumericUpDown.Value, GlobalClass.CurrentUser.UserID);
                    _RefereshTransferLogList();
                }
                else
                    MessageBox.Show("Failed to transfer Balance :-(", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(guna2SerachAccountNumberForTransferLog.Text))
            {
                _RefereshTransferLogList();
            }
            else
            {
                Dv.RowFilter = $"S_AccountNumber = '{guna2SerachAccountNumberForTransferLog.Text}'";
                dgvTransferLog.DataSource = Dv;
                lblClientsCountTransferLog.Text = $"{Dv.Count} Client(s) found";

            }
        }
    }
}