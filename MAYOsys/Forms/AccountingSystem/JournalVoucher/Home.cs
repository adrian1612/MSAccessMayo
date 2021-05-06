using MAYOsys.Classes.AccountingSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAYOsys.Forms.AccountingSystem.JournalVoucher
{
    public partial class Home : Form
    {

        public delegate void mytrigger();
        public event mytrigger ProgressBarStep;

        Voucher cv = new Voucher();
        dbcontrol s = new dbcontrol();

        DataTable tblAccountTitle;
        DataTable tblLocation;
        DataTable tblCVCheckNo;

        void trigger()
        {
            ProgressBarStep?.Invoke();
        }
        public Home()
        {
            InitializeComponent();
        }

        void LoadFieldInitialize()
        {
            trigger();
            tblAccountTitle = s.Table("qryDisplayAccountTitle", null, CommandType.StoredProcedure);
            trigger();
            tblLocation = s.Table("qryDisplayLocation", null, CommandType.StoredProcedure);
            trigger();
            tblCVCheckNo = s.Table("qryListOfCVCheckNo", null, CommandType.StoredProcedure);
            LoadField();
        }

        void SetProgressBarMax(int Value)
        {
            tsProgressBar.Value = 0;
            tsProgressBar.Maximum = Value;
        }

        void LoadField()
        {
            cbAccountTitle.DataSource = tblAccountTitle;
            cbAccountTitle.DisplayMember = "AccountTitle";
            cbAccountTitle.ValueMember = "AccountTitle";
            cbLocation.DataSource = tblLocation;
            cbLocation.ValueMember = "Location";
            cbLocation.DisplayMember = "Location";
            cbcheckno.DataSource = tblCVCheckNo;
            cbcheckno.ValueMember = "CheckNo";
            cbcheckno.DisplayMember = "CheckNo";
        }

        void BindDetail()
        {
            dgvAcctLoc.DataSource = cv.Detail();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cv.AddValueToHeader("AccountTitle", cbAccountTitle.Text);
            SummaryInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cv.AddLocation(cbLocation.Text);
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
            SummaryInfo();
            lvJOAssign.Items.Clear();
            listLocationJO.ForEach(llj =>
            {
                lvJOAssign.Items.Add(new ListViewItem(new string[] { llj.JOID.ToString(), llj.Location }));
            });
        }

        private void btnAllLocation_Click(object sender, EventArgs e)
        {
            LoadAllLocation();
        }


        void LoadAllLocation()
        {
            SetProgressBarMax(tblLocation.Rows.Count);
            foreach (DataRow r in tblLocation.Rows)
            {
                cv.AddLocation(r[0].ToString());
                tsProgressBar.PerformStep();
            }
            tsProgressBar.Value = 0;
        }


        void SummaryInfo()
        {
            VoucherInfo summary;
            summary = cv.Info(listLocationJO);
            label3.Text = $"No. of Account Title : {summary.TotalAccountTitle}\nTotal Debit : {summary.TotalDebit:c2}\nTotal Credit : {summary.TotalCredit:c2}\nBalance : {summary.Balance:c2}\nNo. of Location J.O. : {summary.TotalLocationJO}";
        }

        private void dgvAcctLoc_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            SummaryInfo();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cv.Detail().Rows.Count <= 0 || string.IsNullOrEmpty(txtParticular.Text))
            {
                MessageBox.Show("Problem Occur\n\n1) You haven't added any Location and Account Title value yet\n2) Particular field is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int LastLedgerID = 0;
            s.Query("select max(id) from tbl_jvledger").ForEach(r =>
            {
                LastLedgerID = r[0] == DBNull.Value ? 1 : (int)r[0] + 1;
            });
            var LID = s.Insert("tbl_jvLedger", p =>
            {
                var cvFormat = Convert.ToDateTime(dtpLDate.Text);
                p.Add("SalesNo", $"{cvFormat:yy}{cvFormat:MM}{LastLedgerID}");
                p.Add("LDate", DateTime.Parse(dtpLDate.Text));
                p.Add("Month", cbMonth.Text);
                p.Add("Year", txtYear.Value);
                p.Add("Particular", txtParticular.Text);
                p.Add("CheckNo", cbcheckno.Text);
            }, true);
            cv.InsertJournalDetail(LID, listLocationJO);
            MessageBox.Show("Done");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            trigger();
            LoadFieldInitialize();
            trigger();
            cbMonth.SelectedIndex = 0;
            trigger();
            CheckForIllegalCrossThreadCalls = false;
            BindDetail();
        }
    }
}

