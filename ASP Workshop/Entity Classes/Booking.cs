using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Workshop
{
    /// <summary>
    /// Booking class
    /// Properties required for display
    /// Group 5 ASP.NET
    /// Mo Xue
    /// </summary>
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public string BookingNo { get; set; }
        public int TravelerCount { get; set; }
        public string TTName { get; set; }

        // get all details associated with this booking
        public List<BookingDetail> GetBookingDetails()
        {
            return TravelExpertsDB.GetBookingDetails(BookingId);
        }

        // return total of this booking
        public decimal GetTotal()
        {
            decimal total = 0m;
            foreach (var detail in GetBookingDetails())
            {
                total += detail.GetTotal();
            }
            return total;
        }
    }
}