<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="SuperButton.aspx.cs" Inherits="ControlsBook2Web.Ch05.SuperButton"
  Title="SuperButton Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch05" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">5</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Events</asp:Label></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    SuperButton</h3>
  <apress:SuperButton ID="superbtn" runat="server" Text="SuperButton Button" OnClick="superbtn_Click">
  </apress:SuperButton>
  <br />
  <br />
  <apress:SuperButton Display="hyperlink" ID="superlink" runat="server" Text="SuperButton HyperLink"
    OnClick="superlink_Click">
  </apress:SuperButton>
  <br />
  <br />
  <h3>
    <asp:Label ID="ClickLabel" runat="server">Waiting...</asp:Label></h3>
</asp:Content>
