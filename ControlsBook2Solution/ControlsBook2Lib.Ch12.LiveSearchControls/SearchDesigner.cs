// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: SearchDesigner.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.

using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.Design.WebControls;

namespace ControlsBook2Lib.CH12.LiveSearchControls.Design
{
  /// <summary>
  /// Designer for LiveSearch Lib Search control
  /// </summary>
  public class SearchDesigner : CompositeControlDesigner
  {
    /// <summary>
    /// Initialize the resources of the designer
    /// </summary>
    /// <param name="component">Component which the designer is linked to</param>
    public override void Initialize(IComponent component)
    {
      if (!(component is Control) && !(component is INamingContainer))
      {
        throw new ArgumentException(
           "This control is not a composite control.", "component");
      }
      base.Initialize(component);
    }

    /// <summary>
    /// HTML rendered when control has an "empty" configuration
    /// </summary>
    /// <returns>HTML string</returns>
    protected override string GetEmptyDesignTimeHtml()
    {
      return CreatePlaceHolderDesignTimeHtml(
         Component.GetType() + " control.");
    }

    /// <summary>
    /// HTML rendered when control has an "error" in its configuration
    /// </summary>
    /// <returns>HTML string</returns>
    protected override string GetErrorDesignTimeHtml(Exception e)
    {
      return CreatePlaceHolderDesignTimeHtml(
         "There was an error rendering the" +
         this.Component.GetType() + " control." +
         "<br>Exception: " + e.Source + " Message: " + e.Message);
    }
  }
}