// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 2 - Encapsulating Functionality in ASP.NET
// File: TableCustomControlDemo.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Web.Ch02
{
  public partial class TableCustomControlDemo : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!Page.IsPostBack)
      {
        TableCust1.X = 3;
        TableCust1.Y = 3;
        TableCompCust1.X = 3;
        TableCompCust1.Y = 3;
      }
    }
  }
}
