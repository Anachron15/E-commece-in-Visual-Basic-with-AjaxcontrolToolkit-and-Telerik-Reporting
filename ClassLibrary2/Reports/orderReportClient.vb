Imports ClassLibrary2
Imports System.ComponentModel

<DataObject>
<Serializable>
Public Class orderReportClient : Inherits orderLogicLayer

    Shared Function getOrderedProductForReport() As Byte()
        Dim orderRep As New OrderReport
        orderRep.DataSource = vwOrders.getProductsForReport()
        Dim reportInstance As New Telerik.Reporting.InstanceReportSource
        reportInstance.ReportDocument = orderRep
        Dim reportProcessor As New Telerik.Reporting.Processing.ReportProcessor
        Dim result As Telerik.Reporting.Processing.RenderingResult = reportProcessor.RenderReport("PDF", reportInstance, Nothing)
        Return result.DocumentBytes
    End Function



End Class
