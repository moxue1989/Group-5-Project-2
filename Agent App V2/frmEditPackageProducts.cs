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
    public partial class frmEditPackageProducts : Form
    {
        public Package Package { get; set; }
        private List<Product_Supplier> psAddedList = null;
        private List<Product_Supplier> psNotAddedList = null;

        public frmEditPackageProducts(Package package)
        {
            InitializeComponent();
            Package = package;
            lblPackageName.Text = Package.PkgName;
        }

        private void refresh()
        {
            psAddedList = Package.GetAddedPS();
            psNotAddedList = Package.GetNotAddedPS();
            lvAdded.Items.Clear();
            lvNotAdded.Items.Clear();

            foreach (var ps in psAddedList)
            {
                ListViewItem item = new ListViewItem(ps.toListViewItem());
                item.Tag = ps.ProductSupplierId;
                lvAdded.Items.Add(item);
            }

            foreach (var ps in psNotAddedList)
            {
                ListViewItem item = new ListViewItem(ps.toListViewItem());
                item.Tag = ps.ProductSupplierId;
                lvNotAdded.Items.Add(item);
            }
        }

        private void frmEditPackageProducts_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvAdded.SelectedItems.Count == 0)
            {
                MessageBox.Show("No product selected!","Remove Product");
            }
            else
            {
                int psId = Convert.ToInt32(lvAdded.SelectedItems[0].Tag);
                MessageBox.Show(Package.PackageId + " " + psId);
                //PackageDB.RemovePSByID(Package.PackageId, psId);
                refresh();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lvNotAdded.SelectedItems.Count == 0)
            {
                MessageBox.Show("No product selected!","Add Product");
            }
            else
            {
                int psId = Convert.ToInt32(lvNotAdded.SelectedItems[0].Tag);
                MessageBox.Show(Package.PackageId + " " + psId);
                PackageDB.AddPSByID(Package.PackageId, psId);
                refresh();
            }
        }
    }
}
