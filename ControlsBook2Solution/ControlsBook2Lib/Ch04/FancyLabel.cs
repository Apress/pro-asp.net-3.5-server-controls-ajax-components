using System.ComponentModel;
// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 4 - WebControl Base Class and Control Styles
// File: FancyLabel.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch04
{
  [ToolboxData("<{0}:fancylabel runat=server></{0}:fancylabel>"),
  DefaultProperty("Text")]
  public class FancyLabel : WebControl
  {
    public FancyLabel()
      : base(HtmlTextWriterTag.Span)
    {
    }

    public CursorStyle Cursor
    {
      get
      {
        return ((FancyLabelStyle)ControlStyle).Cursor;
      }
      set
      {
        ((FancyLabelStyle)ControlStyle).Cursor = value;
      }
    }

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

    protected override Style CreateControlStyle()
    {
      FancyLabelStyle style = new FancyLabelStyle(ViewState);
      return style;
    }

    override protected void RenderContents(HtmlTextWriter writer)
    {
      writer.Write(Text);
    }
  }
}