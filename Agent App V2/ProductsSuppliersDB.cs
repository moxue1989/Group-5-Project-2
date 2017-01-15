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
            //var prod = new List<Product>();

            using (SqlConnection con = new SqlConnection(Settings.connectionString2))
            {
                con.Open();

                return con.Query<Product>(Settings.productsQuery).ToList();
                //return prod;
            }
        }

        //coded by Kasi Emmanuel
        public static List<Product> GetProductSuppBySuppID(int supplierId)
        {
            //var prod = new List<Product_Supplier>();
            using (SqlConnection con = new SqlConnection(Settings.connectionString2))
            {
                con.Open();

                return con.Query<Product>(Settings.ProductSupplierSp, new {SupplierId = supplierId}).ToList();
               
            }
        }

        //coded by Kasi Emmanuel
        public static List<Product> GetProductNotInProdSuppBySuppID(int supplierId)
        {

            using (SqlConnection con = new SqlConnection(Settings.connectionString2))
            {
                con.Open();

                return con.Query<Product>(Settings.GetNotAddedProdSuppQuery, new {supplierId}).ToList();
            }
        }

        //coded by Kasi Emmanuel
        public static List<Supplier> GetSuppliers()
        {
            using (SqlConnection con = new SqlConnection(Settings.connectionString2))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                con.Close();
                return con.Query<Supplier>(Settings.suppQuery).ToList();
            }
        }

        //coded by Kasi Emmanuel
        //public static int AddToProdSupp(int supplierId, int productId, int prodSupp)
        //{
        //    int add = 0;

        //    //int productSupplier;
        //    using (SqlConnection con = new SqlConnection(Settings.connectionString2))
        //    {
        //        con.Open();

        //        add = con.Execute(Settings.AddProdToSuppByIDQuery, new {supplierId, productId, prodSupp });
        //        add = Convert.ToInt32(con.ExecuteScalar(Settings.LastProdSuppQuery));
        //        return add;

        //    }

        //}
        public static int AddToProdSupp(Product_Supplier prodSupp)
        {
            int add = 0;

            //int productSupplier;
            using (SqlConnection con = new SqlConnection(Settings.connectionString2))
            {
                con.Open();

                con.Execute(Settings.AddProdToSuppByIDQuery, new { prodSupp.SupplierId, prodSupp.ProductId });
                add = Convert.ToInt32(con.ExecuteScalar(Settings.LastProdSuppQuery));
                return add;

            }

        }
        public static int RemoveProdFromSupp(Product_Supplier prodSupp)
        {
            int status;
            using (SqlConnection con = new SqlConnection(Settings.connectionString2))
            {
                con.Open();
                status = con.Execute(Settings.RemoveProdsFromSuppQuery, new {prodSupp.ProductSupplierId, prodSupp.SupplierId, prodSupp.ProductId});
            }
            return status;
        }
    }
}
