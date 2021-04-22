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
    public partial class Insert : Form
    {
        Customers c = new Customers();
        Employee emp = new Employee();
        Sales sale = new Sales();

        public Insert()
        {
            InitializeComponent();
            notifyIcon1.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(5000, "Message", "Please wait -Adrian Jaspio", ToolTipIcon.Info);

            LoadCustomer();

            var listAppr = new List<ComboBox>() { cbPreparedBy, cbApprovedBy, cbCheckedBy };
            listAppr.ForEach(appr =>
            {
                appr.DataSource = emp.ListEmployee();
                appr.DisplayMember = "Fullname";
                appr.ValueMember = "Fullname";
            });
        }

        void LoadCustomer()
        {
            cbCustomer.DataSource = c.ListCustomer();
            cbCustomer.DisplayMember = "Display";
            cbCustomer.ValueMember = "Customer";
        }

        private void Insert_Load(object sender, EventArgs e)
        {
           
            UpdateCustomerFields();
            notifyIcon1.Visible = false;
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCustomerFields();
        }

        void UpdateCustomerFields()
        {
            var cust = c.FindCustomer(cbCustomer.SelectedValue.ToString());
            txtAddress.Text = cust.Address;
            txtTIN.Text = cust.TIN;
            txtBusinessStyle.Text = cust.BusinessStyle;
            txtTerms.Text = cust.Terms;
        }

        private void Insert_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnParticular_Click(object sender, EventArgs e)
        {
            var particular = new AddParticular();
            particular.NewParticular += Particular_NewParticular;
            particular.ShowDialog();
        }

        private void Particular_NewParticular(SalesDetail s)
        {
            sale.Details.Add(s);
            txtAmountInWord.Text = sale.changeCurrencyToWords((double)sale.ParticularTotalAmount);
            txtTotal.Text = sale.ParticularTotalAmount.ToString();

            lvParticular.Items.Clear();
            sale.Details.ForEach(d =>
            {
                lvParticular.Items.Add(new ListViewItem(new string[] { d.Particular, d.Amount.ToString() }));
            });
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var Confirm = MessageBox.Show("Are you sure you want to save this Data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Confirm == DialogResult.Yes)
            {
                if (sale.Details.Count <= 0)
                {
                    MessageBox.Show("Particular can not be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                sale.Insert(new Sales(Convert.ToInt32(txtSalesNo.Text), cbCategory.Text, cbCustomer.Text, txtAddress.Text,txtTIN.Text, txtBusinessStyle.Text, dtpDate.Text, txtTerms.Text, txtPONo.Text, txtAmountInWord.Text, txtPayableTo.Text, cbPreparedBy.Text, cbCheckedBy.Text, cbApprovedBy.Text));
                MessageBox.Show("Done!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
