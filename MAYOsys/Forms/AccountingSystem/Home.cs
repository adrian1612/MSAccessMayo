﻿using MAYOsys.Classes.AccountingSystem;
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
        dbcontrol mys = new dbcontrol("provider=microsoft.ace.oledb.12.0;data source=|DataDirectory|MHCICV.mdb");

        DataTable tblAccountTitle;
        DataTable tblLocation;
        DataTable tblPayee;

        public Home()
        {
            LoadFieldInitialize();
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            BindDetail();
        }

        async void LoadFieldInitialize()
        {
            await Task.Run(() =>
            {
                tblAccountTitle = s.Table("select AccountTitle from tblChartOfAccounts where accounttitle <> ''");
                tblLocation = s.Table("select Location from tblLocation");
                tblPayee = s.Table("select Payee from tblpayee");
            });
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
            mys.Insert("tbl_Ledger", p =>
            {
                p.Add("SalesNo", txtCVNo.Text);
                p.Add("LDate", DateTime.Parse(dtpLDate.Text));
                p.Add("LMonth", cbMonth.Text);
                p.Add("LYear", txtYear.Value);
                p.Add("Payee", cbPayee.Text);
                p.Add("Particular", txtParticular.Text);
                p.Add("Bank", txtBank.Text);
                p.Add("AccountNo", txtAccountNo.Text);
                p.Add("CheckNo", txtCheckNo.Text);
                p.Add("Branch", txtBranchNo.Text);
            }, true);
            if (mys.HasException)
            {
                MessageBox.Show(mys.Exception);
            }
            var LID = mys.GetLastID;
            cv.InsertDetail(LID, cv.Detail(), listLocationJO);
            MessageBox.Show("Done");
        }


        private void LoadCB(object sender, EventArgs e)
        {
            LoadField();
        }
    }
}
