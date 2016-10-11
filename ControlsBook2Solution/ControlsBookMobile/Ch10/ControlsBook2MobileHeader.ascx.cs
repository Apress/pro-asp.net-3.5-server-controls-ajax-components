// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 10 - Other Server Controls
// File: ControlsBook2MobileHeader.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Mobile.Ch10
{
  public partial class ControlsBook2MobileHeader : System.Web.UI.MobileControls.MobileUserControl
  {

    //private members
    private string bookChapterTitle;
    private int chapterNumber;

    protected void Page_Load(object sender, System.EventArgs e)
    {
      Label1.Text = "Chapter " + chapterNumber.ToString();
      Label4.Text = bookChapterTitle;
    }

    //properties
    public String ChapterTitle
    {
      get
      {
        return bookChapterTitle;
      }
      set
      {
        bookChapterTitle = value;
      }
    }

    public int ChapterNumber
    {
      get
      {
        return chapterNumber;
      }
      set
      {
        chapterNumber = value;
      }
    }
  }
}