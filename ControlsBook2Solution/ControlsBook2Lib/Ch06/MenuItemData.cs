// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 6 - Server Control Templates and Themes
// File: MenuItemData.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.ComponentModel;

namespace ControlsBook2Lib.Ch06
{
  [TypeConverter(typeof(ExpandableObjectConverter))]
  public class MenuItemData
  {
    public MenuItemData()
    {

    }

    //Override this method to display just MenuItemData instead of fully qualified type 
    //in the custom collection editor
    public override string ToString()
    {
      return "MenuItemData";
    }

    [NotifyParentProperty(true)]
    public string Title {get; set; }

    [NotifyParentProperty(true)]
    public string Url { get; set; }

    [NotifyParentProperty(true)]
    public string ImageUrl {get; set; }

    [NotifyParentProperty(true)]
    public string Target { get; set; }
  }
}