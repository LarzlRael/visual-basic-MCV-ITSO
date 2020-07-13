<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportUserNoValidate
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
        Me.db_ventasDataSet1 = New MVC.db_ventasDataSet1()
        Me.reporte_usuarios_novalidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reporte_usuarios_novalidosTableAdapter = New MVC.db_ventasDataSet1TableAdapters.reporte_usuarios_novalidosTableAdapter()
        CType(Me.db_ventasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporte_usuarios_novalidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.reporte_usuarios_novalidosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MVC.ReportuserNovalidate.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(864, 538)
        Me.ReportViewer1.TabIndex = 0
        '
        'db_ventasDataSet1
        '
        Me.db_ventasDataSet1.DataSetName = "db_ventasDataSet1"
        Me.db_ventasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'reporte_usuarios_novalidosBindingSource
        '
        Me.reporte_usuarios_novalidosBindingSource.DataMember = "reporte_usuarios_novalidos"
        Me.reporte_usuarios_novalidosBindingSource.DataSource = Me.db_ventasDataSet1
        '
        'reporte_usuarios_novalidosTableAdapter
        '
        Me.reporte_usuarios_novalidosTableAdapter.ClearBeforeFill = True
        '
        'FormReportUserNoValidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 539)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormReportUserNoValidate"
        Me.Text = "FormReportUserNoValidate"
        CType(Me.db_ventasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporte_usuarios_novalidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents reporte_usuarios_novalidosBindingSource As BindingSource
    Friend WithEvents db_ventasDataSet1 As db_ventasDataSet1
    Friend WithEvents reporte_usuarios_novalidosTableAdapter As db_ventasDataSet1TableAdapters.reporte_usuarios_novalidosTableAdapter
End Class
