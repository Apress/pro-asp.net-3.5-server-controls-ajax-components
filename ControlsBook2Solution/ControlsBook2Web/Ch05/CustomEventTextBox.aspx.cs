// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 5 - Server Control Events
// File: CustomEventTextBox.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Web.Ch05
{
  public partial class CustomEventTextBox : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      BeforeLabel.Text = NameCustom.Text;
      AfterLabel.Text = NameCustom.Text;
    }

    protected void NameCustom_TextChanged(object o, ControlsBook2Lib.Ch05.TextChangedEventArgs tce)
    {
      BeforeLabel.Text = tce.OldValue;
      AfterLabel.Text = tce.NewValue;
    }
  }
}