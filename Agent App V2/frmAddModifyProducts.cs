using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agent_App_V2
{
    public partial class frmAddModifyProducts : Form
    {
        public bool addProducts; //Modify of edit Products

        public Product product = new Product();// object of product data
        private List<Product> prodList;

        public frmAddModifyProducts()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Add Products 
            if (addProducts)
            {
                product= new Product();
                this.AddProductsData(product);
                //try
                //{
                       
                    product.ProductId = ProductDB.AddProduct(product);
                    this.DialogResult = DialogResult.OK;
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, ex.GetType().ToString());
                //}
            }
            else //Update 
            {
                Product newProd = new Product();
                newProd.ProductId = product.ProductId;
                AddProductsData(newProd);
                //try
                //{
                    if (product == newProd)
                    {
                        MessageBox.Show(@"Another user has updated or " +
                            @"deleted that customer.", @"Database Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                      
                    }
                    else
                    {
                    product = newProd;
                    //prodList.Add(product);
                    product.UpdateProd();
                        this.DialogResult = DialogResult.OK;
                    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, ex.GetType().ToString());
                //}
            }
            
        }

        private void DisplayProduct()
        {
            txtProdID.Text = product.ProductId.ToString();
            txtProdName.Text = product.ProdName;
        }

        private void AddProductsData(Product product)
        {
            //product.ProductId = Convert.ToInt32(txtProdID.Text);
            product.ProdName = txtProdName.Text;
        }

        public void ClearControls()
        {
            txtProdID.Clear();
            txtProdName.Clear();
        }
        private void frmAddProducts_Load(object sender, EventArgs e)
        {
            if (addProducts)
            {
                this.Text = "Add Product";
            }
            else
            {
                this.Text = "Modify Product";
                this.DisplayProduct();
            }
        }
    }

    
}
