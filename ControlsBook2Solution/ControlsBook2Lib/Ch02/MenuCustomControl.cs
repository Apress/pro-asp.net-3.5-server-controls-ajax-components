// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 2 - Encapsulating Functionality in ASP.NET
// File: MenuCustomControl.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Web.UI;

namespace ControlsBook2Lib.Ch02
{
  [ToolboxData("<{0}:menucustomcontrol runat=server></{0}:menucustomcontrol>")]
  public class MenuCustomControl : Control
  {
    protected override void Render(HtmlTextWriter writer)
    {
      base.Render(writer);

      writer.WriteLine("<div>");
      RenderMenuItem(writer, "Apress", "http://www.apress.com");
      writer.Write(" | ");
      RenderMenuItem(writer, "Microsoft", "http://www.microsoft.com");
      writer.Write(" | ");
      RenderMenuItem(writer, "MSDN", "http://msdn.microsoft.com");
      writer.Write(" | ");
      RenderMenuItem(writer, "ASP.NET", "http://asp.net");
      writer.WriteLine("</div>");
    }

    private void RenderMenuItem(HtmlTextWriter writer, string title, string url)
    {
      writer.Write("<span><a href=\"");
      writer.Write(url);
      writer.Write("\">");
      writer.Write(title);
      writer.WriteLine("</a><span>");
    }
  }
}
