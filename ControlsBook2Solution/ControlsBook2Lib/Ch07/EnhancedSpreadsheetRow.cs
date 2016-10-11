// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 7 - Server Control Data Binding
// File: EnhancedSpreadsheetRow.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch07
{
  public class EnhancedSpreadsheetRow : TableRow, IDataItemContainer
  {
    private object data;
    private int _itemIndex;

    public EnhancedSpreadsheetRow(int itemIndex, object o, bool dataBinding)
    {
      if (dataBinding)
      {
        data = o;
        _itemIndex = itemIndex;
      }
    }

    public virtual object Data
    {
      get
      {
        return data;
      }
    }

    object IDataItemContainer.DataItem
    {
      get
      {
        return Data;
      }
    }

    int IDataItemContainer.DataItemIndex
    {
      get
      {
        return _itemIndex;
      }
    }

    int IDataItemContainer.DisplayIndex
    {
      get
      {
        return _itemIndex;
      }
    }
  }
}
