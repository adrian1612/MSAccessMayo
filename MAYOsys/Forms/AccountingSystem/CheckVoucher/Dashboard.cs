using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAYOsys.Forms.AccountingSystem.CheckVoucher
{
    public partial class Dashboard : Form
    {
        dbcontrol s = new dbcontrol();
        public Dashboard()
        {
            InitializeComponent();
            LoadData();
        }

        DataTable data;
        void SetPMax(int value)
        {
            tsProgressbar.Value = 0;
            tsProgressbar.Maximum = value * 10;
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            SetPMax(4);
            var cv = new Home();
            cv.ProgressBarStep += Cv_ProgressBarStep;
            cv.MdiParent = this.MdiParent;
            cv.Show();
            tsProgressbar.Value = 0;
        }

        private void Cv_ProgressBarStep()
        {
            tsProgressbar.PerformStep();
        }

        void LoadData()
        {
            data = s.Table("qryLoadCVLedger", null, CommandType.StoredProcedure);
            dgvCVDashboard.DataSource = data;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchRecord(txtSearch.Text);
        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
            
        }

        void SearchRecord(string search = "")
        {
            DataTable mydata = (DataTable)dgvCVDashboard.DataSource;
            string filter = "";
            foreach (DataColumn c in data.Columns)
            {
                if (c.DataType != typeof(int) && c.DataType != typeof(decimal))
                {
                    filter += $" [{c}] like '%{search}%' or ";
                }
                else
                {
                    filter += $" [{c}] = '{search}' or ";
                }
            }
            mydata.DefaultView.RowFilter = filter.Substring(0, filter.Length - 3);
        }
    }
}
