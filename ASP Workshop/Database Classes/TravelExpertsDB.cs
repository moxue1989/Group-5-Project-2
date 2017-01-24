using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Dapper;
using Dapper.Contrib.Extensions;

namespace ASP_Workshop
{
    /// <summary>
    /// Database access class
    /// Methods use Dapper for mapping to objects
    /// Group 5 ASP.NET
    /// Mo Xue
    /// </summary>
    public static class TravelExpertsDB
    {
        // retrives a customer with username and password, returns an customer with null properties if not found
        public static Customer GetCustomer(string UserName, string Password)
        {
            Customer cust = new Customer();
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                var result = conn.Query<Customer>(Settings.GetCustomerQuery, new {UserName, Password}).ToList();
                if (result.Count == 1)
                {
                    cust = result[0];
                }
            }
            return cust;
        }

        // retrieves bookings for a particular customer id
        public static List<Booking> GetBookings(int CustomerId)
        {
            List<Booking> bookings = new List<Booking>();
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                bookings.AddRange(conn.Query<Booking>(Settings.GetBookingsQuery, new { CustomerId }));
            }
            return bookings;
        }

        // retrieves details for a specific booking
        public static List<BookingDetail> GetBookingDetails(int bookingId)
        {
            List<BookingDetail> details = new List<BookingDetail>();
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                details.AddRange(conn.Query<BookingDetail>(Settings.GetBookingDetailsQuery, new { bookingId }));
            }
            return details;
        }

        // add new customer to customers table and returns the added customer 
        public static Customer RegisterCustomer(Customer cust)
        {
            Customer newCust = new Customer();
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                long customerId = conn.Insert(cust);
                if (customerId != 0)
                {
                    newCust = conn.QuerySingle<Customer>(Settings.GetAddedCustomerQuery, new { customerId});
                }
            }
            return newCust;
        }

        // gets the list of agents for selection
        public static List<Agent> GetAgents()
        {
            List<Agent> agents = new List<Agent>();
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                agents.AddRange(conn.Query<Agent>(Settings.GetAgentsQuery));
            }
            return agents;
        }

        // updates customer information using Dapper extension method
        public static bool UpdateCustomer(Customer cust)
        {
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                return conn.Update(cust);
            }
        }
    }
}