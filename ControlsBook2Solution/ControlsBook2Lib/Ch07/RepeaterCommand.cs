// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 7 - Server Control Data Binding
// File: RepeaterCommand.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch07
{
   public delegate void RepeaterCommandEventHandler(object o, RepeaterCommandEventArgs rce);

   public class RepeaterCommandEventArgs : CommandEventArgs
   {
      public RepeaterCommandEventArgs(RepeaterItem item, object commandSource,
         CommandEventArgs originalArgs) : base(originalArgs)
      {
         this.item = item;
         this.commandSource = commandSource;
      }

      private RepeaterItem item;
      public RepeaterItem Item
      {
         get
         {
            return item;
         }
      }

      private object commandSource;
      public object CommandSource
      {
         get
         {
            return commandSource;
         }
      }
   }
}
