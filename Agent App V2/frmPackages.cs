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
    public partial class frmPackages : Form
    {
        private List<Package> packageList;
        private Package currentPackage;
        private List<Product_Supplier> currentPSList;
        private int count = 0;

        public frmPackages()
        {
            InitializeComponent();
        }

        private void Reload()
        {
            // remove buttons to refresh packages
            for (int i = count; i > 0; i--)
            {
                Controls.RemoveAt(Controls.Count-1);
            }
            
            // make each package into a button
            count = 0;
            packageList = PackageDB.GetPackages();
            foreach (var package in packageList)
            {
                Button button = new Button();
                button.Location = new Point(10, 30 * count);
                button.Size = new Size(200, 30);
                button.TabIndex = count;
                button.Text = package.PkgName;
                button.Tag = count.ToString();
                button.Click += Package_Button_Click;

                Controls.Add(button);
                count++;
            }

            // disable update and delete buttons
            btnEditPackage.Enabled = false;
            btnDeletePackage.Enabled = false;

            // reset current package and PS list
            currentPackage = null;
            currentPSList = null;

            // clear form details
            tbPackageID.Clear();
            tbPkgName.Clear();
            tbPkgStartDate.Clear();
            tbPkgEndDate.Clear();
            tbPkgDesc.Clear();
            tbPkgBasePrice.Clear();
            tbPkgAgencyCommission.Clear();
            lvProducts.Items.Clear();
        }
        private void frmPackages_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void Package_Button_Click(object sender, EventArgs e)
        {
            // set current package and get current product_supplier list for current package
            currentPackage = packageList[Convert.ToInt32(((Button) sender).Tag)];
            currentPSList = currentPackage.GetAddedPS();

            // populate package details
            tbPackageID.Text = currentPackage.PackageId.ToString();
            tbPkgName.Text = currentPackage.PkgName;
            tbPkgStartDate.Text = currentPackage.PkgStartDate.ToString("d");
            tbPkgEndDate.Text = currentPackage.PkgEndDate.ToString("d");
            tbPkgDesc.Text = currentPackage.PkgDesc;
            tbPkgBasePrice.Text = currentPackage.PkgBasePrice.ToString("c");
            tbPkgAgencyCommission.Text = currentPackage.PkgAgencyCommission.ToString("c");

            // show current product_supplier list
            lvProducts.Items.Clear();
            foreach (var ps in currentPSList)
            {
                ListViewItem item = new ListViewItem(ps.toListViewItem());
                lvProducts.Items.Add(item);
            }

            // enable edit and delete button
            btnEditPackage.Enabled = true;
            btnDeletePackage.Enabled = true;
        }

        private void btnEditPackage_Click(object sender, EventArgs e)
        {
            // modify current package
            var frmAddEdit = new frmAddEditPackage("edit");
            frmAddEdit.Package = currentPackage;
            // if user clicks save
            if (frmAddEdit.ShowDialog() == DialogResult.OK)
            {
                frmAddEdit.Package.Update();
                frmAddEdit.Package.RemoveProducts();
                foreach (var ps in frmAddEdit.AddedPSList)
                {
                    ps.AddToPackage(frmAddEdit.Package.PackageId);
                }
                Reload();
            }
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            // add new package
            var frmAddEdit = new frmAddEditPackage("add");
            frmAddEdit.Package = new Package();

            // if user clicks save
            if (frmAddEdit.ShowDialog() == DialogResult.OK)
            {
                int PackageId = frmAddEdit.Package.AddPackage();
                frmAddEdit.Package.PackageId = PackageId;

                foreach (var ps in frmAddEdit.AddedPSList)
                {
                    ps.AddToPackage(frmAddEdit.Package.PackageId);
                }
                Reload();
            }
        }

        private void btnDeletePackage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to delete package: " + currentPackage.PkgName, "Delete Package", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentPackage.RemoveProducts();
                currentPackage.Delete();
            }
            Reload();
        }
    }
}
