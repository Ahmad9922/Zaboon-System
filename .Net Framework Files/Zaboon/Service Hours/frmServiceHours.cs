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
    public partial class frmServiceHours : Form
    {
        public int ServiceID { get; set; }

        public List<clsServiceHour> ServiceHours {  get; set; }

        private void InitializeInfo()
        {
            cbDaysOfWeek.SelectedIndex = 0;
        }

        public frmServiceHours(List<clsServiceHour> ServiceHours, int ServiceID)
        {
            InitializeComponent();
            InitializeInfo();
            this.ServiceHours = ServiceHours;
            this.ServiceID = ServiceID;
        }

        private ucServiceHourCardInfo InitializeControl(clsServiceHour ServiceHour)
        {
            ucServiceHourCardInfo ServiceInfo = new ucServiceHourCardInfo();

            ServiceInfo.Size = new Size(flpServiceHoursList.Width - 25, ServiceInfo.Height);

            ServiceInfo.OnServiceHourDeleted += ServiceInfo_OnServiceHourDeleted;

            ServiceInfo.FillInfo(ServiceHour);

            return ServiceInfo;
        }

        private void SetNoServiceHoursProperties()
        {
            if (ServiceHours != null && ServiceHours.Count == 0)
            {
                lblEmptyMessage.Visible = true;
                flpServiceHoursList.Visible = false;
            }
            else
            {
                lblEmptyMessage.Visible = false;
                flpServiceHoursList.Visible = true;
            }
        }

        private void ServiceInfo_OnServiceHourDeleted(object sender, clsServiceHour ServiceHour)
        {
            ServiceHours.Remove(ServiceHour);

            SetNoServiceHoursProperties();
        }

        private void CreateServiceHoursControls(List<clsServiceHour> ServiceHours)
        {
            flpServiceHoursList.Controls.Clear();

            if (ServiceHours != null && ServiceHours.Count > 0)
            {
                ServiceHours.ForEach(SH => flpServiceHoursList.Controls.Add(InitializeControl(SH)));
            }

            SetNoServiceHoursProperties();
        }

        private void LoadAllServiceHours()
        {
            CreateServiceHoursControls(ServiceHours);
        }

        private void frmServiceHours_Load(object sender, EventArgs e)
        {
            LoadAllServiceHours();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            frmServiceHourSetup ServiceHourSetupForm = new frmServiceHourSetup(ServiceID);
            ServiceHourSetupForm.OnSaveSuccessfully += ServiceHourSetupForm_OnSaveSuccessfully;
            ServiceHourSetupForm.ShowDialog();
        }

        private void ServiceHourSetupForm_OnSaveSuccessfully(object sender, clsServiceHour ServiceHour)
        {
            flpServiceHoursList.Controls.Add(InitializeControl(ServiceHour));
            ServiceHours.Add(ServiceHour);

            SetNoServiceHoursProperties();
        }

        private void cbDaysOfWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDaysOfWeek.Text == "All")
            {
                LoadAllServiceHours();
            }
            else
            {
                IEnumerable<clsServiceHour> FilteredServiceHours = ServiceHours.Where(SH =>
                SH.DayOfWeek.ToString() == cbDaysOfWeek.Text);

                if (FilteredServiceHours.Count() > 0)
                {
                    CreateServiceHoursControls(FilteredServiceHours.ToList());
                }
                else
                {
                    lblEmptyMessage.Visible = true;
                    flpServiceHoursList.Visible = false;
                }
            }
        }

        private void flpServiceHoursList_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control C in flpServiceHoursList.Controls)
            {
                C.Size = new Size(flpServiceHoursList.Width - 25, C.Height);
            }
        }
    }
}
