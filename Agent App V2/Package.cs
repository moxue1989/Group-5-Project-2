using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_App_V2
{
    public class Package
    {
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public DateTime PkgStartDate { get; set; }
        public DateTime PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal PkgAgencyCommission { get; set; }

        public List<Product_Supplier> GetAddedPS()
        {
            return PackageDB.GetAddedPS(PackageId);
        }

        public List<Product_Supplier> GetNotAddedPS()
        {
            return PackageDB.GetNotAddedPS(PackageId);
        }

        public int AddPackage()
        {
            return PackageDB.AddPackage(this);
        }

        public void Update()
        {
            PackageDB.UpdatePackage(this);
        }

        public void RemoveProducts()
        {
            PackageDB.RemoveAllPSForPkg(this.PackageId);
        }

        public void Delete()
        {
            PackageDB.DeletePackage(this);
        }
        //public override string ToString()
        //{
        //    return PkgName + PkgDesc + PkgStartDate;
        //}
    }
}
