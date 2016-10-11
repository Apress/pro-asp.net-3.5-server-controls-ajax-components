<%@ Page Trace="true" Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="LifeCycle.aspx.cs" Inherits="ControlsBook2Web.Ch05.LifeCycle"
  Title="LifeCycle Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch05" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">5</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Events</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    LifeCycle</h3>
  <apress:Lifecycle ID="life1" runat="server" />
  <asp:Button ID="Button1" runat="server" Text="Button"></asp:Button>
</asp:Content>
