// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 10 - Other Server Controls
// File: CustomerInfoWebPart.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Web.Ch10
{
  public partial class CustomerInfoWebPart : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected override void OnPreRender(EventArgs e)
    {
      base.OnPreRender(e);

      // Set properties on verbs.
      connectionsZone1.CancelVerb.Description =
        "Terminates the connection process";
      connectionsZone1.CloseVerb.Description =
        "Closes the connections UI";
      connectionsZone1.ConfigureVerb.Description =
        "Configure the transformer for the connection";
      connectionsZone1.ConnectVerb.Description =
        "Connect two WebPart controls";
      connectionsZone1.DisconnectVerb.Description =
        "End the connection between two controls";

      // Set properties for UI text strings.
      connectionsZone1.ConfigureConnectionTitle =
        "Configure";
      connectionsZone1.ConnectToConsumerInstructionText =
        "Choose a consumer connection point";
      connectionsZone1.ConnectToConsumerText =
        "Select a consumer for the provider to connect with";
      connectionsZone1.ConnectToConsumerTitle =
        "Send data to this consumer";
      connectionsZone1.ConnectToProviderInstructionText =
        "Choose a provider connection point";
      connectionsZone1.ConnectToProviderText =
        "Select a provider for the consumer to connect with";
      connectionsZone1.ConnectToProviderTitle =
        "Get data from this provider";
      connectionsZone1.ConsumersInstructionText =
        "WebPart controls that receive data from providers";
      connectionsZone1.ConsumersTitle = "Consumer Controls";
      connectionsZone1.GetFromText = "Receive from";
      connectionsZone1.GetText = "Retrieve";
      connectionsZone1.HeaderText =
       "Create and Manage Connections";
      connectionsZone1.InstructionText =
       "Manage connections for the selected WebPart control";
      connectionsZone1.InstructionTitle =
        "Manage connections for consumers or providers";
      connectionsZone1.NoExistingConnectionInstructionText =
        "No connections exist. Click the above link to create "
        + "a connection.";
      connectionsZone1.NoExistingConnectionTitle =
        "No current connections";
      connectionsZone1.ProvidersInstructionText =
        "WebPart controls that send data to consumers";
      connectionsZone1.ProvidersTitle = "Provider controls";
    }
  }
}