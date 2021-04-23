using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSAccessMayo
{
    public partial class ORCRForm : Form
    {
        ORCR orcr = new ORCR();
        public ORCRForm()
        {
            InitializeComponent();
        }

        private void ORCRForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Already reviewed the field?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                orcr.Insert(new ORCR(cbCategory.Text, (int)txtORNo.Value, dtpODate.Text, txtReceivedFrom.Text, txtTIN.Text, txtAddress.Text, txtAmount.Value, txtSalesNo.Text));
                MessageBox.Show("Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
