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
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }
        private int _CountLoginFailed = 3;
        private void frmLoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void guna2btnLogin_Click(object sender, EventArgs e)
        {

            clsUsers Users = clsUsers.Find(guna2txtUserName.Text);
            if (Users != null)
            {

                if (Users.Password != guna2txtPassword.Text)
                {


                    _CountLoginFailed--;
                    lblErrorMessage.Text = "Invalid UserName/Password !\n" +
                                            $"You have {_CountLoginFailed} attempts before lock your account";
              
                    if (_CountLoginFailed == 0)
                    {
                        lblErrorMessage.Text = "You are locked after 3 Failed trails!\n" +
                        $"Contact system administration to unlock your Account";
                        lblErrorMessage.ForeColor = Color.Red;
                        guna2btnLogin.Enabled = false;

                    }

                    return;

                }
            }  
            else
            {
                    _CountLoginFailed--;
                    lblErrorMessage.Text = "Invalid UserName/Password !\n" +
                                            $"You have {_CountLoginFailed} attempts before lock your account";

                    if (_CountLoginFailed == 0)
                    {
                        lblErrorMessage.Text = "You are locked after 3 Failed trails!\n" +
                        $"Contact system administration to unlock your Account";
                        lblErrorMessage.ForeColor = Color.Red;
                        guna2btnLogin.Enabled = false;

                    }

                    return;

            }

            GlobalClass.CurrentUser = Users;
            clsLoginRegister.AddLoginRegister(Users.UserID);
            frmHome Home = new frmHome();
            Home.ShowDialog();
        }
    }
}
