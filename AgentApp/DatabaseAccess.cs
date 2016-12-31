using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace AgentApp
{
    public static class DatabaseAccess
    {
        public static IList<Product> GetProducts()
        {
            var results = new List<Product>();
            using (SqlConnection conn = new SqlConnection(Settings.ConnectionString))
            {
                conn.Open();
                results.AddRange(conn.Query<Product>(Settings.ProductsQuery));
            }
            return results;
        }

        public static List<Package> GetPackages()
        {
            var results = new List<Package>();
            using (SqlConnection conn = new SqlConnection(Settings.ConnectionString))
            {
                conn.Open();
                results.AddRange(conn.Query<Package>(Settings.PackagesQuery));
            }
            return results;
        }

        public static DataTable GetProductsData()
        {
            DataTable data = new DataTable();

            using (SqlConnection conn = new SqlConnection(Settings.ConnectionString))
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(Settings.ProductsQuery, conn);
                SqlCommandBuilder command = new SqlCommandBuilder(sqlAdapter);
                sqlAdapter.Fill(data);

                DataRow newRow = data.NewRow();
                newRow[1] = "testProduct2";
                DataRow newRow2 = data.NewRow();
                newRow2[1] = "otherproduct";
                data.Rows.Add(newRow);
                data.Rows.Add(newRow2);
                //data.Rows[10].Delete();

                MessageBox.Show(sqlAdapter.Update(data).ToString());
                data.Clear();
                sqlAdapter.Fill(data);
            }
            return data;
        }

        public static void SqlQuery(string sqlString)
        {
            try
            {
                SqlDataReader dataReader = null;
                SqlConnection conn = new SqlConnection(Settings.ConnectionString);
                conn.Open();
                SqlCommand command = new SqlCommand(sqlString, conn);

                dataReader = command.ExecuteReader();
                List<string> data = new List<string>();
                dataReader.Read();
                MessageBox.Show(dataReader[4].ToString());
                while (dataReader.Read())
                {
                    data.Add(dataReader["CustLastName"].ToString());
                }
                MessageBox.Show(data[4]);
                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static DataTable GetData(string tableName)
        {
            DataTable data = new DataTable();
            SqlConnection conn = new SqlConnection(Settings.ConnectionString);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM " + tableName, conn);
            SqlCommandBuilder sqlCommand = new SqlCommandBuilder(sqlAdapter);
            sqlAdapter.Fill(data);
            return data;
        }

    }
}