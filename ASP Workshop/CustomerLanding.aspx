<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerLanding.aspx.cs" Inherits="ASP_Workshop.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   
        <div class="col-sm-4 col-sm-offset-2  text-xs-center">
            <div class="divider-new">
                <label class="h2-responsive">Account Details</label>
            </div>
            <div class="jumbotron">
                <p >Update contact information and address</p> 
                <asp:Button CssClass="btn btn-primary waves-effect waves-light" ID="AccountDetails" runat="server" Text="Change Account Details" OnClick="AccountDetails_Click" />
            </div>
        </div>
        <div class="col-sm-4   text-xs-center">
            <div class="divider-new">
                <label class="h2-responsive">Purchases</label>
            </div>
            <div class="jumbotron">
                <p >View Details on Past Bookings and Puchases</p> 
                <asp:Button CssClass="btn btn-primary waves-effect waves-light" ID="BookingDetails" runat="server" Text="View BookingDetails" OnClick="BookingDetails_Click"  />
            </div>
        </div>

    <%-- <div class="card">
            <div class="card-block">
                <div class="md-textarea col-sm-8 col-sm-offset-3">
                    <div class="col-sm-4">
                        <h4 class="card-header">Purchases</h4>
                        <p class="card-subtitle">View Details on Past Bookings and Puchases</p> 
                    </div>
                    <div class="col-sm-4">
                        <button class="btn btn-success">View Booking Details</button> 
                    </div>
                </div>
            </div>
        
       </div> <br/>--%>
</asp:Content>
