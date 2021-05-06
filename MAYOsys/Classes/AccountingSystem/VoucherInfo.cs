using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAYOsys.Classes.AccountingSystem
{
    public class VoucherInfo
    {
        public int TotalAccountTitle { get; set; }
        public decimal TotalDebit { get; set; }
        public int TotalLocationJO { get; set; }
        public decimal TotalCredit { get; set; }
        public decimal Balance { get { return TotalDebit - TotalCredit; } }
        public int TotalInsert { get; set; }
        public VoucherInfo()
        {

        }
        public VoucherInfo(int TotalAccountTitle, decimal TotalDebit, int TotalLocationJO)
        {
            this.TotalAccountTitle = TotalAccountTitle;
            this.TotalDebit = TotalDebit;
            this.TotalLocationJO = TotalLocationJO;
        }
    }
}
