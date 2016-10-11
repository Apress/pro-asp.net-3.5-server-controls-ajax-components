<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="ControlsBook2MobileHeader.ascx.cs"
  Inherits="ControlsBook2Mobile.Ch10.ControlsBook2MobileHeader" TargetSchema="http://schemas.microsoft.com/Mobile/WebUserControl" %>
<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<mobile:Label id="Label2" runat="server" Font-Name="Arial Narrow" Font-Bold="False"
  Font-Size="Small">Pro ASP.NET 3.5 Server Controls and AJAX Components</mobile:Label>
<mobile:Label id="Label1" runat="server" Font-Name="Arial Narrow" Font-Bold="False"
  Font-Size="Small">
<DeviceSpecific>
  <Choice Filter="isWML11" Visible="False"></Choice>
</DeviceSpecific>Chapter</mobile:Label>
<mobile:Label id="Label4" runat="server" Font-Name="Arial Narrow" Font-Bold="False"
  Font-Size="Small">
<DeviceSpecific>
  <Choice Filter="isWML11" Visible="False"></Choice>
</DeviceSpecific>Chapter Title</mobile:Label>
<mobile:Image id="Image1" runat="server" ImageUrl="../Ch10/imgs/line.bmp">
  <DeviceSpecific>
    <Choice Filter="isWML11"></Choice>
  </DeviceSpecific>
</mobile:Image>
