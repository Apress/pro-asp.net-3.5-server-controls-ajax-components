// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 5 - Server Control Events
// File: CustomEventTextBox.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Collections.Specialized;
using System.ComponentModel;
using System.Web.UI;

namespace ControlsBook2Lib.Ch05
{
  [ToolboxData("<{0}:customeventtextbox runat=server></{0}:customeventtextbox>"),
  DefaultProperty("Text")]
  public class CustomEventTextBox : Control, IPostBackDataHandler
  {
    private string oldText;
    private static readonly object TextChangedKey = new object();

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
        oldText = Text;
        Text = postedValue;
        return true;
      }
      else
        return false;
    }

    public void RaisePostDataChangedEvent()
    {
      OnTextChanged(new TextChangedEventArgs(oldText, Text));
    }

    protected virtual void OnTextChanged(TextChangedEventArgs tce)
    {
      TextChangedEventHandler del =
         (TextChangedEventHandler)Events[TextChangedKey];
      if (del != null)
      {
        del(this, tce);
      }
    }

    public event TextChangedEventHandler TextChanged
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