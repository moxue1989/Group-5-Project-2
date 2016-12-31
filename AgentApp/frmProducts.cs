using System;
using System.Collections.Generic;
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
        const int MinValue = 0; // Minimum Value for ID
        public FrmProducts()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    Validate();
                    productsBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(travelExpertsDataSet);
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show(@"A error occurred. " + @"Some rows were not updated.", @"Concurrency Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    productsTableAdapter.Fill(travelExpertsDataSet.Products); //populate textboxes with existing records
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
                catch (DataException)
                {
                    MessageBox.Show(@"Fields must contain information. ", @"Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    productsBindingSource.CancelEdit(); //cancels the edit command
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show(@"A error occurred. " + @"Some rows were not updated.", @"Concurrency Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    productsTableAdapter.Fill(travelExpertsDataSet.Products); //populate textboxes with existing records
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'travelExpertsDataSet.Products' table. You can move, or remove it, as needed.
                this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            }
            catch (DataException)
            {
                MessageBox.Show(@"aaaaaaaaa. ", @"Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                productsBindingSource.CancelEdit(); //cancels the edit command
            }
            catch (SqlException ex)
            {
                MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            productsBindingSource.CancelEdit(); //Cancel Add/Edit Operations
            Close();//close form
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            productsBindingSource.CancelEdit();
            eProducts.SetError(txtProductId, null);
            eProducts.SetError(txtProdName, null);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"This record will be permanently deleted.", @"Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            eProducts.Clear();
        }
        //binding validator class to textbox fields
        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtProductId) &&
                Validator.IsInt(txtProductId, MinValue) &&
                //Validator.IsPositiveNum(txtProductId, MinValue) &&
                Validator.IsPresent(txtProdName);
        }

        private void bNavMovePrev_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                productsBindingSource?.MovePrevious();//if all textbox data are valid, move to previous record
            }
        }

        private void bNavMoveNext_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                productsBindingSource?.MoveNext();//if all textbox data are valid, move to next record
            }
        }

        private void bNavMoveLast_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                productsBindingSource?.MoveLast();//if all textbox data are valid, move to last record
            }
        }

        private void bNavMoveFirst_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                productsBindingSource?.MoveFirst();//if all textbox data are valid, move to first record
            }
        }
    }
}
