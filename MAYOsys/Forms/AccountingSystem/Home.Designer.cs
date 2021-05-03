namespace MAYOsys.Forms.AccountingSystem
{
    partial class Home
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAccountTitle = new System.Windows.Forms.ComboBox();
            this.btnAddTitle = new System.Windows.Forms.Button();
            this.dgvAcctLoc = new System.Windows.Forms.DataGridView();
            this.txtParticular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPayee = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpLDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCheckNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.dgvLocationJO = new System.Windows.Forms.DataGridView();
            this.btnAllLocation = new System.Windows.Forms.Button();
            this.btnAssignLocationJO = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.NumericUpDown();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcctLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocationJO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbMonth);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtParticular);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbPayee);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpLDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCheckNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 640);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accounting System";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAssignLocationJO);
            this.groupBox2.Controls.Add(this.btnAllLocation);
            this.groupBox2.Controls.Add(this.dgvLocationJO);
            this.groupBox2.Controls.Add(this.btnAddLocation);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbLocation);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbAccountTitle);
            this.groupBox2.Controls.Add(this.btnAddTitle);
            this.groupBox2.Controls.Add(this.dgvAcctLoc);
            this.groupBox2.Location = new System.Drawing.Point(6, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1019, 425);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location Data Entry";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Account Title";
            // 
            // cbAccountTitle
            // 
            this.cbAccountTitle.FormattingEnabled = true;
            this.cbAccountTitle.Location = new System.Drawing.Point(244, 41);
            this.cbAccountTitle.Name = "cbAccountTitle";
            this.cbAccountTitle.Size = new System.Drawing.Size(220, 21);
            this.cbAccountTitle.TabIndex = 9;
            // 
            // btnAddTitle
            // 
            this.btnAddTitle.Location = new System.Drawing.Point(466, 40);
            this.btnAddTitle.Name = "btnAddTitle";
            this.btnAddTitle.Size = new System.Drawing.Size(81, 23);
            this.btnAddTitle.TabIndex = 1;
            this.btnAddTitle.Text = "Add Title";
            this.btnAddTitle.UseVisualStyleBackColor = true;
            this.btnAddTitle.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAcctLoc
            // 
            this.dgvAcctLoc.AllowUserToAddRows = false;
            this.dgvAcctLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcctLoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvAcctLoc.Location = new System.Drawing.Point(244, 68);
            this.dgvAcctLoc.Name = "dgvAcctLoc";
            this.dgvAcctLoc.RowHeadersVisible = false;
            this.dgvAcctLoc.Size = new System.Drawing.Size(769, 351);
            this.dgvAcctLoc.TabIndex = 0;
            // 
            // txtParticular
            // 
            this.txtParticular.Location = new System.Drawing.Point(105, 82);
            this.txtParticular.Multiline = true;
            this.txtParticular.Name = "txtParticular";
            this.txtParticular.Size = new System.Drawing.Size(294, 121);
            this.txtParticular.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Particular";
            // 
            // cbPayee
            // 
            this.cbPayee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayee.FormattingEnabled = true;
            this.cbPayee.Location = new System.Drawing.Point(105, 55);
            this.cbPayee.Name = "cbPayee";
            this.cbPayee.Size = new System.Drawing.Size(294, 21);
            this.cbPayee.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payee";
            // 
            // dtpLDate
            // 
            this.dtpLDate.CustomFormat = "MMM dd, yyyy";
            this.dtpLDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLDate.Location = new System.Drawing.Point(279, 29);
            this.dtpLDate.Name = "dtpLDate";
            this.dtpLDate.Size = new System.Drawing.Size(120, 20);
            this.dtpLDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // txtCheckNo
            // 
            this.txtCheckNo.Location = new System.Drawing.Point(105, 29);
            this.txtCheckNo.Name = "txtCheckNo";
            this.txtCheckNo.Size = new System.Drawing.Size(100, 20);
            this.txtCheckNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Job Order Assignment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(569, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Location";
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(572, 41);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(115, 21);
            this.cbLocation.TabIndex = 14;
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(690, 40);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(81, 23);
            this.btnAddLocation.TabIndex = 16;
            this.btnAddLocation.Text = "Add Location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvLocationJO
            // 
            this.dgvLocationJO.AllowUserToAddRows = false;
            this.dgvLocationJO.AllowUserToDeleteRows = false;
            this.dgvLocationJO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocationJO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocationJO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dgvLocationJO.Location = new System.Drawing.Point(6, 68);
            this.dgvLocationJO.MultiSelect = false;
            this.dgvLocationJO.Name = "dgvLocationJO";
            this.dgvLocationJO.ReadOnly = true;
            this.dgvLocationJO.RowHeadersVisible = false;
            this.dgvLocationJO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocationJO.Size = new System.Drawing.Size(232, 351);
            this.dgvLocationJO.TabIndex = 17;
            // 
            // btnAllLocation
            // 
            this.btnAllLocation.Location = new System.Drawing.Point(772, 40);
            this.btnAllLocation.Name = "btnAllLocation";
            this.btnAllLocation.Size = new System.Drawing.Size(81, 23);
            this.btnAllLocation.TabIndex = 18;
            this.btnAllLocation.Text = "All Location";
            this.btnAllLocation.UseVisualStyleBackColor = true;
            // 
            // btnAssignLocationJO
            // 
            this.btnAssignLocationJO.Location = new System.Drawing.Point(157, 40);
            this.btnAssignLocationJO.Name = "btnAssignLocationJO";
            this.btnAssignLocationJO.Size = new System.Drawing.Size(81, 23);
            this.btnAssignLocationJO.TabIndex = 19;
            this.btnAssignLocationJO.Text = "Assign";
            this.btnAssignLocationJO.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Month";
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMonth.Location = new System.Drawing.Point(470, 25);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 21);
            this.cbMonth.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(600, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(635, 25);
            this.txtYear.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(77, 20);
            this.txtYear.TabIndex = 12;
            this.txtYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "AccountTitle";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Account Title";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 95;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Credit";
            this.Column2.HeaderText = "Credit";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "JOID";
            this.Column3.FillWeight = 91.37056F;
            this.Column3.HeaderText = "JO ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Location";
            this.Column4.FillWeight = 108.6294F;
            this.Column4.HeaderText = "Location";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 664);
            this.Controls.Add(this.groupBox1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcctLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocationJO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpLDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCheckNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParticular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPayee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbAccountTitle;
        private System.Windows.Forms.Button btnAddTitle;
        private System.Windows.Forms.DataGridView dgvAcctLoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Button btnAllLocation;
        private System.Windows.Forms.DataGridView dgvLocationJO;
        private System.Windows.Forms.Button btnAssignLocationJO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}