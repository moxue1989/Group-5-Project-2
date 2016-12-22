using System;
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
            Validate();
            products_SuppliersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(travelExpertsDataSet);

        }

        private void frmProdSupp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products_Suppliers' table. You can move, or remove it, as needed.
            products_SuppliersTableAdapter.Fill(travelExpertsDataSet.Products_Suppliers);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            products_SuppliersBindingSource.CancelEdit();//cancels the edit command
            Close();//close active form
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            tableAdapterManager.UpdateAll(travelExpertsDataSet);//update and refresh dataset
            Close();//close active form
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();//closes products form
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
