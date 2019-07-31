using System;
using System.Windows.Forms;

namespace VehicleRegistrationSystem
{
    public partial class frmActivity : Form
    {
        protected clsActivity _Activity;
        public frmActivity()
        {
            InitializeComponent();
        }

        public bool ShowDialog(clsActivity pActivity)
        {
            _Activity = pActivity;
            updateActivityForm();
            return ShowDialog() == DialogResult.OK;
        }
        protected virtual void updateActivityForm()
        {
            txtName.Text = _Activity.Name;
            //if (txtName.Text != null && txtName.Text.ToString() == "")
            //{
                dtPickerStartDate.Value = _Activity.ActivityStartDate;
                numericUpDownCharge.Value = _Activity.ActivityCost;
            //}
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ActivitySave();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ActivitySave()
        {
            string pMessage = DisplayError();
            if (string.IsNullOrEmpty(pMessage))
            {
                if (txtName.Text != null)
                {
                    if (String.IsNullOrEmpty(txtName.Text.ToString()) == false)
                    {
                        ViewData();
                        MessageBox.Show("Activity Successful Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Activty Not saved", pMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        protected virtual void ViewData()
        {
            _Activity.Name = txtName.Text;
            _Activity.ActivityStartDate = dtPickerStartDate.Value;
            _Activity.ActivityCost = numericUpDownCharge.Value;
        }
        protected virtual string DisplayError()
        {
            if (string.IsNullOrEmpty(txtName.Text))
                return "Warning!!.The name of the Activity cannot be empty. ";
            else if (numericUpDownCharge.Value == 0)
                return "Warning!! The Rent Charge can't be empty.";
            else
                return string.Empty;
        }
    }

}
