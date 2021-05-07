using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MAYOsys.Classes.AccountingSystem
{
	public class LedgerLocation
	{
        dbcontrol s = new dbcontrol();
		public int		ID			{ get; set; }
		public int		LID			{ get; set; }
		public string	Location	{ get; set; }
        public List<AccountTitle> AccountTitles { get; set; }

        public LedgerLocation()
		{

		}

		public LedgerLocation(int ID, int LID, int JOID, string Location)
		{
			this.ID			 = ID		;
			this.LID			 = LID		;
			this.Location = Location;
		}

		public LedgerLocation(int LID, int JOID, string Location)
		{
			this.LID = LID;
			this.Location = Location;
		}

        public List<LedgerLocation> ListLocation(int ID)
        {
            var list = new List<LedgerLocation>();
            s.Query("select * from tbl_ckledgerLocation where ID = @ID", p => p.Add("@ID", ID)).ForEach(r => 
            {
                list.Add(new LedgerLocation(r));
            });
            return list;
        }

		public LedgerLocation(DataRow r)
		{
			ID = (int)r["ID"];
			LID = (int)r["LID"];
			Location = r["Location"].ToString();
		}
	}
}
