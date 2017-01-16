using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Agent_App_V2
{
    public static class ProductsSuppliersDB
    {

        //coded by Kasi Emmanuel
        public static List<Product> GetProducts()
        {
            using (SqlConnection con = new SqlConnection(Settings.connectionString2))
            {
                try
                {
                    con.Open();

                    return con.Query<Product>(Settings.productsQuery).ToList();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        //coded by Kasi Emmanuel
        public static List<Product> GetProductSuppBySuppID(int supplierId)
        {
            //var prod = new List<Product_Supplier>();
            using (SqlConnection con = new SqlConnection(Settings.connectionString2))
            {
                try
                {
                    con.Open();

                    return con.Query<Product>(Settings.ProductSupplierSp, new {SupplierId = supplierId}).ToList();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        //coded by Kasi Emmanuel
        public static List<Product> GetProductNotInProdSuppBySuppID(int supplierId)
        {

            using (SqlConnection con = new SqlConnection(Settings.connectionString2))
            {
                try
                {
                    con.Open();

                    return con.Query<Product>(Settings.GetNotAddedProdSuppQuery, new {supplierId}).ToList();
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }

        //coded by Kasi Emmanuel
        public static List<Supplier> GetSuppliers()
        {
            using (SqlConnection con = new SqlConnection(Settings.connectionString2))
            {
                try
                {
                    con.Open();

                    return con.Query<Supplier>(Settings.suppQuery).ToList();
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }

        public static int AddToProdSupp(Product_Supplier prodSupp)
        {
            int add = 0;

            //int productSupplier;
            using (SqlConnection con = new SqlConnection(Settings.connectionString2))
            {
                try
                {
                    con.Open();

                    con.Execute(Settings.AddProdToSuppByIDQuery, new {prodSupp.SupplierId, prodSupp.ProductId});
                    add = Convert.ToInt32(con.ExecuteScalar(Settings.LastProdSuppQuery));
                }
                catch (Exception ex)
                {

                    throw ex;
                }

                return add;

            }

        }

        public static int RemoveProdFromSupp(Product_Supplier prodSupp)
        {
            int status;
            using (SqlConnection con = new SqlConnection(Settings.connectionString2))
            {
                try
                {
                    con.Open();
                    status = con.Execute(Settings.RemoveProdsFromSuppQuery, new { prodSupp.ProductSupplierId, prodSupp.SupplierId, prodSupp.ProductId });
                }
                catch (Exception ex)
                {
                    
                    throw ex;
                }
                
            }
            return status;
        }
    }
}
