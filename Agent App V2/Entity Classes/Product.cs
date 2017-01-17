using System.Collections.Generic;
using System.ComponentModel;

namespace Agent_App_V2
{
    public class Product
    {   
        [Browsable(false)]
        public int ProductId { get; set; }
        [DisplayName("Product Name")]
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
