// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: ResultItemTemplate.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.

using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.CH12.LiveSearchControls
{
  /// <summary>
  ///		Default ResultItemTemplate implementation used by a 
  ///		stock LiveSearch Lib Result control without a ItemTemplate
  /// </summary>
  public class ResultItemTemplate : ITemplate
  {
    /// <summary>
    /// Method puts template controls into container control
    /// </summary>
    /// <param name="container">Outside control container to template items</param>
    public void InstantiateIn(Control container)
    {
      HyperLink link = new HyperLink();
      link.DataBinding += new EventHandler(BindLink);
      container.Controls.Add(link);
      container.Controls.Add(new LiteralControl("<br>"));

      Label snippet = new Label();
      snippet.DataBinding += new EventHandler(BindSnippet);
      container.Controls.Add(snippet);
      container.Controls.Add(new LiteralControl("<br>"));

      Label url = new Label();
      url.DataBinding += new EventHandler(BindUrl);
      container.Controls.Add(url);
      container.Controls.Add(new LiteralControl("<br>"));
      container.Controls.Add(new LiteralControl("<br>"));
    }

    private LiveSearchService.Result GetResultElement(Control container)
    {
      ResultItem item = (ResultItem)container;
      return (LiveSearchService.Result)item.DataItem;
    }

    private void BindLink(object source, EventArgs e)
    {
      HyperLink link = (HyperLink)source;
      LiveSearchService.Result elem = GetResultElement(link.NamingContainer);
      link.Text = elem.Title;
      link.NavigateUrl = elem.Url;
    }

    private void BindSnippet(object source, EventArgs e)
    {
      Label snippet = (Label)source;
      LiveSearchService.Result elem = GetResultElement(snippet.NamingContainer);
      snippet.Text = elem.Description;
    }

    private void BindUrl(object source, EventArgs e)
    {
      Label url = (Label)source;
      LiveSearchService.Result elem = GetResultElement(url.NamingContainer);
      url.Text = elem.Url;
    }
  }
}