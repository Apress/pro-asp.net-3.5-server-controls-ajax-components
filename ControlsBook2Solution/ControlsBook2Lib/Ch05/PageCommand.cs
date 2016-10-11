// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 5 - Server Control Events
// File: PageCommand.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Lib.Ch05
{
  public enum PageDirection
  {
    Left = 0,
    Right = 1
  }

  public delegate void PageCommandEventHandler(object o, PageCommandEventArgs pce);

  public class PageCommandEventArgs
  {
    public PageCommandEventArgs(PageDirection direction)
    {
      this.direction = direction;
    }

    PageDirection direction;
    public PageDirection Direction
    {
      get { return direction; }
    }
  }
}