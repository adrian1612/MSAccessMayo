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
            this.txtCVNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.btnAllLocation = new System.Windows.Forms.Button();
            this.btnAssignLocationJO = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.NumericUpDown();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvJOAssign = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBranchNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCheckNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcctLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCheckNo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtBranchNo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtAccountNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtBank);
            this.groupBox1.Controls.Add(this.label10);
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
            this.groupBox1.Controls.Add(this.txtCVNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 689);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accounting System";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvJOAssign);
            this.groupBox2.Controls.Add(this.btnAssignLocationJO);
            this.groupBox2.Controls.Add(this.btnAllLocation);
            this.groupBox2.Controls.Add(this.btnAddLocation);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbLocation);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbAccountTitle);
            this.groupBox2.Controls.Add(this.btnAddTitle);
            this.groupBox2.Controls.Add(this.dgvAcctLoc);
            this.groupBox2.Location = new System.Drawing.Point(6, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1019, 458);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location Data Entry";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "Account Title";
            // 
            // cbAccountTitle
            // 
            this.cbAccountTitle.FormattingEnabled = true;
            this.cbAccountTitle.Location = new System.Drawing.Point(244, 44);
            this.cbAccountTitle.Name = "cbAccountTitle";
            this.cbAccountTitle.Size = new System.Drawing.Size(220, 22);
            this.cbAccountTitle.TabIndex = 9;
            // 
            // btnAddTitle
            // 
            this.btnAddTitle.Location = new System.Drawing.Point(466, 43);
            this.btnAddTitle.Name = "btnAddTitle";
            this.btnAddTitle.Size = new System.Drawing.Size(81, 25);
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
            this.dgvAcctLoc.Location = new System.Drawing.Point(244, 73);
            this.dgvAcctLoc.Name = "dgvAcctLoc";
            this.dgvAcctLoc.RowHeadersVisible = false;
            this.dgvAcctLoc.Size = new System.Drawing.Size(769, 378);
            this.dgvAcctLoc.TabIndex = 0;
            // 
            // txtParticular
            // 
            this.txtParticular.Location = new System.Drawing.Point(105, 88);
            this.txtParticular.Multiline = true;
            this.txtParticular.Name = "txtParticular";
            this.txtParticular.Size = new System.Drawing.Size(294, 130);
            this.txtParticular.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Particular";
            // 
            // cbPayee
            // 
            this.cbPayee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayee.FormattingEnabled = true;
            this.cbPayee.Location = new System.Drawing.Point(105, 59);
            this.cbPayee.Name = "cbPayee";
            this.cbPayee.Size = new System.Drawing.Size(294, 22);
            this.cbPayee.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payee";
            // 
            // dtpLDate
            // 
            this.dtpLDate.CustomFormat = "MMM dd, yyyy";
            this.dtpLDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLDate.Location = new System.Drawing.Point(279, 31);
            this.dtpLDate.Name = "dtpLDate";
            this.dtpLDate.Size = new System.Drawing.Size(120, 22);
            this.dtpLDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // txtCVNo
            // 
            this.txtCVNo.Location = new System.Drawing.Point(105, 31);
            this.txtCVNo.Name = "txtCVNo";
            this.txtCVNo.Size = new System.Drawing.Size(100, 22);
            this.txtCVNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "CV No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Job Order Assignment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(569, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "Location";
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(572, 44);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(115, 22);
            this.cbLocation.TabIndex = 14;
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(690, 43);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(81, 25);
            this.btnAddLocation.TabIndex = 16;
            this.btnAddLocation.Text = "Add Location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAllLocation
            // 
            this.btnAllLocation.Location = new System.Drawing.Point(772, 43);
            this.btnAllLocation.Name = "btnAllLocation";
            this.btnAllLocation.Size = new System.Drawing.Size(81, 25);
            this.btnAllLocation.TabIndex = 18;
            this.btnAllLocation.Text = "All Location";
            this.btnAllLocation.UseVisualStyleBackColor = true;
            // 
            // btnAssignLocationJO
            // 
            this.btnAssignLocationJO.Location = new System.Drawing.Point(157, 43);
            this.btnAssignLocationJO.Name = "btnAssignLocationJO";
            this.btnAssignLocationJO.Size = new System.Drawing.Size(81, 25);
            this.btnAssignLocationJO.TabIndex = 19;
            this.btnAssignLocationJO.Text = "Assign";
            this.btnAssignLocationJO.UseVisualStyleBackColor = true;
            this.btnAssignLocationJO.Click += new System.EventHandler(this.btnAssignLocationJO_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 14);
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
            this.cbMonth.Location = new System.Drawing.Point(470, 27);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 22);
            this.cbMonth.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(600, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(635, 27);
            this.txtYear.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(77, 22);
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
            this.Column1.Width = 102;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Credit";
            this.Column2.HeaderText = "Credit";
            this.Column2.Name = "Column2";
            // 
            // lvJOAssign
            // 
            this.lvJOAssign.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvJOAssign.Location = new System.Drawing.Point(6, 73);
            this.lvJOAssign.Name = "lvJOAssign";
            this.lvJOAssign.Size = new System.Drawing.Size(232, 378);
            this.lvJOAssign.TabIndex = 20;
            this.lvJOAssign.UseCompatibleStateImageBehavior = false;
            this.lvJOAssign.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "JO ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Location";
            this.columnHeader2.Width = 128;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(427, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 14);
            this.label10.TabIndex = 13;
            this.label10.Text = "Bank";
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(501, 62);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(211, 22);
            this.txtBank.TabIndex = 14;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(501, 90);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(211, 22);
            this.txtAccountNo.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(427, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 14);
            this.label11.TabIndex = 15;
            this.label11.Text = "Account No.";
            // 
            // txtBranchNo
            // 
            this.txtBranchNo.Location = new System.Drawing.Point(501, 118);
            this.txtBranchNo.Name = "txtBranchNo";
            this.txtBranchNo.Size = new System.Drawing.Size(211, 22);
            this.txtBranchNo.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(427, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 14);
            this.label12.TabIndex = 17;
            this.label12.Text = "Branch";
            // 
            // txtCheckNo
            // 
            this.txtCheckNo.Location = new System.Drawing.Point(501, 145);
            this.txtCheckNo.Name = "txtCheckNo";
            this.txtCheckNo.Size = new System.Drawing.Size(211, 22);
            this.txtCheckNo.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(427, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 14);
            this.label13.TabIndex = 19;
            this.label13.Text = "Check No.";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 715);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcctLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpLDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCVNo;
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
        private System.Windows.Forms.Button btnAssignLocationJO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ListView lvJOAssign;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtCheckNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBranchNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label label10;
    }
}