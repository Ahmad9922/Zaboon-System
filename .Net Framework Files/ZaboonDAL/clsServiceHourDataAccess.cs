using Dotools;
 using System;
 using System.Collections.Generic;
 using System.Data;
 using System.Data.SqlClient;
 using System.Linq;
 using System.Text;
using System.Threading.Tasks;

namespace ZaboonDAL
{
    /// <summary>
    /// Data Access Layer for the ServiceHours table.
    /// Provides CRUD operations and query helpers for service hours.
    /// Relies on clsAdoQueryExecutor for executing parameterized SQL and mapping results.
    /// </summary>
    public static class clsServiceHourDataAccess
    {
        #region DTO

        /// <summary>
        /// Represents a service hour record mapped to the ServiceHours table.
        /// </summary>
        public class clsServiceHourData
        {
            public int? ServiceHourID { get; set; }
            public string Title { get; set; }
            public TimeSpan WorkStartTime { get; set; }
            public TimeSpan WorkEndTime { get; set; }
            public byte DayOfWeek { get; set; }
            public int ServiceID { get; set; }
        }

        #endregion

        #region CRUD

        /// <summary>
        /// Retrieves a service hour by ServiceHourID and fills the provided DTO if found.
        /// </summary>
        /// <param name="ServiceHourData">Input: ServiceHourID must be set. Output: remaining fields are populated if found.</param>
        /// <returns>true if a record is found; otherwise, false.</returns>
        public static bool GetByID(clsServiceHourData ServiceHourData)
        {
            string Query = "SELECT * FROM ServiceHours WHERE ServiceHourID = @ServiceHourID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, ServiceHourData);

            }, Query, new SqlParameter("@ServiceHourID", ServiceHourData.ServiceHourID));
        }

        /// <summary>
        /// Gets the current service hour for a specific service based on current server time and day.
        /// </summary>
        /// <param name="ServiceID">Service identifier.</param>
        /// <returns>clsServiceHourData representing the current slot; fields remain default if none matched.</returns>
        /// <remarks>
        /// Uses CAST(GETDATE() AS TIME) and DATEPART(WEEKDAY, GETDATE()) - 1 for day matching.
        /// Ensure your DayOfWeek storage aligns with SQL Server DATEFIRST settings.
        /// </remarks>
        public static clsServiceHourData GetCurrentServiceHour(int ServiceID)
        {
            clsServiceHourData ServiceHourData = new clsServiceHourData();

            string Query = @"SELECT * FROM ServiceHours
                         WHERE CAST(GETDATE() AS TIME) Between WorkStartTime AND WorkEndTime
                         AND DayOfWeek = DATEPART(WEEKDAY, GETDATE()) - 1 AND ServiceID = @ServiceID";

            clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, ServiceHourData);

            }, Query, new SqlParameter("@ServiceID", ServiceID));

            return ServiceHourData;
        }

        /// <summary>
        /// Inserts a new service hour and returns the generated ServiceHourID.
        /// </summary>
        /// <param name="ServiceHourData">DTO with Title, WorkStartTime, WorkEndTime, DayOfWeek, and ServiceID.</param>
        /// <returns>The newly generated ServiceHourID.</returns>
        public static int Add(clsServiceHourData ServiceHourData)
        {
            string Query = @"INSERT INTO [dbo].[ServiceHours] ( 
[Title], [WorkStartTime], [WorkEndTime], [DayOfWeek], [ServiceID])
 VALUES (@Title, @WorkStartTime, @WorkEndTime, @DayOfWeek, @ServiceID)
 SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, ServiceHourData);
        }

        /// <summary>
        /// Updates an existing service hour by ServiceHourID.
        /// </summary>
        /// <param name="ServiceHourData">DTO with ServiceHourID and fields to update.</param>
        /// <returns>true if one or more rows were affected; otherwise, false.</returns>
        public static bool Update(clsServiceHourData ServiceHourData)
        {
            string Query = @"UPDATE [dbo].[ServiceHours] SET 
[Title] = @Title,
[WorkStartTime] = @WorkStartTime,
[WorkEndTime] = @WorkEndTime,
[DayOfWeek] = @DayOfWeek,
[ServiceID] = @ServiceID WHERE ServiceHourID = @ServiceHourID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, ServiceHourData) > 0;
        }

        /// <summary>
        /// Deletes a service hour by its ServiceHourID.
        /// </summary>
        /// <param name="ServiceHourID">Service hour identifier.</param>
        /// <returns>true if a row was deleted; otherwise, false.</returns>
        public static bool Delete(int ServiceHourID)
        {
            string Query = @"DELETE FROM [ServiceHours] WHERE ServiceHourID = @ServiceHourID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, new SqlParameter("@ServiceHourID", ServiceHourID)) > 0;
        }

        #endregion

        #region Lists / Queries

        /// <summary>
        /// Gets all service hours as a DataTable.
        /// </summary>
        /// <returns>DataTable containing all service hours.</returns>
        public static DataTable GetList()
        {
            string Query = @"SELECT * FROM ServiceHours";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        /// <summary>
        /// Gets a filtered list of service hours as a DataTable.
        /// </summary>
        /// <param name="FilterData">Filter object used by the underlying executor to apply filters.</param>
        /// <returns>DataTable containing filtered service hours.</returns>
        public static DataTable GetList(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM ServiceHours";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);
        }

        /// <summary>
        /// Gets all service hours ordered by DayOfWeek.
        /// </summary>
        /// <returns>List of clsServiceHourData ordered by DayOfWeek.</returns>
        public static List<clsServiceHourData> GetServiceHours()
        {
            string Query = @"SELECT * FROM ServiceHours ORDER BY DayOfWeek";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsServiceHourData>(Command);

            }, Query);
        }

        /// <summary>
        /// Gets all service hours for a specific service ordered by DayOfWeek.
        /// </summary>
        /// <param name="ServiceID">Service identifier.</param>
        /// <returns>List of clsServiceHourData filtered by ServiceID.</returns>
        public static List<clsServiceHourData> GetServiceHours(int ServiceID)
        {
            string Query = @"SELECT * FROM ServiceHours WHERE ServiceID = @ServiceID ORDER BY DayOfWeek";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsServiceHourData>(Command);

            }, Query, new SqlParameter("@ServiceID", ServiceID));
        }

        /// <summary>
        /// Gets all service hours by service name (joins Services) ordered by DayOfWeek.
        /// </summary>
        /// <param name="Name">Service name.</param>
        /// <returns>List of clsServiceHourData for the specified service name.</returns>
        public static List<clsServiceHourData> GetServiceHours(string Name)
        {
            string Query = @"SELECT ServiceHours.*
                         FROM ServiceHours INNER JOIN
                         Services ON ServiceHours.ServiceID = Services.ServiceID
                         WHERE Services.Name = @Name ORDER BY DayOfWeek";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsServiceHourData>(Command);

            }, Query, new SqlParameter("@Name", Name));
        }

        #endregion

        #region Existence / Checks

        /// <summary>
        /// Checks if a service hour exists by ServiceHourID.
        /// </summary>
        /// <param name="ServiceHourID">Service hour identifier.</param>
        /// <returns>true if exists; otherwise, false.</returns>
        public static bool IsExist(int ServiceHourID)
        {
            string Query = @"SELECT R = 1 FROM ServiceHours WHERE ServiceHourID = @ServiceHourID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@ServiceHourID", ServiceHourID)) != null;
        }

        /// <summary>
        /// Checks if there is any existing service hour that overlaps with the given time range
        /// across all records.
        /// </summary>
        /// <param name="WorkStartTime">Start time of the new/edited time slot.</param>
        /// <param name="WorkEndTime">End time of the new/edited time slot.</param>
        /// <returns>true if an overlapping slot exists; otherwise, false.</returns>
        public static bool IsExist(TimeSpan WorkStartTime, TimeSpan WorkEndTime)
        {
            string Query = @"
                           SELECT TOP 1 1
                           FROM ServiceHours
                           WHERE @WorkStartTime < WorkEndTime
                             AND @WorkEndTime > WorkStartTime";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter[]
            {
                 new SqlParameter("@WorkStartTime", WorkStartTime),
                 new SqlParameter("@WorkEndTime", WorkEndTime)

            }) != null;
        }

        /// <summary>
        /// Checks if there is any existing service hour that overlaps with the given time range
        /// within a specific service and a specific day of week.
        /// </summary>
        /// <param name="WorkStartTime">Start time of the new/edited time slot.</param>
        /// <param name="WorkEndTime">End time of the new/edited time slot.</param>
        /// <param name="ServiceID">Target service identifier.</param>
        /// <param name="DayOfWeek">
        /// Day of week as stored in the DB (e.g., 0-6). 
        /// Ensure consistency with your storage and SQL Server DATEFIRST.
        /// </param>
        /// <returns>true if an overlapping slot exists; otherwise, false.</returns>
        public static bool IsExist(TimeSpan WorkStartTime, TimeSpan WorkEndTime, byte DayOfWeek, int ServiceID)
        {
            string Query = @"
                           SELECT TOP 1 1
                           FROM ServiceHours
                           WHERE ServiceID = @ServiceID
                             AND DayOfWeek = @DayOfWeek
                             AND @WorkStartTime < WorkEndTime
                             AND @WorkEndTime > WorkStartTime";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter[]
            {
                  new SqlParameter("@ServiceID", ServiceID),
                  new SqlParameter("@DayOfWeek", DayOfWeek),
                  new SqlParameter("@WorkStartTime", WorkStartTime),
                  new SqlParameter("@WorkEndTime", WorkEndTime)

            }) != null;
        }

        /// <summary>
        /// Checks if the current server time falls within the specified service hour window (and matches today's day of week).
        /// </summary>
        /// <param name="ServiceHourID">Service hour identifier.</param>
        /// <returns>true if the current time is within the time window; otherwise, false.</returns>
        /// <remarks>
        /// Uses DATEPART(WEEKDAY, GETDATE()) - 1 for day matching; ensure alignment with your stored DayOfWeek convention and DATEFIRST.
        /// </remarks>
        public static bool IsCurrentTimeInThisWorkHour(int ServiceHourID)
        {
            string Query = @"SELECT ServiceHourID FROM ServiceHours
                         WHERE ServiceHourID = @ServiceHourID AND CAST(GETDATE() AS TIME) Between WorkStartTime AND WorkEndTime
                         AND DayOfWeek = DATEPART(WEEKDAY, GETDATE()) - 1";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@ServiceHourID", ServiceHourID)) != null;
        }

        #endregion
    }
}