using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace MAYOsys.Classes.AccountingSystem
{
    class CheckVoucher
    {
        DataTable dt = new DataTable();

        public CheckVoucher()
        {
            dt.Columns.Add(new DataColumn("AccountTitle"));
            dt.Columns.Add(new DataColumn("Quezon"));
            dt.Columns.Add(new DataColumn("MOA"));
            dt.Columns.Add(new DataColumn("SMBicol"));
            dt.Columns.Add(new DataColumn("Credit"));
        }

       
        public void AddValueToHeader(string Header, string Value)
        {
            DataRow dr = dt.NewRow();
            dr[dt.Columns.IndexOf(Header)] = Value;
            dt.Rows.Add(dr);
        }

        public DataTable Detail()
        {
            return dt;
        }
    }
}
