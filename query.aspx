<%@ Page Language="C#" AutoEventWireup="true" CodeFile="query.aspx.cs" Inherits="query" MasterPageFile="~/Site.master" %>







<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <div style="z-index: 1; width: 1275px; height: 37px; position: absolute; top: 88px; left: 15px">
        <hr style="z-index: 1; width: 1275px; position: absolute; top: 0px; left: 0px" />
    </div>
    <p style="height: 720px">
        <br />
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" style="z-index: 1; position: absolute; top: 145px; left: 46px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-default" style="z-index: 1; position: absolute; width:90px; top: 147px; left: 365px" Text="查  询" />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="z-index: 1; width: 411px; height: 195px; position: absolute; top: 205px; left: 32px" AllowCustomPaging="True" AllowPaging="True" PageSize="15">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </p>
</asp:Content>








