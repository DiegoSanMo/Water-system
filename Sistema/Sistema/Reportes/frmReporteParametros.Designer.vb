<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReporteParametros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteParametros))
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInicial = New System.Windows.Forms.Label()
        Me.lblFechaFinal = New System.Windows.Forms.Label()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.lblGastosPorPeriodo = New System.Windows.Forms.Label()
        Me.lblHistorial = New System.Windows.Forms.Label()
        Me.lblEntradasPeriodo = New System.Windows.Forms.Label()
        Me.lblSalidaMaterial = New System.Windows.Forms.Label()
        Me.lblPagosPer = New System.Windows.Forms.Label()
        Me.lblactividadPozos = New System.Windows.Forms.Label()
        Me.lblServiciosPeriodo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(173, 56)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaInicial.TabIndex = 0
        Me.dtpFechaInicial.Value = New Date(2017, 5, 4, 0, 0, 0, 0)
        Me.dtpFechaInicial.Visible = False
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(398, 56)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaFinal.TabIndex = 1
        Me.dtpFechaFinal.Value = New Date(2017, 5, 4, 0, 0, 0, 0)
        Me.dtpFechaFinal.Visible = False
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.AutoSize = True
        Me.lblFechaInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicial.Location = New System.Drawing.Point(55, 58)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(96, 16)
        Me.lblFechaInicial.TabIndex = 2
        Me.lblFechaInicial.Text = "Fecha inicial"
        Me.lblFechaInicial.Visible = False
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.AutoSize = True
        Me.lblFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFinal.Location = New System.Drawing.Point(292, 58)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(84, 16)
        Me.lblFechaFinal.TabIndex = 3
        Me.lblFechaFinal.Text = "Fecha final"
        Me.lblFechaFinal.Visible = False
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(398, 50)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(97, 40)
        Me.btnBuscarCliente.TabIndex = 7
        Me.btnBuscarCliente.Text = "Buscar cliente (cuenta)"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        Me.btnBuscarCliente.Visible = False
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(77, 61)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.ReadOnly = True
        Me.txtNombreCliente.Size = New System.Drawing.Size(258, 20)
        Me.txtNombreCliente.TabIndex = 9
        Me.txtNombreCliente.Visible = False
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(74, 45)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(93, 13)
        Me.lblNom.TabIndex = 10
        Me.lblNom.Text = "Nombre de cliente"
        Me.lblNom.Visible = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Image = Global.Sistema.My.Resources.Resources.Checked_48
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAceptar.Location = New System.Drawing.Point(501, 26)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(82, 64)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'lblGastosPorPeriodo
        '
        Me.lblGastosPorPeriodo.AutoSize = True
        Me.lblGastosPorPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGastosPorPeriodo.Location = New System.Drawing.Point(169, 20)
        Me.lblGastosPorPeriodo.Name = "lblGastosPorPeriodo"
        Me.lblGastosPorPeriodo.Size = New System.Drawing.Size(188, 24)
        Me.lblGastosPorPeriodo.TabIndex = 11
        Me.lblGastosPorPeriodo.Text = "Gastos por periodo"
        Me.lblGastosPorPeriodo.Visible = False
        '
        'lblHistorial
        '
        Me.lblHistorial.AutoSize = True
        Me.lblHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistorial.Location = New System.Drawing.Point(138, 20)
        Me.lblHistorial.Name = "lblHistorial"
        Me.lblHistorial.Size = New System.Drawing.Size(283, 24)
        Me.lblHistorial.TabIndex = 12
        Me.lblHistorial.Text = "Historial de pagos por cliente"
        Me.lblHistorial.Visible = False
        '
        'lblEntradasPeriodo
        '
        Me.lblEntradasPeriodo.AutoSize = True
        Me.lblEntradasPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntradasPeriodo.Location = New System.Drawing.Point(120, 21)
        Me.lblEntradasPeriodo.Name = "lblEntradasPeriodo"
        Me.lblEntradasPeriodo.Size = New System.Drawing.Size(346, 24)
        Me.lblEntradasPeriodo.TabIndex = 13
        Me.lblEntradasPeriodo.Text = "Entradas de material por un periodo"
        Me.lblEntradasPeriodo.Visible = False
        '
        'lblSalidaMaterial
        '
        Me.lblSalidaMaterial.AutoSize = True
        Me.lblSalidaMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalidaMaterial.Location = New System.Drawing.Point(138, 21)
        Me.lblSalidaMaterial.Name = "lblSalidaMaterial"
        Me.lblSalidaMaterial.Size = New System.Drawing.Size(321, 24)
        Me.lblSalidaMaterial.TabIndex = 14
        Me.lblSalidaMaterial.Text = "Salida de material por un periodo"
        Me.lblSalidaMaterial.Visible = False
        '
        'lblPagosPer
        '
        Me.lblPagosPer.AutoSize = True
        Me.lblPagosPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagosPer.Location = New System.Drawing.Point(138, 20)
        Me.lblPagosPer.Name = "lblPagosPer"
        Me.lblPagosPer.Size = New System.Drawing.Size(307, 24)
        Me.lblPagosPer.TabIndex = 15
        Me.lblPagosPer.Text = "Pagos realizados en un periodo"
        Me.lblPagosPer.Visible = False
        '
        'lblactividadPozos
        '
        Me.lblactividadPozos.AutoSize = True
        Me.lblactividadPozos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblactividadPozos.Location = New System.Drawing.Point(134, 21)
        Me.lblactividadPozos.Name = "lblactividadPozos"
        Me.lblactividadPozos.Size = New System.Drawing.Size(325, 24)
        Me.lblactividadPozos.TabIndex = 16
        Me.lblactividadPozos.Text = "Actividad de pozos en un periodo"
        Me.lblactividadPozos.Visible = False
        '
        'lblServiciosPeriodo
        '
        Me.lblServiciosPeriodo.AutoSize = True
        Me.lblServiciosPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiciosPeriodo.Location = New System.Drawing.Point(134, 21)
        Me.lblServiciosPeriodo.Name = "lblServiciosPeriodo"
        Me.lblServiciosPeriodo.Size = New System.Drawing.Size(307, 24)
        Me.lblServiciosPeriodo.TabIndex = 17
        Me.lblServiciosPeriodo.Text = "Servicios atendidos por periodo"
        Me.lblServiciosPeriodo.Visible = False
        '
        'frmReporteParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 125)
        Me.Controls.Add(Me.lblServiciosPeriodo)
        Me.Controls.Add(Me.lblactividadPozos)
        Me.Controls.Add(Me.lblPagosPer)
        Me.Controls.Add(Me.lblSalidaMaterial)
        Me.Controls.Add(Me.lblEntradasPeriodo)
        Me.Controls.Add(Me.lblHistorial)
        Me.Controls.Add(Me.lblGastosPorPeriodo)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.lblFechaFinal)
        Me.Controls.Add(Me.lblFechaInicial)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReporteParametros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents lblNom As Label
    Friend WithEvents lblGastosPorPeriodo As Label
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents lblFechaInicial As Label
    Friend WithEvents lblFechaFinal As Label
    Friend WithEvents lblHistorial As Label
    Friend WithEvents lblEntradasPeriodo As Label
    Friend WithEvents lblSalidaMaterial As Label
    Friend WithEvents lblPagosPer As Label
    Friend WithEvents lblactividadPozos As Label
    Friend WithEvents lblServiciosPeriodo As Label
End Class
