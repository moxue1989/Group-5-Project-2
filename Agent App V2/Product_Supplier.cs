using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_App_V2
{
    public class Product_Supplier
    {
        [Browsable(false)]
        public int ProductSupplierId { get; set; }
        [Browsable(false)]
        public int ProductId { get; set; }
        [Browsable(false)]
        public int SupplierId { get; set; }
        public string ProdName { get; set; }
        public string SupName { get; set; }

        public string[] toListViewItem()
        {
            string[] item = new string[2];
            item[0] = ProdName;
            item[1] = SupName;
            return item;
        }

        public void AddToPackage(int packageId)
        {
            PackageDB.AddPSByID(packageId, this.ProductSupplierId);
        }
    }
}
