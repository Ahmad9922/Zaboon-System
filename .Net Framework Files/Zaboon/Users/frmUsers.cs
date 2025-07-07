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
    public partial class frmUsers : Form
    {
        private List<clsUser> Users {  get; set; }

        public clsUserType.enUserTypeID UserType {  get; set; }

        private void InitializeInfo()
        {
            UserType = clsUserType.enUserTypeID.Client;
        }

        public frmUsers()
        {
            InitializeComponent();
            InitializeInfo();
        }

        private void LoadUsersTypes()
        {
            List<clsUserType> UserTypes = clsUserType.GetUserTypes();

            ucClientUserType.FillType(UserTypes[0]);
            ucEmployeeType.FillType(UserTypes[1]);
        }

        private void UserTypeInfo_EditClosed(object sender, EventArgs e)
        {
            LoadUsersTypes();
        }

        private void CreateAccountsControls(List<clsUser> Users)
        {
            foreach (clsUser User in Users)
            {
                ucUserCardInfo UserInfo = new ucUserCardInfo();

                UserInfo.FillUser(User);

                UserInfo.OnUserDeleted += UserInfo_OnUserDeleted;

                flpAccountsList.Controls.Add(UserInfo);
            }
        }

        private void UserInfo_OnUserDeleted(object sender, EventArgs e)
        {
            flpAccountsList.Controls.Remove((ucUserCardInfo)sender);
        }

        private void LoadUsers()
        {
            flpAccountsList.Controls.Clear();

            Users = clsUser.GetUsers(UserType);

            CreateAccountsControls(Users);
        }

        private void LoadUsers(List<clsUser> Users)
        {
            flpAccountsList.Controls.Clear();

            CreateAccountsControls(Users);
        }

        public void frmUsers_Load(object sender, EventArgs e)
        {
            LoadUsersTypes();
            LoadUsers();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser AddEditUser = new frmAddEditUser(UserType);
            AddEditUser.ShowDialog();

            LoadUsers();
        }

        private void btnSwitchType_Click(object sender, EventArgs e)
        {
            switch (UserType)
            {
                case clsUserType.enUserTypeID.Client:
                    UserType = clsUserType.enUserTypeID.Employee;
                    txtUserType.Text = "Employee accounts";
                    break;

                case clsUserType.enUserTypeID.Employee:
                    UserType = clsUserType.enUserTypeID.Client;
                    txtUserType.Text = "Client accounts";

                    break;
            }

            LoadUsers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadUsers(Users.Where(U => U.UserName.Contains(txtSearch.Text)).ToList());
            }
            else
            {
                LoadUsers();
            }
        }
    }
}
