namespace VehicleRegistrationSystem
{
    partial class frmActivity
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
            this.numericUpDownCharge = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblRentPrice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtPickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Activity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharge)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCharge
            // 
            this.numericUpDownCharge.DecimalPlaces = 2;
            this.numericUpDownCharge.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCharge.Location = new System.Drawing.Point(347, 441);
            this.numericUpDownCharge.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDownCharge.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.numericUpDownCharge.Name = "numericUpDownCharge";
            this.numericUpDownCharge.Size = new System.Drawing.Size(210, 38);
            this.numericUpDownCharge.TabIndex = 27;
            this.numericUpDownCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(700, 556);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 63);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOK.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(39, 543);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(131, 63);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblRentPrice
            // 
            this.lblRentPrice.AutoSize = true;
            this.lblRentPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentPrice.Location = new System.Drawing.Point(33, 443);
            this.lblRentPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRentPrice.Name = "lblRentPrice";
            this.lblRentPrice.Size = new System.Drawing.Size(123, 31);
            this.lblRentPrice.TabIndex = 24;
            this.lblRentPrice.Text = "Cashflow:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(33, 337);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(68, 31);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "Date";
            // 
            // dtPickerStartDate
            // 
            this.dtPickerStartDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerStartDate.Location = new System.Drawing.Point(347, 331);
            this.dtPickerStartDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtPickerStartDate.Name = "dtPickerStartDate";
            this.dtPickerStartDate.Size = new System.Drawing.Size(394, 38);
            this.dtPickerStartDate.TabIndex = 22;
            this.dtPickerStartDate.Value = new System.DateTime(2015, 7, 10, 0, 0, 0, 0);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(33, 240);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 31);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(347, 238);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 38);
            this.txtName.TabIndex = 20;
            // 
            // Activity
            // 
            this.Activity.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Activity.AutoSize = true;
            this.Activity.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity.Location = new System.Drawing.Point(292, 64);
            this.Activity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Activity.Name = "Activity";
            this.Activity.Size = new System.Drawing.Size(539, 87);
            this.Activity.TabIndex = 19;
            this.Activity.Text = "Activity Form ";
            // 
            // frmActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(937, 692);
            this.Controls.Add(this.numericUpDownCharge);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblRentPrice);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtPickerStartDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Activity);
            this.Name = "frmActivity";
            this.Text = "Activity Form";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.NumericUpDown numericUpDownCharge;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Button btnOK;
        protected System.Windows.Forms.Label lblRentPrice;
        protected System.Windows.Forms.Label lblDate;
        protected System.Windows.Forms.DateTimePicker dtPickerStartDate;
        protected System.Windows.Forms.Label lblName;
        protected System.Windows.Forms.TextBox txtName;
        protected System.Windows.Forms.Label Activity;
    }
}