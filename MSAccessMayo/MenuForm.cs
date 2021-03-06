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
    public partial class MenuForm : Form
    {
        public MenuForm(string[] arg)
        {
            InitializeComponent();
            Hide();
            foreach (string s in arg)
            {
                switch (s)
                {
                    case "Insert":
                        var insert = new Insert();
                        insert.ShowDialog();
                        break;
                    case "CreateORCR":
                        var ORCR = new ORCRForm();
                        ORCR.ShowDialog();
                        break;
                    case "ORCRSearch":
                        var orcrsearch = new ORCRSearch();
                        orcrsearch.ShowDialog();
                        break;
                    default:
                        MessageBox.Show("Command Not Found\n-Adrian Jaspio", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            MessageBox.Show("Invalid Action\n\nContact Adrian Jaspio to resolved this issue", "Developer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Environment.Exit(0);
        }
    }
}
