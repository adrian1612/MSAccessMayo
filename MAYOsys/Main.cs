using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAYOsys
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        void SetPMax(int value)
        {
            tsProgressbar.Value = 0;
            tsProgressbar.Maximum = value * 10;
        }

        private void checkVoucherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //SetPMax(4);
            //var cv = new Forms.AccountingSystem.Home();
            //cv.ProgressBarStep += Cv_ProgressBarStep1;
            //cv.MdiParent = this;
            //cv.Show();
            //tsProgressbar.Value = 0;
            SetPMax(1);
            var cvDashboard = new Forms.AccountingSystem.CheckVoucher.Dashboard();
            cvDashboard.TriggerLoading += CvDashboard_TriggerLoading;
            cvDashboard.MdiParent = this;
            cvDashboard.Show();
            tsProgressbar.Value = 0;
        }

        private void CvDashboard_TriggerLoading(object sender, EventArgs e)
        {
            tsProgressbar.PerformStep();
        }

        private void journalVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPMax(5);
            var jv = new Forms.AccountingSystem.JournalVoucher.Home();
           
            jv.MdiParent = this;
            jv.Show();
            tsProgressbar.Value = 0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer : Adrian A. Jaspio\nPosition : Computer Programmer\nCompany : Mayo Holdings Constraction Company Inc.\n\n© 2021", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
