<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCatalogoCuentas
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
        Me.components = New System.ComponentModel.Container()
        Me.cboCalle = New System.Windows.Forms.ComboBox()
        Me.CallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSistema = New Sistema.DataSetSistema()
        Me.CallesTableAdapter = New Sistema.DataSetSistemaTableAdapters.callesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNombreCue = New System.Windows.Forms.TextBox()
        Me.dtpFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNoInt = New System.Windows.Forms.TextBox()
        Me.txtNoExt = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgCuenta = New System.Windows.Forms.DataGridView()
        Me.IdcuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdcalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoExisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoIntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPagoADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPagoMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentasTableAdapter = New Sistema.DataSetSistemaTableAdapters.cuentasTableAdapter()
        CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboCalle
        '
        Me.cboCalle.DataSource = Me.CallesBindingSource
        Me.cboCalle.DisplayMember = "nombre"
        Me.cboCalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCalle.Enabled = False
        Me.cboCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCalle.FormattingEnabled = True
        Me.cboCalle.Location = New System.Drawing.Point(112, 81)
        Me.cboCalle.Name = "cboCalle"
        Me.cboCalle.Size = New System.Drawing.Size(175, 26)
        Me.cboCalle.TabIndex = 0
        Me.cboCalle.ValueMember = "id_calle"
        '
        'CallesBindingSource
        '
        Me.CallesBindingSource.DataMember = "calles"
        Me.CallesBindingSource.DataSource = Me.DataSetSistema
        '
        'DataSetSistema
        '
        Me.DataSetSistema.DataSetName = "DataSetSistema"
        Me.DataSetSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CallesTableAdapter
        '
        Me.CallesTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id_Cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Calle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(610, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "No. Exterior"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(616, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "No. Interior"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(599, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Fecha de Alta"
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "id_cuenta", True))
        Me.txtIdCuenta.Enabled = False
        Me.txtIdCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCuenta.Location = New System.Drawing.Point(112, 16)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.Size = New System.Drawing.Size(100, 24)
        Me.txtIdCuenta.TabIndex = 9
        '
        'CuentasBindingSource
        '
        Me.CuentasBindingSource.DataMember = "cuentas"
        Me.CuentasBindingSource.DataSource = Me.DataSetSistema
        '
        'txtNombreCue
        '
        Me.txtNombreCue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "nombre", True))
        Me.txtNombreCue.Enabled = False
        Me.txtNombreCue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCue.Location = New System.Drawing.Point(112, 49)
        Me.txtNombreCue.MaxLength = 50
        Me.txtNombreCue.Name = "txtNombreCue"
        Me.txtNombreCue.Size = New System.Drawing.Size(408, 24)
        Me.txtNombreCue.TabIndex = 10
        '
        'dtpFechaAlta
        '
        Me.dtpFechaAlta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "fechaAlta", True))
        Me.dtpFechaAlta.Enabled = False
        Me.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaAlta.Location = New System.Drawing.Point(715, 18)
        Me.dtpFechaAlta.Name = "dtpFechaAlta"
        Me.dtpFechaAlta.Size = New System.Drawing.Size(103, 20)
        Me.dtpFechaAlta.TabIndex = 13
        Me.dtpFechaAlta.Value = New Date(2017, 2, 27, 0, 0, 0, 0)
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Image = Global.Sistema.My.Resources.Resources.Exit_Sign_30
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(759, 402)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(97, 39)
        Me.cmdSalir.TabIndex = 19
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabar.Image = Global.Sistema.My.Resources.Resources.Save_30
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGrabar.Location = New System.Drawing.Point(256, 402)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(97, 39)
        Me.cmdGrabar.TabIndex = 18
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Image = Global.Sistema.My.Resources.Resources.Add_Property_30
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 402)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(97, 39)
        Me.cmdNuevo.TabIndex = 17
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUltimo.Location = New System.Drawing.Point(507, 162)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(76, 28)
        Me.cmdUltimo.TabIndex = 23
        Me.cmdUltimo.Text = "Último"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSiguiente.Location = New System.Drawing.Point(415, 162)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(86, 28)
        Me.cmdSiguiente.TabIndex = 22
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnterior.Location = New System.Drawing.Point(337, 162)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(72, 28)
        Me.cmdAnterior.TabIndex = 21
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInicio.Location = New System.Drawing.Point(275, 162)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(56, 28)
        Me.cmdInicio.TabIndex = 20
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNoInt)
        Me.GroupBox1.Controls.Add(Me.txtNoExt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpFechaAlta)
        Me.GroupBox1.Controls.Add(Me.txtIdCuenta)
        Me.GroupBox1.Controls.Add(Me.cboCalle)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombreCue)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(844, 118)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'txtNoInt
        '
        Me.txtNoInt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "noInt", True))
        Me.txtNoInt.Location = New System.Drawing.Point(715, 81)
        Me.txtNoInt.MaxLength = 7
        Me.txtNoInt.Name = "txtNoInt"
        Me.txtNoInt.ReadOnly = True
        Me.txtNoInt.Size = New System.Drawing.Size(103, 20)
        Me.txtNoInt.TabIndex = 15
        '
        'txtNoExt
        '
        Me.txtNoExt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "noExis", True))
        Me.txtNoExt.Location = New System.Drawing.Point(715, 52)
        Me.txtNoExt.MaxLength = 7
        Me.txtNoExt.Name = "txtNoExt"
        Me.txtNoExt.ReadOnly = True
        Me.txtNoExt.Size = New System.Drawing.Size(103, 20)
        Me.txtNoExt.TabIndex = 14
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Image = Global.Sistema.My.Resources.Resources.Cancel_30
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(500, 402)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(112, 39)
        Me.cmdCancelar.TabIndex = 29
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(269, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(282, 31)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Catálogo de cuentas"
        '
        'dgCuenta
        '
        Me.dgCuenta.AllowUserToAddRows = False
        Me.dgCuenta.AutoGenerateColumns = False
        Me.dgCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdcuentaDataGridViewTextBoxColumn, Me.IdcalleDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.NoExisDataGridViewTextBoxColumn, Me.NoIntDataGridViewTextBoxColumn, Me.FechaAltaDataGridViewTextBoxColumn, Me.UltimoPagoADataGridViewTextBoxColumn, Me.UltimoPagoMDataGridViewTextBoxColumn})
        Me.dgCuenta.DataSource = Me.CuentasBindingSource
        Me.dgCuenta.Location = New System.Drawing.Point(12, 196)
        Me.dgCuenta.Name = "dgCuenta"
        Me.dgCuenta.ReadOnly = True
        Me.dgCuenta.Size = New System.Drawing.Size(844, 200)
        Me.dgCuenta.TabIndex = 30
        '
        'IdcuentaDataGridViewTextBoxColumn
        '
        Me.IdcuentaDataGridViewTextBoxColumn.DataPropertyName = "id_cuenta"
        Me.IdcuentaDataGridViewTextBoxColumn.HeaderText = "id_cuenta"
        Me.IdcuentaDataGridViewTextBoxColumn.Name = "IdcuentaDataGridViewTextBoxColumn"
        Me.IdcuentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdcalleDataGridViewTextBoxColumn
        '
        Me.IdcalleDataGridViewTextBoxColumn.DataPropertyName = "id_calle"
        Me.IdcalleDataGridViewTextBoxColumn.HeaderText = "id_calle"
        Me.IdcalleDataGridViewTextBoxColumn.Name = "IdcalleDataGridViewTextBoxColumn"
        Me.IdcalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoExisDataGridViewTextBoxColumn
        '
        Me.NoExisDataGridViewTextBoxColumn.DataPropertyName = "noExis"
        Me.NoExisDataGridViewTextBoxColumn.HeaderText = "noExis"
        Me.NoExisDataGridViewTextBoxColumn.Name = "NoExisDataGridViewTextBoxColumn"
        Me.NoExisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoIntDataGridViewTextBoxColumn
        '
        Me.NoIntDataGridViewTextBoxColumn.DataPropertyName = "noInt"
        Me.NoIntDataGridViewTextBoxColumn.HeaderText = "noInt"
        Me.NoIntDataGridViewTextBoxColumn.Name = "NoIntDataGridViewTextBoxColumn"
        Me.NoIntDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaAltaDataGridViewTextBoxColumn
        '
        Me.FechaAltaDataGridViewTextBoxColumn.DataPropertyName = "fechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.HeaderText = "fechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.Name = "FechaAltaDataGridViewTextBoxColumn"
        Me.FechaAltaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UltimoPagoADataGridViewTextBoxColumn
        '
        Me.UltimoPagoADataGridViewTextBoxColumn.DataPropertyName = "ultimoPagoA"
        Me.UltimoPagoADataGridViewTextBoxColumn.HeaderText = "ultimoPagoA"
        Me.UltimoPagoADataGridViewTextBoxColumn.Name = "UltimoPagoADataGridViewTextBoxColumn"
        Me.UltimoPagoADataGridViewTextBoxColumn.ReadOnly = True
        '
        'UltimoPagoMDataGridViewTextBoxColumn
        '
        Me.UltimoPagoMDataGridViewTextBoxColumn.DataPropertyName = "ultimoPagoM"
        Me.UltimoPagoMDataGridViewTextBoxColumn.HeaderText = "ultimoPagoM"
        Me.UltimoPagoMDataGridViewTextBoxColumn.Name = "UltimoPagoMDataGridViewTextBoxColumn"
        Me.UltimoPagoMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
        '
        'frmCatalogoCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgCuenta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCatalogoCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCatalogoCuentas"
        CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCalle As ComboBox
    Friend WithEvents DataSetSistema As DataSetSistema
    Friend WithEvents CallesBindingSource As BindingSource
    Friend WithEvents CallesTableAdapter As DataSetSistemaTableAdapters.callesTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIdCuenta As TextBox
    Friend WithEvents txtNombreCue As TextBox
    Friend WithEvents dtpFechaAlta As DateTimePicker
    Friend WithEvents IdcuentasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmdUltimo As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdInicio As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dgCuenta As DataGridView
    Friend WithEvents CuentasBindingSource As BindingSource
    Friend WithEvents txtNoInt As TextBox
    Friend WithEvents txtNoExt As TextBox
    Friend WithEvents CuentasTableAdapter As DataSetSistemaTableAdapters.cuentasTableAdapter
    Friend WithEvents IdcuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdcalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoExisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoIntDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UltimoPagoADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UltimoPagoMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
