﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentApp
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                tableAdapterManager.UpdateAll(travelExpertsDataSet);
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show(@"Fields must contain information. ", @"Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                productsBindingSource.CancelEdit(); //cancels the edit command
            }
            catch (SqlException ex)
            {
                MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString());
            }
        }
        
        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                productsBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(travelExpertsDataSet);
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show(@"A error occurred. " + @"Some rows were not updated.", @"Concurrency Exception");
                productsTableAdapter.Fill(travelExpertsDataSet.Products); //populate textboxes with existing records
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                productsBindingSource.CancelEdit(); //cancels the edit command
            }
            catch (SqlException ex)
            {
                MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString());
            }
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
        }
        
    }
}
