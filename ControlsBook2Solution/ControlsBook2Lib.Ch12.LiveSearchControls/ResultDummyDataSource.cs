// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: ResultDummyDataSource.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.

namespace ControlsBook2Lib.CH12.LiveSearchControls
{
  /// <summary>
  /// Provides a fictional Data source to show control rendering of 
  /// templates while control is in design-time mode
  /// </summary>
  public sealed class ResultDummyDataSource
  {
    private const int TotalResultsCount = 100;

    private ResultDummyDataSource()
    {
    }
    /// <summary>
    /// Returns a LiveSearchService.SearchResponse data set that is valid
    /// according to web service guidelines
    /// </summary>
    /// <param name="pageSize">page size of the LiveSearchService.SearchResponse set</param>
    /// <returns>LiveSearchService.SearchResponse instance with Service.resultElement 
    /// entries present according to page size</returns>
    public static LiveSearchService.SearchResponse GetLiveSearchResults(int pageSize)
    {
      LiveSearchService.SearchResponse result = new LiveSearchService.SearchResponse();
      LiveSearchService.SourceResponse[] sr = new LiveSearchService.SourceResponse[TotalResultsCount];
      result.Responses = sr;
      sr.SetValue(new LiveSearchService.SourceResponse(), 0);
      result.Responses[0].Total = TotalResultsCount;
      result.Responses[0].Source = LiveSearchService.SourceType.Web;
      result.Responses[0].Offset = 0;
      // fill up 10 result elements
      result.Responses[0].Results = new LiveSearchService.Result[pageSize];
      for (int i = 0; i < pageSize; i++)
      {
        result.Responses[0].Results[i] = GetResult(i);
      }

      return result;
    }

    /// <summary>
    /// Returns a valid LiveSearchService.Result instance
    /// </summary>
    /// <param name="index">Index to help create title and url</param>
    /// <returns>Fully populated LiveSearchService.Result instance</returns>
    public static LiveSearchService.Result GetResult(int index)
    {
      LiveSearchService.Result result = new LiveSearchService.Result();
      result.Title = "Result Control " + (index + 1);
      result.Url = "http://apress.com/resultcontrol" + (index + 1);
      result.Summary = "Summary";
      result.Description = "Description";
      result.CacheUrl = "http://apress.com/cached" + (index + 1);
      return result;
    }
  }
}