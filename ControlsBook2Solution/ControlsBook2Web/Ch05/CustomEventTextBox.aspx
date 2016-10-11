<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="CustomEventTextBox.aspx.cs" Inherits="ControlsBook2Web.Ch05.CustomEventTextBox"
  Title="Custom Event TextBox Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch05" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">5</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Events</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    CustomEventTextBox</h3>
  Enter your name:<br />
  <apress:CustomEventTextBox ID="NameCustom" runat="server" OnTextChanged="NameCustom_TextChanged">
  </apress:CustomEventTextBox>
  <br />
  <br />
  <asp:Button ID="SubmitPageButton" runat="server" Text="Submit Page"></asp:Button><br />
  <br />
  Before:<asp:Label ID="BeforeLabel" runat="server" Text=""></asp:Label><br />
  After:<asp:Label ID="AfterLabel" runat="server" Text=""></asp:Label><br />
</asp:Content>
