using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Workshop
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string username;
        private string password;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;
            Customer cust = TravelExpertsDB.GetCustomer(username, password);
            if (cust.CustFirstName != null)
            {
                Session["Customer"] = cust;
                Response.Redirect("CustomerLanding.aspx");
            }
            else
            {
                lblLoginError.Text = "Wrong Username or Password!";
            }
        }
    }
}