// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 7 - Server Control Data Binding
// File: AdvancedRepeater.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Web.Ch07
{
  public partial class AdvancedRepeater : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      status.Text = "";
      if (!Page.IsPostBack)
      {
        SqlDataReader dr = GetCustomerDataReader();
        repeaterRdrCust.DataSource = dr;
        repeaterRdrCust.DataBind();
        dr.Close();
      }
    }

    private SqlDataReader GetCustomerDataReader()
    {
      SqlConnection conn =
         new SqlConnection(WebConfigurationManager.ConnectionStrings["NorthWindDB"].ConnectionString);
      conn.Open();

      SqlCommand cmd =
         new SqlCommand("SELECT CustomerID, ContactName, ContactTitle, CompanyName FROM Customers WHERE CustomerID LIKE '[AB]%'",
         conn);
      SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
      return dr;
    }

    protected void repeaterRdrCust_ItemCommand(object o, ControlsBook2Lib.Ch07.RepeaterCommandEventArgs rce)
    {
      ControlsBook2Lib.Ch07.RepeaterItem item = rce.Item;
      Label lblID = (Label)item.FindControl("lblID");
      status.Text = lblID.Text + " was clicked!";
    }

    protected void repeaterRdrCust_ItemDataBound(object o, ControlsBook2Lib.Ch07.RepeaterItemEventArgs rie)
    {
      ControlsBook2Lib.Ch07.RepeaterItem item = rie.Item;
      DbDataRecord row = (DbDataRecord)item.DataItem;
      string ID = (string)row["CustomerID"];
      Label lblID = (Label)item.FindControl("lblID");
      lblID.Text = ID;
    }

    protected void repeaterRdrCust_ItemCreated(object o, ControlsBook2Lib.Ch07.RepeaterItemEventArgs rie)
    {
      ControlsBook2Lib.Ch07.RepeaterItem item = rie.Item;
      if (item.ItemType == ListItemType.Item)
      {
        Label lblID = new Label();
        lblID.ID = "lblID";
        item.Controls.Add(lblID);
        item.Controls.Add(new LiteralControl("&nbsp;"));
      }
    }
  }
}
