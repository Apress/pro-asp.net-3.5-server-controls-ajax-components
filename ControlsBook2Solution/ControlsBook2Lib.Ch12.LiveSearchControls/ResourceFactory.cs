// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: ResourceFactory.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.

using System.Reflection;
using System.Resources;

namespace ControlsBook2Lib.CH12.LiveSearchControls
{
  /// <summary>
  /// Allows for efficient access to a single ResourceManager instance
  /// using a singleton type of factory pattern
  /// </summary>
  internal class ResourceFactory
  {
    private ResourceFactory()
    {
    }

    internal const string ResourceName = "ControlsBook2Lib.CH12.LiveSearchControls.LocalStrings";
    static ResourceManager rm;

    /// <summary>
    /// Retrieves static instance of ResourceManager class
    /// </summary>
    public static ResourceManager Manager
    {
      get
      {
        if (rm == null)
        {
          // Load the LocalStrings resource bound to the
          // main assembly or one of the language specific
          // satellite assemblies
          rm = new ResourceManager(ResourceName,
          Assembly.GetExecutingAssembly(), null);
        }
        return rm;
      }
    }
  }
}
