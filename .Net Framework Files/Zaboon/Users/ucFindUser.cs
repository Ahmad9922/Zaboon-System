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
    public partial class ucFindUser : UserControl
    {
        public event EventHandler<clsUser> OnUserFound; 

        public ucFindUser()
        {
            InitializeComponent();
        }

        private void FindUser()
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                ucUserCardInfo1.FillUser(txtSearch.Text);

                if (ucUserCardInfo1.User != null)
                {
                    OnUserFound?.Invoke(this, ucUserCardInfo1.User);
                }
                else
                {
                    MessageBox.Show("Failed to find user, please check username and try again.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearch_IconRightClick(object sender, EventArgs e)
        {
            FindUser();
        }

        private void txtSearch_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindUser();
            }
        }
    }
}
