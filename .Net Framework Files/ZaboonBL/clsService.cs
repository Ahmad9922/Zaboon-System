using ZaboonDAL;
 using Dotools;
 using System;
 using System.Collections.Generic;
 using System.Data;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;
using System.Runtime.Versioning;

namespace ZaboonBL
{
    /// <summary>
    /// Business layer class that represents a service and encapsulates its domain logic
    /// (creation, update, querying, and related working hours and reservations).
    /// Persistence is handled via clsServiceDataAccess.
    /// </summary>
    public class clsService
    {
        #region Mode

        /// <summary>
        /// Object persistence mode.
        /// </summary>
        public enum enMode
        {
            /// <summary>
            /// New service (not yet saved to DB).
            /// </summary>
            AddNew = 1,

            /// <summary>
            /// Existing service (updates only).
            /// </summary>
            Update = 2
        }

        #endregion

        #region Properties
        public int? ServiceID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public decimal? Fees { get; set; }
        public List<clsServiceHour> ServiceHours { get; set; }

        /// <summary>
        /// Current object mode (AddNew/Update).
        /// </summary>
        public enMode Mode { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Private constructor for creating a new service (AddNew mode).
        /// </summary>
        /// <param name="Name">Service name.</param>
        private clsService(string Name)
        {
            this.Name = Name;

            ServiceID = null;
            Description = null;
            Fees = null;
            ServiceHours = null;

            IsActive = true;

            this.Mode = enMode.AddNew;
        }

        /// <summary>
        /// Private constructor to materialize an existing service (Update mode) from DAL data.
        /// </summary>
        /// <param name="ServiceData">DAL DTO loaded from database.</param>
        private clsService(clsServiceDataAccess.clsServiceData ServiceData)
        {
            ServiceID = ServiceData.ServiceID;
            Name = ServiceData.Name;
            Description = ServiceData.Description;
            IsActive = ServiceData.IsActive;
            Fees = ServiceData.Fees;
            ServiceHours = clsServiceHour.GetServiceHours(ServiceID.Value);

            this.Mode = enMode.Update;
        }

        #endregion

        #region Persistence (private)

        /// <summary>
        /// Adds the current service to the database and sets <see cref="ServiceID"/> on success.
        /// </summary>
        /// <returns>True if added; otherwise, false.</returns>
        private bool _Add()
        {
            clsServiceDataAccess.clsServiceData ServiceData = new clsServiceDataAccess.clsServiceData
            {
                ServiceID = ServiceID,
                Name = Name,
                Description = Description,
                IsActive = IsActive,
                Fees = Fees
            };

            this.ServiceID = clsServiceDataAccess.Add(ServiceData);

            return this.ServiceID != null;
        }

        /// <summary>
        /// Updates the current service in the database.
        /// </summary>
        /// <returns>True if updated; otherwise, false.</returns>
        private bool _Update()
        {
            clsServiceDataAccess.clsServiceData ServiceData = new clsServiceDataAccess.clsServiceData
            {
                ServiceID = ServiceID,
                Name = Name,
                Description = Description,
                IsActive = IsActive,
                Fees = Fees
            };

            return clsServiceDataAccess.Update(ServiceData);
        }

        #endregion

        #region Persistence (public)

        /// <summary>
        /// Saves the service:
        /// - If in AddNew mode, inserts and switches to Update mode on success.
        /// - If in Update mode, updates the record.
        /// </summary>
        /// <returns>True if operation succeeded; otherwise, false.</returns>
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

        #endregion

        #region Instance helpers

        /// <summary>
        /// Builds the current queue for this service (based on current service hour).
        /// </summary>
        /// <returns>A FIFO queue of reservations for the current service hour.</returns>
        public Queue<clsReservation> GetCurrentQueue()
        {
            return new Queue<clsReservation>(clsReservation.GetCurrentServiceHourReservations(ServiceID.Value));
        }

        /// <summary>
        /// Gets the current service hour for this service (based on server time/day).
        /// </summary>
        /// <returns>Current <see cref="clsServiceHour"/>; may be a defaulted object if none matches DAL logic.</returns>
        public clsServiceHour GetCurrentServiceHour()
        {
            return clsServiceHour.GetCurrentServiceHour(ServiceID.Value);
        }

        /// <summary>
        /// Deletes this service by <see cref="ServiceID"/>.
        /// </summary>
        /// <returns>True if deletion succeeded; otherwise, false.</returns>
        public bool Delete()
        {
            return clsServiceDataAccess.Delete(ServiceID.Value);
        }

        /// <summary>
        /// Indicates whether now is within any working hour of this service.
        /// </summary>
        /// <returns>True if within working hours; otherwise, false.</returns>
        /// <remarks>Relies on server time and DAL logic (DATEFIRST/DayOfWeek alignment).</remarks>
        public bool IsWorkTimeNow()
        {
            return clsServiceDataAccess.IsWorkTimeNow(ServiceID.Value);
        }

        /// <summary>
        /// Checks if the service has working hours for the given date.
        /// </summary>
        /// <param name="DateTime">Target date.</param>
        /// <returns>True if there are working hours on that date; otherwise, false.</returns>
        public bool HasServiceHoursForDay(DateTime DateTime)
        {
            return clsServiceDataAccess.HasServiceHoursForDay(ServiceID.Value, DateTime);
        }

        /// <summary>
        /// Checks if the service has working hours for the given day of week.
        /// </summary>
        /// <param name="DayOfWeek">Day of week.</param>
        /// <returns>True if there are working hours; otherwise, false.</returns>
        public bool HasServiceHoursForDay(DayOfWeek DayOfWeek)
        {
            return clsServiceDataAccess.HasServiceHoursForDay(ServiceID.Value, DayOfWeek);
        }

        /// <summary>
        /// Gets the total number of reservations for this service.
        /// </summary>
        /// <returns>Reservations count.</returns>
        public int GetReservationCount()
        {
            return clsReservation.GetResrvationCount(ServiceID.Value);
        }

        #endregion

        #region Finders / Factory (static)

        /// <summary>
        /// Finds a service by its identifier.
        /// </summary>
        /// <param name="ServiceID">Service identifier.</param>
        /// <returns>clsService if found; otherwise, null.</returns>
        public static clsService Find(int ServiceID)
        {
            clsServiceDataAccess.clsServiceData ServiceData = new clsServiceDataAccess.clsServiceData
            {
                ServiceID = ServiceID
            };

            if (clsServiceDataAccess.GetByID(ServiceData))
            {
                return new clsService(ServiceData);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Finds a service by its name.
        /// </summary>
        /// <param name="Name">Service name.</param>
        /// <returns>clsService if found; otherwise, null.</returns>
        public static clsService Find(string Name)
        {
            clsServiceDataAccess.clsServiceData ServiceData = new clsServiceDataAccess.clsServiceData
            {
                Name = Name
            };

            if (clsServiceDataAccess.GetByName(ServiceData))
            {
                return new clsService(ServiceData);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Factory: creates a new service (AddNew mode) with the given name (not persisted).
        /// </summary>
        /// <param name="Name">Service name.</param>
        /// <returns>New clsService in AddNew mode; otherwise null if name invalid.</returns>
        public static clsService Add(string Name)
        {
            if (!string.IsNullOrEmpty(Name))
            {
                return new clsService(Name);
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region Static checks / helpers

        /// <summary>
        /// Checks existence of a service by ID.
        /// </summary>
        public static bool IsExist(int ServiceID)
        {
            return clsServiceDataAccess.IsExist(ServiceID);
        }

        /// <summary>
        /// Static helper: checks if a service has working hours for a specific date.
        /// </summary>
        public static bool HasServiceHoursForDay(int ServiceID, DateTime DateTime)
        {
            return clsServiceDataAccess.HasServiceHoursForDay(ServiceID, DateTime);
        }

        /// <summary>
        /// Static helper: checks if a service has working hours for a specific day of week.
        /// </summary>
        public static bool HasServiceHoursForDay(int ServiceID, DayOfWeek DayOfWeek)
        {
            return clsServiceDataAccess.HasServiceHoursForDay(ServiceID, DayOfWeek);
        }

        /// <summary>
        /// Static helper: indicates whether now is within any working hour of the given service.
        /// </summary>
        public static bool IsWorkTimeNow(int ServiceID)
        {
            return clsServiceDataAccess.IsWorkTimeNow(ServiceID);
        }

        /// <summary>
        /// Static delete by identifier.
        /// </summary>
        public static bool Delete(int ServiceID)
        {
            return clsServiceDataAccess.Delete(ServiceID);
        }

        #endregion

        #region Listing / Filters (static)

        /// <summary>
        /// Retrieves all services as a DataTable.
        /// </summary>
        public static DataTable GetList()
        {
            return clsServiceDataAccess.GetList();
        }

        /// <summary>
        /// Retrieves filtered services as a DataTable.
        /// </summary>
        /// <param name="Value">Filter value.</param>
        /// <param name="FieldName">Field name to filter by.</param>
        public static DataTable GetList(string Value, string FieldName)
        {
            return clsServiceDataAccess.GetList(new clsDataTypes.clsFilterData(Value, FieldName));
        }

        /// <summary>
        /// Retrieves all services as domain objects.
        /// </summary>
        public static List<clsService> GetServices()
        {
            return clsServiceDataAccess.GetServices().ConvertAll(S => new clsService(S)).ToList();
        }

        /// <summary>
        /// Retrieves services by name as domain objects.
        /// </summary>
        /// <param name="Name">Service name to match.</param>
        public static List<clsService> GetServices(string Name)
        {
            return clsServiceDataAccess.GetServices(Name).Select(S => new clsService(S)).ToList();
        }

        #endregion
    }
}