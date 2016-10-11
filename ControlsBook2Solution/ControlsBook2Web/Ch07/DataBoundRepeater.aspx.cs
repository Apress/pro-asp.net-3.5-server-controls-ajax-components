// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 7 - Server Control Data Binding
// File: DataBoundRepeater.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace ControlsBook2Web.Ch07
{
  public partial class DataBoundRepeater : System.Web.UI.Page
  {
    protected System.Data.SqlClient.SqlDataAdapter dataAdapterEmp;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
    protected DataSetEmp dataSetEmp;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (!Page.IsPostBack)
      {
        string[] array = new String[] { "one", "two", "three" };
        repeaterA.DataSource = array;
        repeaterA.DataBind();

        ArrayList list = new ArrayList();
        list.Add("four");
        list.Add("five");
        list.Add("six");
        repeaterAl.DataSource = list;
        repeaterAl.DataBind();

        SqlDataReader dr = GetCustomerDataReader();
        repeaterRdrCust.DataSource = dr;
        repeaterRdrCust.DataBind();
        dr.Close();

        DataSet ds = new DataSet();
        FillEmployeesDataSet(ds);

        repeaterDtEmp.DataSource = ds;
        repeaterDtEmp.DataMember = "Employees";
        repeaterDtEmp.DataBind();
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
