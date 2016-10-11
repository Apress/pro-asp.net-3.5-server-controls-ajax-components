using System;
using System.Globalization;
using System.Threading;
using System.Web;

namespace ControlsBook2Web
{
  public class Global : System.Web.HttpApplication
  {

    protected void Application_Start(object sender, EventArgs e)
    {

    }

    protected void Session_Start(object sender, EventArgs e)
    {

    }

    protected void Application_BeginRequest(object sender, EventArgs e)
    {
      string culture;
      // find the preferred culture from the browser
      if (null != HttpContext.Current.Request.UserLanguages)
      {
        culture = HttpContext.Current.Request.UserLanguages[0];

        CultureInfo info = null;

        // check for a neutral culture of length 2 (i.e., de or es)
        if (culture.Length == 2)
          // use CultureInfo to convert from neutral to specific culture
          // so we can assign to both CurrentCulture and CurrentUI Culture
          info = CultureInfo.CreateSpecificCulture(culture);
        else
          info = new CultureInfo(culture);

        // set it for both formatting/comparisons (CurrentCulture)
        // and resource lookup (CurrentUICulture)
        Thread.CurrentThread.CurrentCulture = info;
        Thread.CurrentThread.CurrentUICulture = info;
      }
    }

    protected void Application_AuthenticateRequest(object sender, EventArgs e)
    {

    }

    protected void Application_Error(object sender, EventArgs e)
    {

    }

    protected void Session_End(object sender, EventArgs e)
    {

    }

    protected void Application_End(object sender, EventArgs e)
    {

    }
  }
}