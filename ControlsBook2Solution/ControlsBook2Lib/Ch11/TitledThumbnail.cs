// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 11 - Design-Time Support
// File: TitledThumbnail.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using ControlsBook2Lib.Ch11.Design;

namespace ControlsBook2Lib.Ch11
{
  public enum TitleAlignment { center, justify, left, right };

  [ToolboxData("<{0}:TitledThumbnail runat=server></{0}:TitledThumbnail>"),
  EditorAttribute(typeof(TitledThumbnailComponentEditor), typeof(ComponentEditor)),
  Designer(typeof(TitledThumbnailDesigner)),
  DefaultProperty("ImageUrl")]
  public class TitledThumbnail : WebControl
  {
    private Image imgThumbnail;
    private Label lblTitle;
    private ImageMetaData metaData;

    public TitledThumbnail()
      : base(HtmlTextWriterTag.Div)
    {

    }

    [DescriptionAttribute("Text to be shown as the image caption."),
    CategoryAttribute("Appearance")]
    public string Title
    {
      get
      {
        EnsureChildControls();
        object title = ViewState["title"];
        return (title == null) ? "" : (string)title;
      }
      set
      {
        EnsureChildControls();
        lblTitle.Text = value;
        ViewState["title"] = value;
      }
    }

    [DescriptionAttribute("The Url of the image to be shown."),
    CategoryAttribute("Appearance")]
    public string ImageUrl
    {
      get
      {
        EnsureChildControls();
        object imageUrl = ViewState["imageUrl"];
        return (imageUrl == null) ? "" : (string)imageUrl;
      }
      set
      {
        EnsureChildControls();
        imgThumbnail.ImageUrl = value;
        ViewState["imageUrl"] = value;
      }
    }

    [DescriptionAttribute("Set the alignment for the Image and Title."),
    CategoryAttribute("Layout"), DefaultValue("center")]
    public TitleAlignment Align
    {
      get
      {
        EnsureChildControls();
        object align = ViewState["align"];
        return (align == null) ? TitleAlignment.left : (TitleAlignment)align;
      }
      set
      {
        EnsureChildControls();
        this.Attributes.Add("align", Enum.GetName(typeof(TitleAlignment), value));
        ViewState["align"] = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
    NotifyParentProperty(true), CategoryAttribute("MetaData"),
    DescriptionAttribute("Meta data that stores information about the displayed photo image.")]
    public ImageMetaData ImageInfo
    {
      get
      {
        EnsureChildControls();
        if (metaData == null)
        {
          metaData = new ImageMetaData();
        }
        return metaData;
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

    protected override void CreateChildControls()
    {
      Controls.Clear();

      HtmlGenericControl divImageContainer = new HtmlGenericControl("div");
      divImageContainer.ID = "imageDiv";
      imgThumbnail = new Image();
      divImageContainer.Controls.Add(imgThumbnail);
      this.Controls.Add(divImageContainer);
      HtmlGenericControl divSpacer = new HtmlGenericControl("div");
      divSpacer.ID = "divSpacer";
      divSpacer.Attributes.Add("style", "margin:3px;");
      this.Controls.Add(divSpacer);
      lblTitle = new Label();
      lblTitle.ID = "imageTitle";
      lblTitle.ForeColor = System.Drawing.Color.White;
      this.Controls.Add(lblTitle);
    }

    protected override void AddAttributesToRender(HtmlTextWriter writer)
    {
      writer.AddAttribute(HtmlTextWriterAttribute.Align, "center");

      writer.AddStyleAttribute(HtmlTextWriterStyle.BackgroundColor, "#2666A5");
      writer.AddStyleAttribute(HtmlTextWriterStyle.Width, "94px");
      writer.AddStyleAttribute(HtmlTextWriterStyle.Height, "88px");
      writer.AddStyleAttribute(HtmlTextWriterStyle.BorderColor, "silver");
      writer.AddStyleAttribute(HtmlTextWriterStyle.BorderStyle, "ridge");
      writer.AddStyleAttribute(HtmlTextWriterStyle.BorderWidth, "4px");
      writer.AddStyleAttribute(HtmlTextWriterStyle.FontSize, "XX-Small");
      writer.AddStyleAttribute(HtmlTextWriterStyle.FontFamily, "Tahoma");

      base.AddAttributesToRender(writer);
    }
  }
}