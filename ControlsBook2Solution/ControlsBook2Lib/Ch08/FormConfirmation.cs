// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 8 - Integrating Client-Side Script
// File: FormConfirmation.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.ComponentModel;
using System.Web.UI;

namespace ControlsBook2Lib.Ch08
{
  [ToolboxData("<{0}:FormConfirmation runat=server></{0}:FormConfirmation>"),
  DefaultProperty("Message")]
  public class FormConfirmation : Control
  {
    public virtual string Message
    {
      get
      {
        return (string)ViewState["Message"];
      }
      set
      {
        ViewState["Message"] = value;
      }
    }

    protected override void OnPreRender(EventArgs e)
    {
      if (Context.Request.Browser.EcmaScriptVersion.Major >= 1)
      {
        string script = "return (confirm('" + this.Message + "'));";

        // register JavaScript code for onsubmit event
        // of the HTML <form> element
        Page.ClientScript.RegisterOnSubmitStatement(typeof(FormConfirmation),
            "FormConfirmation", script);
      }
    }

    protected override void Render(HtmlTextWriter writer)
    {
      // make sure the control is rendered inside
      // <form runat=server> tags
      Page.VerifyRenderingInServerForm(this);

      base.Render(writer);
    }
  }
}