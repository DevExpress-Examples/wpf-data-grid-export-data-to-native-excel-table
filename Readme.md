<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128650398/16.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T466541)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication80/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication80/MainWindow.xaml))
* **[MainWindow.xaml.cs](./CS/WpfApplication80/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication80/MainWindow.xaml.vb))**
<!-- default file list end -->
# How to export the GridControl into a native Excel table


<p>In this example, we demonstrate how to export data from the GridControl into a <a href="https://support.office.com/en-us/article/Overview-of-Excel-tables-7ab0bb7d-3a9e-4b56-a3c9-6c94334e492c">native Excel table</a>. Exporting data into a <a href="https://support.office.com/en-us/article/Overview-of-Excel-tables-7ab0bb7d-3a9e-4b56-a3c9-6c94334e492c">native Excel table</a> provides greater capabilities for data analysis and management, and allows you to format cells using numerous formatting options. To enable this export mode, set the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingXlsxExportOptionsEx_LayoutModetopic">XlsxExportOptionsEx.LayoutMode</a> property to "Table".<br>When exporting to a native Excel table, you can handle the <a href="https://documentation.devexpress.com/CoreLibraries/DevExpressXtraPrintingXlsxExportOptionsEx_BeforeExportTabletopic.aspx">BeforeExportTable</a> event to customize the settings of the created table.</p>

<br/>


