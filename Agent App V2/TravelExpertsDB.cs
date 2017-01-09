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
        public static List<Package_Product_Supplier> GetPPS(int packageId)
        {
            var pps = new List<Package_Product_Supplier>();
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                pps.AddRange(conn.Query<Package_Product_Supplier>(Settings.productSuppliersQuery, new {packageId}));
            }
            return pps;
        }

        public static Product_Supplier GetProductSupplier(int productSupplierId)
        {
            var ps = new Product_Supplier();
        }
    }
}
