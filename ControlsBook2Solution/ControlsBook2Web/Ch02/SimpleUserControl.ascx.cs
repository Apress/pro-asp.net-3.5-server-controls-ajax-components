// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 2 - Encapsulating Functionality in ASP.NET
// File: SimpleUserControl.ascx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Drawing;

namespace ControlsBook2Web.Ch02
{
  public partial class SimpleUserControl : System.Web.UI.UserControl
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