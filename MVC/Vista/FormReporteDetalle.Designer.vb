<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteDetalle
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.db_ventasDataSet = New MVC.db_ventasDataSet()
        Me.reporteDetalle_ventaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reporteDetalle_ventaTableAdapter = New MVC.db_ventasDataSetTableAdapters.reporteDetalle_ventaTableAdapter()
        Me.txtIdVenta = New System.Windows.Forms.TextBox()
        CType(Me.db_ventasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporteDetalle_ventaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.reporteDetalle_ventaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MVC.reporteDetalle.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-5, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(743, 356)
        Me.ReportViewer1.TabIndex = 0
        '
        'db_ventasDataSet
        '
        Me.db_ventasDataSet.DataSetName = "db_ventasDataSet"
        Me.db_ventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'reporteDetalle_ventaBindingSource
        '
        Me.reporteDetalle_ventaBindingSource.DataMember = "reporteDetalle_venta"
        Me.reporteDetalle_ventaBindingSource.DataSource = Me.db_ventasDataSet
        '
        'reporteDetalle_ventaTableAdapter
        '
        Me.reporteDetalle_ventaTableAdapter.ClearBeforeFill = True
        '
        'txtIdVenta
        '
        Me.txtIdVenta.Location = New System.Drawing.Point(-5, 30)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtIdVenta.TabIndex = 1
        '
        'FormReporteDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 349)
        Me.Controls.Add(Me.txtIdVenta)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormReporteDetalle"
        Me.Text = "FormReporteDetalle"
        CType(Me.db_ventasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporteDetalle_ventaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents reporteDetalle_ventaBindingSource As BindingSource
    Friend WithEvents db_ventasDataSet As db_ventasDataSet
    Friend WithEvents reporteDetalle_ventaTableAdapter As db_ventasDataSetTableAdapters.reporteDetalle_ventaTableAdapter
    Friend WithEvents txtIdVenta As TextBox
End Class
