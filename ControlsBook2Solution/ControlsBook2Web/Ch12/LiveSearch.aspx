<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="LiveSearch.aspx.cs" Inherits="ControlsBook2Web.Ch12.LiveSearch"
  Title="Live Search Demo" %>

<%@ Register TagPrefix="ApressLive" Namespace="ControlsBook2Lib.CH12.LiveSearchControls"
  Assembly="ControlsBook2Lib.CH12.LiveSearchControls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadSection" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">12</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Building a Complex Control</asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Ch12 Live Search</h3>
  <ApressLive:Search ID="search" runat="server" RedirectToLiveSearch="false" Width="426px"
    ResultControl="Result"></ApressLive:Search>
  <br />
  <br />
  <ApressLive:Result ID="Result" runat="server" PagerStyle="TextWithDHTML" PagerBarRange="4"
    PageSize="8" PageNumber="1" PagerLinkStyle="Text">
    <HeaderStyle Font-Bold="True" ForeColor="Blue" BorderColor="Blue"></HeaderStyle>
    <StatusStyle Font-Bold="True" ForeColor="Blue"></StatusStyle>
  </ApressLive:Result>
</asp:Content>