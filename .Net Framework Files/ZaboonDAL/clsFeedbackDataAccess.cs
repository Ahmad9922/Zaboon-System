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
    /// Data Access Layer for the Feedbacks table.
    /// Provides CRUD operations, listing, and existence checks for feedback entities.
    /// Relies on clsAdoQueryExecutor for executing parameterized SQL and mapping results.
    /// </summary>
    public static class clsFeedbackDataAccess
    {
        #region DTO

        /// <summary>
        /// Represents a Feedback entity matching the Feedbacks table.
        /// </summary>
        public class clsFeedbackData
        {
            public int? FeedbackID { get; set; }
            public int ReservationID { get; set; }
            public byte? Rating { get; set; }
            public string Comment { get; set; }
            public DateTime FeedbackDate { get; set; }
        }

        #endregion

        #region CRUD

        /// <summary>
        /// Retrieves a Feedback record by its FeedbackID and fills the provided DTO if found.
        /// </summary>
        /// <param name="FeedbackData">Input: DTO with <c>FeedbackID</c> set. Output: remaining fields populated on success.</param>
        /// <returns>True if a record is found; otherwise, false.</returns>
        public static bool GetByID(clsFeedbackData FeedbackData)
        {
            string Query = "SELECT * FROM Feedbacks WHERE FeedbackID = @FeedbackID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FeedbackData);

            }, Query, new SqlParameter("@FeedbackID", FeedbackData.FeedbackID));
        }

        /// <summary>
        /// Inserts a new Feedback record and returns the generated FeedbackID.
        /// </summary>
        /// <param name="FeedbackData">DTO containing the feedback data to insert.</param>
        /// <returns>The newly created <c>FeedbackID</c>.</returns>
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

        /// <summary>
        /// Updates an existing Feedback record.
        /// </summary>
        /// <param name="FeedbackData">DTO with fields to update (must include <c>FeedbackID</c>).</param>
        /// <returns>True if one or more rows were affected; otherwise, false.</returns>
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

        /// <summary>
        /// Deletes a Feedback record by its ID.
        /// </summary>
        /// <param name="FeedbackID">The feedback identifier.</param>
        /// <returns>True if a row was deleted; otherwise, false.</returns>
        public static bool Delete(int FeedbackID)
        {
            string Query = @"DELETE FROM [Feedbacks] WHERE FeedbackID = @FeedbackID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, new SqlParameter("@FeedbackID", FeedbackID)) > 0;
        }

        #endregion

        #region Lists / Filters

        /// <summary>
        /// Retrieves all feedback records as a DataTable.
        /// </summary>
        /// <returns>A <see cref="DataTable"/> containing all feedback records.</returns>
        public static DataTable GetList()
        {
            string Query = @"SELECT * FROM Feedbacks";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        /// <summary>
        /// Retrieves a filtered list of feedback records as a DataTable.
        /// </summary>
        /// <param name="FilterData">Filter conditions applied by the underlying executor.</param>
        /// <returns>A <see cref="DataTable"/> containing filtered feedback records.</returns>
        public static DataTable GetList(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM Feedbacks";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);
        }

        #endregion

        #region Existence

        /// <summary>
        /// Checks if a Feedback record exists by its ID.
        /// </summary>
        /// <param name="FeedbackID">The feedback identifier.</param>
        /// <returns>True if the feedback exists; otherwise, false.</returns>
        public static bool IsExist(int FeedbackID)
        {
            string Query = @"SELECT R = 1 FROM Feedbacks WHERE FeedbackID = @FeedbackID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@FeedbackID", FeedbackID)) != null;
        }

        #endregion
    }
}