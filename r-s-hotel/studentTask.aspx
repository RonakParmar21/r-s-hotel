<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="studentTask.aspx.cs" Inherits="r_s_hotel.studentTask" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">

        <Columns>
            <asp:TemplateField HeaderText="Id">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Stream">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("stream") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Mobile">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("mobile") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            </Columns>

    </asp:GridView>
    <div style="height: 300px;">

    </div>
</asp:Content>
