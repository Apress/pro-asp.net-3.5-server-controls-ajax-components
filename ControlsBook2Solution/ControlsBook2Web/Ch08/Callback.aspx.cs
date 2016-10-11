// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 8 - Integrating Client-Side Script
// File: Callback.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace ControlsBook2Web.Ch08
{
  public partial class Callback : System.Web.UI.Page, ICallbackEventHandler
  {
    private List<Vehicle> cbVehicles;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (!Page.IsPostBack)
      {
        LoadVehicleListBoxes();
      }
    }

    private void RenderScripts()
    {

      CbCategoryDrp.Attributes.Add("onChange",
       "GetVehicles(this.options[this.selectedIndex].value)");

      string clientRecFunc = @"
            function LoadVehicles(results, context)
            {
                var vehLst = document.getElementById('$list');
                vehLst.innerHTML = '';
                    
                var cars = results.split(';');
                for (var i = 0; i < cars.length-1; i++)
                {
                    var values = cars[i].split(':');
                    var option = document.createElement('option');
                    option.value = values[0];
                    option.innerHTML = values[1];
                    vehLst.appendChild(option);
                }
            }";

      Page.ClientScript.RegisterClientScriptBlock(this.GetType(),
          "LoadVehicles", clientRecFunc.Replace("$list", CbVehicleLst.ClientID), true);

      string callBack = Page.ClientScript.GetCallbackEventReference(
          this, "category", "LoadVehicles", null);

      string clientCallFunc = "function GetVehicles(category){ " + callBack + "; }\n";
      Page.ClientScript.RegisterClientScriptBlock(this.GetType(),
          "GetVehicles", clientCallFunc, true);
    }

    private void LoadVehicleListBoxes()
    {
      VehicleLst.DataSource = GetVehiclesByCategory(CategoryDrp.SelectedValue);
      VehicleLst.DataBind();

      CbVehicleLst.DataSource = GetVehiclesByCategory(CbCategoryDrp.SelectedValue);
      CbVehicleLst.DataBind();

      RenderScripts();
    }

    protected void CategoryDrp_SelectedIndexChanged(object sender, EventArgs e)
    {
      LoadVehicleListBoxes();
    }


    private List<Vehicle> GetVehiclesByCategory(string category)
    {
      List<Vehicle> vehicles = new List<Vehicle>();

      switch (category)
      {
        case "Car":
          vehicles.Add(new Vehicle("Camaro", "Chevrolet Camaro"));
          vehicles.Add(new Vehicle("Charger", "Dodge Charger"));
          vehicles.Add(new Vehicle("Mustang", "Ford Mustang"));
          break;
        case "Truck":
          vehicles.Add(new Vehicle("Silverado", "Chevrolet Silverado"));
          vehicles.Add(new Vehicle("Ram", "Dodge"));
          vehicles.Add(new Vehicle("F150", "Ford F150"));
          break;
        case "SUV":
          vehicles.Add(new Vehicle("Yukon", "Chevrolet Yukon"));
          vehicles.Add(new Vehicle("Durango", "Dodge Durango"));
          vehicles.Add(new Vehicle("Expedition", "Ford Expedition"));
          break;
      }
      return vehicles;
    }
    #region ICallbackEventHandler Members

    public string GetCallbackResult()
    {
      string result = "";
      foreach (Vehicle veh in cbVehicles)
      {
        result += veh.Name + ":" + veh.Description + ";";
      }
      return result;
    }

    public void RaiseCallbackEvent(string eventArgument)
    {
      cbVehicles = GetVehiclesByCategory(eventArgument);
    }
    #endregion
  }

  public class Vehicle
  {
    public Vehicle(string name, string description)
    {
      Name = name;
      Description = description;
    }

    public string Name {get; set;}

    public string Description {get; set;}
  }
}