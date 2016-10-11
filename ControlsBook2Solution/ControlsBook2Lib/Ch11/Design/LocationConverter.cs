// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 11 - Design-Time Support
// File: LocationConverter.cs
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
  public class LocationConverter : TypeConverter
  {
    public override object ConvertFrom(ITypeDescriptorContext
       context, CultureInfo culture, object value)
    {
      if (value.GetType() == typeof(string))
      {
        string str = (string)value;

        string[] propValues =
           str.Split(',');

        if (2 != propValues.Length)
        {
          throw new ArgumentException("Invalid Location.  It must be in decimal form with N or S for latitude and E or W for longitude.  Example: 25.4N,123.3W.", "value");
        }

        //Peel off N/S for latitude and E/W for longitude
        string Lat = propValues[0];
        if ("N" == Lat.Substring(Lat.Length - 1))
        {
          string[] latParts = Lat.Split("N".ToCharArray());
          Lat = latParts[0];
        }
        if ("S" == Lat.Substring(Lat.Length - 1))
        {
          string[] latParts = Lat.Split("S".ToCharArray());
          Lat = "-" + latParts[0];
        }

        string Long = propValues[1];
        if ("W" == Long.Substring(Long.Length - 1))
        {
          string[] longParts = Long.Split("W".ToCharArray());
          Long = longParts[0];
        }
        if ("E" == Long.Substring(Long.Length - 1))
        {
          string[] longParts = Long.Split("E".ToCharArray());
          Long = "-" + longParts[0];
        }

        return new Location(Convert.ToDouble(Lat),
           Convert.ToDouble(Long));
      }
      else
        return base.ConvertFrom(context, culture, value);
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
      if (destinationType == typeof(string))
      {
        Location Loc = (Location)value;
        string Lat;
        string Long;

        //Add N/S for latitude, E/W for longitude
        if (Math.Round(Loc.Latitude) >= 0)
        {
          Lat =
             (double)Loc.Latitude + "N";
        }
        else
        {
          Lat =
             (double)Math.Abs(Loc.Latitude) + "S";
        }

        if (Math.Round(Loc.Longitude) >= 0)
        {
          Long =
             (double)Loc.Longitude + "W";
        }
        else
        {
          Long = (double)Math.Abs(Loc.Longitude) + "E";
        }

        // Display lat and long as concantenated string with
        // a comma as the separator
        return Lat + "," + Long;
      }

      if (destinationType == typeof(InstanceDescriptor))
      {
        MemberInfo memberInfo = null;
        object[] memberParameters = null;

        Location Loc = (Location)value;
        Type doubleType = typeof(double);
        memberInfo = typeof(Location).GetConstructor(new Type[] { doubleType, doubleType });
        memberParameters =
           new object[] { Loc.Latitude, Loc.Longitude };
        return new InstanceDescriptor(memberInfo, memberParameters);
      }
      return base.ConvertTo(context, culture, value, destinationType);
    }

    public override bool CanConvertTo(ITypeDescriptorContext
       context, Type destinationType)
    {
      if ((typeof(string) == destinationType) ||
         (typeof(InstanceDescriptor) == destinationType))
      {
        return true;
      }
      else
        return base.CanConvertTo(context, destinationType);
    }

    public override bool CanConvertFrom(ITypeDescriptorContext
       context, Type sourceType)
    {
      if (sourceType == typeof(string))
      {
        return true;
      }
      else
        return base.CanConvertFrom(context, sourceType);
    }
  }
}