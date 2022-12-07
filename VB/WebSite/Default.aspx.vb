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
#Region "#Prevent_Collapsing"
Imports DevExpress.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub ASPxTreeView1_ExpandedChanging(ByVal source As Object, ByVal e As DevExpress.Web.TreeViewNodeCancelEventArgs)
		e.Node.Expanded = True
		If e.Node.Expanded AndAlso (ASPxTreeView1.SelectedNode IsNot Nothing) Then
			Dim node As TreeViewNode = ASPxTreeView1.SelectedNode.Parent
			Do While node IsNot Nothing
				If e.Node Is node Then
					e.Cancel = True
					Exit Do
				End If
				node = node.Parent
			Loop
		End If
	End Sub
End Class
#End Region ' #Prevent_Collapsing