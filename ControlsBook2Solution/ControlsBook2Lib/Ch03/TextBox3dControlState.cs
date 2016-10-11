// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 3 - ASP.NET State Management
// File: TextBox3dControlState.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch03
{
  [ToolboxData("<{0}:textbox3d runat=server></{0}:textbox3d>"),
  ToolboxBitmap(typeof(ControlsBook2Lib.Ch03.TextBox3d), "ControlsBook2Lib.Ch02.TextBox3d.bmp")]
  public class TextBox3d : TextBox// Inherit from rich control
  { 
    public TextBox3d()
    {
      Enable3D = true;
    }

    // Custom property to set 3D appearance
    [DescriptionAttribute("Set to true for 3d appearance"), DefaultValue("True")]
    public bool Enable3D {get; set; }

    protected override void Render(HtmlTextWriter output)
    {
      // Add DHTML style attribute
      if (Enable3D)
        output.AddStyleAttribute("FILTER", "progid:DXImageTransform.Microsoft.dropshadow(OffX=2, OffY=2, Color='gray', Positive='true'");

      base.Render(output);
    }

    //Notify the page that control state is required
    protected override void OnInit(EventArgs e)
    {
      base.OnInit(e);
      Page.RegisterRequiresControlState(this);
    }

    protected override object SaveControlState()
    {
      object obj = base.SaveControlState();
      if (Enable3D != false)
      {
        if (obj != null)
        {
          return new Pair(obj, Enable3D);
        }
        else
        {
          return (Enable3D);
        }
      }
      else
      {
        return obj;
      }
    }

    protected override void LoadControlState(object state)
    {
      if (state != null)
      {
        Pair p = state as Pair;
        if (p != null)
        {
          base.LoadControlState(p.First);
          Enable3D = (bool)p.Second;
        }
        else
        {
          if (state is bool)
          {
            Enable3D = (bool)state;
          }
          else
          {
            base.LoadControlState(state);
          }
        }
      }
    }
  }
}