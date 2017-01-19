using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Workshop
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Customer"] != null)
            {
                var customer = (Customer) Session["Customer"];
                lblWelcome.Text = "Welcome Back " + customer.CustFirstName + " " + customer.CustLastName;
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}