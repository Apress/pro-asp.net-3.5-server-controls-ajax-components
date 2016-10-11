// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 10 - Other Server Controls
// File: TxtandTransCtrls.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Mobile.Ch10
{
   public partial class TextandTransCtrls : System.Web.UI.MobileControls.MobilePage
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

      protected void Command1_Click(object sender, System.EventArgs e)
      {
         this.ActiveForm = Form2;

         Label2.Text = "<b>Password:</b> <i>" + TextBox1.Text + "</i>";
         TextView1.Text = "<b>Password:</b> <i>" + TextBox1.Text + "</i>";
      }
   }
}
