namespace VehicleRegistrationSystem
{
    partial class frmHiringActiivty
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
            this.numericUpDownTotalCharge = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblModel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalCharge)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCharge
            // 
            this.numericUpDownCharge.DecimalPlaces = 2;
            this.numericUpDownCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCharge.Location = new System.Drawing.Point(347, 467);
            this.numericUpDownCharge.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.numericUpDownCharge.Size = new System.Drawing.Size(210, 41);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(700, 615);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(39, 615);
            // 
            // lblRentPrice
            // 
            this.lblRentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentPrice.Location = new System.Drawing.Point(33, 467);
            this.lblRentPrice.Size = new System.Drawing.Size(259, 36);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(33, 321);
            this.lblDate.Size = new System.Drawing.Size(76, 36);
            // 
            // dtPickerStartDate
            // 
            this.dtPickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerStartDate.Location = new System.Drawing.Point(347, 321);
            this.dtPickerStartDate.Size = new System.Drawing.Size(394, 41);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(33, 238);
            this.lblName.Size = new System.Drawing.Size(92, 36);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Size = new System.Drawing.Size(242, 41);
            // 
            // Activity
            // 
            this.Activity.Location = new System.Drawing.Point(24, 74);
            this.Activity.Size = new System.Drawing.Size(791, 87);
            this.Activity.Text = "Activity: Hiring Form";
            // 
            // numericUpDownTotalCharge
            // 
            this.numericUpDownTotalCharge.AutoSize = true;
            this.numericUpDownTotalCharge.DecimalPlaces = 2;
            this.numericUpDownTotalCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTotalCharge.Location = new System.Drawing.Point(347, 552);
            this.numericUpDownTotalCharge.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDownTotalCharge.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.numericUpDownTotalCharge.Name = "numericUpDownTotalCharge";
            this.numericUpDownTotalCharge.Size = new System.Drawing.Size(210, 41);
            this.numericUpDownTotalCharge.TabIndex = 124;
            this.numericUpDownTotalCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 557);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 36);
            this.label1.TabIndex = 123;
            this.label1.Text = "Total Hiring Price";
            // 
            // dtPickerEndDate
            // 
            this.dtPickerEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerEndDate.Location = new System.Drawing.Point(347, 391);
            this.dtPickerEndDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtPickerEndDate.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dtPickerEndDate.MinDate = new System.DateTime(2010, 12, 30, 0, 0, 0, 0);
            this.dtPickerEndDate.Name = "dtPickerEndDate";
            this.dtPickerEndDate.Size = new System.Drawing.Size(394, 41);
            this.dtPickerEndDate.TabIndex = 122;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(33, 391);
            this.lblModel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(138, 36);
            this.lblModel.TabIndex = 121;
            this.lblModel.Text = "End Date";
            // 
            // frmHiringActiivty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(938, 735);
            this.Controls.Add(this.numericUpDownTotalCharge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPickerEndDate);
            this.Controls.Add(this.lblModel);
            this.Name = "frmHiringActiivty";
            this.Text = "Activity Hiring";
            this.Controls.SetChildIndex(this.Activity, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.dtPickerStartDate, 0);
            this.Controls.SetChildIndex(this.lblDate, 0);
            this.Controls.SetChildIndex(this.lblRentPrice, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.numericUpDownCharge, 0);
            this.Controls.SetChildIndex(this.lblModel, 0);
            this.Controls.SetChildIndex(this.dtPickerEndDate, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.numericUpDownTotalCharge, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalCharge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.NumericUpDown numericUpDownTotalCharge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPickerEndDate;
        private System.Windows.Forms.Label lblModel;
    }
}
