// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: RsaLicenseCache.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.

using System;
using System.Collections;

namespace ControlsBook2Lib.CH12.LiveSearchControls
{
  /// <summary>
  ///   Custom cache collection built on Hashtable for storing RsaLicense instances
  /// </summary>
  internal class RsaLicenseCache
  {
    private Hashtable hash = new Hashtable();

    public void AddLicense(Type type, RsaLicense license)
    {
      hash.Add(type, license);
    }

    public RsaLicense GetLicense(Type type)
    {
      RsaLicense license = null;
      if (hash.ContainsKey(type))
        license = (RsaLicense)hash[type];
      return license;
    }

    public void RemoveLicense(Type type)
    {
      hash.Remove(type);
    }
  }
}