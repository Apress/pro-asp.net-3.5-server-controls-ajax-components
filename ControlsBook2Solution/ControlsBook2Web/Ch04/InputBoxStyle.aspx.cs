// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 4 - WebControl Base Class and Control Styles
// File: InputBoxStyle.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.ComponentModel;
using System.Drawing;

namespace ControlsBook2Web.Ch04
{
  public partial class InputBoxStyle : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SetStyleButton_Click(object sender, EventArgs e)
    {
      if (LabelActionList.SelectedIndex > 0)
        SetLabelStyle();

      if (TextboxActionList.SelectedIndex > 0)
        SetTextboxStyle();
    }
    private void SetLabelStyle()
    {
      NameInputBox.LabelStyle.Font.Name = LabelFontDropDownList.SelectedItem.Value;
      NameInputBox.LabelStyle.Font.Bold = (LabelBoldCheckbox.Checked == true);
      NameInputBox.LabelStyle.Font.Italic = (LabelItalicCheckbox.Checked == true);
      Color labelColor =
         (Color)TypeDescriptor.GetConverter(typeof(Color)).ConvertFromString(
         LabelForeColorDropDownList.SelectedItem.Value);
      NameInputBox.LabelStyle.ForeColor = labelColor;
    }

    private void SetTextboxStyle()
    {
      NameInputBox.TextboxStyle.Font.Name = TextboxFontDropDownList.SelectedItem.Value;
      NameInputBox.TextboxStyle.Font.Bold = (TextboxBoldCheckbox.Checked == true);
      NameInputBox.TextboxStyle.Font.Italic = (TextboxItalicCheckbox.Checked == true);

      // Use the TypeConverter for the System.Drawing.Color class
      // to get the typed Color value from the string value
      Color textboxColor =
         (Color)TypeDescriptor.GetConverter(typeof(Color)).ConvertFromString(
         TextboxForeColorDropDownList.SelectedItem.Value);
      NameInputBox.TextboxStyle.ForeColor = textboxColor;
    }
  }
}
