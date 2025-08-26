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
    /// Data Access Layer for Reservations table.
    /// Provides CRUD operations and query helpers for reservations.
    /// Relies on clsAdoQueryExecutor for executing parameterized SQL and mapping results.
    /// </summary>
    public static class clsReservationDataAccess
    {
        #region DTO

        /// <summary>
        /// Represents a reservation record mapped to the Reservations table.
        /// </summary>
        public class clsReservationData
        {
            public int? ReservationID { get; set; }
            public int UserID { get; set; }
            public DateTime ReservationDate { get; set; }
            public byte ReservationStatus { get; set; }
            public decimal? PaidFees { get; set; }
            public int ServiceID { get; set; }
            public int ServiceHourID { get; set; }
            public DateTime CreateDate { get; set; }
        }

        #endregion

        #region CRUD

        /// <summary>
        /// Retrieves a reservation by ReservationID and fills the provided DTO if found.
        /// </summary>
        /// <param name="ReservationData">Input: ReservationID must be set. Output: remaining fields are populated if found.</param>
        /// <returns>true if a record is found; otherwise, false.</returns>
        public static bool GetByID(clsReservationData ReservationData)
        {
            string Query = "SELECT * FROM Reservations WHERE ReservationID = @ReservationID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, ReservationData);

            }, Query, new SqlParameter("@ReservationID", ReservationData.ReservationID));
        }

        /// <summary>
        /// Inserts a new reservation and returns the generated ReservationID.
        /// </summary>
        /// <param name="ReservationData">
        /// Required fields: UserID, ReservationDate, ReservationStatus, PaidFees (nullable), ServiceID, ServiceHourID.
        /// </param>
        /// <returns>The newly generated ReservationID.</returns>
        public static int Add(clsReservationData ReservationData)
        {
            string Query = @"
            INSERT INTO [dbo].[Reservations] 
                ([UserID], [ReservationDate], [ReservationStatus], [PaidFees], [ServiceID], [ServiceHourID])
            VALUES 
                (@UserID, @ReservationDate, @ReservationStatus, @PaidFees, @ServiceID, @ServiceHourID)
            SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, ReservationData);
        }

        /// <summary>
        /// Updates an existing reservation by ReservationID.
        /// </summary>
        /// <param name="ReservationData">DTO with ReservationID and fields to update.</param>
        /// <returns>true if one or more rows were affected; otherwise, false.</returns>
        public static bool Update(clsReservationData ReservationData)
        {
            string Query = @"
            UPDATE [dbo].[Reservations] SET 
                [UserID] = @UserID,
                [ReservationDate] = @ReservationDate,
                [ReservationStatus] = @ReservationStatus,
                [PaidFees] = @PaidFees,
                [ServiceID] = @ServiceID,
                [ServiceHourID] = @ServiceHourID 
            WHERE ReservationID = @ReservationID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, ReservationData) > 0;
        }

        /// <summary>
        /// Deletes a reservation by its ReservationID.
        /// </summary>
        /// <param name="ReservationID">Reservation identifier.</param>
        /// <returns>true if a row was deleted; otherwise, false.</returns>
        public static bool Delete(int ReservationID)
        {
            string Query = @"DELETE FROM [Reservations] WHERE ReservationID = @ReservationID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, new SqlParameter("@ReservationID", ReservationID)) > 0;
        }

        #endregion

        #region Lists / Queries

        /// <summary>
        /// Gets a list of reservations with details (using the view: ReservationsDetails).
        /// </summary>
        /// <returns>DataTable containing reservation details.</returns>
        public static DataTable GetList()
        {
            string Query = @"SELECT * FROM ReservationsDetails";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        /// <summary>
        /// Gets a filtered list of reservation details (using the view: ReservationsDetails).
        /// </summary>
        /// <param name="FilterData">Filter object used by the underlying executor to apply filters.</param>
        /// <returns>DataTable containing filtered reservation details.</returns>
        public static DataTable GetList(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM ReservationsDetails";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);
        }

        public static DataTable GetTopServicesByReservations(int topN, DateTime startDate, DateTime endDateExclusive)
        {
            string Query = @"
                           SELECT TOP (@TopN)
                           r.ServiceID,
                           s.Name AS ServiceName,
                           COUNT(1) AS ReservationsCount
                           FROM Reservations r
                           INNER JOIN Services s ON r.ServiceID = s.ServiceID
                           WHERE (@StartDate IS NULL OR r.ReservationDate >= @StartDate)
                           AND (@EndDate IS NULL OR r.ReservationDate < @EndDate)
                           GROUP BY r.ServiceID, s.Name
                           ORDER BY ReservationsCount DESC";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query, new SqlParameter[]
            {
                new SqlParameter("@TopN", topN),
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDateExclusive)
            });
        }

        /// <summary>
        /// Gets all reservations as a list of DTOs.
        /// </summary>
        /// <returns>List of clsReservationData.</returns>
        public static List<clsReservationData> GetReservations()
        {
            string Query = @"SELECT * FROM Reservations";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsReservationData>(Command);

            }, Query);
        }

        /// <summary>
        /// Gets reservations for a specific user.
        /// </summary>
        /// <param name="UserID">User identifier.</param>
        /// <returns>List of clsReservationData for the given user.</returns>
        public static List<clsReservationData> GetReservations(int UserID)
        {
            string Query = @"SELECT * FROM Reservations WHERE UserID = @UserID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsReservationData>(Command);

            }, Query, new SqlParameter("@UserID", UserID));
        }

        /// <summary>
        /// Gets reservations for a specific user and service.
        /// </summary>
        /// <param name="UserID">User identifier.</param>
        /// <param name="ServiceID">Service identifier.</param>
        /// <returns>List of clsReservationData matching the user and service.</returns>
        public static List<clsReservationData> GetReservations(int UserID, int ServiceID)
        {
            string Query = @"SELECT * FROM Reservations WHERE UserID = @UserID AND ServiceID = @ServiceID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsReservationData>(Command);

            }, Query, new SqlParameter[] {
            new SqlParameter("@UserID", UserID),
            new SqlParameter("@ServiceID", ServiceID)
        });
        }

        /// <summary>
        /// Gets today's reservations for the current service hour of a specific service.
        /// Current hour is computed from ServiceHours where current time falls between WorkStartTime and WorkEndTime,
        /// and the DayOfWeek matches today.
        /// </summary>
        /// <param name="ServiceID">Service identifier.</param>
        /// <returns>List of clsReservationData ordered by CreateDate.</returns>
        /// <remarks>
        /// Uses DATEPART(WEEKDAY, GETDATE()) - 1 for DayOfWeek matching.
        /// Ensure your DayOfWeek values align with SQL Server DATEFIRST settings.
        /// Filters by ReservationStatus = 1 and ReservationDate = today.
        /// </remarks>
        public static List<clsReservationData> GetCurrentServiceHourReservations(int ServiceID)
        {
            string Query = @"
            SELECT * FROM Reservations
            WHERE ServiceHourID = (
                SELECT TOP 1 ServiceHourID 
                FROM ServiceHours
                WHERE CAST(GETDATE() AS TIME) BETWEEN WorkStartTime AND WorkEndTime
                  AND DayOfWeek = DATEPART(WEEKDAY, GETDATE()) - 1 
                  AND ServiceID = @ServiceID
            )
            AND ReservationDate = CAST(GETDATE() AS DATE) 
            AND ReservationStatus = 1 
            ORDER BY CreateDate";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsReservationData>(Command);

            }, Query, new SqlParameter("@ServiceID", ServiceID));
        }

        #endregion

        #region Checks / Counters / Maintenance

        /// <summary>
        /// Checks if a reservation exists by ReservationID.
        /// </summary>
        /// <param name="ReservationID">Reservation identifier.</param>
        /// <returns>true if exists; otherwise, false.</returns>
        public static bool IsExist(int ReservationID)
        {
            string Query = @"SELECT R = 1 FROM Reservations WHERE ReservationID = @ReservationID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@ReservationID", ReservationID)) != null;
        }

        /// <summary>
        /// Gets the total count of reservations for a given service.
        /// </summary>
        /// <param name="ServiceID">Service identifier.</param>
        /// <returns>Number of reservations.</returns>
        public static int GetReservationCount(int ServiceID)
        {
            string Query = @"
            SELECT COUNT(UserID) 
            FROM Reservations
            WHERE ServiceID = @ServiceID";

            return Convert.ToInt32(clsAdoQueryExecutor.ExecuteQuery(Command =>
                clsAdoQueryExecutor.ExecuteScalar(Command), Query, new SqlParameter("@ServiceID", ServiceID)));
        }

        /// <summary>
        /// Gets the total count of reservations for a given service made by a specific user.
        /// </summary>
        /// <param name="ServiceID">Service identifier.</param>
        /// <param name="UserID">User identifier.</param>
        /// <returns>Number of reservations matching the criteria.</returns>
        public static int GetReservationCount(int ServiceID, int UserID)
        {
            string Query = @"
            SELECT COUNT(UserID) 
            FROM Reservations
            WHERE ServiceID = @ServiceID AND UserID = @UserID";

            return Convert.ToInt32(clsAdoQueryExecutor.ExecuteQuery(Command =>
                clsAdoQueryExecutor.ExecuteScalar(Command), Query, new SqlParameter[] {
                new SqlParameter("@ServiceID", ServiceID),
                new SqlParameter("@UserID", UserID)
                }));
        }

        /// <summary>
        /// Marks past-dated reservations as missed/canceled by updating their status.
        /// </summary>
        /// <returns>true if one or more rows were updated; otherwise, false.</returns>
        /// <remarks>
        /// Updates all reservations with ReservationDate &lt; today and ReservationStatus != 3 to ReservationStatus = 2.
        /// </remarks>
        public static bool CancelMissedReservations()
        {
            string Query = @"
            UPDATE Reservations
            SET ReservationStatus = 2
            WHERE ReservationDate < CAST(GETDATE() AS DATE) 
              AND ReservationStatus != 3";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
                clsAdoQueryExecutor.ExecuteNonQuery(Command), Query) > 0;
        }

        public static int GetCountByRange(DateTime startDate, DateTime endDateExclusive)
        {
            string Query = @"
                           SELECT COUNT(1)
                           FROM Reservations
                           WHERE ReservationDate >= @StartDate AND ReservationDate < @EndDate";

            return Convert.ToInt32(clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter[]
            {
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDateExclusive)
            }));
        }

        public static int GetCountByRangeAndStatus(DateTime startDate, DateTime endDateExclusive, byte reservationStatus)
        {
            string Query = @"
                           SELECT COUNT(1)
                           FROM Reservations
                           WHERE ReservationDate >= @StartDate AND ReservationDate < @EndDate
                           AND ReservationStatus = @Status";

            return Convert.ToInt32(clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter[]
            {
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDateExclusive),
                new SqlParameter("@Status", reservationStatus)
            }));
        }

        #endregion
    }
}