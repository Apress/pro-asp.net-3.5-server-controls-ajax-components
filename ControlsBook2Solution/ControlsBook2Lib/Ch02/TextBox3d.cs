using System.ComponentModel;
using System.Drawing;
// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 2 - Encapsulating Functionality in ASP.NET
// File: TextBox3d.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch02
{
  [ToolboxData("<{0}:textbox3d runat=server></{0}:textbox3d>"),
  ToolboxBitmap(typeof(ControlsBook2Lib.Ch02.TextBox3d), "ControlsBook2Lib.Ch03.TextBox3d.bmp")]
  public class TextBox3d : TextBox// Inherit from rich control
  {
    public TextBox3d()
    {
      Enable3D = true;
    }

    // Custom property to set 3D appearance
    [DescriptionAttribute("Set to true for 3d appearance"), DefaultValue("True")]
    public bool Enable3D
    {
      get
      {
        object enable3D = ViewState["Enable3D"];
        if (enable3D == null)
          return false;
        else
          return (bool)enable3D;
      }
      set
      {
        ViewState["Enable3D"] = value;
      }
    }

    protected override void Render(HtmlTextWriter output)
    {
      // Add DHTML style attribute
      if (Enable3D)
        output.AddStyleAttribute("FILTER", "progid:DXImageTransform.Microsoft.dropshadow(OffX=2, OffY=2, Color='gray', Positive='true'");

      base.Render(output);
    }
  }
}