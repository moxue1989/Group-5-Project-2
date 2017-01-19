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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
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