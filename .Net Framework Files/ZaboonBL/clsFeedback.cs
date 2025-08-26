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
    /// Business layer class that represents a feedback entity (rating/comment on a reservation).
    /// Encapsulates create/update/find/list logic and persists via clsFeedbackDataAccess.
    /// </summary>
    public class clsFeedback
    {
        #region Mode

        /// <summary>
        /// Object persistence mode.
        /// </summary>
        public enum enMode
        {
            /// <summary>
            /// New feedback (not saved yet).
            /// </summary>
            AddNew = 1,

            /// <summary>
            /// Existing feedback (updates only).
            /// </summary>
            Update = 2,
        }

        #endregion

        #region Properties

        public int? FeedbackID { get; set; }
        public clsReservation Reservation { get; set; }
        public byte? Rating { get; set; }
        public string Comment { get; set; }
        public DateTime FeedbackDate { get; set; }

        /// <summary>
        /// Current object mode (AddNew/Update).
        /// </summary>
        public enMode Mode { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor initializes a new feedback in AddNew mode.
        /// </summary>
        public clsFeedback()
        {
            FeedbackID = null;
            Reservation = null;
            Rating = null;
            Comment = null;
            FeedbackDate = DateTime.MinValue;

            this.Mode = enMode.AddNew;
        }

        /// <summary>
        /// Private constructor to materialize an existing feedback (Update mode) from DAL DTO.
        /// </summary>
        /// <param name="FeedbackData">DAL DTO loaded from database.</param>
        private clsFeedback(clsFeedbackDataAccess.clsFeedbackData FeedbackData)
        {
            FeedbackID = FeedbackData.FeedbackID;
            Reservation = clsReservation.Find(FeedbackData.ReservationID);
            Rating = FeedbackData.Rating;
            Comment = FeedbackData.Comment;
            FeedbackDate = FeedbackData.FeedbackDate;

            this.Mode = enMode.Update;
        }

        #endregion

        #region Persistence (private)

        /// <summary>
        /// Adds the current feedback to the database and sets <see cref="FeedbackID"/> on success.
        /// </summary>
        /// <returns>True if added; otherwise, false.</returns>
        private bool _Add()
        {
            clsFeedbackDataAccess.clsFeedbackData FeedbackData = new clsFeedbackDataAccess.clsFeedbackData
            {
                FeedbackID = FeedbackID,
                ReservationID = Reservation.ReservationID.Value,
                Rating = Rating,
                Comment = Comment,
                FeedbackDate = FeedbackDate
            };

            this.FeedbackID = clsFeedbackDataAccess.Add(FeedbackData);

            return this.FeedbackID != null;
        }

        /// <summary>
        /// Updates the current feedback in the database.
        /// </summary>
        /// <returns>True if updated; otherwise, false.</returns>
        private bool _Update()
        {
            clsFeedbackDataAccess.clsFeedbackData FeedbackData = new clsFeedbackDataAccess.clsFeedbackData
            {
                FeedbackID = FeedbackID,
                ReservationID = Reservation.ReservationID.Value,
                Rating = Rating,
                Comment = Comment,
                FeedbackDate = FeedbackDate
            };

            return clsFeedbackDataAccess.Update(FeedbackData);
        }

        #endregion

        #region Persistence (public)

        /// <summary>
        /// Saves the feedback:
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

        #endregion

        #region Finders / Listing (static)

        /// <summary>
        /// Finds a feedback by its identifier.
        /// </summary>
        /// <param name="FeedbackID">Feedback identifier.</param>
        /// <returns>clsFeedback instance if found; otherwise, null.</returns>
        public static clsFeedback Find(int FeedbackID)
        {
            clsFeedbackDataAccess.clsFeedbackData FeedbackData = new clsFeedbackDataAccess.clsFeedbackData
            {
                FeedbackID = FeedbackID
            };

            if (clsFeedbackDataAccess.GetByID(FeedbackData))
            {
                return new clsFeedback(FeedbackData);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Checks whether a feedback exists by its identifier.
        /// </summary>
        /// <param name="FeedbackID">Feedback identifier.</param>
        /// <returns>True if exists; otherwise, false.</returns>
        public static bool IsExist(int FeedbackID)
        {
            return clsFeedbackDataAccess.IsExist(FeedbackID);
        }

        /// <summary>
        /// Retrieves all feedback records as a DataTable.
        /// </summary>
        /// <returns>DataTable with feedback records.</returns>
        public static DataTable GetList()
        {
            return clsFeedbackDataAccess.GetList();
        }

        /// <summary>
        /// Retrieves filtered feedback records as a DataTable.
        /// </summary>
        /// <param name="Value">Filter value.</param>
        /// <param name="FieldName">Field name to filter by.</param>
        /// <returns>Filtered DataTable.</returns>
        public static DataTable GetList(string Value, string FieldName)
        {
            return clsFeedbackDataAccess.GetList(new clsDataTypes.clsFilterData(Value, FieldName));
        }

        #endregion
    }
}