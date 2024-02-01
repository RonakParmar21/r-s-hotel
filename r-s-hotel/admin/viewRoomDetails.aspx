<%@ Page Title="" Language="C#" MasterPageFile="~/admin/nav_footer.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="viewRoomDetails.aspx.cs" Inherits="r_s_hotel.admin.viewRoomDetails" %>
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
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("room_id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Room No">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("room_no") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Description">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("room_description") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Room Type">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("room_type") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Capacity">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("room_capacity") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Price">
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("room_price") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Service">
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("room_service") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Status">
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<%# Bind("room_status") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Total">
                <ItemTemplate>
                    <asp:Label ID="Label9" runat="server" Text='<%# Bind("room_total") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Image">
                <ItemTemplate>
                    <asp:Label ID="Label10" runat="server" Text='<%# Bind("room_img") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnDelete" runat="server" CommandArgument='<%# Bind("room_id") %>' Text="Delete"  CssClass="btn btn-danger" OnCommand="btnDelete_Command" />
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
