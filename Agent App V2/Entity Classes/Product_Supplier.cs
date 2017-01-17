using System.ComponentModel;

namespace Agent_App_V2
{
    public class Product_Supplier
    {
        /// <summary>
        /// Product Supplier class
        /// Methods to get product and supplier names from database
        /// C# workshop project
        /// Written By: Mo Xue
        /// </summary>
        [Browsable(false)]
        public int ProductSupplierId { get; set; }
        [Browsable(false)]
        public int ProductId { get; set; }
        [Browsable(false)]
        public int SupplierId { get; set; }
        [DisplayName("Product Name")]
        public string ProdName { get; set; }
        [DisplayName("Supplier Name")]
        public string SupName { get; set; }

        // convert to listview item for display
        public string[] toListViewItem()
        {
            string[] item = new string[2];
            item[0] = GetProductName();
            item[1] = GetSupplierName();
            return item;
        }

        public string GetSupplierName()
        {
            return SupName;
            //Public static method of getting name using LINQ
            //string SupplierName = (from sup in Supplier.AllSuppliers
            //    where sup.SupplierId == SupplierId
            //    select sup.SupName).First();
            //return SupplierName;
        }

        public string GetProductName()
        {
            return ProdName;
            //Public static method of getting name using LINQ
            //string ProductName = (from prod in Product.AllProducts
            //    where prod.ProductId == ProductId
            //    select prod.ProdName).First();
            //return ProductName;
        }

        // add this product to a package
        public void AddToPackage(int packageId)
        {
            PackageDB.AddPSByID(packageId, ProductSupplierId);
        }

        
        
    }
}
