using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Workshop
{
    /// <summary>
    /// Customer register/modify page
    /// Can be used to add or modify customer depending on session
    /// Group 5 ASP.NET
    /// Mo Xue, Dhwani Desai and Kasi Emmanuel
    /// </summary>
    public partial class WebForm3 : System.Web.UI.Page
    {
        // variable to indicate if adding or editing
        private bool addStatus;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                messageAlert.Visible = false;
            }

            // check if customer is logged in, or new customer register
            if (Session["Customer"] != null)
            {
                if (!IsPostBack)
                {
                    // populate text fields with current customer information
                    addStatus = false;
                    Customer cust = (Customer)Session["Customer"];
                    txtFirstName.Text = cust.CustFirstName;
                    txtLastName.Text = cust.CustLastName;
                    txtAddress.Text = cust.CustAddress;
                    txtCity.Text = cust.CustCity;
                    txtProv.Text = cust.CustProv;
                    txtPostal.Text = cust.CustPostal;
                    txtCountry.Text = cust.CustCountry;

                    txtEmail.Text = cust.CustEmail;
                    txtHomePhone.Text = cust.CustHomePhone;
                    txtBusPhone.Text = cust.CustBusPhone;

                    // hides agent, username, and password information
                    newCust.Visible = false;
                    lblAgent.Visible = false;
                    ddlAgents.Visible = false;
                    btnRegister.Visible = false;
                    LoginInfo.Visible = false;
                    newCustomerPassword.Visible = false;
                }
            }
            else
            {
                // new customer register
                addStatus = true;

                // populate agent selection drop down list
                List<Agent> agents = TravelExpertsDB.GetAgents();
                ddlAgents.DataSource = agents;
                ddlAgents.DataTextField = "SelectDisplay";
                ddlAgents.DataValueField = "AgentId";
                ddlAgents.DataBind();

                // hide update button and navbar info
                btnUpdate.Visible = false;
                AccountDetails.Visible = false;

                // enable username and password validators
                UNReqV.Enabled = true;
                PWReqV.Enabled = true;
                CPWReqV.Enabled = true;
                CPWCompareV.Enabled = true;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            // register customer
            if (Page.IsValid)
            {
                messageAlert.Visible = true;
                lblMessage.Text = "Added!";
                Customer newCust = CreateCustomer();
                newCust = TravelExpertsDB.RegisterCustomer(newCust);

                // redirects customer to landing page after registering
                if (newCust.CustFirstName != null)
                {
                    Session["Customer"] = newCust;
                    Response.Redirect("CustomerLanding.aspx");
                }
            }
            else
            {
                // clear error text if validation fails
                lblMessage.Text = "";
                messageAlert.Visible = false;
            }
        }

        private Customer CreateCustomer()
        {
            Customer newCust;
            if (addStatus)
            {
                // creats new customer with username, password, and agentID if registering
                newCust = new Customer();
                newCust.UserName = txtUserName.Text;
                newCust.Password = txtPassword.Text;
                newCust.AgentId = Convert.ToInt32(ddlAgents.SelectedValue);
            }
            else
            {
               // get old customer from session if modifying
               newCust = (Customer) Session["Customer"];
            }
            // add/modify customer details
            newCust.CustFirstName = txtFirstName.Text;
            newCust.CustLastName = txtLastName.Text;
            newCust.CustAddress = txtAddress.Text;
            newCust.CustCity = txtCity.Text;
            newCust.CustProv = txtProv.Text;
            newCust.CustPostal = txtPostal.Text;
            newCust.CustCountry = txtCountry.Text;
            newCust.CustHomePhone = txtHomePhone.Text;
            newCust.CustBusPhone = txtBusPhone.Text;
            newCust.CustEmail = txtEmail.Text;
            
            return newCust;
        }

        // Update information of current customer
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer newCust = CreateCustomer();
            // check validation before updating
            if (Page.IsValid)
            {
                messageAlert.Visible = true;
                if (TravelExpertsDB.UpdateCustomer(newCust))
                {
                    Session["Customer"] = newCust;
                    lblMessage.Text = "Update Successful!";
                }
                else
                {
                    lblMessage.Text = "Update failed!";
                }
            }
            else
            {
                // clear error messages if not valid
                messageAlert.Visible = false;
                lblMessage.Text = "";
            }
        }
    }
}
