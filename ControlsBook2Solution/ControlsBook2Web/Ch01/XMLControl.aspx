<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="XMLControl.aspx.cs" Inherits="ControlsBook2Web.Ch01.XMLControls"
  Title="XML Control Demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">1</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Basics and What’s new in ASP.NET</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    XML Control</h3>
  <asp:Xml ID="Xml1" runat="server"></asp:Xml><br />
  <asp:AccessDataSource ID="ApressBooksds" runat="server" DataFile="~/App_Data/ApressBooks.mdb"
    SelectCommand="SELECT [ISBN], [Author], [DatePublished], [NumPages], [Price] FROM [Books]">
  </asp:AccessDataSource>
</asp:Content>
