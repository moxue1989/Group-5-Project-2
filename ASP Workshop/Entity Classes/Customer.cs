using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper.Contrib.Extensions;

namespace ASP_Workshop
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string CustAddress { get; set; }
        public string CustCity { get; set; }
        public string CustProv { get; set; }
        public string CustPostal { get; set; }
        public string CustCountry { get; set; }
        public string CustHomePhone { get; set; }
        public string CustBusPhone { get; set; }
        public string CustEmail { get; set; }
        public int? AgentId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<Booking> GetBookings()
        {
            return TravelExpertsDB.GetBookings(CustomerId);
        }
        public decimal GetTotal()
        {
            decimal total = 0m;
            foreach (var booking in GetBookings())
            {
                total += booking.GetTotal();
            }
            return total;
        }
    }
}
