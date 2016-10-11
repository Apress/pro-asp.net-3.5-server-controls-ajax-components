// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 6 - Server Control Templates and Themes
// File: TagDataMenu.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch06
{
  // PaseChildren attribute tells the ASP.NET page parser to treat 
  // child content as items to be added to a collection.
  [ParseChildren(true, "MenuItems")]
  [ToolboxData("<{0}:tagdatamenu runat=server></{0}:tagdatamenu>")]
  public class TagDataMenu : CompositeControl
  {
    public TagDataMenu()
      : base()
    {
    }

    private List<MenuItemData> menuData = new List<MenuItemData>();

    // This collection is automatically populated by ASP.NET because of the
    // ParseChildren attribute on the class
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
    Description("Collection of MenuItemData objects for display"),
    PersistenceMode(PersistenceMode.InnerDefaultProperty), NotifyParentProperty(true)]

    public List<MenuItemData> MenuItems
    {
      get
      {
        if (menuData == null)
        {
          menuData = new List<MenuItemData>();
        }
        return menuData;
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

    override protected void CreateChildControls()
    {
      Controls.Clear();
      CreateControlHierarchy();
    }

    private void CreateControlHierarchy()
    {
      int count = MenuItems.Count;
      for (int index = 0; index < count; index++)
      {
        MenuItemData itemdata = (MenuItemData)MenuItems[index];
        CreateMenuItem(itemdata.Title, itemdata.Url, itemdata.ImageUrl, itemdata.Target);

        if ((count > 1) && (index < count - 1))
        {
          Controls.Add(new LiteralControl(" | "));
        }
      }
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