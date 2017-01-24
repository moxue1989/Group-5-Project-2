using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_Workshop
{
    /// <summary>
    /// Agent class
    /// Only has properties relevant to drop down selection
    /// Group 5 ASP.NET
    /// Mo Xue
    /// </summary>
    public class Agent
    {
        public int AgentId { get; set; }
        public string AgtFirstName { get; set; }
        public string AgtLastName { get; set; }
        public string AgtPosition { get; set; }

        public string SelectDisplay
        {
            get { return AgtPosition + " " + AgtFirstName + " " + AgtLastName; }
        }
    }
}
