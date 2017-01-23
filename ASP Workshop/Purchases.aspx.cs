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

                //lblWelcome.Text = "Welcome Back " + customer.CustFirstName + " " + customer.CustLastName;
                bookings = TravelExpertsDB.GetBookings(customer.CustomerId);
                Session["Bookings"] = bookings;

                decimal totalCost = 0;
                foreach (var book in bookings)
                {
                    totalCost += book.GetTotal();
                }
                txtTotalCost.Text = totalCost.ToString("c");
                CreateBookings();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        private void CreateBookings()
        {
            foreach(var booking in bookings)
            {
                Table tableBk = new Table();
                TableRow rowBkHead = new TableRow();
                TableCell[] cellsBkHead = new TableCell[4];
                cellsBkHead[0] = new TableCell();
                cellsBkHead[1] = new TableCell();
                cellsBkHead[2] = new TableCell();
                cellsBkHead[3] = new TableCell();
                cellsBkHead[0].Text = "Order Date";
                cellsBkHead[1].Text = "Booking Number";
                cellsBkHead[2].Text = "Traveller Count";
                cellsBkHead[3].Text = "Trip Type";
                rowBkHead.Cells.AddRange(cellsBkHead);
                tableBk.Rows.Add(rowBkHead);

                TableRow rowBkData = new TableRow();
                TableCell[] cellsBkData = new TableCell[4];
                cellsBkData[0] = new TableCell();
                cellsBkData[1] = new TableCell();
                cellsBkData[2] = new TableCell();
                cellsBkData[3] = new TableCell();
                cellsBkData[0].Text = booking.BookingDate.ToString("d");
                cellsBkData[1].Text = booking.BookingNo;
                cellsBkData[2].Text = booking.TravelerCount.ToString();
                cellsBkData[3].Text = booking.TTName;
                rowBkData.Cells.AddRange(cellsBkData);
                tableBk.Rows.Add(rowBkData);

                tableBk.CssClass = "table table-hover table-striped";
                pnlBookings.Controls.Add(tableBk);
                
                // details table
                details = TravelExpertsDB.GetBookingDetails(booking.BookingId);
                Table tableDt = new Table();

                TableRow rowDtHead = new TableRow();
                TableCell[] cellsDtHead = new TableCell[5];

                cellsDtHead[0] = new TableCell();
                cellsDtHead[1] = new TableCell();
                cellsDtHead[2] = new TableCell();
                cellsDtHead[3] = new TableCell();
                cellsDtHead[4] = new TableCell();
                cellsDtHead[0].Text = "Itinerary Number";
                cellsDtHead[1].Text = "Trip Start";
                cellsDtHead[2].Text = "Trip End";
                cellsDtHead[3].Text = "Description";
                cellsDtHead[4].Text = "Destination";

                rowDtHead.Cells.AddRange(cellsDtHead);
                tableDt.Rows.Add(rowDtHead);

                foreach (var detail in details)
                {
                    TableRow rowDtData = new TableRow();
                    TableCell[] cellsDtData = new TableCell[5];

                    cellsDtData[0] = new TableCell();
                    cellsDtData[1] = new TableCell();
                    cellsDtData[2] = new TableCell();
                    cellsDtData[3] = new TableCell();
                    cellsDtData[4] = new TableCell();
                    cellsDtData[0].Text = detail.ItineraryNo.ToString();
                    cellsDtData[1].Text = detail.TripStart?.ToString("d");
                    cellsDtData[2].Text = detail.TripEnd?.ToString("d");
                    cellsDtData[3].Text = detail.Description;
                    cellsDtData[4].Text = detail.Destination;

                    rowDtData.Cells.AddRange(cellsDtData);
                    tableDt.Rows.Add(rowDtData);
                }

                tableDt.CssClass = "table table-hover table-striped";
                pnlBookings.Controls.Add(tableDt);

                Label lbBkTotalHead = new Label();
                lbBkTotalHead.Text = "Booking Total";
                lbBkTotalHead.Width = 150;

                Label lbBkTotal = new Label();
                lbBkTotal.Width = 150;
                lbBkTotal.Text = booking.GetTotal().ToString("c");

                pnlBookings.Controls.Add(lbBkTotalHead);
                pnlBookings.Controls.Add(lbBkTotal);


                //GridView gvBookings2 = new GridView();
                //List<Booking> bookingData = new List<Booking>();
                //bookingData.Add(bookings[i]);
                //gvBookings2.AutoGenerateColumns = false;

                //BoundField boundfield = new BoundField();
                //boundfield.DataField = dt.Columns[i].ColumnName.ToString();
                //boundfield.HeaderText = dt.Columns[i].ColumnName.ToString();
                //gvEmployee.Columns.Add(boundfield);

                //gvBookings2.DataSource = bookingData;
                //gvBookings2.DataBind();
                //gvBookings2.CssClass = "table table-hover table-striped";
                //pnlBookings.Controls.Add(gvBookings2);

                //details = TravelExpertsDB.GetBookingDetails(bookings[i].BookingId);
                //GridView gvDetails = new GridView();
                //gvDetails.DataSource = details;
                //gvDetails.DataBind();
                //gvDetails.CssClass = "table table-hover table-striped";
                //pnlBookings.Controls.Add(gvDetails);
            }
        }

        protected void gvBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = gvBookings.SelectedIndex;
            //Booking booking = bookings[index];
            //details = TravelExpertsDB.GetBookingDetails(booking.BookingId);

            //decimal bookingTotal = 0;
            //foreach (var detail in details)
            //{
            //    bookingTotal += detail.GetTotal();
            //}
            //txtBookingTotal.Text = bookingTotal.ToString("c");
        }
    }
}