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
        private List<Product> prodSuppList;
        private List<Product> allProdList;
        private List<Package> packageList = new List<Package>();

        private Supplier currentSupp;
        List<Supplier> suppList;

        private Product newProd;
        private Product currentProd;
        private Product currentAllProd;

        public frmProdSuppliers()
        {
            InitializeComponent();
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            dataGridSuppliers.DataSource = ProductsSuppliersDB.GetSuppliers();
            datagridPackages.DataSource = packageList;
            FindProductSuppliers();
            dataGridSuppliers.Columns[0].Width = 300;
            dataGridAllProd.Columns[0].Width = 200;
            dataGridProdSupp.Columns[0].Width = 200;
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

        private void dataGridAllProd_SelectionChanged(object sender, EventArgs e)
        {
            currentAllProd = (Product) dataGridAllProd.CurrentRow.DataBoundItem;
        }

        private void dataGridProdSupp_SelectionChanged(object sender, EventArgs e)
        {
            currentProd = (Product) dataGridProdSupp.CurrentRow.DataBoundItem;
            packageList = ProductsSuppliersDB.GetPackagesWith(currentSupp.SupplierId, currentProd.ProductId);
            datagridPackages.DataSource = packageList;
            //store currently selected row data to product Object
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            FrmAddModifyProducts addProductsForm = new FrmAddModifyProducts();
            addProductsForm.AddProducts = true;

            DialogResult res = addProductsForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                Display();
            }
        }

        private void Display()
        {
            allProdList = ProductsSuppliersDB.GetProducts();
            prodSuppList = ProductsSuppliersDB.GetProductSuppBySuppID(currentSupp.SupplierId);
            dataGridProdSupp.DataSource = prodSuppList;
            dataGridAllProd.DataSource = allProdList;
        }

        private void btnEditProd_Click(object sender, EventArgs e)
        {
            FrmAddModifyProducts editProdForm = new FrmAddModifyProducts();
            editProdForm.AddProducts = false;
            editProdForm.product = currentAllProd;
            
            DialogResult res = editProdForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                currentProd = editProdForm.product;
                allProdList = ProductsSuppliersDB.GetProducts();
                dataGridAllProd.DataSource = allProdList;
                Display();
            }
            else
            {
                editProdForm.ClearControls();
            }
        }


        private void btnDeleteProd_Click(object sender, EventArgs e) //delete products
        {
            if (currentAllProd != null)
            {
                if (MessageBox.Show(@"Are you sure you want to delete: " + currentAllProd.ProdName, @"Delete Product",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        currentAllProd.Delete();
                        Display();
                        FindProductSuppliers();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show(@"This product cannot be deleted, it is part of a supplier");
                    }

                }

            }

        }

        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier addSuppfrm = new frmAddEditSupplier();
            addSuppfrm.AddSuppliers = true;

            DialogResult res = addSuppfrm.ShowDialog();
            if (res == DialogResult.OK)
            {
                suppList = ProductsSuppliersDB.GetSuppliers();
                dataGridSuppliers.DataSource = suppList;
                Display();
                FindProductSuppliers();
            }
        }

        private void btnEditSupp_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier editSuppfrm = new frmAddEditSupplier(); //Instantiate a new form

            if (currentSupp != null)
            {
                editSuppfrm.supplier = currentSupp; // selected supplier is now the next form's supplier
                editSuppfrm.AddSuppliers = false;

                DialogResult res = editSuppfrm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    suppList = ProductsSuppliersDB.GetSuppliers();
                    dataGridSuppliers.DataSource = suppList;
                    Display();
                    FindProductSuppliers();
                }
            }
        }

        private void btnDeleteSupp_Click(object sender, EventArgs e)
        {
            if (currentSupp != null)
            {
                try
                {
                    if (MessageBox.Show(@"Are you sure you want to delete: " + currentSupp.SupName + @" Supplier?",
                        @"Delete Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        currentSupp.DeleteSupp(); // delete current supplier
                        suppList = ProductsSuppliersDB.GetSuppliers();
                        dataGridSuppliers.DataSource = suppList;
                        Display();
                        FindProductSuppliers(); // find Suppliers
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Cannot delete this supplier, it is currently supplying products!",@"Delete",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
        } //delete supplier

        private void btnAddProdToList_Click(object sender, EventArgs e) //add new products to suppliers
        {
            if (dataGridAllProd.SelectedRows.Count == 0)
            {
                MessageBox.Show(@"No product/s to add! " + @"Try Again", @"No Product", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;

            }

            int newProdId = ((Product) dataGridAllProd.CurrentRow.DataBoundItem).ProductId;

            var products = from ps in prodSuppList
                where ps.ProductId == newProdId
                select ps;

            if (products.Count() != 0)
            {
                MessageBox.Show(@"This Product is already added!", @"Duplicate", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

        private void btnRemoveProdFrList_Click(object sender, EventArgs e)
        {
            if (dataGridProdSupp.CurrentRow != null)
            {
                if (packageList.Count != 0)
                {
                    string confirmString =
                        @"This product is currently part of one or more packages! Are you sure you want to remove this product? (This action will also remove the product from all packages!)";

                    if (MessageBox.Show(confirmString, "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                        DialogResult.Yes)
                    {
                        Product_Supplier PS = new Product_Supplier();
                        PS.ProductId = currentProd.ProductId;
                        PS.SupplierId = currentSupp.SupplierId;
                        PS.RemoveFromAllPkg();

                        currentProd.RemoveFromSupplier(currentSupp.SupplierId); //delete selected product from supplier
                    }
                }
                else
                {
                    string confirmString = "Are you sure you want to remove this product?";
                    if (MessageBox.Show(confirmString, "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                        DialogResult.Yes)
                    {
                        currentProd.RemoveFromSupplier(currentSupp.SupplierId); //delete selected product from supplier
                    }
                }
                Display();
            }
            else
            {
                MessageBox.Show("No Product Selected!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();//closes application
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;//minimize application window
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            //frmMain guiDashBoard = new frmMain(); //Instantiate a new form
            //guiDashBoard.ShowDialog();
            //Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
