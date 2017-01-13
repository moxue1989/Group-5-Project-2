using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Agent_App_V2
{
    public static class ProductDB
    {
        public static int AddProduct(Product product)
        {
            int returnId = 0;
            using (SqlConnection conn = new SqlConnection(Settings.connectionString2))
            {
                try
                {
                    conn.Open();
                    conn.Execute(Settings.AddProductsQuery, new {product.ProdName});
                    returnId = Convert.ToInt32(conn.ExecuteScalar(Settings.LastProductQuery));
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
            using (SqlConnection conn = new SqlConnection(Settings.connectionString2))
            {
                conn.Open();

                var count = conn.Execute(Settings.UpdateProductQuery, product);
                return count > 0;

                //conn.Execute(Settings.UpdateProductQuery, new { product.ProdName });
                //productId = Convert.ToInt32(conn.ExecuteScalar(Settings.LastProductQuery));
                //return productId;
            }

        }

        public static int DeleteProduct(Product product)
        {
            int status;
            using (SqlConnection conn = new SqlConnection(Settings.connectionString2))
            {
                conn.Open();
                status = conn.Execute(Settings.DeleteProductQuery, new {product.ProductId});
            }
            return status;
        }
    }
}
