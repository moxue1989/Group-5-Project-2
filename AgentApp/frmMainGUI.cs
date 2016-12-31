using System;
using System.Windows.Forms;

//coded by Kasi Emmanuel

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

        //launch Products form
        private void navProdAddEdit_Click(object sender, EventArgs e)
        {
            using (FrmProducts prod = new FrmProducts())
            {
                prod.ShowDialog(this);
            }
        }

        //launch Suppliers form
        private void navSuppAddEdit_Click(object sender, EventArgs e)
        {
            using (FrmSuppliers supp = new FrmSuppliers())
            {
                supp.ShowDialog(this);
            }
        }

        //launch Product Suppliers form
        private void navProdSuppAddEdit_Click(object sender, EventArgs e)
        {
            using (FrmProdSupp prodsupp = new FrmProdSupp())
            {
                prodsupp.ShowDialog(this);
            }
        }

        //launch packages form
        private void navPkgAddEdit_Click(object sender, EventArgs e)
        {
            using (FrmPackages pkg = new FrmPackages())
            {
                pkg.ShowDialog(this);
            }
        }
       
    }
}
