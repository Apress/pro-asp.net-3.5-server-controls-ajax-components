// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: RsaLicense.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright � 2007, Apress L.P.

using System;
using System.ComponentModel;

namespace ControlsBook2Lib.CH12.LiveSearchControls
{
  /// <summary>
  ///	License class for server controls using RSA crypto
  /// </summary>
  public class RsaLicense : License
  {
    private Type type;
    private string licenseKey;
    private string guid;
    private DateTime expireDate;
    private bool _disposed;

    /// <summary>
    ///   Constructor for RsaLicense control license class
    /// </summary>
    /// <param name="type">Type of server control to license</param>
    /// <param name="key">Full key value of license</param>
    /// <param name="guid">Guid for server control type build</param>
    /// <param name="expireDate">Date license expires</param>
    public RsaLicense(Type type, string key, string guid, DateTime expireDate)
    {
      licenseKey = key;
      this.type = type;
      this.guid = guid;
      this.expireDate = expireDate;
    }

    /// <summary>
    /// Full key value of license stored in license file
    /// </summary>
    public override string LicenseKey
    {
      get
      {
        return licenseKey;
      }
    }

    /// <summary>
    /// Server control type the license is bound to
    /// </summary>
    public Type AssociatedServerControlType
    {
      get
      {
        return type;
      }
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
    /// Expiration date of license
    /// </summary>
    public DateTime ExpireDate
    {
      get
      {
        return expireDate;
      }
    }

    /// <summary>
    /// You must override Dispose for controls derived from the License clsas
    /// </summary>
    public sealed override void Dispose()
    {
      //Dispose of any unmanaged resourcee
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    /// <summary>
    /// You must override Dispose for controls derived from the License clsas
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!_disposed)
      {
        if (disposing)
        {
          //Dispose of additional unmanaged resources here
          //if (_resource != null)
          //_resource.Dispose();
        }

        // Indicate that the instance has been disposed.
        // Set additional unmanaged resources to null here
        //_resource = null;
        _disposed = true;
      }
    }
  }
}