<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovimientosActividadPozos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgActividades = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboPozo = New System.Windows.Forms.ComboBox()
        Me.txtLectura = New System.Windows.Forms.TextBox()
        Me.txtIdPoz = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtIdActividad = New System.Windows.Forms.TextBox()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmbGrabar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mskHora = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pozo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(470, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Id_Actividad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(500, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "id_Pozo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(522, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Hora"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Lectura"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Observaciones"
        '
        'dgActividades
        '
        Me.dgActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgActividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgActividades.Location = New System.Drawing.Point(12, 242)
        Me.dgActividades.Name = "dgActividades"
        Me.dgActividades.ReadOnly = True
        Me.dgActividades.Size = New System.Drawing.Size(734, 150)
        Me.dgActividades.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "id_Actividad"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "id_Pozo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Pozo"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Fecha"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Hora"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Lectura"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Observaciones"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'cboPozo
        '
        Me.cboPozo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPozo.Enabled = False
        Me.cboPozo.FormattingEnabled = True
        Me.cboPozo.Location = New System.Drawing.Point(105, 16)
        Me.cboPozo.Name = "cboPozo"
        Me.cboPozo.Size = New System.Drawing.Size(121, 21)
        Me.cboPozo.TabIndex = 8
        '
        'txtLectura
        '
        Me.txtLectura.Enabled = False
        Me.txtLectura.Location = New System.Drawing.Point(105, 74)
        Me.txtLectura.Name = "txtLectura"
        Me.txtLectura.Size = New System.Drawing.Size(121, 20)
        Me.txtLectura.TabIndex = 10
        '
        'txtIdPoz
        '
        Me.txtIdPoz.Enabled = False
        Me.txtIdPoz.Location = New System.Drawing.Point(570, 49)
        Me.txtIdPoz.Name = "txtIdPoz"
        Me.txtIdPoz.Size = New System.Drawing.Size(100, 20)
        Me.txtIdPoz.TabIndex = 11
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Enabled = False
        Me.txtObservaciones.Location = New System.Drawing.Point(26, 124)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(655, 46)
        Me.txtObservaciones.TabIndex = 13
        '
        'txtIdActividad
        '
        Me.txtIdActividad.Enabled = False
        Me.txtIdActividad.Location = New System.Drawing.Point(570, 16)
        Me.txtIdActividad.Name = "txtIdActividad"
        Me.txtIdActividad.Size = New System.Drawing.Size(100, 20)
        Me.txtIdActividad.TabIndex = 14
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Image = Global.Sistema.My.Resources.Resources.Add_Property_30
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 398)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(108, 39)
        Me.cmdNuevo.TabIndex = 15
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmbGrabar
        '
        Me.cmbGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGrabar.Image = Global.Sistema.My.Resources.Resources.Save_30
        Me.cmbGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmbGrabar.Location = New System.Drawing.Point(312, 398)
        Me.cmbGrabar.Name = "cmbGrabar"
        Me.cmbGrabar.Size = New System.Drawing.Size(108, 39)
        Me.cmbGrabar.TabIndex = 16
        Me.cmbGrabar.Text = "Grabar"
        Me.cmbGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmbGrabar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.Image = Global.Sistema.My.Resources.Resources.Exit_Sign_30
        Me.Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salir.Location = New System.Drawing.Point(636, 398)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(108, 39)
        Me.Salir.TabIndex = 17
        Me.Salir.Text = "Salir"
        Me.Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Salir.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(105, 46)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(121, 20)
        Me.dtpFecha.TabIndex = 18
        Me.dtpFecha.Value = New Date(2017, 3, 9, 12, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mskHora)
        Me.GroupBox1.Controls.Add(Me.txtLectura)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtIdActividad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboPozo)
        Me.GroupBox1.Controls.Add(Me.txtIdPoz)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(732, 176)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(210, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(344, 41)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Actividad de pozos"
        '
        'mskHora
        '
        Me.mskHora.Enabled = False
        Me.mskHora.Location = New System.Drawing.Point(570, 79)
        Me.mskHora.Mask = "00:00"
        Me.mskHora.Name = "mskHora"
        Me.mskHora.Size = New System.Drawing.Size(100, 20)
        Me.mskHora.TabIndex = 19
        Me.mskHora.ValidatingType = GetType(Date)
        '
        'frmMovimientosActividadPozos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 454)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.cmbGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.dgActividades)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMovimientosActividadPozos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento actividad de pozos"
        CType(Me.dgActividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgActividades As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents cboPozo As ComboBox
    Friend WithEvents txtLectura As TextBox
    Friend WithEvents txtIdPoz As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents txtIdActividad As TextBox
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmbGrabar As Button
    Friend WithEvents Salir As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mskHora As MaskedTextBox
    Friend WithEvents Label8 As Label
End Class
