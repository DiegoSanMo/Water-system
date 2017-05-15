<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallesConsultaPago
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
        Me.grupoServicio = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNombreServicio = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtIdServicio = New System.Windows.Forms.TextBox()
        Me.txtIdSituacion = New System.Windows.Forms.TextBox()
        Me.txtSituacionDes = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtCuota = New System.Windows.Forms.TextBox()
        Me.txtRecargo = New System.Windows.Forms.TextBox()
        Me.txtInfra = New System.Windows.Forms.TextBox()
        Me.txtTar = New System.Windows.Forms.TextBox()
        Me.txtIdTarifa = New System.Windows.Forms.TextBox()
        Me.txtOtro = New System.Windows.Forms.TextBox()
        Me.grupoAgua = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMesFinal = New System.Windows.Forms.TextBox()
        Me.txttxtMesInicial = New System.Windows.Forms.TextBox()
        Me.txtTarifa = New System.Windows.Forms.TextBox()
        Me.txtSituacion = New System.Windows.Forms.TextBox()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.grupoServicio.SuspendLayout()
        Me.grupoAgua.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupoServicio
        '
        Me.grupoServicio.Controls.Add(Me.Label18)
        Me.grupoServicio.Controls.Add(Me.Label17)
        Me.grupoServicio.Controls.Add(Me.Label16)
        Me.grupoServicio.Controls.Add(Me.Label15)
        Me.grupoServicio.Controls.Add(Me.Label14)
        Me.grupoServicio.Controls.Add(Me.txtNombreServicio)
        Me.grupoServicio.Controls.Add(Me.txtNombreEmpleado)
        Me.grupoServicio.Controls.Add(Me.txtIdEmpleado)
        Me.grupoServicio.Controls.Add(Me.txtPrecio)
        Me.grupoServicio.Controls.Add(Me.txtIdServicio)
        Me.grupoServicio.Location = New System.Drawing.Point(34, 12)
        Me.grupoServicio.Name = "grupoServicio"
        Me.grupoServicio.Size = New System.Drawing.Size(707, 151)
        Me.grupoServicio.TabIndex = 12
        Me.grupoServicio.TabStop = False
        Me.grupoServicio.Text = "Servicio"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(276, 86)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 18)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "Empleado"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(45, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 18)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Servicio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 86)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 18)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "IdEmpleado"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(272, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 18)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "IdServicio"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(510, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 18)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Precio"
        '
        'txtNombreServicio
        '
        Me.txtNombreServicio.Location = New System.Drawing.Point(122, 26)
        Me.txtNombreServicio.Name = "txtNombreServicio"
        Me.txtNombreServicio.ReadOnly = True
        Me.txtNombreServicio.Size = New System.Drawing.Size(109, 20)
        Me.txtNombreServicio.TabIndex = 19
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(362, 84)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.ReadOnly = True
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreEmpleado.TabIndex = 18
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Location = New System.Drawing.Point(122, 84)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.ReadOnly = True
        Me.txtIdEmpleado.Size = New System.Drawing.Size(109, 20)
        Me.txtIdEmpleado.TabIndex = 17
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(575, 69)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 13
        '
        'txtIdServicio
        '
        Me.txtIdServicio.Location = New System.Drawing.Point(362, 26)
        Me.txtIdServicio.Name = "txtIdServicio"
        Me.txtIdServicio.ReadOnly = True
        Me.txtIdServicio.Size = New System.Drawing.Size(100, 20)
        Me.txtIdServicio.TabIndex = 11
        '
        'txtIdSituacion
        '
        Me.txtIdSituacion.Enabled = False
        Me.txtIdSituacion.Location = New System.Drawing.Point(131, 25)
        Me.txtIdSituacion.Name = "txtIdSituacion"
        Me.txtIdSituacion.Size = New System.Drawing.Size(100, 20)
        Me.txtIdSituacion.TabIndex = 11
        '
        'txtSituacionDes
        '
        Me.txtSituacionDes.Enabled = False
        Me.txtSituacionDes.Location = New System.Drawing.Point(601, 25)
        Me.txtSituacionDes.Name = "txtSituacionDes"
        Me.txtSituacionDes.Size = New System.Drawing.Size(100, 20)
        Me.txtSituacionDes.TabIndex = 13
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(289, 171)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(121, 18)
        Me.Label41.TabIndex = 13
        Me.Label41.Text = "Pago realizado"
        '
        'txtCuota
        '
        Me.txtCuota.Location = New System.Drawing.Point(63, 223)
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.ReadOnly = True
        Me.txtCuota.Size = New System.Drawing.Size(100, 20)
        Me.txtCuota.TabIndex = 29
        '
        'txtRecargo
        '
        Me.txtRecargo.Location = New System.Drawing.Point(251, 223)
        Me.txtRecargo.Name = "txtRecargo"
        Me.txtRecargo.ReadOnly = True
        Me.txtRecargo.Size = New System.Drawing.Size(100, 20)
        Me.txtRecargo.TabIndex = 31
        '
        'txtInfra
        '
        Me.txtInfra.Location = New System.Drawing.Point(575, 223)
        Me.txtInfra.Name = "txtInfra"
        Me.txtInfra.ReadOnly = True
        Me.txtInfra.Size = New System.Drawing.Size(100, 20)
        Me.txtInfra.TabIndex = 33
        '
        'txtTar
        '
        Me.txtTar.Location = New System.Drawing.Point(418, 223)
        Me.txtTar.Name = "txtTar"
        Me.txtTar.ReadOnly = True
        Me.txtTar.Size = New System.Drawing.Size(100, 20)
        Me.txtTar.TabIndex = 35
        '
        'txtIdTarifa
        '
        Me.txtIdTarifa.Enabled = False
        Me.txtIdTarifa.Location = New System.Drawing.Point(341, 73)
        Me.txtIdTarifa.Name = "txtIdTarifa"
        Me.txtIdTarifa.Size = New System.Drawing.Size(100, 20)
        Me.txtIdTarifa.TabIndex = 43
        '
        'txtOtro
        '
        Me.txtOtro.Location = New System.Drawing.Point(250, 276)
        Me.txtOtro.Name = "txtOtro"
        Me.txtOtro.ReadOnly = True
        Me.txtOtro.Size = New System.Drawing.Size(100, 20)
        Me.txtOtro.TabIndex = 45
        '
        'grupoAgua
        '
        Me.grupoAgua.Controls.Add(Me.Label13)
        Me.grupoAgua.Controls.Add(Me.txtTotal)
        Me.grupoAgua.Controls.Add(Me.Label12)
        Me.grupoAgua.Controls.Add(Me.Label11)
        Me.grupoAgua.Controls.Add(Me.Label10)
        Me.grupoAgua.Controls.Add(Me.Label9)
        Me.grupoAgua.Controls.Add(Me.Label8)
        Me.grupoAgua.Controls.Add(Me.Label7)
        Me.grupoAgua.Controls.Add(Me.Label6)
        Me.grupoAgua.Controls.Add(Me.Label5)
        Me.grupoAgua.Controls.Add(Me.Label4)
        Me.grupoAgua.Controls.Add(Me.Label3)
        Me.grupoAgua.Controls.Add(Me.Label2)
        Me.grupoAgua.Controls.Add(Me.Label1)
        Me.grupoAgua.Controls.Add(Me.txtMesFinal)
        Me.grupoAgua.Controls.Add(Me.txttxtMesInicial)
        Me.grupoAgua.Controls.Add(Me.txtTarifa)
        Me.grupoAgua.Controls.Add(Me.txtSituacion)
        Me.grupoAgua.Controls.Add(Me.txtOtro)
        Me.grupoAgua.Controls.Add(Me.txtIdTarifa)
        Me.grupoAgua.Controls.Add(Me.txtTar)
        Me.grupoAgua.Controls.Add(Me.txtInfra)
        Me.grupoAgua.Controls.Add(Me.txtRecargo)
        Me.grupoAgua.Controls.Add(Me.txtCuota)
        Me.grupoAgua.Controls.Add(Me.Label41)
        Me.grupoAgua.Controls.Add(Me.txtSituacionDes)
        Me.grupoAgua.Controls.Add(Me.txtIdSituacion)
        Me.grupoAgua.Location = New System.Drawing.Point(34, 12)
        Me.grupoAgua.Name = "grupoAgua"
        Me.grupoAgua.Size = New System.Drawing.Size(707, 322)
        Me.grupoAgua.TabIndex = 10
        Me.grupoAgua.TabStop = False
        Me.grupoAgua.Text = "Agua"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(361, 278)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 18)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Total pagado"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(473, 276)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 62
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(144, 278)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 18)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Otro"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(526, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 18)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Infra"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(359, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 18)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Tarifa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(171, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Recargo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 18)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Cuota"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(376, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 18)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Mes final"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(133, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 18)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Mes inicial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(254, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "idTarifa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Año tarifa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(496, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Descuento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "IdSituación"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(247, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 18)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Situación"
        '
        'txtMesFinal
        '
        Me.txtMesFinal.Enabled = False
        Me.txtMesFinal.Location = New System.Drawing.Point(458, 132)
        Me.txtMesFinal.Name = "txtMesFinal"
        Me.txtMesFinal.Size = New System.Drawing.Size(100, 20)
        Me.txtMesFinal.TabIndex = 49
        '
        'txttxtMesInicial
        '
        Me.txttxtMesInicial.Enabled = False
        Me.txttxtMesInicial.Location = New System.Drawing.Point(227, 132)
        Me.txttxtMesInicial.Name = "txttxtMesInicial"
        Me.txttxtMesInicial.Size = New System.Drawing.Size(100, 20)
        Me.txttxtMesInicial.TabIndex = 48
        '
        'txtTarifa
        '
        Me.txtTarifa.Enabled = False
        Me.txtTarifa.Location = New System.Drawing.Point(133, 70)
        Me.txtTarifa.Name = "txtTarifa"
        Me.txtTarifa.Size = New System.Drawing.Size(100, 20)
        Me.txtTarifa.TabIndex = 47
        '
        'txtSituacion
        '
        Me.txtSituacion.Enabled = False
        Me.txtSituacion.Location = New System.Drawing.Point(341, 25)
        Me.txtSituacion.Name = "txtSituacion"
        Me.txtSituacion.Size = New System.Drawing.Size(149, 20)
        Me.txtSituacion.TabIndex = 46
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(369, 340)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 13
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'DetallesConsultaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 389)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.grupoServicio)
        Me.Controls.Add(Me.grupoAgua)
        Me.Name = "DetallesConsultaPago"
        Me.Text = "DetallesConsultaPago"
        Me.grupoServicio.ResumeLayout(False)
        Me.grupoServicio.PerformLayout()
        Me.grupoAgua.ResumeLayout(False)
        Me.grupoAgua.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoServicio As GroupBox
    Friend WithEvents txtNombreServicio As TextBox
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents txtIdEmpleado As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtIdServicio As TextBox
    Friend WithEvents txtIdSituacion As TextBox
    Friend WithEvents txtSituacionDes As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents txtCuota As TextBox
    Friend WithEvents txtRecargo As TextBox
    Friend WithEvents txtInfra As TextBox
    Friend WithEvents txtTar As TextBox
    Friend WithEvents txtIdTarifa As TextBox
    Friend WithEvents txtOtro As TextBox
    Friend WithEvents grupoAgua As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMesFinal As TextBox
    Friend WithEvents txttxtMesInicial As TextBox
    Friend WithEvents txtTarifa As TextBox
    Friend WithEvents txtSituacion As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cmdAceptar As Button
End Class
