// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 4 - WebControl Base Class and Control Styles
// File: InputBox.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch04
{
  [ToolboxData("<{0}:inputbox runat=server></{0}:inputbox>")]
  public class InputBox : WebControl
  {
    public InputBox()
      : base(HtmlTextWriterTag.Div)
    {
    }

    public string LabelText
    {
      get
      {
        EnsureChildControls();
        ControlsBook2Lib.Ch04.Label label =
           (ControlsBook2Lib.Ch04.Label)Controls[0];
        return label.Text;
      }
      set
      {
        EnsureChildControls();
        ControlsBook2Lib.Ch04.Label label =
           (ControlsBook2Lib.Ch04.Label)Controls[0];
        label.Text = value;
      }
    }

    public string TextboxText
    {
      get
      {
        EnsureChildControls();
        ControlsBook2Lib.Ch04.Textbox textbox =
           (ControlsBook2Lib.Ch04.Textbox)Controls[1];
        return textbox.Text;
      }
      set
      {
        EnsureChildControls();
        ControlsBook2Lib.Ch04.Textbox textbox =
           (ControlsBook2Lib.Ch04.Textbox)Controls[1];
        textbox.Text = value;
      }
    }

    Style labelStyle;
    public virtual Style LabelStyle
    {
      get
      {
        if (labelStyle == null)
        {
          labelStyle = new Style();
          if (IsTrackingViewState)
            ((IStateManager)labelStyle).TrackViewState();
        }
        return labelStyle;
      }
    }

    Style textboxStyle;
    public virtual Style TextboxStyle
    {
      get
      {
        if (textboxStyle == null)
        {
          textboxStyle = new Style();
          if (IsTrackingViewState)
            ((IStateManager)textboxStyle).TrackViewState();
        }
        return textboxStyle;
      }
    }

    override protected void LoadViewState(object savedState)
    {
      if (savedState != null)
      {
        object[] state = (object[])savedState;

        if (state[0] != null)
          base.LoadViewState(state[0]);
        if (state[1] != null)
          ((IStateManager)LabelStyle).LoadViewState(state[1]);
        if (state[2] != null)
          ((IStateManager)TextboxStyle).LoadViewState(state[2]);
      }
    }

    override protected object SaveViewState()
    {
      object baseState = base.SaveViewState();
      object labelStyleState = (labelStyle != null) ? ((IStateManager)labelStyle).SaveViewState() : null;
      object textboxStyleState = (textboxStyle != null) ? ((IStateManager)textboxStyle).SaveViewState() : null;

      object[] state = new object[3];
      state[0] = baseState;
      state[1] = labelStyleState;
      state[2] = textboxStyleState;

      return state;
    }

    override protected void CreateChildControls()
    {

      ControlsBook2Lib.Ch04.Label label = new ControlsBook2Lib.Ch04.Label();
      Controls.Add(label);

      ControlsBook2Lib.Ch04.Textbox textbox = new ControlsBook2Lib.Ch04.Textbox();
      Controls.Add(textbox);
    }

    public override ControlCollection Controls
    {
      get
      {
        EnsureChildControls();
        return base.Controls;
      }
    }

    private void PrepareControlHierarchy()
    {
      ControlsBook2Lib.Ch04.Label label = (ControlsBook2Lib.Ch04.Label)Controls[0];
      label.ApplyStyle(LabelStyle);
      label.MergeStyle(ControlStyle);

      ControlsBook2Lib.Ch04.Textbox textbox = (ControlsBook2Lib.Ch04.Textbox)Controls[1];
      textbox.ApplyStyle(TextboxStyle);
      textbox.MergeStyle(ControlStyle);
    }

    override protected void Render(HtmlTextWriter writer)
    {
      PrepareControlHierarchy();
      RenderBeginTag(writer);
      RenderChildren(writer);
      RenderEndTag(writer);
    }
  }
}