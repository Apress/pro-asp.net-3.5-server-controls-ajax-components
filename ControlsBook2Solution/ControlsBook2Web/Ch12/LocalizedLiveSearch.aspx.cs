// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: LocalizedLiveSearch.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Threading;

namespace ControlsBook2Web.Ch12
{
  public partial class LocalizedLiveSearch : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      CultureLabel.Text = Thread.CurrentThread.CurrentCulture.DisplayName;
      DateTimeLabel.Text = DateTime.Now.ToLongDateString();
    }
  }
}
