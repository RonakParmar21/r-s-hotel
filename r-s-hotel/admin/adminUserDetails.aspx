<%@ Page Title="" Language="C#" MasterPageFile="~/admin/nav_footer.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="adminUserDetails.aspx.cs" Inherits="r_s_hotel.admin.adminUserDetails" %>
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
   <div style="margin:50px; margin-left:210px;">
       <asp:HyperLink ID="HyperLink1" style="background-color:#141d28; color:#fff; width:100px; margin-left:90%; margin-bottom:20px; margin-top: 20px;"
                                                        CssClass="dropdown-item x-large" runat="server"
                                                        NavigateUrl="~/admin/addAdmin.aspx" Visible="true">Add Admin
                                                    </asp:HyperLink>
    <center>
     
    <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" Width="100%" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" CssClass="text-center">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:TemplateField HeaderText="ID">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("admin_id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("admin_name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Email">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("admin_email") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Mobile">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("admin_mobile") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="DOB">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("admin_dob") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnDelete" runat="server" CommandArgument='<%# Bind("admin_id") %>' Text="Delete"  CssClass="btn btn-danger" OnCommand="btnDelete_Command" />
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
