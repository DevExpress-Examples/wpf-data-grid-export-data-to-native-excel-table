<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128650398/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T466541)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WPF Data Grid - Export Data to a Native Excel Table

This example demonstrates how to export data from the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl) to a [native Excel table](https://support.microsoft.com/en-us/office/overview-of-excel-tables-7ab0bb7d-3a9e-4b56-a3c9-6c94334e492c). To enable this export mode, set the [XlsxExportOptionsEx.LayoutMode](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.XlsxExportOptionsEx.LayoutMode) property to `Table`.

![image](https://user-images.githubusercontent.com/65009440/174605486-2372ac74-223b-443a-990f-28b6e43920d9.png)

When you export grid data to a native Excel table, you can handle the [XlsxExportOptionsEx.BeforeExportTable](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.XlsxExportOptionsEx.BeforeExportTable) event to customize the settings of the created table.

<!-- default file list -->
## Files to look at

* [MainWindow.xaml](./CS/WpfApplication80/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication80/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication80/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication80/MainWindow.xaml.vb))

<!-- default file list end -->

## Documentation

* [Data-Aware Export](https://docs.devexpress.com/WPF/10018/controls-and-libraries/data-grid/printing-and-exporting/data-aware-export)
* [Printing and Exporting](https://docs.devexpress.com/WPF/117296/controls-and-libraries/data-grid/printing-and-exporting)
* [XlsxExportOptionsEx](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.XlsxExportOptionsEx)

## More Examples

* [WPF Data Grid - Export the GridControl with the Specified Page Header and Footer](https://github.com/DevExpress-Examples/how-to-create-the-print-page-header-and-footer-when-exporting-the-gridcontrol-e2608)
* [WPF Data Grid - Customize the Print and Export Appearance](https://github.com/DevExpress-Examples/wpf-data-grid-customize-print-export-appearance)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-export-data-to-native-excel-table&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-export-data-to-native-excel-table&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
