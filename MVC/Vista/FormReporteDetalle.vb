Public Class FormReporteDetalle
    Private Sub FormReporteDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_ventasDataSet.reporteDetalle_venta' Puede moverla o quitarla según sea necesario.
        Me.reporteDetalle_ventaTableAdapter.Fill(Me.db_ventasDataSet.reporteDetalle_venta, idventa:=txtIdVenta.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class