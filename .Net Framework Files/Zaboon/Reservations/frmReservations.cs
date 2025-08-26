using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ZaboonBL;

namespace Zaboon
{
    public partial class frmReservations : Form
    {
        private int SeletedReservationID
        {
            get
            {
                return Convert.ToInt32(dgReservationsList.SelectedRows[0].Cells[0].Value);
            }
        }

        public frmReservations()
        {
            InitializeComponent();
        }

        private void LoadReservations()
        {
            dgReservationsList.DataSource = clsReservation.GetList();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            frmReservationEditor ReservationEditorForm = new frmReservationEditor();
            ReservationEditorForm.ShowDialog();

            LoadReservations();
        }

        private void dgReservationsList_SizeChanged(object sender, EventArgs e)
        {
            guna2ShapesTool1.Size = new Size(dgReservationsList.Width + 20, dgReservationsList.Height + 20);
        }

        public void frmReservations_Load(object sender, EventArgs e)
        {
            LoadReservations();

            clsReservation.CancelMissedReservations();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservationEditor EditReservationForm = new frmReservationEditor(clsReservation.Find(SeletedReservationID));
            EditReservationForm.ShowDialog();

            LoadReservations();
        }
    }
}
