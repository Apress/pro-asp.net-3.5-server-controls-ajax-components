using System.Collections;
using System.ComponentModel;
// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 6 - Server Control Templates and Themes
// File: TempateMenu.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Web.UI;
using System.Web.UI.WebControls;
using ControlsBook2Lib.Ch11.Design;

namespace ControlsBook2Lib.Ch06
{
  [ToolboxData("<{0}:templatemenu runat=server></{0}:templatemenu>"),
  Designer(typeof(TemplateMenuDesigner))]
  public class TemplateMenu : CompositeControl
  {
    private ArrayList menuData;
    public TemplateMenu()
      : base()
    {
      menuData = new ArrayList()  //Uses new C# 3.0 Object and Collection Initializers
      {
        new MenuItemData{Title="Apress", Url="http://www.apress.com"},
        new MenuItemData{Title="Microsoft", Url="http://www.microsoft.com"},
        new MenuItemData{Title="ASP.Net", Url="http://asp.net"}
      };
    }

    private ITemplate headerTemplate;
    [Browsable(false), Description("The header template"), PersistenceMode(PersistenceMode.InnerProperty),
    TemplateContainer(typeof(BasicTemplateContainer))]
    public ITemplate HeaderTemplate
    {
      get
      {
        return headerTemplate;
      }
      set
      {
        headerTemplate = value;
      }
    }

    private ITemplate footerTemplate;
    [Browsable(false), Description("The footer template"), PersistenceMode(PersistenceMode.InnerProperty),
    TemplateContainer(typeof(BasicTemplateContainer))]
    public ITemplate FooterTemplate
    {
      get
      {
        return footerTemplate;
      }
      set
      {
        footerTemplate = value;
      }
    }

    private ITemplate separatorTemplate;
    [Browsable(false), Description("The separator template"), PersistenceMode(PersistenceMode.InnerProperty),
   TemplateContainer(typeof(SeperatorTemplateContainer))]
    public ITemplate SeparatorTemplate
    {
      get
      {
        return separatorTemplate;
      }
      set
      {
        separatorTemplate = value;
      }
    }

    private void CreateControlHierarchy()
    {
      if (HeaderTemplate != null)
      {
        BasicTemplateContainer header = new BasicTemplateContainer();
        HeaderTemplate.InstantiateIn(header);
        Controls.Add(header);
      }

      int count = menuData.Count;
      for (int index = 0; index < count; index++)
      {
        MenuItemData itemdata = (MenuItemData)menuData[index];

        HyperLink link = new HyperLink() { Text = itemdata.Title, NavigateUrl = itemdata.Url, ImageUrl = itemdata.ImageUrl, Target = itemdata.Target };
        Controls.Add(link);

        if (index != count - 1)
        {
          if (SeparatorTemplate != null)
          {
            SeperatorTemplateContainer separator = new SeperatorTemplateContainer();
            SeparatorTemplate.InstantiateIn(separator);
            Controls.Add(separator);
          }
          else
          {
            Controls.Add(new LiteralControl(" | "));
          }
        }
      }

      if (FooterTemplate != null)
      {
        BasicTemplateContainer footer = new BasicTemplateContainer();
        FooterTemplate.InstantiateIn(footer);
        Controls.Add(footer);
      }
    }

    override protected void CreateChildControls()
    {
      Controls.Clear();
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

    public override void DataBind()
    {
      CreateChildControls();
      ChildControlsCreated = true;

      base.DataBind();
    }
  }
}