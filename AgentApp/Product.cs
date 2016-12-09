using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentApp
{
    public class Product
    {
        int Product_ID { get; set; }
        string Product_Name { get; set; }

        //constructor with default initial values provided
        public Product (int id = 0, string name = "")
        {
            Product_ID = id;
            Product_Name = name;
        }
    }
}
