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
        CheckVoucher cv = new CheckVoucher();
        dbcontrol s = new dbcontrol();
        dbcontrol mys = new dbcontrol("provider=microsoft.ace.oledb.12.0;data source=|DataDirectory|MHCICV.mdb");

        DataTable tblAccountTitle;
        DataTable tblLocation;
        DataTable tblPayee;
        DataTable tblBank;

        public Home()
        {
            InitializeComponent();
            LoadFieldInitialize();
            CheckForIllegalCrossThreadCalls = false;
            BindDetail();
        }

        void LoadFieldInitialize()
        {
            tblAccountTitle = s.Table("select AccountTitle from tblChartOfAccounts where accounttitle <> '' order by accounttitle asc");
            tblLocation = s.Table("select Location from tblLocation order by location asc");
            tblPayee = s.Table("select Payee from tblpayee order by payee asc");
            tblBank = mys.Table("select [Bank] + ' | ' + [AccountNo] AS Display,* from tbl_Bank order by Bank asc");
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
            cbPayee.DataSource = tblPayee;
            cbPayee.ValueMember = "Payee";
            cbPayee.DisplayMember = "Payee";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            int LastLedgerID = 0;
            mys.Query("select max(id) from tbl_ledger").ForEach(r =>
            {
                LastLedgerID = r[0] == DBNull.Value ? 1 : (int)r[0] + 1;
            });
            var LID =  mys.Insert("tbl_Ledger", p =>
            {
                var cvFormat = Convert.ToDateTime(dtpLDate.Text);
                p.Add("SalesNo", $"{cvFormat:yy}{cvFormat:MM}{LastLedgerID}");
                p.Add("LDate", DateTime.Parse(dtpLDate.Text));
                p.Add("Month", cbMonth.Text);
                p.Add("Year", txtYear.Value);
                p.Add("Payee", cbPayee.Text);
                p.Add("Particular", txtParticular.Text);
            }, true); 
            cv.InsertDetail(LID, cv.Detail(), listLocationJO);
            MessageBox.Show("Done");
        }
    }
}
