<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="HtmlControls.aspx.cs" Inherits="ControlsBook2Web.Ch01.HtmlControls"
  Title="HTML Controls Demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">1</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Basics and What’s new in ASP.NET</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    HTML Controls</h3>
  X
  <input type="text" id="XTextBox" runat="server" /><br />
  <br />
  Y
  <input type="text" id="YTextBox" runat="server" /><br />
  <br />
  <input type="submit" id="BuildTableButton" runat="server" value="Build Table" onserverclick="BuildTableButton_ServerClick" /><br />
  <br />
  <span id="Span1" runat="server"></span>
</asp:Content>
