using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAYOsys
{
    public class SummaryReport
    {
        public string AccountTitle { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }

        public SummaryReport()
        {

        }

        public SummaryReport(string AccountTitle, decimal Debit, decimal Credit)
        {
            this.AccountTitle = AccountTitle;
            this.Debit = Debit;
            this.Credit = Credit;
        }

        public List<SummaryReport> Summary(int ID)
        {
            var list = new List<SummaryReport>();

            return list;
        }
    }

}