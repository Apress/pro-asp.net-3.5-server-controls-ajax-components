<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="ControlsBook2Web.Ch01.HelloWorld"
  Title="Hello, World! Demo Web Form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">1</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Basics and What’s new in ASP.NET</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    <asp:Label ID="Label1" runat="server" Text="Hello, World!"></asp:Label></h3>
  <asp:DropDownList ID="Greeting" runat="server" ToolTip="Select a greeting">
  </asp:DropDownList>
  <asp:TextBox ID="Name" runat="server" Font-Italic="True" ToolTip="Enter your name"
    OnTextChanged="Name_TextChanged"></asp:TextBox><br />
  <br />
  <asp:Button ID="ClickMe" runat="server" Text="Click Me!" OnClick="ClickMe_Click"></asp:Button><br />
  <br />
  <asp:Label ID="ChangeLabel" runat="server">Change Label</asp:Label><br />
  <asp:Label ID="Resultlabel" runat="server">Result Label</asp:Label>
  <br />
</asp:Content>
