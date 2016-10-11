// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 7 - Server Control Data Binding
// File: DynamicTemplates.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using ControlsBook2Lib.Ch07;

namespace ControlsBook2Web.Ch07
{
  public partial class DynamicTemplates : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      LoadRepeater();
    }

    private void LoadRepeater()
    {
      string templateName = templateList.SelectedItem.Text;
      if (templateName.IndexOf(".ascx") > 0)
      {
        repeaterRdrCust.ItemTemplate = Page.LoadTemplate(templateName);
      }
      else
      {
        repeaterRdrCust.HeaderTemplate = new CustCodeHeaderTemplate();

        repeaterRdrCust.ItemTemplate = new CustCodeItemTemplate(true);

        repeaterRdrCust.AlternatingItemTemplate = new CustCodeItemTemplate(false);

        repeaterRdrCust.FooterTemplate = new CustCodeFooterTemplate();
      }

      SqlDataReader dr = GetCustomerDataReader();
      repeaterRdrCust.DataSource = dr;
      repeaterRdrCust.DataBind();
      dr.Close();
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
  }
}