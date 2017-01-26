using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Workshop
{
    /// <summary>
    /// Master File
    /// Stores user in Session
    /// Hide Navbar items when not required
    /// Display welcome message to customer
    /// Group 5 ASP.NET
    /// Mo Xue, Kasi Emmanuel
    /// </summary>
    public partial class Site : System.Web.UI.MasterPage
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Customer"] != null)
            {

                var customer = (Customer)Session["Customer"];
                Session["CustomerId"] = customer.CustomerId;

               
                CustomerMenu.Visible = true;//show account navbar item
                LogoutOption.Visible = true;//show logout button on navbar
                lblWelcome.Text = "Hello " + customer.CustFirstName + " " + customer.CustLastName;//display welcome message to customer
                
            }
            else
            {
            
                CustomerMenu.Visible = false;//hide account navbar item
                LogoutOption.Visible = false;//hide logout button item on navbar
            }
        }

        protected void Log_Out(object sender, EventArgs e)
        {
            Session.Clear();//clears the session
            Response.Redirect("Default.aspx");//redirect the customer to the customer portal page after session is cleared
        }
    }
}