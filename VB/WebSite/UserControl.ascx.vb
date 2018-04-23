Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Public Class UserControl
	Inherits System.Web.UI.UserControl
	Implements ITemplate
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		System.Threading.Thread.Sleep(1000) ' some processing
	End Sub
	Private Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
		container.Controls.Add(Me)
	End Sub
End Class
