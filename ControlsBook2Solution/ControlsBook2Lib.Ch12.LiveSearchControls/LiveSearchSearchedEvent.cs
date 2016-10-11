// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: LiveSearchSearchedEvent.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.

using System;
using System.Collections.Generic;


namespace ControlsBook2Lib.CH12.LiveSearchControls
{
  /// <summary>
  /// Custom event class for passing LiveSearchResult query info
  /// between LiveSearch Lib Search and Result controls
  /// </summary>
  public class LiveSearchSearchedEventArgs : EventArgs
  {
    private LiveSearchService.SearchResponse result;

    /// <summary>
    /// Constructor for LiveSearchSearchEventArgs
    /// </summary>
    /// <param name="result">Results from search of Live Search web service</param>
    public LiveSearchSearchedEventArgs(LiveSearchService.SearchResponse result)
    {
      this.result = result;
    }

    /// <summary>
    /// Results from search of Live Search web service
    /// </summary>
    public LiveSearchService.SearchResponse Result
    {
      get
      {
        return result;
      }
    }
  }
}