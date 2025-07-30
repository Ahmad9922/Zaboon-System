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
    public partial class ucServiceQueuePanel : UserControl
    {
        public event EventHandler<clsReservation> OnReservationAdded;

        public Queue<clsReservation> Reservations = new Queue<clsReservation>();

        public clsService Service {  get; set; }

        public clsServiceHour CurrentServiceHour { get; set; }

        public ucServiceQueuePanel()
        {
            InitializeComponent();
        }

        private void LoadInfo()
        {
            txtServiceName.Text = Service.Name;
            Reservations = Service.GetCurrentQueue();
            txtQueueLength.Text = $"{Reservations.Count} Reservations";
            CurrentServiceHour = Service.GetCurrentServiceHour();
            txtServiceHour.Text = CurrentServiceHour.ToString();
        }

        public void FillServiceQueue(clsService Service)
        {
            this.Service = Service;

            if (Service != null)
            {
                LoadInfo();
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            frmFindUser FindUserForm = new frmFindUser();
            FindUserForm.OnUserFound += FindUserForm_OnUserFound;
            FindUserForm.ShowDialog();

            txtQueueLength.Text = $"{Reservations.Count} Reservations";
        }

        private clsReservation AddReservation(clsUser Client)
        {
            clsReservation Reservation = clsReservation.Add(Client, Service, CurrentServiceHour);

            if (Reservation.Save())
            {
                OnReservationAdded?.Invoke(this, Reservation);
                return Reservation;
            }
            
            return null;
        }

        private void FindUserForm_OnUserFound(object sender, clsUser Client)
        {
            Reservations.Enqueue(AddReservation(Client));
        }

        private void btnQueueManagement_Click(object sender, EventArgs e)
        {
            frmQueueManagement QueueManagementForm = new frmQueueManagement(Reservations);
            QueueManagementForm.ShowDialog();
        }
    }
}
