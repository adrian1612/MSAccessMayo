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
    public partial class AddEmployee : Form
    {
        public delegate void Emp(Employee e);
        public event Emp NewEmployee;
        Employee emp = new Employee();

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Are you sure you wan't to add this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                emp.Insert(new Employee(txtEmpID.Text, txtFullname.Text, txtPosition.Text));
                MessageBox.Show("Employee Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewEmployee?.Invoke(emp);
                Close();
            }
        }

        private void AddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void AddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
