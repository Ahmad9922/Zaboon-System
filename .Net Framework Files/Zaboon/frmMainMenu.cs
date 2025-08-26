using Dotools;
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

        private void LoadAccountImage()
        {
            try
            {
                if (clsGlobal.RegisteredUser?.ImageByte != null)
                {
                    cpbAccountImage.Image = clsConverter.ToImage(clsGlobal.RegisteredUser.ImageByte);
                }
            }
            catch (Exception ex)
            {
                clsEventLogger.WriteEntryInApplicationLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
        }

        private void LoadRegisteredUserInfo()
        {
            LoadAccountImage();
            lblUserName.Text = clsGlobal.RegisteredUser?.UserName;
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();
            frmUsers Users = new frmUsers();
            frmReservations Reservations = new frmReservations();
            frmServices services = new frmServices();
            frmQueues Queues = new frmQueues();

            ucTabControl.SetForm(Home, Home.frmHome_Load);
            ucTabControl.SetForm(Users, Users.frmUsers_Load);
            ucTabControl.SetForm(Reservations, Reservations.frmReservations_Load);
            ucTabControl.SetForm(Queues, Queues.frmQueues_Load);
            ucTabControl.SetForm(services, services.frmServices_Load);

            LoadRegisteredUserInfo();
        }

        private void cpbAccountImage_Click(object sender, EventArgs e)
        {
            frmUserInfo UserInfoForm = new frmUserInfo(clsGlobal.RegisteredUser);
            UserInfoForm.ShowDialog();

            LoadRegisteredUserInfo();
        }
    }
}
