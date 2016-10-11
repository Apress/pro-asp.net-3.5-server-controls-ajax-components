<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="DynamicTemplates.aspx.cs" Inherits="ControlsBook2Web.Ch07.DynamicTemplates"
  Title="Dynamic Templates Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch07" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">7</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Data Binding</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Dynamic Templates</h3>
  <b>Template: </b>
  <br />
  <br />
  <asp:DropDownList ID="templateList" runat="server" AutoPostBack="True">
    <asp:ListItem>FileTemplate.ascx</asp:ListItem>
    <asp:ListItem>CustCodeTemplate</asp:ListItem>
    <asp:ListItem>CustFileTemplate.ascx</asp:ListItem>
  </asp:DropDownList>
  <br />
  <br />
  <b>Repeater:</b><br />
  <br />
  <apress:Repeater ID="repeaterRdrCust" runat="server">
  </apress:Repeater>
</asp:Content>
