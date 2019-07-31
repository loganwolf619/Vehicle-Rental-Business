using System;
using System.Windows.Forms;

namespace VehicleRegistrationSystem
{
    public partial class frmServiceActivity : VehicleRegistrationSystem.frmActivity
    {
        public frmServiceActivity()
        {
            InitializeComponent();
        }
        protected override void updateActivityForm()
        {
            base.updateActivityForm();
            ClsServiceActivity pActivity = (ClsServiceActivity)_Activity;
            rtBoxServiceDescription.Text = pActivity.ServiceDescription;
            if (string.IsNullOrEmpty(_Activity.Name))
            {
                 numericUpDownCharge.Value = Convert.ToDecimal(_Activity.ActivityCost);
            }
            else
                numericUpDownCharge.Value = Convert.ToDecimal(_Activity.ActivityCost);
        }
        protected override string DisplayError()
        {
            string Message = base.DisplayError();
            if (string.IsNullOrEmpty(Message))
            {
                if(DateTime.Compare(dtPickerStartDate.Value, DateTime.Now)> 0)
                    MessageBox.Show("Warning!!", "The date cannot exceed the present time ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (string.IsNullOrEmpty(rtBoxServiceDescription.Text))
                    MessageBox.Show("Warning!!", "Service description cannot be empty.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                   return string.Empty;
            }
            return Message;
        }
        protected override void ViewData()
        {
            base.ViewData();
            ClsServiceActivity pActivity = (ClsServiceActivity)_Activity;
            pActivity.ServiceDescription = rtBoxServiceDescription.Text;
            pActivity.ActivityCost = numericUpDownCharge.Value;
            pActivity.ActivityStartDate = dtPickerStartDate.Value;
            pActivity.Name = txtName.Text;
        }

        private void frmServiceActivity_Load(object sender, EventArgs e)
        {

        }
    }
}
