Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub ASPxGridView1_HtmlDataCellPrepared(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewTableDataCellEventArgs)
		Dim colIdx As String = "col_idx_" & e.DataColumn.Index.ToString()
		Dim rowIdx As String = "row_idx_" & e.VisibleIndex.ToString()
		e.Cell.Attributes.Add("onmouseover", "OnCellOver(this, '" & colIdx & "', '" & rowIdx & "');")
		e.Cell.Attributes.Add("onmouseout", "OnCellOut(this, '" & colIdx & "', '" & rowIdx & "');")
		e.Cell.CssClass &= " " & colIdx & " " & rowIdx
	End Sub
End Class