<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="SimpleUserControlDemo.aspx.cs" 
  Inherits="ControlsBook2Web.Ch02.SimpleUserControlDemo"
  Title="Simple User Control Demo" %>

<%@ Register Src="SimpleUserControl.ascx" TagName="SimpleUserControl" TagPrefix="apressuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">2</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Encapsulating Functionality in ASP.NET</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <apressuc:SimpleUserControl ID="SimpleUserControl1" runat="server" />
</asp:Content>