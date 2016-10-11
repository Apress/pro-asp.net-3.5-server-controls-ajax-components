// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: ResultDesigner.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.

using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

namespace ControlsBook2Lib.CH12.LiveSearchControls.Design
{
  /// <summary>
  /// Designer class for the Result server control
  /// </summary>
  public class ResultDesigner : ControlDesigner
  {
    TemplateGroupCollection templateGroupCol;

    /// <summary>
    /// Initialize the resources of the designer
    /// </summary>
    /// <param name="component">Component which the designer is linked to</param>
    public override void Initialize(IComponent component)
    {
      base.Initialize(component);
      if (!(component is Result) && !(component is INamingContainer))
      {
        throw new ArgumentException(
           "This control is not a Result control.", "component");
      }
      else
        SetViewFlags(ViewFlags.TemplateEditing, true);
    }

    /// <summary>
    /// Pointer to template editing menu items
    /// </summary>
    public override TemplateGroupCollection TemplateGroups
    {
      get
      {
        if (templateGroupCol == null)
        {
          // Get the base collection
          templateGroupCol = base.TemplateGroups;

          TemplateGroup templateGroup;
          TemplateDefinition templateDef;
          Result ctl;

          //Get reference to the component as Result
          ctl = (Result)Component;

          //Create Template Group
          templateGroup = new TemplateGroup("TemplateMenu Templates");

          //Status
          templateDef = new TemplateDefinition(this, "Status",
              ctl, "StatusTemplate", false);
          templateGroup.AddTemplateDefinition(templateDef);

          //Header
          templateDef = new TemplateDefinition(this, "Header",
              ctl, "HeaderTemplate", false);
          templateGroup.AddTemplateDefinition(templateDef);

          //Separator
          templateDef = new TemplateDefinition(this, "Separator",
               ctl, "SeparatorTemplate", false);
          templateGroup.AddTemplateDefinition(templateDef);

          //Item
          templateDef = new TemplateDefinition(this, "Item",
              ctl, "ItemTemplate", false);
          templateGroup.AddTemplateDefinition(templateDef);

          //Alternate Item
          templateDef = new TemplateDefinition(this, "AlternateItem",
              ctl, "AlternateItemTemplate", false);
          templateGroup.AddTemplateDefinition(templateDef);

          //Footer
          templateDef = new TemplateDefinition(this, "Footer",
              ctl, "FooterTemplate", false);
          templateGroup.AddTemplateDefinition(templateDef);

          // Add the TemplateGroup to the TemplateGroupCollection
          templateGroupCol.Add(templateGroup);
        }

        return templateGroupCol;
      }
    }

    /// <summary>
    /// Determines if designer allows control to be resized in editor
    /// </summary>
    public override bool AllowResize
    {
      get
      {
        bool templateExists = null != ((Result)Component).HeaderTemplate ||
                                      null != ((Result)Component).StatusTemplate ||
                                      null != ((Result)Component).AlternatingItemTemplate ||
                                      null != ((Result)Component).ItemTemplate ||
                                      null != ((Result)Component).SeparatorTemplate ||
                                      null != ((Result)Component).FooterTemplate;

        return templateExists || InTemplateMode;
      }
    }

    /// <summary>
    /// Provides HTML for the visual designer to display
    /// </summary>
    /// <returns>HTML string based on rendering the control with a dummy data source</returns>
    public override string GetDesignTimeHtml()
    {
      Result control = (Result)Component;
      string designTimeHTML = null;

      // bind Result control to dummy data source
      // that has the appropriate page size
      control.DataSource =
         ResultDummyDataSource.GetLiveSearchResults(control.PageSize);
      control.DataBind();

      // let base class designer call Render() on
      // data-bound control to get HTML
      designTimeHTML = base.GetDesignTimeHtml();

      return designTimeHTML;
    }

    /// <summary>
    /// HTML rendered when control has an "error" in its configuration
    /// </summary>
    /// <returns>HTML string</returns>
    protected override string GetErrorDesignTimeHtml(Exception e)
    {

      return CreatePlaceHolderDesignTimeHtml("There was an error rendering the TemplateMenu control." +
         "<br>Exception: " + e.Source + "  Message: " + e.Message);
    }


    /// <summary>
    /// Checks to see if any templates have their content set to a non-empty value
    /// </summary>
    protected bool TemplatesExist
    {
      get
      {
        return (
           ((Result)Component).HeaderTemplate != null ||
           ((Result)Component).StatusTemplate != null ||
           ((Result)Component).ItemTemplate != null ||
           ((Result)Component).AlternatingItemTemplate != null ||
           ((Result)Component).SeparatorTemplate != null ||
           ((Result)Component).FooterTemplate != null
        );
      }
    }

    /// <summary>
    /// Called when the component has been changed
    /// </summary>
    /// <param name="sender">Sender of the event</param>
    /// <param name="ce">Event data including member that was changed.</param>
    public override void OnComponentChanged(object sender, ComponentChangedEventArgs ce)
    {
      if (ce.Member != null)
      {
        string memberName = ce.Member.Name;
        if (memberName.Equals("HeaderStyle") ||
           memberName.Equals("StatusStyle") ||
           memberName.Equals("ItemStyle") ||
           memberName.Equals("AlternatingItemStyle") ||
           memberName.Equals("SeparatorStyle") ||
           memberName.Equals("PagerStyle") ||
           memberName.Equals("FooterStyle"))
        {
          OnStylesChanged();
        }
      }

      base.OnComponentChanged(sender, ce);
    }

    /// <summary>
    /// Override of method that is invoked when control styles change
    /// </summary>
    protected void OnStylesChanged()
    {
      //OnTemplateEditingVerbsChanged();
    }

    /// <summary>
    /// HTML rendered when control has an "empty" configuration
    /// </summary>
    /// <returns>HTML string</returns>
    protected override string GetEmptyDesignTimeHtml()
    {
      string text;

      if (!TemplatesExist)
      {
        text = "Click the arrow, select edit Template, then choose a template to modify.";
      }
      else
      {
        text = "Switch to HTML view to edit the control's templates.";
      }
      return CreatePlaceHolderDesignTimeHtml(text);
    }
  }
}