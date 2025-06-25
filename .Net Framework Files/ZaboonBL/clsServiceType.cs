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
    public class clsServiceType
    {
        public enum enMode
        {
            AddNew = 1,
            Update = 2,
        }
        public int? ServiceTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public enMode Mode { get; private set; }

        public clsServiceType()
        {
            ServiceTypeID = null;
            Name = string.Empty;
            Description = null;
            IsActive = false;

            this.Mode = enMode.AddNew;
        }

        private clsServiceType(clsServiceTypeDataAccess.clsServiceTypeData ServiceTypeData)
        {
            ServiceTypeID = ServiceTypeData.ServiceTypeID;
            Name = ServiceTypeData.Name;
            Description = ServiceTypeData.Description;
            IsActive = ServiceTypeData.IsActive;

            this.Mode = enMode.Update;
        }

        private bool _Add()
        {
            clsServiceTypeDataAccess.clsServiceTypeData ServiceTypeData = new clsServiceTypeDataAccess.clsServiceTypeData();

            ServiceTypeData.ServiceTypeID = ServiceTypeID;
            ServiceTypeData.Name = Name;
            ServiceTypeData.Description = Description;
            ServiceTypeData.IsActive = IsActive;

            this.ServiceTypeID = clsServiceTypeDataAccess.Add(ServiceTypeData);

            return this.ServiceTypeID != null;
        }

        private bool _Update()
        {
            clsServiceTypeDataAccess.clsServiceTypeData ServiceTypeData = new clsServiceTypeDataAccess.clsServiceTypeData();

            ServiceTypeData.ServiceTypeID = ServiceTypeID;
            ServiceTypeData.Name = Name;
            ServiceTypeData.Description = Description;
            ServiceTypeData.IsActive = IsActive;

            return clsServiceTypeDataAccess.Update(ServiceTypeData);
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

        public static clsServiceType Find(int ServiceTypeID)
        {
            clsServiceTypeDataAccess.clsServiceTypeData ServiceTypeData = new clsServiceTypeDataAccess.clsServiceTypeData();

            ServiceTypeData.ServiceTypeID = ServiceTypeID;

            if (clsServiceTypeDataAccess.GetByID(ServiceTypeData))
            {
                return new clsServiceType(ServiceTypeData);
            }
            else
            {
                return null;
            }
        }

        public static bool IsExist(int ServiceTypeID)
        {
            return clsServiceTypeDataAccess.IsExist(ServiceTypeID);
        }

        public static DataTable GetList()
        {
            return clsServiceTypeDataAccess.GetList();
        }

        public static DataTable GetList(string Value, string FieldName)
        {
            return clsServiceTypeDataAccess.GetList(new clsDataTypes.clsFilterData(Value, FieldName));
        }

    }
}