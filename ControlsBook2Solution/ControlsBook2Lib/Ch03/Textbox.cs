// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 3 - ASP.NET State Management
// File: Textbox.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Collections.Specialized;
using System.ComponentModel;
using System.Web.UI;

namespace ControlsBook2Lib.Ch03
{
   [ToolboxData("<{0}:textbox runat=server></{0}:textbox>"),
   DefaultProperty("Text")]
   public class Textbox : Control, IPostBackDataHandler
   {
       public virtual string Text
      {
         get
         {
            object text = ViewState["Text"];
            if (text == null)
               return string.Empty;
            else
               return (string) text;
         }
         set
         {
            ViewState["Text"] = value;
         }
      }

      public bool LoadPostData(string postDataKey,
         NameValueCollection postCollection)
      {
         string postedValue = postCollection[postDataKey];
         Text = postedValue;
         return false;
      }

      public virtual void RaisePostDataChangedEvent()
      {

      }

      override protected void Render(HtmlTextWriter writer)
      {
         Page.VerifyRenderingInServerForm(this);

         base.Render(writer);

         // write out the <INPUT type="text"> tag
         writer.Write("<INPUT type=\"text\" name=\"");
         writer.Write(this.UniqueID);
         writer.Write("\" value=\"" + this.Text + "\" />");
      }
   }
}