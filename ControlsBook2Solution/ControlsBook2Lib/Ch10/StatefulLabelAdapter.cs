// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 10 - Other Server Controls
// File: StatefulLabelAdapter.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Web.UI.Adapters;

namespace ControlsBook2Lib.Ch10
{
  class StatefulLabelAdapter : ControlAdapter
  {
    protected override void Render(System.Web.UI.HtmlTextWriter writer)
    {
      //base.Render(writer);  Don't want default rendering so comment out

      //Change rendering from a span to a div
      writer.RenderBeginTag(HtmlTextWriterTag.Div);
      //Get a reference to the target control to determine what value to write out
      writer.Write(((StatefulLabel)this.Control).Text);
      writer.RenderEndTag();
    }
  }
}