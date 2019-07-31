using System;
using System.Windows.Forms;

namespace VehicleRegistrationSystem
{
    public partial class frmRelocationActivity : VehicleRegistrationSystem.frmActivity
    {

        public frmRelocationActivity()
        {
            InitializeComponent();
        }
        protected override void updateActivityForm()
        {
            base.updateActivityForm();
            clsRelocationActivity pActivity = (clsRelocationActivity)_Activity;
            // UPDATE and lock numupdownCharge 
            // value numupdown = days hired * daily hire charge
            if(string.IsNullOrEmpty(_Activity.Name))
            {
                numKmTravelled.Value = Convert.ToDecimal(pActivity.RelocationNumber1);
                dtPickerStartDate.Value = pActivity.ActivityStartDate;
                numericUpDownCharge.Value = Convert.ToDecimal(pActivity.ActivityCost);
            }
            else
                MessageBox.Show("Warning!!", "The name need to be entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        protected override string DisplayError()
        {
            string pMessage = base.DisplayError();
            if (string.IsNullOrEmpty(pMessage))
            {
                if (DateTime.Compare(dtPickerStartDate.Value, DateTime.Now) > 0)
                    MessageBox.Show("Warning!!", "The date cannot exceed the present time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (numKmTravelled.Value == 0)
                    MessageBox.Show("Warning!!", "The value in Kms cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    return string.Empty;
            }
            return pMessage;
        }
        protected override void ViewData()
        {
            base.ViewData();
            clsRelocationActivity pActivity = (clsRelocationActivity)_Activity;
            pActivity.RelocationNumber1 = numKmTravelled.Value;
            pActivity.ActivityCost = numericUpDownCharge.Value;
            pActivity.ActivityStartDate = dtPickerStartDate.Value;
            pActivity.Name = txtName.Text;
        }
    }
}
