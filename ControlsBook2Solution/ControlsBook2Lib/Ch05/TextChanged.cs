// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 5 - Server Control Events
// File: TextChanged.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Lib.Ch05
{
  public delegate void TextChangedEventHandler(object o, TextChangedEventArgs tce);

  public class TextChangedEventArgs : EventArgs
  {
    private string oldValue;
    private string newValue;

    public TextChangedEventArgs(string oldValue, string newValue)
    {
      this.oldValue = oldValue;
      this.newValue = newValue;
    }

    public string OldValue
    {
      get
      {
        return oldValue;
      }
    }

    public string NewValue
    {
      get
      {
        return newValue;
      }
    }
  }
}