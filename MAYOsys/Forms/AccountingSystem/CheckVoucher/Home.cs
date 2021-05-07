using MAYOsys.Classes;
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

namespace MAYOsys.Forms.AccountingSystem
{
    public partial class Home : Form
    {
        public delegate void mytrigger();
        public event mytrigger ProgressBarStep;

        Voucher cv = new Voucher();
        dbcontrol s = new dbcontrol();

        DataTable tblAccountTitle;
        DataTable tblLocation;
        DataTable tblPayee;
        DataTable tblBank;
        void trigger()
        {
            ProgressBarStep?.Invoke();
        }

        public Home()
        {
            InitializeComponent();
            cv.TriggerDetailInsert += Cv_TriggerDetailInsert;
            
            CheckForIllegalCrossThreadCalls = false;
        }

        
        private void Home_Load_1(object sender, EventArgs e)
        {
            LoadFieldInitialize();
            cbMonth.SelectedIndex = 0;
            CheckForIllegalCrossThreadCalls = false;
            BindDetail();
        }

        void LoadFieldInitialize()
        {
            trigger();
            tblAccountTitle = s.Table("qryDisplayAccountTitle", null, CommandType.StoredProcedure);
            trigger();
            tblLocation = s.Table("qryDisplayLocation", null, CommandType.StoredProcedure);
            trigger();
            tblPayee = s.Table("qryDisplayPayee", null, CommandType.StoredProcedure);
            trigger();
            tblBank = s.Table("qryDisplayBankInfo", null, CommandType.StoredProcedure);
            trigger();
            LoadField();
            BindBankDetail();
        }

        void SetProgressBarMax(int Value)
        {
            tsProgressBar.Value = 0;
            tsProgressBar.Maximum = Value;
        }

        void LoadField()
        {
            var listtable = new List<DataTable> { tblAccountTitle, tblLocation, tblPayee, tblBank };
            var listCB = new List<ComboBox> { cbAccountTitle, cbLocation, cbPayee, cbBank };
            var liststr = new Dictionary<string, string> { { "AccountTitle", "AccountTitle" }, { "Location", "Location" }, { "Payee", "Payee" }, { "Display", "AccountNo" } };
            int i = 0;
            foreach (KeyValuePair<string, string> str in liststr)
            {
                listCB[i].DataSource = listtable[i];
                listCB[i].ValueMember = str.Value;
                listCB[i].DisplayMember = str.Key;
                i++;
            }
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

        private void Cv_TriggerDetailInsert(object sender, EventArgs e)
        {
            tsProgressBar.PerformStep();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cv.Detail().Rows.Count <= 0 || string.IsNullOrEmpty(txtParticular.Text) || string.IsNullOrEmpty(txtCheckNo.Text))
            {
                MessageBox.Show("Problem Occur\n\n1) You haven't added any Location and Account Title value yet\n2) Particular field is empty!\n3) Check No. is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SetProgressBarMax(summary.TotalInsert);
            int LastLedgerID = 0;
            s.Query("select max(id) from tbl_ckledger").ForEach(r =>
            {
                LastLedgerID = r[0] == DBNull.Value ? 1 : (int)r[0] + 1;
            }); 
            var LID =  s.Insert("tbl_CKLedger", p =>
            {
                var cvFormat = Convert.ToDateTime(dtpLDate.Text);
                p.Add("SalesNo", $"{cvFormat:yy}{cvFormat:MM}{LastLedgerID}");
                p.Add("LDate", DateTime.Parse(dtpLDate.Text));
                p.Add("Month", cbMonth.Text);
                p.Add("Year", txtYear.Value);
                p.Add("Payee", cbPayee.Text);
                p.Add("Particular", txtParticular.Text);
                p.Add("Bank", cbBank.SelectedValue.ToString());
                p.Add("CheckNo", txtCheckNo.Text);
                p.Add("Amount", txtAmount.Text);
                p.Add("AmountInWord", txtAmountInWord.Text);
            }, true); 
            cv.InsertCheckDetail(LID, listLocationJO);
            MessageBox.Show("Done");
        }

        void BindBankDetail()
        {
            txtAccountNo.DataBindings.Add("text", tblBank, "AccountNo");
            txtBranchNo.DataBindings.Add("text", tblBank, "Branch");
        }

        VoucherInfo summary;
        void SummaryInfo()
        {
            summary = cv.Info(listLocationJO);
            label1.Text = $"No. of Account Title : {summary.TotalAccountTitle}\nTotal Debit : {summary.TotalDebit:c2}\nTotal Credit : {summary.TotalCredit:c2}\nBalance : {summary.Balance:c2}\nNo. of Location J.O. : {summary.TotalLocationJO}";
        }

        private void dgvAcctLoc_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            SummaryInfo();
        }

        private void dgvAcctLoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dgvAcctLoc_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewCell r in dgvAcctLoc.SelectedCells)
            {
                if (r.OwningColumn.HeaderText == "Credit" && e.Button == MouseButtons.Right && !string.IsNullOrEmpty(r.Value.ToString()))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
           
        }

        Convertion conv = new Convertion();
        private void btnSetAmount_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell r in dgvAcctLoc.SelectedCells)
            {
                if (r.OwningColumn.HeaderText == "Credit")
                {
                    txtAmountInWord.Text = $"{conv.changeCurrencyToWords(Convert.ToDouble(r.Value))}";
                    txtAmount.Text = $"{r.Value}";
                }
            }
        }
    }
}
