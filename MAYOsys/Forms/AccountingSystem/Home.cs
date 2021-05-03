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
    public partial class Home : Form
    {
        CheckVoucher cv = new CheckVoucher();
        public Home()
        {
            InitializeComponent();
            BindDetail();
        }

        void BindDetail()
        {
            dgvAcctLoc.DataSource = cv.Detail();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cv.AddValueToHeader("AccountTitle", cbAccountTitle.Text);
            BindDetail();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cv.AddLocation(cbLocation.Text);
            BindDetail();
        }

        private void btnAssignLocationJO_Click(object sender, EventArgs e)
        {
            var assign = new JobOrderAssignment(cv.Detail());
            assign.Entry += Assign_Entry;
            assign.ShowDialog();
        }

        List<LocationJO> listLocationJO = new List<LocationJO>();
        private void Assign_Entry(LocationJO jo)
        {
            listLocationJO.Add(jo);
            lvJOAssign.Items.Clear();
            listLocationJO.ForEach(llj =>
            {
                lvJOAssign.Items.Add(new ListViewItem(new string[] { llj.JOID.ToString(), llj.Location }));
            });
        }
    }
}
