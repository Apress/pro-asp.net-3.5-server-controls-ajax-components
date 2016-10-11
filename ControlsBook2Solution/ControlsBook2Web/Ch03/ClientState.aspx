<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="ClientState.aspx.cs" Inherits="ControlsBook2Web.Ch03.ClientState"
  Title="Client State Demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">3</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">ASP.NET State Management</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Client State</h3>
  Enter your name:<br />
  <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox><br />
  <br />
  <asp:Button ID="SetStateButton" runat="server" Text="Set State" OnClick="SetStateButton_Click">
  </asp:Button>&nbsp;
  <asp:Button ID="SubmitPageButton" runat="server" Text="Submit Page"></asp:Button><br />
  <input id="HiddenName" type="hidden" runat="server" />
  <br />
  <asp:HyperLink ID="URLEncodeLink" runat="server">Link to encode name in URL</asp:HyperLink><br />
  <br />
  <h3>
    Results</h3>
  Cookie:<asp:Label ID="CookieLabel" runat="server"></asp:Label><br />
  URL:<asp:Label ID="URLLabel" runat="server"></asp:Label><br />
  Hidden Variable:<asp:Label ID="HiddenLabel" runat="server"></asp:Label><br />
  ViewState:<asp:Label ID="ViewStateLabel" runat="server"></asp:Label><br />
</asp:Content>
