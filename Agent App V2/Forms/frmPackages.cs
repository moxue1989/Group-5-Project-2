using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Agent_App_V2
{
    /// <summary>
    /// Form to view all packages, links to add and edit package
    /// Allows for deleting packages
    /// C# workshop project
    /// Written By: Mo Xue
    /// </summary>
    public partial class frmPackages : Form
    {
        // initialize variables
        private List<Package> packageList;
        private Package currentPackage;
        private List<Product_Supplier> currentPSList;
        private int count;


        public frmPackages()
        {
            InitializeComponent();
        }

        // reload package list from database and refresh buttons for each package
        private void Reload()
        {
            // remove buttons for old packages
            pnlPackages.Controls.Clear();

            count = 0;
            packageList = PackageDB.GetPackages();
            // draw a button for each package in list
            foreach (var package in packageList)
            {
                int startX = pnlPackages.Location.X;
                int startY = pnlPackages.Location.Y;
                Button button = new Button();
                button.Location = new Point(5 + startX, 30*count + startY -10);
                button.Size = new Size(200, 25);
                button.TabIndex = count;
                button.Cursor = Cursors.Hand;
                button.Text = package.PkgName;
                button.Tag = count.ToString();
                button.Name = package.PackageId.ToString();
                button.Click += Package_Button_Click;

                // set color of expired, current, and available packages
                if (package.PkgEndDate < DateTime.Today)
                {
                    button.ForeColor = Color.Red;
                } else if (package.PkgStartDate < DateTime.Today)
                {
                    button.ForeColor = Color.Orange;
                }
                else
                {
                    button.ForeColor = Color.Green;
                }

                pnlPackages.Controls.Add(button);
                count++;
            }

            // disable update and delete buttons
            btnEditPackage.Enabled = false;
            btnDeletePackage.Enabled = false;

            // reset current package and PS list
            currentPackage = null;
            currentPSList = null;

            // clear form details
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

        // method called when user clicks a package
        private void Package_Button_Click(object sender, EventArgs e)
        {
            foreach (Button pkgButton in pnlPackages.Controls)
            {
                pkgButton.Enabled = true;
            }
            Button button = (Button)sender;
            button.Enabled = false;

            // set current package and get current product_supplier list for current package
            currentPackage = packageList[Convert.ToInt32(button.Tag)];
            currentPSList = currentPackage.GetAddedPS();

            // populate package details
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
                // add products to package
                foreach (var ps in frmAddEdit.AddedPSList)
                {
                    ps.AddToPackage(frmAddEdit.Package.PackageId);
                }
                Reload();

                // find this package in new button list and click it to show update details
                string buttonName = frmAddEdit.Package.PackageId.ToString();
                ((Button)pnlPackages.Controls[buttonName]).PerformClick();
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
                // add package to database and get package ID
                int PackageId = frmAddEdit.Package.AddPackage();
                frmAddEdit.Package.PackageId = PackageId;

                // add products to newly created package
                foreach (var ps in frmAddEdit.AddedPSList)
                {
                    ps.AddToPackage(frmAddEdit.Package.PackageId);
                }
                Reload();
                // find this package in new button list and click it to show update details
                string buttonName = PackageId.ToString();
                ((Button)pnlPackages.Controls[buttonName]).PerformClick();
            }
        }

        private void btnDeletePackage_Click(object sender, EventArgs e)
        {
            // Make sure user wants to delete
            if (MessageBox.Show("Are you sure you wish to delete package: " + currentPackage.PkgName, "Delete Package", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // remove products attached to package
                currentPackage.RemoveProducts();

                // delete package
                currentPackage.Delete();
            }
            Reload();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMain guiDashBoard = new frmMain(); //Instantiate a new form
            guiDashBoard.ShowDialog();
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
