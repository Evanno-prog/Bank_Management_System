using BankSystem_BussinnesLayer;
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
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private clsUsers _User;

        private DataView dv = clsUsers.GetAllUsers().DefaultView;

        private short _SetPermissions()
        {

            short Permissions = 0;
            if (rbYes.Checked)
            {
                Permissions += (short)clsUsers.enPermissions.eAll;
            }
            else 
            {

                if (chkManageClients.Checked)
                    Permissions += (short)clsUsers.enPermissions.pManageClient;

                if (chkClientTransactions.Checked)
                    Permissions += (short)clsUsers.enPermissions.pTransactionClient;

                if (chkManageUsers.Checked)
                    Permissions += (short)clsUsers.enPermissions.pManageUsers;

            }
            return Permissions;
        }
        private short _SetUpdatePermissions()
        {

            short Permissions = 0;
            if (rbtnYes.Checked)
            {
                Permissions += (short)clsUsers.enPermissions.eAll;
            }
            else 
            {

                if (cheManageClient.Checked)
                    Permissions += (short)clsUsers.enPermissions.pManageClient;

                if (cheClientTransactions.Checked)
                    Permissions += (short)clsUsers.enPermissions.pTransactionClient;

                if (cheManageUsers.Checked)
                    Permissions += (short)clsUsers.enPermissions.pManageUsers;

            }
            return Permissions;
        }

        private void _RefereshUserList()
        {

            dv = clsUsers.GetAllUsers().DefaultView;
            guna2dgvListUsers.DataSource = dv;
            lblNumberOfUsers.Text = $"{dv.Count} User(s) found";

        }
       
        private void _RefereshLoginRegisterList()
        {
            dv = clsLoginRegister.GetAllLoginRegisters().DefaultView;
            guna2dgvLoginRegister.DataSource = dv;
            lblNumberOfLoginRegister.Text = $"{dv.Count} User(s) found";
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            ctrlSlideBar1.CurrentUserLogin();
            _RefereshUserList();
            _RefereshLoginRegisterList();
        }

        private void guna2SearchUserName_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(guna2SearchUserName.Text))
            {
                _RefereshUserList();
            }
            else
            {
                dv.RowFilter = $"UserName = '{guna2SearchUserName.Text}'";
                guna2dgvListUsers.DataSource = dv;
                lblNumberOfUsers.Text = $"{dv.Count} User(s) found";

            }
        }

        private void guna2btnAddNewUser_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to add new User ?", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                clsUsers User = new clsUsers();
                User.UserName = guna2txtUserName.Text;
                User.Password = guna2txtPassword.Text;
                User.FirstName = guna2txtFirstName.Text;
                User.LastName = guna2txtLastName.Text;
                User.Email = guna2txtEmail.Text;
                User.Phone = guna2txtPhone.Text;
                User.Permissions = _SetPermissions();
               
                if (User.Save())
                {
                    MessageBox.Show("User saved succfully :-)", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefereshUserList();
                    guna2txtUserName.Text = guna2txtPhone.Text = guna2txtPassword.Text = guna2txtFirstName.Text = guna2txtLastName.Text = guna2txtEmail.Text = string.Empty;
                    guna2CircleProgressBar1.Value = 0;
                    rbNo.Checked = rbYes.Checked = chkClientTransactions.Checked = chkManageClients.Checked = chkManageUsers.Checked = false;

                }
                else
                {
                    MessageBox.Show("User Added failed :-(", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void guna2txtUserName_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrEmpty(guna2txtUserName.Text))
            {
                e.Cancel = true;
                guna2txtUserName.Focus();
                errorProvider1.SetError(guna2txtUserName, "UserName Should Have A value");
                return;
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(guna2txtUserName, "");

            }

            if (clsUsers.IsUserExist(guna2txtUserName.Text))
            {
                e.Cancel = true;
                guna2txtUserName.Focus();
                errorProvider1.SetError(guna2txtUserName, "UserName is Exist! , Choose another one");
                return;
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(guna2txtUserName, "");
               
            }
            guna2CircleProgressBar1.Value += 16;
        }

        private void guna2txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2txtPassword.Text))
            {
                e.Cancel = true;
                guna2txtPassword.Focus();
                errorProvider1.SetError(guna2txtPassword, "Password Should Have A value");
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(guna2txtPassword, "");
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

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {

            if (rbYes.Checked)
            {
                chkClientTransactions.Checked = chkManageClients.Checked = chkManageUsers.Checked = true;
                chkManageUsers.Enabled = chkManageClients.Enabled = chkClientTransactions.Enabled = false;
            }
            else
            {
                chkClientTransactions.Checked = chkManageClients.Checked = chkManageUsers.Checked = false;
                chkManageUsers.Enabled = chkManageClients.Enabled = chkClientTransactions.Enabled = true;
            }

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

            if (!clsUsers.IsUserExist(guna2FindUpdateUserName.Text))
            {
                MessageBox.Show("UserName is not Exist! Choose another one", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User = clsUsers.Find(guna2FindUpdateUserName.Text);
            guna2UpPassword.Text = _User.Password;
            guna2txtUpFirstName.Text = _User.FirstName;
            guna2UpLastName.Text = _User.LastName;
            guna2txtUpEmail.Text = _User.Email;
            guna2txtUpPhone.Text = _User.Phone;
            
        }

        private void rbtnYes_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtnYes.Checked)
            {
                cheClientTransactions.Checked = cheManageClient.Checked = cheManageUsers.Checked = true;
                cheManageUsers.Enabled = cheManageClient.Enabled = cheClientTransactions.Enabled = false;
            }
            else
            {
                cheClientTransactions.Checked = cheManageClient.Checked = cheManageUsers.Checked = false;
                cheManageUsers.Enabled = cheManageClient.Enabled = cheClientTransactions.Enabled = true;

            }
        }

        private void guna2btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update this User?", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                
                    
                    _User.Password = guna2UpPassword.Text;
                    _User.FirstName = guna2txtUpFirstName.Text;
                    _User.LastName = guna2UpLastName.Text;
                    _User.Email = guna2txtUpEmail.Text;
                    _User.Phone = guna2txtUpPhone.Text;
                    _User.Permissions = _SetUpdatePermissions();

                    if (_User.Save())
                    {
                        MessageBox.Show("User Updated succfully :-)", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefereshUserList();
                        guna2FindUpdateUserName.Text = guna2txtUpPhone.Text = guna2UpPassword.Text = guna2txtUpFirstName.Text = guna2UpLastName.Text = guna2txtUpEmail.Text = string.Empty;
                       
                        rbtnNo.Checked = rbtnYes.Checked = cheClientTransactions.Checked = cheManageClient.Checked = cheManageUsers.Checked = false;

                    }
                    else
                    {
                        MessageBox.Show("User Updated failed :-(", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                

            }
        }

        private void guna2SerachAccountNumber_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(guna2SerachAccountNumber.Text))
            {
                _RefereshLoginRegisterList();
            }
            else
            {
                dv.RowFilter = $"UserName = '{guna2SerachAccountNumber.Text}'";
                guna2dgvLoginRegister.DataSource = dv;
                lblNumberOfLoginRegister.Text = $"{dv.Count} User(s) found";

            }
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _User = clsUsers.Find((string)guna2dgvListUsers.CurrentRow.Cells[0].Value);
            guna2FindUpdateUserName.Text = _User.UserName;
            guna2UpPassword.Text = _User.Password;
            guna2txtUpFirstName.Text = _User.FirstName;
            guna2txtUpFirstName.Focus();
            guna2UpLastName.Text = _User.LastName;
            guna2txtUpEmail.Text = _User.Email;
            guna2txtUpPhone.Text = _User.Phone;
            tcManageUsers.SelectedIndex = 2;
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure you want to delete this user?","Confirm!",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {

                if (guna2dgvListUsers.CurrentRow.Cells[0].Value.ToString() == "Admin")
                {
                    MessageBox.Show("Sorry! you can not delete this user?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _User = clsUsers.Find(guna2dgvListUsers.CurrentRow.Cells[0].Value.ToString());

                if (clsLoginRegister.DeleteLoginRegisterUser(_User.UserID))
                {
                    clsUsers.DeleteUser(guna2dgvListUsers.CurrentRow.Cells[0].Value.ToString());
                    _RefereshUserList();
                    _RefereshLoginRegisterList();
                    MessageBox.Show("User Deleted succfully :-)", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("User Deleted Failed :-(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

    }
}
