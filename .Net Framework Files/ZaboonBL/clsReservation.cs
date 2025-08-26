using ZaboonDAL;
 using Dotools;
 using System;
 using System.Collections.Generic;
 using System.Data;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

namespace ZaboonBL
{
    /// <summary>
    /// Business layer class that represents a reservation and encapsulates domain logic
    /// for creating, updating, finding, and querying reservations. Persists via clsReservationDataAccess.
    /// </summary>
    public class clsReservation
    {
        #region Enums / Mode

        /// <summary>
        /// Object persistence mode.
        /// </summary>
        public enum enMode
        {
            /// <summary>
            /// New reservation (not saved yet).
            /// </summary>
            AddNew = 1,

            /// <summary>
            /// Existing reservation (updates only).
            /// </summary>
            Update = 2
        }

        /// <summary>
        /// Reservation status mapping to DB numeric values.
        /// </summary>
        public enum enReservationStatus
        {
            /// <summary>
            /// New / pending reservation (1).
            /// </summary>
            New = 1,

            /// <summary>
            /// Reservation cancelled (2).
            /// </summary>
            Cancelled = 2,

            /// <summary>
            /// Reservation completed (3).
            /// </summary>
            Completed = 3
        }

        #endregion

        #region Properties

        public int? ReservationID { get; set; }

        public clsUser User { get; set; }
        public DateTime ReservationDate { get; set; }
        public enReservationStatus ReservationStatus { get; set; }
        public decimal? PaidFees { get; set; }
        public clsService Service { get; set; }
        public clsServiceHour ServiceHour { get; set; }
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Current object mode (AddNew/Update).
        /// </summary>
        public enMode Mode { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Private constructor to create a new reservation (AddNew mode).
        /// </summary>
        /// <param name="User">The user making the reservation.</param>
        /// <param name="Service">The target service.</param>
        /// <param name="ServiceHour">The selected service hour.</param>
        private clsReservation(clsUser User, clsService Service, clsServiceHour ServiceHour)
        {
            ReservationID = null;

            this.User = User;
            this.Service = Service;
            this.ServiceHour = ServiceHour;

            ReservationDate = DateTime.Now;
            ReservationStatus = enReservationStatus.New;
            PaidFees = null;
            CreateDate = DateTime.Now;

            this.Mode = enMode.AddNew;
        }

        /// <summary>
        /// Private constructor to materialize an existing reservation from DAL data (Update mode).
        /// </summary>
        /// <param name="ReservationData">DAL DTO loaded from database.</param>
        private clsReservation(clsReservationDataAccess.clsReservationData ReservationData)
        {
            ReservationID = ReservationData.ReservationID;
            User = clsUser.Find(ReservationData.UserID);
            ReservationDate = ReservationData.ReservationDate;
            ReservationStatus = (enReservationStatus)ReservationData.ReservationStatus;
            PaidFees = ReservationData.PaidFees;
            Service = clsService.Find(ReservationData.ServiceID);
            ServiceHour = clsServiceHour.Find(ReservationData.ServiceHourID);
            CreateDate = ReservationData.CreateDate;

            this.Mode = enMode.Update;
        }

        #endregion

        #region Persistence (private)

        /// <summary>
        /// Adds the current reservation to the database and sets <see cref="ReservationID"/> on success.
        /// </summary>
        /// <returns>True if added; otherwise, false.</returns>
        private bool _Add()
        {
            clsReservationDataAccess.clsReservationData ReservationData = new clsReservationDataAccess.clsReservationData
            {
                ReservationID = ReservationID,
                UserID = User.UserID.Value,
                ReservationDate = ReservationDate,
                ReservationStatus = Convert.ToByte(ReservationStatus),
                PaidFees = PaidFees,
                ServiceID = Service.ServiceID.Value,
                ServiceHourID = ServiceHour.ServiceHourID.Value
            };

            this.ReservationID = clsReservationDataAccess.Add(ReservationData);

            return this.ReservationID != null;
        }

        /// <summary>
        /// Updates the current reservation in the database.
        /// </summary>
        /// <returns>True if updated; otherwise, false.</returns>
        private bool _Update()
        {
            clsReservationDataAccess.clsReservationData ReservationData = new clsReservationDataAccess.clsReservationData
            {
                ReservationID = ReservationID,
                UserID = User.UserID.Value,
                ReservationDate = ReservationDate,
                ReservationStatus = Convert.ToByte(ReservationStatus),
                PaidFees = PaidFees,
                ServiceID = Service.ServiceID.Value,
                ServiceHourID = ServiceHour.ServiceHourID.Value
            };

            return clsReservationDataAccess.Update(ReservationData);
        }

        #endregion

        #region Persistence (public)

        /// <summary>
        /// Saves the reservation:
        /// - If in AddNew mode, inserts and switches to Update mode on success.
        /// - If in Update mode, updates the record.
        /// </summary>
        /// <returns>True if the operation succeeded; otherwise, false.</returns>
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_Add())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _Update();
            }

            return false;

        }

        /// <summary>
        /// Deletes the current reservation by <see cref="ReservationID"/>.
        /// </summary>
        /// <returns>True if deletion succeeded; otherwise, false.</returns>
        public bool Delete()
        {
            return clsReservationDataAccess.Delete(ReservationID.Value);
        }

        #endregion

        #region Finders / Factory (static)

        /// <summary>
        /// Finds a reservation by its identifier.
        /// </summary>
        /// <param name="ReservationID">Reservation identifier.</param>
        /// <returns>clsReservation instance if found; otherwise, null.</returns>
        public static clsReservation Find(int ReservationID)
        {
            clsReservationDataAccess.clsReservationData ReservationData = new clsReservationDataAccess.clsReservationData
            {
                ReservationID = ReservationID
            };

            if (clsReservationDataAccess.GetByID(ReservationData))
            {
                return new clsReservation(ReservationData);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Factory: creates a new reservation (AddNew mode) without persisting.
        /// </summary>
        /// <param name="User">The user making the reservation.</param>
        /// <param name="Service">The target service.</param>
        /// <param name="ServiceHour">The selected service hour.</param>
        /// <returns>New clsReservation in AddNew mode; otherwise, null if inputs invalid.</returns>
        public static clsReservation Add(clsUser User, clsService Service, clsServiceHour ServiceHour)
        {
            if (User != null && Service != null)
            {
                return new clsReservation(User, Service, ServiceHour);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Static delete by identifier.
        /// </summary>
        /// <param name="ReservationID">Reservation identifier.</param>
        /// <returns>True if deletion succeeded; otherwise, false.</returns>
        public static bool Delete(int ReservationID)
        {
            return clsReservationDataAccess.Delete(ReservationID);
        }

        #endregion

        #region Existence / Lists (static)

        /// <summary>
        /// Checks whether a reservation exists by its identifier.
        /// </summary>
        /// <param name="ReservationID">Reservation identifier.</param>
        /// <returns>True if exists; otherwise, false.</returns>
        public static bool IsExist(int ReservationID)
        {
            return clsReservationDataAccess.IsExist(ReservationID);
        }

        /// <summary>
        /// Retrieves a details list of reservations as DataTable (via DAL view/selection).
        /// </summary>
        /// <returns>DataTable with reservations details.</returns>
        public static DataTable GetList()
        {
            return clsReservationDataAccess.GetList();
        }

        /// <summary>
        /// Retrieves a filtered details list of reservations as DataTable.
        /// </summary>
        /// <param name="Value">Filter value.</param>
        /// <param name="FieldName">Target field to filter by.</param>
        /// <returns>Filtered DataTable.</returns>
        public static DataTable GetList(string Value, string FieldName)
        {
            return clsReservationDataAccess.GetList(new clsDataTypes.clsFilterData(Value, FieldName));
        }

        public static DataTable GetTopServicesByReservations(int topN, DateTime start, DateTime endExclusive)
        {
            return clsReservationDataAccess.GetTopServicesByReservations(topN, start, endExclusive);
        }


        /// <summary>
        /// Retrieves all reservations as domain objects.
        /// </summary>
        /// <returns>List of clsReservation.</returns>
        public static List<clsReservation> GetReservations()
        {
            return clsReservationDataAccess.GetReservations().Select(R => new clsReservation(R)).ToList();
        }

        /// <summary>
        /// Retrieves reservations for a specific user as domain objects.
        /// </summary>
        /// <param name="UserID">User identifier.</param>
        /// <returns>List of clsReservation for the user.</returns>
        public static List<clsReservation> GetReservations(int UserID)
        {
            return clsReservationDataAccess.GetReservations(UserID).Select(R => new clsReservation(R)).ToList();
        }

        /// <summary>
        /// Retrieves reservations for a specific user and service as domain objects.
        /// </summary>
        /// <param name="UserID">User identifier.</param>
        /// <param name="ServiceID">Service identifier.</param>
        /// <returns>List of clsReservation for the user and service.</returns>
        public static List<clsReservation> GetReservations(int UserID, int ServiceID)
        {
            return clsReservationDataAccess.GetReservations(UserID, ServiceID).Select(R => new clsReservation(R)).ToList();
        }

        /// <summary>
        /// Retrieves today's reservations for the current service hour of a specific service.
        /// </summary>
        /// <param name="ServiceID">Service identifier.</param>
        /// <returns>List of clsReservation ordered by creation date (according to DAL query).</returns>
        public static List<clsReservation> GetCurrentServiceHourReservations(int ServiceID)
        {
            return clsReservationDataAccess.GetCurrentServiceHourReservations(ServiceID).Select(R => new clsReservation(R)).ToList();
        }

        #endregion

        #region Counters / Maintenance (static)

        /// <summary>
        /// Gets total reservations count for a service.
        /// </summary>
        /// <param name="ServiceID">Service identifier.</param>
        /// <returns>Number of reservations.</returns>
        public static int GetResrvationCount(int ServiceID)
        {
            return clsReservationDataAccess.GetReservationCount(ServiceID);
        }

        /// <summary>
        /// Gets total reservations count for a service by a specific user.
        /// </summary>
        /// <param name="ServiceID">Service identifier.</param>
        /// <param name="UserID">User identifier.</param>
        /// <returns>Number of reservations for the user in that service.</returns>
        public static int GetResrvationCount(int ServiceID, int UserID)
        {
            return clsReservationDataAccess.GetReservationCount(ServiceID, UserID);
        }

        /// <summary>
        /// Marks past-dated reservations as cancelled/missed according to DAL logic.
        /// </summary>
        /// <returns>True if one or more rows were updated; otherwise, false.</returns>
        public static bool CancelMissedReservations()
        {
            return clsReservationDataAccess.CancelMissedReservations();
        }

        public static int GetCount(DateTime start, DateTime endExclusive)
        {
            return clsReservationDataAccess.GetCountByRange(start, endExclusive);
        }

        public static int GetCount(DateTime start, DateTime endExclusive, enReservationStatus status)
        {
            return clsReservationDataAccess.GetCountByRangeAndStatus(start, endExclusive, (byte)status);
        }

        #endregion
    }
}