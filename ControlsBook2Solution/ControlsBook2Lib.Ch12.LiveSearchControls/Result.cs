// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 12 - Building a Complex Control
// File: result.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;
using ControlsBook2Lib.CH12.LiveSearchControls.Design;
using LiveSearchService;

namespace ControlsBook2Lib.CH12.LiveSearchControls
{
  /// <summary>
  ///		Determines search results pager style
  /// </summary>
  public enum ResultPagerLinkStyle
  {
    /// <summary>
    /// Render pager with text hyperlinks for search result navigation
    /// </summary>
    Text = 0,

    /// <summary>
    /// Render pager DHTML for page link buttons in pager.  
    /// Not implemented but a place holder for extension
    /// </summary>
    TextWithDHTML
  }

  /// <summary>
  ///		Result control displays the formatted results from a query of the
  ///		Live Search search web service.
  /// </summary>
  [ParseChildren(true),
  ToolboxData("<{0}:result runat=server></{0}:result>"),
  Designer(typeof(ResultDesigner)),
#if LICENSED
   RsaLicenseData(
      "55489e7a-bff5-4b3c-8f21-c43fad861dfa",

"<RSAKeyValue><Modulus>mWpgckAepJAp4aU0AvEcGg3TdO+0VXws9LjiSCLpy7aQKD5V7uj49Exh1RtcB6TcuXxm0R6dw75VmKwyoGbvYT6btOIwQgqbLhci5LjWmWUPEdBRiYsOLD0h2POXs9xTvp4IDTKXYoP8GPDRKzklJuuxCbbUcooESQoYHp9ppbE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>"
      ),
   LicenseProvider(typeof(RsaLicenseProvider)),
#endif
 DefaultEvent("LiveSearchSearched")
  ]
  public class Result : CompositeControl
  {
    // constants
    private const int defaultPageSize = 10;
    private const int defaultPagerBarRange = 4;
    private const int defaultPageNumber = 1;

    // style property fields
    private Style headerStyle;
    private Style statusStyle;
    private Style itemStyle;
    private Style alternatingItemStyle;
    private Style separatorStyle;
    private Style pagerStyle;
    private Style footerStyle;
    private ResultPagerLinkStyle pagerLinkStyle =
    ResultPagerLinkStyle.TextWithDHTML;

    // Template property fields
    private ITemplate headerTemplate;
    private ITemplate statusTemplate;
    private ITemplate itemTemplate;
    private ITemplate alternatingItemTemplate;
    private ITemplate separatorTemplate;
    private ITemplate footerTemplate;

    private bool searchConducted;
    private SearchResponse dataSource;
    private Collection<ResultItem> items = new Collection<ResultItem>();

#if LICENSED
      private License license;
#endif

    /// <summary>
    /// Default constructor for Result control
    /// </summary>
    public Result()
    {
#if LICENSED
         // initiate license validation
         license =
            LicenseManager.Validate(typeof(Search), this);
#endif
    }

    /// <summary>
    ///   Override bases Result control on div HTML tag
    /// </summary>
    protected override HtmlTextWriterTag TagKey
    {
      get
      {
        return HtmlTextWriterTag.Div;
      }
    }
    #region Dispose pattern

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
    #endregion

    #region Search properties
    /// <summary>
    /// Number of search results returned with query and displayed on page.
    /// </summary>
    [Description("Number of search results returned with query and displayed on page."),
     Category("Search"), DefaultValue(defaultPageSize)]
    virtual public int PageSize
    {
      get
      {
        object size = ViewState["PageSize"];
        if (size == null)
          return defaultPageSize;
        else
          return (int)size;
      }
      set
      {
        ViewState["PageSize"] = value;
      }
    }

    /// <summary>
    /// Ending item index of search list results.
    /// </summary>
    [Browsable(true), DefaultValue(defaultPageNumber)]
    virtual public int PageNumber
    {
      get
      {
        object pageNumber = ViewState["PageNumber"];
        if (pageNumber == null)
          return defaultPageNumber;
        else
          return (int)pageNumber;
      }
      set
      {
        if (value < 1)
          value = 1;
        ViewState["PageNumber"] = value;
      }
    }

    /// <summary>
    /// Estimated total results count from query.
    /// </summary>
    [Browsable(false)]
    virtual public int TotalResultsCount
    {
      get
      {
        object count = ViewState["TotalResultsCount"];
        if (count == null)
          return 0;
        else
          return (int)count;
      }

    }

    /// <summary>
    /// Search query string.
    /// </summary>
    [Browsable(false)]
    virtual public string Query
    {
      get
      {
        object query = ViewState["Query"];
        if (query == null)
          return string.Empty;
        else
          return (string)query;
      }
      set
      {
        ViewState["Query"] = value;
      }
    }

    #endregion

    #region Appearance properties

    /// <summary>
    /// Display paging links at bottom of search results.
    /// </summary>
    [Description("Display paging links at bottom of search results."),
    Category("Appearance")]
    virtual public bool DisplayPager
    {
      get
      {
        object pager = ViewState["DisplayPager"];
        if (pager == null)
          return true;
        else
          return (bool)pager;
      }
      set
      {
        ViewState["DisplayPager"] = value;
      }
    }

    /// <summary>
    /// Style of Pager control link display.
    /// </summary>
    [Description("Style of Pager control link display."),
    Category("Appearance")]
    public ResultPagerLinkStyle PagerLinkStyle
    {
      get
      {
        return pagerLinkStyle;
      }
      set
      {
        pagerLinkStyle = value;
      }
    }

    /// <summary>
    /// Number of pages displayed in pager bar.
    /// </summary>
    [Description("Number of pages displayed in pager bar."),
    Category("Appearance"), DefaultValue(4)]
    virtual public int PagerBarRange
    {
      get
      {
        object range = ViewState["PagerBarRange"];
        if (range == null)
          return defaultPagerBarRange;
        else
          return (int)range;
      }
      set
      {
        ViewState["PagerBarRange"] = value;
      }
    }
    #endregion

    #region Miscellaneous properties
    /// <summary>
    /// Data source which takes a SearchResponse to build display.
    /// </summary>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),
          DefaultValue(null),
          Bindable(true),
          Browsable(false)]
    public LiveSearchService.SearchResponse DataSource
    {
      get
      {
        return dataSource;
      }
      set
      {
        dataSource = value;
      }
    }

    /// <summary>
    /// Collection of child ResultItem controls
    /// </summary>
    [Browsable(false)]
    public Collection<ResultItem> Items
    {
      get
      {
        return items;
      }
    }
    #endregion

    #region Style properties
    /// <summary>
    /// The style to be applied to header template.
    /// </summary>
    [Category("Style"),
    Description("The style to be applied to header template."),

DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
    NotifyParentProperty(true),
    PersistenceMode(PersistenceMode.InnerProperty),
    ]
    public virtual Style HeaderStyle
    {
      get
      {
        if (headerStyle == null)
        {
          headerStyle = new Style();
          if (IsTrackingViewState)
            ((IStateManager)footerStyle).TrackViewState();
        }
        return headerStyle;
      }
    }

    /// <summary>
    /// The style to be applied to status template.
    /// </summary>
    [Category("Style"),
    Description("The style to be applied to status template."),

DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
    NotifyParentProperty(true),
    PersistenceMode(PersistenceMode.InnerProperty),
    ]
    public virtual Style StatusStyle
    {
      get
      {
        if (statusStyle == null)
        {
          statusStyle = new Style();
          statusStyle.ForeColor = System.Drawing.Color.Blue;
          statusStyle.Font.Bold = true;
          if (IsTrackingViewState)
            ((IStateManager)statusStyle).TrackViewState();
        }
        return statusStyle;
      }
    }

    /// <summary>
    /// The style to be applied to item template.
    /// </summary>
    [Category("Style"),
    Description("The style to be applied to item template."),

DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
    NotifyParentProperty(true),
    PersistenceMode(PersistenceMode.InnerProperty),
    ]
    public virtual Style ItemStyle
    {
      get
      {
        if (itemStyle == null)
        {
          itemStyle = new Style();
          if (IsTrackingViewState)
            ((IStateManager)itemStyle).TrackViewState();
        }
        return itemStyle;
      }
    }

    /// <summary>
    /// The style to be applied to alternate item template.
    /// </summary>
    [Category("Style"),
Description("The style to be applied to alternate item template."),

DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
NotifyParentProperty(true),
PersistenceMode(PersistenceMode.InnerProperty),
]
    public virtual Style AlternatingItemStyle
    {
      get
      {
        if (alternatingItemStyle == null)
        {
          alternatingItemStyle = new Style();
          if (IsTrackingViewState)
            ((IStateManager)alternatingItemStyle).TrackViewState();
        }
        return alternatingItemStyle;
      }
    }

    /// <summary>
    /// The style to be applied to the separator template
    /// </summary>
    [Category("Style"),
    Description("The style to be applied to the separator template."),

DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
    NotifyParentProperty(true),
    PersistenceMode(PersistenceMode.InnerProperty),
    ]
    public virtual Style SeparatorStyle
    {
      get
      {
        if (separatorStyle == null)
        {
          separatorStyle = new Style();
          if (IsTrackingViewState)
            ((IStateManager)separatorStyle).TrackViewState();
        }
        return separatorStyle;
      }
    }

    /// <summary>
    /// The style to be applied to the footer template.
    /// </summary>
    [Category("Style"),
    Description("The style to be applied to the pager."),

DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
    NotifyParentProperty(true),
    PersistenceMode(PersistenceMode.InnerProperty),
    ]
    public virtual Style PagerStyle
    {
      get
      {
        if (pagerStyle == null)
        {
          pagerStyle = new Style();
          if (IsTrackingViewState)
            ((IStateManager)pagerStyle).TrackViewState();
        }
        return pagerStyle;
      }
    }

    /// <summary>
    /// The style to be applied to the footer template.
    /// </summary>
    [Category("Style"),
    Description("The style to be applied to the footer template."),

DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
    NotifyParentProperty(true),
    PersistenceMode(PersistenceMode.InnerProperty),
    ]
    public virtual Style FooterStyle
    {
      get
      {
        if (footerStyle == null)
        {
          footerStyle = new Style();
          if (IsTrackingViewState)
            ((IStateManager)footerStyle).TrackViewState();
        }
        return footerStyle;
      }
    }
    #endregion

    #region Style and ViewState management
    /// <summary>
    /// Manual override of ViewState save method to put in custom styles for control templates
    /// </summary>
    /// <returns>Object array to persist to ViewState</returns>
    override protected object SaveViewState()
    {
      object baseState = base.SaveViewState();
      object headerStyleState = (headerStyle != null) ?
((IStateManager)HeaderStyle).SaveViewState() : null;
      object statusStyleState = (statusStyle != null) ?
((IStateManager)StatusStyle).SaveViewState() : null;
      object itemStyleState = (itemStyle != null) ?
((IStateManager)ItemStyle).SaveViewState() : null;
      object alternatingItemStyleState = (alternatingItemStyle != null) ?
((IStateManager)AlternatingItemStyle).SaveViewState() : null;
      object separatorStyleState = (separatorStyle != null) ?
((IStateManager)SeparatorStyle).SaveViewState() : null;
      object pagerStyleState = (pagerStyle != null) ?
((IStateManager)PagerStyle).SaveViewState() : null;
      object footerStyleState = (itemStyle != null) ?
((IStateManager)FooterStyle).SaveViewState() : null;

      object[] state = new object[8];
      state[0] = baseState;
      state[1] = headerStyleState;
      state[2] = statusStyleState;
      state[3] = itemStyleState;
      state[4] = alternatingItemStyleState;
      state[5] = separatorStyleState;
      state[6] = pagerStyleState;
      state[7] = footerStyleState;

      return state;
    }

    /// <summary>
    /// Manual override of ViewState load method to retrieve custom styles for control templates
    /// </summary>
    /// <param name="savedState">Object array retrieved from ViewState</param>
    override protected void LoadViewState(object savedState)
    {
      if (savedState != null)
      {
        object[] state = (object[])savedState;

        if (state[0] != null)
          base.LoadViewState(state[0]);
        if (state[1] != null)
          ((IStateManager)HeaderStyle).LoadViewState(state[1]);
        if (state[2] != null)
          ((IStateManager)StatusStyle).LoadViewState(state[2]);
        if (state[3] != null)
          ((IStateManager)ItemStyle).LoadViewState(state[3]);
        if (state[4] != null)

          ((IStateManager)AlternatingItemStyle).LoadViewState(state[4]);
        if (state[5] != null)
          ((IStateManager)SeparatorStyle).LoadViewState(state[5]);
        if (state[6] != null)
          ((IStateManager)PagerStyle).LoadViewState(state[6]);
        if (state[7] != null)
          ((IStateManager)FooterStyle).LoadViewState(state[7]);
      }
    }

    /// <summary>
    /// Build child control structure
    /// </summary>
    protected void PrepareControlHierarchy()
    {
      // apply all the appropriate style attributes
      // to the items in the result output
      foreach (ResultItem item in this.Items)
      {
        if (item.ItemType == ResultItemType.Header)
        {
          if (HeaderStyle != null)
            item.ApplyStyle(HeaderStyle);
        }
        else if (item.ItemType == ResultItemType.Status)
        {
          if (StatusStyle != null)
            item.ApplyStyle(StatusStyle);
        }
        else if (item.ItemType == ResultItemType.Item)
        {
          if (ItemStyle != null)
            item.ApplyStyle(ItemStyle);

        }
        else if (item.ItemType == ResultItemType.AlternatingItem)
        {
          if (AlternatingItemStyle != null)
            item.ApplyStyle(AlternatingItemStyle);
          else if (ItemStyle != null)
            item.ApplyStyle(ItemStyle);
        }
        else if (item.ItemType == ResultItemType.Separator)
        {
          if (SeparatorStyle != null)
            item.ApplyStyle(SeparatorStyle);
        }
        else if (item.ItemType == ResultItemType.Pager)
        {
          if (PagerStyle != null)
          {
            Pager pager = (Pager)item.Controls[0];
            pager.ApplyStyle(PagerStyle);
          }
        }
        else if (item.ItemType == ResultItemType.Footer)
        {
          if (FooterStyle != null)
            item.ApplyStyle(FooterStyle);
        }
      }
    }
    #endregion

    #region Template properties
    /// <summary>
    /// The content to be shown at header of control.
    /// </summary>
    [Browsable(false),
    DefaultValue(null),
    Description("The content to be shown at header of control."),
    PersistenceMode(PersistenceMode.InnerProperty),
    TemplateContainer(typeof(ResultItem))
    ]
    public ITemplate HeaderTemplate
    {
      get
      {
        return headerTemplate;
      }
      set
      {
        headerTemplate = value;
      }
    }

    /// <summary>
    /// The content to be shown in status area below header template.
    /// </summary>
    [Browsable(false),
    DefaultValue(null),
    Description("The content to be shown in status area below header template."),
    PersistenceMode(PersistenceMode.InnerProperty),
    TemplateContainer(typeof(ResultItem))
    ]
    public ITemplate StatusTemplate
    {
      get
      {
        return statusTemplate;
      }
      set
      {
        statusTemplate = value;
      }
    }

    /// <summary>
    /// The content to be shown with each item of the search result set.
    /// </summary>
    [Browsable(false),
    DefaultValue(null),
    Description("The content to be shown with each item of the search result set."),
    PersistenceMode(PersistenceMode.InnerProperty),
    TemplateContainer(typeof(ResultItem))
    ]
    public ITemplate ItemTemplate
    {
      get
      {
        return itemTemplate;
      }
      set
      {
        itemTemplate = value;
      }
    }

    /// <summary>
    /// The content to be shown with alternating items in the search result set.
    /// </summary>
    [Browsable(false),
    DefaultValue(null),
    Description("The content to be shown with alternating items in the search result set."),
    PersistenceMode(PersistenceMode.InnerProperty),
    TemplateContainer(typeof(ResultItem))
    ]
    public ITemplate AlternatingItemTemplate
    {
      get
      {
        return alternatingItemTemplate;
      }
      set
      {
        alternatingItemTemplate = value;
      }
    }

    /// <summary>
    /// The content to be put between each item in the search result set.
    /// </summary>
    [Browsable(false),
    DefaultValue(null),
    Description("The content to be put between each item in the search result set."),
    PersistenceMode(PersistenceMode.InnerProperty),
    TemplateContainer(typeof(ResultItem))
    ]
    public ITemplate SeparatorTemplate
    {
      get
      {
        return separatorTemplate;
      }
      set
      {
        separatorTemplate = value;
      }
    }

    /// <summary>
    /// The content to be shown below search results at bottom of control.
    /// </summary>
    [Browsable(false),
    DefaultValue(null),
    Description("The content to be shown below search results at bottom of control."),
    PersistenceMode(PersistenceMode.InnerProperty),
    TemplateContainer(typeof(ResultItem))
    ]
    public ITemplate FooterTemplate
    {
      get
      {
        return footerTemplate;
      }
      set
      {
        footerTemplate = value;
      }
    }
    #endregion

    #region Events and Event Handling
    /// <summary>
    ///		Public event for hooking into the Live Search service
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
    ///		Public event for hooking into when each result is created and added to the returned results to allow customization.
    /// </summary>
    public event EventHandler<ResultItemEventArgs> ItemCreated;
    /// <summary>
    ///   Protected method for invoking ItemCreated event from within Result control
    /// </summary>
    /// <param name="e">Event arguments</param>
    protected virtual void OnItemCreated(ResultItemEventArgs e)
    {
      EventHandler<ResultItemEventArgs> evnt = ItemCreated;
      if (evnt != null)
        evnt(this, e);
    }
    /// <summary>
    ///		Public event for hooking into when each result databinds to allow customization.
    /// </summary>
    public event EventHandler<ResultItemEventArgs> ItemDataBound;
    /// <summary>
    ///   Protected method for invoking ItemDataBound event from within Result control
    /// </summary>
    /// <param name="e">Event arguments</param>
    protected virtual void OnItemDataBound(ResultItemEventArgs e)
    {
      EventHandler<ResultItemEventArgs> evnt = ItemDataBound;
      if (evnt != null)
        evnt(this, e);
    }

    /// <summary>
    /// Handles bubbled up events from child controls to catch paging events from Pager control
    /// </summary>
    /// <param name="source">Control which is source of event</param>
    /// <param name="args">Event arguments</param>
    /// <returns></returns>
    protected override bool OnBubbleEvent(object source, EventArgs args)
    {
      // Handle events raised by children by overriding OnBubbleEvent.
      // (main purpose is to detect paging events)
      bool handled = false;
      CommandEventArgs cea = args as CommandEventArgs;

      // handle Page event by extracting new start index
      // and calling HandleSearch method which does the
      // work of re-binding this control to the results
      // from the web service
      if (cea.CommandName == "Page")
      {
        PageNumber = Convert.ToInt32(cea.CommandArgument);
        HandleSearch();
      }
      return handled;
    }

    private void HandleSearch()
    {
      SourceRequest[] sourceRequests = new SourceRequest[1];
      sourceRequests[0] = new SourceRequest();
      sourceRequests[0].Source = SourceType.Web;
      sourceRequests[0].Count = PageSize; //Specifies the number of results to return from offset
      sourceRequests[0].Offset = PageSize * (PageNumber - 1); //start index for returned results
      //For paging, specify new offset to get next results.
      //so for count of 5, to get 6-10 specify offset of 5 for page 2
      sourceRequests[0].ResultFields = ResultFieldMask.All | ResultFieldMask.DateTime;

      SearchResponse searchResults =
         SearchUtility.SearchLiveSearchService(
         Query, sourceRequests);

      OnLiveSearchSearched(new LiveSearchSearchedEventArgs(searchResults));

      this.DataSource = searchResults;
      this.DataBind();
    }
    #endregion

    #region Control Creation/Rendering
    private ResultItem CreateResultItem(int index, ResultItemType
itemType, bool dataBind, object dataItem)
    {
      ITemplate selectedTemplate;

      switch (itemType)
      {
        case ResultItemType.Header:
          selectedTemplate = HeaderTemplate;
          break;
        case ResultItemType.Status:
          if (StatusTemplate == null)
          {
            // if no StatusTemplate, pick up the default
            // template ResultStatusTemplate
            selectedTemplate = new ResultStatusTemplate();
          }
          else
            selectedTemplate = StatusTemplate;
          break;
        case ResultItemType.Item:
          if (ItemTemplate == null)
          {
            // if no ItemTemplate, pick up the default
            // template ResultItemTemplate
            selectedTemplate = new ResultItemTemplate();
          }
          else
            selectedTemplate = ItemTemplate;
          break;
        case ResultItemType.AlternatingItem:
          selectedTemplate = AlternatingItemTemplate;
          if (selectedTemplate == null)
          {
            // if no AlternatingItemTemplate, switch to Item type
            // and pick up ItemTemplate
            itemType = ResultItemType.Item;
            selectedTemplate = ItemTemplate;
            if (selectedTemplate == null)
            {
              // if that doesnt work, pick up the default
              // template ResultItemTemplate
              selectedTemplate = new ResultItemTemplate();
            }
          }
          break;
        case ResultItemType.Separator:
          selectedTemplate = SeparatorTemplate;
          break;
        case ResultItemType.Footer:
          selectedTemplate = FooterTemplate;
          break;
        default:
          selectedTemplate = null;
          break;
      }

      ResultItem item = new ResultItem(index, itemType, dataItem);

      if (selectedTemplate != null)
      {
        selectedTemplate.InstantiateIn(item);
      }

      OnItemCreated(new ResultItemEventArgs(item));
      Controls.Add(item);

      if (dataBind)
      {
        item.DataBind();
        OnItemDataBound(new ResultItemEventArgs(item));
      }
      return item;
    }

    private ResultItem CreatePagerResultItem()
    {
      ResultItem item = new ResultItem(-1, ResultItemType.Pager, null);

      Pager pager = new Pager();
      pager.PageSize = PageSize;
      pager.PagerBarRange = PagerBarRange;
      pager.PagerLinkStyle = PagerLinkStyle;
      pager.TotalResultsCount = TotalResultsCount;
      pager.PageNumber = PageNumber;

      item.Controls.Add(pager);

      Controls.Add(item);

      return item;
    }

    private void CreateControlHierarchy(bool dataBind)
    {
      Controls.Clear();
      SearchResponse result = null;

      // Result items
      items = new Collection<ResultItem>();

      int count = 0;

      if (dataBind == true)
      {
        if (DataSource == null)
          return;
        result = DataSource;

        // set ViewState values for read-only props
        ViewState["TotalResultsCount"] =
result.Responses[0].Total;
        ViewState["Offset"] = result.Responses[0].Offset;
        ViewState["Source"] = result.Responses[0].Source;

        count = result.Responses[0].Results.Length;
        ViewState["ResultItemCount"] = count;
      }
      else
      {
        object temp = ViewState["ResultItemCount"];
        if (temp != null)
          count = (int)temp;
      }

      if (HeaderTemplate != null)
      {
        ResultItem headerItem = CreateResultItem(-1,
ResultItemType.Header, false, null);
        items.Add(headerItem);
      }

      ResultItem statusItem = CreateResultItem(-1, ResultItemType.Status,
dataBind, result);
      items.Add(statusItem);

      // loop through and create ResultItem controls for each of the
      // result elements from the Live Search web service result
      ResultItemType itemType = ResultItemType.Item;
      for (int i = 0; i < count; i++)
      {
        if (separatorTemplate != null)
        {
          ResultItem separator =
          CreateResultItem(-1, ResultItemType.Separator, false, null);
          items.Add(separator);
        }

        LiveSearchService.Result searchResultItem = null;
        if (dataBind == true)
        {
          searchResultItem = result.Responses[0].Results[i];
        }

        ResultItem item = CreateResultItem(i,
          itemType, dataBind, searchResultItem);
        items.Add(item);

        // swap between item and alternatingitem types
        if (itemType == ResultItemType.Item)
          itemType = ResultItemType.AlternatingItem;
        else
          itemType = ResultItemType.Item;
      }

      // display pager if allowed by user and if results
      // are greater than a page in length
      if (DisplayPager == true && TotalResultsCount > PageSize)
      {
        ResultItem pager = CreatePagerResultItem();
        items.Add(pager);
      }

      if (FooterTemplate != null)
      {
        ResultItem footer = CreateResultItem(-1, ResultItemType.Footer,
false, null);
        items.Add(footer);
      }
    }

    private void CreateBlankControlHierarchy()
    {
      if (HeaderTemplate != null)
      {
        ResultItem headerItem = CreateResultItem(-1,
ResultItemType.Header, false, null);
        items.Add(headerItem);
      }

      if (FooterTemplate != null)
      {
        ResultItem footer = CreateResultItem(-1, ResultItemType.Footer,
false, null);
        items.Add(footer);
      }
    }

    /// <summary>
    /// Called by framework for composite controls to create control heirarchy
    /// </summary>
    override protected void CreateChildControls()
    {
      if (searchConducted == false &&
         ViewState["ResultItemCount"] != null)
      {
        CreateControlHierarchy(false);
      }
    }

    /// <summary>
    /// Binds search control results to control contents
    /// </summary>
    public override void DataBind()
    {
      base.OnDataBinding(System.EventArgs.Empty);

      Controls.Clear();
      ClearChildViewState();
      TrackViewState();

      searchConducted = true;
      CreateControlHierarchy(true);
      ChildControlsCreated = true;
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

    /// <summary>
    /// Override of base method of server controls that does rendering of HTML content
    /// between the outer div tags
    /// </summary>
    /// <param name="writer">Stream class for HTML output</param>
    protected override void RenderContents(HtmlTextWriter writer)
    {
      // if no search, create a hierarchy with header and
      // footer templates only
      if (!searchConducted)
      {
        CreateBlankControlHierarchy();
      }

      // prep all template styles
      PrepareControlHierarchy();

      // render all child controls
      base.RenderContents(writer);
    }
    #endregion
  }
}