using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentApp
{
    public class Product
    {
        int ProductId { get; set; }
        string ProdName { get; set; }

        //constructor with default initial values provided
        //public Product (int id = 0, string name = "")
        //{
        //    ProductId = id;
        //    ProdName = name;
        public override string ToString()
        {
            return ProductId + " " + ProdName;
        }
    }
}

