<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master" AutoEventWireup="true" CodeBehind="CustomerInfo.aspx.cs" Inherits="ControlsBook2Web.Ch10.CustomerInfo" Title="Customer Info Demo Web Form" %>
<%@ Register assembly="ControlsBook2Lib" namespace="ControlsBook2Lib.Ch10" tagprefix="apress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadSection" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">10</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Other Server Controls</asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PrimaryContent" runat="server">
  <br />
  <br />
  <apress:CustomerList ID="CustomerList1" runat="server" 
  ConnectionString = "<%$ ConnectionStrings:NorthwindDB %>" 
    AllowCustomerEditing="True" />
  <br /> <br />  
  <apress:CustomerInvoices ID="CustomerInvoices1" runat="server"  CustomerID="VINET"
  ConnectionString = "<%$ ConnectionStrings:NorthwindDB %>" />
  <br /> <br />  
</asp:Content>
