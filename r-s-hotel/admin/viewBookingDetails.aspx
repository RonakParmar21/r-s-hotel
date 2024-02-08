<%@ Page Title="" Language="C#" MasterPageFile="~/admin/nav_footer.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="viewBookingDetails.aspx.cs" Inherits="r_s_hotel.admin.viewBookingDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header>
    <style>
                .fc {
                    max-width: 400px;
                }

                .con {
                    margin-bottom: 50px;
                    padding-top: 10px;
                    /*text-transform: uppercase;*/
                }

                .form-control {
                    display: inline;
                }
                /*img{
                    Height:70px;
                    Width:auto;

                }*/
        </style>
        </header>
   <div style="margin:50px; margin-left:210px; overflow-x: auto;">
       <asp:HyperLink ID="HyperLink1" style="background-color:#141d28; color:#fff; width:100px; margin-left:90%; margin-bottom:20px; margin-top: 20px;"
                                                        CssClass="dropdown-item x-large" runat="server"
                                                        NavigateUrl="~/admin/addRoom.aspx" Visible="true">Add Room
                                                    </asp:HyperLink>
    <center>
     
    <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" Width="100%" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" CssClass="text-center">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:TemplateField HeaderText="Id">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("book_id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="User Id">
                <ItemTemplate>
                    <asp:Label ID="Label10" runat="server" Text='<%# Bind("user_id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Room Id">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("room_id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="checkin">
                <ItemTemplate>
                    <asp:Label ID="Label11" runat="server" Text='<%# Bind("book_checkin_date") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="checkout">
                <ItemTemplate>
                    <asp:Label ID="Label12" runat="server" Text='<%# Bind("book_checkout_date") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Total Day">
                <ItemTemplate>
                    <asp:Label ID="Label13" runat="server" Text='<%# Bind("book_totalday") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Total Price">
                <ItemTemplate>
                    <asp:Label ID="Label14" runat="server" Text='<%# Bind("book_totalprice") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="TotalRoom">
                <ItemTemplate>
                    <asp:Label ID="Label15" runat="server" Text='<%# Bind("book_totalroom") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Room Type">
                <ItemTemplate>
                    <asp:Label ID="Label16" runat="server" Text='<%# Bind("book_roomtype") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Payment Status">
                <ItemTemplate>
                    <asp:Label ID="Label17" runat="server" Text='<%# Bind("book_paymentstatus") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Total Person">
                <ItemTemplate>
                    <asp:Label ID="Label18" runat="server" Text='<%# Bind("book_total_person") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Status">
                <ItemTemplate>
                    <asp:Label ID="Label19" runat="server" Text='<%# Bind("book_status") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Special Request">
                <ItemTemplate>
                    <asp:Label ID="Label20" runat="server" Text='<%# Bind("book_special_request") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnDelete" runat="server" CommandArgument='<%# Bind("book_id") %>' Text="Delete"  CssClass="btn btn-danger" OnCommand="btnDelete_Command" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
       </center>
        </div>
</asp:Content>
