<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="Click.aspx.cs" Inherits="ControlsBook2Web.Ch08.Click"
  Title="Click Demo" %>

<%@ Register Assembly="ControlsBook2Lib" Namespace="ControlsBook2Lib.Ch08" TagPrefix="apress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">8</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Integrating Client-Side Script</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Ch08 Click Event Handling</h3>
  <asp:Label ID="TopLabel" runat="server" Text="Click the TopLabel" onclick="alert('TopLabel clicked!');" />
  <br />
  <apress:ClickLabel ID="ClickLabel1" runat="server" Text="Click the MiddleLabel" ClickText="MiddleLabel clicked!" />
  <br />
  <asp:Label ID="BottomLabel" runat="server" Text="Click the BottomLabel" />
</asp:Content>