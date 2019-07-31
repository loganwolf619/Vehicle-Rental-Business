using System;

namespace VehicleRegistrationSystem
{
    [Serializable]
    class ClsServiceActivity : clsActivity
    {
        private string _ServiceDescription;

        public string ServiceDescription { get => _ServiceDescription; set => _ServiceDescription = value; }



        public override string typeOfActivity()
        {
            return "Service";
        }
        public override bool viewEdiActivity()
        {
            frmServiceActivity lcfrmServiceActivity = new frmServiceActivity();
            return lcfrmServiceActivity.ShowDialog(this);
        }
        public override string quickViewActivity()
        {
            return ("Name of Activity: " + this.Name) + ("\nDescription: " + this.ServiceDescription) + ("\nCost in NZ$: " + this.ActivityCost);

        }
    }
}
