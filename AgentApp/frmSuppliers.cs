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
    public partial class frmSuppliers : Form
    {
        public frmSuppliers()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            this.suppliersTableAdapter.Fill(this.travelExpertsDataSet.Suppliers);//populate textboxes with existing records
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//closes products form
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.suppliersBindingSource.CancelEdit();//cancels the edit command
            Close();//close active form
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);//update and refresh dataset
            Close();//close active form
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);
        }
    }
}
