using BankSystem_BussinnesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace BankSystemWinForm_PresentationLayer
{
    public partial class frmManageClients : Form
    {
        public frmManageClients()
        {
            InitializeComponent();
        }
        private DataView dv = new DataView();

        private clsClients _Client;

        private void _RefereshClientList()
        {
            dv = clsClients.GetAllClients().DefaultView;
            guna2DataGridView1.DataSource = dv;
            lblClientsCount.Text = $"{dv.Count} Client(s) found";

        }

        private void frmManageClients_Load(object sender, EventArgs e)
        {
            ctrlSlideBar1.CurrentUserLogin();
            _RefereshClientList();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(guna2SerachAccountNumber.Text))
            {
                _RefereshClientList();
            }
            else
            {
                dv.RowFilter = $"AccountNumber = '{guna2SerachAccountNumber.Text}'";
                guna2DataGridView1.DataSource = dv;
                lblClientsCount.Text = $"{dv.Count} Client(s) found";

            }


        }


        private void guna2txtAccNumber_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(guna2txtAccNumber.Text))
            {
                e.Cancel = true;
                guna2txtAccNumber.Focus();
                errorProvider1.SetError(guna2txtAccNumber, "Account Number Should Have A value");

            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(guna2txtAccNumber, "");
              
            }

            if (clsClients.IsClientExist(guna2txtAccNumber.Text))
            {
                e.Cancel = true;
                guna2txtAccNumber.Focus();
                errorProvider1.SetError(guna2txtAccNumber, "Account Number is Exist! , Choose another one");
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(guna2txtAccNumber, "");
                guna2CircleProgressBar1.Value += 16;
            }

        }

        private void guna2PinCode_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(guna2PinCode.Text))
            {
                e.Cancel = true;
                guna2PinCode.Focus();
                errorProvider1.SetError(guna2PinCode, "PinCode Should Have A value");
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(guna2PinCode, "");
                guna2CircleProgressBar1.Value += 16;
            }


        }

        private void guna2txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2txtFirstName.Text))
            {
                e.Cancel = true;
                guna2txtFirstName.Focus();
                errorProvider1.SetError(guna2txtFirstName, "FirstName Should Have A value");
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(guna2txtFirstName, "");
                guna2CircleProgressBar1.Value += 16;
            }

        }

        private void guna2txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2txtLastName.Text))
            {
                e.Cancel = true;
                guna2txtLastName.Focus();
                errorProvider1.SetError(guna2txtLastName, "LastName Should Have A value");
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(guna2txtLastName, "");
                guna2CircleProgressBar1.Value += 16;
            }

        }

        private void guna2txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2txtEmail.Text))
            {
                e.Cancel = true;
                guna2txtEmail.Focus();
                errorProvider1.SetError(guna2txtEmail, "Email Should Have A value");
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(guna2txtEmail, "");
                guna2CircleProgressBar1.Value += 16;
            }

        }

        private void guna2txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2txtPhone.Text))
            {
                e.Cancel = true;
                guna2txtPhone.Focus();
                errorProvider1.SetError(guna2txtPhone, "Phone Should Have A value");
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(guna2txtPhone, "");
                guna2CircleProgressBar1.Value += 20;
            }

        }

        private void guna2btnAddNewClient_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure you want to add new client ?", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                clsClients clients = new clsClients();
                clients.AccountNumber = guna2txtAccNumber.Text;
                clients.PinCode = guna2PinCode.Text;
                clients.FirstName = guna2txtFirstName.Text;
                clients.LastName = guna2txtLastName.Text;
                clients.Email = guna2txtEmail.Text;
                clients.Phone = guna2txtPhone.Text;
                clients.Balance = (int)guna2NumericUpDown1.Value;
                if (clients.Save())
                {
                    MessageBox.Show("Client saved succfully :-)", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefereshClientList();
                    guna2txtAccNumber.Text = guna2txtPhone.Text = guna2PinCode.Text = guna2txtFirstName.Text = guna2txtLastName.Text = guna2txtEmail.Text = string.Empty;
                    guna2CircleProgressBar1.Value = 0;
                    guna2NumericUpDown1.Value = 0;
                }
                else
                {
                    MessageBox.Show("Client saved failed :-(", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

            if (!clsClients.IsClientExist(guna2FindAccNumberToUpdate.Text))
            {
                MessageBox.Show("Account number is not Exist! choose another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Client = clsClients.Find(guna2FindAccNumberToUpdate.Text);

                guna2UpPinCode.Text = _Client.PinCode;
                guna2txtUpFirstName.Text = _Client.FirstName;
                guna2UpLastName.Text = _Client.LastName;
                guna2txtUpEmail.Text = _Client.Email;
                guna2txtUpPhone.Text = _Client.Phone;
                guna2UpNumericUpDown.Value = _Client.Balance;
            
        }

        private void guna2btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update this Client ?", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                _Client.PinCode = guna2UpPinCode.Text;
                _Client.FirstName = guna2txtUpFirstName.Text;
                _Client.LastName = guna2UpLastName.Text;
                _Client.Email = guna2txtUpEmail.Text;
                _Client.Phone = guna2txtUpPhone.Text;
                _Client.Balance = (int)guna2UpNumericUpDown.Value;

                if (_Client.Save())
                {
                    MessageBox.Show("Client Updated succfully :-)", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefereshClientList();
                    guna2FindAccNumberToUpdate.Text = guna2UpPinCode.Text = guna2PinCode.Text = guna2txtUpFirstName.Text = guna2UpLastName.Text = guna2txtUpEmail.Text = string.Empty;

                    guna2UpNumericUpDown.Value = 0;

                }
                else
                {
                    MessageBox.Show("Client Updated failed :-(", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void ContextMenueUpdateClientByAccNumber(string AccNumber)
        {
            _Client = clsClients.Find(AccNumber);
            if (_Client != null)
            {
                guna2FindAccNumberToUpdate.Text = AccNumber;
                guna2UpPinCode.Text = _Client.PinCode;
                guna2txtUpFirstName.Text = _Client.FirstName;
                guna2UpLastName.Text = _Client.LastName;
                guna2txtUpEmail.Text = _Client.Email;
                guna2txtUpPhone.Text = _Client.Phone;
                guna2UpNumericUpDown.Value = _Client.Balance;
            }
        }
        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbctrlManageClient.SelectTab(2);
            ContextMenueUpdateClientByAccNumber(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete this client ?","Confirm Option",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {

                _Client = clsClients.Find(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());

                if (clsTransferLog.DeleteTransferLog(_Client.ClientID))
                {
                    clsClients.DeleteClient(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Client Deleted succfully :-)", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefereshClientList();
                    
                }
                else
                    MessageBox.Show("Client Deleted Failed :-(", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!GlobalClass.CurrentUser.CheckAccessPermission(clsUsers.enPermissions.eAll))
            {

                if (!GlobalClass.CurrentUser.CheckAccessPermission(clsUsers.enPermissions.pTransactionClient))
                { MessageBox.Show("Sorry! you do not have permission to do this!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            }

            frmTransactionsClient TransactionsClient = new frmTransactionsClient(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());
            TransactionsClient.SetTabControl("Deposit");
            TransactionsClient.FindClientToDeposite();
            TransactionsClient.ShowDialog();
            _RefereshClientList();

//          Rest of code will be here :-)
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!GlobalClass.CurrentUser.CheckAccessPermission(clsUsers.enPermissions.eAll))
            {

                if (!GlobalClass.CurrentUser.CheckAccessPermission(clsUsers.enPermissions.pTransactionClient))
                { MessageBox.Show("Sorry! you do not have permission to do this!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            }

            frmTransactionsClient TransactionsClient = new frmTransactionsClient(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());
            TransactionsClient.SetTabControl("Withdraw");
            TransactionsClient.FindClientToWithdraw();
            TransactionsClient.ShowDialog();
            _RefereshClientList();

          
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!GlobalClass.CurrentUser.CheckAccessPermission(clsUsers.enPermissions.eAll))
            {

                if (!GlobalClass.CurrentUser.CheckAccessPermission(clsUsers.enPermissions.pTransactionClient))
                { MessageBox.Show("Sorry! you do not have permission to do this!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            }

            frmTransactionsClient TransactionsClient = new frmTransactionsClient(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());
            TransactionsClient.SetTabControl("TransferBalance");
            TransactionsClient.FindClientToTransfer();
            TransactionsClient.ShowDialog();
            _RefereshClientList();

        }
    }
}

