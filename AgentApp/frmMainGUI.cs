using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AgentApp.TravelExpertsDataSetTableAdapters;

namespace AgentApp
{
    public partial class FrmMainGui : Form
    {
        public FrmMainGui()
        {
            InitializeComponent();
        }
        
        private void frmMainGUI_Load(object sender, EventArgs e)
        {
            
        }

        //Add/Edit Products
        private void navProdAddEdit_Click(object sender, EventArgs e)
        {
            using (FrmProducts prod = new FrmProducts())
            {
                prod.ShowDialog(this);
            }
        }

        //Add/Edit Suppliers
        private void navSuppAddEdit_Click(object sender, EventArgs e)
        {
            using (FrmSuppliers supp = new FrmSuppliers())
            {
                supp.ShowDialog(this);
            }
        }

        private void navProdSuppAddEdit_Click(object sender, EventArgs e)
        {
            using (FrmProdSupp prodsupp = new FrmProdSupp())
            {
                prodsupp.ShowDialog(this);
            }
        }

        private void navPkgAddEdit_Click(object sender, EventArgs e)
        {
            using (FrmPackages pkg = new FrmPackages())
            {
                pkg.ShowDialog(this);
            }
        }
       
    }
}
