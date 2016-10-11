<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
  AutoEventWireup="true" CodeBehind="HoverButton.aspx.cs" Inherits="ControlsBook2Web.Ch09.HoverButton"
  Title="HoverButton Client Control Demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadSection" runat="server">
  <style type="text/css">
    button
    {
      border: solid 1px black;
    }
    #HoverLabel
    {
      color: blue;
    }
  </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
  <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">9</asp:Label>&nbsp;&nbsp;<asp:Label
    ID="ChapterTitleLabel" runat="server" Width="360px">ASP.NET AJAX Controls and Extenders</asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PrimaryContent" runat="server">

  <script type="text/javascript">
    var app = Sys.Application;
    app.add_load(applicationLoadHandler);

    function applicationLoadHandler(sender, args) 
    {
        $create(ControlsBook2Lib.Ch09.HoverButton, 
          {text: 'A HoverButton Control',  //properties
          element: {style: {fontWeight: "bold", borderWidth: "2px"}}},  //properties (continued)
          {click: doClick, hover: doSomethingOnHover, unhover: doSomethingOnUnHover},  //events
            null, //references (none in this case)
          $get('Button1')); //element where the behavior is applied  (in this case, the HTML button Button1)
    }

    function doSomethingOnHover(sender, args) 
    {
        hoverMessage = "The mouse is over the button."
        $get('HoverLabel').innerHTML = hoverMessage;
    }

    function doSomethingOnUnHover(sender, args) 
    {
       $get('HoverLabel').innerHTML = "";
    }

    function doClick(sender, args) 
    {
       alert("The client-side JavaScript function doClick handled the HoverButton click event.");
    }
  </script>

  <br />
  <br />
  <button type="button" id="Button1">
  </button>
  &nbsp;
  <div id="HoverLabel">
  </div>
  <br />
  <br />
</asp:Content>
