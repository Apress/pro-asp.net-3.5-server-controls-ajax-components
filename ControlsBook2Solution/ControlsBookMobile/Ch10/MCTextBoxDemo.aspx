<%@ Page Language="c#" CodeBehind="MCTextBoxDemo.aspx.cs" Inherits="ControlsBook2Mobile.Ch10.MCTextBox"
  AutoEventWireup="True" %>

<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<%@ Register TagPrefix="ApressMC" Namespace="ControlsBook2Lib.Ch10" Assembly="ControlsBook2Lib" %>
<head>
  <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
  <meta content="http://schemas.microsoft.com/Mobile/Page" name="vs_targetSchema">
</head>
<body>
  <mobile:Form ID="Form1" Runat="server">
    <mobile:Label ID="Label1" Runat="server">Change the value:</mobile:Label>
    <ApressMC:MCTextBox ID="MCTextBox1" runat="server" Text="Hi There!" MaxLength="15"
      Numeric="False" Password="False" Size="10" OnTextChanged="MCTextBox1_TextChanged"></ApressMC:MCTextBox>
    <mobile:Command ID="Command1" Runat="server">Command</mobile:Command>
    <mobile:Label ID="ChangeLabel" Runat="server">Message</mobile:Label>
  </mobile:Form>
</body>
