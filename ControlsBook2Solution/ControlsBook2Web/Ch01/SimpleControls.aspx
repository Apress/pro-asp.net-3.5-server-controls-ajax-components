<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="SimpleControls.aspx.cs" Inherits="ControlsBook2Web.Ch01.SimpleControls"
  Title="Simple Controls Demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">1</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Basics and What’s new in ASP.NET</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Simple Controls</h3>
  X
  <asp:TextBox ID="XTextBox" runat="server"></asp:TextBox><br />
  <br />
  Y
  <asp:TextBox ID="YTextBox" runat="server"></asp:TextBox><br />
  <br />
  <asp:Button ID="BuildTableButton" runat="server" Text="Build Table" OnClick="BuildTableButton_Click">
  </asp:Button><br />
  <asp:PlaceHolder ID="TablePlaceHolder" runat="server"></asp:PlaceHolder>
</asp:Content>
