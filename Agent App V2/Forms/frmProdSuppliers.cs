using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Agent_App_V2
{
    public partial class frmProdSuppliers : Form
    {
        public frmProdSuppliers()
        {
            InitializeComponent();
        }

        //Product prod = new Product();
        List<Product> prodSuppList;
        List<Product> productsList;

        private Supplier currentSupp = new Supplier();
        List<Supplier> suppList;

        private Product newProd = new Product();
        private Product currentProd = new Product();

        private Product_Supplier currentProdSupp = new Product_Supplier();



        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            FindProductSuppliers();

            //lvProd.View = View.Details;

            //foreach (Product p in prodSupp)
            //{

            //    ListViewItem item = new ListViewItem(p.ProductId.ToString());
            //    item.SubItems.Add(p.ProdName);

            //    //Add Items
            //    lvProd.Items.Add(item);//Add user input in List View
            //}

        }

        private void FindProductSuppliers()
        {
            cbProdSupp.DataSource = ProductsSuppliersDB.GetSuppliers();
            cbProdSupp.DisplayMember = "SupName";
            cbProdSupp.ValueMember = "SupplierId";

            currentSupp = cbProdSupp.SelectedItem as Supplier;

            if (currentSupp != null)
            {

                GetSuppliersProducts(currentSupp.SupplierId);
                Display();
            }
        }

        private void GetSuppliersProducts(int supplierId)
        {
            try
            {
                prodSuppList = ProductsSuppliersDB.GetProductSuppBySuppID(supplierId);
                productsList = ProductsSuppliersDB.GetProductNotInProdSuppBySuppID(supplierId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void cbProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {

            Supplier obj = cbProdSupp.SelectedItem as Supplier;
            if (obj != null)
            {
                GetProdSuppliers(obj.SupplierId);

                Display();
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
                prodSuppList = ProductsSuppliersDB.GetProductSuppBySuppID(SupplierId);

                productsList = ProductsSuppliersDB.GetProductNotInProdSuppBySuppID(SupplierId);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void dataGridNotInSupp_SelectionChanged(object sender, EventArgs e)
        {
            newProd = (Product) dataGridNotInSupp.CurrentRow.DataBoundItem;
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            FrmAddModifyProducts addProductsForm = new FrmAddModifyProducts();
            addProductsForm.AddProducts = true;

            DialogResult res = addProductsForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                newProd = addProductsForm.product;
                productsList.Add(newProd);

                RefreshProducts();
                Display();
            }
        }

        private void Display()
        {
            dataGridProdSupp.DataSource = prodSuppList;

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
            editProdForm.product = newProd;

            DialogResult res = editProdForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                newProd = editProdForm.product;
                Supplier obj = cbProdSupp.SelectedItem as Supplier;
                if (obj != null)
                {
                    GetProdSuppliers(obj.SupplierId);

                    Display();
                }

            }
            else if (res == DialogResult.Retry)
            {
                GetSuppliersProducts(newProd.ProductId);
                if (newProd != null)
                    Display();
                else
                    editProdForm.ClearControls();
            }
        }

        private void RefreshProducts()
        {
            dataGridProdSupp.DataSource = null;

            dataGridNotInSupp.DataSource = null;
        }

        
        private void btnDeleteProd_Click(object sender, EventArgs e)//delete products
        {
            if (MessageBox.Show(@"Are you sure you want to delete: " + newProd.ProdName, @"Delete Product",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (newProd != null)
                {
                    newProd = (Product)dataGridNotInSupp.CurrentRow.DataBoundItem;

                    newProd.Delete();
                    RefreshProducts();
                    Display();
                }
               
            }

        }

        private void frmSuppliers_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshProducts();
        }

        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier addSuppfrm = new frmAddEditSupplier();
            addSuppfrm.AddSuppliers = true;

            DialogResult res = addSuppfrm.ShowDialog();
            if (res == DialogResult.OK)
            {
                currentSupp = addSuppfrm.supplier;
                FindProductSuppliers();

            }
        }

        private void btnEditSupp_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier editSuppfrm = new frmAddEditSupplier();//Instantiate a new form

            Supplier currentSupp = cbProdSupp.SelectedItem as Supplier;
            if (currentSupp != null)
            {
                editSuppfrm.supplier = currentSupp; // selected supplier is now the next form's supplier
                editSuppfrm.AddSuppliers = false;

                DialogResult res = editSuppfrm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    FindProductSuppliers();
                }
            }
        }

        private void btnDeleteSupp_Click(object sender, EventArgs e)
        {
            Supplier obj = cbProdSupp.SelectedItem as Supplier;
            if (obj != null)
            {
                currentSupp = obj;

                if (MessageBox.Show(@"Are you sure you want to delete: " + currentSupp.SupName + @" Supplier?",
                        @"Delete Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    currentSupp.DeleteSupp(); // delete current supplier
                    RefreshProducts();

                    FindProductSuppliers(); // find Suppliers
                    Display();
                }
            }
        }//delete supplier

        private void AddProductSupplierData(Product_Supplier prodSupp) //add data from controls to object
        {
            newProd = (Product) dataGridNotInSupp.CurrentRow.DataBoundItem;

            currentProdSupp.ProductId = newProd.ProductId;

            currentSupp = cbProdSupp.SelectedItem as Supplier;

            currentProdSupp.SupplierId = currentSupp.SupplierId;

        }
        private void dataGridProdSupp_SelectionChanged(object sender, EventArgs e)
        {
            currentProd = (Product)dataGridProdSupp.CurrentRow.DataBoundItem;//store currently selected row data to product Object
        }

        private void btnAddProdToList_Click(object sender, EventArgs e)//add new products to suppliers
        {
            Product_Supplier newProdSupp = new Product_Supplier();
            AddProductSupplierData(currentProdSupp);
            try
            {
                newProdSupp = currentProdSupp;
                newProdSupp.ProductSupplierId = ProductsSuppliersDB.AddToProdSupp(currentProdSupp);

                currentSupp = cbProdSupp.SelectedItem as Supplier;
                if (currentSupp != null)
                {
                    GetProdSuppliers(currentSupp.SupplierId);

                    Display();
                }
                RefreshProducts();

                Display();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        private void RemoveProductFrSupplierData(Product_Supplier prodSupp) //add data from controls to object
        {
         
            currentProd = (Product)dataGridProdSupp.CurrentRow.DataBoundItem;
            currentProdSupp.ProductId = currentProd.ProductId;// link ProductID to ProductSupplier.ProductID

            currentSupp = cbProdSupp.SelectedItem as Supplier;

            currentProdSupp.SupplierId = currentSupp.SupplierId;// link SupplierID to ProductSupplier.SupplierID
            
        }

        private void btnRemoveProdFrList_Click(object sender, EventArgs e)
        {
            if (currentProdSupp != null)
            {
                RemoveProductFrSupplierData(currentProdSupp);//takes the SupplerId and ProductId from Products 
                                                             //and Suppliers table and insert into Product Suppliers object

                currentProdSupp.RemoveProduct(currentProdSupp.SupplierId);//delete selected product from supplier

                currentSupp = cbProdSupp.SelectedItem as Supplier;
                if (currentSupp != null)
                {
                    GetProdSuppliers(currentSupp.SupplierId);

                    Display();
                }
                RefreshProducts();
                Display();
            }
            
            

        }

        
    }
}
