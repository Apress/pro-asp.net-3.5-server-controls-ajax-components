<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="RichControls.aspx.cs" Inherits="ControlsBook2Web.Ch01.RichControls"
  Title="Rich Controls Demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">1</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Basics and What’s new in ASP.NET</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    Rich Controls</h3>
  <p>
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" Width="220px" ForeColor="#003399"
      Height="200px" Font-Size="8pt" Font-Names="Verdana" BorderColor="#3366CC" BorderWidth="1px"
      DayNameFormat="FirstLetter" CellPadding="1" OnSelectionChanged="Date_Selected">
      <TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
      <SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
      <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
      <DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
      <SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
      <TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
        BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
      <WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
      <OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
    </asp:Calendar>
  </p>
  <p>
    <asp:Label ID="Label1" runat="server"></asp:Label></p>
</asp:Content>
