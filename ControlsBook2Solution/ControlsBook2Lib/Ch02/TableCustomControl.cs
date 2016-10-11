// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 2 - Encapsulating Functionality in ASP.NET
// File: TableCustomControl.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Web.UI;

namespace ControlsBook2Lib.Ch02
{
  [ToolboxData("<{0}:tablecustomcontrol runat=server></{0}:tablecustomcontrol>")]
  public class TableCustomControl : Control
  {
    // Properties to access dimensions of HTML table
    // New property declaration syntax in C# 3.0
    public int X { get; set; } 
    public int Y { get; set; }

    protected override void Render(HtmlTextWriter writer)
    {
      base.Render(writer);

      RenderHeader(writer);
      RenderTable(writer, X, Y);
    }

    private void RenderHeader(HtmlTextWriter writer)
    {
      // write just <H3
      writer.WriteBeginTag("h3");
      // write >
      writer.Write(HtmlTextWriter.TagRightChar);
      writer.Write("TableCustomControl");
      // write <br/>
      writer.WriteFullBeginTag("br");
      writer.Write("X:" + X.ToString() + "&nbsp;");
      writer.WriteLine("Y:" + Y.ToString() + "&nbsp;");
      // write </h3>
      writer.WriteEndTag("h3");
    }

    private void RenderTable(HtmlTextWriter writer, int xDim, int yDim)
    {
      // write <TABLE border="1">
      writer.AddAttribute(HtmlTextWriterAttribute.Border, "1");
      writer.RenderBeginTag(HtmlTextWriterTag.Table);

      for (int y = 0; y < yDim; y++)
      {
        // write <TR>
        writer.RenderBeginTag(HtmlTextWriterTag.Tr);

        for (int x = 0; x < xDim; x++)
        {
          // write <TD cellspacing="1">
          writer.AddAttribute(HtmlTextWriterAttribute.Cellspacing, "1");
          writer.RenderBeginTag(HtmlTextWriterTag.Td);

          // write <SPAN>
          writer.RenderBeginTag(HtmlTextWriterTag.Span);
          writer.Write("X:" + x.ToString());
          writer.Write("Y:" + y.ToString());
          // write </SPAN>
          writer.RenderEndTag();

          // write </TD>
          writer.RenderEndTag();
        }
        // write </TR>
        writer.RenderEndTag();
      }
      // write </TABLE>
      writer.RenderEndTag();
    }
  }
}