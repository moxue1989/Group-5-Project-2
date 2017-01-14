using System.ComponentModel;

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

        public void AddProductToSupp(int SupplierId)//method to update products
        {
            //ProductsSuppliersDB.AddToProdSupp(SupplierId, ProductId, ProductSupplierId);
        }

        public void RemoveProduct(int SupplierId)
        {
            ProductsSuppliersDB.RemoveProdFromSupp(this);
        }

        public string[] toListViewItem()
        {
            string[] item = new string[2];
            item[0] = ProdName;
            item[1] = SupName;
            return item;
        }

        public void AddToPackage(int packageId)
        {
            PackageDB.AddPSByID(packageId, ProductSupplierId);
        }

        
        
    }
}
