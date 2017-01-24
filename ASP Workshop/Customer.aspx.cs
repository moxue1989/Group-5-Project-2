﻿using System;
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
        private bool addStatus;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                messageAlert.Visible = false;
            }
            if (Session["Customer"] != null)
            {
                if (!IsPostBack)
                {
                    addStatus = false;
                    Customer cust = (Customer)Session["Customer"];
                    txtFirstName.Text = txtFirstName.Text.Trim();
                    txtFirstName.Text = cust.CustFirstName;

                    txtLastName.Text = cust.CustLastName;
                    txtAddress.Text = cust.CustAddress;
                    txtCity.Text = cust.CustCity;
                    txtProv.Text = cust.CustProv;
                    txtPostal.Text = cust.CustPostal;
                    txtCountry.Text = cust.CustCountry;

                    txtEmail.Text = txtEmail.Text.Trim();
                    txtEmail.Text = cust.CustEmail;

                    txtHomePhone.Text = cust.CustHomePhone;
                    txtBusPhone.Text = cust.CustBusPhone;

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
                addStatus = true;
                List<Agent> agents = TravelExpertsDB.GetAgents();
                ddlAgents.DataSource = agents;
                ddlAgents.DataTextField = "SelectDisplay";
                ddlAgents.DataValueField = "AgentId";
                ddlAgents.DataBind();
                btnUpdate.Visible = false;
                AccountDetails.Visible = false;


                UNReqV.Enabled = true;
                PWReqV.Enabled = true;
                CPWReqV.Enabled = true;
                CPWCompareV.Enabled = true;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                messageAlert.Visible = true;
                Customer newCust = CreateCustomer();
                newCust = TravelExpertsDB.RegisterCustomer(newCust);

                if (newCust.CustFirstName != null)
                {
                    Session["Customer"] = newCust;
                    Response.Redirect("CustomerLanding.aspx");
                }
            }
            else
            {
                lblMessage.Text = "";
                messageAlert.Visible = false;
            }
        }

        private Customer CreateCustomer()
        {
            Customer newCust = (Customer)Session["Customer"];
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
            if (addStatus)
            {
                newCust.Password = txtPassword.Text;
                newCust.AgentId = Convert.ToInt32(ddlAgents.SelectedValue);
            }
            return newCust;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer newCust = CreateCustomer();
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
                messageAlert.Visible = false;
                lblMessage.Text = "";
            }
        }
    }
}