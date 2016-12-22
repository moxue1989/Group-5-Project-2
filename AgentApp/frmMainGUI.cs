﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgentApp
{
    public partial class FrmMainGui : Form
    {
        public FrmMainGui()
        {
            InitializeComponent();
        }

        private void packagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                packagesBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(travelExpertsDataSet);
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show(@"Input error ", @"Data Error");
                packagesBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString());
            }
            
        }
        private void frmMainGUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Packages' table. You can move, or remove it, as needed.
            packagesTableAdapter.Fill(travelExpertsDataSet.Packages);
        }
        
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtPkgId.Enabled = true;
            txtpkgBasePrice.Enabled = true;
            txtpkgCommission.Enabled = true;
            txtPkgDesc.Enabled = true;
            txtPkgName.Enabled = true;
            dpPkgEndDate.Enabled = true;
            dpPkgStartDate.Enabled = true;
            dpPkgStartDate.Value = DateTime.Now;
            dpPkgEndDate.Value = DateTime.Now.AddDays(10);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"This record will be permanently deleted.", @"Delete", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }
        private void navProdAddEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using(FrmProducts prod = new FrmProducts())
                prod.ShowDialog(this);
            }
           
            catch (NoNullAllowedException)
            {
                MessageBox.Show(@"Cancel/Save data before viewing records. Try Again.", @"Data Error");
                suppliersBindingSource.CancelEdit();

            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show(@"Another user is currently using this table. Data entered was not updated.", @"Concurrent Error");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString());
            }
        }

        private void navSuppAddEdit_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (FrmSuppliers supp = new FrmSuppliers())
                {
                    supp.ShowDialog(this);
                }
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show(@"Cancel/Save data before viewing records. Try Again.", @"Data Error");
                suppliersBindingSource.CancelEdit(); //cancels the edit command
            }
            
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number + @": " + @"is required.", @"Data Entry Error");
            }

        }

        private void navProdSuppAddEdit_Click(object sender, EventArgs e)
        {
            using (FrmProdSupp prodsupp = new FrmProdSupp())
            {
                prodsupp.ShowDialog(this);
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.packagesBindingSource.CancelEdit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            tableAdapterManager.UpdateAll(travelExpertsDataSet);//update and refresh dataset
        }
    }
}