// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 9 - ASP.NET AJAX Controls and Extenders
// File: HighlightedHyperLink.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Attribute required to make embedded resource script files avaialble at run time
[assembly: WebResource("ControlsBook2Lib.Ch09.HighlightedHyperLink.js", "text/javascript")]

namespace ControlsBook2Lib.Ch09
{
  [DefaultProperty("HighlightCssClass")]
  [ToolboxData("<{0}:highlightedhyperLink runat=server></{0}:highlightedhyperLink>")]
  public class HighlightedHyperLink : HyperLink, IScriptControl
  {
    private ScriptManager sm;

    [Bindable(false)]
    [Category("Target Control Appearance")]
    [DefaultValue("")]
    [Localizable(true)]
    public string HighlightCssClass
    {
      get 
      {
        return (string)ViewState["HighlightCssClass"];
      }
      set 
      { 
        ViewState["HighlightCssClass"] = value; 
      }
    }

    [Bindable(false)]
    [Category("Target Control Appearance")]
    [DefaultValue("")]
    [Localizable(true)]
    public string NoHighlightCssClass
    {
      get 
      {
        return (string)ViewState["NoHighlightCssClass"];
      }
      set 
      {
        ViewState["NoHighlightCssClass"] = value; 
      }
    }

    protected override void OnPreRender(EventArgs e)
    {
      if (!this.DesignMode)
      {
        // Test for ScriptManager and register if it exists
        sm = ScriptManager.GetCurrent(Page);

        if (sm == null)
          throw new HttpException("A ScriptManager control must exist on the current page.");

        sm.RegisterScriptControl(this);
      }

      base.OnPreRender(e);
    }

    protected override void Render(HtmlTextWriter writer)
    {
      if (!this.DesignMode)
        sm.RegisterScriptDescriptors(this);

      base.Render(writer);
    }

    protected virtual IEnumerable<ScriptReference> GetScriptReferences()
    {
      ScriptReference reference = new ScriptReference();
      //Load script from embedded resource
      reference.Assembly = "ControlsBook2Lib";
      reference.Name = "ControlsBook2Lib.Ch09.HighlightedHyperLink.js";

      return new ScriptReference[] { reference };
    }

    protected virtual IEnumerable<ScriptDescriptor> GetScriptDescriptors()
    {
      ScriptControlDescriptor descriptor = new ScriptControlDescriptor("ControlsBook2Lib.Ch09.HighlightedHyperlink", this.ClientID);
      descriptor.AddProperty("highlightCssClass", this.HighlightCssClass);
      descriptor.AddProperty("nohighlightCssClass", this.NoHighlightCssClass);

      return new ScriptDescriptor[] { descriptor };
    }

    IEnumerable<ScriptReference> IScriptControl.GetScriptReferences()
    {
      return GetScriptReferences();
    }

    IEnumerable<ScriptDescriptor> IScriptControl.GetScriptDescriptors()
    {
      return GetScriptDescriptors();
    }
  }
}
