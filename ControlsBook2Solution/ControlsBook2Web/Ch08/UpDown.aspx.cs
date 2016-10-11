// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 8 - Integrating Client-Side Script
// File: UpDown.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Web.Ch08
{
  public partial class UpDown : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      timelabel.Text = DateTime.Now.ToString();
      changelabel.Text = "";
    }

    protected void updown1_ValueChanged(object sender, System.EventArgs e)
    {
      changelabel.Text = " UpDown value is now " + updown1.Value + "!";
    }
  }
}
