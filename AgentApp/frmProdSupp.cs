using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgentApp
{
    public partial class FrmProdSupp : Form
    {
        const int MinValue = 0; // Minimum Value for ID

        public FrmProdSupp()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void products_SuppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    Validate();
                    products_SuppliersBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(travelExpertsDataSet);
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show(@"A error occurred. " + @"Some rows were not updated.", @"Concurrency Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    products_SuppliersTableAdapter.Fill(travelExpertsDataSet.Products_Suppliers); //populate textboxes with existing records
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(@"A error occurred. " + @"Some rows were not updated.", @"Concurrency Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    products_SuppliersTableAdapter.Fill(travelExpertsDataSet.Products_Suppliers); //populate textboxes with existing records
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmProdSupp_Load(object sender, EventArgs e)
        {
            try
            {
                products_SuppliersTableAdapter.Fill(travelExpertsDataSet.Products_Suppliers);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            products_SuppliersBindingSource.CancelEdit();//cancels the edit command
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            products_SuppliersBindingSource.CancelEdit();
            Close();//closes products form
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"This record will be permanently deleted.", @"Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtProdId) &&
                Validator.IsPositiveNum(txtProdId, MinValue) &&
                Validator.IsPresent(txtProdSupp) &&
                Validator.IsPositiveNum(txtProdSupp, MinValue) &&
                Validator.IsPresent(txtSuppId) &&
                Validator.IsPositiveNum(txtSuppId, MinValue);
        }
    }
}
