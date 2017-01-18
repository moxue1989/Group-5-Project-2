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
    public partial class frmAddEditSupplier : Form
    {
        public bool AddSuppliers; //Modify of edit Suppliers

        public Supplier supplier = new Supplier();// object of supplier data

        public frmAddEditSupplier()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Add Suppliers 
            if (AddSuppliers)
            {
                Supplier newSupp = new Supplier();
                newSupp.SupName = txtSuppName.Text;
                try
                {
                    SupplierDB.AddSupplier(newSupp);
                    DialogResult = DialogResult.OK;
                }

                catch (Exception ex)

                {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else //Update Suppliers
            {
                supplier.SupName = txtSuppName.Text;

                try
                {
                    supplier.UpdateSupp();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        public void ClearControls()//method to clear controls
        {
            txtSuppName.Clear();
        }

        private void DisplaySupplier()//Display supplier details
        {
            txtSuppName.Text = supplier.SupName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtSuppName);

        }

        private void frmAddEditSupplier_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtSuppName;
            if (AddSuppliers)
            {
                lblForm.Text = @"Add Supplier - Travel Experts Inc.";//name of dialog form to Add Supplier
               
            }
            else
            {
                lblForm.Text = @"Modify Supplier - Travel Experts Inc.";//name of dialog form to Modify Supplier
                
                DisplaySupplier();
            }
        }

        private void EditSupplierPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
