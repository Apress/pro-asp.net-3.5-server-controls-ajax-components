// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 8 - Integrating Client-Side Script
// File: ControlCallback.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Web.Ch08
{
  public partial class ControlCallback : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!Page.IsPostBack)
      {
        LoadSymbols();
      }
    }

    private void LoadSymbols()
    {
      stockNews.DataSource = new string[] { "MSFT", "IBM", "GOOG", "ORCL" };
      stockNews.DataBind();
    }
  }
}
