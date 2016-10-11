<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="TextBox3DDemo.aspx.cs" Inherits="ControlsBook2Web.Ch02.TextBox3DDemo"
  Title="TextBox3D Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch02" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">2</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Encapsulating Functionality in ASP.NET</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <br />
  <apress:TextBox3d ID="TextBox3d1" runat="server" Width="159px" Height="22px" Enable3D="True">I look 3D!</apress:TextBox3d>
  <br />
  <br />
  <apress:TextBox3d ID="Textbox3d2" runat="server" Width="159px" Height="22px" Enable3D="false">I don't!</apress:TextBox3d>
  <br />
</asp:Content>
