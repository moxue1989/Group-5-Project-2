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
        public static List<Product> GetProducts()
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

        public static void SqlQuery(string sqlString)
        {
            try
            {
                SqlDataReader dataReader = null;
                SqlConnection conn = new SqlConnection(@"Data Source=ICTVM-FQQ06UJG2\SQLEXPRESS;" + "Database=TravelExperts;" + "User id=sa;" + "Password=sa;");
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
            SqlConnection conn = new SqlConnection(@"Data Source=ICTVM-FQQ06UJG2\SQLEXPRESS;" + "Database=TravelExperts;" + "User id=sa;" + "Password=sa;");
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM " + tableName, conn);
            SqlCommandBuilder sqlCommand = new SqlCommandBuilder(sqlAdapter);
            sqlAdapter.Fill(data);
            return data;
        }

    }
}