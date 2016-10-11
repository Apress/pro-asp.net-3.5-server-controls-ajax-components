// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 5 - Server Control Events
// File: SuperButton.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch05
{
  public enum ButtonDisplay
  {
    Button = 0,
    Hyperlink = 1
  }

  [ToolboxData("<{0}:superbutton runat=server></{0}:superbutton>")]
  public class SuperButton : Control, IPostBackEventHandler
  {
    public virtual ButtonDisplay Display
    {
      get
      {
        object display = ViewState["Display"];
        if (display == null)
          return ButtonDisplay.Button;
        else
          return (ButtonDisplay)display;
      }
      set
      {
        ViewState["Display"] = value;
      }
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

    private static readonly object ClickKey = new object();

    public event EventHandler Click
    {
      add
      {
        Events.AddHandler(ClickKey, value);
      }
      remove
      {
        Events.RemoveHandler(ClickKey, value);
      }
    }

    protected virtual void OnClick(EventArgs e)
    {
      EventHandler clickEventDelegate =
         (EventHandler)Events[ClickKey];
      if (clickEventDelegate != null)
      {
        clickEventDelegate(this, e);
      }
    }

    private static readonly object CommandKey = new object();

    public event CommandEventHandler Command
    {
      add
      {
        Events.AddHandler(CommandKey, value);
      }
      remove
      {
        Events.RemoveHandler(CommandKey, value);
      }
    }

    public virtual string CommandName
    {
      get
      {
        object name = ViewState["CommandName"];
        if (name == null)
          return string.Empty;
        else
          return (string)name;
      }
      set
      {
        ViewState["CommandName"] = value;
      }
    }

    public virtual string CommandArgument
    {
      get
      {
        object arg = ViewState["CommandArgument"];
        if (arg == null)
          return string.Empty;
        else
          return (string)arg;
      }
      set
      {
        ViewState["CommandArgument"] = value;
      }
    }

    protected virtual void OnCommand(CommandEventArgs ce)
    {
      CommandEventHandler commandEventDelegate =
         (CommandEventHandler)Events[CommandKey];
      if (commandEventDelegate != null)
      {
        commandEventDelegate(this, ce);
      }

      RaiseBubbleEvent(this, ce);
    }

    public void RaisePostBackEvent(string argument)
    {
      OnCommand(new CommandEventArgs(CommandName, CommandArgument));
      OnClick(EventArgs.Empty);
    }

    protected override void Render(HtmlTextWriter writer)
    {
      base.Render(writer);
      Page.VerifyRenderingInServerForm(this);

      if (Display == ButtonDisplay.Button)
      {
        writer.Write("<INPUT type=\"submit\"");
        writer.Write(" name=\"" + this.UniqueID + "\"");
        writer.Write(" id=\"" + this.UniqueID + "\"");
        writer.Write(" value=\"" + Text + "\"");
        writer.Write(" />");
      }
      else if (Display == ButtonDisplay.Hyperlink)
      {
        writer.Write("<A href=\"");
        writer.Write(Page.ClientScript.GetPostBackClientHyperlink(this, ""));
        writer.Write("\">" + Text + "</A>");
      }
    }
  }
}