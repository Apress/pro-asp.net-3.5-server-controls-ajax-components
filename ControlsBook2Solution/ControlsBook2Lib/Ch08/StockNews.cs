// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 8 - Integrating Client-Side Script
// File: StockNews.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ControlsBook2Lib.Ch08
{
  [ToolboxData("<{0}:StockNews runat=server></{0}:StockNews>"),
  DefaultProperty("Symbols")]
  public class StockNews : CompositeDataBoundControl, ICallbackEventHandler
  {
    protected DropDownList list = new DropDownList();
    protected HtmlGenericControl div;
    private List<NewsItem> items;

    [Browsable(false)]
    public virtual ListItemCollection Symbols
    {
      get
      {
        EnsureChildControls();
        return list.Items;
      }
    }

    protected override int CreateChildControls(System.Collections.IEnumerable dataSource, bool dataBinding)
    {
      int count = 0;
      if (dataSource != null)
      {
        LiteralControl txt = new LiteralControl("Stock Symbol:");
        Controls.Add(txt);

        list = new DropDownList();
        Controls.Add(list);

        div = new HtmlGenericControl("div");
        Controls.Add(div);

        if (dataBinding)
        {
          IEnumerator e = dataSource.GetEnumerator();
          while (e.MoveNext())
          {
            string symbol = e.Current.ToString();
            ListItem item = new ListItem(symbol, symbol);
            list.Items.Add(item);
            count++;

          }
        }
        else
        {
          IEnumerator e = dataSource.GetEnumerator();
          while (e.MoveNext())
          {
            ListItem item = new ListItem("", "");
            list.Items.Add(item);
            count++;
          }
        }
        CreateClientScript();
      }
      return count;
    }

    protected override void OnPreRender(EventArgs e)
    {
      base.OnPreRender(e);
      RaiseCallbackEvent(list.SelectedValue);
      div.InnerHtml = GetCallbackResult();
    }

    private void CreateClientScript()
    {
      list.Attributes.Add("onChange",
          "GetNews(this.options[this.selectedIndex].value)");

      string clientRecFunc = @"
            function LoadNews(results, context)
            {
                var newsDiv = document.getElementById('$div');
                newsDiv.innerHTML = results;
            }";
      Page.ClientScript.RegisterClientScriptBlock(this.GetType(),
          "LoadNews", clientRecFunc.Replace("$div", div.ClientID),
          true);

      string callBack = Page.ClientScript.GetCallbackEventReference(
          this, "symbol", "LoadNews", null);
      string clientCallFunc = "function GetNews(symbol){ " +
          callBack + "; }";
      Page.ClientScript.RegisterClientScriptBlock(this.GetType(),
          "GetNews", clientCallFunc, true);

    }

    public string GetCallbackResult()
    {
      StringBuilder sb = new StringBuilder();
      if (items != null)
      {
        foreach (NewsItem item in items)
        {
          sb.Append("<span><a href='");
          sb.Append(item.Link);
          sb.Append("'>");
          sb.Append(item.Title);
          sb.Append("</a><span>");
          sb.Append("<br />");
          sb.Append("<span>");
          sb.Append(item.Description);
          sb.Append("</span>");
          sb.Append("<br />");
        }
      }
      return sb.ToString();
    }

    public void RaiseCallbackEvent(string eventArgument)
    {
      items = GetNewsItems(eventArgument);
    }

    private List<NewsItem> GetNewsItems(string symbol)
    {
      List<NewsItem> Feeditems = new List<NewsItem>();
      string url = "http://moneycentral.msn.com/community/rss/generate_feed.aspx" +
          "?feedType=0&symbol=" + symbol;
      XDocument rssFeed = XDocument.Load(url);
      var posts = from item in rssFeed.Descendants("item")
                  select new
                  {
                    Title = item.Element("title").Value,
                    Description = item.Element("description").Value,
                    Link = item.Element("link").Value,
                   };

      var stockPosts = from item in posts
                     select item;

      foreach (var item in stockPosts)
      {
        Feeditems.Add(new NewsItem { Title = item.Title, Description = item.Description, Link = item.Link});
      }

      //// Create the XmlReader.
      //XmlReaderSettings settings = new XmlReaderSettings();
      //settings.IgnoreWhitespace = true;

      //XmlReader rdr = XmlReader.Create(url, settings);
      //XmlDocument stockFeed = new XmlDocument();
      //stockFeed.Load(rdr);
      //if (stockFeed.InnerXml.Length != 0)
      //{
      //  XPathNavigator navStockFeed = stockFeed.CreateNavigator();
      //  XPathExpression stockFeedXpression = navStockFeed.Compile("rss/channel/item");
      //  XPathNodeIterator iterator = navStockFeed.Select(stockFeedXpression);
      //  while (iterator.MoveNext())
      //  {
      //    NewsItem item = new NewsItem();
      //    XPathNavigator navItem = iterator.Current.Clone();
      //    if (navItem.IsNode == true)
      //    {
      //      navItem.MoveToChild("title", "");
      //      item.Title = navItem.Value;
      //      navItem.MoveToChild("description", "");
      //      item.Description = navItem.Value;
      //      navItem.MoveToChild("link", "");
      //      item.Link = navItem.Value;
      //      items.Add(item);
      //    }
      //  }
      //}
      return Feeditems;
    }
  }

  class NewsItem
  {
    public string Title;
    public string Description;
    public string Link;
  }
}