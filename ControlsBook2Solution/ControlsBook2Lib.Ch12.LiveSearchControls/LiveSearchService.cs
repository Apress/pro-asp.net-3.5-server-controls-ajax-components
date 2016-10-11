﻿// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: LiveSearchService.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
//
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//Modifications: Added LiveSearchService namespace declaration

namespace LiveSearchService
{
  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/MSNSearch/2005/09/fex")]
  public partial class SearchRequest
  {

    private string appIDField;

    private string queryField;

    private string cultureInfoField;

    private SafeSearchOptions safeSearchField;

    private SearchFlags flagsField;

    private Location locationField;

    private SourceRequest[] requestsField;

    /// <remarks/>
    public SearchRequest()
    {
      this.safeSearchField = SafeSearchOptions.Moderate;
      this.flagsField = SearchFlags.None;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string AppID
    {
      get
      {
        return this.appIDField;
      }
      set
      {
        this.appIDField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string Query
    {
      get
      {
        return this.queryField;
      }
      set
      {
        this.queryField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public string CultureInfo
    {
      get
      {
        return this.cultureInfoField;
      }
      set
      {
        this.cultureInfoField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public SafeSearchOptions SafeSearch
    {
      get
      {
        return this.safeSearchField;
      }
      set
      {
        this.safeSearchField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public SearchFlags Flags
    {
      get
      {
        return this.flagsField;
      }
      set
      {
        this.flagsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public Location Location
    {
      get
      {
        return this.locationField;
      }
      set
      {
        this.locationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order = 6)]
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
    public SourceRequest[] Requests
    {
      get
      {
        return this.requestsField;
      }
      set
      {
        this.requestsField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/MSNSearch/2005/09/fex")]
  public enum SafeSearchOptions
  {

    /// <remarks/>
    Moderate,

    /// <remarks/>
    Strict,

    /// <remarks/>
    Off,
  }

  /// <remarks/>
  [System.FlagsAttribute()]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/MSNSearch/2005/09/fex")]
  public enum SearchFlags
  {

    /// <remarks/>
    None = 1,

    /// <remarks/>
    MarkQueryWords = 2,

    /// <remarks/>
    DisableSpellCorrectForSpecialWords = 4,

    /// <remarks/>
    DisableHostCollapsing = 8,

    /// <remarks/>
    DisableLocationDetection = 16,
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/MSNSearch/2005/09/fex")]
  public partial class Location
  {

    private double latitudeField;

    private double longitudeField;

    private double radiusField;

    /// <remarks/>
    public Location()
    {
      this.radiusField = 5;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public double Latitude
    {
      get
      {
        return this.latitudeField;
      }
      set
      {
        this.latitudeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public double Longitude
    {
      get
      {
        return this.longitudeField;
      }
      set
      {
        this.longitudeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    [System.ComponentModel.DefaultValueAttribute(5)]
    public double Radius
    {
      get
      {
        return this.radiusField;
      }
      set
      {
        this.radiusField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/MSNSearch/2005/09/fex")]
  public partial class Image
  {

    private string imageURLField;

    private int imageWidthField;

    private bool imageWidthFieldSpecified;

    private int imageHeightField;

    private bool imageHeightFieldSpecified;

    private int imageFileSizeField;

    private bool imageFileSizeFieldSpecified;

    private string thumbnailURLField;

    private int thumbnailWidthField;

    private bool thumbnailWidthFieldSpecified;

    private int thumbnailHeightField;

    private bool thumbnailHeightFieldSpecified;

    private int thumbnailFileSizeField;

    private bool thumbnailFileSizeFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string ImageURL
    {
      get
      {
        return this.imageURLField;
      }
      set
      {
        this.imageURLField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public int ImageWidth
    {
      get
      {
        return this.imageWidthField;
      }
      set
      {
        this.imageWidthField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ImageWidthSpecified
    {
      get
      {
        return this.imageWidthFieldSpecified;
      }
      set
      {
        this.imageWidthFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public int ImageHeight
    {
      get
      {
        return this.imageHeightField;
      }
      set
      {
        this.imageHeightField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ImageHeightSpecified
    {
      get
      {
        return this.imageHeightFieldSpecified;
      }
      set
      {
        this.imageHeightFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public int ImageFileSize
    {
      get
      {
        return this.imageFileSizeField;
      }
      set
      {
        this.imageFileSizeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ImageFileSizeSpecified
    {
      get
      {
        return this.imageFileSizeFieldSpecified;
      }
      set
      {
        this.imageFileSizeFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public string ThumbnailURL
    {
      get
      {
        return this.thumbnailURLField;
      }
      set
      {
        this.thumbnailURLField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public int ThumbnailWidth
    {
      get
      {
        return this.thumbnailWidthField;
      }
      set
      {
        this.thumbnailWidthField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ThumbnailWidthSpecified
    {
      get
      {
        return this.thumbnailWidthFieldSpecified;
      }
      set
      {
        this.thumbnailWidthFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
    public int ThumbnailHeight
    {
      get
      {
        return this.thumbnailHeightField;
      }
      set
      {
        this.thumbnailHeightField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ThumbnailHeightSpecified
    {
      get
      {
        return this.thumbnailHeightFieldSpecified;
      }
      set
      {
        this.thumbnailHeightFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
    public int ThumbnailFileSize
    {
      get
      {
        return this.thumbnailFileSizeField;
      }
      set
      {
        this.thumbnailFileSizeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ThumbnailFileSizeSpecified
    {
      get
      {
        return this.thumbnailFileSizeFieldSpecified;
      }
      set
      {
        this.thumbnailFileSizeFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/MSNSearch/2005/09/fex")]
  public partial class SearchTag
  {

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string Name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/MSNSearch/2005/09/fex")]
  public partial class Address
  {

    private string addressLineField;

    private string primaryCityField;

    private string secondaryCityField;

    private string subdivisionField;

    private string postalCodeField;

    private string countryRegionField;

    private string formattedAddressField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string AddressLine
    {
      get
      {
        return this.addressLineField;
      }
      set
      {
        this.addressLineField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string PrimaryCity
    {
      get
      {
        return this.primaryCityField;
      }
      set
      {
        this.primaryCityField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public string SecondaryCity
    {
      get
      {
        return this.secondaryCityField;
      }
      set
      {
        this.secondaryCityField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public string Subdivision
    {
      get
      {
        return this.subdivisionField;
      }
      set
      {
        this.subdivisionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public string PostalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public string CountryRegion
    {
      get
      {
        return this.countryRegionField;
      }
      set
      {
        this.countryRegionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
    public string FormattedAddress
    {
      get
      {
        return this.formattedAddressField;
      }
      set
      {
        this.formattedAddressField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/MSNSearch/2005/09/fex")]
  public partial class DateTime
  {

    private int yearField;

    private int monthField;

    private int dayField;

    private int hourField;

    private int minuteField;

    private int secondField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public int Year
    {
      get
      {
        return this.yearField;
      }
      set
      {
        this.yearField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public int Month
    {
      get
      {
        return this.monthField;
      }
      set
      {
        this.monthField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public int Day
    {
      get
      {
        return this.dayField;
      }
      set
      {
        this.dayField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public int Hour
    {
      get
      {
        return this.hourField;
      }
      set
      {
        this.hourField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public int Minute
    {
      get
      {
        return this.minuteField;
      }
      set
      {
        this.minuteField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public int Second
    {
      get
      {
        return this.secondField;
      }
      set
      {
        this.secondField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/MSNSearch/2005/09/fex")]
  public partial class Result
  {

    private string titleField;

    private string descriptionField;

    private string urlField;

    private string displayUrlField;

    private string cacheUrlField;

    private string sourceField;

    private string searchTagsField;

    private string phoneField;

    private DateTime dateTimeField;

    private Address addressField;

    private Location locationField;

    private SearchTag[] searchTagsArrayField;

    private string summaryField;

    private string resultTypeField;

    private Image imageField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string Title
    {
      get
      {
        return this.titleField;
      }
      set
      {
        this.titleField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string Description
    {
      get
      {
        return this.descriptionField;
      }
      set
      {
        this.descriptionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public string Url
    {
      get
      {
        return this.urlField;
      }
      set
      {
        this.urlField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public string DisplayUrl
    {
      get
      {
        return this.displayUrlField;
      }
      set
      {
        this.displayUrlField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public string CacheUrl
    {
      get
      {
        return this.cacheUrlField;
      }
      set
      {
        this.cacheUrlField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public string Source
    {
      get
      {
        return this.sourceField;
      }
      set
      {
        this.sourceField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
    public string SearchTags
    {
      get
      {
        return this.searchTagsField;
      }
      set
      {
        this.searchTagsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
    public string Phone
    {
      get
      {
        return this.phoneField;
      }
      set
      {
        this.phoneField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
    public DateTime DateTime
    {
      get
      {
        return this.dateTimeField;
      }
      set
      {
        this.dateTimeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
    public Address Address
    {
      get
      {
        return this.addressField;
      }
      set
      {
        this.addressField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
    public Location Location
    {
      get
      {
        return this.locationField;
      }
      set
      {
        this.locationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order = 11)]
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
    public SearchTag[] SearchTagsArray
    {
      get
      {
        return this.searchTagsArrayField;
      }
      set
      {
        this.searchTagsArrayField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
    public string Summary
    {
      get
      {
        return this.summaryField;
      }
      set
      {
        this.summaryField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
    public string ResultType
    {
      get
      {
        return this.resultTypeField;
      }
      set
      {
        this.resultTypeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
    public Image Image
    {
      get
      {
        return this.imageField;
      }
      set
      {
        this.imageField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/MSNSearch/2005/09/fex")]
  public partial class SourceResponse
  {

    private SourceType sourceField;

    private int offsetField;

    private int totalField;

    private Result[] resultsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public SourceType Source
    {
      get
      {
        return this.sourceField;
      }
      set
      {
        this.sourceField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public int Offset
    {
      get
      {
        return this.offsetField;
      }
      set
      {
        this.offsetField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public int Total
    {
      get
      {
        return this.totalField;
      }
      set
      {
        this.totalField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
    public Result[] Results
    {
      get
      {
        return this.resultsField;
      }
      set
      {
        this.resultsField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/MSNSearch/2005/09/fex")]
  public enum SourceType
  {

    /// <remarks/>
    Web,

    /// <remarks/>
    News,

    /// <remarks/>
    Ads,

    /// <remarks/>
    InlineAnswers,

    /// <remarks/>
    PhoneBook,

    /// <remarks/>
    WordBreaker,

    /// <remarks/>
    Spelling,

    /// <remarks/>
    QueryLocation,

    /// <remarks/>
    Image,
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/MSNSearch/2005/09/fex")]
  public partial class SearchResponse
  {

    private SourceResponse[] responsesField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
    public SourceResponse[] Responses
    {
      get
      {
        return this.responsesField;
      }
      set
      {
        this.responsesField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/MSNSearch/2005/09/fex")]
  public partial class SourceRequest
  {

    private SourceType sourceField;

    private int offsetField;

    private int countField;

    private string fileTypeField;

    private SortByType sortByField;

    private ResultFieldMask resultFieldsField;

    private string[] searchTagFiltersField;

    /// <remarks/>
    public SourceRequest()
    {
      this.sourceField = SourceType.Web;
      this.offsetField = 0;
      this.countField = 10;
      this.sortByField = SortByType.Default;
      this.resultFieldsField = ((ResultFieldMask.Title | ResultFieldMask.Description)
                  | ResultFieldMask.Url);
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public SourceType Source
    {
      get
      {
        return this.sourceField;
      }
      set
      {
        this.sourceField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public int Offset
    {
      get
      {
        return this.offsetField;
      }
      set
      {
        this.offsetField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public int Count
    {
      get
      {
        return this.countField;
      }
      set
      {
        this.countField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public string FileType
    {
      get
      {
        return this.fileTypeField;
      }
      set
      {
        this.fileTypeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    [System.ComponentModel.DefaultValueAttribute(SortByType.Default)]
    public SortByType SortBy
    {
      get
      {
        return this.sortByField;
      }
      set
      {
        this.sortByField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public ResultFieldMask ResultFields
    {
      get
      {
        return this.resultFieldsField;
      }
      set
      {
        this.resultFieldsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order = 6)]
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
    public string[] SearchTagFilters
    {
      get
      {
        return this.searchTagFiltersField;
      }
      set
      {
        this.searchTagFiltersField = value;
      }
    }
  }

  /// <remarks/>
  [System.FlagsAttribute()]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/MSNSearch/2005/09/fex")]
  public enum SortByType
  {

    /// <remarks/>
    Default = 1,

    /// <remarks/>
    Relevance = 2,

    /// <remarks/>
    Distance = 4,
  }

  /// <remarks/>
  [System.FlagsAttribute()]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/MSNSearch/2005/09/fex")]
  public enum ResultFieldMask
  {

    /// <remarks/>
    All = 1,

    /// <remarks/>
    Title = 2,

    /// <remarks/>
    Description = 4,

    /// <remarks/>
    Url = 8,

    /// <remarks/>
    DisplayUrl = 16,

    /// <remarks/>
    CacheUrl = 32,

    /// <remarks/>
    Source = 64,

    /// <remarks/>
    SearchTags = 128,

    /// <remarks/>
    Phone = 256,

    /// <remarks/>
    DateTime = 512,

    /// <remarks/>
    Address = 1024,

    /// <remarks/>
    Location = 2048,

    /// <remarks/>
    SearchTagsArray = 4096,

    /// <remarks/>
    Summary = 8192,

    /// <remarks/>
    ResultType = 16384,

    /// <remarks/>
    Image = 32768,
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
  [System.ServiceModel.ServiceContractAttribute(Namespace = "http://schemas.microsoft.com/MSNSearch/2005/09/fex", ConfigurationName = "MSNSearchPortType")]
  public interface MSNSearchPortType
  {
    /// <remarks/>
    [System.ServiceModel.OperationContractAttribute(Action = "http://schemas.microsoft.com/MSNSearch/2005/09/fex/Search", ReplyAction = "*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    [return: System.ServiceModel.MessageParameterAttribute(Name = "Response")]
    SearchResponse Search(SearchRequest Request);
  }
  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
  public interface MSNSearchPortTypeChannel : MSNSearchPortType, System.ServiceModel.IClientChannel
  {
  }

  /// <remarks/>
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
  public partial class MSNSearchPortTypeClient : System.ServiceModel.ClientBase<MSNSearchPortType>, MSNSearchPortType
  {
    /// <remarks/>
    public MSNSearchPortTypeClient()
    {
    }

    /// <remarks/>
    public MSNSearchPortTypeClient(string endpointConfigurationName) :
      base(endpointConfigurationName)
    {
    }

    /// <remarks/>
    public MSNSearchPortTypeClient(string endpointConfigurationName, string remoteAddress) :
      base(endpointConfigurationName, remoteAddress)
    {
    }

    /// <remarks/>
    public MSNSearchPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
      base(endpointConfigurationName, remoteAddress)
    {
    }

    /// <remarks/>
    public MSNSearchPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
      base(binding, remoteAddress)
    {
    }

    /// <remarks/>
    public SearchResponse Search(SearchRequest Request)
    {
      return base.Channel.Search(Request);
    }
  }
}