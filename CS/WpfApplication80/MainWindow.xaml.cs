using DevExpress.Export;
using DevExpress.Export.Xl;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication80 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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
            XlsxExportOptionsEx options = new XlsxExportOptionsEx() { UnboundExpressionExportMode = DevExpress.Export.UnboundExpressionExportMode.AsFormula, LayoutMode = LayoutMode.Table };
            options.BeforeExportTable += options_BeforeExportTable;
            view.ExportToXlsx("Document.xlsx", options);
            Process.Start("Document.xlsx");
        }

        void options_BeforeExportTable(BeforeExportTableEventArgs e) {
            e.Table.Style.Name = XlBuiltInTableStyleId.Dark4;
        }
    }

    public class Item {
        public string Name {
            get;
            set;
        }

        public int MinValue {
            get;
            set;
        }
        public int MaxValue {
            get;
            set;
        }
    }
}
