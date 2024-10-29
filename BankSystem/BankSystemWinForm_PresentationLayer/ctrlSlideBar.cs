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
    public partial class ctrlSlideBar : UserControl
    {
        public ctrlSlideBar()
        {
            InitializeComponent();
        }

        public void CurrentUserLogin()
        {
            lblUserLogin.Text = GlobalClass.CurrentUser.UserName;
        }
    
        private void ctrlSlideBar_Load(object sender, EventArgs e)
        {
         
        }

    }
}
