<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="TableCustomControlDemo.aspx.cs" Inherits="ControlsBook2Web.Ch02.TableCustomControlDemo"
  Title="Table Custom Controls Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch02" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">2</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Encapsulating Functionality in ASP.NET</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Table Custom Controls</h3>
  <table>
    <tr>
      <td style="width: 50%">
        <apress:TableCustomControl ID="TableCust1" runat="server" Y="2" X="2">
        </apress:TableCustomControl>
      </td>
      <td>
        <apress:TableCompCustomControl ID="TableCompCust1" runat="server" X="2" Y="2"></apress:TableCompCustomControl>
      </td>
    </tr>
  </table>
</asp:Content>
