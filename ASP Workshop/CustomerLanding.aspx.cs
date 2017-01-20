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
        List<Booking> bookings = new List<Booking>();
        List<BookingDetail> details = new List<BookingDetail>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Customer"] != null)
            {
                if (!IsPostBack)
                {
                    var customer = (Customer) Session["Customer"];
                    lblWelcome.Text = "Welcome Back " + customer.CustFirstName + " " + customer.CustLastName;
                    bookings = TravelExpertsDB.GetBookings(customer.CustomerId);
                    Session["Bookings"] = bookings;
                    gvBookings.DataSource = bookings;
                    gvBookings.DataBind();
                    ddlBookings.DataSource = bookings;
                    ddlBookings.DataTextField = "BookingId";
                    ddlBookings.DataValueField = "BookingId";
                    ddlBookings.DataBind();
                }
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void ddlBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ddlBookings.SelectedIndex;
            Booking booking = ((List<Booking>)Session["Bookings"])[index];
            details = TravelExpertsDB.GetBookingDetails(booking.BookingId);
            gvDetails.DataSource = details;
            gvDetails.DataBind();
        }
    }
}