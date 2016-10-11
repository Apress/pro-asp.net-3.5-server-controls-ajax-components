<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="DataBoundRepeater.aspx.cs" Inherits="ControlsBook2Web.Ch07.DataBoundRepeater"
  Title="DataBound Repeater Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch07" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">7</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Data Binding</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Databound Repeater Control</h3>
  <br />
  <table>
    <tbody>
      <tr valign="top">
        <td>
          <apress:Repeater ID="repeaterA" runat="server">
            <HeaderTemplate>
              <b>Array</b><br />
            </HeaderTemplate>
            <ItemTemplate>
              <%# Container.DataItem %></ItemTemplate>
            <SeparatorTemplate>
              <br />
            </SeparatorTemplate>
          </apress:Repeater>
          <br />
        </td>
        <td>
          &nbsp;&nbsp;</td>
        <td class="style1">
          <apress:Repeater ID="repeaterAl" runat="server">
            <HeaderTemplate>
              <div>
                <asp:Label ID="Label1" runat="server" BackColor="Maroon" ForeColor="White" Text="ArrayList"
                  Width="96px"></asp:Label></div>
              <br />
            </HeaderTemplate>
            <ItemTemplate>
            </ItemTemplate>
            <SeparatorTemplate>
              <br />
            </SeparatorTemplate>
            <FooterTemplate>
              <div style="color: white; height: 24px; background-color: navy">
              </div>
            </FooterTemplate>
          </apress:Repeater>
          <br />
        </td>
      </tr>
      <tr valign="top">
        <td>
          <apress:Repeater ID="repeaterRdrCust" runat="server">
            <HeaderTemplate>
              <b>Customers DataReader</b><br />
            </HeaderTemplate>
            <ItemTemplate>
              <div style="display: inline; font-weight: bold; color: yellow; background-color: red">
                <%# DataBinder.Eval(Container.DataItem,"ContactName") %></div>
            </ItemTemplate>
            <AlternatingItemTemplate>
              <div style="display: inline; font-weight: bold; color: yellow; background-color: blue">
                <%# DataBinder.Eval(Container.DataItem,"ContactName") %></div>
            </AlternatingItemTemplate>
            <SeparatorTemplate>
              <br />
            </SeparatorTemplate>
            <FooterTemplate>
              <br />
              End of the list
            </FooterTemplate>
          </apress:Repeater>
        </td>
        <td>
        </td>
        <td class="style1">
          <apress:Repeater ID="repeaterDtEmp" runat="server">
            <HeaderTemplate>
              <b>DataSet Employees DataTable</b><br />
            </HeaderTemplate>
            <ItemTemplate>
              <%# DataBinder.Eval(Container.DataItem,"FirstName") %><%# DataBinder.Eval(Container.DataItem,"LastName") %></ItemTemplate>
            <SeparatorTemplate>
              <br />
            </SeparatorTemplate>
          </apress:Repeater>
        </td>
        <td>
          <apress:Repeater ID="RepeaterDesignTime" runat="server" DataSourceID="EmployeeDataSource">
            <HeaderTemplate>
              <b>Binding to a Design-Time Data Source</b><br />
            </HeaderTemplate>
            <ItemTemplate>
              <%# DataBinder.Eval(Container.DataItem,"FirstName") %><%# DataBinder.Eval(Container.DataItem,"LastName") %></ItemTemplate>
            <SeparatorTemplate>
              <br />
            </SeparatorTemplate>
          </apress:Repeater>
        </td>
      </tr>
    </tbody>
  </table>
  <asp:Button ID="Button1" runat="server" Text="Submit"></asp:Button>&nbsp;
  <asp:SqlDataSource ID="EmployeeDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:NorthWindDB %>"
    ProviderName="<%$ ConnectionStrings:NorthWindDB.ProviderName %>" SelectCommand="SELECT [FirstName], [LastName], [Title] FROM [Employees]">
  </asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="HeadSection">
  <style type="text/css">
    .style1
    {
      width: 207px;
    }
  </style>
</asp:Content>