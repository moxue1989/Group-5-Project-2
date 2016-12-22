﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgentApp
{
    public partial class FrmSuppliers : Form
    {
        public FrmSuppliers()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            suppliersTableAdapter.Fill(travelExpertsDataSet.Suppliers); //populate textboxes with existing records

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.CancelEdit(); //cancels the edit command
        }

        private void suppliersbindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    Validate();
                    suppliersBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(travelExpertsDataSet);
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show(@"A error occurred. " + @"Some rows were not updated.", @"Concurrency Exception");
                    suppliersTableAdapter.Fill(travelExpertsDataSet.Suppliers); //populate textboxes with existing records
                }
                catch (DataException ex)
                {
                    //MessageBox.Show(ex.Message, ex.GetType().ToString());
                    MessageBox.Show(@"Product ID is required.", @"Data Entry Error");
                    suppliersBindingSource.CancelEdit(); //cancels the edit command
                }
            }
            else
            {
                try
                {
                    tableAdapterManager.UpdateAll(travelExpertsDataSet);
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show(@"A error occurred. " + @"Some rows were not updated.", @"Concurrency Exception");
                    suppliersTableAdapter.Fill(travelExpertsDataSet.Suppliers); //populate textboxes with existing records
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Number + @": " + @"is required.", @"Data Entry Error");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); //closes products form
        }

        private void suppliersbindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                tableAdapterManager.UpdateAll(travelExpertsDataSet);
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show(@"Fields must contain information. ", @"Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                suppliersBindingSource.CancelEdit(); //cancels the edit command
            }
            catch (SqlException ex)
            {
                MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString());
            }
        }
        private bool IsValidData()//Call the Validator Method
        {
            return
                Validator.IsPresent(txtSupplierId) &&
                Validator.IsPresent(txtSupName);
        }
    }
}
