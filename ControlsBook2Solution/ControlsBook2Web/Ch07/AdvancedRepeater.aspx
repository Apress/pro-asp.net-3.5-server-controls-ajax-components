<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="AdvancedRepeater.aspx.cs" Inherits="ControlsBook2Web.Ch07.AdvancedRepeater"
  Title="Advanced Repeater Control Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch07" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">7</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Data Binding</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Ch07 Advanced Repeater Control</h3>
  <b>
    <asp:Label ID="status" runat="server" BackColor="#FFC080"></asp:Label><br />
  </b>
  <br />
  <apress:Repeater ID="repeaterRdrCust" runat="server" OnItemCommand="repeaterRdrCust_ItemCommand"
    OnItemDataBound="repeaterRdrCust_ItemDataBound" OnItemCreated="repeaterRdrCust_ItemCreated">
    <ItemTemplate>
      <%# DataBinder.Eval(Container.DataItem,"ContactName") %>
      <asp:Button ID="contact1" runat="server"></asp:Button>
    </ItemTemplate>
    <SeparatorTemplate>
      <br />
    </SeparatorTemplate>
  </apress:Repeater>
</asp:Content>
