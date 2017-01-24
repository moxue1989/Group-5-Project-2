using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Workshop
{
    /// <summary>
    /// BookingDetail class
    /// Properties relevant for calculation
    /// Group 5 ASP.NET
    /// Mo Xue
    /// </summary>
    public class BookingDetail
    {
        public int BookingDetailId { get; set; }
        public double ItineraryNo { get; set; }
        public DateTime? TripStart { get; set; }
        public DateTime? TripEnd { get; set; }
        public string Description { get; set; }
        public string Destination { get; set; }
        public decimal BasePrice { get; set; }
        public decimal AgencyCommission { get; set; }
        public decimal FeeAmt { get; set; }

        // return total amount of this booking
        public decimal GetTotal()
        {
            return BasePrice + AgencyCommission + FeeAmt;
        }
    }
}