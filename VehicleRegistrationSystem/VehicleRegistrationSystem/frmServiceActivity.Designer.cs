namespace VehicleRegistrationSystem
{
    partial class frmServiceActivity
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
            this.rtBoxServiceDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharge)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCharge
            // 
            this.numericUpDownCharge.Location = new System.Drawing.Point(347, 617);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(426, 718);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(28, 718);
            // 
            // lblRentPrice
            // 
            this.lblRentPrice.Location = new System.Drawing.Point(33, 608);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // Activity
            // 
            this.Activity.Location = new System.Drawing.Point(60, 69);
            this.Activity.Size = new System.Drawing.Size(823, 87);
            this.Activity.Text = "Activity: Service Form";
            // 
            // rtBoxServiceDescription
            // 
            this.rtBoxServiceDescription.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtBoxServiceDescription.Location = new System.Drawing.Point(347, 402);
            this.rtBoxServiceDescription.Margin = new System.Windows.Forms.Padding(5);
            this.rtBoxServiceDescription.Name = "rtBoxServiceDescription";
            this.rtBoxServiceDescription.Size = new System.Drawing.Size(394, 171);
            this.rtBoxServiceDescription.TabIndex = 29;
            this.rtBoxServiceDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 487);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 41);
            this.label1.TabIndex = 28;
            this.label1.Text = "Service Brief";
            // 
            // frmServiceActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(960, 811);
            this.Controls.Add(this.rtBoxServiceDescription);
            this.Controls.Add(this.label1);
            this.Name = "frmServiceActivity";
            this.Text = "Activity: Service Form";
            this.Load += new System.EventHandler(this.frmServiceActivity_Load);
            this.Controls.SetChildIndex(this.Activity, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.dtPickerStartDate, 0);
            this.Controls.SetChildIndex(this.lblDate, 0);
            this.Controls.SetChildIndex(this.lblRentPrice, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.numericUpDownCharge, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.rtBoxServiceDescription, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtBoxServiceDescription;
        private System.Windows.Forms.Label label1;
    }
}
