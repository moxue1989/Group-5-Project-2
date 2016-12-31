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
            dataGridView1.DataSource = DatabaseAccess.GetProductsData();
        }
    }
}
