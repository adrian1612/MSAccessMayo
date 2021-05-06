using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace MAYOsys.Classes.AccountingSystem
{
    class Voucher
    {
        public event EventHandler TriggerDetailInsert;

        DataTable dt = new DataTable();
        dbcontrol s = new dbcontrol();
        public Voucher()
        {
            var pri = new DataColumn("AccountTitle");
            dt.Columns.Add(pri);
            dt.Columns.Add(new DataColumn("Credit", typeof(decimal)));
            dt.PrimaryKey = new DataColumn[] { pri };
            s.ErrorOccured += S_ErrorOccured;
        }

        private void S_ErrorOccured(AAJdbController.ErrorMessage e)
        {
            MessageBox.Show(e.ExceptionMessage);
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


        int countInsert;
        public VoucherInfo Info(List<LocationJO> locationJO)
        {
            var info = new VoucherInfo();
            foreach (DataRow r in dt.Rows)
            {
                info.TotalAccountTitle++;
            }
            foreach (DataColumn c in dt.Columns)
            {
                if (c.ToString() != "AccountTitle")
                {
                    string tempLoc = "";
                    foreach (DataRow r in dt.Rows)
                    {
                        if (r[c] != DBNull.Value)
                        {
                            if (tempLoc != c.ToString())
                            {
                                countInsert++;
                                locationJO.ForEach(lj =>
                                {
                                    if (lj.Location == c.ToString())
                                    {
                                        countInsert++;
                                        info.TotalLocationJO++;
                                    }
                                });
                            }
                            tempLoc = c.ToString();
                            if (c.ToString() == "Credit")
                            {
                                countInsert++;
                                info.TotalCredit += (decimal)r[c];
                            }
                            else
                            {
                                countInsert++;
                                info.TotalDebit += (decimal)r[c];
                            }
                        }
                    }
                }
            }
            info.TotalInsert = countInsert;
            return info;
        }
        
        void triggerEvent()
        {
            TriggerDetailInsert?.Invoke(this, EventArgs.Empty);
        }


        public void InsertCheckDetail(int LedgerID, List<LocationJO> locationJO)
        {
            foreach (DataColumn c in dt.Columns)
            {
                if (c.ToString() != "AccountTitle")
                {
                    string tempLoc = "";
                    int LLID = 0;
                    foreach (DataRow r in dt.Rows)
                    {
                        if (r[c] != DBNull.Value)
                        {
                            if (tempLoc != c.ToString())
                            {
                                triggerEvent();
                                LLID = s.Insert("tbl_ckLedgerLocation", p =>
                                {
                                    p.Add("LID", LedgerID);
                                    p.Add("Location", c.ToString());
                                }, true);

                                locationJO.ForEach(lj =>
                                {
                                    if (lj.Location == c.ToString())
                                    {
                                        triggerEvent();
                                        s.Insert("tbl_ckLocationJO", p =>
                                        {
                                            p.Add("JOID", lj.JOID);
                                            p.Add("LLID", LLID);
                                        });
                                    }
                                });
                            }
                            tempLoc = c.ToString();
                            if (c.ToString() == "Credit")
                            {
                                triggerEvent();
                                s.Insert("tbl_ckAccountTitle", p =>
                                {
                                    p.Add("LLID", LLID);
                                    p.Add("LID", LedgerID);
                                    p.Add("AccountTitle", r["AccountTitle"]);
                                    p.Add("Debit", 0);
                                    p.Add("Credit", (decimal)r[c]);
                                });
                            }
                            else
                            {
                                triggerEvent();
                                s.Insert("tbl_ckAccountTitle", p =>
                                {
                                    p.Add("LLID", LLID);
                                    p.Add("LID", LedgerID);
                                    p.Add("AccountTitle", r["AccountTitle"]);
                                    p.Add("Debit", (decimal)r[c]);
                                    p.Add("Credit", 0);
                                });
                            }
                        }
                    }
                }
            }

            
        }

        public void InsertJournalDetail(int LedgerID, List<LocationJO> locationJO)
        {
            foreach (DataColumn c in dt.Columns)
            {
                if (c.ToString() != "AccountTitle")
                {
                    string tempLoc = "";
                    int LLID = 0;
                    foreach (DataRow r in dt.Rows)
                    {
                        if (r[c] != DBNull.Value)
                        {
                            if (tempLoc != c.ToString())
                            {
                                LLID = s.Insert("tbl_jvLedgerLocation", p =>
                                {
                                    p.Add("LID", LedgerID);
                                    p.Add("Location", c.ToString());
                                }, true);

                                locationJO.ForEach(lj =>
                                {
                                    if (lj.Location == c.ToString())
                                    {
                                        s.Insert("tbl_jvLocationJO", p =>
                                        {
                                            p.Add("JOID", lj.JOID);
                                            p.Add("LLID", LLID);
                                        });
                                    }
                                });
                            }
                            tempLoc = c.ToString();
                            if (c.ToString() == "Credit")
                            {
                                s.Insert("tbl_jvAccountTitle", p =>
                                {
                                    p.Add("LLID", LLID);
                                    p.Add("LID", LedgerID);
                                    p.Add("AccountTitle", r["AccountTitle"]);
                                    p.Add("Debit", 0);
                                    p.Add("Credit", (decimal)r[c]);
                                });
                            }
                            else
                            {
                                s.Insert("tbl_jvAccountTitle", p =>
                                {
                                    p.Add("LLID", LLID);
                                    p.Add("LID", LedgerID);
                                    p.Add("AccountTitle", r["AccountTitle"]);
                                    p.Add("Debit", (decimal)r[c]);
                                    p.Add("Credit", 0);
                                });
                            }
                        }
                    }
                }
            }


        }

        public DataTable Detail()
        {
            return dt;
        }
    }

}
