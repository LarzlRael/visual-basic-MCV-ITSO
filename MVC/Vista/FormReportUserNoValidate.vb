Public Class FormReportUserNoValidate
    Private Sub FormReportUserNoValidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_ventasDataSet1.reporte_usuarios_novalidos' Puede moverla o quitarla según sea necesario.
        Me.reporte_usuarios_novalidosTableAdapter.Fill(Me.db_ventasDataSet1.reporte_usuarios_novalidos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class