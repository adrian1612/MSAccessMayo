using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAJdbController;
namespace MAYOsys
{
    public class dbcontrol : AAJControl
    {
        public dbcontrol() : base(DatabaseType.OleDb, "PROVIDER=MICROSOFT.ACE.OLEDB.12.0;DATA SOURCE=|DataDirectory|MAYO - IAS v.4-020321.mdb")
        {

        }

        public dbcontrol(string connectionstring) : base(DatabaseType.OleDb, connectionstring)
        {

        }
    }
}
