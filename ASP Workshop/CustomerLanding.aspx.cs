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
                var customer = (Customer) Session["Customer"];
                Session["CustomerId"] = customer.CustomerId;

                lblWelcome.Text = "Welcome Back " + customer.CustFirstName + " " + customer.CustLastName;
                bookings = TravelExpertsDB.GetBookings(customer.CustomerId);
                Session["Bookings"] = bookings;

                decimal totalCost = 0;
                foreach (var book in bookings)
                {
                    totalCost += book.GetTotal();
                }
                txtTotalCost.Text = totalCost.ToString("c");
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void gvBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gvBookings.SelectedIndex;
            Booking booking = bookings[index];
            details = TravelExpertsDB.GetBookingDetails(booking.BookingId);

            decimal bookingTotal = 0;
            foreach (var detail in details)
            {
                bookingTotal += detail.GetTotal();
            }
            txtBookingTotal.Text = bookingTotal.ToString("c");
        }
    }
}