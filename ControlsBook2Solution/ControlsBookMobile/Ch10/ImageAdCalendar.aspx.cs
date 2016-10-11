// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 10 - Other Server Controls
// File: ImageAdCalendar.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Mobile.Ch10
{
   public partial class ImageAddCalendar : System.Web.UI.MobileControls.MobilePage
   {
      protected System.Web.UI.MobileControls.Label ChoiceLabel;


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

      protected void Calendar1_SelectionChanged(object sender, System.EventArgs e)
      {
         DateTime date = Calendar1.SelectedDate;
         CalResult.Text = "Selected " + date.ToShortDateString();
      }
   }
}