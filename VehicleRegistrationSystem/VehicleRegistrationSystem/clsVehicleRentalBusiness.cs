using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace VehicleRegistrationSystem
{
    [Serializable]
    class clsVehicleRentalBusiness
    {
        private static SortedDictionary<string, clsVehicle> _Fleet =
            new SortedDictionary<string, clsVehicle>();
        private static string _FileName ="Vehicle rental business";
        

        public static SortedDictionary<string, clsVehicle> Fleet
        { get => _Fleet; set => _Fleet = value; }

        private static SortedDictionary<string, clsActivity> _ActvityList =
            new SortedDictionary<string, clsActivity>();

        public static SortedDictionary<string, clsActivity> ActvityList
        { get => ActvityList; set => ActvityList = value; }

        public static decimal CalculateTotalCashFlow()
        {
            decimal TotalCashFlow = 0;
            decimal Value = 0;
            List<clsVehicle> VehicleList = Fleet.Values.ToList();
            if (VehicleList.Any())
            {
                foreach (clsVehicle pVehicle in VehicleList)
                {
                    Value += pVehicle.CalculateTotalCashFlow();
                }
            }
                        TotalCashFlow += Value;
            return TotalCashFlow;
        }

        public static void SaveData()
        {
            using (FileStream lcFileStream = new FileStream(_FileName, FileMode.Create))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                lcFormatter.Serialize(lcFileStream, _Fleet);
            }
        }

        public static void RetrieveData()
        {
            using (FileStream lcFileStream = new FileStream(_FileName, FileMode.Open))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                _Fleet = (SortedDictionary<string, clsVehicle>)lcFormatter.Deserialize(lcFileStream);
            }
        }

     
    }
}
