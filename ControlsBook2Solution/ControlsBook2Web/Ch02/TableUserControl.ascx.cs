// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 2 - Encapsulating Functionality in ASP.NET
// File: TableUserControl.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Web.UI.HtmlControls;

namespace ControlsBook2Web.Ch02
{
  public partial class TableUserControl : System.Web.UI.UserControl
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      XLabel.Text = X.ToString();
      YLabel.Text = Y.ToString();

      BuildTable(X, Y);
    }

    // Properties to access dimensions of HTML table
    //using new syntax in C# 3.0
    public int X {get; set;}
    public int Y {get; set;}
    
    // HTML table building routine
    private void BuildTable(int xDim, int yDim)
    {
      HtmlTableRow row;
      HtmlTableCell cell;
      HtmlGenericControl content;

      for (int y = 0; y < yDim; y++)
      {
        // create <TR>
        row = new HtmlTableRow();

        for (int x = 0; x < xDim; x++)
        {
          // create <TD cellspacing=1>
          cell = new HtmlTableCell();
          cell.Attributes.Add("border", "1");

          // create a <SPAN>
          content = new HtmlGenericControl("SPAN");
          content.InnerHtml = "X:" + x.ToString() +
             "Y:" + y.ToString();
          cell.Controls.Add(content);

          row.Cells.Add(cell);
        }
        Table1.Rows.Add(row);
      }
    }
  }
}