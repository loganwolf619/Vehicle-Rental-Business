using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VehicleRegistrationSystem
{
    public partial class frmActivityList : Form
    {
        clsVehicle _Vehicle = new clsVehicle();
        public frmActivityList()
        {
            InitializeComponent();
        }
        internal void ShowDialog(clsVehicle pVehicle)
        {
            _Vehicle = pVehicle;
            showComboBoxForActvityType();
            viewActivityList(comboBoxResortLog.Text);
            loadDefaultActivitySettings();
            base.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string TypeOfactvity = comboBoxActivityType.Text;
            clsActivity pActivity = clsActivity.NewActivityType(TypeOfactvity, _Vehicle.VehicleRentPrice);
            if (pActivity != null && pActivity.viewEdiActivity())
            {
                _Vehicle.ActivityListofVehicle.Add(pActivity);
                viewActivityList(comboBoxResortLog.Text);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            clsVehicleRentalBusiness.SaveData();
            richTextBoxViewActivity.Clear();
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            richTextBoxViewActivity.Clear();
            clsActivity pActivity = (clsActivity)listBoxViewActivity.SelectedItem;
            if (pActivity != null && pActivity.viewEdiActivity())
            {
                viewActivityList(comboBoxResortLog.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            richTextBoxViewActivity.Clear();
            clsActivity pActivity = (clsActivity)listBoxViewActivity.SelectedItem;
            if (pActivity != null)
                MessageBox.Show("Do You want to delte Actvity?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            {
                _Vehicle.ActivityListofVehicle.Remove(pActivity);
                viewActivityList(comboBoxResortLog.Text);
            }
        }

        private void comboBoxResortLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewActivityList(comboBoxResortLog.Text);
        }

        private void viewActivityList(string reSortType)
        {
            List<clsActivity> listofActivity = sortActivityType(_Vehicle.ActivityListofVehicle, reSortType);
            listBoxViewActivity.DataSource = null;
            listBoxViewActivity.DataSource = listofActivity;
            decimal TotalCashFlow = _Vehicle.CalculateTotalCashFlow();
            lblCashFlowOfVehicle.Text = "Total Cash Flow in NZ$: " + TotalCashFlow;
        }
        private List<clsActivity> sortActivityType(List<clsActivity> ListOfActivity,string reSortType)
        {
            if (reSortType == "Name")
            {
                clsSortNaming sortNaming = new clsSortNaming();
                ListOfActivity.Sort(sortNaming);
            }
            else
            {
                clsSortDate sortDate = new clsSortDate();
                ListOfActivity.Sort(sortDate);
            }
            return ListOfActivity;
        }
        private void loadDefaultActivitySettings ()
        {

            comboBoxResortLog.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxActivityType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxActivityType.Text = "Hiring";
            comboBoxResortLog.Text = "Name";
        }
        private void showComboBoxForActvityType()
        {
            comboBoxActivityType.DataSource = clsActivity.ActivityType1;
            comboBoxResortLog.DataSource = clsActivity.SortActivity1;      
        }

        private void listBoxViewActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsActivity pActivity = (clsActivity)listBoxViewActivity.SelectedItem;
            if (pActivity != null)
            {
                richTextBoxViewActivity.Text = pActivity.quickViewActivity();
            }
        }
    }
}
