using System;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Agent_App_V2
{
    public static class Settings
    {
        /// <summary>
        /// Modify this connection string to work with local database!
        /// </summary>
        public static string connectionString =
            @"Data Source=ICTVM-M1JAMLFO8\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";
             //@"Data Source=ICTVM-FQQ06UJG2\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";

        public static string connectionString2 = @"Data Source=ICTVM-M1JAMLFO8\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";
            //"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\TravelExperts.mdf;Integrated Security=True;Connect Timeout=30";



        /// <summary>
        /// Modify this connection string to work with local database!
        /// </summary>

       // Agent Login Query

        public static string GetAgentQuery =
            @"Select * from Agents where AgtFirstName = @AgtFirstName and AgtPassword = @AgtPassword";

        /// 
        /// KASI SQL QUERIES
        /// 
        /// 
        /// 
        //PRODUCTS SQL QUERIES
       
       
        public static string productsQuery = @"SELECT * FROM [Products]";


        public static string AddProductsQuery = @"INSERT INTO Products VALUES (@ProdName); SELECT CAST(SCOPE_IDENTITY() as int)";

        public static string UpdateProductQuery = @"UPDATE Products SET ProdName = @ProdName " + 
            "WHERE ProductId = @ProductId";

        public static string DeleteProductQuery =@"DELETE FROM Products WHERE ProductId = @ProductId";

        public static string LastProductQuery =
            @"SELECT IDENT_CURRENT('Products')";

        //public static string AddSupplierQuery = @"INSERT INTO Supplier VALUES (@SupplierId, @SupName)";


        /// 
        /// KASI SQL QUERIES
        /// 
        //SUPPLIERS SQL QUERIES


        public static string suppQuery = @"SELECT SupplierId, SupName FROM [Suppliers]";

        public static string AddSuppliersQuery = @"INSERT INTO Suppliers Values (((SELECT MAX(SupplierId) FROM Suppliers) + 1), @SupName)";

        public static string LastSuppQuery =
            @"SELECT IDENT_CURRENT('Suppliers')";

        public static string UpdateSuppliersQuery = 
            @"UPDATE Suppliers SET SupName = @SupName " +
            "WHERE SupplierId = @SupplierId";

        public static string DeleteSuppQuery = 
            @"DELETE FROM Suppliers WHERE SupplierId = @SupplierId";


        /// 
        /// KASI SQL QUERIES
        /// 
        //PRODUCT SUPPLIER SQL QUERIES
        public static string ProductSupplierSp =
            @"select p.ProductId, p.ProdName,s.SupplierId, s.SupName, ps.ProductSupplierId " + 
            "from Products_Suppliers ps inner join Suppliers s " + 
            "on ps.SupplierId = s.SupplierId inner join Products p " + 
            "on p.ProductId = ps.ProductId " + 
            "where s.SupplierId= @SupplierId";
       

        public static string AddProdToSuppByIDQuery = 
            @"INSERT INTO Products_Suppliers " + 
            "(ProductId, SupplierId) " +
            "VALUES (@ProductId, @SupplierId); SELECT CAST(SCOPE_IDENTITY() as int)";

        public static string LastProdSuppQuery =
            @"SELECT IDENT_CURRENT('Products_Suppliers')";


        public static string GetNotAddedProdSuppQuery = @"SELECT * FROM Products WHERE ProductId not in " + 
                                                             "(select productId from Products_Suppliers WHERE SupplierId = @SupplierId)";

        public static string RemoveProdsFromSuppQuery = @"DELETE FROM Products_Suppliers " + 
            "WHERE " + 
            "SupplierId = @SupplierId and ProductId = @ProductId";

        





        /// Package SQL Queries
        /// 
        /// Coded by Mo Xue
        public static string GetPackagesQuery =
            @"SELECT PackageId,PkgName,PkgStartDate,PkgEndDate,PkgDesc,
                PkgBasePrice,PkgAgencyCommission
            FROM Packages ORDER BY PkgStartDate desc";

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
