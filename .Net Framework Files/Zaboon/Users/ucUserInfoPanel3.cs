using Dotools;
using Guna.UI2.WinForms;
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
    public partial class ucUserInfoPanel3 : UserControl
    {
        public clsUser User { get; set; }

        public ucUserInfoPanel3()
        {
            InitializeComponent();
        }

        private void LoadImage()
        {
            try
            {
                if (User.ImageByte != null)
                {
                    pbAccountImage.Image = clsConverter.ToImage(User.ImageByte);
                }
            }
            catch (Exception ex)
            {
                clsEventLogger.WriteEntryInApplicationLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
        }

        private void LoadUserInfo()
        {
            LoadImage();
            txtUserName.Text = User.UserName;
        }

        private ucServiceReservationCount GetControl(clsService service)
        {
            ucServiceReservationCount ServiceReservationCount = new ucServiceReservationCount();


            ServiceReservationCount.Size = new Size(flpReservations.Width - 10, 36);
            ServiceReservationCount.Fill(service, User);

            return ServiceReservationCount;
        }

        public void CreateServcieReservationsCount()
        {
            List<clsService> services = clsService.GetServices();

            foreach (clsService service in services)
            {
                if (User.HasReservationInService(service.ServiceID.Value))
                    flpReservations.Controls.Add(GetControl(service));
            }
        }

        public void FillUser(int UserID)
        {
            if ((User = clsUser.Find(UserID)) != null )
            {
                LoadUserInfo();
                CreateServcieReservationsCount();
            }

            UpdateUserUIState("No user has been assigned yet");
        }

        public void FillUser(clsUser User)
        {
            if ((this.User = User) != null)
            {
                LoadUserInfo();
                CreateServcieReservationsCount();
            }

            UpdateUserUIState("No user has been assigned yet");
        }

        /// <summary>
        /// Updates the UI controls depending on whether a User exists or not.
        /// If User is null, it shows a "no user" message and hides user details.
        /// Otherwise, it displays the user information.
        /// </summary>
        /// <param name="message">The message to display when no user exists.</param>
        private void UpdateUserUIState(string Message)
        {
            if (User == null)
            {

                // Show "no user" message
                lblNoUserMessage.Text = Message;
                lblNoUserMessage.Visible = true;

                // Hide user-related controls
                pbAccountImage.Visible = false;
                txtUserName.Visible = false;
                guna2Separator1.Visible = false;
                flpReservations.Visible = false;
                txtReservations.Visible = false;
            }
            else
            {
                // Hide "no user" message
                lblNoUserMessage.Visible = false;

                // Show user-related controls
                pbAccountImage.Visible = true;
                txtUserName.Visible = true;
                guna2Separator1.Visible = true;
                flpReservations.Visible = true;
                txtReservations.Visible = true;
            }
        }

        private void ucUserInfoPanel3_Load(object sender, EventArgs e)
        {
            UpdateUserUIState("No user has been assigned yet");
        }
    }
}
