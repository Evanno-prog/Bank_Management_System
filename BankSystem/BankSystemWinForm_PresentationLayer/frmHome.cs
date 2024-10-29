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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

            ctrlSlideBar1.CurrentUserLogin();
         
            guna2btnManageClients.Visible = guna2btnClientsTransactions.Visible = guna2btnManageUsers.Visible = true;
            if (!GlobalClass.CurrentUser.CheckAccessPermission(clsUsers.enPermissions.eAll))
            {

                if (!GlobalClass.CurrentUser.CheckAccessPermission(clsUsers.enPermissions.pManageClient))
                { guna2btnManageClients.Visible = false; }


                if (!GlobalClass.CurrentUser.CheckAccessPermission(clsUsers.enPermissions.pTransactionClient))
                { guna2btnClientsTransactions.Visible = false; }


                if (!GlobalClass.CurrentUser.CheckAccessPermission(clsUsers.enPermissions.pManageUsers))
                { guna2btnManageUsers.Visible = false; }


            }

        }

        private void guna2btnManageClients_Click(object sender, EventArgs e)
        {
            frmManageClients MC = new frmManageClients();
            MC.ShowDialog();
        }

        private void guna2btnClientsTransactions_Click(object sender, EventArgs e)
        {
            frmTransactionsClient TC = new frmTransactionsClient("");
            TC.ShowDialog();
        }

        private void guna2btnManageUsers_Click(object sender, EventArgs e)
        {
            frmManageUsers MU = new frmManageUsers();
            MU.ShowDialog();
        }
    }
}
