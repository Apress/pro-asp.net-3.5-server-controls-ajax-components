// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 9 - ASP.NET AJAX Controls and Extenders
// File: SimpleUserControlAJAX.ascx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Drawing;

namespace ControlsBook2Web.Ch09
{
  public partial class SimpleUserControlAJAX : System.Web.UI.UserControl
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public Color HeaderColor
    {
      get { return GridView1.HeaderStyle.BackColor; }
      set { GridView1.HeaderStyle.BackColor = value; }
    }

    public int RecordsPerPage
    {
      get { return GridView1.PageSize; }
      set { GridView1.PageSize = value; }
    }
  }
}