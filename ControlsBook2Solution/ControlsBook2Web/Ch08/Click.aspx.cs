// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 8 - Integrating Client-Side Script
// File: Click.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Web.Ch08
{
  public partial class Click : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      BottomLabel.Attributes.Add("onclick",
             "alert('BottomLabel clicked!');");
    }
  }
}
