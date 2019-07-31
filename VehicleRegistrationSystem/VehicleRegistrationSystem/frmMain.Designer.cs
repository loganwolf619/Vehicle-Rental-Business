namespace VehicleRegistrationSystem
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCarRegistration = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.btnEditVehicle = new System.Windows.Forms.Button();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.lblTotalCashFlow = new System.Windows.Forms.Label();
            this.listBoxRegistrationList = new System.Windows.Forms.ListBox();
            this.richTextBoxQuickView = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 36);
            this.label1.TabIndex = 49;
            this.label1.Text = "Vehicle Rental Business";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Quick View of a Vehicle";
            // 
            // lblCarRegistration
            // 
            this.lblCarRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarRegistration.Location = new System.Drawing.Point(22, 78);
            this.lblCarRegistration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarRegistration.Name = "lblCarRegistration";
            this.lblCarRegistration.Size = new System.Drawing.Size(217, 20);
            this.lblCarRegistration.TabIndex = 47;
            this.lblCarRegistration.Text = "Registration Plate Number";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(580, 333);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnExit.Size = new System.Drawing.Size(93, 34);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.BackColor = System.Drawing.Color.Violet;
            this.btnDeleteVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVehicle.Location = new System.Drawing.Point(580, 231);
            this.btnDeleteVehicle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnDeleteVehicle.Size = new System.Drawing.Size(93, 30);
            this.btnDeleteVehicle.TabIndex = 45;
            this.btnDeleteVehicle.Text = "Delete Vehicle";
            this.btnDeleteVehicle.UseVisualStyleBackColor = false;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click_1);
            // 
            // btnEditVehicle
            // 
            this.btnEditVehicle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEditVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditVehicle.Location = new System.Drawing.Point(580, 173);
            this.btnEditVehicle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditVehicle.Name = "btnEditVehicle";
            this.btnEditVehicle.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnEditVehicle.Size = new System.Drawing.Size(93, 30);
            this.btnEditVehicle.TabIndex = 44;
            this.btnEditVehicle.Text = "Edit Vehicle";
            this.btnEditVehicle.UseVisualStyleBackColor = false;
            this.btnEditVehicle.Click += new System.EventHandler(this.btnEditVehicle_Click);
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.BackColor = System.Drawing.Color.Coral;
            this.btnAddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicle.Location = new System.Drawing.Point(99, 312);
            this.btnAddVehicle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAddVehicle.Size = new System.Drawing.Size(93, 34);
            this.btnAddVehicle.TabIndex = 43;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = false;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click_1);
            // 
            // lblTotalCashFlow
            // 
            this.lblTotalCashFlow.BackColor = System.Drawing.SystemColors.Info;
            this.lblTotalCashFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCashFlow.Location = new System.Drawing.Point(22, 370);
            this.lblTotalCashFlow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCashFlow.Name = "lblTotalCashFlow";
            this.lblTotalCashFlow.Size = new System.Drawing.Size(384, 21);
            this.lblTotalCashFlow.TabIndex = 42;
            this.lblTotalCashFlow.Text = "Total Cash Flow:\r\n";
            this.lblTotalCashFlow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxRegistrationList
            // 
            this.listBoxRegistrationList.BackColor = System.Drawing.Color.Cornsilk;
            this.listBoxRegistrationList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRegistrationList.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBoxRegistrationList.FormattingEnabled = true;
            this.listBoxRegistrationList.ItemHeight = 19;
            this.listBoxRegistrationList.Location = new System.Drawing.Point(18, 114);
            this.listBoxRegistrationList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxRegistrationList.Name = "listBoxRegistrationList";
            this.listBoxRegistrationList.Size = new System.Drawing.Size(224, 137);
            this.listBoxRegistrationList.TabIndex = 40;
            this.listBoxRegistrationList.SelectedIndexChanged += new System.EventHandler(this.listBoxRegistrationList_SelectedIndexChanged);
            // 
            // richTextBoxQuickView
            // 
            this.richTextBoxQuickView.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxQuickView.Location = new System.Drawing.Point(272, 107);
            this.richTextBoxQuickView.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.richTextBoxQuickView.Name = "richTextBoxQuickView";
            this.richTextBoxQuickView.Size = new System.Drawing.Size(262, 162);
            this.richTextBoxQuickView.TabIndex = 50;
            this.richTextBoxQuickView.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(702, 399);
            this.Controls.Add(this.richTextBoxQuickView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCarRegistration);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteVehicle);
            this.Controls.Add(this.btnEditVehicle);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.lblTotalCashFlow);
            this.Controls.Add(this.listBoxRegistrationList);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCarRegistration;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.Button btnEditVehicle;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Label lblTotalCashFlow;
        private System.Windows.Forms.ListBox listBoxRegistrationList;
        private System.Windows.Forms.RichTextBox richTextBoxQuickView;
    }
}