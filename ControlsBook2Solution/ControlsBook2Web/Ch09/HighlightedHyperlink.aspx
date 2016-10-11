<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="HighlightedHyperlink.aspx.cs" Inherits="ControlsBook2Web.Ch09.HighlightedHyperlink"
  Title="HighlightedHyperLink Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch09" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadSection" runat="server">
  <style type="text/css">
    .Highlight
    {
      color: navy;
      font-weight: bolder;
    }
    .NoHighlight
    {
      color: Green;
      font-weight: lighter;
    }
  </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">9</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">ASP.NET AJAX Controls and Extenders</asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PrimaryContent" runat="server">
  <br />
  <apress:HighlightedHyperLink ID="HighlightedHyperLink1" HighlightCssClass="Highlight"
    NoHighlightCssClass="NoHighlight" runat="server" NavigateUrl="http://www.microsoft.com">Microsoft</apress:HighlightedHyperLink><br />
  <apress:HighlightedHyperLink ID="HighlightedHyperLink2" HighlightCssClass="Highlight"
    NoHighlightCssClass="NoHighlight" runat="server" NavigateUrl="http://apress.com">Apress</apress:HighlightedHyperLink><br />
  <apress:HighlightedHyperLink ID="HighlightedHyperLink3" HighlightCssClass="Highlight"
    NoHighlightCssClass="NoHighlight" runat="server" NavigateUrl="http://ajax.asp.net">ASP.NET AJAX</apress:HighlightedHyperLink><br />
  <apress:HighlightedHyperLink ID="HighlightedHyperLink4" HighlightCssClass="Highlight"
    NoHighlightCssClass="NoHighlight" runat="server" NavigateUrl="http://msdn.microsoft.com">MSDN Online</apress:HighlightedHyperLink><br />
  <br />
</asp:Content>
