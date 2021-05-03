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
            var pri = new DataColumn("AccountTitle");
            dt.Columns.Add(pri);
            dt.Columns.Add(new DataColumn("Credit", typeof(decimal)));
            dt.PrimaryKey = new DataColumn[] { pri };
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
            if (!dt.Rows.Contains(Value))
            {
                dt.Rows.Add(dr);
            }
        }

        public DataTable Detail()
        {
            return dt;
        }
    }
}
