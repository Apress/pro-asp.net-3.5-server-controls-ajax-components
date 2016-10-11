Source code samples for "Pro ASP.NET Server Controls and AJAX Components" by Rob Cameron and Dale Michalk.
-----------------------------------------------------------------------

PREREQUISITES:
SQL Server Express 2005 or SQL Server 2005 with the Northwind database are used in the sample .aspx pages in Chapter 6, 7, and 9.   
The samples are configured to use impersonation when connecting to SQL Server 2005.  This requires that the account that you are  
logged in on Windows has permissions to the Northwind databases in SQL Server.  The scripts to generate the Northwind database are  
available here:
http://www.microsoft.com/downloads/details.aspx?FamilyID=06616212-0356-46A0-8DA2-EEBC53A68034&displaylang=en


In order to view the mobile web projects in ControlsBook2MobileWeb, follow the instructions at this blog post to install the  
mobile web project template:
http://blogs.msdn.com/webdevtools/archive/2007/01/09/tip-trick-using-mobile-web-forms-with-web-applicaiton-projects.aspx


In order to test the Windows Live Search server controls, you will need a developer (free as of this writing) license key that you  
can obtain by following the instructions here:
http://dev.live.com/blogs/livesearch/archive/2006/03/23/27.aspx

Enter your license key in the web.config by replacing the string YOUR_WINDOWS_LIVE_SEARCH_KEY_GOES_HERE in this config section:

  <ControlsBook2Lib>
    <LiveSearchControls>
      <License LiveSearchLicenseKey="YOUR_WINDOWS_LIVE_SEARCH_KEY_GOES_HERE" />
      <Url LiveSearchWebServiceUrl="http://soap.search.msn.com:80/webservices.asmx" />
    </LiveSearchControls>
  </ControlsBook2Lib>



INSTALLATION STEPS:
In the directory where the readme.txt is found, you will find a Visual Studio 2008 solution named ControlsBook2Solution.sln as  
well as several project directories.  Here is a description of the projects:


ControlsBook2Lib - Library project that contains source code for the server controls discussed in this book (Except for Chapter's  
12 and 13).

ControlsBook2Lib.CH12.LiveSearchControls - Library project that contains the server control code from Chapter's 12 and 13.

ControlsBook2MobileWeb - Mobile web project that contains the .aspx test pages for server controls discussed in Chapter 10.

ControlsBook2Web - Web project that contains the .aspx test pages for server controls discussed in all chapters (Except Chapter  
10). 

LicenseGenerator - Windows Forms project that generates licensing information for the Live Search Server Control.

TestDelegates - Console project that demonstrates delegates.



MOBILE WEB PROJECTS:
The ControlsBook2MoibleWeb project depends on IIS so you will be prompted to create a virtual directory when you open the project  
in Visual Studio 2008.  Ignore if you do not wish to review the mobile web site.  Otherwise, add IIS to your Windows installation.   
Also, download the mobile web project and item templates at the above blog post for the ability to add mobile web pages to the project in Visual Studio 2008.
