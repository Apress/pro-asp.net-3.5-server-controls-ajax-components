<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="MenuUserControlDemo.aspx.cs" Inherits="ControlsBook2Web.Ch02.MenuUserControlDemo"
  Title="Menu User Control Demo" %>

<%@ Register Src="MenuUserControl.ascx" TagName="MenuUserControl" TagPrefix="apressuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">2</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Encapsulating Functionality in ASP.NET</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <apressuc:MenuUserControl ID="MenuUserControl1" runat="server" />
</asp:Content>