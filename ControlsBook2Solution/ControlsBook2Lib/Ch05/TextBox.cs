// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 5 - Server Control Events
// File: TextBox.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Web.UI;

namespace ControlsBook2Lib.Ch05
{
  [ToolboxData("<{0}:textbox runat=server></{0}:textbox>"),
  DefaultProperty("Text")]
  public class TextBox : Control, IPostBackDataHandler
  {
    public string Text
    {
      get
      {
        object text = ViewState["Text"];
        if (text == null)
          return string.Empty;
        else
          return (string)text;
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
      if (!Text.Equals(postedValue))
      {
        Text = postedValue;
        return true;
      }
      else
        return false;
    }

    public void RaisePostDataChangedEvent()
    {
      OnTextChanged(EventArgs.Empty);
    }

    protected virtual void OnTextChanged(EventArgs e)
    {
      if (TextChanged != null)
        TextChanged(this, e);
    }

    public event EventHandler TextChanged;

    protected override void Render(HtmlTextWriter writer)
    {
      base.Render(writer);
      Page.VerifyRenderingInServerForm(this);
      // write out the <INPUT type="text"> tag
      writer.Write("<INPUT type=\"text\" name=\"");
      writer.Write(this.UniqueID);
      writer.Write("\" value=\"" + this.Text + "\" />");
    }
  }
}