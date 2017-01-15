using System;
using System.Collections.Generic;

namespace Agent_App_V2
{
    /// <summary>
    /// Package class
    /// Methods to add, modify, and add products to package
    /// C# workshop project
    /// Written By: Mo Xue
    /// </summary>
    public class Package
    {
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public DateTime PkgStartDate { get; set; }
        public DateTime PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal PkgAgencyCommission { get; set; }

        // get list of added products
        public List<Product_Supplier> GetAddedPS()
        {
            return PackageDB.GetAddedPS(PackageId);
        }

        // get list of available suppliers
        public List<Product_Supplier> GetNotAddedPS()
        {
            return PackageDB.GetNotAddedPS(PackageId);
        }

        // add this package to database
        public int AddPackage()
        {
            return PackageDB.AddPackage(this);
        }

        // update this package
        public void Update()
        {
            PackageDB.UpdatePackage(this);
        }

        // removes products for this package
        public void RemoveProducts()
        {
            PackageDB.RemoveAllPSForPkg(PackageId);
        }

        // delete this package
        public void Delete()
        {
            PackageDB.DeletePackage(this);
        }
    }
}
