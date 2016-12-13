using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentApp
{
    public static class DatabaseAccess
    {
        //comment
        private static SqlConnection SqlConnect()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ICTVM-FQQ06UJG2\SQLEXPRESS;" + "Database=TravelExperts;" + "User id=sa;" + "Password=sa;");

            //conn.ConnectionString = @"Data Source=ICTVM-FQQ06UJG2\SQLEXPRESS;" +
            //                        "Database=TravelExperts;" +
            //                        "User id=sa;" +
            //                        "Password=sa;";
            return conn;
        }

        public static void SqlQuery(string sqlString)
        {
            try
            {
                SqlDataReader dataReader = null;
                SqlConnection conn = SqlConnect();
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

        //    List<string> data = new List<string>();
        //            while (dataReader.Read())
        //            {
        //                data.Add(dataReader["CustLastName"].ToString());
        //            }
        //MessageBox.Show(data[4].ToString());

    }
}