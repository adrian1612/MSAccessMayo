using MAYOsys.Classes.AccountingSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAYOsys.Forms.AccountingSystem
{
    public partial class JobOrderAssignment : Form
    {
        public delegate void LocationDelegate(LocationJO jo);
        public event LocationDelegate Entry;

        public JobOrderAssignment()
        {
            InitializeComponent();
        }

        private DataTable table = new DataTable();
        public JobOrderAssignment(DataTable location)
        {
            table = location;
            InitializeComponent();
            foreach (DataColumn c in table.Columns)
            {
                if (c.ToString() != "AccountTitle" && c.ToString() != "Credit")
                {
                    cbLocation.Items.Add(c.ToString());
                }
            }
            cbLocation.SelectedIndex = cbLocation.Items.Count <= 0 ? -1 : 0;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var item = new LocationJO(cbJOID.Text, cbLocation.Text);
            Entry?.Invoke(item);
        }
    }
}
