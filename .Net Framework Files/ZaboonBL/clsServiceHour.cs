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
    /// Business layer class representing a service working-hour slot.
    /// Encapsulates creation, update, deletion, lookups, and helpers around service hours.
    /// Persists via clsServiceHourDataAccess.
    /// </summary>
    public class clsServiceHour
    {
        #region Events

        /// <summary>
        /// Raised after a successful deletion of the current service hour.
        /// </summary>
        public event Action AfterDeleted;

        #endregion

        #region Mode

        /// <summary>
        /// Object persistence mode.
        /// </summary>
        public enum enMode
        {
            /// <summary>
            /// New record (not saved yet).
            /// </summary>
            AddNew = 1,

            /// <summary>
            /// Existing record (updates only).
            /// </summary>
            Update = 2
        }

        #endregion

        #region Properties

        public int? ServiceHourID { get; set; }
        public string Title { get; set; }
        public TimeSpan WorkStartTime { get; set; }
        public TimeSpan WorkEndTime { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int ServiceID { get; set; }

        /// <summary>
        /// Current object mode (AddNew/Update).
        /// </summary>
        public enMode Mode { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new service hour in AddNew mode with default values for the given service.
        /// </summary>
        private clsServiceHour(int ServiceID)
        {
            this.ServiceHourID = null;
            this.Title = null;
            this.WorkStartTime = new TimeSpan(0, 0, 0);
            this.WorkEndTime = new TimeSpan(0, 0, 0);
            this.DayOfWeek = DayOfWeek.Sunday;
            this.ServiceID = ServiceID;

            this.Mode = enMode.AddNew;
        }

        /// <summary>
        /// Initializes a new service hour in AddNew mode with provided time range and day.
        /// </summary>
        private clsServiceHour(TimeSpan WorkStartTime, TimeSpan WorkEndTime, DayOfWeek DayOfWeek, int ServiceID)
        {
            this.ServiceHourID = null;
            this.Title = null;
            this.WorkStartTime = WorkStartTime;
            this.WorkEndTime = WorkEndTime;
            this.DayOfWeek = DayOfWeek;
            this.ServiceID = ServiceID;

            this.Mode = enMode.AddNew;
        }

        /// <summary>
        /// Materializes an existing service hour (Update mode) from DAL data.
        /// </summary>
        private clsServiceHour(clsServiceHourDataAccess.clsServiceHourData ServiceHourData)
        {
            this.ServiceHourID = ServiceHourData.ServiceHourID;
            this.Title = ServiceHourData.Title;
            this.WorkStartTime = ServiceHourData.WorkStartTime;
            this.WorkEndTime = ServiceHourData.WorkEndTime;
            this.DayOfWeek = (DayOfWeek)ServiceHourData.DayOfWeek;
            this.ServiceID = ServiceHourData.ServiceID;

            this.Mode = enMode.Update;
        }

        #endregion

        #region Persistence (private)

        /// <summary>
        /// Adds the current service hour to the database and sets <see cref="ServiceHourID"/> on success.
        /// </summary>
        /// <returns>True if added; otherwise, false.</returns>
        private bool _Add()
        {
            clsServiceHourDataAccess.clsServiceHourData ServiceHourData = new clsServiceHourDataAccess.clsServiceHourData
            {
                ServiceHourID = ServiceHourID,
                Title = Title,
                WorkStartTime = WorkStartTime,
                WorkEndTime = WorkEndTime,
                DayOfWeek = Convert.ToByte(DayOfWeek),
                ServiceID = ServiceID
            };

            this.ServiceHourID = clsServiceHourDataAccess.Add(ServiceHourData);

            return this.ServiceHourID != null;
        }

        /// <summary>
        /// Updates the current service hour in the database.
        /// </summary>
        /// <returns>True if updated; otherwise, false.</returns>
        private bool _Update()
        {
            clsServiceHourDataAccess.clsServiceHourData ServiceHourData = new clsServiceHourDataAccess.clsServiceHourData
            {
                ServiceHourID = ServiceHourID,
                Title = Title,
                WorkStartTime = WorkStartTime,
                WorkEndTime = WorkEndTime,
                DayOfWeek = Convert.ToByte(DayOfWeek),
                ServiceID = ServiceID
            };

            return clsServiceHourDataAccess.Update(ServiceHourData);
        }

        #endregion

        #region Persistence (public)

        /// <summary>
        /// Saves the service hour:
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

        /// <summary>
        /// Deletes the current service hour (if it has an ID). Fires <see cref="AfterDeleted"/> on success.
        /// </summary>
        /// <returns>True if deleted; otherwise, false.</returns>
        public bool Delete()
        {
            bool IsSuccessful = false;

            if (this.ServiceHourID != null)
            {
                IsSuccessful = clsServiceHourDataAccess.Delete(this.ServiceHourID.Value);

                if (IsSuccessful)
                {
                    AfterDeleted?.Invoke();
                }
            }

            return IsSuccessful;
        }

        #endregion

        #region Instance helpers

        /// <summary>
        /// Checks if the current server time falls within this work-hour window for today.
        /// </summary>
        /// <returns>True if the current time is within the window; otherwise, false.</returns>
        /// <remarks>Requires <see cref="ServiceHourID"/> to have a value.</remarks>
        public bool IsCurrentTimeInThisWorkHour()
        {
            return clsServiceHourDataAccess.IsCurrentTimeInThisWorkHour(ServiceHourID.Value);
        }

        /// <summary>
        /// Checks whether there is an overlapping work-hour within the same service and day as this instance.
        /// </summary>
        /// <returns>True if an overlap exists; otherwise, false.</returns>
        public bool Exists()
        {
            return clsServiceHourDataAccess.IsExist(WorkStartTime, WorkEndTime, Convert.ToByte(DayOfWeek), ServiceID);
        }

        #endregion

        #region Find / Add / Checks (static)

        /// <summary>
        /// Finds a service hour by identifier.
        /// </summary>
        /// <param name="ServiceHourID">Service hour identifier.</param>
        /// <returns>clsServiceHour if found; otherwise, null.</returns>
        public static clsServiceHour Find(int ServiceHourID)
        {
            clsServiceHourDataAccess.clsServiceHourData ServiceHourData = new clsServiceHourDataAccess.clsServiceHourData
            {
                ServiceHourID = ServiceHourID
            };

            if (clsServiceHourDataAccess.GetByID(ServiceHourData))
            {
                return new clsServiceHour(ServiceHourData);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Creates a new service hour object in AddNew mode (without persisting).
        /// Validates start/end time to be within 00:00:00 and 23:59:59.
        /// </summary>
        /// <param name="WorkStartTime">Start time.</param>
        /// <param name="WorkEndTime">End time.</param>
        /// <param name="DayOfWeek">Day of week.</param>
        /// <param name="ServiceID">Related service ID.</param>
        /// <returns>New clsServiceHour in AddNew mode; otherwise null if validation fails.</returns>
        public static clsServiceHour Add(TimeSpan WorkStartTime, TimeSpan WorkEndTime, DayOfWeek DayOfWeek, int ServiceID)
        {
            bool ValidateWorkStartTime = WorkStartTime >= TimeSpan.Zero && WorkStartTime <= new TimeSpan(23, 59, 59);
            bool ValidateWorkEndTime = WorkEndTime >= TimeSpan.Zero && WorkEndTime <= new TimeSpan(23, 59, 59);

            if (ValidateWorkStartTime && ValidateWorkEndTime)
            {
                return new clsServiceHour(WorkStartTime, WorkEndTime, DayOfWeek, ServiceID);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Checks existence by ServiceHourID.
        /// </summary>
        public static bool IsExist(int ServiceHourID)
        {
            return clsServiceHourDataAccess.IsExist(ServiceHourID);
        }

        /// <summary>
        /// Checks if any work-hour overlaps with the given time range (no service/day filter).
        /// </summary>
        public static bool IsExist(TimeSpan WorkStartTime, TimeSpan WorkEndTime)
        {
            return clsServiceHourDataAccess.IsExist(WorkStartTime, WorkEndTime);
        }

        /// <summary>
        /// Checks if any work-hour overlaps within a specific service and specific day.
        /// </summary>
        public static bool IsExist(TimeSpan WorkStartTime, TimeSpan WorkEndTime, DayOfWeek DayOfWeek, int ServiceID)
        {
            return clsServiceHourDataAccess.IsExist(WorkStartTime, WorkEndTime, Convert.ToByte(DayOfWeek), ServiceID);
        }

        /// <summary>
        /// Gets the current service hour for a given service (based on server time/day).
        /// </summary>
        public static clsServiceHour GetCurrentServiceHour(int ServiceID)
        {
            return new clsServiceHour(clsServiceHourDataAccess.GetCurrentServiceHour(ServiceID));
        }

        /// <summary>
        /// Static helper: checks if now is within a given service hour window by ID.
        /// </summary>
        public static bool IsCurrentTimeInThisWorkHour(int ServiceHourID)
        {
            return clsServiceHourDataAccess.IsCurrentTimeInThisWorkHour(ServiceHourID);
        }

        /// <summary>
        /// Static delete by identifier.
        /// </summary>
        public static bool Delete(int ServiceHourID)
        {
            return clsServiceHourDataAccess.Delete(ServiceHourID);
        }

        #endregion

        #region Listing / Filters (static)

        /// <summary>
        /// Retrieves all service hours as DataTable.
        /// </summary>
        public static DataTable GetList()
        {
            return clsServiceHourDataAccess.GetList();
        }

        /// <summary>
        /// Retrieves filtered service hours as DataTable.
        /// </summary>
        public static DataTable GetList(string Value, string FieldName)
        {
            return clsServiceHourDataAccess.GetList(new clsDataTypes.clsFilterData(Value, FieldName));
        }

        /// <summary>
        /// Gets all service hours as domain objects.
        /// </summary>
        public static List<clsServiceHour> GetServiceHours()
        {
            return clsServiceHourDataAccess.GetServiceHours().Select(S => new clsServiceHour(S)).ToList();
        }

        /// <summary>
        /// Gets service hours for a given service.
        /// </summary>
        public static List<clsServiceHour> GetServiceHours(int ServiceID)
        {
            return clsServiceHourDataAccess.GetServiceHours(ServiceID).Select(S => new clsServiceHour(S)).ToList();
        }

        /// <summary>
        /// Gets service hours by service name.
        /// </summary>
        public static List<clsServiceHour> GetServiceHours(string ServiceName)
        {
            return clsServiceHourDataAccess.GetServiceHours(ServiceName)?.Select(S => new clsServiceHour(S)).ToList();
        }

        /// <summary>
        /// Gets service hours for a given service filtered by day of week.
        /// </summary>
        public static List<clsServiceHour> GetServiceHours(int ServiceID, DayOfWeek DayOfWeek)
        {
            return clsServiceHourDataAccess.GetServiceHours(ServiceID).Select(S => new clsServiceHour(S)).Where(S => S.DayOfWeek == DayOfWeek).ToList();
        }

        /// <summary>
        /// Gets service hours by service name filtered by day of week.
        /// </summary>
        public static List<clsServiceHour> GetServiceHours(string ServiceName, DayOfWeek DayOfWeek)
        {
            return clsServiceHourDataAccess.GetServiceHours(ServiceName)?.Select(S => new clsServiceHour(S)).Where(S => S.DayOfWeek == DayOfWeek).ToList();
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Returns a friendly string representation: "Title Start - End (DayOfWeek)".
        /// </summary>
        public override string ToString()
        {
            return $"{Title} {WorkStartTime} - {WorkEndTime} ({DayOfWeek})";
        }

        /// <summary>
        /// Equality by ServiceHourID.
        /// </summary>
        /// <remarks>
        /// Assumes <paramref name="obj"/> is clsServiceHour and both IDs are non-null.
        /// </remarks>
        public override bool Equals(object obj)
        {
            return ServiceHourID.Equals((obj as clsServiceHour).ServiceHourID);
        }

        #endregion
    }
}