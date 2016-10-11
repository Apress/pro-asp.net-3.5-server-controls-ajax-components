// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: Pager.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.

using System.Resources;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.CH12.LiveSearchControls
{
  /// <summary>
  /// Pager control implements the paging functionality aggregated
  /// by the Result control
  /// </summary>
  internal class Pager : CompositeControl
  {
    private Table table;
    private ResultPagerLinkStyle pagerLinkStyle;
    private int pagerBarRange;
    private int pageSize;
    private int totalResultsCount;
    private int pageNumber;

    /// <summary>
    /// Pager is based on span tag
    /// </summary>
    protected override HtmlTextWriterTag TagKey
    {
      get
      {
        return HtmlTextWriterTag.Span;
      }
    }

    /// <summary>
    /// Number of search results returned with query and displayed on page.
    /// </summary>
    public int PageSize
    {
      get
      {
        return pageSize;
      }
      set
      {
        pageSize = value;
      }
    }

    /// <summary>
    /// Number of pages displayed in pager bar.
    /// </summary>
    public int PagerBarRange
    {
      get
      {
        return pagerBarRange;
      }
      set
      {
        pagerBarRange = value;
      }
    }

    /// <summary>
    /// Style of Pager control link display.
    /// </summary>
    public ResultPagerLinkStyle PagerLinkStyle
    {
      get
      {
        return pagerLinkStyle;
      }
      set
      {
        pagerLinkStyle = value;
      }
    }

    ///<summary>
    /// Current Page of search results.
    ///</summary>
    public int PageNumber
    {
      get
      {
        return pageNumber;
      }
      set
      {
        pageNumber = value;
      }
    }

    /// <summary>
    /// Estimated total results count from query.
    /// </summary>
    public int TotalResultsCount
    {
      get
      {
        return totalResultsCount;
      }
      set
      {
        totalResultsCount = value;
      }
    }

    private void CreatePagerResults(TableRow textRow,
       ResultPagerLinkStyle style)
    {
      TableCell cell;

      cell = new TableCell();

      ResourceManager rm = ResourceFactory.Manager;

      cell.Text = rm.GetString("Pager.resultsPageCell.Text");
      cell.Wrap = false;
      cell.HorizontalAlign = HorizontalAlign.Center;
      textRow.Cells.Add(cell);
    }

    //Pass in style to permit extension based on style setting
    private void CreatePagerPreviousButton(TableRow textRow,
       ResultPagerLinkStyle style, int prevIndex)
    {
      TableCell cell;

      ResourceManager rm = ResourceFactory.Manager;

      cell = new TableCell();
      LinkButton prevButton = new LinkButton();
      prevButton.ID = "PrevButton";
      prevButton.Text = rm.GetString("Pager.prevButton.Text");
      prevButton.CommandName = "Page";
      prevButton.CommandArgument = prevIndex.ToString();
      cell.HorizontalAlign = HorizontalAlign.Right;
      cell.Controls.Add(prevButton);

      textRow.Cells.Add(cell);
    }

    private void CreatePagerPageButton(TableRow textRow,
       ResultPagerLinkStyle style, int pageNum, bool currentPage)
    {
      TableCell cell;
      LiteralControl lit;

      cell = new TableCell();
      cell.HorizontalAlign = HorizontalAlign.Center;

      // add extra separation between page numbers
      // if text only paging is used
      if (style == ResultPagerLinkStyle.Text)
      {
        lit = new LiteralControl();
        lit.Text = "&nbsp;";
        cell.Controls.Add(lit);
      }
      //For TextWithDHTML functionality, you can create a 
      //HighlightedLinkButton class similar to the 
      //HighlightedHyperlink created in chapter 9
      //and render that instead of the basic LinkButton
      //based on the configured ResultPagerLinkStyle
      LinkButton pageButton = new LinkButton();
      pageButton.ID = "page" + pageNum.ToString() + "Button";
      pageButton.Text = pageNum.ToString();
      pageButton.CommandName = "Page";
      pageButton.CommandArgument = pageNum.ToString();
      pageButton.CausesValidation = true;
      if (currentPage == true)
        pageButton.ControlStyle.Font.Bold = true;

      cell.Controls.Add(pageButton);
      textRow.Cells.Add(cell);
    }

    private void CreatePagerNextButton(TableRow textRow,
       ResultPagerLinkStyle style, int nextIndex)
    {
      TableCell cell = new TableCell();
      LiteralControl lit;

      cell = new TableCell();

      // add extra separation between page numbers
      // if text only paging is used
      if (style == ResultPagerLinkStyle.Text)
      {
        lit = new LiteralControl();
        lit.Text = "&nbsp;";
        cell.Controls.Add(lit);
      }

      ResourceManager rm = ResourceFactory.Manager;

      LinkButton nextButton = new LinkButton();
      nextButton.ID = "nextButton";
      nextButton.Text = rm.GetString("Pager.nextButton.Text");
      nextButton.CommandName = "Page";
      nextButton.CommandArgument = nextIndex.ToString();
      cell.HorizontalAlign = HorizontalAlign.Center;
      cell.Controls.Add(nextButton);

      textRow.Cells.Add(cell);
    }

    private void CreateControlHierarchy()
    {
      table = new Table();

      TableRow textRow = new TableRow();
      textRow.VerticalAlign = VerticalAlign.Top;

      // insert localized "Page Results:" text
      CreatePagerResults(textRow, PagerLinkStyle);

      // if the page number greater than 1 you can put in a previous page
      // link
      if (PageNumber > 1)
      {
        // insert Previous text
        CreatePagerPreviousButton(textRow, PagerLinkStyle, PageNumber - 1);
      }

      int endPage = 0;
      int calculatedEndPage = (int)System.Math.Floor((double)TotalResultsCount / PageSize);
      if ((calculatedEndPage - PageNumber) > PagerBarRange)
        endPage = PageNumber + PagerBarRange - 1;
      else
        endPage = calculatedEndPage;
      // loop through each page and spit out the page link
      for (int pageNum = PageNumber; pageNum <= endPage; pageNum++)
      {

        // insert Page number text
        CreatePagerPageButton(textRow, PagerLinkStyle,
           pageNum,(PageNumber == pageNum));
      }

      // insert a next link if less than max number of pages
      if (calculatedEndPage > endPage)
      {
        // Insert Next text
        CreatePagerNextButton(textRow, PagerLinkStyle, PageNumber + 1);
      }

      // always display text links
      table.Rows.Add(textRow);

      Controls.Add(table);
    }

    /// <summary>
    /// Called by framework for composite controls to create control heirarchy
    /// </summary>
    override protected void CreateChildControls()
    {
      Controls.Clear();
      CreateControlHierarchy();
    }

    /// <summary>
    /// Overridden to ensure Controls collection is created before external access
    /// </summary>
    public override ControlCollection Controls
    {
      get
      {
        EnsureChildControls();
        return base.Controls;
      }
    }

    protected void PrepareControlHierarchy()
    {
      // apply the Pager style attributes to the
      // table if they were specified by Result control
      if (this.ControlStyleCreated)
        table.ApplyStyle(this.ControlStyle);
    }

    /// <summary>
    /// Overridden to ensure styles are properly applied
    /// </summary>
    protected override void RenderContents(HtmlTextWriter writer)
    {
      EnsureChildControls();

      PrepareControlHierarchy();

      base.RenderContents(writer);
    }
  }
}