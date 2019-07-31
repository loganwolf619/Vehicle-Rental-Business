namespace VehicleRegistrationSystem
{
    partial class frmVehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBVehcileModel = new System.Windows.Forms.TextBox();
            this.tBVehicleMake = new System.Windows.Forms.TextBox();
            this.tBVehcileRegistration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnViewActvity = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblVehicleRegistration = new System.Windows.Forms.Label();
            this.lblVehicleMake = new System.Windows.Forms.Label();
            this.lblRentPerDay = new System.Windows.Forms.Label();
            this.lblVehcileYear = new System.Windows.Forms.Label();
            this.lblVehicleModel = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numRent = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRent)).BeginInit();
            this.SuspendLayout();
            // 
            // tBVehcileModel
            // 
            this.tBVehcileModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBVehcileModel.Location = new System.Drawing.Point(228, 172);
            this.tBVehcileModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBVehcileModel.Name = "tBVehcileModel";
            this.tBVehcileModel.Size = new System.Drawing.Size(167, 20);
            this.tBVehcileModel.TabIndex = 114;
            // 
            // tBVehicleMake
            // 
            this.tBVehicleMake.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBVehicleMake.Location = new System.Drawing.Point(228, 127);
            this.tBVehicleMake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBVehicleMake.Name = "tBVehicleMake";
            this.tBVehicleMake.Size = new System.Drawing.Size(167, 20);
            this.tBVehicleMake.TabIndex = 113;
            // 
            // tBVehcileRegistration
            // 
            this.tBVehcileRegistration.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBVehcileRegistration.Location = new System.Drawing.Point(228, 83);
            this.tBVehcileRegistration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBVehcileRegistration.MaxLength = 6;
            this.tBVehcileRegistration.Name = "tBVehcileRegistration";
            this.tBVehcileRegistration.Size = new System.Drawing.Size(167, 20);
            this.tBVehcileRegistration.TabIndex = 112;
            this.tBVehcileRegistration.TextChanged += new System.EventHandler(this.tBVehcileRegistration_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 36);
            this.label6.TabIndex = 111;
            this.label6.Text = "Vehicle";
            // 
            // btnViewActvity
            // 
            this.btnViewActvity.AutoSize = true;
            this.btnViewActvity.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnViewActvity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewActvity.Location = new System.Drawing.Point(505, 263);
            this.btnViewActvity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewActvity.Name = "btnViewActvity";
            this.btnViewActvity.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnViewActvity.Size = new System.Drawing.Size(93, 34);
            this.btnViewActvity.TabIndex = 110;
            this.btnViewActvity.Text = "View Activity";
            this.btnViewActvity.UseVisualStyleBackColor = false;
            this.btnViewActvity.Click += new System.EventHandler(this.btnViewActvity_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Bisque;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(505, 208);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnCancel.Size = new System.Drawing.Size(93, 34);
            this.btnCancel.TabIndex = 109;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(505, 155);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnOK.Size = new System.Drawing.Size(93, 34);
            this.btnOK.TabIndex = 108;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblVehicleRegistration
            // 
            this.lblVehicleRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleRegistration.Location = new System.Drawing.Point(12, 83);
            this.lblVehicleRegistration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleRegistration.Name = "lblVehicleRegistration";
            this.lblVehicleRegistration.Size = new System.Drawing.Size(187, 20);
            this.lblVehicleRegistration.TabIndex = 107;
            this.lblVehicleRegistration.Text = "Registration Number:";
            // 
            // lblVehicleMake
            // 
            this.lblVehicleMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleMake.Location = new System.Drawing.Point(12, 127);
            this.lblVehicleMake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleMake.Name = "lblVehicleMake";
            this.lblVehicleMake.Size = new System.Drawing.Size(187, 20);
            this.lblVehicleMake.TabIndex = 106;
            this.lblVehicleMake.Text = "Make:";
            // 
            // lblRentPerDay
            // 
            this.lblRentPerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentPerDay.Location = new System.Drawing.Point(12, 244);
            this.lblRentPerDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRentPerDay.Name = "lblRentPerDay";
            this.lblRentPerDay.Size = new System.Drawing.Size(187, 20);
            this.lblRentPerDay.TabIndex = 105;
            this.lblRentPerDay.Text = "Rent per Day in NZ$: ";
            // 
            // lblVehcileYear
            // 
            this.lblVehcileYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehcileYear.Location = new System.Drawing.Point(12, 204);
            this.lblVehcileYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehcileYear.Name = "lblVehcileYear";
            this.lblVehcileYear.Size = new System.Drawing.Size(187, 20);
            this.lblVehcileYear.TabIndex = 104;
            this.lblVehcileYear.Text = "Year:";
            // 
            // lblVehicleModel
            // 
            this.lblVehicleModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleModel.Location = new System.Drawing.Point(12, 169);
            this.lblVehicleModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Size = new System.Drawing.Size(187, 20);
            this.lblVehicleModel.TabIndex = 103;
            this.lblVehicleModel.Text = "Vehicle Model:";
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(228, 207);
            this.numYear.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.numYear.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(135, 20);
            this.numYear.TabIndex = 117;
            this.numYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numRent
            // 
            this.numRent.DecimalPlaces = 2;
            this.numRent.Location = new System.Drawing.Point(228, 249);
            this.numRent.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.numRent.Name = "numRent";
            this.numRent.Size = new System.Drawing.Size(135, 20);
            this.numRent.TabIndex = 118;
            // 
            // frmVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(619, 316);
            this.Controls.Add(this.numRent);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.tBVehcileModel);
            this.Controls.Add(this.tBVehicleMake);
            this.Controls.Add(this.tBVehcileRegistration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnViewActvity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblVehicleRegistration);
            this.Controls.Add(this.lblVehicleMake);
            this.Controls.Add(this.lblRentPerDay);
            this.Controls.Add(this.lblVehcileYear);
            this.Controls.Add(this.lblVehicleModel);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmVehicle";
            this.Text = "frmVehicle";
            this.Load += new System.EventHandler(this.frmVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBVehcileModel;
        private System.Windows.Forms.TextBox tBVehicleMake;
        private System.Windows.Forms.TextBox tBVehcileRegistration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnViewActvity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblVehicleRegistration;
        private System.Windows.Forms.Label lblVehicleMake;
        private System.Windows.Forms.Label lblRentPerDay;
        private System.Windows.Forms.Label lblVehcileYear;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numRent;
    }
}