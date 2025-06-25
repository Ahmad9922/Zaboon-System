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
    public class clsFeedback
    {
        public enum enMode
        {
            AddNew = 1,
            Update = 2,
        }
        public int? FeedbackID { get; set; }
        public clsReservation Reservation { get; set; }
        public byte? Rating { get; set; }
        public string Comment { get; set; }
        public DateTime FeedbackDate { get; set; }
        public enMode Mode { get; private set; }

        public clsFeedback()
        {
            FeedbackID = null;
            Reservation = null;
            Rating = null;
            Comment = null;
            FeedbackDate = DateTime.MinValue;

            this.Mode = enMode.AddNew;
        }

        private clsFeedback(clsFeedbackDataAccess.clsFeedbackData FeedbackData)
        {
            FeedbackID = FeedbackData.FeedbackID;
            Reservation = clsReservation.Find(FeedbackData.ReservationID);
            Rating = FeedbackData.Rating;
            Comment = FeedbackData.Comment;
            FeedbackDate = FeedbackData.FeedbackDate;

            this.Mode = enMode.Update;
        }

        private bool _Add()
        {
            clsFeedbackDataAccess.clsFeedbackData FeedbackData = new clsFeedbackDataAccess.clsFeedbackData();

            FeedbackData.FeedbackID = FeedbackID;
            FeedbackData.ReservationID = Reservation.ReservationID.Value;
            FeedbackData.Rating = Rating;
            FeedbackData.Comment = Comment;
            FeedbackData.FeedbackDate = FeedbackDate;

            this.FeedbackID = clsFeedbackDataAccess.Add(FeedbackData);

            return this.FeedbackID != null;
        }

        private bool _Update()
        {
            clsFeedbackDataAccess.clsFeedbackData FeedbackData = new clsFeedbackDataAccess.clsFeedbackData();

            FeedbackData.FeedbackID = FeedbackID;
            FeedbackData.ReservationID = Reservation.ReservationID.Value;
            FeedbackData.Rating = Rating;
            FeedbackData.Comment = Comment;
            FeedbackData.FeedbackDate = FeedbackDate;

            return clsFeedbackDataAccess.Update(FeedbackData);
        }

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

        public static clsFeedback Find(int FeedbackID)
        {
            clsFeedbackDataAccess.clsFeedbackData FeedbackData = new clsFeedbackDataAccess.clsFeedbackData();

            FeedbackData.FeedbackID = FeedbackID;

            if (clsFeedbackDataAccess.GetByID(FeedbackData))
            {
                return new clsFeedback(FeedbackData);
            }
            else
            {
                return null;
            }
        }

        public static bool IsExist(int FeedbackID)
        {
            return clsFeedbackDataAccess.IsExist(FeedbackID);
        }

        public static DataTable GetList()
        {
            return clsFeedbackDataAccess.GetList();
        }

        public static DataTable GetList(string Value, string FieldName)
        {
            return clsFeedbackDataAccess.GetList(new clsDataTypes.clsFilterData(Value, FieldName));
        }

    }
}