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
    public class clsService
    {
        public enum enMode
        {
            AddNew = 1,
            Update = 2,
        }
        public int? ServiceID { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime CreateDate { get; set; }
        public clsServiceType ServiceType { get; set; }
        public enMode Mode { get; private set; }

        public clsService()
        {
            ServiceID = null;
            Description = null;
            Image = null;
            CreateDate = DateTime.MinValue;
            ServiceType = null;

            this.Mode = enMode.AddNew;
        }

        private clsService(clsServiceDataAccess.clsServiceData ServiceData)
        {
            ServiceID = ServiceData.ServiceID;
            Description = ServiceData.Description;
            Image = ServiceData.Image;
            CreateDate = ServiceData.CreateDate;
            ServiceType = clsServiceType.Find(ServiceData.ServiceTypeID);

            this.Mode = enMode.Update;
        }

        private bool _Add()
        {
            clsServiceDataAccess.clsServiceData ServiceData = new clsServiceDataAccess.clsServiceData();

            ServiceData.ServiceID = ServiceID;
            ServiceData.Description = Description;
            ServiceData.Image = Image;
            ServiceData.CreateDate = CreateDate;
            ServiceData.ServiceTypeID = ServiceType.ServiceTypeID.Value;

            this.ServiceID = clsServiceDataAccess.Add(ServiceData);

            return this.ServiceID != null;
        }

        private bool _Update()
        {
            clsServiceDataAccess.clsServiceData ServiceData = new clsServiceDataAccess.clsServiceData();

            ServiceData.ServiceID = ServiceID;
            ServiceData.Description = Description;
            ServiceData.Image = Image;
            ServiceData.CreateDate = CreateDate;
            ServiceData.ServiceTypeID = ServiceType.ServiceTypeID.Value;

            return clsServiceDataAccess.Update(ServiceData);
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

        public static clsService Find(int ServiceID)
        {
            clsServiceDataAccess.clsServiceData ServiceData = new clsServiceDataAccess.clsServiceData();

            ServiceData.ServiceID = ServiceID;

            if (clsServiceDataAccess.GetByID(ServiceData))
            {
                return new clsService(ServiceData);
            }
            else
            {
                return null;
            }
        }

        public static bool IsExist(int ServiceID)
        {
            return clsServiceDataAccess.IsExist(ServiceID);
        }

        public static DataTable GetList()
        {
            return clsServiceDataAccess.GetList();
        }

        public static DataTable GetList(string Value, string FieldName)
        {
            return clsServiceDataAccess.GetList(new clsDataTypes.clsFilterData(Value, FieldName));
        }

    }
}