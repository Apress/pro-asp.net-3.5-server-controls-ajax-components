// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 2 - Encapsulating Functionality in ASP.NET
// File: TableCompCustomControl.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Text;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch02
{
  [ToolboxData("<{0}:tablecompcustomcontrol runat=server></{0}:tablecompcustomcontrol>")]
  public class TableCompCustomControl : CompositeControl
  {
    private HtmlTable table;

    // properties to access dimensions of HTML table
    int xDim;
    public int X
    {
      get
      {
        return xDim;
      }
      set
      {
        xDim = value;
      }
    }

    int yDim;
    public int Y
    {
      get
      {
        return yDim;
      }
      set
      {
        yDim = value;
      }
    }

    public override ControlCollection Controls
    {
      get
      {
        EnsureChildControls();
        return base.Controls;
      }
    }

    protected override void CreateChildControls()
    {
      Controls.Clear();
      BuildHeader();
      BuildTable(X, Y);
    }

    private void BuildHeader()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("TableCompCustomControl<br/>");
      sb.Append("X:");
      sb.Append(X.ToString());
      sb.Append("&nbsp;");
      sb.Append("Y:");
      sb.Append(Y.ToString());
      sb.Append("&nbsp;");

      HtmlGenericControl header = new HtmlGenericControl("h3");
      header.InnerHtml = sb.ToString();
      Controls.Add(header);
    }

    private void BuildTable(int xDim, int yDim)
    {
      HtmlTableRow row;
      HtmlTableCell cell;
      HtmlGenericControl content;

      // create <table border=1>
      table = new HtmlTable();
      table.Border = 1;

      for (int y = 0; y < Y; y++)
      {
        // create <tr>
        row = new HtmlTableRow();

        for (int x = 0; x < X; x++)
        {
          // create <td cellspacing=1>
          cell = new HtmlTableCell();
          cell.Attributes.Add("border", "1");

          // create a <span>
          content = new HtmlGenericControl("span");
          content.InnerHtml = "X:" + x.ToString() +
             "Y:" + y.ToString();
          cell.Controls.Add(content);

          row.Cells.Add(cell);
        }
        table.Rows.Add(row);
      }
      Controls.Add(table);
    }
  }
}
