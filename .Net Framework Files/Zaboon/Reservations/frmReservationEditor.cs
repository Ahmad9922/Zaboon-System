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
    public partial class frmReservationEditor : Form
    {
        #region Objects, Structs, Enums & Events

        /// <summary>
        /// Holds reservation-related information during the process.
        /// </summary>
        private struct stReservationInfo
        {
            public clsUser Client { get; set; }
            public clsService Service { get; set; }
            public clsServiceHour ServiceHour { get; set; }
        }

        private stReservationInfo ReservationInfo;

        public clsReservation Reservation {  get; set; }

        public event EventHandler<clsReservation> OnSaveSuccessfully;

        /// <summary>
        /// Represents the mode of the form (Add or Edit).
        /// </summary>
        private enum enFormMode { Add = 1, Edit = 2 }
        private enFormMode FormMode { get; set; }

        #endregion


        #region Constructors

        /// <summary>
        /// Initializes the form in Add mode.
        /// </summary>
        public frmReservationEditor()
        {
            InitializeComponent();

            FormMode = enFormMode.Add;

            InitializeForm();
        }

        /// <summary>
        /// Initializes the form in Edit mode with an existing reservation.
        /// </summary>
        public frmReservationEditor(clsReservation Reservation)
        {
            InitializeComponent();

            this.Reservation = Reservation;
            FormMode = enFormMode.Edit;

            InitializeForm();
        }

        #endregion


        #region Initialization

        /// <summary>
        /// Sets up the form (title, default values, data).
        /// </summary>
        private void InitializeForm()
        {
            dtReservationDate.MinDate = DateTime.Now;
            dtReservationDate.Value = DateTime.Now;

            LoadServices();

            switch (FormMode)
            {
                case enFormMode.Add:
                    this.Text = "Add Reservation";
                    txtTitle.Text = "Add Reservation";
                    break;

                case enFormMode.Edit:
                    this.Text = "Edit Reservation";
                    txtTitle.Text = "Edit Reservation";
                    FillReservationInfo();
                    break;
            }
        }

        #endregion


        #region Helper Methods


        /// <summary>
        /// Loads all services into the services combo box.
        /// </summary>
        private void LoadServices()
        {
            cbServices.Items.Clear();

            List<clsService> services = clsService.GetServices();

            cbServices.Items.AddRange(services.ConvertAll(S => S.Name).ToArray());

            if (cbServices.Items.Count > 0)
                cbServices.SelectedIndex = 0;
        }

        /// <summary>
        /// Loads service hours (as radio buttons) for the selected day.
        /// </summary>
        private void LoadServiceHours(DayOfWeek DayOfWeek)
        {
            flpServiceHours.Controls.Clear();
            flpServiceHours.Visible = true;

            List<clsServiceHour> ServiceHours = clsServiceHour.GetServiceHours(cbServices.Text, DayOfWeek);

            ServiceHours.ForEach(hour =>
            {
                Guna2Button btnServiceHour = new Guna2Button
                {
                    BorderRadius = 12,
                    ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton,
                    CheckedState = { FillColor = Color.LimeGreen, ForeColor = Color.White },
                    DisabledState =
                {
                    BorderColor = Color.DarkGray,
                    CustomBorderColor = Color.DarkGray,
                    FillColor = Color.FromArgb(169, 169, 169),
                    ForeColor = Color.FromArgb(141, 141, 141)
                },
                    FillColor = Color.White,
                    Font = new Font("Segoe UI", 9F),
                    ForeColor = Color.LimeGreen,
                    Location = new Point(3, 3),
                    Size = new Size(150, 45),
                    Text = hour.ToString(),
                    Tag = hour
                };

                btnServiceHour.CheckedChanged += ServiceHourRadioButton_CheckedChanged;
                flpServiceHours.Controls.Add(btnServiceHour);
            });

            // Auto-check the first button if available
            if (flpServiceHours.Controls.OfType<Guna2Button>().Any())
                flpServiceHours.Controls.OfType<Guna2Button>().First().Checked = true;

            ValidateSaveAvailability();
        }

        /// <summary>
        /// Fills the form controls with reservation data (for edit mode).
        /// </summary>
        private void FillReservationInfo()
        {
            ucUserCardInfo1.FillUser(Reservation.User);
            cbServices.Text = Reservation.Service.Name;
            nudPaidFees.Value = Reservation.PaidFees != null ? Reservation.PaidFees.Value : 0;

            dtReservationDate.Value = Reservation.ReservationDate < DateTime.Now
                        ? DateTime.Now
                        : Reservation.ReservationDate;

            ReservationInfo.Client = Reservation.User;
            ReservationInfo.Service = Reservation.Service;
            ReservationInfo.ServiceHour = Reservation.ServiceHour;
        }


        /// <summary>
        /// Prepares the Reservation object before saving.
        /// </summary>
        private void PrepareReservation()
        {
            switch (FormMode)
            {
                case enFormMode.Add:
                    Reservation = clsReservation.Add(ReservationInfo.Client,
                        ReservationInfo.Service, ReservationInfo.ServiceHour);
                    break;

                case enFormMode.Edit:
                    Reservation.User = ReservationInfo.Client;
                    Reservation.Service = ReservationInfo.Service;
                    Reservation.ServiceHour = ReservationInfo.ServiceHour;
                    break;
            }

            if (nudPaidFees.Value != 0) Reservation.PaidFees = nudPaidFees.Value;
            else Reservation.PaidFees = null;
            
            Reservation.ReservationDate = dtReservationDate.Value;
        }


        /// <summary>
        /// Enables or disables the Save button depending on required data.
        /// </summary>
        private bool ValidateSaveAvailability()
        {
            bool canSave = (ReservationInfo.Client != null &&
                        ReservationInfo.Service != null &&
                        ReservationInfo.ServiceHour != null);

            btnSave.Enabled = canSave;
            return canSave;
        }

        #endregion


        #region Events Handlers

        private void btnSave_Click(object sender, EventArgs e)
        {
            PrepareReservation();

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

        private void ServiceHourRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ReservationInfo.ServiceHour = (clsServiceHour)((Guna2Button)sender).Tag;
        }

        private void FrmFindUser_OnUserFound(object sender, clsUser Client)
        {
            ucUserCardInfo1.FillUser(Client);
            
            ReservationInfo.Client = Client;

            ValidateSaveAvailability();
        }

        private void cbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReservationInfo.Service = clsService.Find(cbServices.Text);

            if (ReservationInfo.Service.HasServiceHoursForDay(dtReservationDate.Value.DayOfWeek))
            {
                LoadServiceHours(dtReservationDate.Value.DayOfWeek);
            }
            else
            {
                lblNoServiceHoursMessage.Text = $"No service hours defined for {ReservationInfo.Service.Name} on the selected date.";
                ReservationInfo.ServiceHour = null;
                flpServiceHours.Visible = false;
                ValidateSaveAvailability();
            }
        }

        private void frmAddEditReservation_Load(object sender, EventArgs e)
        {
            ValidateSaveAvailability();
        }

        private void dtReservationDate_ValueChanged(object sender, EventArgs e)
        {
            LoadServiceHours(dtReservationDate.Value.DayOfWeek);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
