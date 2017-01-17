using System.Collections.Generic;
using System.ComponentModel;

namespace Agent_App_V2
{
    public class Supplier
    {
        [Browsable(false)]
        public int SupplierId { get; set; }
        [DisplayName("Supplier Name")]
        public string SupName { get; set; }

        public void UpdateSupp()//method to update products
        {
            SupplierDB.UpdateSupplier(this);
        }
        public void DeleteSupp()//method to delete products
        {
            SupplierDB.DeleteSupplier(this);
        }

    }
}
