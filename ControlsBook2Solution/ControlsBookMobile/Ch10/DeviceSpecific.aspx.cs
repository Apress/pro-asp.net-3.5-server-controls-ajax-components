// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 10 - Other Server Controls
// File: DeviceSpecific.aspx.cs
// Written by: Rob Cameron and Dale Michalk
using System;
using System.Data;
using System.Web;
using System.Web.Mobile;

namespace ControlsBook2Mobile.Ch10
{
   public partial class DeviceSpecific : System.Web.UI.MobileControls.MobilePage
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

      private DataSet GetCustomersByName(String Name)
      {
         return ControlsBook2Mobile.Ch10.CustDB.GetCustomersByName(Name,"40");
      }

      protected void SelListCmd_Click(object sender, System.EventArgs e)
      {
         ActiveForm = ObjectListForm;
         DataSet ds = GetCustomersByName(NameTextBox.Text);
         ObjectList1.DataSource = ds;
         ObjectList1.DataMember = "Customers";
         ObjectList1.DataBind();
      }

      protected void InputForm_Activate(object sender, System.EventArgs e)
      {
         AgentLabel.Text = HttpContext.Current.Request.Headers["User-Agent"];

         MobileCapabilities caps = (MobileCapabilities)
            HttpContext.Current.Request.Browser;
         if (caps != null) //Cast succeeds
         {
            PrefRendLabel.Text = caps.PreferredRenderingType.ToString();
            PrefImageLabel.Text = caps.PreferredImageMime.ToString();
         }
      }
   }
}
