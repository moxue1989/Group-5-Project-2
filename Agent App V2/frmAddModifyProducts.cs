using System;
using System.Windows.Forms;

namespace Agent_App_V2
{
    public partial class FrmAddModifyProducts : Form
    {
        public bool AddProducts; //Modify of edit Products

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
                product= new Product();
                AddProductsData(product);
            try
                {
                product.ProductId = ProductDB.AddProduct(product);
                DialogResult = DialogResult.OK;
                }

            catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else //Update Products
            {
                Product newProd = new Product();
                newProd.ProductId = product.ProductId;
                AddProductsData(newProd);
                try
                {
                    if (product == newProd)
                    {
                        MessageBox.Show(@"Another user has modifed or deleted this product.", @"Database Input Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                    product = newProd;
                    product.UpdateProd();
                    DialogResult = DialogResult.OK;
                    }
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }

        private void DisplayProduct()//Display product details
        {
            txtProdID.Text = product.ProductId.ToString();
            txtProdName.Text = product.ProdName;
        }

        private void AddProductsData(Product prod)//add data from controls to object
        {
            
            product.ProdName = txtProdName.Text;
        }

        public void ClearControls()//method to clear controls
        {
            txtProdID.Clear();
            txtProdName.Clear();
        }

        private void frmAddProducts_Load(object sender, EventArgs e)
        {
            if (AddProducts)
            {
                Text = @"Add Product";//name dialog form to Add Product
            }
            else
            {
                Text = @"Modify Product";//name dialog form to Modify Product
                DisplayProduct();
            }
        }
    }

    
}
