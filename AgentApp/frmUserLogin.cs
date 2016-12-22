using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgentApp
{
    public partial class FrmUserLogin : Form
    {
        public FrmUserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=ICTVM-M1JAMLFO8\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Agents WHERE AgtFirstName = '"+ txtUserName.Text +"' AND AgtPassword = '"+ txtPassword.Text +"'",con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Hide();
                FrmMainGui gui = new FrmMainGui();
                gui.Show();
                
            }
            else
            {
                MessageBox.Show(@"Invalid username or password. \n  Please try again", @"User Authentication Error");
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
