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
        public clsService ServiceType {  get; set; }

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

        private void LoadInfo()
        {
            txtName.Text = ServiceType.Name;
            txtDescription.Text = ServiceType.Description;
            
            if (ServiceType.Fees != null)
            {
                nudFees.Value = ServiceType.Fees.Value;
            }
            else
            {
                nudFees.Value = 0;
            }

            cbIsActive.Checked = ServiceType.IsActive;
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

            this.ServiceType = ServiceType;
            Mode = enMode.Edit;

            InitializeInfo();
        }

        private bool ValidatingName()
        {
            if (Mode == enMode.Add)
            {
                ServiceType = clsService.Add(txtName.Text);

                if (ServiceType != null)
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

        private void SetServiceInfo()
        {
            if (nudFees.Value != 0)
            {
                ServiceType.Fees = nudFees.Value;
            }
            else
            {
                ServiceType.Fees = null;
            }

            ServiceType.Name = txtName.Text;
            ServiceType.Description = txtDescription.Text;
            ServiceType.IsActive = cbIsActive.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidatingName())
            {
                SetServiceInfo();

                if (ServiceType.Save())
                {
                    MessageBox.Show("The service has been saved successfully .",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OnSaveSuccessfully?.Invoke(this, ServiceType);

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
