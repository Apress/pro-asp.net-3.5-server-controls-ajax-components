// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 6 - Server Control Templates and Themes
// File: MenuControlBuilder.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Collections;
using System.Web.UI;

namespace ControlsBook2Lib.Ch06
{
   public class MenuControlBuilder : ControlBuilder
   {
      public override Type GetChildControlType(String tagName,
         IDictionary attributes)
      {
        if (String.Compare(tagName, "data", true) == 0)
         {
            return typeof(MenuItemData);
         }

         return null;
      }

      public override void AppendLiteralString(string s)
      {
         s.Trim();
         // Ignores literals between tags.
      }
   }
}
