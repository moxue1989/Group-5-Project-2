<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerLanding.aspx.cs" Inherits="ASP_Workshop.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblWelcome" runat="server"></asp:Label>

    <div class="container">
        <div class="row">
            <div class="col-sm-3">
                <asp:GridView CssClass="table table-hover table-striped" ID="gvBookings" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="BookingId">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="BookingDate" DataFormatString="{0:d}" HeaderText="Booking Date" SortExpression="BookingDate" />
                        <asp:BoundField DataField="BookingNo" HeaderText="Booking Number" SortExpression="BookingNo" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetBookings" TypeName="ASP_Workshop.TravelExpertsDB">
                    <SelectParameters>
                        <asp:SessionParameter Name="CustomerId" SessionField="CustomerId" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
            <div class="col-sm-9">
                <asp:GridView CssClass="table table-hover table-striped" ID="gvDetails" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
                    <Columns>
                        <asp:BoundField DataField="TripStart" DataFormatString="{0:d}" HeaderText="Trip Start Date" SortExpression="TripStart" />
                        <asp:BoundField DataField="TripEnd" DataFormatString="{0:d}" HeaderText="Trip End Date" SortExpression="TripEnd" />
                        <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                        <asp:BoundField DataField="Destination" HeaderText="Destination" SortExpression="Destination" />
                        <asp:BoundField DataField="BasePrice" HeaderText="Base Price" SortExpression="BasePrice" />
                        <asp:BoundField DataField="AgencyCommission" HeaderText="Commission" SortExpression="AgencyCommission" />
                        <asp:BoundField DataField="FeeAmt" HeaderText="Fee" SortExpression="FeeAmt" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetBookingDetails" TypeName="ASP_Workshop.TravelExpertsDB">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="gvBookings" Name="bookingId" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
    </div>
</asp:Content>
