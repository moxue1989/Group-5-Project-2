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
    public partial class frmSuppliers : Form
    {
        public frmSuppliers()
        {
            InitializeComponent();
        }
        //Product prod = new Product();
        List<Product> suppList;
        List<Product> productsList;
        private Supplier currentSupp = new Supplier();
        //List<Product> addProdList;
        //private List<Product> newProdList;
        private Product currentProd = new Product() ;
        

        


        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            cbProducts.DataSource = ProductsSuppliersDB.GetSuppliers();
            cbProducts.DisplayMember = "SupName";
            cbProducts.ValueMember = "SupplierId";
            
            Supplier obj = cbProducts.SelectedItem as Supplier;

            if (obj != null)
            {

                GetSuppliersProducts(obj.SupplierId);
                dataGridProdSupp.DataSource = suppList;
                dataGridNotInSupp.DataSource = productsList;
            }

            //lvProd.View = View.Details;
            
            //foreach (Product p in prodSupp)
            //{
               
            //    ListViewItem item = new ListViewItem(p.ProductId.ToString());
            //    item.SubItems.Add(p.ProdName);
                
            //    //Add Items
            //    lvProd.Items.Add(item);//Add user input in List View
            //}
            
        }

        private void GetSuppliersProducts(int supplierId)
        {
            try
            {
                suppList = ProductsSuppliersDB.GetProductSuppBySuppID(supplierId);
                productsList = ProductsSuppliersDB.GetProductNotInProdSuppBySuppID(supplierId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void cbProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            Supplier obj = cbProducts.SelectedItem as Supplier;
            if (obj != null)
            {
                GetProdSuppliers(obj.SupplierId);

                dataGridProdSupp.DataSource = suppList;
                dataGridNotInSupp.DataSource = productsList;
                //AddProds();
            }
        }


        private void AddProdToSuppliers(int SupplierId)
        {
            try
            {
                //addProdList = ProductsSuppliersDB.AddToProdSupp(SupplierId);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void GetProdSuppliers(int SupplierId)
        {
            try
            {
                suppList = ProductsSuppliersDB.GetProductSuppBySuppID(SupplierId);

                productsList = ProductsSuppliersDB.GetProductNotInProdSuppBySuppID(SupplierId);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridNotInSupp_SelectionChanged(object sender, EventArgs e)
        {
            currentProd = (Product)dataGridNotInSupp.CurrentRow.DataBoundItem;
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            frmAddModifyProducts addProductsForm = new frmAddModifyProducts();
            addProductsForm.addProducts = true;
            
            DialogResult res = addProductsForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                currentProd = addProductsForm.product;
                productsList.Add(currentProd);

                RefreshProducts();
                dataGridNotInSupp.DataSource = productsList;
                
                
                
            }
            
        }
        public void DisplayProduct()
        {
          
            //productsList.Add(currentProd);
            dataGridNotInSupp.Update();
            
            dataGridNotInSupp.DataSource = productsList;

        }
        private void btnEditProd_Click(object sender, EventArgs e)
        {
            

            frmAddModifyProducts editProdForm = new frmAddModifyProducts();

            editProdForm.addProducts = false;
            editProdForm.product = currentProd;

            DialogResult res = editProdForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                currentProd = editProdForm.product;
                RefreshProducts();
                //productsList.Add(currentProd);
                this.DisplayProduct();
            }
            else if (res == DialogResult.Retry)
            {
                this.GetSuppliersProducts(currentProd.ProductId);
                if (currentProd != null)
                    this.DisplayProduct();
                else
                    editProdForm.ClearControls();
            }
        }

        private void RefreshProducts()
        {
            
            //currentProd = null;
            //suppList = null;
            //productsList = null;
            dataGridProdSupp.DataSource = suppList;
            dataGridNotInSupp.DataSource = null;
            dataGridNotInSupp.Update();
            dataGridNotInSupp.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete: " + currentProd.ProdName, "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //dataGridNotInSupp.CurrentRow
                currentProd = (Product)dataGridNotInSupp.CurrentRow.DataBoundItem;

                currentProd.Delete();
                RefreshProducts();
                productsList.Add(currentProd);
                dataGridNotInSupp.DataSource = productsList;
            }

        }
    }
}
