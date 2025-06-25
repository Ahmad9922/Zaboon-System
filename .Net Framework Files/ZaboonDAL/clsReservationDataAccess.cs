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
    public static class clsReservationDataAccess
    {
        public class clsReservationData
        {
            public int? ReservationID { get; set; }
            public int UserID { get; set; }
            public DateTime ReservationDate { get; set; }
            public byte ReservationStatus { get; set; }
            public decimal? PaidFees { get; set; }
            public int ServiceID { get; set; }

        }


        public static bool GetByID(clsReservationData ReservationData)
        {
            string Query = "SELECT * FROM Reservations WHERE ReservationID = @ReservationID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, ReservationData);

            }, Query, new SqlParameter("@ReservationID", ReservationData.ReservationID));
        }

        public static int Add(clsReservationData ReservationData)
        {
            string Query = @"INSERT INTO [dbo].[Reservations] ( 
[UserID], [ReservationDate], [ReservationStatus], [PaidFees], [ServiceID])
 VALUES ( @UserID, @ReservationDate, @ReservationStatus, @PaidFees, @ServiceID)
 SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, ReservationData);
        }

        public static bool Update(clsReservationData ReservationData)
        {
            string Query = @"UPDATE [dbo].[Reservations] SET 
[UserID] = @UserID,
[ReservationDate] = @ReservationDate,
[ReservationStatus] = @ReservationStatus,
[PaidFees] = @PaidFees,
[ServiceID] = @ServiceID WHERE ReservationID = @ReservationID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, ReservationData) > 0;
        }

        public static bool Delete(int ReservationID)
        {
            string Query = @"DELETE FROM [Reservations] WHERE ReservationID = @ReservationID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, new SqlParameter("@ReservationID", ReservationID)) > 0;
        }

        public static DataTable GetList()
        {
            string Query = @"SELECT * FROM Reservations";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        public static DataTable GetList(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM Reservations";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);
        }

        public static bool IsExist(int ReservationID)
        {
            string Query = @"SELECT R = 1 FROM Reservations WHERE ReservationID = @ReservationID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@ReservationID", ReservationID)) != null;
        }

    }
}