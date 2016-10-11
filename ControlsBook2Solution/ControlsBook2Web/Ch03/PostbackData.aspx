<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="PostbackData.aspx.cs" Inherits="ControlsBook2Web.Ch03.PostbackData"
  Title="Postback Data Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch03" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">3</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">ASP.NET State Management</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Postback Data</h3>
  Enter your name:<br />
  <apress:Textbox ID="NameTextBox" runat="server">
  </apress:Textbox>
  <br />
  <br />
  <asp:Button ID="SetLabelButton" runat="server" Text="Set Labels" OnClick="SetLabelButton_Click">
  </asp:Button>&nbsp;
  <asp:Button ID="SubmitPageButton" runat="server" Text="Submit Page"></asp:Button><br />
  <br />
  <h3>
    StatelessLabel</h3>
  <apress:StatelessLabel ID="StatelessLabel1" runat="server" Text="StatelessLabel">
  </apress:StatelessLabel>
  <br />
  <h3>
    StatefulLabel</h3>
  <apress:StatefulLabel ID="StatefulLabel1" runat="server" Text="StatefulLabel">
  </apress:StatefulLabel>
</asp:Content>
