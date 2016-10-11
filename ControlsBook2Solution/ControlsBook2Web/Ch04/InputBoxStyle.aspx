<%@ Page Language="C#" 
  MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="InputBoxStyle.aspx.cs" 
  Inherits="ControlsBook2Web.Ch04.InputBoxStyle"
  Title="InputBox Style Web Form Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch04" Assembly="ControlsBook2Lib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">4</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">WebControl Base Class and Control Styles</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">
  <h3>
    InputBox Style</h3>
  <apress:InputBox ID="NameInputBox" runat="server" LabelText="Enter your name: " TextboxText="blank"
    Font-Names="Courier New" ForeColor="Red" Font-Italic="True"></apress:InputBox>
  <br />
  <br />
  <table>
    <tr>
      <td>
        <span style="font-weight: bold">Label Style</span><br />
        <asp:RadioButtonList ID="LabelActionList" RepeatColumns="3" runat="server">
          <asp:ListItem Value="Off" Selected="True">Off</asp:ListItem>
          <asp:ListItem Value="Apply">Apply</asp:ListItem>
        </asp:RadioButtonList><br />
        Font-Name:
        <asp:DropDownList ID="LabelFontDropDownList" runat="server">
          <asp:ListItem Value="Arial">Arial</asp:ListItem>
          <asp:ListItem Value="Courier New">Courier New</asp:ListItem>
          <asp:ListItem Value="Times New Roman">Times New Roman</asp:ListItem>
          <asp:ListItem Value="Monotype Corsiva">Monotype Corsiva</asp:ListItem>
        </asp:DropDownList><br />
        ForeColor:
        <asp:DropDownList ID="LabelForeColorDropDownList" runat="server">
          <asp:ListItem Value="Blue">Blue</asp:ListItem>
          <asp:ListItem Value="Red">Red</asp:ListItem>
          <asp:ListItem Value="Black">Black</asp:ListItem>
        </asp:DropDownList><br />
        <asp:CheckBox ID="LabelBoldCheckbox" runat="server" Text="Bold: " TextAlign="Left">
        </asp:CheckBox><br />
        <asp:CheckBox ID="LabelItalicCheckbox" runat="server" Text="Italic: " TextAlign="Left">
        </asp:CheckBox><br />
      </td>
      <td>
        <span style="font-weight: bold">Textbox Style</span><br />
        <asp:RadioButtonList ID="TextboxActionList" RepeatColumns="3" runat="server">
          <asp:ListItem Value="Off" Selected="True">Off</asp:ListItem>
          <asp:ListItem Value="Apply">Apply</asp:ListItem>
        </asp:RadioButtonList><br />
        Font-Name:
        <asp:DropDownList ID="TextboxFontDropDownList" runat="server">
          <asp:ListItem Value="Arial">Arial</asp:ListItem>
          <asp:ListItem Value="Courier New">Courier New</asp:ListItem>
          <asp:ListItem Value="Times New Roman">Times New Roman</asp:ListItem>
          <asp:ListItem Value="Monotype Corsiva">Monotype Corsiva</asp:ListItem>
        </asp:DropDownList><br />
        ForeColor:
        <asp:DropDownList ID="TextboxForeColorDropDownList" runat="server">
          <asp:ListItem Value="Blue">Blue</asp:ListItem>
          <asp:ListItem Value="Red">Red</asp:ListItem>
          <asp:ListItem Value="Black">Black</asp:ListItem>
        </asp:DropDownList><br />
        <asp:CheckBox ID="TextboxBoldCheckbox" runat="server" Text="Bold: " TextAlign="Left">
        </asp:CheckBox><br />
        <asp:CheckBox ID="TextboxItalicCheckbox" runat="server" Text="Italic: " TextAlign="Left">
        </asp:CheckBox><br />
      </td>
    </tr>
  </table>
  <br />
  <br />
  <asp:Button ID="SetStyleButton" runat="server" Text="Set Style" Height="23px" Width="83px"
    OnClick="SetStyleButton_Click"></asp:Button>&nbsp;
  <asp:Button ID="SubmitPageButton" runat="server" Text="Submit Page"></asp:Button><br />
  <br />
</asp:Content>
