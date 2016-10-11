// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 1 - Server Control Basics
// File: SimpleControls.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Drawing;
using System.Web.UI.WebControls;

namespace ControlsBook2Web.Ch01
{
  public partial class SimpleControls : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BuildTableButton_Click(object sender, EventArgs e)
    {
      int xDim = Convert.ToInt32(XTextBox.Text);
      int yDim = Convert.ToInt32(YTextBox.Text);
      BuildTable(xDim, yDim);
    }

    private void BuildTable(int xDim, int yDim)
    {
      Table table;
      TableRow row;
      TableCell cell;
      Literal content;

      table = new Table();
      table.BorderWidth = 1;
      table.BorderStyle = BorderStyle.Ridge;
      for (int y = 0; y < yDim; y++)
      {
        row = new TableRow();
        for (int x = 0; x < xDim; x++)
        {
          cell = new TableCell();
          cell.BackColor = Color.Blue;
          cell.BorderWidth = 1;
          cell.ForeColor = Color.Yellow;
          cell.Font.Name = "Verdana";
          cell.Font.Size = 16;
          cell.Font.Bold = true;
          cell.Font.Italic = true;

          content = new Literal();
          content.Text = "<SPAN>X:" + x.ToString() +
             "Y:" + y.ToString() + "</SPAN>";
          cell.Controls.Add(content);
          row.Cells.Add(cell);
        }
        table.Rows.Add(row);
      }
      TablePlaceHolder.Controls.Add(table);
    }
  }
}