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
    public partial class ucUserTypeInfo : UserControl
    {
        public event EventHandler EditClosed;

        public clsUserType UserType { get; set; }

        public ucUserTypeInfo()
        {
            InitializeComponent();
        }

        public void FillType(clsUserType.enUserTypeID UserTypeID)
        {
            if ((UserType = clsUserType.Find(UserTypeID)) != null)
            {
                txtName.Text = UserType.Name;
                txtDescription.Text = UserType.Description;
            }
        }

        public void FillType(clsUserType UserType)
        {
            this.UserType = UserType;

            if (this.UserType != null)
            {
                txtName.Text = UserType.Name;
                txtDescription.Text = UserType.Description;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (UserType != null)
            {
                frmEditUserType AddEditUserType = new frmEditUserType(UserType.UserTypeID);
                AddEditUserType.ShowDialog();

                EditClosed?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show($"Cannot modify a null object.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
