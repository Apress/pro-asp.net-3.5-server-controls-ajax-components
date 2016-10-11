// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: ResultStatusTemplate.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.

using System;
using System.Resources;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.CH12.LiveSearchControls
{
  /// <summary>
  ///		Default StatusTemplate implementation used by a 
  ///		stock Live Result control without a StatusTemplate
  /// </summary>
  public class ResultStatusTemplate : ITemplate
  {
    /// <summary>
    /// Method puts template controls into container control
    /// </summary>
    /// <param name="container">Outside control container to template items</param>
    public void InstantiateIn(Control container)
    {
      Label header = new Label();
      header.DataBinding += new EventHandler(BindResultHeader);
      container.Controls.Add(header);
      LiteralControl lit = new LiteralControl();
      lit.Text = "<br>";
      container.Controls.Add(lit);
    }

    private Result GetResultControl(Control container)
    {
      ResultItem itemControl = (ResultItem)container.Parent;
      Result resultControl = (Result)itemControl.Parent;
      return resultControl;
    }

    private void BindResultHeader(object source, EventArgs e)
    {
      Label header = (Label)source;
      Result resultControl = GetResultControl(header);

      StringBuilder section = new StringBuilder();

      // get ResouceManager for localized format strings
      ResourceManager rm = ResourceFactory.Manager;

      // Searched for: <searchQuery>
      section.Append(
      String.Format(
         rm.GetString("ResultStatusTemplate.SearchFor"),
         resultControl.Query));
      section.Append("<br>");

      // Result <StartIndex+1> - <EndIndex+1> of about 
      // <TotalResultsCount> records
      // (accounting for zero based index)
      section.Append(
      String.Format(
         rm.GetString("ResultStatusTemplate.ResultAbout"),
      ((resultControl.PageNumber - 1) * (resultControl.PageSize)) + 1,
      resultControl.PageNumber * (resultControl.PageSize),
      resultControl.TotalResultsCount));
      section.Append("&nbsp&nbsp");

      header.Text = section.ToString();
    }
  }
}