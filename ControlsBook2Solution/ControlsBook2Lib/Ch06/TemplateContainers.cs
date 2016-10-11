// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 6 - Server Control Templates and Themes
// File: BasicTemplateContainer.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch06
{
   public class BasicTemplateContainer : WebControl, INamingContainer
   {
      public BasicTemplateContainer() : base(HtmlTextWriterTag.Span)
      {
        this.BorderWidth = 2;
        this.BorderStyle = BorderStyle.Outset;
      }
   }

  public class SeperatorTemplateContainer : WebControl, INamingContainer
  {
    public SeperatorTemplateContainer() : base(HtmlTextWriterTag.Span)
    {
    }
  }
}
