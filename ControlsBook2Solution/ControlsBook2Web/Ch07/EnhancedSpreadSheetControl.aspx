<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="EnhancedSpreadSheetControl.aspx.cs" Inherits="ControlsBook2Web.Ch07.EnhancedSpreadSheetControl"
  Title="Enhanced Spreadsheet Control Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch07" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">7</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Data Binding</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <br />
  <apress:EnhancedSpreadsheetControl ID="EnhancedSpreadsheetControl1" runat="Server"
    DataMember="DefaultView" DataSourceID="SqlDataSource1" BorderWidth="2px" HeaderRowColor="Gainsboro"
    HeaderRowBackColor="Navy" HeaderRowForeColor="Gold" />
  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthWindDB %>"
    SelectCommand="SELECT [FirstName], [LastName], [Title], [HireDate] FROM [Employees]">
  </asp:SqlDataSource>
  <br />
  <br />
  <apress:EnhancedSpreadsheetControl ID="EnhancedSpreadsheetControl2" runat="server"
    BorderWidth="2px" HeaderRowColor="Gainsboro" HeaderRowBackColor="Navy" HeaderRowForeColor="Gold" />
  <br />
  <asp:Button ID="Button1" runat="server" Text="Submit" />
  <br />
</asp:Content>