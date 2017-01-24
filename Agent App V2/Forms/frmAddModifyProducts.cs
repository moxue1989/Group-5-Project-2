using System;
using System.Windows.Forms;

namespace Agent_App_V2
{
    public partial class FrmAddModifyProducts : Form
    {
        public bool AddProducts; //Modify of edit Products
        private bool saveStatus = false;
        public Product product = new Product();// object of product data

        public FrmAddModifyProducts()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Add Products 
            if (AddProducts)
            {
                if (IsValid())
                {
                    Product newProd = new Product();
                    newProd.ProdName = txtProdName.Text;
                    saveStatus = true;
                    try
                    {
                        ProductDB.AddProduct(newProd);
                        DialogResult = DialogResult.OK;
                    }

                    catch (Exception ex)

                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                
            }

            else //Update Products
            {
                if (IsValid())
                {
                    product.ProdName = txtProdName.Text;
                    saveStatus = true;
                    try
                    {
                        product.UpdateProd();
                        DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                
            }
        }

        private void DisplayProduct()//Display product details
        {
            txtProdName.Text = product.ProdName;
        }


        public void ClearControls()//method to clear controls
        {
            txtProdName.Clear();
        }

        private void frmAddProducts_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtProdName;
            if (AddProducts)
            {
                lblForm.Text = @"Add Product - Travel Experts Inc.";//name dialog form to Add Product
            }
            else
            {
                lblForm.Text = @"Modify Product - Travel Experts Inc.";//name dialog form to Modify Product
                DisplayProduct();
            }
        }

        private bool IsValid()
        {
            return
                Validator.IsPresent(txtProdName);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmAddModifyProducts_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!saveStatus)
            {
                // make sure user wants to exit
                if (
                    MessageBox.Show("Exit without saving changes?", "Cancel", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Exclamation) != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }
    }

    
}
