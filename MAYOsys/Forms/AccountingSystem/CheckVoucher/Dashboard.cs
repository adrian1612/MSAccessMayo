using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAYOsys.Forms.AccountingSystem.CheckVoucher
{
    public partial class Dashboard : Form
    {
        public event EventHandler TriggerLoading;
        void trigger()
        {
            TriggerLoading?.Invoke(this, EventArgs.Empty);
        }
        dbcontrol s = new dbcontrol();
        public Dashboard()
        {
            InitializeComponent();
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
            cv.DoneInsert += Cv_DoneInsert;
            cv.ProgressBarStep += Cv_ProgressBarStep;
            cv.MdiParent = this.MdiParent;
            cv.Show();
            tsProgressbar.Value = 0;
        }

        private void Cv_DoneInsert(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Cv_ProgressBarStep()
        {
            tsProgressbar.PerformStep();
        }

        void LoadData(string search = "")
        {
            data = s.Table("qryLoadCVLedger", p => p.Add("@search", $"%{search}%"), CommandType.StoredProcedure);
            dgvCVDashboard.Columns.Clear();
            dgvCVDashboard.DataSource = null;
            foreach (DataColumn c in data.Columns)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.DataPropertyName = c.ToString();
                if (c.ToString().ToLower() == "id")
                {
                    col.Visible = false;
                }
                col.HeaderText = c.ToString();
                col.Name = c.ToString();
                if (c.DataType == typeof(decimal))
                {
                    col.DefaultCellStyle = new DataGridViewCellStyle { Format = "c2", WrapMode = DataGridViewTriState.True };
                }
                dgvCVDashboard.Columns.Add(col);
            }
            dgvCVDashboard.DataSource = data;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
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
                else if (c.DataType == typeof(int) && c.DataType == typeof(decimal))
                {
                    filter += $" [{c}] = '{search}' or ";
                }
                else if (c.DataType == typeof(DateTime))
                {
                    filter += $" [{c}] between '{search}' and '{search}' or ";
                }
            }
            mydata.DefaultView.RowFilter = filter.Substring(0, filter.Length - 3);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchRecord(txtSearch.Text);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvCVDashboard.SelectedRows)
            {
                if (r.Selected)
                {
                    var details = new Details((int)r.Cells[0].Value);
                    details.MdiParent = MdiParent;
                    details.Show();
                }
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            trigger();
            LoadData();
        }
    }
}
