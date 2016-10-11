<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CustFileTemplate.ascx.cs"
  Inherits="ControlsBook2Web.Ch07.CustFileTemplate" %>
Contact:<br />
<input type="text" value="<%# DataBinder.Eval(Container, "DataItem.ContactName") %>" />
<br />
