// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: Search.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.

using System;
using System.ComponentModel;
using System.Resources;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LiveSearchService;
using ControlsBook2Lib.CH12.LiveSearchControls.Design;

namespace ControlsBook2Lib.CH12.LiveSearchControls
{
  /// <summary>
  ///		Search control displays input textbox and button to capture input and start search process.
  /// </summary>
  [ParseChildren(true),
  ToolboxData("<{0}:Search runat=server></{0}:Search>"),
#if LICENSED
 RsaLicenseData(
     "55489e7a-bff5-4b3c-8f21-c43fad861dfa",

     "<RSAKeyValue><Modulus>mWpgckAepJAp4aU0AvEcGg3TdO+0VXws9LjiSCLpy7aQKD5V7uj49Exh1RtcB6TcuXxm0R6dw75VmKwyoGbvYT6btOIwQgqbLhci5LjWmWUPEdBRiYsOLD0h2POXs9xTvp4IDTKXYoP8GPDRKzklJuuxCbbUcooESQoYHp9ppbE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>"
     ),
  LicenseProvider(typeof(RsaLicenseProvider)),
#endif
 DefaultEvent("LiveSearchSearched"),Designer(typeof(SearchDesigner))]
  public class Search : CompositeControl
  {
    private const string LiveSearchWebPageUrl = "http://www.live.com";
    private const string LiveSearchWebSearchUrl =
       "http://search.live.com/results.aspx";
    private const string LiveSearch25PtLogoImageUrl =
       "http://go.microsoft.com/fwlink/?LinkId=89151";
    private const string LiveSearchLogoImageUrl =
       "http://go.microsoft.com/fwlink/?LinkId=89151";
    private const int SearchTextBoxWidth = 200;
    private const bool DefaultFilteringValue = false;
    private const bool DefaultRedirectToLiveSearchValue = false;
    private bool searchHandled;

    private HyperLink liveSearchLinkImage;
    private TextBox searchTextBox;
    private Button searchButton;

#if LICENSED
    private License license;
#endif


    /// <summary>
    /// Default constructor for Search control
    /// </summary>
    public Search()
    {

#if LICENSED

      // initiate license validation
      license =
         LicenseManager.Validate(typeof(Search), this);

#endif
    }

#if LICENSED

    private bool _disposed;
    /// <summary>
    /// Override Dispose to clean up resources.
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
          if (license != null)
            license.Dispose();
          base.Dispose();
        }
        license = null;
        _disposed = true;
      }
    }

#endif

    /// <summary>
    ///		LiveSearchControls Result control to bind search results to for display
    /// </summary>
    [DescriptionAttribute("Result control to bind search results to for display."),
    CategoryAttribute("Search")]
    virtual public string ResultControl
    {
      get
      {
        object control = ViewState["ResultControl"];
        if (control == null)
          return "";
        else
          return (string)control;
      }
      set
      {
        ViewState["ResultControl"] = value;
      }
    }

    /// <summary>
    ///		Search query string
    /// </summary>
    [DescriptionAttribute("Search query string."),
    CategoryAttribute("Search")]
    virtual public string Query
    {
      get
      {
        EnsureChildControls();
        return searchTextBox.Text;
      }
      set
      {
        EnsureChildControls();
        searchTextBox.Text = value;
      }
    }

    /// <summary>
    ///		Redirect search query to Live Search site web pages.
    /// </summary>
    [DescriptionAttribute("Redirect search query to Live Search site web pages."),
    CategoryAttribute("Search")]
    virtual public bool RedirectToLiveSearch
    {
      get
      {
        object redirect = ViewState["RedirectToLiveSearch"];
        if (redirect == null)
          return DefaultRedirectToLiveSearchValue;
        else
          return (bool)redirect;
      }
      set
      {
        ViewState["RedirectToLiveSearch"] = value;
      }
    }

    /// <summary>
    /// Click event handler for search button
    /// </summary>
    /// <param name="source">Search button</param>
    /// <param name="e">Event arguments</param>
    protected void SearchButtonClick(object source, EventArgs e)
    {
      HandleSearch();
    }

    private void HandleSearch()
    {
      // check to see if search was handled on this postback
      // (this prevents TextChanged and ButtonClicked from
      // requesting the same query twice on the Live Search web service)
      if (searchHandled == true)
        return;

      // check for redirect of query processing to Live Search web site
      if (RedirectToLiveSearch == true)
      {
        this.Page.Response.Redirect(
           LiveSearchWebSearchUrl + "?q=" +
           HttpContext.Current.Server.UrlEncode(Query), true);
      }

      if (ResultControl.Length != 0)
      {
        // lookup the Result control we are linked to
        // and get the PageSize property value
        Result resControl = (Result)Page.FindControl(ResultControl);
        if (resControl == null)
          resControl = (Result)this.NamingContainer.FindControl(ResultControl);
        if (resControl == null)
          throw new ArgumentException("Either a Result control is not set on the " +
              "Search Control or the Result control is not located on the " +
              "Page or at the same nesting level as the Search control.");
        SourceRequest[] sourceRequests = new SourceRequest[1];
        sourceRequests[0] = new SourceRequest();
        sourceRequests[0].Count = resControl.PageSize; //Specifies the number of results to return from offset
        sourceRequests[0].Source = SourceType.Web;
        //new search, always reset
        sourceRequests[0].Offset = 0; //start index for returned results
        sourceRequests[0].ResultFields = ResultFieldMask.All | ResultFieldMask.DateTime;

        // get search results from Live Search WCF service proxy
        SearchResponse searchResponse =
           SearchUtility.SearchLiveSearchService(
           Query, sourceRequests);

        // raise search results for any interested parties as well
        OnLiveSearchSearched(new LiveSearchSearchedEventArgs(searchResponse));

        // databind search results with the Result control
        // we are linked with
        resControl.Query = Query;
        resControl.PageNumber = 0;

        resControl.DataSource = searchResponse;
        resControl.DataBind();
      }
      // set bool that tells us the search has been handled on this
      // postback
      searchHandled = true;
    }

    /// <summary>
    ///   Event handler for hooking into the Search event.
    /// </summary>
    public event EventHandler<LiveSearchSearchedEventArgs> LiveSearchSearched;
    /// <summary>
    ///   Protected method for invoking LiveSearchSearched event from within Result control
    /// </summary>
    /// <param name="e">Event arguments including search results</param>
    protected virtual void OnLiveSearchSearched(LiveSearchSearchedEventArgs e)
    {
      EventHandler<LiveSearchSearchedEventArgs> evnt = LiveSearchSearched;
      if (evnt != null)
        evnt(this, e);
    }

    /// <summary>
    /// Called by framework for composite controls to create control heirarchy
    /// </summary>
    protected override void CreateChildControls()
    {
      liveSearchLinkImage = new HyperLink();
      liveSearchLinkImage.ImageUrl = LiveSearchLogoImageUrl;
      liveSearchLinkImage.NavigateUrl = LiveSearchWebPageUrl;
      this.Controls.Add(liveSearchLinkImage);

      LiteralControl br = new LiteralControl("<br>");
      this.Controls.Add(br);

      searchTextBox = new TextBox();
      searchTextBox.Width = SearchTextBoxWidth;
      //searchTextBox.TextChanged += new
      //   EventHandler(SearchTextBoxTextChanged);
      this.Controls.Add(searchTextBox);

      br = new LiteralControl("&nbsp;");
      this.Controls.Add(br);

      // search button Text is localized
      ResourceManager rm = ResourceFactory.Manager;
      searchButton = new Button();
      searchButton.Text = rm.GetString("Search.searchButton.Text");
      searchButton.Click += new EventHandler(SearchButtonClick);
      this.Controls.Add(searchButton);

      br = new LiteralControl("<br>");
      this.Controls.Add(br);
    }

    /// <summary>
    /// Overridden to ensure Controls collection is created before external access
    /// </summary>
    public override ControlCollection Controls
    {
      get
      {
        EnsureChildControls();
        return base.Controls;
      }
    }
  }
}