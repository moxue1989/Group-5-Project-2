using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Workshop
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Written by Kasi Emmanuel
        //Redirect to Customer page
        protected void AccountDetails_Click(object sender, EventArgs e)
        {
            if (Session["Customer"] != null)
            {
                Response.Redirect("Customer.aspx");
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        //Written by Kasi Emmanuel
        //Redirect to Bookings Details page
        protected void BookingDetails_Click(object sender, EventArgs e)
        {
            if (Session["Customer"] != null)
            {
                Response.Redirect("Purchases.aspx");
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}