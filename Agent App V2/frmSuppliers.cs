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
        List<Product> products = new List<Product>();
        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            cbProducts.DataSource = TravelExpertsDB.GetSuppliers();
            cbProducts.DisplayMember = "SupName";
            cbProducts.ValueMember = "SupplierId";

            lvProd.View = View.Details;//View the data details
            lvProd.FullRowSelect = true;//Select the entire row of data

            

            Supplier obj = cbProducts.SelectedItem as Supplier;

            if (obj != null)
            {
              
                products = TravelExpertsDB.GetProductSuppBySuppID(obj.SupplierId);
                dataGridProdSupp.DataSource = products;

            }

            lvProd.View = View.Details;
            List<Product> prods = TravelExpertsDB.GetProducts();
            foreach (Product p in prods)
            {
               
                ListViewItem item = new ListViewItem(p.ProductId.ToString());
                item.SubItems.Add(p.ProdName);

                //Add Items
                lvProd.Items.Add(item);//Add user input in List View
            }
            
        }

        private void cbProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {

            Supplier obj = cbProducts.SelectedItem as Supplier;
            if (obj != null)
            {
                products = TravelExpertsDB.GetProductSuppBySuppID(obj.SupplierId);
                
                dataGridProdSupp.DataSource = products;

            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
