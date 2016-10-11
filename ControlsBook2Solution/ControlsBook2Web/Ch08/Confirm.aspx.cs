// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 8 - Integrating Client-Side Script
// File: Confirm.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Web.Ch08
{
  public partial class Confirm : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button_Click(object sender, System.EventArgs e)
    {
      status.Text = "Regular Button Clicked! - " + DateTime.Now;
    }

    protected void LinkButton_Click(object sender, System.EventArgs e)
    {
      status.Text = "LinkButton Clicked! - " + DateTime.Now;
    }

    protected void ConfirmLinkButton_ClickClick(object sender, System.EventArgs e)
    {
      status.Text = "ConfirmLinkButton Clicked! - " + DateTime.Now;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
      status.Text = "Click a button.";
    }
  }
}