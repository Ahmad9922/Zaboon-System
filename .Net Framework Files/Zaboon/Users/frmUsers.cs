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

        public clsUserType.enUserTypeID UsersType {  get; set; }

        private void InitializeInfo()
        {
            UsersType = clsUserType.enUserTypeID.Client;
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

                UserInfo.UserInfoClosed += UserInfo_UserInfoClosed;

                flpAccountsList.Controls.Add(UserInfo);
            }
        }

        private void UserInfo_UserInfoClosed(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            flpAccountsList.Controls.Clear();

            Users = clsUser.GetUsers(UsersType);

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
            frmAddEditUser AddEditUser = new frmAddEditUser(UsersType);
            AddEditUser.ShowDialog();

            LoadUsers();
        }

        private void btnSwitchType_Click(object sender, EventArgs e)
        {
            switch (UsersType)
            {
                case clsUserType.enUserTypeID.Client:
                    UsersType = clsUserType.enUserTypeID.Employee;
                    txtUserType.Text = "Employee accounts";
                    break;

                case clsUserType.enUserTypeID.Employee:
                    UsersType = clsUserType.enUserTypeID.Client;
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
