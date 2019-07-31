using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VehicleRegistrationSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            SaveData();
            UpdateVehicleList();
        }

        private void SaveData()
        {
            try
            {
                clsVehicleRentalBusiness.RetrieveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }

        }

        private void lstRegistration_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateVehicleList();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                clsVehicleRentalBusiness.SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            Close();
        }

        private void btnDeleteVehicle_Click_1(object sender, EventArgs e)
        {
            String VehicleRegistrationNumber = listBoxRegistrationList.SelectedItem.ToString();
            DialogResult dialogResult = MessageBox.Show("Information!!", "Deleting vehicle successfully", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == dialogResult && clsVehicleRentalBusiness.Fleet.Remove(VehicleRegistrationNumber))
                UpdateVehicleList();
        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            string VehicleRegistrationNumber = listBoxRegistrationList.SelectedItem.ToString();
            clsVehicle pVehicle = clsVehicleRentalBusiness.Fleet[VehicleRegistrationNumber];
            pVehicle.ViewEditedVehicle();
            UpdateVehicleList();

        }

        private void btnAddVehicle_Click_1(object sender, EventArgs e)
        {

            clsVehicle pVehicle = new clsVehicle();
            if (pVehicle != null && pVehicle.ViewEditedVehicle())
            {
                clsVehicleRentalBusiness.Fleet.Add(pVehicle.VehicleRegistrationNumber, pVehicle);
                UpdateVehicleList();
            }
        }

        private void listBoxRegistrationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string VehicleRegistrationNumber; 


               VehicleRegistrationNumber = listBoxRegistrationList.SelectedItem.ToString();

            clsVehicle pVehicle = clsVehicleRentalBusiness.Fleet[VehicleRegistrationNumber];
            richTextBoxQuickView.Text = pVehicle.ViewVehicleDetails();
        }

        private void UpdateVehicleList()
        {
            List<String> fleet = clsVehicleRentalBusiness.Fleet.Keys.ToList();
            listBoxRegistrationList.DataSource = fleet;
            decimal TotalCashFLow = clsVehicleRentalBusiness.CalculateTotalCashFlow();
            lblTotalCashFlow.Text = "Total Cash Flow in NZ$: " + TotalCashFLow;
                //listBoxRegistrationList.DataSource = null;
                //listBoxRegistrationList.Items.Clear();
            richTextBoxQuickView.Clear();

        }

    }
}
