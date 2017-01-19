using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Workshop
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Agent> agents = TravelExpertsDB.GetAgents();
            ddlAgents.DataSource = agents;
            ddlAgents.DataTextField = "SelectDisplay";
            ddlAgents.DataValueField = "AgentId";
            ddlAgents.DataBind();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.CustFirstName = txtFirstName.Text;
            cust.CustLastName = txtLastName.Text;
            cust.CustAddress = txtAddress.Text;
            cust.CustCity = txtCity.Text;
            cust.CustProv = txtProv.Text;
            cust.CustPostal = txtPostal.Text;
            cust.CustCountry = txtCountry.Text;
            cust.CustHomePhone = txtHomePhone.Text;
            cust.CustBusPhone = txtBusPhone.Text;
            cust.UserName = txtUserName.Text;
            cust.Password = txtPassword.Text;
            cust.CustEmail = txtEmail.Text;
            cust.AgentId = Convert.ToInt32(ddlAgents.SelectedValue);

            TravelExpertsDB.RegisterCustomer(cust);
        }
    }
}