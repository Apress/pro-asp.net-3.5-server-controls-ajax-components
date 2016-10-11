using System.ComponentModel;
using System.Text;
// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 8 - Integrating Client-Side Script
// File: ConfirmedLinkButton.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch08
{
  [ToolboxData("<{0}:ConfirmedLinkButton runat=server></{0}:ConfirmedLinkButton>"),
  DefaultProperty("Message")]
  public class ConfirmedLinkButton : LinkButton
  {
    private string message = "";
    public virtual string Message
    {
      get { return message; }
      set { message = value; }
    }

    protected override void AddAttributesToRender(HtmlTextWriter writer)
    {
      // enhance the LinkButton by replacing its
      // href attribute while leaving the rest of the
      // rendering process to the base class
      if (Context != null && Context.Request.Browser.EcmaScriptVersion.Major >= 1 &&
         this.Message != "")
      {
        StringBuilder script = new StringBuilder();
        script.Append("javascript: if (confirm('");
        script.Append(this.Message);
        script.Append("')) {");
        // get the ASP.NET JavaScript that does a form
        // postback and have this control submit it
        script.Append(Page.ClientScript.GetPostBackEventReference(this, ""));
        script.Append("}");
        writer.AddAttribute(HtmlTextWriterAttribute.Href,
           script.ToString());
      }
    }
  }
}