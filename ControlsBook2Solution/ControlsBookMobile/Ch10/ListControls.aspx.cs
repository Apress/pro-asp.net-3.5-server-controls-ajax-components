// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 10 - Other Server Controls
// File: ListControls.aspx.cs
// Written by: Rob Cameron and Dale Michalk
using System;
using System.Data;
using System.Web.UI.MobileControls;

namespace ControlsBook2Mobile.Ch10
{
   public partial class ListControls : System.Web.UI.MobileControls.MobilePage
   {

      #region Web Form Designer generated code
      override protected void OnInit(EventArgs e)
      {
         //
         // CODEGEN: This call is required by the ASP.NET Web Form Designer.
         //
         InitializeComponent();
         base.OnInit(e);
      }

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.List1.ItemCommand += new System.Web.UI.MobileControls.ListCommandEventHandler(this.List1_ItemCommand);

      }
      #endregion


      private DataSet GetCustomersData()
      {
         return ControlsBook2Mobile.Ch10.CustDB.GetCustomersByName("[AB]","10");
      }

      protected void Form1_Activate(object sender, System.EventArgs e)
      {
         DataSet ds = GetCustomersData();
         List1.DataSource = ds;
         List1.DataMember = "Customers";
         List1.DataTextField = "ContactName";
         List1.DataBind();
      }

      protected void SelectionListForm_Activate(object sender, System.EventArgs e)
      {
         DataSet ds = GetCustomersData();
         SelectionList1.DataSource = ds;
         SelectionList1.DataMember = "Customers";
         SelectionList1.DataTextField = "ContactName";
         SelectionList1.DataBind();
      }

      protected void ObjectListForm_Activate(object sender, System.EventArgs e)
      {
         DataSet ds = GetCustomersData();
         ObjectList1.DataSource = ds;
         ObjectList1.DataMember = "Customers";
         ObjectList1.DataBind();
      }

      private void List1_ItemCommand(object sender, System.Web.UI.MobileControls.ListCommandEventArgs e)
      {
         ListResult.Text = "Selected name:" + e.ListItem.Text;
      }

      protected void SelListCmd_Click(object sender, System.EventArgs e)
      {
         string results = "";
         foreach (MobileListItem item in SelectionList1.Items)
         {
            if (item.Selected)
            {
               if (results.Length == 0)
                  results += " " + item.Text;
               else
                  results += ", " + item.Text;
            }
         }
         SelectionListResults.Text = "Selected names:" + results;
      }
   }
}
