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
    public partial class frmServiceHourSetup : Form
    {
        public int ServiceID { get; set; }

        public clsServiceHour ServiceHour {  get; set; }

        public event EventHandler<clsServiceHour> OnSaveSuccessfully;

        enum enMode { Add = 1, Edit = 2 }
        enMode Mode { get; set; }

        private void InitializeInfo()
        {
            cbDaysOfWeek.SelectedIndex = 0;

            switch (Mode)
            {
                case enMode.Add:
                    this.Text = "Add Service Hour";
                    break;

                case enMode.Edit:
                    this.Text = "Edit Service Hour";
                    FillInfoInControls();
                    break;
            }
        }

        public frmServiceHourSetup(int ServiceID)
        {
            InitializeComponent();
            this.ServiceID = ServiceID;
            Mode = enMode.Add;
            InitializeInfo();
        }

        public frmServiceHourSetup(clsServiceHour ServiceHour)
        {
            InitializeComponent();
            this.ServiceHour = ServiceHour;
            this.ServiceID = ServiceHour.ServiceID;
            Mode = enMode.Edit;
            InitializeInfo();
        }

        private void FillInfoInControls()
        {
            txtTitle.Text = ServiceHour.Title;
            cbDaysOfWeek.Text = ServiceHour.DayOfWeek.ToString();

            CustomControls.UCTimeRangePicker.TimeRange Range = new CustomControls.UCTimeRangePicker.TimeRange();
            Range.StartTime = ServiceHour.WorkStartTime;
            Range.EndTime = ServiceHour.WorkEndTime;

            ucTimeRangePicker1.Value = Range;
        }

        private void PrepareServiceHourObject()
        {
            if (Mode == enMode.Add)
            {
                ServiceHour = clsServiceHour.Add(ucTimeRangePicker1.Value.StartTime,
                    ucTimeRangePicker1.Value.EndTime, (DayOfWeek)cbDaysOfWeek.SelectedIndex, ServiceID);
            }
            else
            {
                ServiceHour.WorkStartTime = ucTimeRangePicker1.Value.StartTime;
                ServiceHour.WorkEndTime = ucTimeRangePicker1.Value.EndTime;
                ServiceHour.DayOfWeek = (DayOfWeek)cbDaysOfWeek.SelectedIndex;
            }

            ServiceHour.Title = txtTitle.Text;
        }

        private bool ValidateServiceHour()
        {
            return !ServiceHour.Exists();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PrepareServiceHourObject();

            if (ValidateServiceHour())
            {
                if (ServiceHour.Save())
                {
                    MessageBox.Show("The service hour has been saved successfully .",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OnSaveSuccessfully?.Invoke(this, ServiceHour);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save the service hour. If the problem persists," +
                        " please seek assistance from the Service and Maintenance Center",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sorry, the specified time range overlaps with an existing service hour.",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
