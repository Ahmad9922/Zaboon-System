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
    public partial class frmEditUserType : Form
    {
        public clsUserType UserType {  get; set; }

        public frmEditUserType(clsUserType.enUserTypeID UserTypeID)
        {
            InitializeComponent();
            InitializeInfo(UserTypeID);
        }

        private void InitializeInfo(clsUserType.enUserTypeID UserTypeID)
        {
            if ((UserType = clsUserType.Find(UserTypeID)) != null)
            {
                txtName.Text = UserType.Name;
                txtDescription.Text = UserType.Description;
            }

            this.Text = $"Edit user type Info";
        }

        private void SetModifications()
        {
            UserType.Name = txtName.Text;
            UserType.Description = txtDescription.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetModifications();

            if (UserType.Save())
            {
                MessageBox.Show("The User Type has been saved successfully .",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save the User Type. If the problem persists," +
                    " please seek assistance from the Service and Maintenance Center",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void frmAddEditUserType_Load(object sender, EventArgs e)
        {

        }
    }
}
