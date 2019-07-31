using System;
using System.Windows.Forms;

namespace VehicleRegistrationSystem
{
    public partial class frmHiringActiivty : frmActivity
    {
        public frmHiringActiivty()
        {
            InitializeComponent();
        }

         protected override void updateActivityForm()
        {
            base.updateActivityForm();
            clsHiringActivity pActivity = (clsHiringActivity)_Activity;

            if (txtName.Text != null)
            {
                if (txtName.Text.ToString() == "")
                {
                    dtPickerStartDate.Value = pActivity.HiringStartDate;
                    dtPickerEndDate.Value = pActivity.HiringEndDate;
                    numericUpDownCharge.Value = pActivity.HiringCost;
                }
                else
                    numericUpDownTotalCharge.Value = pActivity.TotalCost;
            }
            base.updateActivityForm();
        }
        protected override void ViewData()
        {
            base.ViewData();
            clsHiringActivity pActivity = (clsHiringActivity)_Activity;
            pActivity.HiringStartDate = dtPickerStartDate.Value;
            pActivity.HiringEndDate = dtPickerEndDate.Value;
            pActivity.ActivityCost = numericUpDownCharge.Value;
            pActivity.TotalCost = numericUpDownTotalCharge.Value;
        }
        protected override string DisplayError()
        {
            string Message = base.DisplayError();
            if (string.IsNullOrEmpty(Message))
            {
                if (DateTime.Compare(dtPickerStartDate.Value, dtPickerEndDate.Value) > 0)
                    MessageBox.Show("The date cannot exceed the present time ", "Information!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (string.IsNullOrEmpty(txtName.Text))
                    MessageBox.Show("The name of the activity cannot be empty", "Information!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    return string.Empty;
            }
            return Message;
        }
    }
}
