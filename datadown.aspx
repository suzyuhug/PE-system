<%@ Page Language="C#" AutoEventWireup="true" CodeFile="datadown.aspx.cs" Inherits="datadown" MasterPageFile="~/Site.master" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <div style="height: 520px">
                    <hr />
                    <asp:GridView ID="GridView1" runat="server" AllowCustomPaging="True" AllowPaging="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="Double" BorderWidth="1px" CaptionAlign="Bottom" CellPadding="3" HorizontalAlign="Center">
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        <PagerSettings Mode="NextPreviousFirstLast" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                        <RowStyle ForeColor="#000066" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    </div>
</asp:Content>


