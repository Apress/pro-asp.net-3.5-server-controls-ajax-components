// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 11 - Design-Time Support
// File: Location.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.ComponentModel;
using System.Globalization;
using ControlsBook2Lib.Ch11.Design;

namespace ControlsBook2Lib.Ch11
{
  [Serializable,TypeConverter(typeof(LocationConverter))]
   public class Location
   {
      public Location()
      {
         Latitude = 0;
         Longitude = 0;
      }

      public Location(double Lat, double Long)
      {
         Latitude = Lat;
         Longitude = Long;
      }

      public double Latitude {get; set;}

      public double Longitude { get; set; }

      public bool IsEmpty
      {
         get
         {
            return (Latitude == 0 && Longitude == 0);
         }
      }

      //override ToString so that it displays the values of
      //its members as opposed to its fully qualified type.
      public override string ToString()
      {
         return ToString(CultureInfo.CurrentCulture);
      }

      public string ToString(CultureInfo Culture)
      {
        string Lat;
        string Long;
        TypeConverter DoubleConverter =
             TypeDescriptor.GetConverter(typeof(double));

        //Add N/S for latitude, E/W for longitude
        if (Math.Round(this.Latitude) >= 0)
        {
          Lat =
             DoubleConverter.ConvertToString(null,
             Culture, this.Latitude) + "N";
        }
        else
        {
          Lat =
             DoubleConverter.ConvertToString(null,
             Culture, Math.Abs(this.Latitude)) + "S";
        }

        if (Math.Round(this.Longitude) >= 0)
        {
          Long =
             DoubleConverter.ConvertToString(null,
             Culture, this.Longitude) + "W";
        }
        else
        {
          Long = DoubleConverter.ConvertToString(null,
             Culture, Math.Abs(this.Longitude)) + "E";
        }

        // Display lat and long as concantenated string with
        // a comma as the separator based on the current culture
        return String.Join(Culture.TextInfo.ListSeparator,
           new string[] { Lat, Long });
      }

      public override bool Equals(object obj)
      {
         Location Loc = (Location) obj;

         if (Loc != null)
         {
            return (Latitude == Loc.Latitude &&
               Longitude == Loc.Longitude);
         }
         return false;
      }

      public override int GetHashCode()
      {
         //XOR the latitude and logitude coordinates
         return Latitude.GetHashCode() ^ Longitude.GetHashCode();
      }
   }
}