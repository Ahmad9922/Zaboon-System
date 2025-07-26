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
    public partial class frmFindUser : Form
    {
        public event EventHandler<clsUser> OnUserFound;

        public clsUser User {  get; set; }

        public frmFindUser()
        {
            InitializeComponent();
        }

        private void ucFindUser1_OnUserFound(object sender, clsUser User)
        {
            this.User = User;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (User != null)
            {
                OnUserFound?.Invoke(this, User);
                this.Close();
            }
            else
            {
               
            }
        }
    }
}
