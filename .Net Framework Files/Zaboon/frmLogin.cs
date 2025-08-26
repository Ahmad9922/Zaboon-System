using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZaboonBL;

namespace Zaboon
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void ucLoggedIn1_LoginButtonClick(object sender, CustomControls.UCLoggedIn.LoginInfoEventArgs e)
        {
            this.Hide();

            frmMainMenu MainMenuForm = new frmMainMenu();
            MainMenuForm.ShowDialog();
            
            this.Close();
        }

        private bool ucLoggedIn1_LoginValidation(object sender, CustomControls.UCLoggedIn.LoginInfoEventArgs e)
        {
            clsGlobal.RegisteredUser = clsUser.Find(e.UserName, e.Password);

            if (clsGlobal.RegisteredUser != null)
            {
                if (clsGlobal.RegisteredUser.UserType.UserTypeID == clsUserType.enUserTypeID.Employee)
                {
                    return true;
                }
            }

            MessageBox.Show("Login failed. Please try again and make sure the credentials are correct.",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
