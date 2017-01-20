using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Workshop
{
    public static class Settings
    {
        public static string connectionString = @"Data Source=ICTVM-M1JAMLFO8\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";
            //@"Data Source=ICTVM-FQQ06UJG2\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";

        public static string GetCustomerQuery =
            @"SELECT * FROM Customers
            WHERE UserName = @UserName
            AND Password = @Password";

        public static string GetBookingsQuery =
            @"SELECT BookingId,BookingDate,BookingNo,TravelerCount,TTName 
            FROM Bookings B, TripTypes T
            WHERE B.TripTypeId = T.TripTypeId
            AND CustomerId = @CustomerId";

        public static string GetBookingDetailsQuery =
            @"SELECT BookingDetailId,ItineraryNo,TripStart,TripEnd,Description,
            Destination,BasePrice,AgencyCommission,FeeAmt 
            FROM BookingDetails B, Fees F
            WHERE B.FeeId = F.FeeId
            AND BookingId = @BookingId";

        public static string GetAgentsQuery =
            @"SELECT AgentId, AgtFirstName, AgtLastName, AgtPosition FROM Agents";
    }
}