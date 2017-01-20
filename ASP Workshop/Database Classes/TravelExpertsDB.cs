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
    public static class TravelExpertsDB
    {
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

        public static Customer RegisterCustomer(Customer cust)
        {
            Customer newCust = new Customer();
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();
                if (conn.Insert(cust) == 1)
                {
                    newCust = conn.QuerySingle<Customer>(Settings.GetAddedCustomerQuery);
                }
            }
            return newCust;
        }

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