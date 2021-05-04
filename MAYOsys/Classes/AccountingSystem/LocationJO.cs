using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAYOsys.Classes.AccountingSystem
{
    public class LocationJO
    {
        public int      ID          { get; set; }
        public string      JOID        { get; set; }
        public int      LLID        { get; set; }
        public string   Location    { get; set; }

        public LocationJO()
        {

        }

        public LocationJO(int ID, string JOID, int LLID, string Location)
        {
            this.ID         = ID           ;
            this.JOID       = JOID         ;
            this.LLID       = LLID         ;
            this.Location = Location;
        }

        public LocationJO(string JOID, int LLID, string Location)
        {
            this.JOID = JOID;
            this.LLID = LLID;
            this.Location = Location;
        }

        public LocationJO(string JOID, string Location)
        {
            this.JOID = JOID;
            this.Location = Location;
        }

        public LocationJO(DataRow r)
        {
           ID =       (int)r["ID"];
           JOID =     r["JOID"].ToString();
           LLID =     (int)r["LLID"];
           Location = r["Location"].ToString();
        }


    }
}
