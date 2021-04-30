using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAYOsys.Classes.AccountingSystem
{
	class LedgerLocation
	{
		public int		ID			{ get; set; }
		public int		LID			{ get; set; }
		public int		JOID		{ get; set; }
		public string	Location	{ get; set; }

		public LedgerLocation()
		{

		}

		public LedgerLocation(int ID, int LID, int JOID, string Location)
		{
			this.ID			 = ID		;
			this.LID			 = LID		;
			this.JOID		 = JOID		;
			this.Location = Location;
		}

		public LedgerLocation(int LID, int JOID, string Location)
		{
			this.LID = LID;
			this.JOID = JOID;
			this.Location = Location;
		}

		public LedgerLocation(DataRow r)
		{
			ID = (int)r["ID"];
			LID = (int)r["LID"];
			JOID = (int)r["JOID"];
			Location = r["Location"].ToString();
		}
	}
}
