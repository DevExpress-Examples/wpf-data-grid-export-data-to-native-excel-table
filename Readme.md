# How to export the GridControl into a native Excel table


<p>In this example, we demonstrate how to export data from the GridControl into a <a href="https://support.office.com/en-us/article/Overview-of-Excel-tables-7ab0bb7d-3a9e-4b56-a3c9-6c94334e492c">native Excel table</a>. Exporting data into a <a href="https://support.office.com/en-us/article/Overview-of-Excel-tables-7ab0bb7d-3a9e-4b56-a3c9-6c94334e492c">native Excel table</a> provides greater capabilities for data analysis and management, and allows you to format cells using numerous formatting options. To enable this export mode, set the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingXlsxExportOptionsEx_LayoutModetopic">XlsxExportOptionsEx.LayoutMode</a> property to "Table".<br>When exporting to a native Excel table, you can handle the <a href="https://documentation.devexpress.com/CoreLibraries/DevExpressXtraPrintingXlsxExportOptionsEx_BeforeExportTabletopic.aspx">BeforeExportTable</a> event to customize the settings of the created table.</p>

<br/>


