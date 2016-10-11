<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="ValidationControls.aspx.cs" Inherits="ControlsBook2Web.Ch01.ValidationControls"
  Title="Validation Controls Demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">1</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">Server Control Basics and What’s new in ASP.NET</asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrimaryContent" runat="server">

  <script type="text/javascript">
    function ValidateEvent(oSrc, args){
      args.IsValid = ((args.Value % 2) == 0);
    }
  </script>

  <asp:Label ID="Label1" runat="server"> RequiredField</asp:Label><br />
  <asp:TextBox ID="RequiredField" runat="server"></asp:TextBox>
  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredField needs an input value!"
    ControlToValidate="RequiredField"></asp:RequiredFieldValidator><br />
  <asp:Label ID="Label2" runat="server"> ComparedField</asp:Label><br />
  <asp:TextBox ID="ComparedField" runat="server"></asp:TextBox>
  <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="RequiredField and ComparedField are not equal!"
    ControlToValidate="ComparedField" ControlToCompare="RequiredField"></asp:CompareValidator><br />
  <asp:Label ID="Label3" runat="server"> RangeField</asp:Label><br />
  <asp:TextBox ID="RangeField" runat="server"></asp:TextBox>
  <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeField value must be between 1-10!"
    ControlToValidate="RangeField" MaximumValue="10" MinimumValue="1" Type="Integer"></asp:RangeValidator><br />
  <asp:Label ID="Label4" runat="server"> RegexField (Phone)</asp:Label><br />
  <asp:TextBox ID="RegexField" runat="server"></asp:TextBox>
  <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegexField must be a valid US phone number!"
    ControlToValidate="RegexField" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator><br />
  <asp:Label ID="Label5" runat="server">CustomField (Even Number)</asp:Label><br />
  <asp:TextBox ID="CustomField" runat="server"></asp:TextBox>
  <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomField must be an even number!"
    ControlToValidate="CustomField" ClientValidationFunction="ValidateEvent" OnServerValidate="ValidateEvent"></asp:CustomValidator><br />
  <br />
  <asp:Button ID="ValidateButton" runat="server" Text="Submit" OnClick="ValidateButton_Click">
  </asp:Button><br />
  <asp:Label ID="ResultsLabel" runat="server"></asp:Label><br />
  <br />
  <asp:ValidationSummary ID="ValidationSummary1" runat="server"></asp:ValidationSummary>
</asp:Content>
