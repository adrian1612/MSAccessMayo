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
                if (s == "Insert")
                {
                    var insert = new Insert();
                    insert.ShowDialog();
                }
            }
        }
    }
}
