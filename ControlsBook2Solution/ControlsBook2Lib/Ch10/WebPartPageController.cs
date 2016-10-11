// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 10 - Other Server Controls
// File: WebPartPageController.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ControlsBook2Lib.Ch10
{
  [DefaultProperty("DisplayModeText")]
  [ToolboxData("<{0}:WebPartPageController runat=server></{0}:WebPartPageController>")]
  public class WebPartPageController : CompositeControl
  {
    WebPartManager _currentWebPartManager;

    Label displayMode;
    DropDownList displayModeDropDown;
    RadioButton userRB;
    RadioButton sharedRB;
    Panel personalizationScopePanel;

    #region Properties
    [Bindable(true), Category("Appearance"), DefaultValue("Display Mode"),
    Localizable(true), Description("Sets the text on the caption for the web part state dropdown.")]
    public string DisplayModeText
    {
      get
      {
        object displayModeText = ViewState["DisplayModeText"];
        if (displayModeText == null)
          return string.Empty;
        else
          return (string)displayModeText;
      }

      set
      {
        ViewState["DisplayModeText"] = value;
      }
    }

    [Bindable(true), Category("Appearance"), DefaultValue("Reset User State"),
    Localizable(true), Description("Configures the text on the link button to reset state.")]
    public string ResetStateText
    {
      get
      {
        object resetStateText = ViewState["ResetStateText"];
        if (resetStateText == null)
          return string.Empty;
        else
          return (string)resetStateText;
      }

      set
      {
        ViewState["ResetStateText"] = value;
      }
    }

    [Bindable(true), Category("Appearance"), Localizable(true),
    DefaultValue("Reset the current user's personalization data for the page."),
    Description("Configures the tooltip for the link button to reset state.")]
    public string ResetStateToolTip
    {
      get
      {
        object resetStateToolTip = ViewState["ResetStateToolTip"];
        if (resetStateToolTip == null)
          return string.Empty;
        else
          return (string)resetStateToolTip;
      }

      set
      {
        ViewState["ResetStateToolTip"] = value;
      }
    }

    #endregion

    #region Overrides
    protected override void OnInit(EventArgs e)
    {
      base.OnInit(e);

      _currentWebPartManager =
       WebPartManager.GetCurrentWebPartManager(Page);
    }

    protected override void OnPreRender(EventArgs e)
    {
      base.OnPreRender(e);

      String browseModeName = WebPartManager.BrowseDisplayMode.Name;

      //Reset items collection on dropdown
      displayModeDropDown.Items.Clear();

      // Fill the DropDown with the names of supported display modes.
      foreach (WebPartDisplayMode mode in _currentWebPartManager.SupportedDisplayModes)
      {
        String modeName = mode.Name;
        // Make sure a mode is enabled before adding it.
        if (mode.IsEnabled(_currentWebPartManager))
        {
          ListItem item = new ListItem(modeName, modeName);
          displayModeDropDown.Items.Add(item);
        }
      }

      // If shared scope is allowed for this user, display the scope-switching
      // UI and select the appropriate radio button for the current user scope.
      if (_currentWebPartManager.Personalization.CanEnterSharedScope)
      {
        personalizationScopePanel.Visible = true;
        if (_currentWebPartManager.Personalization.Scope == PersonalizationScope.User)
          userRB.Checked = true;
        else
          sharedRB.Checked = true;
      }

      ListItemCollection items = displayModeDropDown.Items;
      int selectedIndex =
        items.IndexOf(items.FindByText(_currentWebPartManager.DisplayMode.Name));
      displayModeDropDown.SelectedIndex = selectedIndex;
    }

    public override ControlCollection Controls
    {
      get
      {
        EnsureChildControls();
        return base.Controls;
      }
    }

    public override Unit Height
    {
      get
      {
        return base.Height;
      }
      set
      {
        EnsureChildControls();
        Unit min = new Unit(87);
        if (value.Value > min.Value)
          base.Height = value;
        else
          base.Height = min;
      }
    }

    public override Unit Width
    {
      get
      {
        return base.Width;
      }
      set
      {
        EnsureChildControls();
        Unit min = new Unit(167);
        if (value.Value >= min.Value)
          base.Width = value;
        else
          base.Width = min;
      }
    }

    protected override void CreateChildControls()
    {
      Controls.Clear();
      CreateChildControlHierarchy();
    }

    #endregion

    private void CreateChildControlHierarchy()
    {
      Panel rootPanel = new Panel
      {
        ID = "rootPanel",
        BorderWidth = 1,
        BackColor = this.BackColor,
        ForeColor = this.ForeColor
      };
      rootPanel.Font.Names = new string[] { "Verdana", "Arial", "Sans Serif" };

      rootPanel.Width = this.Width;
      rootPanel.Height = this.Height;
      Controls.Add(rootPanel);

      displayModeDropDown = new DropDownList
      {
        ID = "displayModeDropDown",
        AutoPostBack = true,
        Width = 120
      };
      displayModeDropDown.SelectedIndexChanged += new EventHandler(displayModeDropDown_SelectedIndexChanged);

      displayMode = new Label
      {
        ID = "displayMode",
        Text = DisplayModeText,
        AssociatedControlID = "DisplayModeDropDown"
      };
      displayMode.Font.Bold = true;
      displayMode.Font.Size = 8;

      //Add in order of desired rendering
      rootPanel.Controls.Add(displayMode);
      HtmlGenericControl div1 = new HtmlGenericControl("div");
      div1.Controls.Add(displayModeDropDown);
      rootPanel.Controls.Add(div1);

      LinkButton resetUserState = new LinkButton
      {
        ID = "resetUserState",
        Text = ResetStateText,
        ToolTip = ResetStateToolTip
      };
      resetUserState.Font.Size = 8;
      resetUserState.Click += new EventHandler(resetUserState_Click);
      HtmlGenericControl div2 = new HtmlGenericControl("div");
      div2.Controls.Add(resetUserState);
      rootPanel.Controls.Add(div2);
      personalizationScopePanel = new Panel
      {
        ID = "personalization Scope",
        GroupingText = "Personalization Scope",
        Width = 165
      };
      personalizationScopePanel.Font.Size = 8;
      personalizationScopePanel.Font.Bold = true;
      rootPanel.Controls.Add(personalizationScopePanel);

      userRB = new RadioButton
      {
        ID = "userRB",
        Text = "User",
        AutoPostBack = true,
        GroupName = "Scope"
      };
      userRB.CheckedChanged += new EventHandler(userRB_CheckedChanged);
      personalizationScopePanel.Controls.Add(userRB);

      sharedRB = new RadioButton
      {
        ID = "sharedRB",
        Text = "Shared",
        AutoPostBack = true,
        GroupName = "Scope"
      };
      sharedRB.CheckedChanged += new EventHandler(sharedRB_CheckedChanged);
      personalizationScopePanel.Controls.Add(sharedRB);
    }

    #region Control Events
    void sharedRB_CheckedChanged(object sender, EventArgs e)
    {
      if (_currentWebPartManager.Personalization.CanEnterSharedScope &&
            _currentWebPartManager.Personalization.Scope == PersonalizationScope.User)
        _currentWebPartManager.Personalization.ToggleScope();
    }

    void userRB_CheckedChanged(object sender, EventArgs e)
    {
      if (_currentWebPartManager.Personalization.Scope == PersonalizationScope.Shared)
        _currentWebPartManager.Personalization.ToggleScope();
    }

    void resetUserState_Click(object sender, EventArgs e)
    {
      _currentWebPartManager.Personalization.ResetPersonalizationState();
    }

    void displayModeDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
      String selectedMode = displayModeDropDown.SelectedValue;

      WebPartDisplayMode mode = _currentWebPartManager.SupportedDisplayModes[selectedMode];
      if (mode != null)
        _currentWebPartManager.DisplayMode = mode;
    }
    #endregion
  }
}