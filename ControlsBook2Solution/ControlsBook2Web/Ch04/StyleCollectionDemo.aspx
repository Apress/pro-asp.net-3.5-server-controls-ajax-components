<%@ Page Language="C#" 
  MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="StyleCollectionDemo.aspx.cs" 
  Inherits="ControlsBook2Web.Ch04.StyleCollectionDemo"
  Title="StyleCollection Demo Web Form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">4</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">WebControl Base Class and Control Styles</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Style Collection Demo</h3>
  <asp:Menu ID="MainMenuID" Font-Names="Arial" ForeColor="Blue" runat="server" Orientation="Horizontal">
    <LevelMenuItemStyles>
      <asp:MenuItemStyle BackColor="Beige" Font-Italic="True" Font-Names="Verdana" ForeColor="Green"
        Font-Underline="False" />
      <asp:MenuItemStyle BackColor="Black" Font-Italic="False" Font-Names="Tahoma" ForeColor="Orange"
        Font-Underline="False" />
      <asp:MenuItemStyle BackColor="Green" Font-Italic="True" Font-Names="Arial" ForeColor="Red"
        Font-Underline="False" />
    </LevelMenuItemStyles>
    <Items>
      <asp:MenuItem Text="File" ToolTip="File" Value="File">
        <asp:MenuItem Text="New" ToolTip="New" Value="New">
          <asp:MenuItem Text="Project" ToolTip="Project" Value="Project" />
          <asp:MenuItem Text="Web Site" ToolTip="Web Site" Value="Web Site" />
          <asp:MenuItem Text="File" ToolTip="File" Value="File" />
        </asp:MenuItem>
        <asp:MenuItem Text="Open" ToolTip="Open" Value="Open">
          <asp:MenuItem Text="Project" ToolTip="Project" Value="Project" />
          <asp:MenuItem Text="Web Site" ToolTip="Web Site" Value="Web Site" />
          <asp:MenuItem Text="File" ToolTip="File" Value="File" />
        </asp:MenuItem>
      </asp:MenuItem>
      <asp:MenuItem Text="Edit" ToolTip="Edit" Value="Edit">
        <asp:MenuItem Text="Find and Replace" ToolTip="Find and Replace" Value="Find and Replace">
          <asp:MenuItem Text="Quick Find" ToolTip="Quick Find" Value="Quick Find" />
          <asp:MenuItem Text="Quick Replace" ToolTip="Quick Replace" Value="Quick Replace" />
          <asp:MenuItem Text="Find in Files" ToolTip="Find in Files" Value="Find in Files" />
        </asp:MenuItem>
        <asp:MenuItem Text="Advanced" ToolTip="Advanced" Value="Advanced">
          <asp:MenuItem Text="Format Document" ToolTip="Format Document" Value="Format Document" />
          <asp:MenuItem Text="Make Uppercase" ToolTip="Make Uppercase" Value="Make Uppercase" />
          <asp:MenuItem Text="Make Lowercase" ToolTip="Make Lowercase" Value="Make Lowercase" />
        </asp:MenuItem>
      </asp:MenuItem>
    </Items>
  </asp:Menu>
  <br />
</asp:Content>