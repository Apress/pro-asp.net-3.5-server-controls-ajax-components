// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 1 - Server Control Basics
// File: HelloWorld.aspx.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Collections;

namespace ControlsBook2Web.Ch01
{
  public partial class HelloWorld : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      ArrayList list = new ArrayList();
      list.Add("Hello");
      list.Add("Goodbye");

      Greeting.DataSource = list;
      Greeting.DataBind();
    }

    protected void ClickMe_Click(object sender, EventArgs e)
    {
      Resultlabel.Text = "Your new message: " + Greeting.SelectedItem.Value + "&nbsp;" + Name.Text + "!";
    }

    protected void Name_TextChanged(object sender, EventArgs e)
    {
      ChangeLabel.Text = "Textbox changed to " + Name.Text;
    }
  }
}