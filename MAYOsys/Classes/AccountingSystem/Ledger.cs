using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAYOsys.Classes.AccountingSystem
{
    class Ledger
    {
        public int      ID          { get; set; }
        public string   SalesNo     { get; set; }
        public DateTime LDate       { get; set; }
        public string   Month       { get; set; }
        public string   Year        { get; set; }
        public string   Voucher     { get; set; }
        public string   Payee       { get; set; }
        public string   Customer    { get; set; }
        public string   Tenant      { get; set; }
        public string   Particular  { get; set; }
        public string   RefDoc      { get; set; }
        public DateTime DueDate     { get; set; }
        public DateTime BankDate    { get; set; }
        public string   Bank        { get; set; }
        public string   AccountNo   { get; set; }
        public string   Branch      { get; set; }
        public string   CheckNo     { get; set; }
        public string   Remarks     { get; set; }
        public string   Address     { get; set; }
        public string   TIN         { get; set; }
        public string   PONo        { get; set; }

		public Ledger()
        {

        }

        public Ledger(int ID, string SalesNo, DateTime LDate, string Month, string Year, string Voucher, string Payee, string Customer, string Tenant, string Particular, string RefDoc, DateTime DueDate, DateTime BankDate, string Bank, string AccountNo, string Branch, string CheckNo, string Remarks, string Address, string TIN, string PONo)
        {
            this.ID = ID;
            this.SalesNo = SalesNo;
            this.LDate = LDate;
            this.Month = Month;
            this.Year = Year;
            this.Voucher = Voucher;
            this.Payee = Payee;
            this.Customer = Customer;
            this.Tenant = Tenant;
            this.Particular = Particular;
            this.RefDoc = RefDoc;
            this.DueDate = DueDate;
            this.BankDate = BankDate;
            this.Bank = Bank;
            this.AccountNo = AccountNo;
            this.Branch = Branch;
            this.CheckNo = CheckNo;
            this.Remarks = Remarks;
            this.Address = Address;
            this.TIN = TIN;
            this.PONo = PONo;
        }

        public Ledger(string SalesNo, DateTime LDate, string Month, string Year, string Voucher, string Payee, string Customer, string Tenant, string Particular, string RefDoc, DateTime DueDate, DateTime BankDate, string Bank, string AccountNo, string Branch, string CheckNo, string Remarks, string Address, string TIN, string PONo)
        {
            this.SalesNo = SalesNo;
            this.LDate = LDate;
            this.Month = Month;
            this.Year = Year;
            this.Voucher = Voucher;
            this.Payee = Payee;
            this.Customer = Customer;
            this.Tenant = Tenant;
            this.Particular = Particular;
            this.RefDoc = RefDoc;
            this.DueDate = DueDate;
            this.BankDate = BankDate;
            this.Bank = Bank;
            this.AccountNo = AccountNo;
            this.Branch = Branch;
            this.CheckNo = CheckNo;
            this.Remarks = Remarks;
            this.Address = Address;
            this.TIN = TIN;
            this.PONo = PONo;
        }

		public Ledger(DataRow r)
		{
			ID = (int)r["ID"];
			SalesNo = r["SalesNo"].ToString();
			LDate = (DateTime)r["LDate"];
			Month = r["Month"].ToString();
			Year = r["Year"].ToString();
			Voucher = r["Voucher"].ToString();
			Payee = r["Payee"].ToString();
			Customer = r["Customer"].ToString();
			Tenant = r["Tenant"].ToString();
			Particular = r["Particular"].ToString();
			RefDoc = r["RefDoc"].ToString();
			DueDate = (DateTime)r["DueDate"];
			BankDate = (DateTime)r["BankDate"];
			Bank = r["Bank"].ToString();
			AccountNo = r["AccountNo"].ToString();
			Branch = r["Branch"].ToString();
			CheckNo = r["CheckNo"].ToString();
			Remarks = r["Remarks"].ToString();
			Address = r["Address"].ToString();
			TIN = r["TIN"].ToString();
			PONo = r["PONo"].ToString();
		}
    }
}
