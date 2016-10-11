<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="SimpleUserControlAJAXDemo.aspx.cs" Inherits="ControlsBook2Web.Ch09.SimpleUserControlAJAXDemo1"
  Title="Simple user Control AJAX Demo" %>

<%@ Register Src="SimpleUserControlAJAX.ascx" TagName="SimpleUserControlAJAX" TagPrefix="apressuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">9</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">ASP.NET AJAX Controls and Extenders</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <apressuc:SimpleUserControlAJAX ID="SimpleUserControlAJAX1" runat="server" />
</asp:Content>
