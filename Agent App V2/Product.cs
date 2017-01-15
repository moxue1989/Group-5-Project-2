namespace Agent_App_V2
{
    public class Product
    {
        public static List<Product> AllProducts = TravelExpertsDB.GetProducts();
        public int ProductId { get; set; }
        public string ProdName { get; set; }

        public void UpdateProd()//method to update products
        {
            ProductDB.UpdateProduct(this);
        }
        public void Delete()//method to delete products
        {
            ProductDB.DeleteProduct(this);
        }

        public override string ToString()
        {
            return ProdName;
        }
    }
    
}
