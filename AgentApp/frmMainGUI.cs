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
    public partial class frmMainGUI : Form
    {
        public frmMainGUI()
        {
            InitializeComponent();
        }

        private void packagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.packagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);

        }
        private void frmMainGUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Packages' table. You can move, or remove it, as needed.
            this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtpkgBasePrice.Enabled = true;
            txtpkgCommission.Enabled = true;
            txtPkgId.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This record will be permanently deleted.", "Delete", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }
        private void navProdAddEdit_Click(object sender, EventArgs e)
        {
            using (frmProducts prod = new frmProducts())
            {
                prod.ShowDialog(this);
            }
        }
    }
}
