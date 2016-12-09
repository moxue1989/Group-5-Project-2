using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentApp
{
    public class Supplier
    {
        int Supplier_ID { get; set; }
        string Supplier_Name { get; set; }

        //constructor with default initial values provided
        public Supplier(int id = 0, string name = "")
        {
            Supplier_ID = id;
            Supplier_Name = name;
        }
    }
}
