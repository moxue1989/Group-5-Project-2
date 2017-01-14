using System;
using System.Collections.Generic;
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
                DisplayProduct();
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

                DisplayProduct();
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
            FrmAddModifyProducts addProductsForm = new FrmAddModifyProducts();
            addProductsForm.AddProducts = true;
            
            DialogResult res = addProductsForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                currentProd = addProductsForm.product;
                productsList.Add(currentProd);

                RefreshProducts();
                DisplayProduct();
            }
        }
        public void DisplayProduct()
        {
            dataGridProdSupp.DataSource = suppList;
            
            dataGridNotInSupp.DataSource = productsList;
            DataGridViewColumn prodID = dataGridNotInSupp.Columns[0];
            DataGridViewColumn prodName = dataGridNotInSupp.Columns[1];
            prodID.Width = 60;
            prodName.Width = 175;
        }
        private void btnEditProd_Click(object sender, EventArgs e)
        {
            FrmAddModifyProducts editProdForm = new FrmAddModifyProducts();
            editProdForm.AddProducts = false;
            editProdForm.product = currentProd;

            DialogResult res = editProdForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                currentProd = editProdForm.product;
                Supplier obj = cbProducts.SelectedItem as Supplier;
                if (obj != null)
                {
                    GetProdSuppliers(obj.SupplierId);

                    DisplayProduct();
                }
                //dataGridNotInSupp.DataSource = productsList;
                //DisplayProduct();

            }
            else if (res == DialogResult.Retry)
            {
                GetSuppliersProducts(currentProd.ProductId);
                if (currentProd != null)
                    DisplayProduct();
                else
                    editProdForm.ClearControls();
            }
        }

        private void RefreshProducts()
        {
            dataGridProdSupp.DataSource = suppList;
            dataGridNotInSupp.DataSource = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete: " + currentProd.ProdName, "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                currentProd = (Product)dataGridNotInSupp.CurrentRow.DataBoundItem;

                currentProd.Delete();
                RefreshProducts();
                dataGridNotInSupp.DataSource = productsList;
                
            }

        }

        private void frmSuppliers_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshProducts();
        }
    }
}
