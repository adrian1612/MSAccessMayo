﻿using MAYOsys.Classes.AccountingSystem;
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
            dataGridView1.DataSource = cv.Detail();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cv.AddValueToHeader("AccountTitle", comboBox2.Text);
            BindDetail();
        }
    }
}
