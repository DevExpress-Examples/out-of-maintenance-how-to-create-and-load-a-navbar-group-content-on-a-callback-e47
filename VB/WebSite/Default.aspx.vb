Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Collections
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.ComponentModel
Imports DevExpress.Web
Imports System.Text
Imports System.Xml


Partial Public Class ASPxperience_LoadOnCallback
	Inherits System.Web.UI.Page
	Protected Sub LoadGroupContent(ByVal group As NavBarGroup)
		Dim control As Control = Nothing
		If group.Expanded AndAlso group.ContentTemplate Is Nothing Then
			Select Case group.Name
				Case "Group1", "Group2"
					control = LoadControl("UserControl.ascx")
			End Select
			group.ContentTemplate = TryCast(control, ITemplate)
		End If
	End Sub
	Protected Sub LoadExpandedGroups()
		For i As Integer = 0 To ASPxNavBar1.Groups.Count - 1
			LoadGroupContent(ASPxNavBar1.Groups(i))
		Next i
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		LoadExpandedGroups()
	End Sub
	Protected Sub ASPxNavBar1_ExpandedChanged(ByVal source As Object, ByVal e As DevExpress.Web.NavBarGroupEventArgs)
		LoadGroupContent(e.Group)
	End Sub
End Class