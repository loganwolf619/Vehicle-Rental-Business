using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace VehicleRegistrationSystem
{
    public partial class frmVehicle : Form
    {
        clsVehicle _Vehicle;
        private frmActivityList _ActvityList = new frmActivityList();
        private string _EditAdd;

        public frmVehicle()
        {
            InitializeComponent();
        }

        internal bool ShowDialog(clsVehicle pVehicle)
        {
            _Vehicle = pVehicle;
            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if ("A" == _EditAdd)
            {
                if (CharcacterCheck())
                    ShowDialogBox("Warning", "All the data space need to be fullfilled.",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string regNumber = tBVehcileRegistration.Text;
                    if (clsVehicleRentalBusiness.Fleet.ContainsKey(regNumber))
                    {
                        if (DialogResult.OK == ShowDialogBox("Warning", "Vehcile number already exists.",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning))
                        {
                            tBVehcileRegistration.Clear();
                            tBVehcileRegistration.Focus();
                        }
                    }
                    else
                    {
                        UpdateVehicleList();
                        Close();
                    }
                }
            }
               
            else
            {
                if (CheckChangeInData())
                {
                    if (CharcacterCheck())
                    {
                        ShowDialogBox("Warning", "Please input valid data :)",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        UpdateVehicleList();
                    }
                }
                else
                    ShowDialogBox("Information", "No changes has been made.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }


        private bool CharcacterCheck()
        {
            return 
                ((string.IsNullOrEmpty(tBVehcileRegistration.Text)) || (string.IsNullOrEmpty(tBVehicleMake.Text)) || (string.IsNullOrEmpty(tBVehcileModel.Text)) || (0 == numYear.Value));
        }
        private void UpdateVehicleList()
        {
            UpdateNewDataEntered();
            ShowDialogBox("Information ", "Vehicle has been added Successfully Added",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }
        private bool CheckChangeInData()
        {
            return (tBVehicleMake.Text != _Vehicle.VehicleMake || tBVehcileModel.Text != _Vehicle.VehicelModel || numYear.Value != _Vehicle.VehicleYear || numRent.Value != _Vehicle.VehicleRentPrice);
        }


        private bool CheckNonEmptyFields()
        {
            return
                ((!string.IsNullOrEmpty(tBVehcileRegistration.Text)) || (!string.IsNullOrEmpty(tBVehicleMake.Text)) || (!string.IsNullOrEmpty(tBVehcileModel.Text)));
        }
        private void btnViewActvity_Click(object sender, EventArgs e)
        {
            frmActivityList lcFrmVehicle = new frmActivityList();
            lcFrmVehicle.ShowDialog(_Vehicle);
        }
        private void updateDisplay()
        {
            if (string.IsNullOrEmpty(_Vehicle.VehicleRegistrationNumber))
            {
                btnViewActvity.Show();
                _EditAdd = "A";
                tBVehcileRegistration.Text = _Vehicle.VehicleRegistrationNumber;
                tBVehcileRegistration.Enabled = true;
                tBVehicleMake.Text = _Vehicle.VehicleMake;
                tBVehcileModel.Text = _Vehicle.VehicelModel;
                numYear.Value = _Vehicle.VehicleYear;
                numRent.Value = _Vehicle.VehicleRentPrice;
            }

            else
            {
                btnViewActvity.Show();
                _EditAdd = "E";
                tBVehcileRegistration.Text = _Vehicle.VehicleRegistrationNumber;
                tBVehcileRegistration.Enabled = false;
                tBVehicleMake.Text = _Vehicle.VehicleMake;
                tBVehcileModel.Text = _Vehicle.VehicelModel;
                numYear.Value = _Vehicle.VehicleYear;
                numRent.Value = _Vehicle.VehicleRentPrice;
            }
        }
        private void UpdateNewDataEntered()
        {
            _Vehicle.VehicleRegistrationNumber = tBVehcileRegistration.Text;
            _Vehicle.VehicleMake = tBVehicleMake.Text;
            _Vehicle.VehicelModel = tBVehcileModel.Text;
            _Vehicle.VehicleYear = Convert.ToInt32(numYear.Value);
            _Vehicle.VehicleRentPrice = Convert.ToInt32(numRent.Value);
        }
        private DialogResult ShowDialogBox(string messageType, string message, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon)
        {
            return MessageBox.Show(message, messageType, messageBoxButtons, messageBoxIcon);
        }

        private void tBVehcileRegistration_TextChanged(object sender, EventArgs e)
        {
            tBVehcileRegistration.Text = string.Concat(tBVehcileRegistration.Text.Where(char.IsLetterOrDigit));
        }

        private void frmVehicle_Load(object sender, EventArgs e)
        {

        }
    }
}
