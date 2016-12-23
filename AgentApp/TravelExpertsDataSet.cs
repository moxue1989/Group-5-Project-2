using System.Data;
using System.Runtime.CompilerServices;

namespace AgentApp
{


    public partial class TravelExpertsDataSet
    {
        partial class PackagesDataTable
        {
            public override void BeginInit()
            {
                //this.ColumnChanging += PackagesDataTable_ColumnChanging;
                //this.PackagesRowChanging += Packages_PackagesRowChanging;
                this.TableNewRow += Packages_TableNewRow;
            }

            private void Packages_TableNewRow(object sender, DataTableNewRowEventArgs e)
            {
                TravelExpertsDataSet.PackagesRow pkgRow = null;
                pkgRow = ((TravelExpertsDataSet.PackagesRow)(e.Row));

            }
        }
    }
}
