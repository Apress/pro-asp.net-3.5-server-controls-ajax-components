<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="PagerEventBubbling.aspx.cs" Inherits="ControlsBook2Web.Ch05.PagerEventBubbling"
  Title="Pager Event Bubbling Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch05" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">5</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Events</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Pager Event Bubbling</h3>
  <apress:Pager ID="pager1" Display="Button" runat="server" OnPageCommand="Pagers_PageCommand">
  </apress:Pager>
  <br />
  <br />
  <h3>
    Direction:&nbsp;<asp:Label ID="DirectionLabel" runat="server"></asp:Label></h3>
  <apress:Pager ID="pager2" runat="server" Display="Hyperlink" OnPageCommand="Pagers_PageCommand">
  </apress:Pager>
  <br />
  <br />
</asp:Content>
