<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>

<%@ Page Language="c#" CodeBehind="ContainerControls.aspx.cs" Inherits="ControlsBook2Mobile.Ch10.ContainerControls"
  AutoEventWireup="True" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<body Xmlns:mobile="http://schemas.microsoft.com/Mobile/WebForm">
  <mobile:Form id="PanelForm" runat="server" Paginate="True" OnActivate="PanelForm_Activate">
    <mobile:Panel id="QueryPanel" runat="server">
      <mobile:Label id="Label1" runat="server">Query by Contact Name:</mobile:Label>
      <mobile:TextBox id="PanelFormTextBox" runat="server">
      </mobile:TextBox>
      <mobile:Command id="PanelFormCmd" runat="server" OnClick="PanelFormCmd_Click">Submit</mobile:Command>
    </mobile:Panel>
    <mobile:Panel id="ResultsPanel" Paginate="True" runat="server" Visible="False">
      <mobile:List id="PanelList" runat="server" Decoration="Numbered" ItemsPerPage="10">
      </mobile:List>
    </mobile:Panel>
  </mobile:Form>
</body>
</html>
