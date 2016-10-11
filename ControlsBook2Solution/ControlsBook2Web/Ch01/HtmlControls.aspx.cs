// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 1 - Server Control Basics
// File: HtmlControls.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Web.UI.HtmlControls;

namespace ControlsBook2Web.Ch01
{
  public partial class HtmlControls : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BuildTableButton_ServerClick(object sender, EventArgs e)
    {
      int xDim = Convert.ToInt32(XTextBox.Value);
      int yDim = Convert.ToInt32(YTextBox.Value);
      BuildTable(xDim, yDim);
    }

    private void BuildTable(int xDim, int yDim)
    {
      HtmlTable table;
      HtmlTableRow row;
      HtmlTableCell cell;
      HtmlGenericControl content;

      table = new HtmlTable();
      table.Border = 1;
      for (int y = 0; y < yDim; y++)
      {
        row = new HtmlTableRow();
        for (int x = 0; x < xDim; x++)
        {
          cell = new HtmlTableCell();
          cell.Style.Add("font", "16pt verdana bold italic");
          cell.Style.Add("background-color", "red");
          cell.Style.Add("color", "yellow");

          content = new HtmlGenericControl("SPAN");
          content.InnerHtml = "X:" + x.ToString() +
             "Y:" + y.ToString();
          cell.Controls.Add(content);
          row.Cells.Add(cell);
        }
        table.Rows.Add(row);
      }
      Span1.Controls.Add(table);
    }
  }
}