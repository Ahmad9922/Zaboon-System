using Dotools;
using Guna.UI2.WinForms;
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
    public partial class frmAddEditReservation : Form
    {
        private struct stReservationInfo
        {
            public clsUser Client { get; set; }
            public clsService Service { get; set; }
            public clsServiceHour ServiceHour { get; set; }
        }

        private stReservationInfo ReservationInfo;

        public clsReservation Reservation {  get; set; }

        public event EventHandler<clsReservation> OnSaveSuccessfully;

        enum enMode { Add = 1, Edit = 2 }
        enMode Mode { get; set; }

        private void InitializeInfo()
        {
            LoadServices();

            dtReservationDate.MinDate = DateTime.Now;

            switch (Mode)
            {
                case enMode.Add:
                    this.Text = "Add Reservation";
                    txtTitle.Text = "Add Reservation";
                    break;

                case enMode.Edit:
                    this.Text = "Edit Reservation";
                    txtTitle.Text = "Edit Reservation";
                    FillReservationInfo();
                    break;
            }
        }

        public frmAddEditReservation()
        {
            InitializeComponent();

            Mode = enMode.Add;

            InitializeInfo();
        }

        public frmAddEditReservation(clsReservation Reservation)
        {
            InitializeComponent();

            this.Reservation = Reservation;
            Mode = enMode.Edit;

            InitializeInfo();
        }

        private void FillReservationInfo()
        {
            ucUserCardInfo1.FillUser(Reservation.User);
            cbServices.Text = Reservation.Service.Name;
            nudPaidFees.Value = Reservation.PaidFees != null ? Reservation.PaidFees.Value : 0;

            if (Reservation.ReservationDate < DateTime.Now)
                dtReservationDate.Value = DateTime.Now;
            else
                dtReservationDate.Value = Reservation.ReservationDate;

            ReservationInfo.Client = Reservation.User;
            ReservationInfo.Service = Reservation.Service;
            ReservationInfo.ServiceHour = Reservation.ServiceHour;
        }

        private void PrepareReservationObject()
        {
            switch (Mode)
            {
                case enMode.Add:
                    Reservation = clsReservation.Add(ReservationInfo.Client,
                        ReservationInfo.Service, ReservationInfo.ServiceHour);
                    break;

                case enMode.Edit:
                    Reservation.User = ReservationInfo.Client;
                    Reservation.Service = ReservationInfo.Service;
                    Reservation.ServiceHour = ReservationInfo.ServiceHour;
                    break;
            }

            if (nudPaidFees.Value != 0) Reservation.PaidFees = nudPaidFees.Value;
            else Reservation.PaidFees = null;
            
            Reservation.ReservationDate = dtReservationDate.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PrepareReservationObject();

            if (Reservation.Save())
            {
                MessageBox.Show("The reservation has been saved successfully .",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OnSaveSuccessfully?.Invoke(this, Reservation);

                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save the reservation. If the problem persists," +
                       " please seek assistance from the Service and Maintenance Center",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            frmFindUser frmFindUser = new frmFindUser();
            frmFindUser.OnUserFound += FrmFindUser_OnUserFound;
            frmFindUser.ShowDialog();
        }

        private void LoadServices()
        {
            cbServices.Items.Clear();

            List<clsService> services = clsService.GetServices();

            cbServices.Items.AddRange(services.ConvertAll(C => C.Name).ToArray());

            cbServices.SelectedIndex = 0;
        }

        private void LoadServiceHours()
        {
            /*
            This method populates the service hours into radio 
            buttons to allow selecting the appropriate time for reservation.
            */

            flpServiceHours.Controls.Clear();

            List<clsServiceHour> ServiceHours = clsServiceHour.GetServiceHours(cbServices.Text);

            ServiceHours.ForEach(SH =>
            {
                Guna2Button ServiceHourRadioButton = new Guna2Button();

                ServiceHourRadioButton.BorderRadius = 12;
                ServiceHourRadioButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                ServiceHourRadioButton.CheckedState.FillColor = System.Drawing.Color.LimeGreen;
                ServiceHourRadioButton.CheckedState.ForeColor = System.Drawing.Color.White;
                ServiceHourRadioButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                ServiceHourRadioButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                ServiceHourRadioButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                ServiceHourRadioButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                ServiceHourRadioButton.FillColor = System.Drawing.Color.White;
                ServiceHourRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F);
                ServiceHourRadioButton.ForeColor = System.Drawing.Color.LimeGreen;
                ServiceHourRadioButton.Location = new System.Drawing.Point(3, 3);
                ServiceHourRadioButton.Name = "guna2Button1";
                ServiceHourRadioButton.Size = new System.Drawing.Size(150, 45);
                ServiceHourRadioButton.TabIndex = 0;
                ServiceHourRadioButton.Text = SH.ToString();
                ServiceHourRadioButton.Tag = SH;
                ServiceHourRadioButton.CheckedChanged += ServiceHourRadioButton_CheckedChanged1;

                flpServiceHours.Controls.Add(ServiceHourRadioButton);
            });
        }

        private void ServiceHourRadioButton_CheckedChanged1(object sender, EventArgs e)
        {
            ReservationInfo.ServiceHour = (clsServiceHour)((Guna2Button)sender).Tag;
        }

        private void FrmFindUser_OnUserFound(object sender, clsUser Client)
        {
            ucUserCardInfo1.FillUser(Client);

            ReservationInfo.Client = Client;
        }

        private void cbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReservationInfo.Service = clsService.Find(cbServices.Text);

            LoadServiceHours();
        }

        private void frmAddEditReservation_Load(object sender, EventArgs e)
        {

        }
    }
}
