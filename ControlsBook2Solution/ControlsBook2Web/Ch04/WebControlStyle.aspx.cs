// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 4 - WebControl Base Class and Control Styles
// File: WebControlsStyle.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI.HtmlControls;

namespace ControlsBook2Web.Ch04
{
  public partial class WebControlStyle : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      //Add link to css class file
      AddCssLinktoHeader();

    }

    private void AddCssLinktoHeader()
    {
      HtmlLink cssRef = new HtmlLink();
      cssRef.Href = "../Ch04/WebControlStyle.css";
      cssRef.Attributes.Add("rel", "stylesheet");
      cssRef.Attributes.Add("type", "text/css");
      Header.Controls.Add(cssRef);
    }

    protected void SetStyleButton_Click(object sender, EventArgs e)
    {
      NameLabel.Text = NameTextbox.Text;

      NameLabel.CssClass = CssClassTextBox.Text;

      NameLabel.Font.Name = FontDropDownList.SelectedItem.Value;
      NameLabel.Font.Bold = (BoldCheckbox.Checked == true);
      NameLabel.Font.Italic = (ItalicCheckbox.Checked == true);

      // Use the TypeConverter for the System.Drawing.Color class
      // to get the typed Color value from the string value
      Color c =
         (Color)TypeDescriptor.GetConverter(typeof(Color)).ConvertFromString(
         ForeColorDropDownList.SelectedItem.Value);
      NameLabel.ForeColor = c;

      // set the text-decoration CSS style properties
      // using manual manipulation of the Style property
      string textdecoration = "none";
      if (UnderlineCheckbox.Checked == true)
        textdecoration = "underline";
      NameLabel.Style["text-decoration"] = textdecoration;
    }
  }
}
