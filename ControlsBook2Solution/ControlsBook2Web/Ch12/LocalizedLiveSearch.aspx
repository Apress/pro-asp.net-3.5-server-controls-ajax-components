<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="LocalizedLiveSearch.aspx.cs" Inherits="ControlsBook2Web.Ch12.LocalizedLiveSearch"
  Title="Localized Live Search Demo" %>

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
    Ch12 Localized Live Search</h3>
  Culture:<asp:Label ID="CultureLabel" runat="server"></asp:Label>&nbsp; Current Date/Time:<asp:Label
    ID="DateTimeLabel" runat="server"></asp:Label>
  <br />
  <ApressLive:Search ID="search" runat="server" ResultControl="Result" RedirectToLiveSearch="false">
  </ApressLive:Search>
  <br />
  <br />
  <ApressLive:Result ID="Result" runat="server" PagerStyle="TextWithDHTML" PagerLinkStyle="Text">
    <StatusStyle Font-Bold="True" ForeColor="Blue"></StatusStyle>
  </ApressLive:Result>
</asp:Content>
