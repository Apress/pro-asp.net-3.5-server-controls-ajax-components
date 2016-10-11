// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 7 - Server Control Data Binding
// File: Repeater.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch07
{
  [ToolboxData("<{0}:repeater runat=server></{0}:repeater>"), ParseChildren(true), PersistChildren(false),
 Designer(typeof(ControlsBook2Lib.Ch11.Design.RepeaterDesigner))]
  public class Repeater : DataBoundControl, INamingContainer
  {
    #region Template Code
    private ITemplate headerTemplate;
    [Browsable(false), TemplateContainer(typeof(RepeaterItem)),
    PersistenceMode(PersistenceMode.InnerProperty)]
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

    private ITemplate footerTemplate;
    [Browsable(false), TemplateContainer(typeof(RepeaterItem)),
    PersistenceMode(PersistenceMode.InnerProperty)]
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

    private ITemplate itemTemplate;
    [Browsable(false), TemplateContainer(typeof(RepeaterItem)),
    PersistenceMode(PersistenceMode.InnerProperty)]
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

    private ITemplate alternatingItemTemplate;
    [Browsable(false), TemplateContainer(typeof(RepeaterItem)),
    PersistenceMode(PersistenceMode.InnerProperty)]
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

    private ITemplate separatorTemplate;
    [Browsable(false), TemplateContainer(typeof(RepeaterItem)),
    PersistenceMode(PersistenceMode.InnerProperty)]
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

    private RepeaterItem CreateItem(int itemIndex, ListItemType itemType, bool dataBind, object dataItem)
    {
      ITemplate selectedTemplate;

      switch (itemType)
      {
        case ListItemType.Header:
          selectedTemplate = headerTemplate;
          break;
        case ListItemType.Item:
          selectedTemplate = itemTemplate;
          break;
        case ListItemType.AlternatingItem:
          selectedTemplate = alternatingItemTemplate;
          break;
        case ListItemType.Separator:
          selectedTemplate = separatorTemplate;
          break;
        case ListItemType.Footer:
          selectedTemplate = footerTemplate;
          break;
        default:
          selectedTemplate = null;
          break;
      }

      if ((itemType == ListItemType.AlternatingItem) &&
         (alternatingItemTemplate == null))
      {
        selectedTemplate = itemTemplate;
        itemType = ListItemType.Item;
      }

      RepeaterItem item = new RepeaterItem(itemIndex, itemType, dataItem);

      if (selectedTemplate != null)
      {
        selectedTemplate.InstantiateIn(item);
      }

      OnItemCreated(new RepeaterItemEventArgs(item));

      Controls.Add(item);

      if (dataBind)
      {
        item.DataBind();
        OnItemDataBound(new RepeaterItemEventArgs(item));
      }
      return item;
    }
    #endregion

    [Browsable(false)]
    public List<RepeaterItem> Items
    {
      get
      {
        EnsureChildControls();
        return items;
      }
    }

    protected override void PerformSelect()
    {
      // Call OnDataBinding here if bound to a data source using the
      // DataSource property (instead of a DataSourceID), because the
      // databinding statement is evaluated before the call to GetData.       
      if (!IsBoundUsingDataSourceID)
      {
        OnDataBinding(EventArgs.Empty);
      }

      // The GetData method retrieves the DataSourceView object from  
      // the IDataSource associated with the data-bound control.            
      GetData().Select(CreateDataSourceSelectArguments(),
          OnDataSourceViewSelectCallback);

      // The PerformDataBinding method has completed.
      RequiresDataBinding = false;
      MarkAsDataBound();

      // Raise the DataBound event.
      OnDataBound(EventArgs.Empty);
    }

    private void OnDataSourceViewSelectCallback(IEnumerable retrievedData)
    {

      // Call OnDataBinding only if it has not already been 
      // called in the PerformSelect method.
      if (IsBoundUsingDataSourceID)
      {
        OnDataBinding(EventArgs.Empty);
      }
      // The PerformDataBinding method binds the data in the  
      // retrievedData collection to elements of the data-bound control.
      PerformDataBinding(retrievedData);
    }

    protected override void PerformDataBinding(IEnumerable data)
    {
      base.PerformDataBinding(data);

      Controls.Clear();
      ClearChildViewState();
      TrackViewState();

      if (IsBoundUsingDataSourceID)
        CreateControlHierarchy(true, true, data);
      else
        CreateControlHierarchy(true, false, data);
      ChildControlsCreated = true;
    }


    protected override void ValidateDataSource(object dataSource)
    {
      if (((dataSource != null) && !(dataSource is IListSource)) &&
         (!(dataSource is IEnumerable) && !(dataSource is IDataSource)))
      {
        throw new InvalidOperationException();
      }
    }

    public override void DataBind()
    {
      this.PerformSelect();
    }

    private List<RepeaterItem> items;  //privite collection backing Items property
    private void CreateControlHierarchy(bool useData, bool usingIDataSource, IEnumerable data)
    {
      items = new List<RepeaterItem>();
      IEnumerable ds = null;

      if (HeaderTemplate != null)
      {
        RepeaterItem header = CreateItem(-1, ListItemType.Header, false, null);
      }

      int count = -1;
      if (useData)
      {
        if (!usingIDataSource)
          ds = (IEnumerable)DataSourceHelper.ResolveDataSource(DataSource,
           DataMember);
        else
          ds = data;
      }
      else
      {
        count = (int)ViewState["ItemCount"];
        if (count != -1)
        {
          ds = new DummyDataSource(count);
        }
      }

      if (ds != null)
      {
        int index = 0;
        count = 0;
        RepeaterItem item;
        ListItemType itemType = ListItemType.Item;

        foreach (object dataItem in (IEnumerable)ds)
        {
          if (index != 0)
          {
            RepeaterItem separator = CreateItem(-1, ListItemType.Separator, false, null);
          }

          item = CreateItem(index, itemType, useData, dataItem);
          items.Add(item);
          index++;
          count++;

          if (itemType == ListItemType.Item)
            itemType = ListItemType.AlternatingItem;
          else
            itemType = ListItemType.Item;
        }
      }

      if (FooterTemplate != null)
      {
        RepeaterItem footer = CreateItem(-1, ListItemType.Footer, false, null);
      }

      if (useData)
      {
        ViewState["ItemCount"] = ((ds != null) ? count : -1);
      }
    }

    override protected void CreateChildControls()
    {
      Controls.Clear();
      if (ViewState["ItemCount"] != null)
      {
        CreateControlHierarchy(false, false, null);
      }
      ClearChildViewState();
    }

    public override ControlCollection Controls
    {
      get
      {
        EnsureChildControls();
        return base.Controls;
      }
    }

    private static readonly object ItemCommandKey = new object();
    public event RepeaterCommandEventHandler ItemCommand
    {
      add
      {
        Events.AddHandler(ItemCommandKey, value);
      }
      remove
      {
        Events.RemoveHandler(ItemCommandKey, value);
      }
    }

    private static readonly object ItemCreatedKey = new object();
    public event RepeaterItemEventHandler ItemCreated
    {
      add
      {
        Events.AddHandler(ItemCreatedKey, value);
      }
      remove
      {
        Events.RemoveHandler(ItemCreatedKey, value);
      }
    }

    private static readonly object ItemDataBoundKey = new object();
    public event RepeaterItemEventHandler ItemDataBound
    {
      add
      {
        Events.AddHandler(ItemDataBoundKey, value);
      }
      remove
      {
        Events.RemoveHandler(ItemDataBoundKey, value);
      }
    }

    protected override bool OnBubbleEvent(object source, EventArgs e)
    {
      RepeaterCommandEventArgs rce = e as RepeaterCommandEventArgs;

      if (rce != null)
      {
        OnItemCommand(rce);
        return true;
      }
      else
        return false;
    }

    protected virtual void OnItemCommand(RepeaterCommandEventArgs rce)
    {
      RepeaterCommandEventHandler repeaterCommandEventDelegate =
         (RepeaterCommandEventHandler)Events[ItemCommandKey];
      if (repeaterCommandEventDelegate != null)
      {
        repeaterCommandEventDelegate(this, rce);
      }
    }

    protected virtual void OnItemCreated(RepeaterItemEventArgs rie)
    {
      RepeaterItemEventHandler repeaterItemEventDelegate =
         (RepeaterItemEventHandler)Events[ItemCreatedKey];
      if (repeaterItemEventDelegate != null)
      {
        repeaterItemEventDelegate(this, rie);
      }
    }

    protected virtual void OnItemDataBound(RepeaterItemEventArgs rie)
    {
      RepeaterItemEventHandler repeaterItemEventDelegate =
         (RepeaterItemEventHandler)Events[ItemDataBoundKey];
      if (repeaterItemEventDelegate != null)
      {
        repeaterItemEventDelegate(this, rie);
      }
    }
  }
}