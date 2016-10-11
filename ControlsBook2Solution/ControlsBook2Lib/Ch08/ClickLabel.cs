// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 8 - Integrating Client-Side Script
// File: ClickLabel.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch08
{
  [ToolboxData("<{0}:ClickLabel runat=server></{0}:ClickLabel>"),
  DefaultProperty("ClickText")]
  public class ClickLabel : Label
  {
    public virtual string ClickText
    {
      get
      {
        return (string)ViewState["ClickText"];
      }
      set
      {
        ViewState["ClickText"] = value;
      }
    }

    protected override void OnPreRender(EventArgs e)
    {
      base.OnPreRender(e);

      // Add the onclick client-side event handler to
      // display a JavaScript alert box
      Attributes.Add("onclick", "alert('" + ClickText + "');");
    }
  }
}
