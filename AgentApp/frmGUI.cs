using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentApp
{
    public partial class frmGUI : Form
    {
        public frmGUI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Package> packages = DatabaseAccess.GetPackages();
            foreach (Package package in packages)
            {
                listBox1.Items.Add(package);
            }
            //dgTest.DataMember = table;
            var packagesList = new BindingList<Package>(packages);
            //packageBindingSource.DataSource = packagesList;

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //dgTest.DataMember = table;
            IList<Product> products = DatabaseAccess.GetProducts();
            foreach (Product product in products)
            {
                listBox1.Items.Add(product);
            }
            
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = DatabaseAccess.GetProductsData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var products = new List<Product>()
            {
                new Product(5,"game"),
                new Product(5,"pop"),
            };

            //dataGridView1.DataSource = products;
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);

        }

        private void frmGUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products_Suppliers' table. You can move, or remove it, as needed.
            this.products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Products_Suppliers);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);

        }
    }
}
