using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Workshop
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        private Customer cust;
        private bool addStatus;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Customer"] != null)
            {
                addStatus = false;
                cust = (Customer) Session["Customer"];
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

                lblAgent.Visible = false;
                ddlAgents.Visible = false;
                btnRegister.Visible = false;
                LoginInfo.Visible = false;
                newCustomerPassword.Visible = false;
            }
            else
            {
                addStatus = true;
                List<Agent> agents = TravelExpertsDB.GetAgents();
                ddlAgents.DataSource = agents;
                ddlAgents.DataTextField = "SelectDisplay";
                ddlAgents.DataValueField = "AgentId";
                ddlAgents.DataBind();
                btnUpdate.Visible = false;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            CreateCustomer();
            cust = TravelExpertsDB.RegisterCustomer(cust);

            if (cust.CustFirstName != null)
            {
                Session["Customer"] = cust;
                Response.Redirect("CustomerLanding.aspx");
            }

        }

        private void CreateCustomer()
        {
            cust.CustFirstName = txtFirstName.Text;
            cust.CustLastName = txtLastName.Text;
            cust.CustAddress = txtAddress.Text;
            cust.CustCity = txtCity.Text;
            cust.CustProv = txtProv.Text;
            cust.CustPostal = txtPostal.Text;
            cust.CustCountry = txtCountry.Text;
            cust.CustHomePhone = txtHomePhone.Text;
            cust.CustBusPhone = txtBusPhone.Text;
            if (addStatus)
            {
                cust.UserName = txtUserName.Text;
                cust.Password = txtPassword.Text;
                cust.CustEmail = txtEmail.Text;
                cust.AgentId = Convert.ToInt32(ddlAgents.SelectedValue);
            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            CreateCustomer();
            messageAlert.Visible = true;
            if (TravelExpertsDB.UpdateCustomer(cust))
            {
                Session["Customer"] = cust;
                lblMessage.Text = "Update Successful!";
            }
            else
            {
                cust = (Customer)Session["Customer"];
                lblMessage.Text = "Update failed!";
            }
        }
    }
}