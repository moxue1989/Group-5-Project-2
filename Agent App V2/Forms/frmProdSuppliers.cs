using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Agent_App_V2
{
    public partial class frmProdSuppliers : Form
    {
        //Product prod = new Product();
        List<Product> prodSuppList;
        private List<Product> allProdList = ProductsSuppliersDB.GetProducts();
        private List<Package> packageList;

        private Supplier currentSupp = new Supplier();
        List<Supplier> suppList;

        private Product newProd = new Product();
        private Product currentProd = new Product();

        private Product_Supplier currentProdSupp = new Product_Supplier();

        public frmProdSuppliers()
        {
            InitializeComponent();
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            dataGridSuppliers.DataSource = ProductsSuppliersDB.GetSuppliers();
            FindProductSuppliers();
            dataGridSuppliers.Columns[0].Width = 300;
            dataGridNotInSupp.Columns[0].Width = 100;
            dataGridProdSupp.Columns[0].Width = 100;
            datagridPackages.Columns[0].Width = 100;
        }

        private void FindProductSuppliers()
        {
            currentSupp = (Supplier) dataGridSuppliers.CurrentRow.DataBoundItem;

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
                allProdList = ProductsSuppliersDB.GetProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void dataGridSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            FindProductSuppliers();
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
                allProdList.Add(newProd);

                Display();
            }
        }

        private void Display()
        {
            dataGridProdSupp.DataSource = prodSuppList;
            dataGridNotInSupp.DataSource = allProdList;
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
                Supplier obj = dataGridSuppliers.CurrentRow.DataBoundItem as Supplier;
                if (obj != null)
                {
                    GetSuppliersProducts(obj.SupplierId);

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


        private void btnDeleteProd_Click(object sender, EventArgs e) //delete products
        {
            if (MessageBox.Show(@"Are you sure you want to delete: " + newProd.ProdName, @"Delete Product",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (newProd != null)
                {
                    newProd = (Product) dataGridNotInSupp.CurrentRow.DataBoundItem;
                    try
                    {
                        newProd.Delete();
                        Supplier obj = dataGridSuppliers.CurrentRow.DataBoundItem as Supplier;
                        if (obj != null)
                        {
                            GetSuppliersProducts(obj.SupplierId);

                            Display();
                        }
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show(@"This product is a package. ");
                    }
                    
                }

            }

        }

        //private void frmSuppliers_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    RefreshProducts();
        //}

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
            frmAddEditSupplier editSuppfrm = new frmAddEditSupplier(); //Instantiate a new form

            //Supplier currentSupp = cbProdSupp.SelectedItem as Supplier;
            Supplier currentSupp = (Supplier)dataGridSuppliers.CurrentRow.DataBoundItem;

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
            Supplier obj = dataGridSuppliers.CurrentRow.DataBoundItem as Supplier;
            if (obj != null)
            {
                currentSupp = obj;

                if (MessageBox.Show(@"Are you sure you want to delete: " + currentSupp.SupName + @" Supplier?",
                        @"Delete Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    currentSupp.DeleteSupp(); // delete current supplier

                    FindProductSuppliers(); // find Suppliers
                    Display();
                }
            }
        } //delete supplier

        private void dataGridProdSupp_SelectionChanged(object sender, EventArgs e)
        {
            currentProd = (Product) dataGridProdSupp.CurrentRow.DataBoundItem;
            packageList = ProductsSuppliersDB.GetPackagesWith(currentSupp.SupplierId, currentProd.ProductId);
            datagridPackages.DataSource = packageList;
            //store currently selected row data to product Object
        }

        private void btnAddProdToList_Click(object sender, EventArgs e) //add new products to suppliers
        {
            if (dataGridNotInSupp.SelectedRows.Count == 0)
            {
                MessageBox.Show(@"No product/s to add! " + @"Try Again", @"No Product", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;

            }

            int newProdId = ((Product) dataGridNotInSupp.CurrentRow.DataBoundItem).ProductId;

            var products = from ps in prodSuppList
                where ps.ProductId == newProdId
                select ps;

            if (products.Count() != 0)
            {
                MessageBox.Show("Already added!");
                return;
            }

            Product_Supplier newProdSupp = new Product_Supplier();

            try
            {
                newProdSupp.ProductId = newProdId;
                newProdSupp.SupplierId = currentSupp.SupplierId;

                newProdSupp.ProductSupplierId = ProductsSuppliersDB.AddToProdSupp(newProdSupp);

                currentSupp = dataGridSuppliers.CurrentRow.DataBoundItem as Supplier;
                if (currentSupp != null)
                {
                    GetSuppliersProducts(currentSupp.SupplierId);

                    Display();
                }

                Display();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void RemoveProductFrSupplierData(Product_Supplier prodSupp) //add data from controls to object
        {
            if (dataGridProdSupp.SelectedRows.Count == 0)
            {
                MessageBox.Show(@"No product/s to remove! " + @"Try Again", @"No Product", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            try
            {
                currentProd = (Product)dataGridProdSupp.CurrentRow.DataBoundItem;
                currentProdSupp.ProductId = currentProd.ProductId;// link ProductID to ProductSupplier.ProductID

                currentSupp = dataGridSuppliers.CurrentRow.DataBoundItem as Supplier;

                currentProdSupp.SupplierId = currentSupp.SupplierId;// link SupplierID to ProductSupplier.SupplierID
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
           
        }

        private void btnRemoveProdFrList_Click(object sender, EventArgs e)
        {
            if (currentProdSupp != null)
            {
                RemoveProductFrSupplierData(currentProdSupp);//takes the SupplerId and ProductId from Products 
                                                             //and Suppliers table and insert into Product Suppliers object

                currentProdSupp.RemoveProduct(currentProdSupp.SupplierId);//delete selected product from supplier

                currentSupp = dataGridSuppliers.CurrentRow.DataBoundItem as Supplier;
                if (currentSupp != null)
                {
                    GetSuppliersProducts(currentSupp.SupplierId);
                }
                Display();
            }
        }
    }
}
