namespace MSAccessMayo
{
    partial class ORCRForm
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
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpODate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReceivedFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTIN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalesNo = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.txtORNo = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtORNo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtORNo);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSalesNo);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTIN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtReceivedFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpODate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "OR",
            "CR"});
            this.cbCategory.Location = new System.Drawing.Point(98, 36);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(238, 21);
            this.cbCategory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "OR No:";
            // 
            // dtpODate
            // 
            this.dtpODate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpODate.Location = new System.Drawing.Point(98, 89);
            this.dtpODate.Name = "dtpODate";
            this.dtpODate.Size = new System.Drawing.Size(238, 20);
            this.dtpODate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // txtReceivedFrom
            // 
            this.txtReceivedFrom.Location = new System.Drawing.Point(98, 115);
            this.txtReceivedFrom.Name = "txtReceivedFrom";
            this.txtReceivedFrom.Size = new System.Drawing.Size(238, 20);
            this.txtReceivedFrom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Received From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "TIN";
            // 
            // txtTIN
            // 
            this.txtTIN.Location = new System.Drawing.Point(98, 141);
            this.txtTIN.Name = "txtTIN";
            this.txtTIN.Size = new System.Drawing.Size(238, 20);
            this.txtTIN.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(98, 167);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(238, 20);
            this.txtAddress.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sales No:";
            // 
            // txtSalesNo
            // 
            this.txtSalesNo.Location = new System.Drawing.Point(98, 193);
            this.txtSalesNo.Name = "txtSalesNo";
            this.txtSalesNo.Size = new System.Drawing.Size(238, 20);
            this.txtSalesNo.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(98, 245);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.DecimalPlaces = 2;
            this.txtAmount.Location = new System.Drawing.Point(98, 219);
            this.txtAmount.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(238, 20);
            this.txtAmount.TabIndex = 15;
            // 
            // txtORNo
            // 
            this.txtORNo.Location = new System.Drawing.Point(98, 63);
            this.txtORNo.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtORNo.Name = "txtORNo";
            this.txtORNo.Size = new System.Drawing.Size(238, 20);
            this.txtORNo.TabIndex = 16;
            // 
            // ORCRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 305);
            this.Controls.Add(this.groupBox1);
            this.Name = "ORCRForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OR / CR Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ORCRForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtORNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpODate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReceivedFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalesNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTIN;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtORNo;
    }
}