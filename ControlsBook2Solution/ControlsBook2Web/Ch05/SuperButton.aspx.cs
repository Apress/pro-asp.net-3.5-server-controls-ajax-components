// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 5 - Server Control Events
// File: SuperButton.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Web.Ch05
{
  public partial class SuperButton : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      ClickLabel.Text = "Waiting...";
    }

    protected void superbtn_Click(object sender, EventArgs e)
    {
      ClickLabel.Text = "superbtn was clicked!";
    }

    protected void superlink_Click(object sender, EventArgs e)
    {
      ClickLabel.Text = "superlink was clicked!";
    }
  }
}
