<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SimpleUserControl.ascx.cs"
  Inherits="ControlsBook2Web.Ch02.SimpleUserControl" %>
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
  AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" DataSourceID="ApressBooksds"
  EmptyDataText="There are no data records to display." Font-Names="Arial" Font-Size="X-Small"
  ForeColor="#333333" GridLines="None">
  <Columns>
    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID"
      InsertVisible="False" />
    <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
    <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
    <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
    <asp:BoundField DataField="DatePublished" HeaderText="DatePublished" SortExpression="DatePublished" />
    <asp:BoundField DataField="NumPages" HeaderText="NumPages" SortExpression="NumPages" />
    <asp:BoundField DataField="TOC" HeaderText="TOC" SortExpression="TOC" />
    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
  </Columns>
  <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
  <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
  <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
  <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
  <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
  <AlternatingRowStyle BackColor="White" />
</asp:GridView>
<asp:AccessDataSource ID="ApressBooksds" runat="server" DataFile="~/App_Data/ApressBooks.mdb"
  SelectCommand="SELECT * FROM [Books]"></asp:AccessDataSource>