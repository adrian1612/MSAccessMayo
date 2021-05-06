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
            SetPMax(4);
            var cv = new Forms.AccountingSystem.Home();
            cv.ProgressBarStep += Cv_ProgressBarStep1;
            cv.MdiParent = this;
            cv.Show();
        }

        private void Cv_ProgressBarStep1()
        {
            tsProgressbar.PerformStep();
        }


        private void journalVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPMax(5);
            var jv = new Forms.AccountingSystem.JournalVoucher.Home();
            jv.ProgressBarStep += Cv_ProgressBarStep1;
            jv.MdiParent = this;
            jv.Show();
        }


    }
}
