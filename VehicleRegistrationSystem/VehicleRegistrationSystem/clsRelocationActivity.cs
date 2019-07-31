using System;

namespace VehicleRegistrationSystem
{
    [Serializable]
    class clsRelocationActivity : clsActivity
    { 
        private decimal RelocationNumber;

        public decimal RelocationNumber1 { get => RelocationNumber; set => RelocationNumber = value; }

        public override string typeOfActivity()
        {
            return "Relocation";
        }
        public override bool viewEdiActivity()
        {
            frmRelocationActivity lcFrmRelocationACtivity = new frmRelocationActivity();
            return lcFrmRelocationACtivity.ShowDialog(this);
        }
        public override string quickViewActivity()
        {
            
            return ("Name of Activity:" + this.Name) + ("\nActivity Date:" + this.ActivityStartDate) + ("\nDistance Covered in KMs: " + this.RelocationNumber) + ("\nCost in NZ$: " + this.ActivityCost);
        }
    }
}
