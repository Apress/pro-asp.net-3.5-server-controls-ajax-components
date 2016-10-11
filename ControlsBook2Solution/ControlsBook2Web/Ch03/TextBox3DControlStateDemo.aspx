<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="TextBox3DControlStateDemo.aspx.cs" 
  Inherits="ControlsBook2Web.Ch03.TextBox3DControlStateDemo"
  Title="Control State Demo" %>

<%@ Register TagPrefix="apressCh02" Namespace="ControlsBook2Lib.Ch02" Assembly="ControlsBook2Lib" %>
<%@ Register TagPrefix="apressCh03" Namespace="ControlsBook2Lib.Ch03" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">3</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">ASP.NET State Management</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <br />
  <asp:Button ID="buttonToggle3d" runat="server" Text="Toggle3d" OnClick="buttonToggle3d_Click" /><br />
  <br />
  <apressCh03:TextBox3d ID="Textbox3CtrlState" runat="server" Width="159px" Height="18px"
    Enable3D="False" EnableViewState="False">I support control state</apressCh03:TextBox3d>
  <br />
  <br />
  <apressCh02:TextBox3d ID="TextBox3dBasic" runat="server" Width="159px" Height="16px"
    Enable3D="False" EnableViewState="False">I don't!</apressCh02:TextBox3d>
  <br />
  <br />
  <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" /><br />
  <br />
  <asp:Label ID="LabelViewState" runat="server" Text="ViewState"></asp:Label><br />
  <br />
</asp:Content>