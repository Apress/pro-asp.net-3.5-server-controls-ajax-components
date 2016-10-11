<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="Callback.aspx.cs" Inherits="ControlsBook2Web.Ch08.Callback"
  Title="Callback Demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">8</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Integrating Client-Side Script</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Ch08 Client Side Callback</h3>
  <h4>
    Current Time:
    <%= DateTime.Now %>
  </h4>
  <h4>
    AutoPostBack ListBox</h4>
  <table>
    <tr valign="top">
      <td>
        <asp:DropDownList ID="CategoryDrp" runat="server" AutoPostBack="true" OnSelectedIndexChanged="CategoryDrp_SelectedIndexChanged">
          <asp:ListItem Selected="true">Car</asp:ListItem>
          <asp:ListItem>Truck</asp:ListItem>
          <asp:ListItem>SUV</asp:ListItem>
        </asp:DropDownList>
      </td>
      <td>
        <asp:ListBox ID="VehicleLst" Width="200" runat="server" DataTextField="Description"
          DataValueField="Name"></asp:ListBox>
      </td>
    </tr>
  </table>
  <h4>
    Client Side Callback ListBox</h4>
  <table>
    <tr valign="top">
      <td>
        <asp:DropDownList ID="CbCategoryDrp" runat="server">
          <asp:ListItem Selected="true">Car</asp:ListItem>
          <asp:ListItem>Truck</asp:ListItem>
          <asp:ListItem>SUV</asp:ListItem>
        </asp:DropDownList>
      </td>
      <td>
        <asp:ListBox ID="CbVehicleLst" Width="200" runat="server" DataTextField="Description"
          DataValueField="Name"></asp:ListBox>
      </td>
    </tr>
  </table>
  <br />
</asp:Content>
