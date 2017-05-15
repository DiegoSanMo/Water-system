<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogoTarifas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.TarifasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSistema = New Sistema.DataSetSistema()
        Me.txtCuota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInfra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRecargos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdTarifa = New System.Windows.Forms.TextBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.TarifasTableAdapter = New Sistema.DataSetSistemaTableAdapters.tarifasTableAdapter()
        Me.dgTarifas = New System.Windows.Forms.DataGridView()
        Me.IdtarifaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecargosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InfraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TarifasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAnio)
        Me.GroupBox1.Controls.Add(Me.txtCuota)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtInfra)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtRecargos)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtIdTarifa)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 72)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'txtAnio
        '
        Me.txtAnio.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtAnio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "anio", True))
        Me.txtAnio.Enabled = False
        Me.txtAnio.Location = New System.Drawing.Point(102, 37)
        Me.txtAnio.MaxLength = 4
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(100, 20)
        Me.txtAnio.TabIndex = 1
        '
        'TarifasBindingSource
        '
        Me.TarifasBindingSource.DataMember = "tarifas"
        Me.TarifasBindingSource.DataSource = Me.DataSetSistema
        '
        'DataSetSistema
        '
        Me.DataSetSistema.DataSetName = "DataSetSistema"
        Me.DataSetSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCuota
        '
        Me.txtCuota.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCuota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "cf", True))
        Me.txtCuota.Enabled = False
        Me.txtCuota.Location = New System.Drawing.Point(329, 16)
        Me.txtCuota.MaxLength = 15
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.Size = New System.Drawing.Size(100, 20)
        Me.txtCuota.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Id_Tarifa"
        '
        'txtInfra
        '
        Me.txtInfra.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtInfra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "infra", True))
        Me.txtInfra.Enabled = False
        Me.txtInfra.Location = New System.Drawing.Point(547, 45)
        Me.txtInfra.MaxLength = 15
        Me.txtInfra.Name = "txtInfra"
        Me.txtInfra.Size = New System.Drawing.Size(100, 20)
        Me.txtInfra.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Año"
        '
        'txtTar
        '
        Me.txtTar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "tar", True))
        Me.txtTar.Enabled = False
        Me.txtTar.Location = New System.Drawing.Point(547, 20)
        Me.txtTar.MaxLength = 15
        Me.txtTar.Name = "txtTar"
        Me.txtTar.Size = New System.Drawing.Size(100, 20)
        Me.txtTar.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(240, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cuota fija"
        '
        'txtRecargos
        '
        Me.txtRecargos.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtRecargos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "recargos", True))
        Me.txtRecargos.Enabled = False
        Me.txtRecargos.Location = New System.Drawing.Point(329, 41)
        Me.txtRecargos.MaxLength = 15
        Me.txtRecargos.Name = "txtRecargos"
        Me.txtRecargos.Size = New System.Drawing.Size(100, 20)
        Me.txtRecargos.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(240, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Recargos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(458, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "T.A.R"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(458, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "INFRA"
        '
        'txtIdTarifa
        '
        Me.txtIdTarifa.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtIdTarifa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "id_tarifa", True))
        Me.txtIdTarifa.Enabled = False
        Me.txtIdTarifa.Location = New System.Drawing.Point(102, 12)
        Me.txtIdTarifa.Name = "txtIdTarifa"
        Me.txtIdTarifa.Size = New System.Drawing.Size(100, 20)
        Me.txtIdTarifa.TabIndex = 30
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Image = Global.Sistema.My.Resources.Resources.Exit_Sign_30
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(590, 332)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(95, 45)
        Me.cmdSalir.TabIndex = 45
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
        Me.cmdGrabar.Location = New System.Drawing.Point(211, 332)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(99, 45)
        Me.cmdGrabar.TabIndex = 44
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnterior.Location = New System.Drawing.Point(401, 135)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(82, 23)
        Me.cmdAnterior.TabIndex = 41
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSiguiente.Location = New System.Drawing.Point(280, 135)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(82, 23)
        Me.cmdSiguiente.TabIndex = 40
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInicio.Location = New System.Drawing.Point(159, 135)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(82, 23)
        Me.cmdInicio.TabIndex = 39
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUltimo.Location = New System.Drawing.Point(522, 135)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(82, 23)
        Me.cmdUltimo.TabIndex = 42
        Me.cmdUltimo.Text = "Último"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Image = Global.Sistema.My.Resources.Resources.Add_Property_30
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(28, 332)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(99, 45)
        Me.cmdNuevo.TabIndex = 43
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'TarifasTableAdapter
        '
        Me.TarifasTableAdapter.ClearBeforeFill = True
        '
        'dgTarifas
        '
        Me.dgTarifas.AllowUserToAddRows = False
        Me.dgTarifas.AutoGenerateColumns = False
        Me.dgTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTarifas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtarifaDataGridViewTextBoxColumn, Me.AnioDataGridViewTextBoxColumn, Me.CfDataGridViewTextBoxColumn, Me.RecargosDataGridViewTextBoxColumn, Me.TarDataGridViewTextBoxColumn, Me.InfraDataGridViewTextBoxColumn})
        Me.dgTarifas.DataSource = Me.TarifasBindingSource
        Me.dgTarifas.Location = New System.Drawing.Point(28, 164)
        Me.dgTarifas.Name = "dgTarifas"
        Me.dgTarifas.ReadOnly = True
        Me.dgTarifas.Size = New System.Drawing.Size(657, 162)
        Me.dgTarifas.TabIndex = 47
        '
        'IdtarifaDataGridViewTextBoxColumn
        '
        Me.IdtarifaDataGridViewTextBoxColumn.DataPropertyName = "id_tarifa"
        Me.IdtarifaDataGridViewTextBoxColumn.HeaderText = "id_tarifa"
        Me.IdtarifaDataGridViewTextBoxColumn.Name = "IdtarifaDataGridViewTextBoxColumn"
        Me.IdtarifaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnioDataGridViewTextBoxColumn
        '
        Me.AnioDataGridViewTextBoxColumn.DataPropertyName = "anio"
        Me.AnioDataGridViewTextBoxColumn.HeaderText = "anio"
        Me.AnioDataGridViewTextBoxColumn.Name = "AnioDataGridViewTextBoxColumn"
        Me.AnioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CfDataGridViewTextBoxColumn
        '
        Me.CfDataGridViewTextBoxColumn.DataPropertyName = "cf"
        Me.CfDataGridViewTextBoxColumn.HeaderText = "cf"
        Me.CfDataGridViewTextBoxColumn.Name = "CfDataGridViewTextBoxColumn"
        Me.CfDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RecargosDataGridViewTextBoxColumn
        '
        Me.RecargosDataGridViewTextBoxColumn.DataPropertyName = "recargos"
        Me.RecargosDataGridViewTextBoxColumn.HeaderText = "recargos"
        Me.RecargosDataGridViewTextBoxColumn.Name = "RecargosDataGridViewTextBoxColumn"
        Me.RecargosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TarDataGridViewTextBoxColumn
        '
        Me.TarDataGridViewTextBoxColumn.DataPropertyName = "tar"
        Me.TarDataGridViewTextBoxColumn.HeaderText = "tar"
        Me.TarDataGridViewTextBoxColumn.Name = "TarDataGridViewTextBoxColumn"
        Me.TarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InfraDataGridViewTextBoxColumn
        '
        Me.InfraDataGridViewTextBoxColumn.DataPropertyName = "infra"
        Me.InfraDataGridViewTextBoxColumn.HeaderText = "infra"
        Me.InfraDataGridViewTextBoxColumn.Name = "InfraDataGridViewTextBoxColumn"
        Me.InfraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Image = Global.Sistema.My.Resources.Resources.Cancel_30
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(394, 332)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(112, 45)
        Me.cmdCancelar.TabIndex = 48
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(205, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(278, 33)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Catálogo de tarifas"
        '
        'frmCatalogoTarifas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 389)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.dgTarifas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.cmdUltimo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCatalogoTarifas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarifas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TarifasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCuota As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtInfra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRecargos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIdTarifa As TextBox
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents cmdInicio As Button
    Friend WithEvents cmdUltimo As Button
    Friend WithEvents DataSetSistema As DataSetSistema
    Friend WithEvents TarifasBindingSource As BindingSource
    Friend WithEvents TarifasTableAdapter As DataSetSistemaTableAdapters.tarifasTableAdapter
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents dgTarifas As DataGridView
    Friend WithEvents IdtarifaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecargosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InfraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents Label9 As Label
End Class
