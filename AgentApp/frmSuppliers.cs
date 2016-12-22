using System;
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
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                suppliersBindingSource.CancelEdit(); //cancels the edit command
            }
            catch (SqlException ex)
            {
                MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString());
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close(); //closes products form
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
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
    }
}
