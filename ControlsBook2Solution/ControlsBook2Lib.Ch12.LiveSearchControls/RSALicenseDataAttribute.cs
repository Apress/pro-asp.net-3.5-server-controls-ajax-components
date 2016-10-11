// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: RsaLicenseDataAttribute.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.

using System;

namespace ControlsBook2Lib.CH12.LiveSearchControls
{
  /// <summary>
  /// Custom attribute for annotating licensing data on LiveSearch Lib controls
  /// </summary>
  [AttributeUsage(AttributeTargets.Class, Inherited = false,
      AllowMultiple = false)]
  public sealed class RsaLicenseDataAttribute : Attribute
  {
    private string guid;
    private string publicKey;

    /// <summary>
    /// Constructor for RsaLicenseDataAttribute
    /// </summary>
    /// <param name="guid"></param>
    /// <param name="publicKey"></param>
    public RsaLicenseDataAttribute(string guid, string publicKey)
    {
      this.guid = guid;
      this.publicKey = publicKey;
    }

    /// <summary>
    /// Guid representing specific build of server control type
    /// </summary>
    public string Guid
    {
      get
      {
        return guid;
      }
    }

    /// <summary>
    /// Public key representing specific build of server control type
    /// </summary>
    public string PublicKey
    {
      get
      {
        return publicKey;
      }
    }
  }
}