// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 10 - Other Server Controls
// File: CustomerInvoicesWebPart.cs
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
  [ToolboxData("<{0}:CustomerInvoicesWebPart runat=server></{0}:CustomerInvoicesWebPart>")]
  public class CustomerInvoicesWebPart : WebPart
  {
    private const string strSelectCmd = @"Select * from [Invoices] where " +
      "CustomerID = '{0}'";
    private ICustomerID _customerIDProvider;

    public CustomerInvoicesWebPart()
    {
    }

    public String CustomerID
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

    //The ConnectionConsumer attribute identifies 
    //this method as the mechanism for connecting with 
    // the provider. 
    [ConnectionConsumer("CustomerID Consumer", "CustomerIDConsumer")]
    public void GetICustomerID(ICustomerID Provider)
    {
      _customerIDProvider = Provider;
    }

    protected override void OnPreRender(EventArgs e)
    {
      base.OnPreRender(e);

      if (this._customerIDProvider != null)
      {
        CustomerID = _customerIDProvider.CustomerID.Trim();
      }
      Title = "Customer Invoices = " + CustomerID;
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
    protected override void CreateChildControls()
    {
      Controls.Clear();

      SqlDataSource ds = new SqlDataSource(this.ConnectionString, String.Format(strSelectCmd, CustomerID));
      ds.ID = "dsCustomerInvoicesWebPart";
      ds.DataSourceMode = SqlDataSourceMode.DataSet;
      Controls.Add(ds);

      GridView grid = new GridView();
      grid.ID = "CustomerInvoicesWebPartGrid";
      grid.Font.Size = 8;
      grid.AllowPaging = true;
      grid.PageSize = 5;
      grid.AllowSorting = true;
      grid.AutoGenerateColumns = false;
      String[] fields = { "CustomerID" };
      grid.DataKeyNames = fields;
      grid.DataSourceID = "dsCustomerInvoicesWebPart";
      CommandField controlButton = new CommandField();
      controlButton.ShowSelectButton = true;
      grid.Columns.Add(controlButton);
      grid.Columns.Add(_createBoundField("OrderID"));
      grid.Columns.Add(_createBoundField("RequiredDate"));
      grid.Columns.Add(_createBoundField("ShippedDate"));
      grid.Columns.Add(_createBoundField("ProductName"));
      grid.Columns.Add(_createBoundField("Quantity"));
      grid.SelectedRowStyle.BackColor = Color.AntiqueWhite;

      grid.SelectedIndexChanged += new EventHandler(SelectedIndexChanged);
      grid.PageIndexChanged += new EventHandler(PageIndexChanged);

      Controls.Add(grid);
      Style.Add(HtmlTextWriterStyle.FontFamily, "arial");
    }

    protected void SelectedIndexChanged(object sender, EventArgs e)
    {
      GridViewRow row = ((GridView)(sender)).SelectedRow;
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
        case "Order ID": field.HeaderText = "Order ID";
          break;
        case "RequiredDate": field.HeaderText = "Required Date";
          break;
        case "ShippedDate": field.HeaderText = "Shipped Date";
          break;
        case "ProductName": field.HeaderText = "Product Name";
          break;
        case "Quanity": field.HeaderText = "Quantity Ordered";
          break;
        default: field.HeaderText = fieldName; break;
      }
      field.DataField = fieldName;
      field.SortExpression = fieldName;
      return field;
    }

    private Parameter _createParameter(String paramName, TypeCode dataTypeCode)
    {
      Parameter theParm = new Parameter(paramName, dataTypeCode);
      return theParm;
    }
  }
}