// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: LiveSectionConfigSectionHandler.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.

using System;
using System.Configuration;

namespace ControlsBook2Lib.CH12.LiveSearchControls
{
  /// <summary>
  ///		Retrieves instance of LiveSearchConfigSection fully populated from web.config
  /// </summary>
  public class LiveSearchConfigSectionHandler : ConfigurationSection
  {
    /// <summary>
    ///		Configuration element for the license
    /// </summary>
    [ConfigurationProperty("License")]
    public LicenseConfigElement License
    {
      get
      { return (LicenseConfigElement)this["License"]; }
      set
      { this["License"] = value; }
    }

    /// <summary>
    ///		Configuration element for the Url where the search service is hosted.
    /// </summary>
    [ConfigurationProperty("Url")]
    public UrlConfigElement Url
    {
      get
      { return (UrlConfigElement)this["Url"]; }
      set
      { this["Url"] = value; }
    }
  }

  /// <summary>
  ///		Configuration element for the license
  /// </summary>
  public class LicenseConfigElement : ConfigurationElement
  {
    /// <summary>
    ///		Configuration for license configuraiton element. 
    /// </summary>
    public LicenseConfigElement()
    {
    }

    /// <summary>
    ///		Configuration property for the license key.
    /// </summary>
    public LicenseConfigElement(String licenseKey)
    {
      LiveSearchLicenseKey = licenseKey;
    }

    /// <summary>
    ///		Configuration element for the  Application ID to access the Live Search  Service.
    /// </summary>
    [ConfigurationProperty("LiveSearchLicenseKey", DefaultValue = "Your App Key Goes Here", IsRequired = true)]
    public String LiveSearchLicenseKey
    {
      get
      { return (String)this["LiveSearchLicenseKey"]; }
      set
      { this["LiveSearchLicenseKey"] = value; }
    }
  }
  /// <summary>
  ///		Configuration element for the Url where the Live Search Service is hosted.
  /// </summary>
  public class UrlConfigElement : ConfigurationElement
  {
    /// <summary>
    ///		Constructor for the Url configuration element where the Live Search Service is hosted.
    /// </summary>
    public UrlConfigElement()
    {
    }

    /// <summary>
    ///		Property for the Url
    /// </summary>
    public UrlConfigElement(String webServiceUrl)
    {
      LiveSearchWebServiceUrl = webServiceUrl;
    }

    /// <summary>
    ///		Configuration property for the live search web service Url.
    /// </summary>
    [ConfigurationProperty("LiveSearchWebServiceUrl", DefaultValue = "http://soap.search.msn.com:80/webservices.asmx", IsRequired = true)]
    public String LiveSearchWebServiceUrl
    {
      get
      { return (String)this["LiveSearchWebServiceUrl"]; }
      set
      { this["LiveSearchWebServiceUrl"] = value; }
    }
  }
}