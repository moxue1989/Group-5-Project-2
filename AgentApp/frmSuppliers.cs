using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgentApp
{
    public partial class FrmSuppliers : Form
    {
        const int MinValue = 0; // Minimum Value for ID
        public FrmSuppliers()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            try
            {
                suppliersTableAdapter.Fill(travelExpertsDataSet.Suppliers); //populate textboxes with existing records
            }
            catch (SqlException ex)
            {
                MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.CancelEdit(); //cancels the edit command
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
                catch (SqlException ex)
                {
                    MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString());
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
                    MessageBox.Show(@"A error occurred. " + @"Some rows were not updated.", @"Concurrency Exception Error");
                    suppliersTableAdapter.Fill(travelExpertsDataSet.Suppliers); //populate textboxes with existing records
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.CancelEdit(); //cancels the edit command
            Close(); //closes products form
        }

        //binding validator class to textbox fields
        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtSupplierId) &&
                Validator.IsInt(txtSupplierId)&&
                Validator.IsPositiveNum(txtSupplierId, MinValue)&& 
                Validator.IsPresent(txtSupName);
        }
    }
}
