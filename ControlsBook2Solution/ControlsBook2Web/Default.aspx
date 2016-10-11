<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControlsBook2Web.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Pro ASP.NET 3.5 Server Controls and AJAX Components</title>
  <link href="css/ControlsBook2Master.css" rel="stylesheet" type="text/css" />
  <link href="css/SkinnedControl.css" rel="stylesheet" type="text/css" />
</head>
<body>
  <form id="form1" runat="server">
  <div id="HeaderPanel">
    <br />
    <asp:Label ID="Label2" CssClass="TitleHeader" runat="server" Height="18px" Width="604px">Pro ASP.NET 3.5 Server Controls and AJAX Components</asp:Label>
    <br />
    <div style="padding: 5px">
      <asp:Image ID="Image1" runat="server" ImageUrl="~/img/blueline.jpg" /><br />
    </div>
    <br />
  </div>
  <div>
    <asp:Label ID="Label1" runat="server" Text="Controls Book 2 - Start Page" Font-Names="Verdana"
      Font-Size="Large"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label13" runat="server" Text="Chapter 1" Font-Names="Verdana" Font-Size="Medium"></asp:Label><br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Ch01/HelloWorld.aspx">Hello World Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Ch01/HtmlControls.aspx">Html Controls Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Ch01/SimpleControls.aspx">Simple Controls Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Ch01/ListControls.aspx">List Controls Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Ch01/RichControls.aspx">Rich Controls Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Ch01/XmlControl.aspx">Xml Control Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/Ch01/ValidationControls.aspx">Validator Controls Demo Web Form</asp:HyperLink><br />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Chapter 2" Font-Names="Verdana" Font-Size="Medium"></asp:Label><br />
    <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/Ch02/SimpleUserControlDemo.aspx">Simple User Control Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink13" runat="server" NavigateUrl="~/Ch02/MenuUserControlDemo.aspx">Menu User Control Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/Ch02/TableUserControlDemo.aspx">Table User Control Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl="~/Ch02/MenuCustomControlDemo.aspx">Menu Custom Control Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink11" runat="server" NavigateUrl="~/Ch02/TableCustomControlDemo.aspx">Table Custom Controls Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink12" runat="server" NavigateUrl="~/Ch02/TextBox3DDemo.aspx">TextBox3D Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink27" runat="server" NavigateUrl="~/Ch02/HtmlControlsAJAX.aspx">Html Controls AJAX Demo Web Form</asp:HyperLink><br />
    <br />
    <br />
    <asp:Label ID="Label10" runat="server" Text="Chapter 3" Font-Names="Verdana" Font-Size="Medium"></asp:Label><br />
    <asp:HyperLink ID="HyperLink14" runat="server" NavigateUrl="~/Ch03/ClientState.aspx">Client State Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink15" runat="server" NavigateUrl="~/Ch03/LabelControls.aspx">Label Controls Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink16" runat="server" NavigateUrl="~/Ch03/PostbackData.aspx">Postback Data Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink17" runat="server" NavigateUrl="~/Ch03/TextBox3DControlStateDemo.aspx">Control State Demo Web Form</asp:HyperLink><br />
    <br />
    <br />
    <asp:Label ID="Label11" runat="server" Font-Names="Verdana" Font-Size="Medium" Text="Chapter 4"></asp:Label><br />
    <asp:HyperLink ID="HyperLink18" runat="server" NavigateUrl="~/Ch04/FancyLabelStyle.aspx">Fancy Label Style Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink19" runat="server" NavigateUrl="~/Ch04/InputBoxStyle.aspx">InputBox Style Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink20" runat="server" NavigateUrl="~/Ch04/WebControlStyle.aspx">Web Control Style Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink26" runat="server" NavigateUrl="~/Ch04/StyleCollectionDemo.aspx">Style Collection Demo Web Form</asp:HyperLink><br />
    <br />
    <br />
    <asp:Label ID="Label12" runat="server" Font-Names="Verdana" Font-Size="Medium" Text="Chapter 5"></asp:Label><br />
    <asp:HyperLink ID="HyperLink21" runat="server" NavigateUrl="~/Ch05/TextBox.aspx">TextBox Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink22" runat="server" NavigateUrl="~/Ch05/CustomEventTextBox.aspx">Custom Event TextBox Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink23" runat="server" NavigateUrl="~/Ch05/SuperButton.aspx">SuperButton Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink24" runat="server" NavigateUrl="~/Ch05/PagerEventBubbling.aspx">Pager Event Bubbling Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink25" runat="server" NavigateUrl="~/Ch05/LifeCycle.aspx">LifeCycle Demo Web Form</asp:HyperLink><br />
    <br />
    <br />
    <asp:Label ID="Label8" runat="server" Font-Names="Verdana" Font-Size="Medium" Text="Chapter 6"></asp:Label><br />
    <asp:HyperLink ID="HyperLink29" runat="server" NavigateUrl="~/Ch06/TemplateMenu.aspx">Template Menu Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink30" runat="server" NavigateUrl="~/Ch06/TagParsingMenu.aspx">Tag Parsing Menu Demo Web Form</asp:HyperLink><br />
    <br />
    <br />
    <asp:Label ID="Label9" runat="server" Font-Names="Verdana" Font-Size="Medium" Text="Chapter 7"></asp:Label><br />
    <asp:HyperLink ID="HyperLink28" runat="server" NavigateUrl="~/Ch07/DataBoundRepeater.aspx">DataBound Repeater Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink32" runat="server" NavigateUrl="~/Ch07/AdvancedRepeater.aspx">Advanced Repeater Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink33" runat="server" NavigateUrl="~/Ch07/DynamicTemplates.aspx">Dynamic Templates Repeater Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink31" runat="server" NavigateUrl="~/Ch07/EnhancedSpreadSheetControl.aspx">Enhanced Spreadsheet Demo Web Form</asp:HyperLink><br />
    <br />
    <br />
    <asp:Label ID="Label14" runat="server" Font-Names="Verdana" Font-Size="Medium" Text="Chapter 8"></asp:Label><br />
    <asp:HyperLink ID="HyperLink34" runat="server" NavigateUrl="~/Ch08/Callback.aspx">Callback Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink45" runat="server" NavigateUrl="~/Ch08/RolloverImage.aspx">Rollover Image Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink35" runat="server" NavigateUrl="~/Ch08/Click.aspx">Click Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink36" runat="server" NavigateUrl="~/Ch08/Confirm.aspx">Confirm Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink37" runat="server" NavigateUrl="~/Ch08/ControlCallback.aspx">Control Callback (Stock Ticker) Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink38" runat="server" NavigateUrl="~/Ch08/UpDown.aspx">UpDown Demo Web Form</asp:HyperLink><br />
    <br />
    <br />
    <asp:Label ID="Label15" runat="server" Font-Names="Verdana" Font-Size="Medium" Text="Chapter 9"></asp:Label><br />
    <asp:HyperLink ID="HyperLink41" runat="server" NavigateUrl="~/Ch09/SimpleUserControlAjaxDemo.aspx">SimpleUserControl AJAX Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink39" runat="server" NavigateUrl="~/Ch09/HighlightedHyperlink.aspx">HighlightedHyperlink Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink40" runat="server" NavigateUrl="~/Ch09/HoverButton.aspx">HoverButton Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink42" runat="server" NavigateUrl="~/Ch09/TextCaseExtender.aspx">TextCaseExtender Demo Web Form</asp:HyperLink><br />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Font-Names="Verdana" Font-Size="Medium" Text="Chapter 10"></asp:Label><br />
    <asp:HyperLink ID="HyperLink46" runat="server" NavigateUrl="~/Ch10/ControlAdapters.aspx">StatefulLabelAdapter Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink47" runat="server" NavigateUrl="~/Ch10/CustomerInfo.aspx">Customer Info Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink48" runat="server" NavigateUrl="~/Ch10/CustomerInfoWebPart.aspx">Customer Info Web Part Demo Web Form</asp:HyperLink><br />
    <br />
    <br />
    <asp:Label ID="Label16" runat="server" Font-Names="Verdana" Font-Size="Medium" Text="Chapter 11"></asp:Label><br />
    <asp:HyperLink ID="HyperLink44" runat="server" NavigateUrl="~/Ch11/TitledThumbnail.aspx">TitledThumbnail Demo Web Form</asp:HyperLink><br />
    <br />
    <br />
    <asp:Label ID="Label17" runat="server" Font-Names="Verdana" Font-Size="Medium" Text="Chapter 12"></asp:Label><br />
    <asp:HyperLink ID="HyperLink49" runat="server" NavigateUrl="~/Ch12/LiveSearch.aspx">Live Search Demo Web Form</asp:HyperLink><br />  
    <asp:HyperLink ID="HyperLink51" runat="server" NavigateUrl="~/Ch12/CustomLiveSearch.aspx">Custom Live Search Demo Web Form</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink50" runat="server" NavigateUrl="~/Ch12/LocalizedLiveSearch.aspx">Localized Live Search Demo Web Form</asp:HyperLink><br />  
    <br />
    <br />
  </div>
  <div id="FooterPanel">
    <br />
    <asp:Image ID="Image2" runat="server" ImageUrl="~/img/blueline.jpg" /><br />
    <asp:Label CssClass="TitleFooter" ID="Label5" runat="server">Pro ASP.NET 3.5 Server Controls and AJAX Components</asp:Label><br />
    <asp:Label CssClass="Author" ID="Label6" runat="server">By Rob Cameron and Dale Michalk</asp:Label><br />
    <asp:Label CssClass="Copyright" ID="Label7" runat="server">Copyright © 2007, Apress L.P.</asp:Label>
  </div>
  </form>
</body>
</html>
