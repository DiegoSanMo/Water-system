<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogoGastos
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
        Me.label = New System.Windows.Forms.Label()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.txtIdGasto = New System.Windows.Forms.TextBox()
        Me.GastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSistema = New Sistema.DataSetSistema()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.dgGasto = New System.Windows.Forms.DataGridView()
        Me.IdgastoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConceptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GastosTableAdapter = New Sistema.DataSetSistemaTableAdapters.gastosTableAdapter()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.GastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdInicio
        '
        Me.cmdInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInicio.Location = New System.Drawing.Point(70, 112)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 0
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(18, 52)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(76, 18)
        Me.label.TabIndex = 1
        Me.label.Text = "Id_Gasto"
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSiguiente.Location = New System.Drawing.Point(163, 112)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(88, 23)
        Me.cmdSiguiente.TabIndex = 2
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnterior.Location = New System.Drawing.Point(272, 112)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 3
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUltimo.Location = New System.Drawing.Point(373, 112)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 4
        Me.cmdUltimo.Text = "último"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Concepto"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Image = Global.Sistema.My.Resources.Resources.Add_Property_30
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(21, 303)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(94, 39)
        Me.cmdNuevo.TabIndex = 7
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabar.Image = Global.Sistema.My.Resources.Resources.Save_30
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGrabar.Location = New System.Drawing.Point(134, 303)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(94, 38)
        Me.cmdGrabar.TabIndex = 8
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Image = Global.Sistema.My.Resources.Resources.Exit_Sign_30
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(377, 303)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(94, 39)
        Me.cmdSalir.TabIndex = 9
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'txtIdGasto
        '
        Me.txtIdGasto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastosBindingSource, "id_gasto", True))
        Me.txtIdGasto.Enabled = False
        Me.txtIdGasto.Location = New System.Drawing.Point(105, 52)
        Me.txtIdGasto.Name = "txtIdGasto"
        Me.txtIdGasto.Size = New System.Drawing.Size(93, 20)
        Me.txtIdGasto.TabIndex = 10
        '
        'GastosBindingSource
        '
        Me.GastosBindingSource.DataMember = "gastos"
        Me.GastosBindingSource.DataSource = Me.DataSetSistema
        '
        'DataSetSistema
        '
        Me.DataSetSistema.DataSetName = "DataSetSistema"
        Me.DataSetSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtConcepto
        '
        Me.txtConcepto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastosBindingSource, "Concepto", True))
        Me.txtConcepto.Enabled = False
        Me.txtConcepto.Location = New System.Drawing.Point(105, 86)
        Me.txtConcepto.MaxLength = 50
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(343, 20)
        Me.txtConcepto.TabIndex = 11
        '
        'dgGasto
        '
        Me.dgGasto.AllowUserToAddRows = False
        Me.dgGasto.AutoGenerateColumns = False
        Me.dgGasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGasto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdgastoDataGridViewTextBoxColumn, Me.ConceptoDataGridViewTextBoxColumn})
        Me.dgGasto.DataSource = Me.GastosBindingSource
        Me.dgGasto.Location = New System.Drawing.Point(21, 141)
        Me.dgGasto.Name = "dgGasto"
        Me.dgGasto.ReadOnly = True
        Me.dgGasto.Size = New System.Drawing.Size(451, 150)
        Me.dgGasto.TabIndex = 12
        '
        'IdgastoDataGridViewTextBoxColumn
        '
        Me.IdgastoDataGridViewTextBoxColumn.DataPropertyName = "id_gasto"
        Me.IdgastoDataGridViewTextBoxColumn.HeaderText = "id_gasto"
        Me.IdgastoDataGridViewTextBoxColumn.Name = "IdgastoDataGridViewTextBoxColumn"
        Me.IdgastoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConceptoDataGridViewTextBoxColumn
        '
        Me.ConceptoDataGridViewTextBoxColumn.DataPropertyName = "Concepto"
        Me.ConceptoDataGridViewTextBoxColumn.HeaderText = "Concepto"
        Me.ConceptoDataGridViewTextBoxColumn.Name = "ConceptoDataGridViewTextBoxColumn"
        Me.ConceptoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConceptoDataGridViewTextBoxColumn.Width = 300
        '
        'GastosTableAdapter
        '
        Me.GastosTableAdapter.ClearBeforeFill = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Image = Global.Sistema.My.Resources.Resources.Cancel_30
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(247, 303)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(111, 39)
        Me.cmdCancelar.TabIndex = 13
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(99, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(283, 33)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Catálogo de gastos"
        '
        'frmCatalogoGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 353)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.dgGasto)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.txtIdGasto)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.cmdInicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCatalogoGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gastos"
        CType(Me.GastosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgGasto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdInicio As Button
    Friend WithEvents label As Label
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdUltimo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents txtIdGasto As TextBox
    Friend WithEvents txtConcepto As TextBox
    Friend WithEvents dgGasto As DataGridView
    Friend WithEvents DataSetSistema As DataSetSistema
    Friend WithEvents GastosBindingSource As BindingSource
    Friend WithEvents GastosTableAdapter As DataSetSistemaTableAdapters.gastosTableAdapter
    Friend WithEvents IdgastoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConceptoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents Label8 As Label
End Class
