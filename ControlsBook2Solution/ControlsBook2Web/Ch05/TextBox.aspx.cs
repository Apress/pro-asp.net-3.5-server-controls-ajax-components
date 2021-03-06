﻿// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 5 - Server Control Events
// File: TextBox.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Web.Ch05
{
  public partial class TextBox : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      ChangeLabel.Text = DateTime.Now.ToLongTimeString() + ": No change.";
    }

    protected void NameTextBox_TextChanged(object sender, EventArgs e)
    {
      ChangeLabel.Text = DateTime.Now.ToLongTimeString() + ": Changed!";
    }
  }
}
