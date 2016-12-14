using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentApp
{
    public partial class frmGUI : Form
    {
        public frmGUI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string table = "Packages";
            DataSet data = DatabaseAccess.GetData(table);
            dgTest.DataSource = data;
            dgTest.DataMember = table;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string table = "Products";
            DataSet data = DatabaseAccess.GetData(table);
            dgTest.DataSource = data;
            dgTest.DataMember = table;
        }
    }
}
