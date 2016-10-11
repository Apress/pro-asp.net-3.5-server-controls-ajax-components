// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 5 - Server Control Events
// File: PagerEventBubbling.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Web.UI;

namespace ControlsBook2Web.Ch05
{
  public partial class PagerEventBubbling : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Pagers_PageCommand(object o, ControlsBook2Lib.Ch05.PageCommandEventArgs pce)
    {
      DirectionLabel.Text = ((Control)o).ID + ": " +
        Enum.GetName(typeof(ControlsBook2Lib.Ch05.PageDirection), pce.Direction);
    }
  }
}
