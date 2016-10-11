<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="TagParsingMenu.aspx.cs" Inherits="ControlsBook2Web.Ch06.TagParsingMenu"
  Title="Tag-Parsing Menu Controls Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch06" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">6</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Templates</asp:Label></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Tag-Parsing Menu Controls</h3>
  <div id="TagDataMenu">
    Tag Data Menu<br />
    <apress:TagDataMenu ID="TagDataMenu1" runat="server">
      <apress:MenuItemData Title="Apress" ImageUrl="" Url="http://www.apress.com" Target="">
      </apress:MenuItemData>
      <apress:MenuItemData Title="Microsoft" ImageUrl="" Url="http://www.microsoft.com"
        Target=""></apress:MenuItemData>
      <apress:MenuItemData Title="MSDN" ImageUrl="" Url="http://msdn.microsoft.com" Target="">
      </apress:MenuItemData>
    </apress:TagDataMenu>
  </div>
  <br />
  <div id="Builder Menu">
    Builder Menu<br />
    <apress:BuilderMenu ID="BuilderMenu1" runat="server">   
      <data title="Apress" url="http://www.apress.com" imageurl="" target="" />
      <data title="Microsoft" url="http://www.microsoft.com" imageurl="" target="" />
      <data title="MSDN" url="http://msdn.microsoft.com" imageurl="" target="" />
    </apress:BuilderMenu>
  </div>
  <br />
</asp:Content>