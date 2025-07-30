using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaboon
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();
            frmUsers Users = new frmUsers();
            frmReservations Reservations = new frmReservations();
            frmServices services = new frmServices();
            frmQueues Queues = new frmQueues();

            ucTabControl.SetForm(Home);
            ucTabControl.SetForm(Users, Users.frmUsers_Load);
            ucTabControl.SetForm(Reservations, Reservations.frmReservations_Load);
            ucTabControl.SetForm(Queues, Queues.frmQueues_Load);
            ucTabControl.SetForm(services, services.frmServices_Load);
        }
    }
}
