// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 10 - Other Server Controls
// File: ValidationControls.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Web.UI;

namespace ControlsBook2Mobile.Ch10
{
   public partial class ValidationControls : System.Web.UI.MobileControls.MobilePage
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

      protected void Command1_Click(object sender, System.EventArgs e)
      {
         if (Page.IsValid)
            this.ActiveForm = SuccessForm;
         else
            this.ActiveForm = ErrorForm;
      }

      protected void SuccessForm_Activate(object sender, System.EventArgs e)
      {
         ResultNumber.Text = NumberTextBox.Text;
      }
   }
}