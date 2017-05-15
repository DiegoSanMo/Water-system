<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogoMateriales
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
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgMateriales = New System.Windows.Forms.DataGridView()
        Me.MaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSistema = New Sistema.DataSetSistema()
        Me.MaterialTableAdapter = New Sistema.DataSetSistemaTableAdapters.materialTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIdMaterial = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mskMaximo = New System.Windows.Forms.MaskedTextBox()
        Me.mskExistencias = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mskMinimo = New System.Windows.Forms.MaskedTextBox()
        Me.mskCosto = New System.Windows.Forms.MaskedTextBox()
        Me.cmbUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.dtpFechaUlti = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.IdmaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaximoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinimoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimaFechaCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdInicio
        '
        Me.cmdInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInicio.Location = New System.Drawing.Point(30, 205)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(106, 28)
        Me.cmdInicio.TabIndex = 0
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id_Material"
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnterior.Location = New System.Drawing.Point(281, 205)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(106, 28)
        Me.cmdAnterior.TabIndex = 2
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSiguiente.Location = New System.Drawing.Point(536, 205)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(106, 28)
        Me.cmdSiguiente.TabIndex = 3
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUltimo.Location = New System.Drawing.Point(754, 205)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(106, 28)
        Me.cmdUltimo.TabIndex = 4
        Me.cmdUltimo.Text = "Último"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Image = Global.Sistema.My.Resources.Resources.Add_Property_30
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 437)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(107, 41)
        Me.cmdNuevo.TabIndex = 5
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabar.Image = Global.Sistema.My.Resources.Resources.Save_30
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGrabar.Location = New System.Drawing.Point(283, 437)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(103, 41)
        Me.cmdGrabar.TabIndex = 6
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Image = Global.Sistema.My.Resources.Resources.Exit_Sign_30
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(816, 437)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(86, 41)
        Me.cmdSalir.TabIndex = 7
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Existencias"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Máximo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Mínimo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Unidad de Medida"
        '
        'dgMateriales
        '
        Me.dgMateriales.AutoGenerateColumns = False
        Me.dgMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdmaterialDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ExistenciasDataGridViewTextBoxColumn, Me.MaximoDataGridViewTextBoxColumn, Me.MinimoDataGridViewTextBoxColumn, Me.UnidadDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.UltimaFechaCompraDataGridViewTextBoxColumn})
        Me.dgMateriales.DataSource = Me.MaterialBindingSource
        Me.dgMateriales.Location = New System.Drawing.Point(12, 239)
        Me.dgMateriales.Name = "dgMateriales"
        Me.dgMateriales.ReadOnly = True
        Me.dgMateriales.Size = New System.Drawing.Size(890, 192)
        Me.dgMateriales.TabIndex = 13
        '
        'MaterialBindingSource
        '
        Me.MaterialBindingSource.DataMember = "material"
        Me.MaterialBindingSource.DataSource = Me.DataSetSistema
        '
        'DataSetSistema
        '
        Me.DataSetSistema.DataSetName = "DataSetSistema"
        Me.DataSetSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaterialTableAdapter
        '
        Me.MaterialTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Costo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Ultima fecha de compra"
        '
        'txtIdMaterial
        '
        Me.txtIdMaterial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "id_material", True))
        Me.txtIdMaterial.Enabled = False
        Me.txtIdMaterial.Location = New System.Drawing.Point(121, 16)
        Me.txtIdMaterial.Name = "txtIdMaterial"
        Me.txtIdMaterial.Size = New System.Drawing.Size(100, 20)
        Me.txtIdMaterial.TabIndex = 16
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "descripcion", True))
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(121, 44)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(331, 20)
        Me.txtDescripcion.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mskMaximo)
        Me.GroupBox1.Controls.Add(Me.mskExistencias)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtIdMaterial)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 151)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'mskMaximo
        '
        Me.mskMaximo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "maximo", True))
        Me.mskMaximo.Enabled = False
        Me.mskMaximo.Location = New System.Drawing.Point(121, 109)
        Me.mskMaximo.Mask = "000000"
        Me.mskMaximo.Name = "mskMaximo"
        Me.mskMaximo.Size = New System.Drawing.Size(100, 20)
        Me.mskMaximo.TabIndex = 21
        '
        'mskExistencias
        '
        Me.mskExistencias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "existencias", True))
        Me.mskExistencias.Enabled = False
        Me.mskExistencias.Location = New System.Drawing.Point(121, 76)
        Me.mskExistencias.Mask = "000000"
        Me.mskExistencias.Name = "mskExistencias"
        Me.mskExistencias.Size = New System.Drawing.Size(100, 20)
        Me.mskExistencias.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mskMinimo)
        Me.GroupBox2.Controls.Add(Me.mskCosto)
        Me.GroupBox2.Controls.Add(Me.cmbUnidadMedida)
        Me.GroupBox2.Controls.Add(Me.dtpFechaUlti)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(476, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 150)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'mskMinimo
        '
        Me.mskMinimo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "minimo", True))
        Me.mskMinimo.Enabled = False
        Me.mskMinimo.Location = New System.Drawing.Point(170, 12)
        Me.mskMinimo.Mask = "000000"
        Me.mskMinimo.Name = "mskMinimo"
        Me.mskMinimo.Size = New System.Drawing.Size(100, 20)
        Me.mskMinimo.TabIndex = 22
        '
        'mskCosto
        '
        Me.mskCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "costo", True))
        Me.mskCosto.Enabled = False
        Me.mskCosto.Location = New System.Drawing.Point(169, 77)
        Me.mskCosto.Mask = "$999,999.00"
        Me.mskCosto.Name = "mskCosto"
        Me.mskCosto.Size = New System.Drawing.Size(100, 20)
        Me.mskCosto.TabIndex = 21
        '
        'cmbUnidadMedida
        '
        Me.cmbUnidadMedida.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "unidad", True))
        Me.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnidadMedida.Enabled = False
        Me.cmbUnidadMedida.FormattingEnabled = True
        Me.cmbUnidadMedida.Items.AddRange(New Object() {"CM", "GRS", "KGS", "LBS", "LTS", "MLT", "MTS", "PUL", "PZA"})
        Me.cmbUnidadMedida.Location = New System.Drawing.Point(169, 45)
        Me.cmbUnidadMedida.Name = "cmbUnidadMedida"
        Me.cmbUnidadMedida.Size = New System.Drawing.Size(121, 21)
        Me.cmbUnidadMedida.TabIndex = 24
        '
        'dtpFechaUlti
        '
        Me.dtpFechaUlti.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "ultimaFechaCompra", True))
        Me.dtpFechaUlti.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MaterialBindingSource, "ultimaFechaCompra", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.dtpFechaUlti.Enabled = False
        Me.dtpFechaUlti.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaUlti.Location = New System.Drawing.Point(170, 110)
        Me.dtpFechaUlti.Name = "dtpFechaUlti"
        Me.dtpFechaUlti.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaUlti.TabIndex = 23
        Me.dtpFechaUlti.Value = New Date(2017, 2, 23, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(274, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(337, 33)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Catálogo de materiales"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Image = Global.Sistema.My.Resources.Resources.Cancel_30
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(533, 437)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(111, 41)
        Me.cmdCancelar.TabIndex = 34
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'IdmaterialDataGridViewTextBoxColumn
        '
        Me.IdmaterialDataGridViewTextBoxColumn.DataPropertyName = "id_material"
        Me.IdmaterialDataGridViewTextBoxColumn.HeaderText = "id_material"
        Me.IdmaterialDataGridViewTextBoxColumn.Name = "IdmaterialDataGridViewTextBoxColumn"
        Me.IdmaterialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 150
        '
        'ExistenciasDataGridViewTextBoxColumn
        '
        Me.ExistenciasDataGridViewTextBoxColumn.DataPropertyName = "existencias"
        Me.ExistenciasDataGridViewTextBoxColumn.HeaderText = "existencias"
        Me.ExistenciasDataGridViewTextBoxColumn.Name = "ExistenciasDataGridViewTextBoxColumn"
        Me.ExistenciasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaximoDataGridViewTextBoxColumn
        '
        Me.MaximoDataGridViewTextBoxColumn.DataPropertyName = "maximo"
        Me.MaximoDataGridViewTextBoxColumn.HeaderText = "maximo"
        Me.MaximoDataGridViewTextBoxColumn.Name = "MaximoDataGridViewTextBoxColumn"
        Me.MaximoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MinimoDataGridViewTextBoxColumn
        '
        Me.MinimoDataGridViewTextBoxColumn.DataPropertyName = "minimo"
        Me.MinimoDataGridViewTextBoxColumn.HeaderText = "minimo"
        Me.MinimoDataGridViewTextBoxColumn.Name = "MinimoDataGridViewTextBoxColumn"
        Me.MinimoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnidadDataGridViewTextBoxColumn
        '
        Me.UnidadDataGridViewTextBoxColumn.DataPropertyName = "unidad"
        Me.UnidadDataGridViewTextBoxColumn.HeaderText = "unidad"
        Me.UnidadDataGridViewTextBoxColumn.Name = "UnidadDataGridViewTextBoxColumn"
        Me.UnidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UltimaFechaCompraDataGridViewTextBoxColumn
        '
        Me.UltimaFechaCompraDataGridViewTextBoxColumn.DataPropertyName = "ultimaFechaCompra"
        Me.UltimaFechaCompraDataGridViewTextBoxColumn.HeaderText = "ultimaFechaCompra"
        Me.UltimaFechaCompraDataGridViewTextBoxColumn.Name = "UltimaFechaCompraDataGridViewTextBoxColumn"
        Me.UltimaFechaCompraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmCatalogoMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 485)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgMateriales)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdInicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCatalogoMateriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Materiales"
        CType(Me.dgMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdInicio As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents cmdUltimo As Button
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgMateriales As DataGridView
    Friend WithEvents DataSetSistema As DataSetSistema
    Friend WithEvents MaterialBindingSource As BindingSource
    Friend WithEvents MaterialTableAdapter As DataSetSistemaTableAdapters.materialTableAdapter
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIdMaterial As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpFechaUlti As DateTimePicker
    Friend WithEvents cmbUnidadMedida As ComboBox
    Friend WithEvents mskMaximo As MaskedTextBox
    Friend WithEvents mskExistencias As MaskedTextBox
    Friend WithEvents mskMinimo As MaskedTextBox
    Friend WithEvents mskCosto As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents IdmaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaximoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinimoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UltimaFechaCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
