// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 10 - Other Server Controls
// File: HtmlMCTextBoxAdapter.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Web.UI.MobileControls.Adapters;

namespace ControlsBook2Lib.Ch10.Adapters
{
  public class HtmlMCTextBoxAdapter : HtmlControlAdapter
  {
    protected new MCTextBox Control
    {
      get
      {
        return (MCTextBox)base.Control;
      }
    }

    public override void Render(HtmlMobileTextWriter writer)
    {
      // write out the HTML tag

      writer.Write("<input name=\"" + Control.UniqueID + "\" ");
      writer.Write("value=\"" + Control.Text + "\" ");
      if (Control.Password)
      {
        writer.Write("type=\"password\" ");
      }
      if (Control.Size != 0)
      {
        writer.Write("size=\"" + Control.Size + "\" ");
      }
      writer.Write("/>");

      if (Control.BreakAfter)
      {
        writer.Write("<br>");
      }
    }
  }
}