using System;

namespace VehicleRegistrationSystem
{
    [Serializable]
    public class clsHiringActivity : clsActivity
    {


        private DateTime _HiringStartDate;
        private DateTime _HiringEndDate;

        private decimal _HiringCost;
        private decimal _TotalCost;


        public decimal HiringCost { get => _HiringCost; set => _HiringCost = value; }
        public decimal TotalCost1 { get => _TotalCost; set => _TotalCost = value; }
        public DateTime HiringStartDate1 { get => _HiringStartDate; set => _HiringStartDate = value; }
        public DateTime HiringEndDate1 { get => _HiringEndDate; set => _HiringEndDate = value; }

        public clsHiringActivity (decimal priceHiring )
        {
            HiringCost = priceHiring;
        }
        public override string typeOfActivity()
        {
            return "Hiring";
        }
        public override bool viewEdiActivity()
        {
            frmHiringActiivty lcFrmHiringActivty = new frmHiringActiivty();
            return lcFrmHiringActivty.ShowDialog(this);

        }
        public override string quickViewActivity()
        {
            return ("Name of Activity:" + this.Name) + ("\nStart Date:" + this.ActivityStartDate) + ("\nEndDate: " + this.HiringEndDate) + ("\nCost in NZ$: " + this.ActivityCost);
        }
    }
}
