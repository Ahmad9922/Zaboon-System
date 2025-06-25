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
    public class clsReservation
    {
        public enum enMode
        {
            AddNew = 1,
            Update = 2,
        }
        public int? ReservationID { get; set; }
        public clsUser User { get; set; }
        public DateTime ReservationDate { get; set; }
        public byte ReservationStatus { get; set; }
        public decimal? PaidFees { get; set; }
        public clsService Service { get; set; }
        public enMode Mode { get; private set; }

        public clsReservation()
        {
            ReservationID = null;
            User = null;
            ReservationDate = DateTime.MinValue;
            ReservationStatus = 0;
            PaidFees = null;
            Service = null;

            this.Mode = enMode.AddNew;
        }

        private clsReservation(clsReservationDataAccess.clsReservationData ReservationData)
        {
            ReservationID = ReservationData.ReservationID;
            User = clsUser.Find(ReservationData.UserID);
            ReservationDate = ReservationData.ReservationDate;
            ReservationStatus = ReservationData.ReservationStatus;
            PaidFees = ReservationData.PaidFees;
            Service = clsService.Find(ReservationData.ServiceID);

            this.Mode = enMode.Update;
        }

        private bool _Add()
        {
            clsReservationDataAccess.clsReservationData ReservationData = new clsReservationDataAccess.clsReservationData();

            ReservationData.ReservationID = ReservationID;
            ReservationData.UserID = User.UserID.Value;
            ReservationData.ReservationDate = ReservationDate;
            ReservationData.ReservationStatus = ReservationStatus;
            ReservationData.PaidFees = PaidFees;
            ReservationData.ServiceID = Service.ServiceID.Value;

            this.ReservationID = clsReservationDataAccess.Add(ReservationData);

            return this.ReservationID != null;
        }

        private bool _Update()
        {
            clsReservationDataAccess.clsReservationData ReservationData = new clsReservationDataAccess.clsReservationData();

            ReservationData.ReservationID = ReservationID;
            ReservationData.UserID = User.UserID.Value;
            ReservationData.ReservationDate = ReservationDate;
            ReservationData.ReservationStatus = ReservationStatus;
            ReservationData.PaidFees = PaidFees;
            ReservationData.ServiceID = Service.ServiceID.Value;

            return clsReservationDataAccess.Update(ReservationData);
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

        public static clsReservation Find(int ReservationID)
        {
            clsReservationDataAccess.clsReservationData ReservationData = new clsReservationDataAccess.clsReservationData();

            ReservationData.ReservationID = ReservationID;

            if (clsReservationDataAccess.GetByID(ReservationData))
            {
                return new clsReservation(ReservationData);
            }
            else
            {
                return null;
            }
        }

        public static bool IsExist(int ReservationID)
        {
            return clsReservationDataAccess.IsExist(ReservationID);
        }

        public static DataTable GetList()
        {
            return clsReservationDataAccess.GetList();
        }

        public static DataTable GetList(string Value, string FieldName)
        {
            return clsReservationDataAccess.GetList(new clsDataTypes.clsFilterData(Value, FieldName));
        }

    }
}