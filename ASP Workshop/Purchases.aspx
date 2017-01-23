<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Purchases.aspx.cs" Inherits="ASP_Workshop.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    

    <div class="container">
        <div class="row">
            <div class="col-sm-8 col-sm-offset-1 divider-new">
                <label class="h2-responsive">Purchase Details</label>
            </div>
            <div class="col-sm-4 col-md-4">
                
                <div class="table-responsive">
                   <asp:GridView CssClass="table table-hover table-striped" ID="gvBookings" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="BookingId" OnSelectedIndexChanged="gvBookings_SelectedIndexChanged" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="BookingDate" DataFormatString="{0:d}" HeaderText="Booking Date" SortExpression="BookingDate" />
                        <asp:BoundField DataField="BookingNo" HeaderText="Booking Number" SortExpression="BookingNo" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView> 
                </div>
                
                <asp:Panel ID="pnlBookings" runat="server">
                </asp:Panel>
                
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetBookings" TypeName="ASP_Workshop.TravelExpertsDB">
                    <SelectParameters>
                        <asp:SessionParameter Name="CustomerId" SessionField="CustomerId" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
            <div class="col-sm-8 col-md-8">
                <div class="table-responsive">
                     <asp:GridView CssClass="table table-hover table-striped" ID="gvDetails" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                    <Columns>
                        <asp:BoundField DataField="TripStart" DataFormatString="{0:d}" HeaderText="Trip Start Date" SortExpression="TripStart" />
                        <asp:BoundField DataField="TripEnd" DataFormatString="{0:d}" HeaderText="Trip End Date" SortExpression="TripEnd" />
                        <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                        <asp:BoundField DataField="Destination" HeaderText="Destination" SortExpression="Destination" />
                        <asp:BoundField DataField="BasePrice" HeaderText="Base Price" SortExpression="BasePrice" />
                        <asp:BoundField DataField="AgencyCommission" HeaderText="Commission" SortExpression="AgencyCommission" />
                        <asp:BoundField DataField="FeeAmt" HeaderText="Fee" SortExpression="FeeAmt" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
                </div>
               
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetBookingDetails" TypeName="ASP_Workshop.TravelExpertsDB">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="gvBookings" Name="bookingId" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>

                <asp:Label ID="Label1" runat="server" Text="Booking Total:"></asp:Label>
                <asp:TextBox CssClass="form-control-success" ID="txtBookingTotal" runat="server"></asp:TextBox>
                
                <br/>

                <asp:Label ID="Label2" runat="server" Text="Customer Total:"></asp:Label>
                <asp:TextBox CssClass="form-control-danger" ID="txtTotalCost" runat="server"></asp:TextBox>
            </div>
        </div>
    </div>
</asp:Content>
