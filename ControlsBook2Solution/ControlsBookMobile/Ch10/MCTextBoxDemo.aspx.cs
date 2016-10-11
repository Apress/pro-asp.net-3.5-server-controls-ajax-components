// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 10 - Other Server Controls
// File: MCTextBoxDemo.aspx.cs
// Written by: Rob Cameron and Dale Michalk
using System;

namespace ControlsBook2Mobile.Ch10
{
  public partial class MCTextBox : System.Web.UI.MobileControls.MobilePage
  {
    protected System.Web.UI.MobileControls.TextBox TextBox1;

    protected void Page_Load(object sender, System.EventArgs e)
    {
      ChangeLabel.Text = DateTime.Now.ToLongTimeString() + ": MCTextBox No change.";
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
    //      /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {

    }
    #endregion

    protected void MCTextBox1_TextChanged(object sender, System.EventArgs e)
    {
      ChangeLabel.Text = DateTime.Now.ToLongTimeString() + ": MCTextbox Changed! " + MCTextBox1.Text;
    }
  }
}