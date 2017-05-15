<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientosGastosRealizados
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
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.cboEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grupoGastos = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtIdGastoRealizado = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboConceptoGR = New System.Windows.Forms.ComboBox()
        Me.mskObservaciones = New System.Windows.Forms.MaskedTextBox()
        Me.mskIdGasto = New System.Windows.Forms.MaskedTextBox()
        Me.mskImporte = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.dgGastos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.rbConcepto = New System.Windows.Forms.RadioButton()
        Me.rbEmpleado = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.cboConcepto = New System.Windows.Forms.ComboBox()
        Me.dtpFechaBus = New System.Windows.Forms.DateTimePicker()
        Me.cboEmpleBus = New System.Windows.Forms.ComboBox()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.grupoBusqueda = New System.Windows.Forms.GroupBox()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.grupoGastos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.txtDomicilio)
        Me.GroupBox1.Controls.Add(Me.txtIdEmpleado)
        Me.GroupBox1.Controls.Add(Me.cboEmpleado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de empleado"
        '
        'txtTel
        '
        Me.txtTel.Enabled = False
        Me.txtTel.Location = New System.Drawing.Point(502, 69)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.ReadOnly = True
        Me.txtTel.Size = New System.Drawing.Size(100, 20)
        Me.txtTel.TabIndex = 8
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Enabled = False
        Me.txtDomicilio.Location = New System.Drawing.Point(111, 68)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.ReadOnly = True
        Me.txtDomicilio.Size = New System.Drawing.Size(272, 20)
        Me.txtDomicilio.TabIndex = 7
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Enabled = False
        Me.txtIdEmpleado.Location = New System.Drawing.Point(502, 32)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.ReadOnly = True
        Me.txtIdEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtIdEmpleado.TabIndex = 6
        '
        'cboEmpleado
        '
        Me.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpleado.Enabled = False
        Me.cboEmpleado.FormattingEnabled = True
        Me.cboEmpleado.Location = New System.Drawing.Point(111, 27)
        Me.cboEmpleado.Name = "cboEmpleado"
        Me.cboEmpleado.Size = New System.Drawing.Size(187, 21)
        Me.cboEmpleado.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(426, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Teléfono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Domicilio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(396, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Id_Empleado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empleado"
        '
        'grupoGastos
        '
        Me.grupoGastos.Controls.Add(Me.Label9)
        Me.grupoGastos.Controls.Add(Me.label)
        Me.grupoGastos.Controls.Add(Me.dtpFecha)
        Me.grupoGastos.Controls.Add(Me.txtIdGastoRealizado)
        Me.grupoGastos.Location = New System.Drawing.Point(12, 37)
        Me.grupoGastos.Name = "grupoGastos"
        Me.grupoGastos.Size = New System.Drawing.Size(632, 52)
        Me.grupoGastos.TabIndex = 5
        Me.grupoGastos.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Fecha"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(442, 16)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(70, 16)
        Me.label.TabIndex = 3
        Me.label.Text = "Id_Gasto"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(67, 16)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(149, 20)
        Me.dtpFecha.TabIndex = 0
        Me.dtpFecha.Value = New Date(2017, 3, 14, 0, 0, 0, 0)
        '
        'txtIdGastoRealizado
        '
        Me.txtIdGastoRealizado.Enabled = False
        Me.txtIdGastoRealizado.Location = New System.Drawing.Point(518, 16)
        Me.txtIdGastoRealizado.Name = "txtIdGastoRealizado"
        Me.txtIdGastoRealizado.Size = New System.Drawing.Size(100, 20)
        Me.txtIdGastoRealizado.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboConceptoGR)
        Me.GroupBox2.Controls.Add(Me.mskObservaciones)
        Me.GroupBox2.Controls.Add(Me.mskIdGasto)
        Me.GroupBox2.Controls.Add(Me.mskImporte)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 129)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de gasto"
        '
        'cboConceptoGR
        '
        Me.cboConceptoGR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConceptoGR.Enabled = False
        Me.cboConceptoGR.FormattingEnabled = True
        Me.cboConceptoGR.Location = New System.Drawing.Point(150, 26)
        Me.cboConceptoGR.Name = "cboConceptoGR"
        Me.cboConceptoGR.Size = New System.Drawing.Size(121, 21)
        Me.cboConceptoGR.TabIndex = 9
        '
        'mskObservaciones
        '
        Me.mskObservaciones.Enabled = False
        Me.mskObservaciones.Location = New System.Drawing.Point(301, 94)
        Me.mskObservaciones.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL"
        Me.mskObservaciones.Name = "mskObservaciones"
        Me.mskObservaciones.Size = New System.Drawing.Size(316, 20)
        Me.mskObservaciones.TabIndex = 11
        '
        'mskIdGasto
        '
        Me.mskIdGasto.Enabled = False
        Me.mskIdGasto.Location = New System.Drawing.Point(391, 29)
        Me.mskIdGasto.Name = "mskIdGasto"
        Me.mskIdGasto.Size = New System.Drawing.Size(100, 20)
        Me.mskIdGasto.TabIndex = 10
        '
        'mskImporte
        '
        Me.mskImporte.Enabled = False
        Me.mskImporte.Location = New System.Drawing.Point(138, 77)
        Me.mskImporte.Mask = "000000.00"
        Me.mskImporte.Name = "mskImporte"
        Me.mskImporte.Size = New System.Drawing.Size(100, 20)
        Me.mskImporte.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(298, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Observaciones"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(298, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Id_Gasto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Importe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Concepto gasto"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Image = Global.Sistema.My.Resources.Resources.Add_Property_30
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 654)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(89, 43)
        Me.cmdNuevo.TabIndex = 2
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabar.Image = Global.Sistema.My.Resources.Resources.Save_30
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGrabar.Location = New System.Drawing.Point(362, 655)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(89, 43)
        Me.cmdGrabar.TabIndex = 3
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Image = Global.Sistema.My.Resources.Resources.Exit_Sign_30
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(546, 654)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(89, 43)
        Me.cmdSalir.TabIndex = 5
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'dgGastos
        '
        Me.dgGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column4, Me.Column5})
        Me.dgGastos.Location = New System.Drawing.Point(12, 461)
        Me.dgGastos.Name = "dgGastos"
        Me.dgGastos.ReadOnly = True
        Me.dgGastos.Size = New System.Drawing.Size(632, 187)
        Me.dgGastos.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "id_Gasto"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "Fecha"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 70
        '
        'Column3
        '
        Me.Column3.HeaderText = "id_Empleado"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 70
        '
        'Column6
        '
        Me.Column6.HeaderText = "Nombre empleado"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 135
        '
        'Column4
        '
        Me.Column4.HeaderText = "Concepto"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 135
        '
        'Column5
        '
        Me.Column5.HeaderText = "Importe"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFecha.Location = New System.Drawing.Point(24, 19)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(67, 22)
        Me.rbFecha.TabIndex = 7
        Me.rbFecha.TabStop = True
        Me.rbFecha.Text = "Fecha"
        Me.rbFecha.UseVisualStyleBackColor = True
        '
        'rbConcepto
        '
        Me.rbConcepto.AutoSize = True
        Me.rbConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbConcepto.Location = New System.Drawing.Point(24, 50)
        Me.rbConcepto.Name = "rbConcepto"
        Me.rbConcepto.Size = New System.Drawing.Size(91, 22)
        Me.rbConcepto.TabIndex = 8
        Me.rbConcepto.TabStop = True
        Me.rbConcepto.Text = "Concepto"
        Me.rbConcepto.UseVisualStyleBackColor = True
        '
        'rbEmpleado
        '
        Me.rbEmpleado.AutoSize = True
        Me.rbEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEmpleado.Location = New System.Drawing.Point(24, 80)
        Me.rbEmpleado.Name = "rbEmpleado"
        Me.rbEmpleado.Size = New System.Drawing.Size(93, 22)
        Me.rbEmpleado.TabIndex = 9
        Me.rbEmpleado.TabStop = True
        Me.rbEmpleado.Text = "Empleado"
        Me.rbEmpleado.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodos.Location = New System.Drawing.Point(431, 19)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(69, 22)
        Me.rbTodos.TabIndex = 10
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'cboConcepto
        '
        Me.cboConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConcepto.FormattingEnabled = True
        Me.cboConcepto.Location = New System.Drawing.Point(122, 50)
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.Size = New System.Drawing.Size(165, 21)
        Me.cboConcepto.TabIndex = 11
        Me.cboConcepto.Visible = False
        '
        'dtpFechaBus
        '
        Me.dtpFechaBus.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaBus.Location = New System.Drawing.Point(121, 19)
        Me.dtpFechaBus.Name = "dtpFechaBus"
        Me.dtpFechaBus.Size = New System.Drawing.Size(165, 20)
        Me.dtpFechaBus.TabIndex = 5
        Me.dtpFechaBus.Value = New Date(2017, 3, 14, 0, 0, 0, 0)
        Me.dtpFechaBus.Visible = False
        '
        'cboEmpleBus
        '
        Me.cboEmpleBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpleBus.FormattingEnabled = True
        Me.cboEmpleBus.Location = New System.Drawing.Point(121, 80)
        Me.cboEmpleBus.Name = "cboEmpleBus"
        Me.cboEmpleBus.Size = New System.Drawing.Size(165, 21)
        Me.cboEmpleBus.TabIndex = 12
        Me.cboEmpleBus.Visible = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(431, 52)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(90, 45)
        Me.cmdAceptar.TabIndex = 13
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'grupoBusqueda
        '
        Me.grupoBusqueda.Controls.Add(Me.cmdAceptar)
        Me.grupoBusqueda.Controls.Add(Me.rbFecha)
        Me.grupoBusqueda.Controls.Add(Me.cboEmpleBus)
        Me.grupoBusqueda.Controls.Add(Me.rbConcepto)
        Me.grupoBusqueda.Controls.Add(Me.dtpFechaBus)
        Me.grupoBusqueda.Controls.Add(Me.rbEmpleado)
        Me.grupoBusqueda.Controls.Add(Me.cboConcepto)
        Me.grupoBusqueda.Controls.Add(Me.rbTodos)
        Me.grupoBusqueda.Enabled = False
        Me.grupoBusqueda.Location = New System.Drawing.Point(12, 344)
        Me.grupoBusqueda.Name = "grupoBusqueda"
        Me.grupoBusqueda.Size = New System.Drawing.Size(632, 111)
        Me.grupoBusqueda.TabIndex = 14
        Me.grupoBusqueda.TabStop = False
        Me.grupoBusqueda.Text = "Busqueda por..."
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdConsultar.Location = New System.Drawing.Point(187, 655)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(89, 43)
        Me.cmdConsultar.TabIndex = 15
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(180, -7)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(313, 41)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "Gastos realizados"
        '
        'frmMovimientosGastosRealizados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 710)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.grupoBusqueda)
        Me.Controls.Add(Me.dgGastos)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.grupoGastos)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMovimientosGastosRealizados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gastos realizados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grupoGastos.ResumeLayout(False)
        Me.grupoGastos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoBusqueda.ResumeLayout(False)
        Me.grupoBusqueda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtIdEmpleado As TextBox
    Friend WithEvents grupoGastos As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents label As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtIdGastoRealizado As TextBox
    Friend WithEvents cboEmpleado As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mskIdGasto As MaskedTextBox
    Friend WithEvents mskImporte As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents dgGastos As DataGridView
    Friend WithEvents rbFecha As RadioButton
    Friend WithEvents rbConcepto As RadioButton
    Friend WithEvents rbEmpleado As RadioButton
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents cboConcepto As ComboBox
    Friend WithEvents dtpFechaBus As DateTimePicker
    Friend WithEvents cboEmpleBus As ComboBox
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents grupoBusqueda As GroupBox
    Friend WithEvents cboConceptoGR As ComboBox
    Friend WithEvents mskObservaciones As MaskedTextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents cmdConsultar As Button
    Friend WithEvents Label22 As Label
End Class
