using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Agent_App_V2
{
    public static class TravelExpertsDB
    {
        

        public static List<Product> GetAllProducts()
        {
            var products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                products.AddRange(conn.Query<Product>(Settings.GetAllProductsQuery));
            }
            return products;
        }

        public static List<Supplier> GetAllSuppliers()
        {
            var suppliers = new List<Supplier>();
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                suppliers.AddRange(conn.Query<Supplier>(Settings.GetAllSuppliersQuery));
            }
            return suppliers;
        }
    }
}
