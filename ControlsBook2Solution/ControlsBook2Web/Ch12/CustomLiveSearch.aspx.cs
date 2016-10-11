// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: CustomLiveSearch.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Web.UI;
using ControlsBook2Lib.CH12.LiveSearchControls;

namespace ControlsBook2Web.Ch12
{
  public partial class CustomLiveSearch : System.Web.UI.Page
  {
    private int resultIndex;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void search_LiveSearchSearched(object sender, LiveSearchSearchedEventArgs lse)
    {
      resultIndex = lse.Result.Responses[0].Offset;
    }

    protected void Result_LiveSearchSearched(object sender, LiveSearchSearchedEventArgs lse)
    {
      resultIndex = lse.Result.Responses[0].Offset;
    }

    protected void Result_ItemCreated(object sender, ResultItemEventArgs e)
    {
      ResultItem item = e.Item;
      if (item.ItemType == ResultItemType.Item ||
         item.ItemType == ResultItemType.AlternatingItem)
      {
        item.Controls.AddAt(0, new LiteralControl
        ((((Result.PageNumber - 1) * Result.PageSize) + item.ItemIndex + 1).ToString() + "."));
        resultIndex++;
      }
    }
  }
}