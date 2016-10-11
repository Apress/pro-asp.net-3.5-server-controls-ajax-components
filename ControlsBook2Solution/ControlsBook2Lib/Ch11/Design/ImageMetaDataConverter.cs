// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 11 - Design-Time Support
// File: ImageMetaDataConverter.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace ControlsBook2Lib.Ch11.Design
{
  public class ImageMetaDataConverter : ExpandableObjectConverter
  {
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
      if (null == value)
      {
        return new ImageMetaData();
      }

      if (value is string)
      {
        string str = (string)value;
        if ("" == str)
        {
          return new ImageMetaData();
        }

        string[] propValues = str.Split(',');

        if (4 != propValues.Length)
        {
          throw new ArgumentException("Invalid ImageMetaData", "value");
        }

        return new ImageMetaData(Convert.ToDateTime(propValues[0]),
           (Location)TypeDescriptor.GetConverter(typeof(Location)).ConvertFromString(propValues[1]),
           (string)propValues[2],
           (string)propValues[3]);
      }
      else
        return base.ConvertFrom(context, culture, value);
    }

    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
      if (typeof(string) == sourceType)
      {
        return true;
      }
      else
        return base.CanConvertFrom(context, sourceType);
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type targetType)
    {
      if ((targetType == typeof(string)) && (value is ImageMetaData))
      {
        ImageMetaData imageMetaData = (ImageMetaData)value;
        if (imageMetaData.IsEmpty)
        {
          return String.Empty;
        }
        return String.Join(culture.TextInfo.ListSeparator,
           new string[] {
                               imageMetaData.ImageDate.ToString(),
                               imageMetaData.ImageLocation.ToString(),
                               imageMetaData.ImageLongDescription,
                               imageMetaData.PhotographerFullName});
      }

      if ((targetType == typeof(InstanceDescriptor)) && (value is ImageMetaData))
      {
        ImageMetaData metaData = (ImageMetaData)value;
        ConstructorInfo cInfo = typeof(ImageMetaData).GetConstructor(new Type[] { typeof(DateTime), typeof(Location), typeof(string), typeof(string) });
        if (cInfo != null)
        {
          object[] obj = new object[] { metaData.ImageDate, metaData.ImageLocation, metaData.ImageLongDescription, metaData.PhotographerFullName };
          return new InstanceDescriptor(cInfo, obj);
        }
      }
      return base.ConvertTo(context, culture, value, targetType);
    }

    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
      if ((destinationType == typeof(InstanceDescriptor)) || (destinationType == typeof(string)))
        return true;
      else
        return base.CanConvertTo(context, destinationType);
    }
  }
}