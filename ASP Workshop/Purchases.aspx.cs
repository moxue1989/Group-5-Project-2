using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Workshop
{
    /// <summary>
    /// Bookings page
    /// Shows bookings and details and cost breakdown
    /// Group 5 ASP.NET
    /// Mo Xue, Kasi Emmanuel
    /// </summary>
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
                
                CreateBookings();
                lblTotalCost.Text = totalCost.ToString("c");
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
                // bookings row
                var divRowBk = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                divRowBk.Attributes.Add("class", "row");

                var divColTotal = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                divColTotal.Attributes.Add("class", "col-sm-12");

                var divColBk = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                divColBk.Attributes.Add("class", "col-sm-8 col-sm-offset-2");

               



                // details row
                var divRowDt = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                divRowDt.Attributes.Add("class", "row");
                
                var divColDt = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                divColDt.Attributes.Add("class", "col-sm-8 col-sm-offset-2");

                Table tableBk = new Table();
                TableHeaderRow rowBkHead = new TableHeaderRow();
                TableHeaderCell[] cellsBkHead = new TableHeaderCell[4];
                cellsBkHead[0] = new TableHeaderCell();
                cellsBkHead[1] = new TableHeaderCell();
                cellsBkHead[2] = new TableHeaderCell();
                cellsBkHead[3] = new TableHeaderCell();
                cellsBkHead[0].Text = "Order Date";
                cellsBkHead[1].Text = "Booking Number";
                cellsBkHead[2].Text = "Traveller Count";
                cellsBkHead[3].Text = "Trip Type";
                rowBkHead.Cells.AddRange(cellsBkHead);
                tableBk.Rows.Add(rowBkHead);
                rowBkHead.Attributes.Add("style", "background-color: teal; color: whitesmoke;");

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

                tableBk.CssClass = "table table-responsive";

                
                // details table
                details = TravelExpertsDB.GetBookingDetails(booking.BookingId);
                Table tableDt = new Table();
                TableHeaderRow rowDtHead = new TableHeaderRow();
                TableHeaderCell[] cellsDtHead = new TableHeaderCell[5];

                cellsDtHead[0] = new TableHeaderCell();
                cellsDtHead[1] = new TableHeaderCell();
                cellsDtHead[2] = new TableHeaderCell();
                cellsDtHead[3] = new TableHeaderCell();
                cellsDtHead[4] = new TableHeaderCell();
                cellsDtHead[0].Text = "Itinerary Number";
                cellsDtHead[1].Text = "Trip Start";
                cellsDtHead[2].Text = "Trip End";
                cellsDtHead[3].Text = "Description";
                cellsDtHead[4].Text = "Destination";

                rowDtHead.Cells.AddRange(cellsDtHead);
                tableDt.Rows.Add(rowDtHead);
                rowDtHead.Attributes.Add("style", "background-color: darkslategray; color: whitesmoke;");

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

                Label lbBkTotalHead = new Label();
                lbBkTotalHead.Text = "Booking Total";
                lbBkTotalHead.Width = 120;
                lbBkTotalHead.Attributes.Add("class", "col-xs-5  col-xs-offset-6  col-md-4 col-md-offset-7");
                Label lbBkTotal = new Label();
                lbBkTotal.Width = 90;
                lbBkTotal.Text = booking.GetTotal().ToString("c");


                divColBk.Controls.Add(tableBk);

                divColTotal.Controls.Add(lbBkTotalHead);
                divColTotal.Controls.Add(lbBkTotal);

                divRowBk.Controls.Add(divColTotal);

                tableDt.CssClass = "table table-responsive";

                

                divRowBk.Controls.Add(divColBk);

                divColDt.Controls.Add(tableDt);
                divRowDt.Controls.Add(divColDt);

                Container.Controls.Add(divRowBk);
                Container.Controls.Add(divRowDt);

                var breakTag = new System.Web.UI.HtmlControls.HtmlGenericControl("BR");
                Container.Controls.Add(breakTag);
                Container.Controls.Add(breakTag);
                
            }
        }

        protected void gvBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }
    }
}