using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Workshop
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public string BookingNo { get; set; }
        public int TravelerCount { get; set; }
        public string TTName { get; set; }
        public List<BookingDetail> GetBookingDetails()
        {
            return TravelExpertsDB.GetBookingDetails(BookingId);
        }

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