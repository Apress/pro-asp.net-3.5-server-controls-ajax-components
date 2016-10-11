using System.ComponentModel;
// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 4 - WebControl Base Class and Control Styles
// File: Label.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch04
{
  [ToolboxData("<{0}:label runat=server></{0}:label>"),
  DefaultProperty("Text")]
  public class Label : WebControl
  {
    public Label()
      : base(HtmlTextWriterTag.Span)
    {
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

    override protected void RenderContents(HtmlTextWriter writer)
    {
      writer.Write(Text);
    }
  }
}