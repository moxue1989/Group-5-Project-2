using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Agent_App_V2
{
    public static class Settings
    {

        public static string connectionString =
             @"Data Source=ICTVM-FQQ06UJG2\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";
      
        //coded by Kasi Emmanuel
        public static void SetIdentity<T>(SqlConnection connection, Action<T> setId)
        {
            dynamic identity = connection.Query("SELECT @@IDENTITY AS Id").Single();
            T newId = (T)identity.Id;
            setId(newId);
        }
        //coded by Kasi Emmanuel
        public static string productsQuery = @"SELECT * FROM [Products]";
        //coded by Kasi Emmanuel
        public static string supplierQuery = @"SELECT SupplierId, SupName FROM [Suppliers]";
        //coded by Kasi Emmanuel
        public static string productSupplierSP = @"spGetProdSuppByProdID";
        //coded by Kasi Emmanuel
        public static string addProductQuery = "INSERT INTO Products_Suppliers " + "(ProductSupplierId, ProductId, SupplierId) " + "VALUES (@ProductSupplierId, @ProductId, @SupplierId)";


        ///
        /// frmPackage Queries
        /// Mo Xue
        public static string GetPackagesQuery =
            @"SELECT PackageId,PkgName,PkgStartDate,PkgEndDate,PkgDesc,
                PkgBasePrice,PkgAgencyCommission
            FROM Packages";

        public static string GetAllPSQuery =
            @"  SELECT ps.ProductSupplierId,p.ProductId,s.SupplierId,p.ProdName,s.SupName
            FROM Products_Suppliers ps,
				Products p, Suppliers s
			WHERE ps.ProductId = p.ProductId
			AND ps.SupplierId = s.SupplierId
            ORDER BY ProductId";

        public static string GetAddedPSQuery =
            @"  SELECT DISTINCT ps.ProductSupplierId,p.ProductId,s.SupplierId,p.ProdName,s.SupName
            FROM Products_Suppliers ps, Packages_Products_Suppliers pps,
				Products p, Suppliers s
            WHERE ps.ProductSupplierId = pps.ProductSupplierId
			AND ps.ProductId = p.ProductId
			AND ps.SupplierId = s.SupplierId
            AND pps.PackageId = @PackageId
            ORDER BY ProductId";

        public static string GetNotAddedPSQuery =
            @"SELECT DISTINCT ProductSupplierId,p.ProductId,s.SupplierId,p.ProdName,s.SupName
            FROM Products_Suppliers ps,Products p,Suppliers s
            WHERE p.ProductId = ps.ProductId
			AND s.SupplierId = ps.SupplierId
			AND	ProductSupplierId not in
			    (SELECT ps.ProductSupplierId
                FROM Products_Suppliers ps, Packages_Products_Suppliers pps
                WHERE ps.ProductSupplierId = pps.ProductSupplierId
			    AND pps.PackageId = @PackageId)
            ORDER BY ProductId";

        public static string UpdatePackageQuery =
            @"UPDATE Packages SET PkgName = @PkgName, PkgStartDate = @PkgStartDate, PkgEndDate = @PkgEndDate, PkgDesc = @PkgDesc, PkgBasePrice = @PkgBasePrice, PkgAgencyCommission = @PkgAgencyCommission
            WHERE PackageId = @PackageId";

        public static string AddPackageQuery =
            @"INSERT INTO Packages VALUES (@PkgName,@PkgStartDate,@PkgEndDate, @PkgDesc,@PkgBasePrice,@PkgAgencyCommission)";

        public static string LastPackageQuery =
            @"SELECT IDENT_CURRENT('Packages')";

        public static string RemovePackageQuery =
            @"DELETE FROM Packages
            WHERE PackageId = @PackageId";

        public static string RemoveAllPSForPkgQuery =
             @"DELETE FROM Packages_Products_Suppliers
            WHERE PackageId = @packageId";

        public static string AddPSByIDQuery =
            @"INSERT INTO Packages_Products_Suppliers
            (PackageId, ProductSupplierId) 
            values (@packageId, @psID)";

        public static string RemovePSByIDQuery =
            @"DELETE FROM Packages_Products_Suppliers
            WHERE PackageId = @packageId
            AND ProductSupplierId = @psID";

        public static string GetAllProductsQuery =
            @"SELECT [ProductId],[ProdName]
            FROM [Products]";

        public static string GetAllSuppliersQuery =
           @"SELECT [SupplierId],[SupName]
            FROM [Suppliers]";

    }
}
