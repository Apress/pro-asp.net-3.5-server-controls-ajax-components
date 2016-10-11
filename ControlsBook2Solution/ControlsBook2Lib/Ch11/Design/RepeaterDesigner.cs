// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 11 - Design-Time Support
// File: RepeaterDesigner.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.ComponentModel;
using System.Web.UI.Design;
using System.Web.UI.Design.WebControls;
using ControlsBook2Lib.Ch07;

namespace ControlsBook2Lib.Ch11.Design
{
  class RepeaterDesigner : DataBoundControlDesigner
  {
    TemplateGroupCollection templateGroupCol = null;

    public override void Initialize(IComponent component)
    {
      base.Initialize(component);
      if (!(component is ControlsBook2Lib.Ch07.Repeater))
      {
        throw new ArgumentException("Component must be a ControlsBook2Lib.Ch06.Repeater control for this custom designer."
           , "component");
      }
      else
      {
        SetViewFlags(ViewFlags.TemplateEditing, true);
      }
    }

    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups
    {
      get
      {
        if (templateGroupCol == null)
        {
          // Get the base collection
          templateGroupCol = base.TemplateGroups;

          TemplateGroup templateGroup;
          TemplateDefinition templateDef;
          Repeater ctl;

          //Get reference to the component as Repeater
          ctl = (Repeater)Component;

          //Create Template Group
          templateGroup = new TemplateGroup("Repeater Templates");

          //Header
          templateDef = new TemplateDefinition(this, "Header",
              ctl, "HeaderTemplate", false);
          templateGroup.AddTemplateDefinition(templateDef);

          //Separator
          templateDef = new TemplateDefinition(this, "Separator",
               ctl, "SeparatorTemplate", false);
          templateGroup.AddTemplateDefinition(templateDef);

          ////Item
          //templateDef = new TemplateDefinition(this, "Item",
          //     ctl, "ItemTemplate", false);
          //templateGroup.AddTemplateDefinition(templateDef);

          ////Alternating Item
          //templateDef = new TemplateDefinition(this, "Alternating Item",
          //     ctl, "AlternatingItemTemplate", false);
          //templateGroup.AddTemplateDefinition(templateDef);

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

    public override string GetDesignTimeHtml()
    {
      //Return configuraiton instructions if no templates are set.
      if ((null == ((Repeater)Component).HeaderTemplate) &&
         (null == ((Repeater)Component).SeparatorTemplate) &&
         (null == ((Repeater)Component).ItemTemplate) &&
         (null == ((Repeater)Component).AlternatingItemTemplate) &&
         (null == ((Repeater)Component).FooterTemplate))
      {
        return CreatePlaceHolderDesignTimeHtml("Click here and use the task menu to edit Repeater Header, Footer, and Seperator template properties. " +
         "<br>A default template is used at run-time if the separator Template is not specified at design-time." +
         "<br>The Header and Footer templates are optional.");
      }

      //return configured html
      string designTimeHtml = String.Empty;
      try
      {
        ((Repeater)Component).DataBind();
        designTimeHtml = base.GetDesignTimeHtml();
      }
      catch (Exception e)
      {
        designTimeHtml = GetErrorDesignTimeHtml(e);
      }
      return designTimeHtml;
    }

    public override bool AllowResize
    {
      get
      {
        bool templateExists = null != ((Repeater)Component).HeaderTemplate ||
                                          null != ((Repeater)Component).SeparatorTemplate ||
                                          null != ((Repeater)Component).FooterTemplate;
        return templateExists || InTemplateMode;
      }
    }
  }
}
