<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<%@ Page language="c#" Codebehind="UserControlHost.aspx.cs" Inherits="ControlsBook2Mobile.Ch10.UserControlHost" AutoEventWireup="True" %>
<%@ Register TagPrefix="ApressUCMobile" TagName="ControlsBook2MobileHeader" Src="ControlsBook2MobileHeader.ascx" %>
<%@ Register TagPrefix="ApressUCMobile" TagName="ControlsBook2MobileFooter" Src="ControlsBook2MobileFooter.ascx" %>
<HEAD>
  <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
  <meta content="C#" name="CODE_LANGUAGE">
  <meta content="http://schemas.microsoft.com/Mobile/Page" name="vs_targetSchema">
</HEAD>
<body Xmlns:mobile="http://schemas.microsoft.com/Mobile/WebForm">
  <mobile:form id="MainForm" runat="server">
    <ApressUCMobile:ControlsBook2MobileHeader id="ControlsBook2MobileHeader1" ChapterNumber="11" ChapterTitle="Customizing and Implementing Mobile Controls"
      runat="server"></ApressUCMobile:ControlsBook2MobileHeader>
    <mobile:Link id="Link1" runat="server" NavigateUrl="#LabelForm">Label Styles</mobile:Link>
    <mobile:Link id="Link2" runat="server" NavigateUrl="#QueryForm">Paging Style</mobile:Link>
    <ApressUCMobile:ControlsBook2MobileFooter id="ControlsBook2MobileFooter1" runat="server"></ApressUCMobile:ControlsBook2MobileFooter>
  </mobile:form>
  <mobile:form id="LabelForm" runat="server">
    <ApressUCMobile:ControlsBook2MobileHeader id="ControlsBook2MobileHeader2" ChapterNumber="10" ChapterTitle="Customizing and Implementing Mobile Controls"
      runat="server"></ApressUCMobile:ControlsBook2MobileHeader>
    <mobile:Label id="Label3" runat="server" StyleReference="SimpleTextStyle1">Some simple text.(BoldTimes)</mobile:Label>
    <mobile:Label id="Label5" runat="server" StyleReference="title">Some Title text.(title default style)</mobile:Label>
    <mobile:Label id="Label4" runat="server" StyleReference="SimpleTextStyle2">More simple text.(ItalicVerdana)</mobile:Label>
    <mobile:Label id="Label6" runat="server" StyleReference="subcommand">Some subcommand Text.(subcommand default style)</mobile:Label>
    <mobile:Label id="Label7" runat="server" StyleReference="error">Error: Some error text.(error default style)</mobile:Label>
    <ApressUCMobile:ControlsBook2MobileFooter id="ControlsBook2MobileFooter2" runat="server"></ApressUCMobile:ControlsBook2MobileFooter>
  </mobile:form>
  <mobile:form id="QueryForm" runat="server" StyleReference="QueryStyle">
    <ApressUCMobile:ControlsBook2MobileHeader id="ControlsBook2MobileHeader3" ChapterNumber="11" ChapterTitle="Customizing and Implementing Mobile Controls"
      runat="server"></ApressUCMobile:ControlsBook2MobileHeader>
    <mobile:Label id="Label1" runat="server">Query by Contact Name:</mobile:Label>
    <mobile:TextBox id="NameTextBox" runat="server">Ana Trujillo</mobile:TextBox>
    <mobile:Command id="QueryCmd" runat="server" onclick="QueryCmd_Click">Submit</mobile:Command>
    <ApressUCMobile:ControlsBook2MobileFooter id="ControlsBook2MobileFooter3" runat="server"></ApressUCMobile:ControlsBook2MobileFooter>
  </mobile:form>
  <mobile:form id="ResultsForm" runat="server" Paginate="True" StyleReference="ResultsStyle" PagerStyle-NextPageText="Go To Next"
    PagerStyle-PreviousPageText="Go to Previous">
    <ApressUCMobile:ControlsBook2MobileHeader id="ControlsBook2MobileHeader4" ChapterNumber="10" ChapterTitle="Customizing and Implementing Mobile Controls"
      runat="server"></ApressUCMobile:ControlsBook2MobileHeader>
    <mobile:List id="CustList" runat="server" ItemsPerPage="10" Decoration="Numbered"></mobile:List>
    <ApressUCMobile:ControlsBook2MobileFooter id="ControlsBook2MobileFooter4" runat="server"></ApressUCMobile:ControlsBook2MobileFooter>
  </mobile:form>
  <mobile:stylesheet id="InlineStyleSheet" runat="server">
    <mobile:Style Font-Size="Small" Font-Name="Times" Font-Bold="True" ForeColor="Black" Wrapping="NoWrap"
      Name="SimpleTextStyle1"></mobile:Style>
    <mobile:Style Font-Size="Small" Font-Name="Verdana" Font-Italic="True" ForeColor="Black" Wrapping="NoWrap"
      Name="SimpleTextStyle2"></mobile:Style>
    <mobile:Style Font-Size="Small" Font-Name="Verdana" Font-Bold="True" ForeColor="Black" Wrapping="NoWrap"
      Name="QueryStyle"></mobile:Style>
    <mobile:Style Font-Size="Small" Font-Name="Tahoma" Font-Bold="False" Font-Italic="True" ForeColor="Black"
      Wrapping="NoWrap" Name="ResultsStyle"></mobile:Style>
  </mobile:stylesheet>
</body>
