using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAYOsys.Classes.AccountingSystem
{
	class AccountTitle
	{
		public int		ID				{ get; set; }
		public int		LLID			{ get; set; }
		public int		LID				{ get; set; }
		public string	Accounttitle	{ get; set; }
		public decimal	Debit			{ get; set; }
		public decimal	Credit			{ get; set; }

		public AccountTitle()
		{

		}

		public AccountTitle(int ID, int LLID, int LID, string Accounttitle, decimal Debit, decimal Credit)
		{
			this.ID = ID;
			this.LLID = LLID;
			this.LID = LID;
			this.Accounttitle = Accounttitle;
			this.Debit = Debit;
			this.Credit = Credit;
		}

		public AccountTitle(int LLID, int LID, string Accounttitle, decimal Debit, decimal Credit)
		{
			this.LLID = LLID;
			this.LID = LID;
			this.Accounttitle = Accounttitle;
			this.Debit = Debit;
			this.Credit = Credit;
		}

        public AccountTitle(DataRow r)
        {
            ID = (int)r["ID"];
            LLID = (int)r["LLID"];
            LID = (int)r["LID"];
            Accounttitle = r["Accounttitle"].ToString();
            Debit = (decimal)r["Debit"];
            Credit = (decimal)r["Credit"];
        }
	}
}
