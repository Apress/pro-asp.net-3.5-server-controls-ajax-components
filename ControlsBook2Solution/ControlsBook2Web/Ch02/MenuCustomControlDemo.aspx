<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="MenuCustomControlDemo.aspx.cs" Inherits="ControlsBook2Web.Ch02.MenuCustomControlDemo"
  Title="Menu Custom Control Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch02" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">2</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Encapsulating Functionality in ASP.NET</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Menu Custom Control</h3>
  <apress:MenuCustomControl ID="menu1" runat="server" />
  <br />
  <br />
</asp:Content>