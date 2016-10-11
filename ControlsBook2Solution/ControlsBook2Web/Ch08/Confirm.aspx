<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="Confirm.aspx.cs" Inherits="ControlsBook2Web.Ch08.Confirm"
  Title="Confirm Demo" %>

<%@ Register Assembly="ControlsBook2Lib" Namespace="ControlsBook2Lib.Ch08" TagPrefix="apress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">8</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Integrating Client-Side Script</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <apress:FormConfirmation ID="confirm1" runat="server" Message="formconfirmation: Are you sure you want to submit?" />
  <br />
  <asp:Button ID="button1" runat="server" Text="Button" OnClick="Button_Click" /><br />
  <asp:LinkButton ID="linkbutton1" runat="server" Text="LinkButton" OnClick="LinkButton_Click" /><br />
  <apress:ConfirmedLinkButton ID="confirmlink1" runat="server" Message="confirmedlinkbutton: Are you sure you want to submit?"
    OnClick="ConfirmLinkButton_ClickClick">ConfirmedLinkButton</apress:ConfirmedLinkButton>
  <br />
  <br />
  <br />
  <asp:Button ID="Button2" runat="server" Text="Reset Status" 
    onclick="Button2_Click" />
  <asp:Label ID="status" runat="server" Text="Click a button."/>
</asp:Content>