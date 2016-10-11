<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="CustomLiveSearch.aspx.cs" Inherits="ControlsBook2Web.Ch12.CustomLiveSearch"
  Title="Custom live Search Demo" %>

<%@ Register TagPrefix="ApressLive" Namespace="ControlsBook2Lib.CH12.LiveSearchControls"
  Assembly="ControlsBook2Lib.CH12.LiveSearchControls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadSection" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">12</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Building a Complex Control</asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Ch12 Custom Live Search</h3>
  <ApressLive:Search ID="search" runat="server" ResultControl="Result" RedirectToLiveSearch="false"
    OnLiveSearchSearched="search_LiveSearchSearched" onlivesearchsearchedeventhandler="search_LiveSearchSearched">
  </ApressLive:Search>
  <br />
  <br />
  <ApressLive:Result ID="Result" runat="server" DisplayPager="true" OnItemCreated="Result_ItemCreated"
    OnLiveSearchSearched="Result_LiveSearchSearched" onlivesearchsearchedeventhandler="Result_LiveSearchSearched"
    onresultitemeventhandler="Result_ItemCreated" PagerLinkStyle="Text">
    <ItemTemplate>
      <a href="<%# ((LiveSearchService.Result)Container.DataItem).Url  %>">
        <%# ((LiveSearchService.Result)Container.DataItem).Url%>
      </a>
      <br />
      <%# ((LiveSearchService.Result)Container.DataItem).Description%>
      <br />
    </ItemTemplate>
    <ItemStyle Font-Size="X-Small" Font-Names="Arial" Font-Italic="True"></ItemStyle>
    <FooterStyle Font-Italic="True" Font-Names="Arial" Font-Size="X-Small"></FooterStyle>
    <PagerStyle Font-Bold="True" ForeColor="Red"></PagerStyle>
    <AlternatingItemStyle Font-Italic="True" Font-Names="Arial" Font-Size="X-Small" />
    <HeaderTemplate>
      Search Results
    </HeaderTemplate>
    <StatusStyle Font-Bold="True" ForeColor="#CC9900"></StatusStyle>
    <HeaderStyle Font-Names="Arial" ForeColor="#339933" />
    <AlternatingItemTemplate>
      <a href=" <%# ((LiveSearchService.Result)Container.DataItem).Url  %>">
        <%#((LiveSearchService.Result)Container.DataItem).Url %>
      </a>
      <br />
      <%# ((LiveSearchService.Result)Container.DataItem).Description%>
      <br />
    </AlternatingItemTemplate>
    <StatusTemplate>
      Displaying entries
      <%# ((Result.PageNumber - 1) * (Result.PageSize)) + 1%>
      -
      <%# Result.PageNumber * (Result.PageSize)%>
      of about
      <%# Result.TotalResultsCount%>.<br />
    </StatusTemplate>
    <SeparatorTemplate>
      <hr />
    </SeparatorTemplate>
  </ApressLive:Result>
</asp:Content>
