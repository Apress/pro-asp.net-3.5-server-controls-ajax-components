<%@ Page Language="C#" 
  MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="FancyLabelStyle.aspx.cs" 
  Inherits="ControlsBook2Web.Ch04.FancyLabelStyle"
  Title="FancyLabel Style Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch04" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">4</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">WebControl Base Class and Control Styles</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    FancyLabelStyle</h3>
  <apress:FancyLabel ID="DefaultLabel" runat="server" CssClass="grayborder" Text="No cursor set">
  </apress:FancyLabel>
  <br />
  <br />
  <apress:FancyLabel ID="AutoLabel" runat="server" CssClass="grayborder" Text="Auto cursor set">
  </apress:FancyLabel>
  <br />
  <br />
  <apress:FancyLabel ID="CrosshairLabel" runat="server" CssClass="grayborder" Text="Crosshair cursor set">
  </apress:FancyLabel>
  <br />
  <br />
  <apress:FancyLabel ID="HandLabel" runat="server" CssClass="grayborder" Text="Hand cursor set">
  </apress:FancyLabel>
  <br />
  <br />
  <apress:FancyLabel ID="HelpLabel" runat="server" CssClass="grayborder" Text="Help cursor set">
  </apress:FancyLabel>
  <br />
  <br />
  <apress:FancyLabel ID="MoveLabel" runat="server" CssClass="grayborder" Text="Move cursor set">
  </apress:FancyLabel>
  <br />
  <br />
  <apress:FancyLabel ID="TextLabel" runat="server" CssClass="grayborder" Text="Text cursort set">
  </apress:FancyLabel>
  <br />
  <br />
  <apress:FancyLabel ID="WaitLabel" runat="server" CssClass="grayborder" Text="Wait cursor set">
  </apress:FancyLabel>
  <br />
  <br />
  <asp:Button ID="Button1" runat="server" Text="Submit"></asp:Button><br />
</asp:Content>
