using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace MSAccessMayo
{
    public class P : Dictionary<string,object>
    {
        public int RecordCount { get; set; }
        public string Exception { get; set; }
        public bool HasException { get { return !string.IsNullOrEmpty(Exception); } }
        public OleDbDataAdapter da { get; set; }
        public DataTable dt { get; set; }
    }
    public class dbcontrol : P
    {
        OleDbConnection cn = new OleDbConnection(ConfigurationManager.ConnectionStrings["access"].ConnectionString);
        OleDbCommand cm;
        List<OleDbParameter> param = new List<OleDbParameter>();
        int LastID;

        public dbcontrol()
        {

        }

        public dbcontrol(string connectionstring)
        {
            cn = new OleDbConnection(connectionstring);
        }

        void q(string command, CommandType _type, bool returnID = false)
        {
            RecordCount = 0;
            Exception = null;
            try
            {
                cn.Open();
                cm = new OleDbCommand(command, cn);
                cm.CommandType = _type;
                param.ForEach(p => cm.Parameters.Add(p));
                param.Clear();
                da = new OleDbDataAdapter(cm);
                RecordCount = da.Fill(dt = new DataTable());
                if (returnID)
                {
                    cm = new OleDbCommand("SELECT @@IDENTITY AS LastID", cn);
                    da = new OleDbDataAdapter(cm);
                    da.Fill(dt = new DataTable());
                    dt.AsEnumerable().ToList().ForEach(r =>
                    {
                        LastID = (int)r[0];
                    });
                }
            }
            catch (Exception e)
            {
                Exception = $"Error : {e.Message}";
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            if (HasException)
            {
                System.Windows.Forms.MessageBox.Show(Exception, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        void p(string Name, object Value)
        {
            param.Add(new OleDbParameter(Name, Value));
        }

        public DataTable Query(string Command, Action<P> _data = null, CommandType _type = CommandType.Text, bool returnID = false)
        {
            if (_data != null)
            {
                P data = new P();
                _data(data);
                foreach (KeyValuePair<string,object> d in data)
                {
                    p(d.Key, d.Value);
                }
            }
            q(Command, _type, returnID);
            return dt;
        }

        public int Insert(string Table, Action<P> _data, bool returnID = false)
        {
            string Column = "", Value = "";
            P data = new P();
            _data(data);
            foreach (KeyValuePair<string,object> d in data)
            {
                Column += $"[{d.Key}],";
                Value += $"@{d.Key},";
            }
            Query($"INSERT INTO {Table} ({Column.Substring(0, Column.Length - 1)}) VALUES ({Value.Substring(0, Value.Length - 1)})", _data, CommandType.Text, returnID);
            return LastID;
        }

        public void Update(string Table, int ID, Action<P> _data)
        {
            string ColVal = "";
            P data = new P();
            _data(data);
            foreach (KeyValuePair<string, object> d in data)
            {
                ColVal += $"[{d.Key}]=@{d.Key},";
            }
            Query($"UPDATE {Table} SET {ColVal.Substring(0, ColVal.Length - 1)} WHERE ID = @ID", p => { _data(p); p.Add("@ID", ID); });
        }
    }
}
