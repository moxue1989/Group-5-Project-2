using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agent_App_V2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var packageForm = new frmPackages();
            packageForm.ShowDialog();
        }

        private void btnProductSuppliers_Click(object sender, EventArgs e)
        {
            var frmSuppliers = new frmSuppliers();
            frmSuppliers.ShowDialog();
        }
    }
}
