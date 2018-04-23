Imports DevExpress.Export
Imports DevExpress.Export.Xl
Imports DevExpress.XtraPrinting
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace WpfApplication80
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()

            Dim items As New ObservableCollection(Of Item)()
            For i As Integer = 1 To 29
                items.Add(New Item() With {.Name = "Name" & i, .MinValue = i + 5, .MaxValue = i + 10})
            Next i
            grid.ItemsSource = items
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim options As New XlsxExportOptionsEx() With {.UnboundExpressionExportMode = DevExpress.Export.UnboundExpressionExportMode.AsFormula, .LayoutMode = LayoutMode.Table}
            AddHandler options.BeforeExportTable, AddressOf options_BeforeExportTable
            view.ExportToXlsx("Document.xlsx", options)
            Process.Start("Document.xlsx")
        End Sub

        Private Sub options_BeforeExportTable(ByVal e As BeforeExportTableEventArgs)
            e.Table.Style.Name = XlBuiltInTableStyleId.Dark4
        End Sub
    End Class

    Public Class Item
        Public Property Name() As String

        Public Property MinValue() As Integer
        Public Property MaxValue() As Integer
    End Class
End Namespace
