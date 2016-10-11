// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 11 - Design-Time Support
// File: ImageMetaData.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Globalization;
using System.Security.Permissions;
using System.Web;
using ControlsBook2Lib.Ch11.Design;

namespace ControlsBook2Lib.Ch11
{
  [TypeConverter(typeof(ImageMetaDataConverter)), AspNetHostingPermission(SecurityAction.LinkDemand, Level = AspNetHostingPermissionLevel.Minimal)]
   public class ImageMetaData
   {
      public ImageMetaData()
      {

      }

      public ImageMetaData(DateTime PhotoDate, Location Loc, string ImageDescription, string FullName)
      {
        PhotographerFullName = FullName;
        ImageDate = PhotoDate;
        ImageLongDescription = ImageDescription;
        ImageLocation = Loc;
      }

      [NotifyParentProperty(true),
      DescriptionAttribute("Name of the photographer who captured the image.")]
      public string PhotographerFullName {get; set;}

      [NotifyParentProperty(true),
      DescriptionAttribute("Date the image was captured.")]
      public DateTime ImageDate {get; set;}

      [NotifyParentProperty(true),
      DescriptionAttribute("Extended description of the image."),
      EditorAttribute(typeof(ControlsBook2Lib.Ch11.Design.SimpleTextEditor),
      typeof(UITypeEditor))]
      public string ImageLongDescription {get; set;}

      [NotifyParentProperty(true),
 DescriptionAttribute("GPS Location where the image was captured.")]
      public Location ImageLocation {get; set;}

      [Browsable(false)]
      public bool IsEmpty
      {
         get
         {
            return ((ImageLongDescription == null) && 
                    (PhotographerFullName == null) && 
                    (ImageDate == null));
         }
      }

      public override string ToString()
      {
         return ToString(CultureInfo.CurrentCulture);
      }

      public string ToString(CultureInfo Culture)
      {
        return string.Format(CultureInfo.CurrentCulture, "[{0}: Date={1}, LongDescription={2}, PhotographerName={3}]", new object[] { base.GetType().Name, this.ImageDate.ToShortDateString(), this.ImageLongDescription, this.PhotographerFullName });
      }
   }
}