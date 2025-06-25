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
    public static class clsFeedbackDataAccess
    {
        public class clsFeedbackData
        {
            public int? FeedbackID { get; set; }
            public int ReservationID { get; set; }
            public byte? Rating { get; set; }
            public string Comment { get; set; }
            public DateTime FeedbackDate { get; set; }

        }


        public static bool GetByID(clsFeedbackData FeedbackData)
        {
            string Query = "SELECT * FROM Feedbacks WHERE FeedbackID = @FeedbackID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FeedbackData);

            }, Query, new SqlParameter("@FeedbackID", FeedbackData.FeedbackID));
        }

        public static int Add(clsFeedbackData FeedbackData)
        {
            string Query = @"INSERT INTO [dbo].[Feedbacks] ( 
[ReservationID], [Rating], [Comment], [FeedbackDate])
 VALUES ( @ReservationID, @Rating, @Comment, @FeedbackDate)
 SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, FeedbackData);
        }

        public static bool Update(clsFeedbackData FeedbackData)
        {
            string Query = @"UPDATE [dbo].[Feedbacks] SET 
[ReservationID] = @ReservationID,
[Rating] = @Rating,
[Comment] = @Comment,
[FeedbackDate] = @FeedbackDate WHERE FeedbackID = @FeedbackID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, FeedbackData) > 0;
        }

        public static bool Delete(int FeedbackID)
        {
            string Query = @"DELETE FROM [Feedbacks] WHERE FeedbackID = @FeedbackID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, new SqlParameter("@FeedbackID", FeedbackID)) > 0;
        }

        public static DataTable GetList()
        {
            string Query = @"SELECT * FROM Feedbacks";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        public static DataTable GetList(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM Feedbacks";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);
        }

        public static bool IsExist(int FeedbackID)
        {
            string Query = @"SELECT R = 1 FROM Feedbacks WHERE FeedbackID = @FeedbackID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@FeedbackID", FeedbackID)) != null;
        }

    }
}