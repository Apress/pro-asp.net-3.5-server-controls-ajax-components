<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="TextCaseExtender.aspx.cs" Inherits="ControlsBook2Web.Ch09.TextCaseExtenderControl"
  Title="TextCaseExtender Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch09" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadSection" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">9</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">ASP.NET AJAX Controls and Extenders</asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PrimaryContent" runat="server">
  <br />
  <asp:TextBox ID="TextBox1" runat="server" Width="300px"></asp:TextBox><br />
  <br />
  <br />
  <asp:Label ID="Label1" runat="server" Text="Set case in the DropDownList, click Submit, and then type some text in the above textbox."
    CssClass="Chapter"></asp:Label><br />
  <asp:DropDownList ID="DropDownList1" runat="server" Height="21px" Width="148px">
    <asp:ListItem Text="LowerCase" Value="lowercase" Selected="True" />
    <asp:ListItem Text="TitleCase" Value="TitleCase" />
    <asp:ListItem Text="UpperCase" Value="UPPERCASE" />
  </asp:DropDownList><br />
  <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
  <apress:TextCaseExtender ID="TextCaseExtender1" runat="server" TargetControlID="TextBox1"
    CaseStyle="LowerCase" />
</asp:Content>
