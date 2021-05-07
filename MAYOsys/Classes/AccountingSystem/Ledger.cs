using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAYOsys.Classes.AccountingSystem
{
    public class Ledger
    {
        dbcontrol s = new dbcontrol();
        Convertion conv = new Convertion();
        public int      ID              { get; set; }
        public string   SalesNo         { get; set; }
        public string LDate           { get; set; }
        public string   Month           { get; set; }
        public string   Year            { get; set; }
        public string   Voucher         { get; set; }
        public string   Payee           { get; set; }
        public string   Customer        { get; set; }
        public string   Tenant          { get; set; }
        public string   Particular      { get; set; }
        public string   RefDoc          { get; set; }
        public DateTime DueDate         { get; set; }
        public DateTime BankDate        { get; set; }
        public string   Bank            { get; set; }
        public string   AccountNo       { get; set; }
        public string   Branch          { get; set; }
        public string   CheckNo         { get; set; }
        public string   Remarks         { get; set; }
        public string   Address         { get; set; }
        public string   TIN             { get; set; }
        public string   PONo            { get; set; }
        public decimal  Amount          { get; set; }
        public string   AmountInWord    { get; set; }
        public List<LedgerLocation> Location { get; set; }

        public Ledger()
        {

        }

        public Ledger(int ID, string SalesNo, string LDate, string Month, string Year, string Voucher, string Payee, string Customer, string Tenant, string Particular, string RefDoc, DateTime DueDate, DateTime BankDate, string Bank, string AccountNo, string Branch, string CheckNo, string Remarks, string Address, string TIN, string PONo, decimal Amount, string AmountInWord)
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
            this.Amount           =Amount        ;
           this.AmountInWord     =AmountInWord  ;
        }

        public Ledger(string SalesNo, string LDate, string Month, string Year, string Voucher, string Payee, string Customer, string Tenant, string Particular, string RefDoc, DateTime DueDate, DateTime BankDate, string Bank, string AccountNo, string Branch, string CheckNo, string Remarks, string Address, string TIN, string PONo, decimal Amount, string AmountInWord)
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
            this.Amount = Amount;
            this.AmountInWord = AmountInWord;
        }

        public Ledger FindLedger(int ID)
        {
            var item = new Ledger();
            s.Query("select ID,  SalesNo, CheckNo, LDate, [Month], [Year], Payee, Particular, (select AccountNo from tbl_bank as b where b.accountno = ckl.bank) AS AccountNo, Amount, AmountInWord, (select Bank from tbl_bank b where b.accountno = ckl.bank) as Bank,(select Branch from tbl_bank b where b.accountno = ckl.bank) as Branch from tbl_ckledger ckl where ID = @ID", p => p.Add("@ID", ID)).ForEach(r =>
            {
                item = new Ledger(r);
            });
            return item;
        }

        public Ledger(DataRow r)
        {
            ID = (int)r["ID"];
            SalesNo = r["SalesNo"].ToString();
            LDate = r["LDate"].ToString();
            Month = r["Month"].ToString();
            Year = r["Year"].ToString();
            //Voucher = r["Voucher"].ToString();
            Payee = r["Payee"].ToString();
            //Customer = r["Customer"].ToString();
            //Tenant = r["Tenant"].ToString();
            Particular = r["Particular"].ToString();
            //RefDoc = r["RefDoc"].ToString();
            //DueDate = (DateTime)r["DueDate"];
            //BankDate = (DateTime)r["BankDate"];
            Bank = r["Bank"].ToString();
            AccountNo = r["AccountNo"].ToString();
            Branch = r["Branch"].ToString();
            CheckNo = r["CheckNo"].ToString();
            //Remarks = r["Remarks"].ToString();
            //Address = r["Address"].ToString();
            //TIN = r["TIN"].ToString();
            //PONo = r["PONo"].ToString();
            Amount = (decimal)r["Amount"];
            AmountInWord = r["AmountInWord"].ToString();
        }
    }
}
