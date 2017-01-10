using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_App_V2
{
    public static class Settings
    {
        public static string connectionString =
            @"Data Source=ICTVM-M1JAMLFO8\SQLEXPRESS;Initial
            Catalog=TravelExperts;Integrated Security=True";

        public static string productSuppliersQuery =
            @"SELECT [ProductSupplierId], [ProductId], [SupplierId]
            FROM [Products_Suppliers] ps, [Packages_Products_Suppliers] pps
            WHERE ps.[ProductSupplierId] = pps.[ProductSupplierId]
            AND pps.[PackageId] = @PackageID";

        public static string productsQuery =
            @"SELECT * FROM [Products]";

        public static string productSupplierSP =
            @"spGetProdSuppByProdID";
    }
}
