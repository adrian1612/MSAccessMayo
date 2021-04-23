using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAccessMayo
{
    public class ORCR
    {
        dbcontrol s = new dbcontrol();
        public int ID { get; set; }
        public string Category { get; set; }
        public int ORNo { get; set; }
        public string ODate { get; set; }
        public string ReceiveFrom { get; set; }
        public string TIN { get; set; }
        public string Address { get; set; }
        public decimal Amount { get; set; }
        public string SalesNo { get; set; }

        public ORCR()
        {

        }

        public ORCR(int ID, string Category, int ORNo, string ODate, string ReceiveFrom, string TIN, string Address, decimal Amount, string SalesNo)
        {
            this.ID = ID;
            this.Category = Category;
            this.ORNo = ORNo;
            this.ODate = ODate;
            this.ReceiveFrom = ReceiveFrom;
            this.TIN = TIN;
            this.Address = Address;
            this.Amount = Amount;
            this.SalesNo = SalesNo;
        }

        public ORCR(string Category, int ORNo, string ODate, string ReceiveFrom, string TIN, string Address, decimal Amount, string SalesNo)
        {
            this.Category = Category;
            this.ORNo = ORNo;
            this.ODate = ODate;
            this.ReceiveFrom = ReceiveFrom;
            this.TIN = TIN;
            this.Address = Address;
            this.Amount = Amount;
            this.SalesNo = SalesNo;
        }

        public ORCR(DataRow r)
        {
            ID = (int)r["ID"];
            Category = r["Category"].ToString();
            ORNo = (int)r["ORNo"];
            ODate = r["ODate"].ToString();
            ReceiveFrom = r["ReceiveFrom"].ToString();
            TIN = r["TIN"].ToString();
            Address = r["Address"].ToString();
            Amount = (decimal)r["Amount"];
            SalesNo = r["SalesNo"].ToString();
        }

        public List<ORCR> ListORCR(string Search = "")
        {
            var list = new List<ORCR>();
            s.Query("select * from tbl_OR WHERE str(ORNo) Like @search", p => p.Add("@search", $"%{Search}%")).AsEnumerable().ToList().ForEach(r =>
            {
                list.Add(new ORCR(r));
            });
            return list;
        }

        public void Insert(ORCR or)
        {
            s.Insert("tbl_OR", p =>
            {
                p.Add("Category", or.Category);
                p.Add("ORNo", or.ORNo);
                p.Add("ODate", or.ODate);
                p.Add("ReceiveFrom", or.ReceiveFrom);
                p.Add("TIN", or.TIN);
                p.Add("Address", or.Address);
                p.Add("Amount", or.Amount);
                p.Add("SalesNo", or.SalesNo);
            });
        }
    }
}
