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
        public dbcontrol() : base(DatabaseType.OleDb, "provider=microsoft.ace.oledb.12.0;data source=|DataDirectory|MHCICV.mdb")
        {
            ErrorOccured += Dbcontrol_ErrorOccured;
        }

        private void Dbcontrol_ErrorOccured(ErrorMessage e)
        {
            System.Windows.Forms.MessageBox.Show(e.ExceptionMessage);
        }

        public dbcontrol(string connectionstring) : base(DatabaseType.OleDb, connectionstring)
        {

        }
    }
}
