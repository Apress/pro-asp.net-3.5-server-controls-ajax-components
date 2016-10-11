// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 7 - Server Control Data Binding
// File: EnhancedSpreadsheetControl.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace ControlsBook2Web.Ch07
{
  public partial class EnhancedSpreadSheetControl : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
        EnhancedSpreadsheetControl1.DataBind();

        SqlDataReader dr = GetCustomerDataReader();
        EnhancedSpreadsheetControl2.DataSource = dr;
        EnhancedSpreadsheetControl2.DataBind();
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

    private void FillEmployeesDataSet(DataSet ds)
    {
      SqlConnection conn =
         new SqlConnection(WebConfigurationManager.ConnectionStrings["NorthWindDB"].ConnectionString);
      conn.Open();

      SqlDataAdapter da =
         new SqlDataAdapter("SELECT EmployeeID, FirstName, LastName, Title FROM Employees WHERE EmployeeID < 5",
         conn);
      da.Fill(ds, "Employees");
      conn.Close();
    }
  }
}
