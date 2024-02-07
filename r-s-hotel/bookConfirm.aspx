<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="bookConfirm.aspx.cs" Inherits="r_s_hotel.bookConfirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="display: flex; justify-content: center; align-items: center; margin-top: 20px; margin-bottom: 20px;">
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />

            <Columns>
                <asp:BoundField DataField="Parameter" HeaderText="Parameter" ControlStyle-Font-Bold="true" />
                <asp:BoundField DataField="Value" HeaderText="Value" />
            </Columns>
        </asp:GridView>
    </div>
    <center>
        <div style="margin-bottom: 130px;">
            <asp:Button ID="Button1" runat="server" Text="Confirm Order" OnClick="Button1_Click" CssClass="btn btn-sm btn-dark rounded py-2 px-4" />
        </div>
    </center>
</asp:Content>
