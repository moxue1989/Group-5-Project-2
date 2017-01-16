using System;
using System.Data.SqlClient;
using System.Windows.Forms;
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
                try
                {
                    con.Open();

                    var count = con.Execute(Settings.UpdateProductQuery, product);

                    return count > 0;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

        }

        public static int DeleteProduct(Product product)
        {
            int status;
            using (SqlConnection con = new SqlConnection(Settings.connectionString2))
            {
                try
                {
                    con.Open();
                    status = con.Execute(Settings.DeleteProductQuery, new {product.ProductId});
                }
                catch (Exception ex)
                {
                    
                    throw ex;
                }
                return status;
            }
            
        }
    }
}
