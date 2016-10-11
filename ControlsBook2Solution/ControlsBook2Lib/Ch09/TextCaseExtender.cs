// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 9 - ASP.NET AJAX Controls and Extenders
// File: TextCaseExtender.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;

//Attribute required to make embedded resource script files avaialble at run time.
[assembly: WebResource("ControlsBook2Lib.Ch09.TextCaseBehavior.js", "text/javascript")]

public enum TextCaseStyle
{
  LowerCase,
  TitleCase,
  UpperCase
}

namespace ControlsBook2Lib.Ch09
{
  [TargetControlType(typeof(Control))]
  [ToolboxData("<{0}:textcaseextender runat=server></{0}:textcaseextender>")]
  public class TextCaseExtender : ExtenderControl
  {
    [Bindable(true)]
    [Category("Appearance")]
    [DefaultValue("LowerCase")]
    [Localizable(true)]
    public TextCaseStyle CaseStyle 
    {
      get
      {
        return (TextCaseStyle)ViewState["CaseStyle"];
      }
      set
      {
        ViewState["CaseStyle"] = value;
      }
    }

    protected override IEnumerable<ScriptReference> GetScriptReferences()
    {
      ScriptReference reference = new ScriptReference();
      //Load script from embedded resource
      reference.Assembly = "ControlsBook2Lib";
      reference.Name = "ControlsBook2Lib.Ch09.TextCaseBehavior.js";

      return new ScriptReference[] { reference };
    }

    protected override IEnumerable<ScriptDescriptor> GetScriptDescriptors(Control targetControl)
    {
      ScriptBehaviorDescriptor descriptor = new ScriptBehaviorDescriptor("ControlsBook2Lib.Ch09.TextCaseBehavior", targetControl.ClientID);
      descriptor.AddProperty("caseStyle", this.CaseStyle.ToString());
      return new ScriptDescriptor[] { descriptor };
    }
  }
}
