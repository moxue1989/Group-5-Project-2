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

        private Product currentProd = new Product();
        

        


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

        private void btnAdd_Click(object sender, EventArgs e)
        {
           


        }

        private void btnRemove_Click(object sender, EventArgs e)
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

                Refresh();
                Display();
            }
        }
        public void Display()
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
            editProdForm.product = currentProd;

            DialogResult res = editProdForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                currentProd = editProdForm.product;
                Supplier obj = cbProdSupp.SelectedItem as Supplier;
                if (obj != null)
                {
                    GetProdSuppliers(obj.SupplierId);

                    Display();
                }

            }
            else if (res == DialogResult.Retry)
            {
                GetSuppliersProducts(currentProd.ProductId);
                if (currentProd != null)
                    Display();
                else
                    editProdForm.ClearControls();
            }
        }

        private void Refresh()
        {
            cbProdSupp.DataSource = null;
            dataGridProdSupp.DataSource = prodSuppList;
            dataGridNotInSupp.DataSource = null;
        }

        private void btnDeleteProd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete: " + currentProd.ProdName, "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentProd = (Product)dataGridNotInSupp.CurrentRow.DataBoundItem;

                currentProd.Delete();
                Refresh();
                dataGridNotInSupp.DataSource = productsList;
                
            }

        }

        private void frmSuppliers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Refresh();
        }

        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier addSuppfrm = new frmAddEditSupplier();
            addSuppfrm.AddSuppliers = true;

            DialogResult res = addSuppfrm.ShowDialog();
            if (res == DialogResult.OK)
            {
                //Supplier newSupp = new Supplier();
                currentSupp = addSuppfrm.supplier;
                FindProductSuppliers();

                //Refresh();
                //Display();
            }
        }

        private void btnEditSupp_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier editSuppfrm = new frmAddEditSupplier();

            Supplier currentSupp = cbProdSupp.SelectedItem as Supplier;
            if (currentSupp != null)
            {
                editSuppfrm.supplier = currentSupp;
                editSuppfrm.AddSuppliers = false;
                
                //cbProducts.DataSource = null;
                DialogResult res = editSuppfrm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    currentSupp = editSuppfrm.supplier;
                    cbProdSupp.SelectedItem = currentSupp;
                    FindProductSuppliers();
                    
                }
                
            }
            
        }

        private void btnDeleteSupp_Click(object sender, EventArgs e)
        {
            Supplier obj = cbProdSupp.SelectedItem as Supplier;
            currentSupp = obj;
            if (MessageBox.Show(@"Are you sure you want to delete: " + currentSupp.SupName, @"Delete Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                if (obj != null)
                {
                    
                    currentSupp.DeleteSupp();
                    Refresh();
                    FindProductSuppliers();
                    Display();
                }
                

            }
        }
    }
}
