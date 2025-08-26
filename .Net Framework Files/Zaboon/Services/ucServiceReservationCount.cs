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
    public partial class ucServiceReservationCount : UserControl
    {
        public clsService Service { get; set; }
        public clsUser User { get; set; }

        public ucServiceReservationCount()
        {
            InitializeComponent();
        }

        private void SetInfoWithService()
        {
            txtServiceName.Text = Service.Name;
            txtReservationCount.Text = Service.GetReservationCount().ToString() + " Reservations";

            User = null;
        }

        private void SetInfoWithServiceAndUser()
        {
            txtServiceName.Text = Service.Name;
            txtReservationCount.Text = User.GetReservationCount(Service.ServiceID.Value).ToString() + " Reservations";
        }

        public void Fill(int ServiceID)
        {
            if ((Service = clsService.Find(ServiceID)) != null)
            {
                SetInfoWithService();
            }
        }

        public void Fill(int ServiceID, int UserID)
        {
            Service = clsService.Find(ServiceID);
            User = clsUser.Find(UserID);

            if (Service != null && User != null)
            {
                SetInfoWithServiceAndUser();
            }
        }

        public void Fill(clsService Service)
        {
            if ((this.Service = Service) != null)
            {
                SetInfoWithService();
            }
        }

        public void Fill(clsService Service, clsUser User)
        {
            this.Service = Service;
            this.User = User;

            if (Service != null && User != null)
            {
                SetInfoWithServiceAndUser();
            }
        }
    }
}
