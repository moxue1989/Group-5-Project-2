using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentApp
{
    public partial class frmProducts : Form
    {
        
        public frmProducts()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);

        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);

        }
        //Code written by Kasi Emmanuel
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//closes products form
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.productsBindingSource.CancelEdit();
            Close();
        }
    }
}
