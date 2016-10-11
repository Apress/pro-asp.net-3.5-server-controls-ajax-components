// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 1 - Server Control Basics
// File: ValidationControls.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Web.Ch01
{
  public partial class ValidationControls : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ValidateButton_Click(object sender, EventArgs e)
    {
      ResultsLabel.Text = "Page submitted at " + DateTime.Now + " IsValid: " + Page.IsValid;
    }

    protected void ValidateEvent(object source, ServerValidateEventArgs args)
    {
      if ((Convert.ToInt32(args.Value) % 2) == 0)
        args.IsValid = true;
      else
        args.IsValid = false;
    }
  }
}
