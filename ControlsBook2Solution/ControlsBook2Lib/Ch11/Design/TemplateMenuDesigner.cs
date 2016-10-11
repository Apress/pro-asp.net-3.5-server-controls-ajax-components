// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 11 - Design-Time Basics
// File: TemplateMenuDesigner.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.ComponentModel;
using System.Web.UI.Design;
using ControlsBook2Lib.Ch06;

namespace ControlsBook2Lib.Ch11.Design
{
  public class TemplateMenuDesigner : ControlDesigner
  {
    TemplateGroupCollection templateGroupCol = null;

    public override void Initialize(IComponent component)
    {
      base.Initialize(component);
      if (!(component is TemplateMenu))
      {
        throw new ArgumentException("Component must be a TemplateMenu control for this custom designer."
           , "component");
      }
      else
      {
        SetViewFlags(ViewFlags.TemplateEditing, true);
      }
    }

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
          TemplateMenu ctl;

          //Get reference to the component as TemplateMenu
          ctl = (TemplateMenu)Component;

          //Create Template Group
          templateGroup = new TemplateGroup("TemplateMenu Templates");

          //Header
          templateDef = new TemplateDefinition(this, "Header",
              ctl, "HeaderTemplate", false);
          templateGroup.AddTemplateDefinition(templateDef);

          //Separator
          templateDef = new TemplateDefinition(this, "Separator",
               ctl, "SeparatorTemplate", false);
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

    public override string GetDesignTimeHtml()
    {
      //Return configuraiton instructions if no templates are set.
      if ((null == ((TemplateMenu)Component).HeaderTemplate) &&
         (null == ((TemplateMenu)Component).SeparatorTemplate) &&
         (null == ((TemplateMenu)Component).FooterTemplate))
      {
        return CreatePlaceHolderDesignTimeHtml("Click here and use the task menu to edit  TemplateMenu Header, Footer, and Seperator template properties. " +
         "<br>A default template is used at run-time if the separator Template is not specified at design-time." +
         "<br>The Header and Footer templates are optional.");
      }

      //return configured html
      string designTimeHtml = String.Empty;
      try
      {
        ((TemplateMenu)Component).DataBind();
        designTimeHtml = base.GetDesignTimeHtml();
      }
      catch (Exception e)
      {
        designTimeHtml = GetErrorDesignTimeHtml(e);
      }
      return designTimeHtml;
    }

    protected override string GetErrorDesignTimeHtml(Exception e)
    {

      return CreatePlaceHolderDesignTimeHtml("There was an error rendering the TemplateMenu control." +
         "<br>Exception: " + e.Source + "  Message: " + e.Message);
    }

    public override bool AllowResize
    {
      get
      {
        bool templateExists = null != ((TemplateMenu)Component).HeaderTemplate ||
                                          null != ((TemplateMenu)Component).SeparatorTemplate ||
                                          null != ((TemplateMenu)Component).FooterTemplate;
        return templateExists || InTemplateMode;
      }
    }
  }
}