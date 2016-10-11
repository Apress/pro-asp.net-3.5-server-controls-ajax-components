// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 10 - Other Server Controls
// File: ContainerControls.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Data;

namespace ControlsBook2Mobile.Ch10
{
   public partial class ContainerControls : System.Web.UI.MobileControls.MobilePage
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

      }
      #endregion

      private DataSet GetCustomersData(string Name)
      {
         return CustDB.GetCustomersByName(Name,"20");
      }

      protected void PanelForm_Activate(object sender, System.EventArgs e)
      {
         PanelList.DataSource = GetCustomersData(PanelFormTextBox.Text);
         PanelList.DataMember = "Customers";
         PanelList.DataTextField = "ContactName";
         PanelList.DataBind();
      }

      protected void PanelFormCmd_Click(object sender, System.EventArgs e)
      {
         ActiveForm = PanelForm;
         QueryPanel.Visible = false;
         ResultsPanel.Visible = true;
      }
   }
}