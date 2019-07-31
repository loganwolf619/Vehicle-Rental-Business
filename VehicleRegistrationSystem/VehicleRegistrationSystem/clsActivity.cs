using System;

namespace VehicleRegistrationSystem
{
    [Serializable]
    public abstract class clsActivity
    {
        public clsActivity()
        {
            _ActivityStartDate = DateTime.Now;
            HiringStartDate = DateTime.Now;
            HiringEndDate = DateTime.Now;
        }

        private string _Name;
        private string _Activity;
        private DateTime _ActivityStartDate = DateTime.Today;
        private DateTime _UpdateActivityTime;
        private decimal _ActivityCost;

        public string Name { get => _Name; set => _Name = value; }
        public string Activity { get => _Activity; set => _Activity = value; }
        public DateTime ActivityStartDate { get => _ActivityStartDate; set => _ActivityStartDate = value; }
        public DateTime UpdateActivityTime { get => _UpdateActivityTime; set => _UpdateActivityTime = value; }

        public decimal ActivityCost { get => _ActivityCost; set => _ActivityCost = value; }

        

        private static readonly string[] ActivityType = { "Relocation", "Hiring", "Service" };
        public static string[] ActivityType1 => ActivityType;

        private static readonly string[] SortActivity = { "Name", "Date" };

        public static string[] SortActivity1 => SortActivity;

        public DateTime HiringStartDate { get; internal set; }
        public DateTime HiringEndDate { get; internal set; }
        public decimal TotalCost { get; internal set; }

        public static clsActivity NewActivityType(string TypeOfActivity, int VehicleRentPrice)
        {
           switch (TypeOfActivity)
            {   
                case "Service": return new ClsServiceActivity();
                case "Relocation": return new clsRelocationActivity();
                default: return new clsHiringActivity(VehicleRentPrice);
            }
   
        }
        public abstract bool viewEdiActivity();
        public abstract string quickViewActivity();
        public abstract string typeOfActivity();

        public override string ToString()
        {
            return string.Format ("{0, -15}",typeOfActivity()) + string.Format("{0, -15}",Name) + string.Format("{0, -10}", Activity)  + string.Format("{0, -10}", ActivityCost) + string.Format("{0, -10}", ActivityStartDate.ToShortDateString());
        }
    }
}