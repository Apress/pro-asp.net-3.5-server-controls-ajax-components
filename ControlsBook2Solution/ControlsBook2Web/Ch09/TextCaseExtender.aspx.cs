// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 9 - ASP.NET AJAX Controls and Extenders
// File: TextCaseExtender.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Web.Ch09
{
  public partial class TextCaseExtenderControl : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      //Convert selected value to TextCaseStyle and then update TextCaseExtender
      TextCaseExtender1.CaseStyle = (TextCaseStyle)Enum.Parse(typeof(TextCaseStyle), DropDownList1.SelectedValue, true);
      //Reset page
      TextBox1.Text = "";
      this.SetFocus(TextBox1);
    }
  }
}
