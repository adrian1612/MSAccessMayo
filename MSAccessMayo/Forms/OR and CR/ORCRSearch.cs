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
    public partial class ORCRSearch : Form
    {
        dbcontrol s = new dbcontrol();
        ORCR orcr = new ORCR();
        public ORCRSearch()
        {
            InitializeComponent();
            LoadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadData(textBox1.Text);
        }

        void LoadData(string search = "")
        {
            dataGridView1.DataSource = s.Query("select * from tbl_OR WHERE ORNo Like @search or Category like @search or salesno like @search or address like @search or TIN like @search", p => p.Add("@search", $"%{search}%"));
        }

        private void ORCRSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
