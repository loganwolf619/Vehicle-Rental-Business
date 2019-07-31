namespace VehicleRegistrationSystem
{
    partial class frmActivityList
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
            this.lblCostInDollar = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.comboBoxActivityType = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.comboBoxResortLog = new System.Windows.Forms.ComboBox();
            this.lblCashFlowOfVehicle = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.richTextBoxViewActivity = new System.Windows.Forms.RichTextBox();
            this.listBoxViewActivity = new System.Windows.Forms.ListBox();
            this.lblRegistrationNumberAct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCostInDollar
            // 
            this.lblCostInDollar.AutoSize = true;
            this.lblCostInDollar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostInDollar.Location = new System.Drawing.Point(287, 75);
            this.lblCostInDollar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCostInDollar.Name = "lblCostInDollar";
            this.lblCostInDollar.Size = new System.Drawing.Size(117, 19);
            this.lblCostInDollar.TabIndex = 140;
            this.lblCostInDollar.Text = "Cost in NZ$:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(163, 75);
            this.lblName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 19);
            this.lblName.TabIndex = 138;
            this.lblName.Text = "Name:";
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(10, 75);
            this.lblActivity.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(90, 19);
            this.lblActivity.TabIndex = 137;
            this.lblActivity.Text = "Activity:";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(431, 75);
            this.lbldate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(54, 19);
            this.lbldate.TabIndex = 139;
            this.lbldate.Text = "Date:";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuit.Location = new System.Drawing.Point(732, 31);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(106, 48);
            this.btnQuit.TabIndex = 135;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 133;
            this.label1.Text = "ReSort Log:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Tomato;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(565, 355);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 25);
            this.btnAdd.TabIndex = 132;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(565, 433);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 25);
            this.btnDelete.TabIndex = 131;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(565, 394);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 25);
            this.btnEdit.TabIndex = 130;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // comboBoxActivityType
            // 
            this.comboBoxActivityType.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.comboBoxActivityType.FormattingEnabled = true;
            this.comboBoxActivityType.Items.AddRange(new object[] {
            "Hiring",
            "Service",
            "Relocation"});
            this.comboBoxActivityType.Location = new System.Drawing.Point(705, 282);
            this.comboBoxActivityType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxActivityType.Name = "comboBoxActivityType";
            this.comboBoxActivityType.Size = new System.Drawing.Size(82, 21);
            this.comboBoxActivityType.TabIndex = 129;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(550, 283);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(111, 17);
            this.lblYear.TabIndex = 128;
            this.lblYear.Text = "Activity Type: ";
            // 
            // comboBoxResortLog
            // 
            this.comboBoxResortLog.BackColor = System.Drawing.Color.PapayaWhip;
            this.comboBoxResortLog.FormattingEnabled = true;
            this.comboBoxResortLog.Items.AddRange(new object[] {
            "Name",
            "Date"});
            this.comboBoxResortLog.Location = new System.Drawing.Point(137, 403);
            this.comboBoxResortLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxResortLog.Name = "comboBoxResortLog";
            this.comboBoxResortLog.Size = new System.Drawing.Size(82, 21);
            this.comboBoxResortLog.TabIndex = 127;
            this.comboBoxResortLog.SelectedIndexChanged += new System.EventHandler(this.comboBoxResortLog_SelectedIndexChanged);
            // 
            // lblCashFlowOfVehicle
            // 
            this.lblCashFlowOfVehicle.AutoSize = true;
            this.lblCashFlowOfVehicle.BackColor = System.Drawing.Color.SeaShell;
            this.lblCashFlowOfVehicle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCashFlowOfVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashFlowOfVehicle.Location = new System.Drawing.Point(13, 442);
            this.lblCashFlowOfVehicle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCashFlowOfVehicle.Name = "lblCashFlowOfVehicle";
            this.lblCashFlowOfVehicle.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblCashFlowOfVehicle.Size = new System.Drawing.Size(6, 24);
            this.lblCashFlowOfVehicle.TabIndex = 126;
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistration.Location = new System.Drawing.Point(201, 23);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(171, 36);
            this.lblRegistration.TabIndex = 125;
            this.lblRegistration.Text = "Actvity List";
            // 
            // richTextBoxViewActivity
            // 
            this.richTextBoxViewActivity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBoxViewActivity.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxViewActivity.Location = new System.Drawing.Point(518, 100);
            this.richTextBoxViewActivity.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.richTextBoxViewActivity.Name = "richTextBoxViewActivity";
            this.richTextBoxViewActivity.Size = new System.Drawing.Size(362, 169);
            this.richTextBoxViewActivity.TabIndex = 141;
            this.richTextBoxViewActivity.Text = "";
            // 
            // listBoxViewActivity
            // 
            this.listBoxViewActivity.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBoxViewActivity.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxViewActivity.FormattingEnabled = true;
            this.listBoxViewActivity.ItemHeight = 15;
            this.listBoxViewActivity.Location = new System.Drawing.Point(8, 100);
            this.listBoxViewActivity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxViewActivity.Name = "listBoxViewActivity";
            this.listBoxViewActivity.Size = new System.Drawing.Size(503, 259);
            this.listBoxViewActivity.TabIndex = 142;
            this.listBoxViewActivity.SelectedIndexChanged += new System.EventHandler(this.listBoxViewActivity_SelectedIndexChanged);
            // 
            // lblRegistrationNumberAct
            // 
            this.lblRegistrationNumberAct.AutoSize = true;
            this.lblRegistrationNumberAct.Location = new System.Drawing.Point(146, 377);
            this.lblRegistrationNumberAct.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblRegistrationNumberAct.Name = "lblRegistrationNumberAct";
            this.lblRegistrationNumberAct.Size = new System.Drawing.Size(0, 13);
            this.lblRegistrationNumberAct.TabIndex = 144;
            // 
            // frmActivityList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(912, 509);
            this.Controls.Add(this.lblRegistrationNumberAct);
            this.Controls.Add(this.listBoxViewActivity);
            this.Controls.Add(this.richTextBoxViewActivity);
            this.Controls.Add(this.lblCostInDollar);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.comboBoxActivityType);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.comboBoxResortLog);
            this.Controls.Add(this.lblCashFlowOfVehicle);
            this.Controls.Add(this.lblRegistration);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmActivityList";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCostInDollar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox comboBoxActivityType;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox comboBoxResortLog;
        private System.Windows.Forms.Label lblCashFlowOfVehicle;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.RichTextBox richTextBoxViewActivity;
        private System.Windows.Forms.ListBox listBoxViewActivity;
        private System.Windows.Forms.Label lblRegistrationNumberAct;
    }
}

