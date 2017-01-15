namespace Agent_App_V2
{
    public class Supplier
    {
        public static List<Supplier> AllSuppliers = TravelExpertsDB.GetSuppliers();
        public int SupplierId { get; set; }
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
