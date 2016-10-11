// Title: Building ASP.NET Server Controls
//
// Chapter: 10 - Mobile Controls
// File: MobileBasics.aspx.cs
// Written by: Dale Michalk and Rob Cameron
//
// Copyright © 2003, Apress L.P.
using System;

namespace ControlsBook2Mobile.Ch10
{

   public partial class MobileBasics : System.Web.UI.MobileControls.MobilePage
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

      protected void cmdHello_Click(object sender, System.EventArgs e)
      {
         this.Label2.Text = "Hello " + TextBox1.Text;
         this.ActiveForm = Form2;
      }
   }
}
