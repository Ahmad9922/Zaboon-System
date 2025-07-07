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
    public partial class ucServiceInfo : UserControl
    {
        public clsService Service { get; set; }

        public event EventHandler OnEditFormClosed;
        public event EventHandler OnServiceDeleted;

        public bool ShowDeleteButton
        {
            get
            {
                return btnDelete.Visible;
            }

            set
            {
                btnDelete.Visible = value;
            }
        }

        public bool ShowEditButton
        {
            get
            {
                return btnEdit.Visible;
            }

            set
            {
                btnEdit.Visible = value;
            }
        }

        public ucServiceInfo()
        {
            InitializeComponent();
        }

        private void LoadInfo()
        {
            txtName.Text = Service.Name;

            if (string.IsNullOrEmpty(Service.Description))
            {
                txtDescription.Text = "There is no Description for this service";
                txtDescription.Multiline = false;
                txtDescription.TextAlign = HorizontalAlignment.Center;
            }
            else
            {
                txtDescription.Text = Service.Description;
                txtDescription.Multiline = true;
                txtDescription.TextAlign = HorizontalAlignment.Left;
            }

            txtFees.Text = $"Fees: {(Service.Fees == null ? " Free" : $"{Service.Fees.ToString()}$")}";

            if (!Service.IsActive)
            {
                guna2ShadowPanel1.FillColor = Color.LightGray;
                txtName.FillColor = Color.LightGray;
                txtFees.FillColor = Color.LightGray;
            }
            else
            {
                guna2ShadowPanel1.FillColor = Color.White;
                txtName.FillColor = Color.White;
                txtFees.FillColor = Color.White;
            }
        }

        public void FillService(int ServiceTypeID)
        {
            if ((Service = clsService.Find(ServiceTypeID)) != null)
            {
                LoadInfo();
            }
        }

        public void FillService(clsService ServiceType)
        {
            this.Service = ServiceType;

            if (ServiceType != null)
            {
                LoadInfo();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddEditService AddEditServiceForm = new frmAddEditService(Service);
            AddEditServiceForm.ShowDialog();

            LoadInfo();

            OnEditFormClosed?.Invoke(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete {Service.Name}",
                        "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Service.Delete())
                {
                    MessageBox.Show("The Service has been successfully deleted.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Dispose();

                    OnServiceDeleted?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("This Service cannot be deleted because they are linked to " +
                        "other entities in the system.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
