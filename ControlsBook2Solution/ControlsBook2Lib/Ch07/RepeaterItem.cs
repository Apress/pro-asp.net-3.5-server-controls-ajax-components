// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 7 - Server Control Data Binding
// File: RepeaterItem.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch07
{
   public class RepeaterItem : Control, INamingContainer
   {
      [ToolboxItem(false)]
      public RepeaterItem(int itemIndex, ListItemType itemType, object dataItem)
      {
         this.itemIndex = itemIndex;
         this.itemType = itemType;
         this.DataItem = dataItem;
      }

      public object DataItem { get; set; }

      private int itemIndex;
      public int ItemIndex
      {
         get
         {
            return itemIndex;
         }
      }

      private ListItemType itemType;
      public ListItemType ItemType
      {
         get
         {
            return itemType;
         }
      }

      protected override bool OnBubbleEvent(object source, EventArgs e)
      {
         CommandEventArgs ce = e as CommandEventArgs;

         if (ce != null)
         {
            RepeaterCommandEventArgs rce = new RepeaterCommandEventArgs(this, source, ce);
            RaiseBubbleEvent(this, rce);

            return true;
         }
         else
            return false;
      }
   }

   public delegate void RepeaterItemEventHandler(object o, RepeaterItemEventArgs rie);

   public class RepeaterItemEventArgs : EventArgs
   {
      public RepeaterItemEventArgs(RepeaterItem item)
      {
         this.item = item;
      }

      private RepeaterItem item;
      public RepeaterItem Item
      {
         get
         {
            return item;
         }
      }
   }
}
