<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="HtmlControlsAJAX.aspx.cs" Inherits="ControlsBook2Web.Ch02.HtmlControlsAJAX"
  Title="HTML Controls Demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">2</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Encapsulating Functionality in ASP.NET</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    HTML Controls</h3>
  X
  <input type="text" id="XTextBox" runat="server" /><br />
  <br />
  Y
  <input type="text" id="YTextBox" runat="server" /><br />
  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
      <input type="submit" id="BuildTableButton" runat="server" value="Build Table" onserverclick="BuildTableButton_ServerClick" />
      <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
        <ProgressTemplate>
          Updating...</ProgressTemplate>
      </asp:UpdateProgress>
      <span id="Span1" runat="server"></span>
    </ContentTemplate>
  </asp:UpdatePanel>
</asp:Content>
