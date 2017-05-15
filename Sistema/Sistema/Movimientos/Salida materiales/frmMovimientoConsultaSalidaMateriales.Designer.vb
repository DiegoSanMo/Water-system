<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientoConsultaSalidaMateriales
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblInicial = New System.Windows.Forms.Label()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.cboCalle = New System.Windows.Forms.ComboBox()
        Me.cboEmpleado = New System.Windows.Forms.ComboBox()
        Me.rbGeneral = New System.Windows.Forms.RadioButton()
        Me.rbPeriodo = New System.Windows.Forms.RadioButton()
        Me.rbSalida = New System.Windows.Forms.RadioButton()
        Me.rbCalle = New System.Windows.Forms.RadioButton()
        Me.rbEmpleado = New System.Windows.Forms.RadioButton()
        Me.txtNoSalida = New System.Windows.Forms.TextBox()
        Me.btnDetalles = New System.Windows.Forms.Button()
        Me.dgConsultaS = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgConsultaS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lblFinal)
        Me.GroupBox1.Controls.Add(Me.lblInicial)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.cboCalle)
        Me.GroupBox1.Controls.Add(Me.cboEmpleado)
        Me.GroupBox1.Controls.Add(Me.rbGeneral)
        Me.GroupBox1.Controls.Add(Me.rbPeriodo)
        Me.GroupBox1.Controls.Add(Me.rbSalida)
        Me.GroupBox1.Controls.Add(Me.rbCalle)
        Me.GroupBox1.Controls.Add(Me.rbEmpleado)
        Me.GroupBox1.Controls.Add(Me.txtNoSalida)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(685, 147)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(523, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 49)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(565, 17)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(59, 13)
        Me.lblFinal.TabIndex = 17
        Me.lblFinal.Text = "Fecha final"
        Me.lblFinal.Visible = False
        '
        'lblInicial
        '
        Me.lblInicial.AutoSize = True
        Me.lblInicial.Location = New System.Drawing.Point(454, 16)
        Me.lblInicial.Name = "lblInicial"
        Me.lblInicial.Size = New System.Drawing.Size(66, 13)
        Me.lblInicial.TabIndex = 16
        Me.lblInicial.Text = "Fecha inicial"
        Me.lblInicial.Visible = False
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(568, 33)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(91, 20)
        Me.dtpFechaFinal.TabIndex = 15
        Me.dtpFechaFinal.Visible = False
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(457, 32)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(91, 20)
        Me.dtpFechaInicial.TabIndex = 14
        Me.dtpFechaInicial.Visible = False
        '
        'cboCalle
        '
        Me.cboCalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCalle.FormattingEnabled = True
        Me.cboCalle.Location = New System.Drawing.Point(147, 110)
        Me.cboCalle.Name = "cboCalle"
        Me.cboCalle.Size = New System.Drawing.Size(121, 21)
        Me.cboCalle.TabIndex = 13
        Me.cboCalle.Visible = False
        '
        'cboEmpleado
        '
        Me.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpleado.FormattingEnabled = True
        Me.cboEmpleado.Location = New System.Drawing.Point(147, 67)
        Me.cboEmpleado.Name = "cboEmpleado"
        Me.cboEmpleado.Size = New System.Drawing.Size(121, 21)
        Me.cboEmpleado.TabIndex = 12
        Me.cboEmpleado.Visible = False
        '
        'rbGeneral
        '
        Me.rbGeneral.AutoSize = True
        Me.rbGeneral.Location = New System.Drawing.Point(355, 73)
        Me.rbGeneral.Name = "rbGeneral"
        Me.rbGeneral.Size = New System.Drawing.Size(62, 17)
        Me.rbGeneral.TabIndex = 11
        Me.rbGeneral.TabStop = True
        Me.rbGeneral.Text = "General"
        Me.rbGeneral.UseVisualStyleBackColor = True
        '
        'rbPeriodo
        '
        Me.rbPeriodo.AutoSize = True
        Me.rbPeriodo.Location = New System.Drawing.Point(355, 27)
        Me.rbPeriodo.Name = "rbPeriodo"
        Me.rbPeriodo.Size = New System.Drawing.Size(61, 17)
        Me.rbPeriodo.TabIndex = 10
        Me.rbPeriodo.TabStop = True
        Me.rbPeriodo.Text = "Periodo"
        Me.rbPeriodo.UseVisualStyleBackColor = True
        '
        'rbSalida
        '
        Me.rbSalida.AutoSize = True
        Me.rbSalida.Location = New System.Drawing.Point(32, 31)
        Me.rbSalida.Name = "rbSalida"
        Me.rbSalida.Size = New System.Drawing.Size(86, 17)
        Me.rbSalida.TabIndex = 8
        Me.rbSalida.TabStop = True
        Me.rbSalida.Text = "No de Salida"
        Me.rbSalida.UseVisualStyleBackColor = True
        '
        'rbCalle
        '
        Me.rbCalle.AutoSize = True
        Me.rbCalle.Location = New System.Drawing.Point(32, 114)
        Me.rbCalle.Name = "rbCalle"
        Me.rbCalle.Size = New System.Drawing.Size(48, 17)
        Me.rbCalle.TabIndex = 7
        Me.rbCalle.TabStop = True
        Me.rbCalle.Text = "Calle"
        Me.rbCalle.UseVisualStyleBackColor = True
        '
        'rbEmpleado
        '
        Me.rbEmpleado.AutoSize = True
        Me.rbEmpleado.Location = New System.Drawing.Point(32, 71)
        Me.rbEmpleado.Name = "rbEmpleado"
        Me.rbEmpleado.Size = New System.Drawing.Size(72, 17)
        Me.rbEmpleado.TabIndex = 6
        Me.rbEmpleado.TabStop = True
        Me.rbEmpleado.Text = "Empleado"
        Me.rbEmpleado.UseVisualStyleBackColor = True
        '
        'txtNoSalida
        '
        Me.txtNoSalida.Location = New System.Drawing.Point(147, 26)
        Me.txtNoSalida.Name = "txtNoSalida"
        Me.txtNoSalida.Size = New System.Drawing.Size(120, 20)
        Me.txtNoSalida.TabIndex = 5
        Me.txtNoSalida.Visible = False
        '
        'btnDetalles
        '
        Me.btnDetalles.Location = New System.Drawing.Point(604, 165)
        Me.btnDetalles.Name = "btnDetalles"
        Me.btnDetalles.Size = New System.Drawing.Size(93, 25)
        Me.btnDetalles.TabIndex = 19
        Me.btnDetalles.Text = "Ver detalles"
        Me.btnDetalles.UseVisualStyleBackColor = True
        Me.btnDetalles.Visible = False
        '
        'dgConsultaS
        '
        Me.dgConsultaS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgConsultaS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgConsultaS.Location = New System.Drawing.Point(12, 196)
        Me.dgConsultaS.Name = "dgConsultaS"
        Me.dgConsultaS.Size = New System.Drawing.Size(685, 150)
        Me.dgConsultaS.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Salida"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Empleado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 220
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Calle"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'frmMovimientoConsultaSalidaMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 372)
        Me.Controls.Add(Me.dgConsultaS)
        Me.Controls.Add(Me.btnDetalles)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMovimientoConsultaSalidaMateriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de salidas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgConsultaS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFinal As Label
    Friend WithEvents lblInicial As Label
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents cboCalle As ComboBox
    Friend WithEvents cboEmpleado As ComboBox
    Friend WithEvents rbGeneral As RadioButton
    Friend WithEvents rbPeriodo As RadioButton
    Friend WithEvents rbSalida As RadioButton
    Friend WithEvents rbCalle As RadioButton
    Friend WithEvents rbEmpleado As RadioButton
    Friend WithEvents txtNoSalida As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnDetalles As Button
    Friend WithEvents dgConsultaS As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
