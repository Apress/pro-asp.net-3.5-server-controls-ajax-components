<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="TemplateMenu.aspx.cs" Inherits="ControlsBook2Web.Ch06.TemplateMenu"
  Title="Template Menu Control Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch06" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">6</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Templates</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    TemplateMenu Control</h3>
  <apress:TemplateMenu ID="menu1" runat="server" Height="43px" Width="224px">
    <SeparatorTemplate>
      &lt;&gt;
    </SeparatorTemplate>
    <HeaderTemplate>
      <div style="font-weight: bold; color: white; background-color: blue">
        Please follow the link of interest</div>
    </HeaderTemplate>
    <FooterTemplate>
      <div style="font-weight: bold; color: white; background-color: red">
        Thanks for visiting this site</div>
    </FooterTemplate>
  </apress:TemplateMenu>
  <br />
  <br />
</asp:Content>