<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="RolloverImage.aspx.cs" Inherits="ControlsBook2Web.Ch08.RolloverImage"
  Title="RolloverImage Demo" %>

<%@ Register Assembly="ControlsBook2Lib" Namespace="ControlsBook2Lib.Ch08" TagPrefix="apress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadSection" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">8</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Integrating Client-Side Script</asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PrimaryContent" runat="server">
  <apress:RolloverImageLink ID="image1" runat="server" ImageUrl="ex1.gif" OverImageUrl="ex1_selected.gif"
    NavigateUrl="http://www.apress.com" />
  <apress:RolloverImageLink ID="image2" runat="server" ImageUrl="ex2.gif" OverImageUrl="ex2_selected.gif"
    NavigateUrl="http://asp.net" EnableClientScript="True" /><br />
</asp:Content>