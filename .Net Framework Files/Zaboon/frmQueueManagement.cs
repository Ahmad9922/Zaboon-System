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
        public Queue<clsUser> Clients = new Queue<clsUser>();
            
        private void InitializeInfo()
        {

        }

        public frmQueueManagement()
        {
            InitializeComponent();
        }

        private void btnServed_Click(object sender, EventArgs e)
        {
            Clients.Dequeue();
        }
    }
}
