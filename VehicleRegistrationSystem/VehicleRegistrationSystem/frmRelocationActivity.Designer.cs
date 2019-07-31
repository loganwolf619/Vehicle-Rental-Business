namespace VehicleRegistrationSystem
{
    partial class frmRelocationActivity
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
            this.numKmTravelled = new System.Windows.Forms.NumericUpDown();
            this.lblKMTravelled = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKmTravelled)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCharge
            // 
            this.numericUpDownCharge.AutoSize = true;
            this.numericUpDownCharge.BackColor = System.Drawing.Color.PapayaWhip;
            this.numericUpDownCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCharge.Location = new System.Drawing.Point(356, 505);
            this.numericUpDownCharge.Size = new System.Drawing.Size(210, 41);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(682, 593);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(39, 606);
            // 
            // lblRentPrice
            // 
            this.lblRentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentPrice.Location = new System.Drawing.Point(33, 512);
            this.lblRentPrice.Size = new System.Drawing.Size(259, 36);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Size = new System.Drawing.Size(76, 36);
            // 
            // dtPickerStartDate
            // 
            this.dtPickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerStartDate.Size = new System.Drawing.Size(394, 41);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Size = new System.Drawing.Size(92, 36);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Size = new System.Drawing.Size(242, 41);
            // 
            // Activity
            // 
            this.Activity.Location = new System.Drawing.Point(14, 53);
            this.Activity.Size = new System.Drawing.Size(942, 87);
            this.Activity.Text = "Activity: Relocation Form";
            // 
            // numKmTravelled
            // 
            this.numKmTravelled.DecimalPlaces = 2;
            this.numKmTravelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numKmTravelled.Location = new System.Drawing.Point(356, 412);
            this.numKmTravelled.Margin = new System.Windows.Forms.Padding(5);
            this.numKmTravelled.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.numKmTravelled.Name = "numKmTravelled";
            this.numKmTravelled.Size = new System.Drawing.Size(201, 41);
            this.numKmTravelled.TabIndex = 29;
            this.numKmTravelled.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblKMTravelled
            // 
            this.lblKMTravelled.AutoSize = true;
            this.lblKMTravelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKMTravelled.Location = new System.Drawing.Point(32, 414);
            this.lblKMTravelled.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKMTravelled.Name = "lblKMTravelled";
            this.lblKMTravelled.Size = new System.Drawing.Size(186, 36);
            this.lblKMTravelled.TabIndex = 28;
            this.lblKMTravelled.Text = "KM invlolved";
            // 
            // frmRelocationActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(961, 753);
            this.Controls.Add(this.numKmTravelled);
            this.Controls.Add(this.lblKMTravelled);
            this.Name = "frmRelocationActivity";
            this.Text = "Activity Reloaction";
            this.Controls.SetChildIndex(this.Activity, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.dtPickerStartDate, 0);
            this.Controls.SetChildIndex(this.lblDate, 0);
            this.Controls.SetChildIndex(this.lblRentPrice, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.numericUpDownCharge, 0);
            this.Controls.SetChildIndex(this.lblKMTravelled, 0);
            this.Controls.SetChildIndex(this.numKmTravelled, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKmTravelled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numKmTravelled;
        private System.Windows.Forms.Label lblKMTravelled;
    }
}
