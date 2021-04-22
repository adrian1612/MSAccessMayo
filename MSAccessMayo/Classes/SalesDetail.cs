using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAccessMayo
{
    public class SalesDetail
    {
        public int ID { get; set; }
        public int RecordID { get; set; }
        public string Particular { get; set; }
        public decimal Amount { get; set; }

        public SalesDetail()
        {

        }

        public SalesDetail(int ID, int RecordID, string Particular, decimal Amount)
        {
            this.ID = ID;
            this.RecordID = RecordID;
            this.Particular = Particular;
            this.Amount = Amount;
        }

        public SalesDetail(int RecordID, string Particular, decimal Amount)
        {
            this.RecordID   = RecordID;
            this.Particular = Particular;
            this.Amount     = Amount;
        }

        public SalesDetail(string Particular, decimal Amount)
        {
            this.Particular = Particular;
            this.Amount = Amount;
        }

        public SalesDetail(DataRow r)
        {
            ID = (int)r["ID"];
            RecordID = (int)r["RecordID"];
            Particular = r["Particular"].ToString();
            Amount = (decimal)r["Amount"];
        }

    }
}
