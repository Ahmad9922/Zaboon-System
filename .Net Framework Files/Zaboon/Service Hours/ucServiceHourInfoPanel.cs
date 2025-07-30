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
    public partial class ucServiceHourInfoPanel : UserControl
    {
        public clsServiceHour ServiceHour {  get; set; }

        public event EventHandler<clsServiceHour> OnServiceHourDeleted;

        public ucServiceHourInfoPanel()
        {
            InitializeComponent();
        }

        private void LoadInfo()
        {
            if (ServiceHour != null)
            {
                txtDayOfWeek.Title = ServiceHour.DayOfWeek.ToString();
                txtStartTime.Title = ServiceHour.WorkStartTime.ToString();
                txtEndTime.Title = ServiceHour.WorkEndTime.ToString();
                txtTitle.Title = ServiceHour.Title;
            }
        }

        public void FillInfo(clsServiceHour ServiceHour)
        {
            this.ServiceHour = ServiceHour;

            if (this.ServiceHour != null)
            {
                LoadInfo();
            }
        }

        public void FillInfo(int ServiceHourID)
        {
            if ((this.ServiceHour = clsServiceHour.Find(ServiceHourID)) != null)
            {
                LoadInfo();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmServiceHourSetup frmServiceHourSetup = new frmServiceHourSetup(ServiceHour);
            frmServiceHourSetup.ShowDialog();

            LoadInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete {ServiceHour}",
                        "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (ServiceHour.Delete())
                {
                    MessageBox.Show("The service hour has been successfully deleted.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OnServiceHourDeleted?.Invoke(this, ServiceHour);

                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("This service hour cannot be deleted because they are linked to " +
                        "other entities in the system.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnQueueManagement_Click(object sender, EventArgs e)
        {
            if (ServiceHour.IsCurrentTimeInThisWorkHour())
            {
                frmQueueManagement QueueManagementForm = new frmQueueManagement(ServiceHour.ServiceID);
                QueueManagementForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("The working hours for this service have not started yet",
                       "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
