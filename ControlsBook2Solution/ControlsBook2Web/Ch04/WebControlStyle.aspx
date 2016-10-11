<%@ Page Language="C#" 
  MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="WebControlStyle.aspx.cs" 
  Inherits="ControlsBook2Web.Ch04.WebControlStyle"
  Title="Web Control Style Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch04" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">4</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">WebControl Base Class and Control Styles</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Web Control Style</h3>
  <span id="Prompt">Enter your first name:</span><br />
  <apress:Textbox ID="NameTextbox" runat="server" Font-Bold="True" BackColor="#E0E0E0"
    Font-Italic="True" Font-Names="Tahoma"></apress:Textbox>
  <br />
  <br />
  Font-Name:
  <asp:DropDownList ID="FontDropDownList" runat="server">
    <asp:ListItem Value="Arial">Arial</asp:ListItem>
    <asp:ListItem Value="Courier New">Courier New</asp:ListItem>
    <asp:ListItem Value="Times New Roman">Times New Roman</asp:ListItem>
    <asp:ListItem Value="Monotype Corsiva">Monotype Corsiva</asp:ListItem>
  </asp:DropDownList><br />
  ForeColor:
  <asp:DropDownList ID="ForeColorDropDownList" runat="server">
    <asp:ListItem Value="Blue">Blue</asp:ListItem>
    <asp:ListItem Value="Red">Red</asp:ListItem>
    <asp:ListItem Value="Black">Black</asp:ListItem>
  </asp:DropDownList><br />
  <asp:CheckBox ID="BoldCheckbox" runat="server" Text="Bold: " TextAlign="Left"></asp:CheckBox><br />
  <asp:CheckBox ID="ItalicCheckbox" runat="server" Text="Italic: " TextAlign="Left">
  </asp:CheckBox><br />
  <asp:CheckBox ID="UnderlineCheckbox" runat="server" Text="Underline: " TextAlign="Left">
  </asp:CheckBox><br />
  CSS class:
  <asp:TextBox ID="CssClassTextBox" runat="server" Text=""></asp:TextBox><br />
  <br />
  <asp:Button ID="SetStyleButton" runat="server" Text="Set Style" OnClick="SetStyleButton_Click">
  </asp:Button>&nbsp;
  <asp:Button ID="SubmitPageButton" runat="server" Text="Submit Page"></asp:Button><br />
  <br />
  <apress:Label ID="NameLabel" runat="server" Text="blank"></apress:Label>
  <br />
</asp:Content>
