// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 10 - Other Server Controls
// File: WmlMCTextBoxAdapter.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Web.UI.MobileControls.Adapters;

namespace ControlsBook2Lib.Ch10.Adapters
{
  public class WmlMCTextBoxAdapter : WmlControlAdapter
  {
    protected new MCTextBox Control
    {
      get
      {
        return (MCTextBox)base.Control;
      }
    }

    public override void Render(WmlMobileTextWriter writer)
    {
      string Format;

      if (Control.Numeric)
      {
        Format = "*N"; //Set format to any number of numeric characters
      }
      else
      {
        Format = "*M"; //Set format to any number of characters
      }
      writer.RenderTextBox(Control.UniqueID, Control.Text, Format, Control.Title,
         Control.Password, Control.Size, Control.MaxLength, false, Control.BreakAfter);
    }
  }
}