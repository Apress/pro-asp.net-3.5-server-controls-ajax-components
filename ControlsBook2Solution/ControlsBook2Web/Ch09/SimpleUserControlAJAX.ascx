<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SimpleUserControlAJAX.ascx.cs" Inherits="ControlsBook2Web.Ch09.SimpleUserControlAJAX" %>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
  <ContentTemplate>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
      AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
      DataKeyNames="ID" DataSourceID="ApressBooksds" 
      EmptyDataText="There are no data records to display." Font-Names="Arial" 
      Font-Size="X-Small" ForeColor="#333333" GridLines="None">
      <Columns>
        <asp:commandfield ShowSelectButton="True" />
        <asp:boundfield DataField="ID" HeaderText="ID" ReadOnly="True" 
          SortExpression="ID" Visible="False" />
        <asp:boundfield DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
        <asp:boundfield DataField="Author" HeaderText="Author" 
          SortExpression="Author" />
        <asp:boundfield DataField="Title" HeaderText="Title" SortExpression="Title" />
        <asp:boundfield DataField="Description" HeaderText="Description" 
          SortExpression="Description" />
        <asp:boundfield DataField="DatePublished" HeaderText="DatePublished" 
          SortExpression="DatePublished" />
        <asp:boundfield DataField="NumPages" HeaderText="NumPages" 
          SortExpression="NumPages" />
        <asp:boundfield DataField="TOC" HeaderText="TOC" SortExpression="TOC" />
        <asp:boundfield DataField="Price" HeaderText="Price" SortExpression="Price" />
      </Columns>
      <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
      <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
      <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
      <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
      <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
      <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    <asp:AccessDataSource ID="ApressBooksds" runat="server" 
      DataFile="..\App_Data\ApressBooks.mdb" SelectCommand="SELECT * FROM [Books]">
    </asp:AccessDataSource>
  </ContentTemplate>
</asp:UpdatePanel>
