<%-- BeginRegion Page setup --%>
<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="ASPxperience_LoadOnCallback" %>

<%@ Register Assembly="DevExpress.Web.v15.1" Namespace="DevExpress.Web"
	TagPrefix="dxnb" %>

<%@ Register Assembly="DevExpress.Web.v15.1" Namespace="DevExpress.Web"
	TagPrefix="dxe" %>


<%-- EndRegion --%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>How to create and load a NavBar group content on a callback</title>
</head>
<body>
	<form id="form1" runat="server">
		&nbsp;
	<div>
		<dxnb:ASPxNavBar ID="ASPxNavBar1" runat="server" EnableCallBacks="True" OnExpandedChanged="ASPxNavBar1_ExpandedChanged" Width="249px">
			<Groups>
				<dxnb:NavBarGroup Expanded="False">
					<Items>
						<dxnb:NavBarItem Text="Item 1">
						</dxnb:NavBarItem>
						<dxnb:NavBarItem Text="Item 2">
						</dxnb:NavBarItem>
					</Items>
				</dxnb:NavBarGroup>
				<dxnb:NavBarGroup Expanded="False" Name="Group1" Text="Group 1">
					<Items>
						<dxnb:NavBarItem>
						</dxnb:NavBarItem>
					</Items>
				</dxnb:NavBarGroup>
				<dxnb:NavBarGroup Expanded="False" Name="Group2" Text="Group 2">
					<Items>
						<dxnb:NavBarItem>
						</dxnb:NavBarItem>
					</Items>
				</dxnb:NavBarGroup>
			</Groups>
		</dxnb:ASPxNavBar>
		&nbsp;&nbsp;
		<dxe:ASPxButton ID="ASPxButton1" runat="server" Text="PostBack">
		</dxe:ASPxButton>
	</div>
	</form>
</body>
</html>
