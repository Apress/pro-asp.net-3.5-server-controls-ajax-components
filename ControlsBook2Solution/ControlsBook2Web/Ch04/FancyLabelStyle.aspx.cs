// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 4 - WebControl Base Class and Control Styles
// File: FancylabelStyle.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Web.UI.HtmlControls;

namespace ControlsBook2Web.Ch04
{
  public partial class FancyLabelStyle : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      AddCssLinktoHeader();
      if (!Page.IsPostBack)
      {
        AutoLabel.Cursor = ControlsBook2Lib.Ch04.CursorStyle.auto;
        CrosshairLabel.Cursor = ControlsBook2Lib.Ch04.CursorStyle.crosshair;
        HandLabel.Cursor = ControlsBook2Lib.Ch04.CursorStyle.hand;
        HelpLabel.Cursor = ControlsBook2Lib.Ch04.CursorStyle.help;
        MoveLabel.Cursor = ControlsBook2Lib.Ch04.CursorStyle.move;
        TextLabel.Cursor = ControlsBook2Lib.Ch04.CursorStyle.text;
        WaitLabel.Cursor = ControlsBook2Lib.Ch04.CursorStyle.wait;
      }
    }

    private void AddCssLinktoHeader()
    {
      HtmlLink cssRef = new HtmlLink();
      cssRef.Href = "../Ch04/WebControlStyle.css";
      cssRef.Attributes.Add("rel", "stylesheet");
      cssRef.Attributes.Add("type", "text/css");
      Header.Controls.Add(cssRef);
    }
  }
}