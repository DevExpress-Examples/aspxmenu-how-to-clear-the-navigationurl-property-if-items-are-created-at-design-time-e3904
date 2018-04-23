Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq

Imports DevExpress.Web.ASPxMenu

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub ASPxMenu1_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim menu As ASPxMenu = TryCast(sender, ASPxMenu)

		'Uncomment the following code to use it in a real application
		'CorrectItem(menu.RootItem);

		'The following code is used for the demo purpose only. Do not use it in a real scenario
		CorrectItem(menu.Items(1))
	End Sub

	Private Sub CorrectItem(ByVal item As MenuItem)
		If item Is Nothing Then
			Return
		End If
		If item.HasChildren Then
			item.NavigateUrl = Nothing
			For Each subItem As MenuItem In item.Items
				CorrectItem(subItem)
			Next subItem
		End If
	End Sub
End Class