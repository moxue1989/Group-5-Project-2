using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace Agent_App_V2
{
    /// <summary>
    /// Database access class for package forms
    /// Uses "Dapper" to map data to objects
    /// C# workshop project
    /// Written By: Mo Xue
    /// </summary>
    public static class PackageDB
    {
        // get all packages from database
        public static List<Package> GetPackages()
        {
            var packageList = new List<Package>();
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                packageList.AddRange(conn.Query<Package>(Settings.GetPackagesQuery));
            }
            return packageList;
        }

        // get all Product suppliers from database
        public static List<Product_Supplier> GetAllPS()
        {
            var psList = new List<Product_Supplier>();
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                psList.AddRange(conn.Query<Product_Supplier>(Settings.GetAllPSQuery));
            }
            return psList;
        }

        // get products suppliers for a single package
        public static List<Product_Supplier> GetAddedPS(int packageId)
        {
            var psList = new List<Product_Supplier>();
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                psList.AddRange(conn.Query<Product_Supplier>(Settings.GetAddedPSQuery, new { packageId }));
            }
            return psList;
        }

        // get available product suppliers for a single package
        public static List<Product_Supplier> GetNotAddedPS(int packageId)
        {
            var psList = new List<Product_Supplier>();
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                psList.AddRange(conn.Query<Product_Supplier>(Settings.GetNotAddedPSQuery, new { packageId }));
            }
            return psList;
        }

        // update package details
        public static int UpdatePackage(Package package)
        {
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                return conn.Execute(Settings.UpdatePackageQuery, new {package.PkgName, package.PkgStartDate, package.PkgEndDate,package.PkgDesc,package.PkgBasePrice,package.PkgAgencyCommission, package.PackageId});
            }
        }

        // add new package
        public static int AddPackage(Package package)
        {
            int packageId;
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                conn.Execute(Settings.AddPackageQuery, new { package.PkgName, package.PkgStartDate, package.PkgEndDate, package.PkgDesc, package.PkgBasePrice, package.PkgAgencyCommission });
                packageId = Convert.ToInt32(conn.ExecuteScalar(Settings.LastPackageQuery));
                return packageId;
            }
        }

        // delete existing package
        public static int DeletePackage(Package package)
        {
            int status;
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                status = conn.Execute(Settings.RemovePackageQuery, new { package.PackageId });
            }
            return status;
        }

        // delete all products for a single package
        public static int RemoveAllPSForPkg(int packageId)
        {
            int status;
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                status = conn.Execute(Settings.RemoveAllPSForPkgQuery, new { packageId });
            }
            return status;
        }

        // add a product to a package
        public static int AddPSByID(int packageId, int psId)
        {
            int status;
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                status = conn.Execute(Settings.AddPSByIDQuery, new {packageId, psId});
            }
            return status;
        }

        // Remove a product supplier from all packages
        public static void removePSFromAllPkg(Product_Supplier ps)
        {
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                conn.Execute(Settings.removePSFromAllPkgQuery, new { ps.ProductId, ps.SupplierId });
            }
        }
    }
}
