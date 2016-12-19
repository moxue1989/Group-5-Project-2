using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentApp
{
    public partial class frmUserLogin : Form
    {
        public frmUserLogin()
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
                this.Hide();
                frmGUI gui = new frmGUI();
                gui.Show();
                
            }
            else
            {
                MessageBox.Show("Invalid username or password. \n  Please try again", "User Authentication Error");
            }

        }
        
    }
}
