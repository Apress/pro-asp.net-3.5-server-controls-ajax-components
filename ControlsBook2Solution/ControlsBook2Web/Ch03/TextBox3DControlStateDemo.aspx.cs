// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 3 - ASP.NET State Management
// File: TextBox3DControlStateDemo.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Web.Ch03
{
  public partial class TextBox3DControlStateDemo : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      LabelViewState.Text = "ViewState Enabled = " + Textbox3CtrlState.EnableViewState.ToString();
    }

    protected void buttonToggle3d_Click(object sender, EventArgs e)
    {
      Textbox3CtrlState.Enable3D = !Textbox3CtrlState.Enable3D;
      TextBox3dBasic.Enable3D = !TextBox3dBasic.Enable3D;
    }
  }
}