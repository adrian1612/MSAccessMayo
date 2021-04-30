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
        Convertion cv = new Convertion();
        public List<SalesDetail> Details = new List<SalesDetail>();
        decimal DetailsTotalAmount
        {
            get
            {
                decimal Total = 0;
                Details.ForEach(d => Total += d.Amount);
                return Total;
            }
        }

        public Insert()
        {
            InitializeComponent();
            notifyIcon1.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(10000, "Loading...", "Please wait\n\n-Adrian Jaspio", ToolTipIcon.Info);
            LoadCustomer();
            LoadEmployee();
        }

        void LoadEmployee()
        {
            var listAppr = new List<ComboBox>() { cbPreparedBy, cbApprovedBy, cbCheckedBy };
            listAppr.ForEach(appr =>
            {
                appr.DataSource = emp.ListEmployee();
                appr.DisplayMember = "Fullname";
                appr.ValueMember = "Fullname";
                appr.SelectedIndex = 1;
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

        async void UpdateCustomerFields()
        {
            await Task.Run(() =>
            {
                var cust = c.FindCustomer(cbCustomer.SelectedValue.ToString());
                txtAddress.Text = cust.Address;
                txtTIN.Text = cust.TIN;
                txtBusinessStyle.Text = cust.BusinessStyle;
                txtTerms.Text = cust.Terms;
            });
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
            Details.Add(s);
            txtAmountInWord.Text = cv.changeCurrencyToWords((double)DetailsTotalAmount);
            txtTotal.Text = DetailsTotalAmount.ToString();

            lvParticular.Items.Clear();
            Details.ForEach(d =>
            {
                lvParticular.Items.Add(new ListViewItem(new string[] { d.Particular, d.Amount.ToString() }));
            });
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var Confirm = MessageBox.Show("Are you sure you want to save this Data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Confirm == DialogResult.Yes)
            {
                if (Details.Count <= 0)
                {
                    MessageBox.Show("Particular can not be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                sale.Insert(new Sales(Convert.ToInt32(txtSalesNo.Text), cbCategory.Text, c.FindCustomer(cbCustomer.SelectedValue.ToString()), dtpDate.Text, txtPONo.Text, txtAmountInWord.Text, txtPayableTo.Text, cbPreparedBy.Text, cbCheckedBy.Text, cbApprovedBy.Text, Details));
                MessageBox.Show("Done!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EmployeeCB(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            if (cb.Text == "-New Employee-")
            {
                var newEmp = new AddEmployee();
                newEmp.NewEmployee += NewEmp_NewEmployee;
                newEmp.ShowDialog();
            }
        }

        private void NewEmp_NewEmployee(Employee e)
        {
            LoadEmployee();
        }
    }
}
