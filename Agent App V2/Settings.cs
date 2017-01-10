using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Agent_App_V2
{
    public static class Settings
    {
        public static string connectionString =
            @"Data Source=ICTVM-M1JAMLFO8\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";

        //coded by Kasi Emmanuel
        public static void SetIdentity<T>(SqlConnection connection, Action<T> setId)
        {
            dynamic identity = connection.Query("SELECT @@IDENTITY AS Id").Single();
            T newId = (T)identity.Id;
            setId(newId);
        }

        public static string productSuppliersQuery =
            @"SELECT [ProductSupplierId], [ProductId], [SupplierId]
            FROM [Products_Suppliers] ps, [Packages_Products_Suppliers] pps
            WHERE ps.[ProductSupplierId] = pps.[ProductSupplierId]
            AND pps.[PackageId] = @PackageID";

        //coded by Kasi Emmanuel
        public static string productsQuery = @"SELECT * FROM [Products]";
        //coded by Kasi Emmanuel
        public static string supplierQuery = @"SELECT SupplierId, SupName FROM [Suppliers]";
        //coded by Kasi Emmanuel
        public static string productSupplierSP = @"spGetProdSuppByProdID";
        //coded by Kasi Emmanuel
        public static string addProductQuery = "INSERT INTO Products_Suppliers " + "(ProductSupplierId, ProductId, SupplierId) " + "VALUES (@ProductSupplierId, @ProductId, @SupplierId)";
    }
}
