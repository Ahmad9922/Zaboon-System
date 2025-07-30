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
    public partial class frmQueueManagement : Form
    {
        public Queue<clsReservation> Reservations = new Queue<clsReservation>();
        public Queue<clsReservation> PostponedReservations  = new Queue<clsReservation>();

        private void FillClientsQueue(List<clsReservation> Reservations)
        {
            Reservations.ForEach(R => this.Reservations.Enqueue(R));
        }

        private void InitializeInfo(int ServiceID)
        {
            FillClientsQueue(clsReservation.GetCurrentServiceHourReservations(ServiceID));
        }

        public frmQueueManagement(int ServiceID)
        {
            InitializeComponent();
            InitializeInfo(ServiceID);
        }

        public frmQueueManagement(Queue<clsReservation> Reservations)
        {
            InitializeComponent();
            this.Reservations = Reservations;
        }

        private void AssignTheNextClient()
        {
            if (Reservations.Count > 1)
            {
                ucNextClient.FillUser(Reservations.ToArray()[1].User);
            }
            else
            {
                ucNextClient.Clear();
            }
        }

        private void AssignTheServiceReceivingClient()
        {
            if (Reservations.Count > 0)
            {
                ucReceivesService.FillUser(Reservations.Peek().User);
            }
            else
            {
                ucReceivesService.Clear();
            }
        }

        private void btnServed_Click(object sender, EventArgs e)
        {
            if (Reservations.Count > 0)
            {
                clsReservation ServedReservation = Reservations.Dequeue();

                ServedReservation.ReservationStatus = clsReservation.enReservationStatus.Completed;

                if (ServedReservation.Save())
                {
                    ucServedClient.FillUser(ServedReservation.User);

                    AssignTheServiceReceivingClient();
                    AssignTheNextClient();
                }
            }

        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            if (Reservations.Count > 0)
            {
                Reservations.Dequeue();
            }
        }

        private void btnPostponeTurn_Click(object sender, EventArgs e)
        {
            if (Reservations.Count > 0)
            {
                PostponedReservations.Enqueue(Reservations.Dequeue());
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Reservations.Count > 0)
            {
                guna2Panel1.Visible = true;

                AssignTheServiceReceivingClient();
                AssignTheNextClient();
            }
            else
            {
                MessageBox.Show("There are no reservations to manage.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (Reservations.Count > 0)
            {
               
            }
            else
            {
                MessageBox.Show("There are no reservations to manage.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
