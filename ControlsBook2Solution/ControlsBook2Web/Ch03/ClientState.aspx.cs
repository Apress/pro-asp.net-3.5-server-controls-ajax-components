// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 3 - ASP.NET State Management
// File: ClientState.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2Web.Ch03
{
  public partial class ClientState : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      GetClientState();
    }

    protected void SetStateButton_Click(object sender, EventArgs e)
    {
      SetClientState();
    }

    private void SetClientState()
    {
      string name = NameTextBox.Text;

      // set the name Cookie value
      Response.Cookies["cookiename"].Value = name;

      // encode the name in the redirect URL
      URLEncodeLink.NavigateUrl = "ClientState.aspx?urlname=" + name;

      // put the name in the hidden variable
      HiddenName.Value = name;

      // put the name in ViewState
      ViewState["viewstatename"] = name;
    }

    private void GetClientState()
    {
      // check the cookiename Cookie
      CookieLabel.Text = "";
      if (Request.Cookies["cookiename"] != null)
        CookieLabel.Text = Request.Cookies["cookiename"].Value;

      // check the URL for urlname variable
      URLLabel.Text = "";
      if (Request.QueryString["urlname"] != null)
        URLLabel.Text = Request.Params["urlname"];

      // check the form data for hiddenname variable
      // Must use UniqueID to get correct HTML Form name
      HiddenLabel.Text = "";
      if (Context.Request.Form[HiddenName.UniqueID] != null)
        HiddenLabel.Text = Request.Form[HiddenName.UniqueID];

      // check the Viewstate for the viewstatename variable
      ViewStateLabel.Text = "";
      if (ViewState["viewstatename"] != null)
        ViewStateLabel.Text = ViewState["viewstatename"].ToString();
    }
  }
}
