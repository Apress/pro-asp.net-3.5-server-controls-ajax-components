// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 5 - Server Control Events
// File: LifeCycleControl.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Collections.Specialized;
using System.Diagnostics;
using System.Web.UI;

namespace ControlsBook2Lib.Ch05
{
  [ToolboxData("<{0}:lifecycle runat=server></{0}:lifecycle>")]
  public class Lifecycle : Control, IPostBackEventHandler, IPostBackDataHandler
  {

    // Init Event
    protected override void OnInit(System.EventArgs e)
    {
      Trace("Lifecycle: Init Event.");
      base.OnInit(e);
    }

    protected override void TrackViewState()
    {
      Trace("Lifecycle: Track ViewState.");
      base.TrackViewState();
    }

    // Load ViewState Event
    protected override void LoadViewState(object savedState)
    {
      Trace("Lifecycle: Load ViewState Event.");
      base.LoadViewState(savedState);
    }

    protected override void LoadControlState(object savedState)
    {
      Trace("Lifecycle: Load ControlState Event.");
      base.LoadControlState(savedState);
    }

    public override void DataBind()
    {
      Trace("Lifecycle: DataBind Event.");
      base.DataBind();
    }

    // Load Postback Data Event
    public bool LoadPostData(string postDataKey,
       NameValueCollection postCollection)
    {
      Trace("Lifecycle: Load PostBack Data Event.");
      Page.RegisterRequiresRaiseEvent(this);
      return true;
    }

    // Load Event
    protected override void OnLoad(System.EventArgs e)
    {
      Trace("Lifecycle: Load Event.");
      base.OnLoad(e);
    }

    // Post Data Changed Event
    public void RaisePostDataChangedEvent()
    {
      Trace("Lifecycle: Post Data Changed Event.");
    }

    // Postback Event
    public void RaisePostBackEvent(string argument)
    {
      Trace("Lifecycle: PostBack Event.");
    }

    // PreRender Event
    protected override void OnPreRender(System.EventArgs e)
    {
      Trace("Lifecycle: PreRender Event.");
      Page.RegisterRequiresPostBack(this);
      base.OnPreRender(e);
    }

    // Save ViewState
    protected override object SaveViewState()
    {
      Trace("Lifecycle: Save ViewState.");
      return base.SaveViewState();
    }

    // Save ControlState
    protected override object SaveControlState()
    {
      Trace("Lifecycle: Save ControlState.");
      return base.SaveControlState();
    }

    // Render Event
    protected override void Render(HtmlTextWriter writer)
    {
      base.Render(writer);
      Trace("Lifecycle: Render Event.");
      writer.Write("<h3>LifeCycle Control</h3>");
    }

    // Unload Event
    protected override void OnUnload(System.EventArgs e)
    {
      Trace("Lifecycle: Unload Event.");
      base.OnUnload(e);
    }

    // Dispose Event
    public override void Dispose()
    {
      Trace("Lifecycle: Dispose Event.");
      base.Dispose();
    }

    private void Trace(string info)
    {
      if (Context != null)
      {
        Context.Trace.Warn(info);
        Debug.WriteLine(info);
      }
    }
  }
}