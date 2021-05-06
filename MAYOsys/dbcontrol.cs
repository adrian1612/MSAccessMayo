using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAJdbController;
using System.Configuration;

namespace MAYOsys
{
    public class dbcontrol : AAJControl
    {
        public dbcontrol() : base(DatabaseType.OleDb, ConfigurationManager.ConnectionStrings["mayosys"].ConnectionString)
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
