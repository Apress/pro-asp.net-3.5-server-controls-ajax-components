<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="TableUserControlDemo.aspx.cs" Inherits="ControlsBook2Web.Ch02.TableUserControlDemo"
  Title="Table User Control Demo" %>

<%@ Register Src="TableUserControl.ascx" TagName="TableUserControl" TagPrefix="apressuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">2</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Encapsulating Functionality in ASP.NET</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Table User Control</h3>
  <p>
    <apressuc:TableUserControl ID="TableUserControl1" runat="server" X="1" Y="1" />
</asp:Content>
