// Title: Building ASP.NET Server Controls
//
// Chapter: 11 - Design-Time Support
// File: TitledThumbnailDesigner.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

namespace ControlsBook2Lib.Ch11.Design
{
   public class TitledThumbnailDesigner : ControlDesigner
   {
      private DesignerVerbCollection designTimeVerbs;
      public override DesignerVerbCollection Verbs 
      {
         get 
         {
            if ( null == designTimeVerbs) 
            {
               designTimeVerbs = new DesignerVerbCollection();
               designTimeVerbs.Add(new DesignerVerb("Property Builder...", new EventHandler(this.OnPropertyBuilder)));
            }
            return designTimeVerbs;
         }
      }

      private void OnPropertyBuilder(object sender, EventArgs e) 
      {
         TitledThumbnailComponentEditor TitledThumbnailPropsEditor = new TitledThumbnailComponentEditor();
         TitledThumbnailPropsEditor.EditComponent(Component);
      }

      public override void Initialize(IComponent comp) 
      {
         if (!(comp is TitledThumbnail)) 
         {
            throw new ArgumentException("Must be a TitledThumbnail component.", "component");
         }
         base.Initialize(comp);
      }

      public override string GetDesignTimeHtml()
      {
         ControlCollection cntrls = ((Control)Component).Controls;
         if (((TitledThumbnail)Component).ImageUrl == "")
         {
            return CreatePlaceHolderDesignTimeHtml("Set ImageUrl to URL of desired thumbnail image.");
         }
         else
         {
            return base.GetDesignTimeHtml();
         }
      }

      protected override string GetEmptyDesignTimeHtml()
      {
        return CreatePlaceHolderDesignTimeHtml(Component.GetType() + " control.");
      }
   }
}