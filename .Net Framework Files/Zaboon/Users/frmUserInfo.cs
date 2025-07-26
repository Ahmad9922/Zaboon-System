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
    public partial class frmUserInfo : Form
    {
        private void InitializeInfo(clsUser User)
        {
            ucFullUserInfo1.FillUser(User);
        }

        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            InitializeInfo(clsUser.Find(UserID));
        }

        public frmUserInfo(clsUser User)
        {
            InitializeComponent();
            InitializeInfo(User);
        }
    }
}
