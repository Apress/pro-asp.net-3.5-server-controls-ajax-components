<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="ControlsBook2MobileFooter.ascx.cs"
  Inherits="ControlsBook2Mobile.Ch10.ControlsBook2MobileFooter" TargetSchema="http://schemas.microsoft.com/Mobile/WebUserControl" %>
<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<mobile:Image id="Image1" runat="server" ImageUrl="../Ch10/imgs/line.bmp">
  <DeviceSpecific>
    <Choice Filter="isWML11"></Choice>
  </DeviceSpecific>
</mobile:Image>
<mobile:Label id="Label1" runat="server" Font-Bold="False" Font-Size="Small" Font-Name="Tahoma">
<DeviceSpecific>
  <Choice Filter="isWML11" Visible="False"></Choice>
</DeviceSpecific>Pro ASP.NET 3.5 Server Controls and AJAX Components</mobile:Label>
<mobile:Label id="Label2" runat="server" Font-Size="Small" Font-Name="Arial Narrow">
<DeviceSpecific>
  <Choice Filter="isWML11" Visible="False"></Choice>
</DeviceSpecific>By Robert Cameron and Dale Michalk</mobile:Label>
<mobile:Label id="Label3" runat="server" Font-Bold="False" Font-Size="Small" Font-Name="Tahoma">Copyright © 2007, Apress L.P. </mobile:Label>
