<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="ListControls.aspx.cs" Inherits="ControlsBook2Web.Ch01.ListControls"
  Title="List Controls Demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">1</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Basics and What’s new in ASP.NET</asp:Label>
  --&gt;
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    List Controls</h3>
  <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ApressBooksds">
    <HeaderTemplate>
      <table>
        <th>
          Title</th>
        <th>
          Author</th>
        <th>
          ISBN</th>
        <th>
          Date Published</th>
    </HeaderTemplate>
    <ItemTemplate>
      <tr style="background-color: Silver">
        <td>
          <%# DataBinder.Eval(Container.DataItem,"Title") %></td>
        <td>
          <%# DataBinder.Eval(Container.DataItem,"Author") %></td>
        <td>
          <%# DataBinder.Eval(Container.DataItem,"ISBN") %></td>
        <td>
          <%# DataBinder.Eval(Container.DataItem,"DatePublished") %></td>
      </tr>
    </ItemTemplate>
    <AlternatingItemTemplate>
      <tr style="background-color: White">
        <td>
          <%# DataBinder.Eval(Container.DataItem,"Title") %></td>
        <td>
          <%# DataBinder.Eval(Container.DataItem,"Author") %></td>
        <td>
          <%# DataBinder.Eval(Container.DataItem,"ISBN") %></td>
        <td>
          <%# DataBinder.Eval(Container.DataItem,"DatePublished") %></td>
      </tr>
    </AlternatingItemTemplate>
    <FooterTemplate>
      </table>
    </FooterTemplate>
  </asp:Repeater>
  <asp:AccessDataSource ID="ApressBooksds" runat="server" DataFile="~/App_Data/ApressBooks.mdb"
    SelectCommand="SELECT [Title], [Author], [ISBN], [DatePublished] FROM [Books]"></asp:AccessDataSource>
  <br />
</asp:Content>