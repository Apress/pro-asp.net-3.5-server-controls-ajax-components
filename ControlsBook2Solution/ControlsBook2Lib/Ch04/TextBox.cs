// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 4 - WebControl Base Class and Control Styles
// File: TextBox.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch04
{
  [ToolboxData("<{0}:textbox runat=server></{0}:textbox>"),
  DefaultProperty("Text")]
  public class Textbox : WebControl, IPostBackDataHandler
  {
    public Textbox()
      : base(HtmlTextWriterTag.Input)
    {
    }

    public virtual string Text
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

    private static readonly object TextChangedKey = new object();
    public event EventHandler TextChanged
    {
      add
      {
        Events.AddHandler(TextChangedKey, value);
      }
      remove
      {
        Events.RemoveHandler(TextChangedKey, value);
      }
    }

    protected virtual void OnTextChanged(EventArgs e)
    {
      EventHandler textChangedEventDelegate =
         (EventHandler)Events[TextChangedKey];
      if (textChangedEventDelegate != null)
      {
        textChangedEventDelegate(this, e);
      }
    }

    override protected void AddAttributesToRender(HtmlTextWriter writer)
    {
      writer.AddAttribute("type", "text");
      writer.AddAttribute("name", UniqueID);
      writer.AddAttribute("value", Text);

      base.AddAttributesToRender(writer);
    }
  }
}