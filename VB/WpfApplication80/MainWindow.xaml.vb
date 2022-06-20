Imports DevExpress.Export
Imports DevExpress.Export.Xl
Imports DevExpress.XtraPrinting
Imports System.Collections.ObjectModel
Imports System.Diagnostics
Imports System.Windows

Namespace WpfApplication80

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim items As ObservableCollection(Of Item) = New ObservableCollection(Of Item)()
            For i As Integer = 1 To 30 - 1
                items.Add(New Item() With {.Name = "Name" & i, .MinValue = i + 5, .MaxValue = i + 10})
            Next

            Me.grid.ItemsSource = items
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim options As XlsxExportOptionsEx = New XlsxExportOptionsEx() With {.UnboundExpressionExportMode = UnboundExpressionExportMode.AsFormula, .LayoutMode = LayoutMode.Table}
            AddHandler options.BeforeExportTable, AddressOf options_BeforeExportTable
            Me.view.ExportToXlsx("Document.xlsx", options)
            Call Process.Start("Document.xlsx")
        End Sub

        Private Sub options_BeforeExportTable(ByVal e As BeforeExportTableEventArgs)
            e.Table.Style.Name = XlBuiltInTableStyleId.Light4
        End Sub
    End Class

    Public Class Item

        Public Property Name As String

        Public Property MinValue As Integer

        Public Property MaxValue As Integer
    End Class
End Namespace
