<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>

<%@ Page Language="c#" CodeBehind="DeviceSpecific.aspx.cs" Inherits="ControlsBook2Mobile.Ch10.DeviceSpecific"
  AutoEventWireup="True" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<body Xmlns:mobile="http://schemas.microsoft.com/Mobile/WebForm">
  <mobile:Form ID="InputForm" Runat="server" OnActivate="InputForm_Activate">
    <p>
      <mobile:Image ID="Image1" ImageUrl="../Ch10/imgs/mslogo.bmp" Runat="server">
        <DeviceSpecific>
          <Choice Filter="prefersWBMP" ImageUrl="../Ch10/imgs/mslogo.wbmp"></Choice>
        </DeviceSpecific>
      </mobile:Image>
      <mobile:Label ID="Label1" Runat="server">Query by contact name:</mobile:Label>
      <mobile:TextBox ID="NameTextBox" Runat="server">Ana Trujillo
      </mobile:TextBox>
      <mobile:Command ID="SelListCmd" Runat="server" OnClick="SelListCmd_Click">Submit</mobile:Command>
      <mobile:Label ID="Label3" Runat="server" BreakAfter="False">Agent:&nbsp;</mobile:Label>
      <mobile:Label ID="AgentLabel" Runat="server">
      </mobile:Label>
      <mobile:Label ID="Label2" Runat="server" BreakAfter="False">PreferredRenderingType:&nbsp;</mobile:Label>
      <mobile:Label ID="PrefRendLabel" Runat="server">
      </mobile:Label>
      <mobile:Label ID="Label5" Runat="server" BreakAfter="False">PreferredImageMIME:&#160;</mobile:Label>
      <mobile:Label ID="PrefImageLabel" Runat="server">
      </mobile:Label>
    </p>
  </mobile:Form>
  <mobile:Form ID="ObjectListForm" Runat="server" Paginate="True">
    <mobile:ObjectList ID="ObjectList1" Runat="server" Wrapping="NoWrap" CommandStyle-StyleReference="subcommand"
      LabelStyle-StyleReference="title" ItemsPerPage="10">
      <DeviceSpecific>
        <Choice Filter="isHTML32">
          <HeaderTemplate>
            <table>
							<tr bgcolor="#000084">
								<td>
									<font color="white">Contact Name</font>
								</td>
								<td>
									<font color="white">Contact Title</font>
								</td>
								<td>
									<font color="white">Company Name</font>
								</td>
							</tr>
          </HeaderTemplate>
          <ItemTemplate>
            <tr bgcolor="#EEEEEE">
							<td>
								<%#((ObjectListItem)Container)["ContactName"]%>
							</td>
							<td>
								<%#((ObjectListItem)Container)["ContactTitle"]%>
							</td>
							<td>
								<%#((ObjectListItem)Container)["CompanyName"]%>
							</td>
						</tr>
          </ItemTemplate>
          <AlternatingItemTemplate>
            <tr bgcolor="#DCDCDC">
							<td>
								<%#((ObjectListItem)Container)["ContactName"]%>
							</td>
							<td>
								<%#((ObjectListItem)Container)["ContactTitle"]%>
							</td>
							<td>
								<%#((ObjectListItem)Container)["CompanyName"]%>
							</td>
						</tr>
          </AlternatingItemTemplate>
          <FooterTemplate>
						</table>
					</FooterTemplate>
        </Choice>
        <Choice>
          <ItemTemplate>
						Name:<%#((ObjectListItem)Container)["ContactName"]%>&nbsp;&nbsp; Title:<%#((ObjectListItem)Container)["ContactTitle"]%>&nbsp;&nbsp; 
						Company:<%#((ObjectListItem)Container)["CompanyName"]%>
						<br />
					</ItemTemplate>
        </Choice>
      </DeviceSpecific>
    </mobile:ObjectList>
  </mobile:Form>
</body>
</html>
