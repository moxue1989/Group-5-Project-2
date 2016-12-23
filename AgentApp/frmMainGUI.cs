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
            try
            {
                using (FrmProducts prod = new FrmProducts())
                {
                    prod.ShowDialog(this);
                }
            }
            catch (DataException)
            {
                MessageBox.Show(@"Cancel/Save Data before viewing other records. Try Again.", @"User Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString());
            }
        }

        //Add/Edit Suppliers
        private void navSuppAddEdit_Click(object sender, EventArgs e)
        {

            FrmSuppliers supp = new FrmSuppliers();
           
                //using (FrmSuppliers supp = new FrmSuppliers())
                //{
                    supp.ShowDialog(this);
                //}
           
            //catch (DataException)
            //{
            //    MessageBox.Show(@"Cancel/Save Data before viewing other records. Try Again.", @"User Input Error",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString());
            //}
        }

        private void navProdSuppAddEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmProdSupp prodsupp = new FrmProdSupp())
                {
                    prodsupp.ShowDialog(this);
                }
            }
            catch (DataException)
            {
                MessageBox.Show(@"Cancel/Save Data before viewing other records. Try Again.", @"User Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString());
            }
        }

        private void navPkgAddEdit_Click(object sender, EventArgs e)
        {
            try
            {

                using (FrmPackages pkg = new FrmPackages())
                {
                    pkg.ShowDialog(this);
                }
            }
            catch (DataException)
            {

                MessageBox.Show(@"Cancel/Save Data before viewing other records. Try Again.", @"User Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString());
            }
        }
       
    }
}
