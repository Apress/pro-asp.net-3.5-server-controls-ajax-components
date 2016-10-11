<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FileTemplate.ascx.cs" Inherits="ControlsBook2Web.Ch07.FileTemplate" %>
Contact:<br>
<span> <%# DataBinder.Eval(Container, "DataItem.ContactName") %> </span>
<br/>