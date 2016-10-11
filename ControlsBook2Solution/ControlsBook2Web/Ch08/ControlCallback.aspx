<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="ControlCallback.aspx.cs" Inherits="ControlsBook2Web.Ch08.ControlCallback"
  Title="Untitled Page" %>

<%@ Register Assembly="ControlsBook2Lib" Namespace="ControlsBook2Lib.Ch08" TagPrefix="apress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">8</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Integrating Client-Side Script</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <br />
  <apress:StockNews ID="stockNews" runat="server" />
  <br />
</asp:Content>
