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
    public partial class frmProdSupp : Form
    {
        public frmProdSupp()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void products_SuppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.products_SuppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);

        }

        private void frmProdSupp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products_Suppliers' table. You can move, or remove it, as needed.
            this.products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Products_Suppliers);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.products_SuppliersBindingSource.CancelEdit();//cancels the edit command
            Close();//close active form
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);//update and refresh dataset
            Close();//close active form
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//closes products form
        }
    }
}
