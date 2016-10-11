// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 11 - Design-Time Support
// File: SimpletexteditorDialog.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System.Windows.Forms;

namespace ControlsBook2Lib.Ch11.Design
{
  public partial class SimpleTextEditorDialog : Form
  {
    public SimpleTextEditorDialog()
    {
      InitializeComponent();
    }

    public string TextValue
    {
      get
      {
        return textString.Text;
      }
      set
      {
        textString.Text = value;
      }
    }
  }
}
