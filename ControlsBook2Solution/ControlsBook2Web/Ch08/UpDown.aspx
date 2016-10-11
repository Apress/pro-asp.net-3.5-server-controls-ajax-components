<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="UpDown.aspx.cs" Inherits="ControlsBook2Web.Ch08.UpDown"
  Title="UpDown Demo" %>

<%@ Register Assembly="ControlsBook2Lib" Namespace="ControlsBook2Lib.Ch08" TagPrefix="apress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
    <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">8</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Integrating Client-Side Script</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
    <apress:UpDown ID="updown1" runat="server" MinValue="1" MaxValue="15" Increment="3"
    Value="6" OnValueChanged="updown1_ValueChanged" Width="98px" 
        EnableClientScript="True"></apress:UpDown>
  <br />
  <br />
  Time:<asp:Label ID="timelabel" runat="server" /><br />
  <br />
  Changes:<asp:Label ID="changelabel" runat="server" /><br />
  <br />
  <asp:Button ID="submitbtn" runat="server" Text="Submit" />
</asp:Content>
