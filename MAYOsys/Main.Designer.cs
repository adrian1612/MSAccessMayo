namespace MAYOsys
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.checkVoucherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountingSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkVoucherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.journalVoucherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProgressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkVoucherToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1248, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // checkVoucherToolStripMenuItem
            // 
            this.checkVoucherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountingSystemToolStripMenuItem});
            this.checkVoucherToolStripMenuItem.Name = "checkVoucherToolStripMenuItem";
            this.checkVoucherToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.checkVoucherToolStripMenuItem.Text = "Menu";
            // 
            // accountingSystemToolStripMenuItem
            // 
            this.accountingSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkVoucherToolStripMenuItem1,
            this.journalVoucherToolStripMenuItem});
            this.accountingSystemToolStripMenuItem.Name = "accountingSystemToolStripMenuItem";
            this.accountingSystemToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.accountingSystemToolStripMenuItem.Text = "Accounting System";
            // 
            // checkVoucherToolStripMenuItem1
            // 
            this.checkVoucherToolStripMenuItem1.Name = "checkVoucherToolStripMenuItem1";
            this.checkVoucherToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.checkVoucherToolStripMenuItem1.Text = "Check Voucher";
            this.checkVoucherToolStripMenuItem1.Click += new System.EventHandler(this.checkVoucherToolStripMenuItem1_Click);
            // 
            // journalVoucherToolStripMenuItem
            // 
            this.journalVoucherToolStripMenuItem.Name = "journalVoucherToolStripMenuItem";
            this.journalVoucherToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.journalVoucherToolStripMenuItem.Text = "Journal Voucher";
            this.journalVoucherToolStripMenuItem.Click += new System.EventHandler(this.journalVoucherToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgressbar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 719);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1248, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsProgressbar
            // 
            this.tsProgressbar.Name = "tsProgressbar";
            this.tsProgressbar.Size = new System.Drawing.Size(200, 16);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 741);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAYO System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem checkVoucherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountingSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkVoucherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem journalVoucherToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tsProgressbar;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

