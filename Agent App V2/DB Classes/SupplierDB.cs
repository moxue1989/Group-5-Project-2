using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Agent_App_V2
{
    public static class SupplierDB
    {
        public static int AddSupplier(Supplier supp)
        {
            int returnId = 0;
            using (SqlConnection conn = new SqlConnection(Settings.connectionString2))
            {
                try
                {
                    conn.Open();
                    conn.Execute(Settings.AddSuppliersQuery, new { supp.SupplierId, supp.SupName });
                    returnId = Convert.ToInt32(conn.ExecuteScalar(Settings.LastSuppQuery));
                    //returnId = conn.Query(Settings.AddSuppliersQuery, supp).SingleOrDefault();

                    ///supp.SupplierId = returnId;
                }
                catch (Exception ex)
                {
                    throw ex;
                }


                return returnId;
            }
        }
        public static bool UpdateSupplier(Supplier supp)
        {
            bool suppId = false;
            using (SqlConnection conn = new SqlConnection(Settings.connectionString2))
            {
                conn.Open();

                var count = conn.Execute(Settings.UpdateSuppliersQuery, supp);
                return count > 0;

                //conn.Execute(Settings.UpdateSupplierQuery, new { supp.ProdName });
                //suppId = Convert.ToInt32(conn.ExecuteScalar(Settings.LastSupplierQuery));
                //return suppId;
            }

        }

        public static int DeleteSupplier(Supplier supp)
        {
            int status;
            using (SqlConnection conn = new SqlConnection(Settings.connectionString2))
            {
                
                conn.Open();
                status = conn.Execute(Settings.DeleteSuppQuery, new { supp.SupplierId });
            }
            return status;
        }
    }
}
