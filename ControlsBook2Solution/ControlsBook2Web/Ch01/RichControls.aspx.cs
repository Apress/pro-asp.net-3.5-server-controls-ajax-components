// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 1 - Server Control Basics
// File: RichControlsControls.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Web.Ch01
{
  public partial class RichControls : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Date_Selected(object sender, EventArgs e)
    {
      Label1.Text = "Selected: " + Calendar1.SelectedDate.ToLongDateString();
    }
  }
}