// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 1 - Server Control Basics
// File: XMLControl.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Data;
using System.Web.UI;

namespace ControlsBook2Web.Ch01
{
  public partial class XMLControls : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!Page.IsPostBack)
      {
        LoadXMLControl();
      }
    }

    private void LoadXMLControl()
    {
      //Create a DataView from the AccessDataSource control
      DataView dv = (DataView)ApressBooksds.Select(new DataSourceSelectArguments());
      try
      {
        dv.Table.TableName = "Books";
        DataSet ds = dv.Table.DataSet;
        ds.DataSetName = "ApressBooks";

        // give the XML control the XML and xslt
        Xml1.DocumentContent = ds.GetXml();
        Xml1.TransformSource = "ApressBooks.xslt";
      }
      finally
      {
        dv.Dispose();
      }
    }
  }
}