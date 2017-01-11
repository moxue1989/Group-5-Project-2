using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;

namespace Agent_App_V2
{
    public static class TravelExpertsDB
    {
        public static List<Product> GetAllProducts()
        {
            var products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                pps.AddRange(conn.Query<Package_Product_Supplier>(Settings.productSuppliersQuery, new { packageId }));

            }
            return products;
        }
      
              public static List<Supplier> GetAllSuppliers()
        {
            var suppliers = new List<Supplier>();
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                suppliers.AddRange(conn.Query<Supplier>(Settings.GetAllSuppliersQuery));
            }
            return suppliers;
                
        //coded by Kasi Emmanuel
        public static List<Product> GetProducts()
        {
            //var prod = new List<Product>();
           
            using (SqlConnection con = new SqlConnection(Settings.connectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    //prod.AddRange(con.Query<Product>(Settings.productsQuery));
                }
                con.Close();
                return con.Query<Product>(Settings.productsQuery).ToList();
                //return prod;
            }
        }
        //coded by Kasi Emmanuel
        public static List<Product> GetProductSuppBySuppID(int supplierId)
        {
            //var prod = new List<Product_Supplier>();
            using (SqlConnection con = new SqlConnection(Settings.connectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                return con.Query<Product>(Settings.productSupplierSP, new { SupplierId = supplierId }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        //coded by Kasi Emmanuel
        public static List<Supplier> GetSuppliers()
        {
            using (SqlConnection con = new SqlConnection(Settings.connectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                con.Close();
                return con.Query<Supplier>(Settings.supplierQuery).ToList();
            }
        }
        //coded by Kasi Emmanuel
        public static int UpdateCustomer(Product_Supplier newProds)
        {

            using (SqlConnection con = new SqlConnection(Settings.connectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    
                }
                int rowsAffectd = con.Execute(Settings.addProductQuery, newProds);
                Settings.SetIdentity<int>(con, id => newProds.SupplierId = id);

                con.Close();
                return rowsAffectd;
               
            }
            
        }

    }
}
