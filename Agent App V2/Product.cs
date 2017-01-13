using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_App_V2
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProdName { get; set; }

        public void UpdateProd()
        {
            ProductDB.UpdateProduct(this);
        }
        public void Delete()
        {
            ProductDB.DeleteProduct(this);
        }

        public override string ToString()
        {
            return ProdName;
        }
    }
    
}
