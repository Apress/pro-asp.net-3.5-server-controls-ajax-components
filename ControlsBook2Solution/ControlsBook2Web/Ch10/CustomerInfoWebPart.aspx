<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master" AutoEventWireup="true" CodeBehind="CustomerInfoWebPart.aspx.cs" Inherits="ControlsBook2Web.Ch10.CustomerInfoWebPart" Title="Customer Info Web Part Demo Web Form" %>
<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch10"  Assembly="ControlsBook2Lib" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadSection" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
<asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">10</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Other Server Controls</asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PrimaryContent" runat="server">
  <div>
  <br />
    <asp:WebPartManager ID="WebPartManager1" runat="server">
    </asp:WebPartManager>
    <apress:WebPartPageController ID="options" runat="server"  DisplayModeText="Display Mode:" 
        ResetStateText="Reset User State" 
        
        ResetStateToolTip="Reset the current user's personalization data for the page." 
        Height="87px" Width="167px" BackColor="Silver" ForeColor="White" />   
  <asp:webpartzone id="WebPartZone1" runat="server" BorderColor="#CCCCCC" 
      Font-Names="Verdana" Padding="6" >
    <EmptyZoneTextStyle Font-Size="0.8em" />
    <PartStyle Font-Size="0.8em" ForeColor="#333333" />
    <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White" />
    <MenuLabelHoverStyle ForeColor="#E2DED6" />
    <MenuPopupStyle BackColor="#5D7B9D" BorderColor="#CCCCCC" BorderWidth="1px" 
      Font-Names="Verdana" Font-Size="0.6em" />
    <MenuVerbStyle BorderColor="#5D7B9D" BorderStyle="Solid" BorderWidth="1px" 
      ForeColor="White" />
    <PartTitleStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.8em" 
      ForeColor="White" />
    <zonetemplate>
      <apress:CustomerListWebPart id="CustomerListWebPart" runat="server"  
         ConnectionString = "<%$ ConnectionStrings:NorthwindDB %>" 
        Title="Customer List" AllowEdit="False" AllowCustomerEditing="True" />
      <apress:CustomerInvoicesWebPart ID="CustomerInvoicesWebPart1" runat="server" CustomerID="VINET"
      ConnectionString = "<%$ ConnectionStrings:NorthwindDB %>" Title="Customer Invoices"/>
    </zonetemplate>
    <MenuVerbHoverStyle BackColor="#F7F6F3" BorderColor="#CCCCCC" 
      BorderStyle="Solid" BorderWidth="1px" ForeColor="#333333" />
    <PartChromeStyle BackColor="#F7F6F3" BorderColor="#E2DED6" Font-Names="Verdana" 
      ForeColor="White" />
    <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
    <MenuLabelStyle ForeColor="White" />
  </asp:webpartzone>
  <asp:connectionszone id="connectionsZone1" runat="server" >
    <cancelverb text="Terminate" />
    <closeverb text="Close Zone" />
    <configureverb text="Configure" />
    <connectverb text="Connect Controls" />
    <disconnectverb text="End Connection" />
  </asp:connectionszone>
  <br />
  </div>
</asp:Content>
