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
    /// Data Access Layer for the Services table.
    /// Provides CRUD operations and query helpers for services.
    /// Relies on clsAdoQueryExecutor for executing parameterized SQL and mapping results.
    /// </summary>
    public static class clsServiceDataAccess
    {
        #region DTO

        /// <summary>
        /// Represents a Service entity matching the database Services table.
        /// </summary>
        public class clsServiceData
        {
            public int? ServiceID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public bool IsActive { get; set; }
            public decimal? Fees { get; set; }
        }

        #endregion

        #region CRUD

        /// <summary>
        /// Retrieves a Service record by its ServiceID and fills the provided DTO if found.
        /// </summary>
        /// <param name="ServiceData">The service DTO with ServiceID set (input); fields are populated if found (output).</param>
        /// <returns>True if record exists; otherwise, false.</returns>
        public static bool GetByID(clsServiceData ServiceData)
        {
            string Query = "SELECT * FROM Services WHERE ServiceID = @ServiceID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, ServiceData);

            }, Query, new SqlParameter("@ServiceID", ServiceData.ServiceID));
        }

        /// <summary>
        /// Retrieves a Service record by its Name and fills the provided DTO if found.
        /// </summary>
        /// <param name="ServiceData">The service DTO with Name set (input); fields are populated if found (output).</param>
        /// <returns>True if record exists; otherwise, false.</returns>
        public static bool GetByName(clsServiceData ServiceData)
        {
            string Query = "SELECT * FROM Services WHERE Name = @Name;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, ServiceData);

            }, Query, new SqlParameter("@Name", ServiceData.Name));
        }

        /// <summary>
        /// Inserts a new Service into the database and returns the generated ServiceID.
        /// </summary>
        /// <param name="ServiceData">The service data to insert.</param>
        /// <returns>The newly created ServiceID.</returns>
        public static int Add(clsServiceData ServiceData)
        {
            string Query = @"INSERT INTO [dbo].[Services] 
                    ([Name], [Description], [IsActive], [Fees])
                    VALUES (@Name, @Description, @IsActive, @Fees)
                    SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, ServiceData);
        }

        /// <summary>
        /// Updates an existing Service record.
        /// </summary>
        /// <param name="ServiceData">The service data containing updated fields (must include ServiceID).</param>
        /// <returns>True if update succeeded (affected rows &gt; 0); otherwise, false.</returns>
        public static bool Update(clsServiceData ServiceData)
        {
            string Query = @"UPDATE [dbo].[Services] SET 
                    [Name] = @Name,
                    [Description] = @Description,
                    [IsActive] = @IsActive,
                    [Fees] = @Fees 
                    WHERE ServiceID = @ServiceID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, ServiceData) > 0;
        }

        /// <summary>
        /// Deletes a Service record by ID.
        /// </summary>
        /// <param name="ServiceID">The ID of the service to delete.</param>
        /// <returns>True if deletion succeeded (affected rows &gt; 0); otherwise, false.</returns>
        public static bool Delete(int ServiceID)
        {
            string Query = @"DELETE FROM [Services] WHERE ServiceID = @ServiceID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, new SqlParameter("@ServiceID", ServiceID)) > 0;
        }

        #endregion

        #region Lists / Filters

        /// <summary>
        /// Retrieves all services as a DataTable.
        /// </summary>
        /// <returns>DataTable containing all service records.</returns>
        public static DataTable GetList()
        {
            string Query = @"SELECT * FROM Services";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        /// <summary>
        /// Retrieves a filtered list of services as a DataTable.
        /// </summary>
        /// <param name="FilterData">The filter conditions applied by the underlying executor.</param>
        /// <returns>DataTable containing filtered service records.</returns>
        public static DataTable GetList(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM Services";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);
        }

        /// <summary>
        /// Retrieves all services as a strongly-typed list.
        /// </summary>
        /// <returns>List of clsServiceData representing service records.</returns>
        public static List<clsServiceData> GetServices()
        {
            string Query = @"SELECT * FROM Services";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsServiceData>(Command);

            }, Query);
        }

        /// <summary>
        /// Retrieves services by name as a strongly-typed list.
        /// </summary>
        /// <param name="Name">The service name to filter by.</param>
        /// <returns>List of clsServiceData filtered by Name.</returns>
        public static List<clsServiceData> GetServices(string Name)
        {
            string Query = @"SELECT * FROM Services WHERE Name = @Name";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsServiceData>(Command);

            }, Query, new SqlParameter("@Name", Name));
        }

        #endregion

        #region Checks / Helpers

        /// <summary>
        /// Checks if a service exists by ID.
        /// </summary>
        /// <param name="ServiceID">The service ID.</param>
        /// <returns>True if service exists; otherwise, false.</returns>
        public static bool IsExist(int ServiceID)
        {
            string Query = @"SELECT R = 1 FROM Services WHERE ServiceID = @ServiceID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@ServiceID", ServiceID)) != null;
        }

        /// <summary>
        /// Checks if the current server time falls within any working hour (ServiceHours) for the given service.
        /// </summary>
        /// <param name="ServiceID">The service ID.</param>
        /// <returns>True if within working hours; otherwise, false.</returns>
        /// <remarks>
        /// Uses CAST(GETDATE() AS TIME) and DATEPART(WEEKDAY, GETDATE()) - 1 to match day-of-week.
        /// Ensure your stored DayOfWeek convention aligns with SQL Server DATEFIRST.
        /// </remarks>
        public static bool IsWorkTimeNow(int ServiceID)
        {
            string Query = @"SELECT ServiceHourID FROM ServiceHours
                     WHERE CAST(GETDATE() AS TIME) BETWEEN WorkStartTime AND WorkEndTime
                     AND DayOfWeek = DATEPART(WEEKDAY, GETDATE()) - 1 
                     AND ServiceID = @ServiceID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@ServiceID", ServiceID)) != null;
        }

        /// <summary>
        /// Checks if the service has working hours for a given date.
        /// </summary>
        /// <param name="ServiceID">The service ID.</param>
        /// <param name="DateTime">The specific date to test against.</param>
        /// <returns>True if service has working hours on that date; otherwise, false.</returns>
        /// <remarks>
        /// Uses DATEPART(WEEKDAY, @DateTime) - 1 to compute DayOfWeek.
        /// </remarks>
        public static bool HasServiceHoursForDay(int ServiceID, DateTime DateTime)
        {
            string Query = @"SELECT ServiceHourID FROM ServiceHours
                     WHERE DayOfWeek = DATEPART(WEEKDAY, @DateTime) - 1 
                     AND ServiceID = @ServiceID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
                clsAdoQueryExecutor.ExecuteScalar(Command),
                Query, new SqlParameter[]
                {
                new SqlParameter("@ServiceID", ServiceID),
                new SqlParameter("@DateTime", DateTime)
                }) != null;
        }

        /// <summary>
        /// Checks if the service has working hours for a given day of week.
        /// </summary>
        /// <param name="ServiceID">The service ID.</param>
        /// <param name="DayOfWeek">The day of week (must align with how it is stored in DB).</param>
        /// <returns>True if service has working hours on that day; otherwise, false.</returns>
        public static bool HasServiceHoursForDay(int ServiceID, DayOfWeek DayOfWeek)
        {
            string Query = @"SELECT ServiceHourID FROM ServiceHours
                     WHERE DayOfWeek = @DayOfWeek 
                     AND ServiceID = @ServiceID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
                clsAdoQueryExecutor.ExecuteScalar(Command),
                Query, new SqlParameter[]
                {
                new SqlParameter("@ServiceID", ServiceID),
                new SqlParameter("@DayOfWeek", DayOfWeek)
                }) != null;
        }

        #endregion
    }
}