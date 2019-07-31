using System;
using System.Collections.Generic;

namespace VehicleRegistrationSystem
{
    [Serializable]
    public class clsVehicle
    {
        private string _VehicleRegistrationNumber;
        private string _VehicleMake;
        private string _VehicelModel;
        private int _VehicleYear;
        private int _VehicleRentPrice;
      
        
        private List<clsActivity> _ActivityListofVehicle = new List<clsActivity>();

        public string VehicleRegistrationNumber { get => _VehicleRegistrationNumber; set => _VehicleRegistrationNumber = value; }
        public string VehicleMake { get => _VehicleMake; set => _VehicleMake = value; }
        public string VehicelModel { get => _VehicelModel; set => _VehicelModel = value; }
        public int VehicleYear { get => _VehicleYear; set => _VehicleYear = value; }
        public int VehicleRentPrice { get => _VehicleRentPrice; set => _VehicleRentPrice = value; }
        public List<clsActivity> ActivityListofVehicle { get => this._ActivityListofVehicle; set => this._ActivityListofVehicle = value; }

        public string ViewVehicleDetails()
        {
            return "Registration Number: " + VehicleRegistrationNumber +
                    "\n" + "Vehicle Make: " + VehicelModel +
                    "\n" + "Vehicle Model: " + VehicelModel +
                    "\n" + "Vehicle Year: " + VehicleYear +
                    "\n" + "Vehicle Rent Price in NZ$: " + VehicleRentPrice;
        }
        public bool ViewEditedVehicle()
        {
            frmVehicle lcFrmVehicleListForm = new frmVehicle();
            return lcFrmVehicleListForm.ShowDialog(this);
        }
        public decimal CalculateTotalCashFlow()
        {
            decimal TotalCashFlow = 0;
            decimal Value = 0;
           
            foreach (clsActivity pActivity in ActivityListofVehicle)
            {
                if (pActivity.typeOfActivity() == "Hiring" )
                {
                    Value += pActivity.TotalCost;
                }
                else
                {
                    Value -= pActivity.ActivityCost;
                }
                
            }
            TotalCashFlow += Value;
            return TotalCashFlow;
        }
    }
}
