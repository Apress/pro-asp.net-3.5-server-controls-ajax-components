// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 10 - Other Server Controls
// File: CustomerListWebPart.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ControlsBook2Lib.Ch10
{
  [ToolboxData("<{0}:CustomerListWebPart runat=server></{0}:CustomerListWebPart>")]
  public class CustomerListWebPart : WebPart, ICustomerID
  {
    private const string strSelectCmd = @"Select * from [Customers]";
    private const string strUpdateCmd = @"UPDATE [Customers] SET " +
      @"[CompanyName] = @CompanyName, [ContactName] = @ContactName, " +
      @"[Phone] = @Phone WHERE [CustomerID] = @CustomerID";

    public CustomerListWebPart()
    {
    }

    [Personalizable()]
    public virtual String CustomerID
    {
      get
      {
        object customerID = ViewState["CustomerID"];
        if (customerID == null)
          return String.Empty;
        else
          return (String)customerID;
      }
      set
      {
        ViewState["CustomerID"] = value;
      }
    }

    //This callback method returns the provider.
    [ConnectionProvider("CustomerID Provider", "CustomerIDProvider")]
    public ICustomerID ProvideICustomerID()
    {
      return this;
    }

    // Allow page developers to set the connection string.
    public String ConnectionString
    {
      get
      {
        object connectionString = ViewState["ConnectionString"];
        if (connectionString == null)
          return String.Empty;
        else
          return (String)connectionString;
      }
      set
      {
        ViewState["ConnectionString"] = value;
      }
    }

    public Boolean AllowCustomerEditing
    {
      get
      {
        object allowEditing = ViewState["AllowCustomerEditing"];
        if (allowEditing == null)
          return false;
        else
          return (Boolean)allowEditing;
      }
      set
      {
        ViewState["AllowCustomerEditing"] = value;
      }
    }

    protected override void CreateChildControls()
    {
      Controls.Clear();

      SqlDataSource ds = new SqlDataSource(this.ConnectionString, strSelectCmd);
      ds.ID = "dsCustomers";
      ds.DataSourceMode = SqlDataSourceMode.DataSet;
      ds.UpdateCommandType = SqlDataSourceCommandType.Text;
      ds.UpdateCommand = strUpdateCmd;
      ParameterCollection updateParams = new ParameterCollection();
      updateParams.Add(_createParameter("CustomerID", TypeCode.String));
      updateParams.Add(_createParameter("CompanyName", TypeCode.String));
      updateParams.Add(_createParameter("ContactName", TypeCode.String));
      updateParams.Add(_createParameter("Phone", TypeCode.String));

      Controls.Add(ds);

      GridView grid = new GridView();
      grid.ID = "customerGrid";
      grid.Font.Size = 8;
      grid.AllowPaging = true;
      grid.AllowSorting = true;
      grid.AutoGenerateColumns = false;
      String[] fields = { "CustomerID" };
      grid.DataKeyNames = fields;
      grid.DataSourceID = "dsCustomers";
      CommandField controlButton = new CommandField();

      //Only show Edit button if control configured for to allow it
      if (AllowCustomerEditing)
        controlButton.ShowEditButton = true;

      controlButton.ShowSelectButton = true;
      grid.Columns.Add(controlButton);
      BoundField customerID = _createBoundField("CustomerID");
      customerID.ReadOnly = true;
      grid.Columns.Add(customerID);
      grid.Columns.Add(_createBoundField("CompanyName"));
      grid.Columns.Add(_createBoundField("ContactName"));
      grid.Columns.Add(_createBoundField("Phone"));
      grid.SelectedRowStyle.BackColor = Color.AntiqueWhite;

      grid.SelectedIndexChanged += new EventHandler(SelectedIndexChanged);
      grid.PageIndexChanged += new EventHandler(PageIndexChanged);
      Controls.Add(grid);
      Style.Add(HtmlTextWriterStyle.FontFamily, "arial");
    }

    protected void SelectedIndexChanged(object sender, EventArgs e)
    {
      GridViewRow row = ((GridView)(sender)).SelectedRow;
      CustomerID = row.Cells[1].Text;
    }

    protected void PageIndexChanged(object sender, EventArgs e)
    {
      ((GridView)(sender)).SelectedIndex = -1;
    }

    private BoundField _createBoundField(String fieldName)
    {
      BoundField field = new BoundField();
      switch (fieldName)
      {
        case "CompanyName": field.HeaderText = "Company Name";
          break;
        case "ContactName": field.HeaderText = "Contact Name";
          break;
        case "PhoneName": field.HeaderText = "Phone Name";
          break;
        case "CustomerID": field.HeaderText = "Customer ID";
          break;
        default: field.HeaderText = fieldName; break;
      }
      field.SortExpression = fieldName;
      field.DataField = fieldName;
      return field;
    }

    private Parameter _createParameter(String paramName, TypeCode dataTypeCode)
    {
      Parameter theParm = new Parameter(paramName, dataTypeCode);
      return theParm;
    }
  }
}