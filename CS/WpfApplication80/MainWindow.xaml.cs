using DevExpress.Export;
using DevExpress.Export.Xl;
using DevExpress.XtraPrinting;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;

namespace WpfApplication80 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            ObservableCollection<Item> items = new ObservableCollection<Item>();
            for (int i = 1; i < 30; i++) {
                items.Add(new Item() { Name = "Name" + i, MinValue = i + 5, MaxValue = i + 10 });
            }
            grid.ItemsSource = items;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            XlsxExportOptionsEx options = new XlsxExportOptionsEx() { 
                UnboundExpressionExportMode = UnboundExpressionExportMode.AsFormula, 
                LayoutMode = LayoutMode.Table 
            };
            options.BeforeExportTable += options_BeforeExportTable;
            view.ExportToXlsx("Document.xlsx", options);
            Process.Start("Document.xlsx");
        }
        void options_BeforeExportTable(BeforeExportTableEventArgs e) {
            e.Table.Style.Name = XlBuiltInTableStyleId.Light4;
        }
    }
    public class Item {
        public string Name { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
    }
}
