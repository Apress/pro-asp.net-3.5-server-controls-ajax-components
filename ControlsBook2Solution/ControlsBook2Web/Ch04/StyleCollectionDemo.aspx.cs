// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 4 - WebControl Base Class and Control Styles
// File: StyleCollectionDemo.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Web.UI.WebControls;

namespace ControlsBook2Web.Ch04
{
  public partial class StyleCollectionDemo : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        MenuItemStyle alterStyle = new MenuItemStyle();
        alterStyle.BackColor = System.Drawing.Color.Navy;
        alterStyle.ForeColor = System.Drawing.Color.Gold;

        // Remove the last of the three menu item styles. Note that
        // since the collection has a zero-based index, the third
        // entry has an index value of 2.
        MainMenuID.LevelMenuItemStyles.RemoveAt(2);
        MainMenuID.LevelMenuItemStyles.Add(alterStyle);
      }
    }
  }
}