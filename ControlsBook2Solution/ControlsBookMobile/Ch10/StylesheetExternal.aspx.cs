// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 10 - Other Server Controls
// File: Stylesheets.aspx.cs
// Written by: Rob Cameron and Dale Michalk
using System;
using System.Data;

namespace ControlsBook2Mobile.Ch10
{
   public partial class StyleSheetExternal : System.Web.UI.MobileControls.MobilePage
   {

      protected void Page_Load(object sender, System.EventArgs e)
      {
         // Put user code to initialize the page here
      }

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

      }
      #endregion

      private DataSet GetCustomersByName(String Name)
      {
         return ControlsBook2Mobile.Ch10.CustDB.GetCustomersByName(Name,"40");
      }

      protected void QueryCmd_Click(object sender, System.EventArgs e)
      {
         ActiveForm = ResultsForm;

         CustList.DataSource = GetCustomersByName(NameTextBox.Text);
         CustList.DataMember = "Customers";
         CustList.DataTextField = "ContactName";
         CustList.DataBind();
      }
   }
}
