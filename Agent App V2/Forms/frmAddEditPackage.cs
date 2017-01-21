using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Agent_App_V2
{
    /// <summary>
    /// Form to add or edit a package
    /// C# workshop project
    /// Written By: Mo Xue
    /// </summary>
    public partial class frmAddEditPackage : Form
    {
        // initialize current package details
        public Package Package;
        public List<Product_Supplier> AddedPSList = new List<Product_Supplier>();
        public List<Product_Supplier> NotAddedPSList = PackageDB.GetAllPS();

        // adding or editing
        private bool addStatus;
        public frmAddEditPackage(string action)
        {
            InitializeComponent();

            // set form open mode, add or edit
            if (action == "add")
            {
                // create new package if adding
                Package = new Package();
                addStatus = true;
            }
            else if (action == "edit")
            {
                addStatus = false;
            }
        }

        private void frmAddEditPackage_Load(object sender, EventArgs e)
        {

            if (!addStatus)
            {
                // load package details textboxes if editing
                LoadPackageDetails();
                lblPackage.Text = @"Edit Package - Travel Experts Inc.";
            }
            else
            {
                // create new list of product suppliers if new package
                AddedPSList = new List<Product_Supplier>();
                lblPackage.Text = @"Add Package - Travel Experts Inc.";
            }

            // fill datagrids with the two lists on load, rename column headers and adjust widths
            RefreshPSData();

            dgvAddedPS.Columns[0].Width = 120;
            dgvAddedPS.Columns[1].Width = 285;
            dgvAddedPS.ColumnHeadersDefaultCellStyle.Font = new
            Font("Segoe UI", 10);

            dgvNotAddedPS.Columns[0].Width = 120;
            dgvNotAddedPS.Columns[1].Width = 285;
            dgvNotAddedPS.ColumnHeadersDefaultCellStyle.Font = new
            Font("Segoe UI", 10);
        }

        private void LoadPackageDetails()
        {
            // fill textboxes and dtp with values
            tbPkgName.Text = Package.PkgName;
            dtpPkgStartDate.Value = Package.PkgStartDate;
            dtpPkgEndDate.Value = Package.PkgEndDate;
            tbPkgDesc.Text = Package.PkgDesc;
            tbPkgBasePrice.Text = Package.PkgBasePrice.ToString("c");
            tbPkgAgencyCommission.Text = Package.PkgAgencyCommission.ToString("c");

            // update added PS for loaded package
            AddedPSList = Package.GetAddedPS();

            // Filter suppliers not in AddedList with LINQ
            NotAddedPSList = NotAddedPSList.Where(allPS => !AddedPSList.Any(addedPS => addedPS.ProductSupplierId == allPS.ProductSupplierId)).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (dgvNotAddedPS.SelectedRows.Count == 0)
            {
                // show error message if nothing selected and return
                MessageBox.Show("Select a product to add!", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedItems = dgvNotAddedPS.SelectedRows;
            // for each item in selection, move to addedPS list
            foreach (DataGridViewRow selectedItem in selectedItems)
            {
                Product_Supplier PSItem = (Product_Supplier)selectedItem.DataBoundItem;

                // add item to product supplier list
                AddedPSList.Add(PSItem);

                // remove item from other product suppliers list
                NotAddedPSList = NotAddedPSList.Where(PS => PS.ProductSupplierId != PSItem.ProductSupplierId).ToList();
            }
            // refresh datagrids
            RefreshPSData();
        }

        private void RefreshPSData()
        {
            // sort both lists
            AddedPSList = sortPSList(AddedPSList);
            NotAddedPSList = sortPSList(NotAddedPSList);

            // refresh dgvs
            dgvAddedPS.DataSource = AddedPSList;
            dgvNotAddedPS.DataSource = NotAddedPSList;

            // filter notAddedPS list based on search text
            FilterPSList();
        }

        // sort method
        private List<Product_Supplier> sortPSList(List<Product_Supplier> PSList)
        {
            // sort product suppliers with LINQ
            return (from PS in PSList
                   orderby PS.ProductId,PS.ProductSupplierId
                   select PS).ToList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvAddedPS.SelectedRows.Count == 0)
            {
                // show error message if nothing selected and return
                MessageBox.Show("Select a product to remove!", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedItems = dgvAddedPS.SelectedRows;
            // foreach item selected, move to notAddedPS list
            foreach (DataGridViewRow selectedItem in selectedItems)
            {
                Product_Supplier PSItem = (Product_Supplier) selectedItem.DataBoundItem;

                // add item to other product supplier list
                NotAddedPSList.Add(PSItem);

                // remove item from product supplier list
                AddedPSList = AddedPSList.Where(PS => PS.ProductSupplierId != PSItem.ProductSupplierId).ToList();
            }
            // refresh datagrids
            RefreshPSData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // validate package
            if (!Validate())
            {
                return;
            }

            // confirm saving
            string saveBtnMessage = (addStatus) ? "Add this package?" : "Save changes to this package?";
            if (MessageBox.Show(saveBtnMessage, "Save Package", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            //update package info from textboxes
            Package.PkgName = tbPkgName.Text;
            Package.PkgStartDate = dtpPkgStartDate.Value;
            Package.PkgEndDate = dtpPkgEndDate.Value;
            Package.PkgDesc = tbPkgDesc.Text;
            Package.PkgBasePrice = Convert.ToDecimal(tbPkgBasePrice.Text.Trim('$'));
            Package.PkgAgencyCommission = Convert.ToDecimal(tbPkgAgencyCommission.Text.Trim('$'));

            // return to parent form
            DialogResult = DialogResult.OK;
        }

        // Validate input fields
        private bool Validate()
        {
            if (Validator.IsPresent(tbPkgName)
                && Validator.IsWithinLength(tbPkgName, 5, 35)
                && Validator.IsPresent(tbPkgBasePrice)
                && Validator.IsDecimal(tbPkgBasePrice)
                && Validator.IsWithinRange(tbPkgBasePrice,0,100000)
                && Validator.IsPresent(tbPkgAgencyCommission)
                && Validator.IsDecimal(tbPkgAgencyCommission)
                && Validator.IsLower(tbPkgAgencyCommission, tbPkgBasePrice)
                && Validator.IsWithinRange(tbPkgAgencyCommission, 0, 100000)
                && Validator.IsValidDate(dtpPkgStartDate, dtpPkgEndDate)
                && Validator.IsPresent(tbPkgDesc)
                && Validator.IsWithinLength(tbPkgDesc,5,100))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // filter data grid view on text change
            FilterPSList();
        }

        private void FilterPSList()
        {
            string searchText = tbSearch.Text;

            // prerequisites for search function
            dgvNotAddedPS.CurrentCell = null;
            CurrencyManager CM = (CurrencyManager)BindingContext[dgvNotAddedPS.DataSource];
            CM.SuspendBinding();


            // hide rows that have no matching data (not case sensative)
            foreach (DataGridViewRow row in dgvNotAddedPS.Rows)
            {
                bool match = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString().ToUpper().Contains(searchText.ToUpper()))
                    {
                        match = true;
                    }
                }
                row.Visible = match;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // make sure user wants to reset
            if (MessageBox.Show("Reset to initial state?", "reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }

            // check if adding or editing
            if (addStatus)
            {
                // clear textboxes
                tbPkgName.Clear();
                dtpPkgStartDate.ResetText();
                dtpPkgEndDate.ResetText();
                tbPkgDesc.Clear();
                tbPkgBasePrice.Clear();
                tbPkgAgencyCommission.Clear();
            }
            else
            {
                // load original package
                LoadPackageDetails();
            }
            // refresh datagrids and search textbox
            RefreshPSData();
            tbSearch.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();//closes application
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;//minimize application window
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmAddEditPackage_FormClosing(object sender, FormClosingEventArgs e)
        {
            // make sure user wants to exit
            if (
                MessageBox.Show("Exit without saving changes?", "Cancel Edit", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
