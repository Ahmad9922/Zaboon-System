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
    /// <summary>
    /// Dashboard for reservations/services KPIs.
    /// Loads counts for today/month/year and top services by reservations.
    /// </summary>
    public partial class ucReservationsDashboard : UserControl
    {
        public int TopN { get; set; } = 8;

        public ucReservationsDashboard()
        {
            InitializeComponent();
        }

        private void ucReservationsDashboard_Load(object sender, EventArgs e)
        {
            // Fire and forget; UI-safe updates are inside method.
            _ = LoadDashboardAsync();
        }

        /// <summary>
        /// Loads/refreshes dashboard metrics and grid asynchronously.
        /// </summary>
        public async Task LoadDashboardAsync()
        {
            try
            {
                this.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                // Date ranges
                var (tStart, tEnd) = (DateTime.Today, DateTime.Today.AddDays(1));
                var mStart = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                var mEnd = mStart.AddMonths(1);
                var yStart = new DateTime(DateTime.Today.Year, 1, 1);
                var yEnd = yStart.AddYears(1);

                // Load numbers off-UI thread
                var todayTotalTask = Task.Run(() => clsReservation.GetCount(tStart, tEnd));
                var todayNewTask = Task.Run(() => clsReservation.GetCount(tStart, tEnd, clsReservation.enReservationStatus.New));
                var todayCompletedTask = Task.Run(() => clsReservation.GetCount(tStart, tEnd, clsReservation.enReservationStatus.Completed));
                var todayCancelledTask = Task.Run(() => clsReservation.GetCount(tStart, tEnd, clsReservation.enReservationStatus.Cancelled));

                var monthTotalTask = Task.Run(() => clsReservation.GetCount(mStart, mEnd));
                var yearTotalTask = Task.Run(() => clsReservation.GetCount(yStart, yEnd));

                var topServicesTask = Task.Run(() => clsReservation.GetTopServicesByReservations(TopN, mStart, mEnd));

                await Task.WhenAll(todayTotalTask, todayNewTask, todayCompletedTask, todayCancelledTask, monthTotalTask, yearTotalTask, topServicesTask);

                // Update UI
                lblTodayTotalValue.Text = todayTotalTask.Result.ToString();
                lblTodayNewValue.Text = todayNewTask.Result.ToString();
                lblTodayCompletedValue.Text = todayCompletedTask.Result.ToString();
                lblTodayCancelledValue.Text = todayCancelledTask.Result.ToString();

                lblMonthTotalValue.Text = monthTotalTask.Result.ToString();
                lblYearTotalValue.Text = yearTotalTask.Result.ToString();

                var dtTop = topServicesTask.Result ?? new DataTable();
                dgvTopServices.DataSource = dtTop;

                if (dtTop.Columns.Contains("ServiceID"))
                    dgvTopServices.Columns["ServiceID"].Visible = false;

                if (dtTop.Rows.Count > 0)
                {
                    var name = dtTop.Rows[0]["ServiceName"]?.ToString() ?? "-";
                    var cnt = Convert.ToInt32(dtTop.Rows[0]["ReservationsCount"]);
                    lblTopServiceName.Text = name;
                    lblTopServiceCount.Text = cnt.ToString();
                }
                else
                {
                    lblTopServiceName.Text = "No data";
                    lblTopServiceCount.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dashboard.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                this.Enabled = true;
            }
        }
    }
}
