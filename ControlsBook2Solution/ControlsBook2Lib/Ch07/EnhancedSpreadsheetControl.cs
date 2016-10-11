using System.Collections;
using System.ComponentModel;
// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 7 - Server Control Data Binding
// File: EnhancedSpreadsheetControl.csS
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsBook2Lib.Ch07
{
  [ToolboxData("<{0}:EnhancedSpreadsheetControl runat=server></{0}:EnhancedSpreadsheetControl>")]
  public class EnhancedSpreadsheetControl : CompositeDataBoundControl
  {
    protected Table table = new Table();

    [Browsable(false)]
    public virtual TableRowCollection Rows
    {
      get
      {
        EnsureChildControls();
        return table.Rows;
      }
    }

    public Color HeaderRowBackColor
    {
      get
      {
        object headerRowBackColor = ViewState["HeaderRowBackColor"];
        if (headerRowBackColor == null)
          return Color.White;
        else
          return (Color)headerRowBackColor;
      }
      set
      {
        ViewState["HeaderRowBackColor"] = value;
      }
    }

    public Color HeaderRowForeColor
    {
      get
      {
        object headerRowForeColor = ViewState["HeaderRowForeColor"];
        if (headerRowForeColor == null)
          return Color.Black;
        else
          return (Color)headerRowForeColor;
      }
      set
      {
        ViewState["HeaderRowForeColor"] = value;
      }
    }

    protected override int CreateChildControls(IEnumerable dataSource, bool dataBinding)
    {
      int count = 0;
      if (dataSource != null)
      {
        table = new Table();
        Controls.Add(table);

        table.Attributes.Add("border", "1");
        table.Attributes.Add("cellpadding", "2");

        if (dataBinding)
        {
          EnhancedSpreadsheetRow row;
          TableCell cellData;
          IEnumerator e = dataSource.GetEnumerator();
          e.MoveNext();
          //Populate Header Row based on datasource schema for first data item
          BuildHeaderRow(e.Current, dataBinding);
          ++count;  //Increment for header row

          do
          {
            object datarow = e.Current;
            row = new EnhancedSpreadsheetRow(count, datarow, dataBinding);
            this.Rows.Add(row);
            if (datarow is DbDataRecord)
            {
              DbDataRecord temp = (DbDataRecord)datarow;
              for (int i = 0; i < temp.FieldCount; ++i)
              {
                cellData = new TableCell();
                row.Cells.Add(cellData);
                cellData.Text = temp.GetValue(i).ToString();
              }
            }
            if (datarow is DataRowView)
            {
              DataRow temp = ((DataRowView)datarow).Row;

              for (int i = 0; i < temp.Table.Columns.Count; ++i)
              {
                cellData = new TableCell();
                row.Cells.Add(cellData);
                cellData.Text = temp[i].ToString();
              }
            }
            row.HorizontalAlign = HorizontalAlign.Center;
            ++count;
          }
          while (e.MoveNext());
        }
        else  //Not databinding, values come from ViewState
        {
          //Add TableRow row as placeholder for
          //header row ViewState
          TableRow headerRow = new TableRow();
          this.Rows.Add(headerRow);
          IEnumerator e = dataSource.GetEnumerator();
          e.MoveNext();
          ++count; //increment since header row handled

          //Add correct number of EnhancedSpreadsheetRows
          //as placeholder for data row ViewState 
          EnhancedSpreadsheetRow row;
          while (e.MoveNext())
          {
            row = new EnhancedSpreadsheetRow(count,e.Current,dataBinding);
            row.HorizontalAlign = HorizontalAlign.Center;
            this.Rows.Add(row);
            ++count;
          }
        }
      }
      return count;
    }

    private void BuildHeaderRow(object dataRow, bool dataBinding)
    {
      //Add header row with column names:
      TableRow headerRow = new TableRow();
      this.Rows.Add(headerRow);
      
      TableCell columnName;

      if (dataRow is DbDataRecord)
      {
        DbDataRecord temp = (DbDataRecord)dataRow;
        for (int i = 0; i < temp.FieldCount; ++i)
        {
          columnName = new TableCell();
          headerRow.Cells.Add(columnName);
          columnName.Text = temp.GetName(i);
        }
      }

      if (dataRow is DataRowView)
      {
        DataRowView drv = (DataRowView)dataRow;
        for (int i = 0; i < drv.Row.Table.Columns.Count; ++i)
        {
          columnName = new TableCell();
          headerRow.Cells.Add(columnName);
          columnName.Text = drv.Row.Table.Columns[i].Caption;
        }
      }

      headerRow.HorizontalAlign = HorizontalAlign.Center;
      headerRow.BackColor = HeaderRowBackColor;
      headerRow.ForeColor = HeaderRowForeColor;
    }
  }
}