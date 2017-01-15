using System;
using System.Data.SqlClient;
using Dapper;

namespace Agent_App_V2
{
    public static class ProductDB
    {
        public static int AddProduct(Product product)
        {
            int returnId = 0;
            using (SqlConnection con = new SqlConnection(Settings.connectionString2))
            {
                try
                {
                    con.Open();
                    con.Execute(Settings.AddProductsQuery, new {product.ProdName});
                    returnId = Convert.ToInt32(con.ExecuteScalar(Settings.LastProductQuery));
                    //returnId = conn.Query(Settings.AddProductsQuery, product).SingleOrDefault();

                    //product.ProductId = returnId;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                
                return returnId;
            }
        }
        public static bool UpdateProduct(Product product)
        {
            bool productId = false;
            using (SqlConnection con = new SqlConnection(Settings.connectionString2))
            {
                con.Open();

                var count = con.Execute(Settings.UpdateProductQuery, product);
                return count > 0;

                //conn.Execute(Settings.UpdateProductQuery, new { product.ProdName });
                //productId = Convert.ToInt32(conn.ExecuteScalar(Settings.LastProductQuery));
                //return productId;
            }

        }

        public static int DeleteProduct(Product product)
        {
            int status;
            using (SqlConnection con = new SqlConnection(Settings.connectionString2))
            {
                con.Open();
                status = con.Execute(Settings.DeleteProductQuery, new {product.ProductId});
            }
            return status;
        }
    }
}
