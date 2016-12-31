using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentApp
{
    public class Package
    {
        private int PackageId { get; set; }
        private string PkgName { get; set; }
        private string PkgStartDate { get; set; }
        private string PkgEndDate { get; set; }
        private string PkgDesc { get; set; }
        private decimal PkgBasePrice { get; set; }
        private decimal PkgAgencyCommission { get; set; }

        public override string ToString()
        {
            return PackageId + " " + PkgName + " " + PkgStartDate + " " + PkgEndDate + " " + PkgDesc + " " +
                   PkgBasePrice + " " + PkgAgencyCommission;
        }
    }
}
