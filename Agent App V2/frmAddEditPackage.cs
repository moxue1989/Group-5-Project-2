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
    public partial class frmAddEditPackage : Form
    {
        public Package Package;
        public List<Product_Supplier> AddedPSList;
        public List<Product_Supplier> NotAddedPSList;
        private bool addStatus;
        public frmAddEditPackage(string action)
        {
            InitializeComponent();
            if (action == "add")
            {
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
            NotAddedPSList = PackageDB.GetAllPS();
            AddedPSList = new List<Product_Supplier>();

            if (!addStatus)
            {
                // populate package details
                tbPkgName.Text = Package.PkgName;
                dtpPkgStartDate.Value = Package.PkgStartDate;
                dtpPkgEndDate.Value = Package.PkgEndDate;
                tbPkgDesc.Text = Package.PkgDesc;
                tbPkgBasePrice.Text = Package.PkgBasePrice.ToString("c");
                tbPkgAgencyCommission.Text = Package.PkgAgencyCommission.ToString("c");

                AddedPSList = PackageDB.GetAddedPS(Package.PackageId);

                // Filter suppliers not in AddedList
                NotAddedPSList = NotAddedPSList.Where(allPS => !AddedPSList.Any(addedPS => addedPS.ProductSupplierId == allPS.ProductSupplierId)).ToList();
            }

            // fill datagrids
            dgvAddedPS.DataSource = AddedPSList;
            dgvAddedPS.Columns[0].HeaderText = "Product Name";
            dgvAddedPS.Columns[1].HeaderText = "Supplier Name";

            dgvNotAddedPS.DataSource = NotAddedPSList;
            dgvNotAddedPS.Columns[0].HeaderText = "Product Name";
            dgvNotAddedPS.Columns[1].HeaderText = "Supplier Name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedItem = (Product_Supplier)dgvNotAddedPS.SelectedRows[0].DataBoundItem;

            // add item to product supplier list
            AddedPSList.Add(selectedItem);
            AddedPSList = sortPSList(AddedPSList);

            // remove item from other product suppliers list
            NotAddedPSList = NotAddedPSList.Where(PS => PS.ProductSupplierId != selectedItem.ProductSupplierId).ToList();
            NotAddedPSList = sortPSList(NotAddedPSList);

            // refresh dgvs
            dgvAddedPS.DataSource = AddedPSList;
            dgvNotAddedPS.DataSource = NotAddedPSList;
        }

        private List<Product_Supplier> sortPSList(List<Product_Supplier> PSList)
        {
            // sort product suppliers win LINQ
            return (from PS in PSList
                   orderby PS.ProductId,PS.ProductSupplierId
                   select PS).ToList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedItem = (Product_Supplier) dgvAddedPS.SelectedRows[0].DataBoundItem;

            // add item to other product supplier list
            NotAddedPSList.Add(selectedItem);
            NotAddedPSList = sortPSList(NotAddedPSList);

            // remove item from product supplier list
            AddedPSList = AddedPSList.Where(PS => PS.ProductSupplierId != selectedItem.ProductSupplierId).ToList();
            AddedPSList = sortPSList(AddedPSList);

            // refresh dgvs
            dgvAddedPS.DataSource = AddedPSList;
            dgvNotAddedPS.DataSource = NotAddedPSList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //validator here required

            //update package info
            Package.PkgName = tbPkgName.Text;
            Package.PkgStartDate = dtpPkgStartDate.Value;
            Package.PkgEndDate = dtpPkgEndDate.Value;
            Package.PkgDesc = tbPkgDesc.Text;
            Package.PkgBasePrice = Convert.ToDecimal(tbPkgBasePrice.Text.Trim('$'));
            Package.PkgAgencyCommission = Convert.ToDecimal(tbPkgAgencyCommission.Text.Trim('$'));

            DialogResult = DialogResult.OK;
        }
    }
}
