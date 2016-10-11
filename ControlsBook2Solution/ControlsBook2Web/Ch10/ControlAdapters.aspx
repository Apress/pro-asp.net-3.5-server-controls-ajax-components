<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="ControlAdapters.aspx.cs" Inherits="ControlsBook2Web.Ch10.ControlAdapters"
  Title="ControlAdapter Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch03" Assembly="ControlsBook2Lib" %>
<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch04" Assembly="ControlsBook2Lib" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">10</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Other Server Controls</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Control Adapter Modified Controls</h3>
 
  <h3>FancyLabel</h3>
  <apress:FancyLabel ID="FancyLabel1" runat="server" Text="Adapted Fancy Label" />
  <br />
  <h3>StatefulLabel</h3>
  <apress:StatefulLabel ID="StatefulLabel1" runat="server" Text="Adapted StatefulLabel"/>
</asp:Content>
