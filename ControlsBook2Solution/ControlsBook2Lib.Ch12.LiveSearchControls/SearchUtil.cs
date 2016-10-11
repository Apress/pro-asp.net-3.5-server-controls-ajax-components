// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: SearchUtility.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.

using System;
using System.Configuration;
using System.ServiceModel;
using System.Threading;
using System.Web;
using LiveSearchService;

namespace ControlsBook2Lib.CH12.LiveSearchControls
{
  /// <summary>
  ///		Utility class for abstracting Live Search web service proxy work
  /// </summary>
  public sealed class SearchUtility
  {
    private const string ConfigSectionName = "ControlsBook2Lib/LiveSearchControls";

    private SearchUtility()
    {
    }

    /// <summary>
    ///   Static method for searching Live Search that wraps web service proxy code for easy invocation.
    /// </summary>
    /// <param name="query">Query to Live Search search web service</param>
    /// <param name="sourceRequests">Collection of search settings</param>
    /// <returns></returns>
    public static LiveSearchService.SearchResponse SearchLiveSearchService(
    string query, SourceRequest[] sourceRequests)
    {
      string LiveSearchLicenseKey = "";
      string LiveSearchWebServiceUrl = "";

      // get <liveSearchControl> config section from web.config
      // for search settings
      LiveSearchConfigSectionHandler config =
            (LiveSearchConfigSectionHandler)ConfigurationManager.GetSection(
            ConfigSectionName);

      if (config != null)
      {
        LiveSearchLicenseKey = config.License.LiveSearchLicenseKey;
        LiveSearchWebServiceUrl = config.Url.LiveSearchWebServiceUrl;
      }
      // if control is instantiated at runtime config section should be present
      else if (HttpContext.Current != null)
      {
        throw new ArgumentException(
           "ControlsBook2Lib.LiveSearchControls.SearchUtility cannot find <LiveSearchControl> configuration section.");
      }

      EndpointAddress liveSearchAddress =
         new EndpointAddress(LiveSearchWebServiceUrl);
      BasicHttpBinding binding = new BasicHttpBinding();
      ChannelFactory<MSNSearchPortType> channelFactory =
        new ChannelFactory<MSNSearchPortType>(binding, liveSearchAddress);

      MSNSearchPortType searchService = channelFactory.CreateChannel();
      SearchRequest searchRequest = new SearchRequest();
      //Required parameters on SearchRequest
      searchRequest.Query = query;
      searchRequest.AppID = LiveSearchLicenseKey;
      searchRequest.CultureInfo = Thread.CurrentThread.CurrentUICulture.Name;
      //Optional parameters for SearchRequest
      if (sourceRequests != null)
        searchRequest.Requests = sourceRequests;
      //Set mark query word.  Non-printable character added to highlight query terms
      //Set DisableHostCollapsing to return all results
      searchRequest.Flags = SearchFlags.DisableHostCollapsing | SearchFlags.MarkQueryWords;

      //Conduct Search
      SearchResponse searchResponse = searchService.Search(searchRequest);

      return searchResponse;
    }
  }
}