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
    public partial class ucUsersStatistics : UserControl
    {
        public ucUsersStatistics()
        {
            InitializeComponent();
        }

        public void FillInfo()
        {
            lblTotalUsers.Text = clsUser.GetUsersCount().ToString();
            lblActiveUsers.Text = "Active: " + clsUser.GetActiveUsersCount().ToString();
            lblInactiveUsers.Text = "Inactive: " + clsUser.GetInactiveUsersCount().ToString();
            lblClients.Text = clsUser.GetClientsCount().ToString();
            lblEmployees.Text = clsUser.GetEmployeesCount().ToString();
        }
    }
}
