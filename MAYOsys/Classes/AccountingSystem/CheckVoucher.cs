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
            dt.Columns.Add(new DataColumn("Credit", typeof(decimal)));
            //dt.Columns.Add(new DataColumn("Quezon"));
            //dt.Columns.Add(new DataColumn("SM MOA"));
            //dt.Columns.Add(new DataColumn("SM Bicol"));
            //dt.Columns.Add(new DataColumn("Madison"));
        }

        public void AddLocation(string Header)
        {
            if (!dt.Columns.Contains(Header))
            {
                dt.Columns.Add(new DataColumn(Header, typeof(decimal)));
            }
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
