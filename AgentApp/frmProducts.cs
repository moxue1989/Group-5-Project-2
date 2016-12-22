using System;
using System.Windows.Forms;

namespace AgentApp
{
    public partial class FrmProducts : Form
    {
        
        public FrmProducts()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }
        //Code written by Kasi Emmanuel
        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            productsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(travelExpertsDataSet);

        }
        //Code written by Kasi Emmanuel
        private void frmProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products' table. You can move, or remove it, as needed.
            productsTableAdapter.Fill(travelExpertsDataSet.Products);//populate textboxes with existing records

        }
        //Code written by Kasi Emmanuel
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();//closes products form
        }
        //Code written by Kasi Emmanuel
        private void btnOK_Click(object sender, EventArgs e)
        {
            tableAdapterManager.UpdateAll(travelExpertsDataSet);//update and refresh dataset
            Close();//close active form
        }
        //Code written by Kasi Emmanuel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            productsBindingSource.CancelEdit();//cancels the edit command
            Close();//close active form
        }
    }
}
