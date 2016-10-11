// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 3 - ASP.NET State Management
// File: LabelControls.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Web.Ch03
{
  public partial class LabelControls : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SetLabelButton_Click(object sender, EventArgs e)
    {
      StatelessLabel1.Text = "Set by " + NameTextBox.Text;
      StatefulLabel1.Text = "Set by " + NameTextBox.Text;
    }
  }
}
