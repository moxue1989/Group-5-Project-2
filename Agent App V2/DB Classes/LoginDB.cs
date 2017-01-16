using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Agent_App_V2
{
    public static class LoginDB
    {
        public static Agent GetAgent(Agent agt)
        {
            Agent agent = new Agent();
            using (SqlConnection con = new SqlConnection(Settings.connectionString2))
            {
                try
                {
                    con.Open();
                    List<Agent> agents = new List<Agent>();
                    agents.AddRange(con.Query<Agent>(Settings.GetAgentQuery, new { agt.AgtFirstName, agt.AgtPassword }));
                    if (agents.Count == 1)
                    {
                        agent = agents[0];
                    }
                        
                    return agent;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
    }
}
