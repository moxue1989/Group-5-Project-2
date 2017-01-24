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
        private bool saveStatus = false;
        public frmAddEditSupplier()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Add Suppliers 
            if (AddSuppliers)
            {
                if (IsValidData())
                {
                    Supplier newSupp = new Supplier();
                    newSupp.SupName = txtSuppName.Text;
                    saveStatus = true;
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
            }
            else //Update Suppliers
            {
                if (IsValidData())
                {
                    supplier.SupName = txtSuppName.Text;
                    saveStatus = true;
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
            return Validator.IsPresent(txtSuppName);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;//minimize application window
        }

        private void frmAddEditSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saveStatus)
            {
                // make sure user wants to exit
                if (
                    MessageBox.Show("Exit without saving changes?", "Cancel", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Exclamation) != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
