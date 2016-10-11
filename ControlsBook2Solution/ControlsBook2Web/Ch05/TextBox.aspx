<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="TextBox.aspx.cs" Inherits="ControlsBook2Web.Ch05.TextBox"
  Title="Untitled Page" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch05" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">5</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Events</asp:Label></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    TextBox</h3>
  Enter your name:<br />
  <apress:TextBox ID="NameTextBox" runat="server" OnTextChanged="NameTextBox_TextChanged">
  </apress:TextBox>
  <br />
  <br />
  <asp:Button ID="SubmitPageButton" runat="server" Text="Submit Page"></asp:Button><br />
  <br />
  <asp:Label ID="ChangeLabel" runat="server" Text=""></asp:Label><br />
</asp:Content>