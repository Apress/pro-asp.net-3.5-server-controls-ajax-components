// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 6 - Server Control Templates and Themes
// File: BuilderMenu.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch06
{
  [ParseChildren(false)]
  [ControlBuilder(typeof(MenuControlBuilder))]
  [ToolboxData("<{0}:buildermenu runat=server></{0}:buildermenu>")]
  public class BuilderMenu : CompositeControl
  {
    public BuilderMenu()
      : base()
    {
    }

    private ArrayList menuData = new ArrayList();
    public ArrayList MenuItems
    {
      get
      {
        return menuData;
      }
    }

    protected override void AddParsedSubObject(Object obj)
    {
      if (obj is MenuItemData)
      {
        menuData.Add(obj);
      }
    }

    private void CreateMenuItem(string title, string url, string target, string imageUrl)
    {
      HyperLink link = new HyperLink();
      link.Text = title;
      link.NavigateUrl = url;
      link.ImageUrl = imageUrl;
      link.Target = target;
      Controls.Add(link);
    }

    private void CreateControlHierarchy()
    {
      int count = menuData.Count;
      for (int index = 0; index < count; index++)
      {
        MenuItemData itemdata = (MenuItemData)menuData[index];
        CreateMenuItem(itemdata.Title, itemdata.Url,
           itemdata.ImageUrl, itemdata.Target);

        if ((count > 1) && (index < count - 1))
        {
          Controls.Add(new LiteralControl(" | "));
        }
      }
    }

    override protected void CreateChildControls()
    {
      CreateControlHierarchy();
    }

    public override ControlCollection Controls
    {
      get
      {
        EnsureChildControls();
        return base.Controls;
      }
    }
  }
}