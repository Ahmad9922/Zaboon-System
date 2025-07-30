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
    public partial class frmServices : Form
    {
        List<clsService> Services = new List<clsService>();

        public frmServices()
        {
            InitializeComponent();
        }

        private ucServiceInfoPanel InitializeControl(clsService Service)
        {
            ucServiceInfoPanel ucServiceInfo = new ucServiceInfoPanel();

            ucServiceInfo.FillService(Service);

            return ucServiceInfo;
        }

        private void CreateServiceControls(List<clsService> Services)
        {
            flpServicesList.Controls.Clear();

            foreach (clsService Service in Services)
            {
                flpServicesList.Controls.Add(InitializeControl(Service));
            }
        }

        private void LoadServices()
        {
            Services = clsService.GetServices();

            CreateServiceControls(Services);
        }

        public void frmServices_Load(object sender, EventArgs e)
        {
            LoadServices();

            txtSearch.Focus();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            frmAddEditService AddEditServiceForm = new frmAddEditService();
            AddEditServiceForm.OnSaveSuccessfully += AddEditServiceForm_OnSaveCompleted;
            AddEditServiceForm.ShowDialog();
        }

        private void AddEditServiceForm_OnSaveCompleted(object sender, clsService Service)
        {
            flpServicesList.Controls.Add(InitializeControl(Service));
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                CreateServiceControls(Services.Where(U => U.Name.ToLower().Contains(txtSearch.Text)).ToList());
            }
            else
            {
                CreateServiceControls(Services);
            }
        }
    }
}
