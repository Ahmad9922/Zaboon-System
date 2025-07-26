using CustomControls;
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
    public partial class frmAddEditService : Form
    {
        public clsService Service {  get; set; }

        public event EventHandler<clsService> OnSaveSuccessfully;

        enum enMode { Add = 1, Edit = 2 }
        enMode Mode { get; set; }

        private void InitializeInfo()
        {
            switch (Mode)
            {
                case enMode.Add:
                    this.Text = "Add Service";
                    txtTitle.Text = "Add Service";
                    break;

                case enMode.Edit:
                    this.Text = "Edit Service";
                    txtTitle.Text = "Edit Service";
                    LoadInfo();
                    break;
            }
        }

        private void LoadServiceHours()
        {
            List<UCTimeRangePicker.TimeRange> hours = new List<UCTimeRangePicker.TimeRange>();

            foreach (clsServiceHour ServiceHour in Service.ServiceHours)
            {
                UCTimeRangePicker.TimeRange timeRange = new UCTimeRangePicker.TimeRange();
                timeRange.StartTime = ServiceHour.WorkStartTime;
                timeRange.EndTime = ServiceHour.WorkEndTime;

                hours.Add(timeRange);
            }

        }

        private void LoadInfo()
        {
            txtName.Text = Service.Name;
            txtDescription.Text = Service.Description;
            
            if (Service.Fees != null)
            {
                nudFees.Value = Service.Fees.Value;
            }
            else
            {
                nudFees.Value = 0;
            }

            cbIsActive.Checked = Service.IsActive;

            LoadServiceHours();
        }

        public frmAddEditService()
        {
            InitializeComponent();

            Mode = enMode.Add;

            InitializeInfo();
        }

        public frmAddEditService(clsService ServiceType)
        {
            InitializeComponent();

            this.Service = ServiceType;
            Mode = enMode.Edit;

            InitializeInfo();
        }

        private bool ValidatingName()
        {
            if (Mode == enMode.Add)
            {
                Service = clsService.Add(txtName.Text);

                if (Service != null)
                {
                    return true;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    return true;
                }
            }

            MessageBox.Show("The name cannot be left blank.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void PrepareServiceInfo()
        {
            if (nudFees.Value != 0)
            {
                Service.Fees = nudFees.Value;
            }
            else
            {
                Service.Fees = null;
            }

            Service.Name = txtName.Text;
            Service.Description = txtDescription.Text;
            Service.IsActive = cbIsActive.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidatingName())
            {
                PrepareServiceInfo();

                if (Service.Save())
                {
                    MessageBox.Show("The service has been saved successfully .",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OnSaveSuccessfully?.Invoke(this, Service);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save the service. If the problem persists," +
                        " please seek assistance from the Service and Maintenance Center",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
