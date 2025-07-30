using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ZaboonBL;

namespace Zaboon
{
    public partial class frmQueues : Form
    {
        List<clsService> Services = new List<clsService>();

        public frmQueues()
        {
            InitializeComponent();
        }

        private ucServiceQueuePanel InitializeControl(clsService Service)
        {
            ucServiceQueuePanel ucServiceQueuePanel = new ucServiceQueuePanel();

            ucServiceQueuePanel.FillServiceQueue(Service);

            return ucServiceQueuePanel;
        }

        private void CreateQueueControls(List<clsService> Services)
        {
            flpQueuesList.Controls.Clear();

            foreach (clsService Service in Services)
            {
                if (Service.IsWorkTimeNow())
                {
                    flpQueuesList.Controls.Add(InitializeControl(Service));
                }
            }
        }

        private void LoadQueuesServices()
        {
            Services = clsService.GetServices();

            CreateQueueControls(Services);
        }

        public void frmQueues_Load(object sender, EventArgs e)
        {
            LoadQueuesServices();
        }
    }
}
