// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 3 - ASP.NET State Management
// File: StatefulLabel.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.ComponentModel;
using System.Web.UI;

namespace ControlsBook2Lib.Ch03
{
  [ToolboxData("<{0}:statefullabel runat=server></{0}:statefullabel>"),
  DefaultProperty("Text")]
  public class StatefulLabel : Control
  {
    public virtual string Text
    {
      get
      {
        object text = ViewState["Text"];
        if (text == null)
          return string.Empty;
        else
          return (string)text;
      }
      set
      {
        ViewState["Text"] = value;
      }
    }

    override protected void Render(HtmlTextWriter writer)
    {
      base.Render(writer);

      writer.RenderBeginTag(HtmlTextWriterTag.Span);
      writer.Write(Text);
      writer.RenderEndTag();
    }
  }
}