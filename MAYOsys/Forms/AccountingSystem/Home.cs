using MAYOsys.Classes.AccountingSystem;
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

namespace MAYOsys.Forms.AccountingSystem
{
    public partial class Home : Form
    {
        CheckVoucher cv = new CheckVoucher();
        dbcontrol s = new dbcontrol();

        DataTable tblAccountTitle;
        DataTable tblLocation;
        DataTable tblPayee;
        public Home()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            LoadFieldInitialize();
            BindDetail();
        }

        async void LoadFieldInitialize()
        {
            await Task.Run(() =>
            {
                tblAccountTitle = s.Table("select AccountTitle from tblChartOfAccounts");
                tblLocation = s.Table("select Location from tblLocation");
                tblPayee = s.Table("select Payee from tblpayee");
                LoadField();
            });
        }

        void SetProgressBarMax(int Value)
        {
            tsProgressBar.Maximum = Value;
        }

        void LoadField()
        {
            SetProgressBarMax(3);
            cbAccountTitle.DataSource = tblAccountTitle;
            cbAccountTitle.DisplayMember = "AccountTitle";
            cbAccountTitle.ValueMember = "AccountTitle";
            tsProgressBar.PerformStep();
            cbLocation.DataSource = tblLocation;
            cbLocation.ValueMember = "Location";
            cbLocation.DisplayMember = "Location";
            tsProgressBar.PerformStep();
            cbPayee.DataSource = tblPayee;
            cbPayee.ValueMember = "Payee";
            cbPayee.DisplayMember = "Payee";
            tsProgressBar.PerformStep();
        }

        void BindDetail()
        {
            dgvAcctLoc.DataSource = cv.Detail();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cv.AddValueToHeader("AccountTitle", cbAccountTitle.Text);
            BindDetail();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cv.AddLocation(cbLocation.Text);
            BindDetail();
        }

        private void btnAssignLocationJO_Click(object sender, EventArgs e)
        {
            var assign = new JobOrderAssignment(cv.Detail());
            assign.Entry += Assign_Entry;
            assign.ShowDialog();
        }

        List<LocationJO> listLocationJO = new List<LocationJO>();
        private void Assign_Entry(LocationJO jo)
        {
            listLocationJO.Add(jo);
            lvJOAssign.Items.Clear();
            listLocationJO.ForEach(llj =>
            {
                lvJOAssign.Items.Add(new ListViewItem(new string[] { llj.JOID.ToString(), llj.Location }));
            });
        }

        private void btnAllLocation_Click(object sender, EventArgs e)
        {
            tsProgressBar.Value = 0;
            SetProgressBarMax(tblLocation.Rows.Count);
            foreach (DataRow r in tblLocation.Rows)
            {
                cv.AddLocation(r[0].ToString());
                tsProgressBar.PerformStep();
            }
            BindDetail();
        }

        void LoadAllLocation()
        {
            tsProgressBar.Value = 0;
            SetProgressBarMax(tblLocation.Rows.Count);
            foreach (DataRow r in tblLocation.Rows)
            {
                cv.AddLocation(r[0].ToString());
                tsProgressBar.PerformStep();
            }
            BindDetail();
        }
    }
}
