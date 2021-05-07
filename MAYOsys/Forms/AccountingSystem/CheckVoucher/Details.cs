using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAYOsys.Classes.AccountingSystem;
using Microsoft.Reporting.WinForms;

namespace MAYOsys.Forms.AccountingSystem.CheckVoucher
{
    public partial class Details : Form
    {
        AccountTitle acc = new AccountTitle();
        dbcontrol s = new dbcontrol();
        int ID;
        public Details(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void Details_Load(object sender, EventArgs e)
        {
            var table = s.Table("select AccountTitle, sum(debit) as debit, sum(credit) as credit from tbl_ckaccounttitle where LID = @LID group by accounttitle order by sum(debit) desc, sum(credit) asc", p => p.Add("@LID", ID));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", table));
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.RefreshReport();
        }
    }
}
