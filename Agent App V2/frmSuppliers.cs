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

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            cbProducts.DataSource = TravelExpertsDB.GetProducts();
            cbProducts.DisplayMember = "ProdName";
            cbProducts.ValueMember = "ProductId";
            Product obj = cbProducts.SelectedItem as Product;

            if (obj != null)
            {
                dataGridProdSupp.DataSource = TravelExpertsDB.GetProductSuppByProdID(obj.ProductId);
            }
        }

        private void cbProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Product obj = cbProducts.SelectedItem as Product;

            if (obj != null)
            {
                dataGridProdSupp.DataSource = TravelExpertsDB.GetProductSuppByProdID(obj.ProductId);
            }
        }
    }
}
