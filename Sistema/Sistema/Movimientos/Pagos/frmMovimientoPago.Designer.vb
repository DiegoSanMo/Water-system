<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovimientoPago
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
        Me.txtIdPago = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        Me.dgCuenta = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbServicio = New System.Windows.Forms.RadioButton()
        Me.rbAgua = New System.Windows.Forms.RadioButton()
        Me.grupoAgua = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtDescuentoAplicado = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtIdTarifa = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtOtro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTarifaAplicada = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtInfraAplicado = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtRecargoAplicado = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCuotaAplicada = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboMesFinal = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboMesInicial = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtInfra = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTarifa = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRecargo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCuota = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIdSituacion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboSituacion = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboTarifa = New System.Windows.Forms.ComboBox()
        Me.txtTotalApagar = New System.Windows.Forms.TextBox()
        Me.grupoServicio = New System.Windows.Forms.GroupBox()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtIdServicio = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cboServicio = New System.Windows.Forms.ComboBox()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.grupoAgua.SuspendLayout()
        Me.grupoServicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIdPago
        '
        Me.txtIdPago.Enabled = False
        Me.txtIdPago.Location = New System.Drawing.Point(724, 43)
        Me.txtIdPago.Name = "txtIdPago"
        Me.txtIdPago.Size = New System.Drawing.Size(100, 20)
        Me.txtIdPago.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtIdCuenta)
        Me.GroupBox1.Controls.Add(Me.dgCuenta)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(878, 219)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(382, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Id_Cuenta"
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.Enabled = False
        Me.txtIdCuenta.Location = New System.Drawing.Point(444, 21)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.Size = New System.Drawing.Size(76, 20)
        Me.txtIdCuenta.TabIndex = 14
        '
        'dgCuenta
        '
        Me.dgCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column4})
        Me.dgCuenta.Location = New System.Drawing.Point(9, 59)
        Me.dgCuenta.Name = "dgCuenta"
        Me.dgCuenta.Size = New System.Drawing.Size(849, 150)
        Me.dgCuenta.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "IdCuenta"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 250
        '
        'Column3
        '
        Me.Column3.HeaderText = "Dirección"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 250
        '
        'Column5
        '
        Me.Column5.HeaderText = "Ultimo año pagado"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Ultimo mes pagado"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(61, 21)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(226, 20)
        Me.txtName.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbServicio)
        Me.GroupBox2.Controls.Add(Me.rbAgua)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 300)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(161, 102)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de pago"
        '
        'rbServicio
        '
        Me.rbServicio.AutoSize = True
        Me.rbServicio.Enabled = False
        Me.rbServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbServicio.Location = New System.Drawing.Point(9, 61)
        Me.rbServicio.Name = "rbServicio"
        Me.rbServicio.Size = New System.Drawing.Size(90, 24)
        Me.rbServicio.TabIndex = 10
        Me.rbServicio.TabStop = True
        Me.rbServicio.Text = "Servicios"
        Me.rbServicio.UseVisualStyleBackColor = True
        '
        'rbAgua
        '
        Me.rbAgua.AutoSize = True
        Me.rbAgua.Enabled = False
        Me.rbAgua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAgua.Location = New System.Drawing.Point(9, 32)
        Me.rbAgua.Name = "rbAgua"
        Me.rbAgua.Size = New System.Drawing.Size(65, 24)
        Me.rbAgua.TabIndex = 9
        Me.rbAgua.TabStop = True
        Me.rbAgua.Text = "Agua"
        Me.rbAgua.UseVisualStyleBackColor = True
        '
        'grupoAgua
        '
        Me.grupoAgua.Controls.Add(Me.txtTotal)
        Me.grupoAgua.Controls.Add(Me.Label30)
        Me.grupoAgua.Controls.Add(Me.txtDescuentoAplicado)
        Me.grupoAgua.Controls.Add(Me.Label29)
        Me.grupoAgua.Controls.Add(Me.txtIdTarifa)
        Me.grupoAgua.Controls.Add(Me.Label28)
        Me.grupoAgua.Controls.Add(Me.txtSubTotal)
        Me.grupoAgua.Controls.Add(Me.txtOtro)
        Me.grupoAgua.Controls.Add(Me.Label5)
        Me.grupoAgua.Controls.Add(Me.Label4)
        Me.grupoAgua.Controls.Add(Me.Label3)
        Me.grupoAgua.Controls.Add(Me.txtTarifaAplicada)
        Me.grupoAgua.Controls.Add(Me.Label26)
        Me.grupoAgua.Controls.Add(Me.txtInfraAplicado)
        Me.grupoAgua.Controls.Add(Me.Label18)
        Me.grupoAgua.Controls.Add(Me.txtRecargoAplicado)
        Me.grupoAgua.Controls.Add(Me.Label19)
        Me.grupoAgua.Controls.Add(Me.txtCuotaAplicada)
        Me.grupoAgua.Controls.Add(Me.Label20)
        Me.grupoAgua.Controls.Add(Me.Label17)
        Me.grupoAgua.Controls.Add(Me.cboMesFinal)
        Me.grupoAgua.Controls.Add(Me.Label15)
        Me.grupoAgua.Controls.Add(Me.cboMesInicial)
        Me.grupoAgua.Controls.Add(Me.Label14)
        Me.grupoAgua.Controls.Add(Me.txtInfra)
        Me.grupoAgua.Controls.Add(Me.Label13)
        Me.grupoAgua.Controls.Add(Me.txtTarifa)
        Me.grupoAgua.Controls.Add(Me.Label12)
        Me.grupoAgua.Controls.Add(Me.txtRecargo)
        Me.grupoAgua.Controls.Add(Me.Label11)
        Me.grupoAgua.Controls.Add(Me.txtCuota)
        Me.grupoAgua.Controls.Add(Me.Label10)
        Me.grupoAgua.Controls.Add(Me.Label9)
        Me.grupoAgua.Controls.Add(Me.txtDescuento)
        Me.grupoAgua.Controls.Add(Me.Label8)
        Me.grupoAgua.Controls.Add(Me.txtIdSituacion)
        Me.grupoAgua.Controls.Add(Me.Label7)
        Me.grupoAgua.Controls.Add(Me.cboSituacion)
        Me.grupoAgua.Controls.Add(Me.Label6)
        Me.grupoAgua.Controls.Add(Me.cboTarifa)
        Me.grupoAgua.Controls.Add(Me.txtTotalApagar)
        Me.grupoAgua.Location = New System.Drawing.Point(179, 300)
        Me.grupoAgua.Name = "grupoAgua"
        Me.grupoAgua.Size = New System.Drawing.Size(801, 371)
        Me.grupoAgua.TabIndex = 9
        Me.grupoAgua.TabStop = False
        Me.grupoAgua.Text = "Agua"
        Me.grupoAgua.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(692, 226)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 47
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(649, 230)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(31, 13)
        Me.Label30.TabIndex = 46
        Me.Label30.Text = "Total"
        '
        'txtDescuentoAplicado
        '
        Me.txtDescuentoAplicado.Enabled = False
        Me.txtDescuentoAplicado.Location = New System.Drawing.Point(692, 252)
        Me.txtDescuentoAplicado.Name = "txtDescuentoAplicado"
        Me.txtDescuentoAplicado.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuentoAplicado.TabIndex = 45
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(625, 256)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(59, 13)
        Me.Label29.TabIndex = 44
        Me.Label29.Text = "Descuento"
        '
        'txtIdTarifa
        '
        Me.txtIdTarifa.Enabled = False
        Me.txtIdTarifa.Location = New System.Drawing.Point(277, 69)
        Me.txtIdTarifa.Name = "txtIdTarifa"
        Me.txtIdTarifa.Size = New System.Drawing.Size(100, 20)
        Me.txtIdTarifa.TabIndex = 43
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(223, 71)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(42, 13)
        Me.Label28.TabIndex = 42
        Me.Label28.Text = "idTarifa"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Location = New System.Drawing.Point(692, 310)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubTotal.TabIndex = 40
        '
        'txtOtro
        '
        Me.txtOtro.Enabled = False
        Me.txtOtro.Location = New System.Drawing.Point(692, 281)
        Me.txtOtro.Name = "txtOtro"
        Me.txtOtro.Size = New System.Drawing.Size(100, 20)
        Me.txtOtro.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(594, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 15)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Total a pagar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(658, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Otro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(635, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "SubTotal"
        '
        'txtTarifaAplicada
        '
        Me.txtTarifaAplicada.Enabled = False
        Me.txtTarifaAplicada.Location = New System.Drawing.Point(385, 226)
        Me.txtTarifaAplicada.Name = "txtTarifaAplicada"
        Me.txtTarifaAplicada.Size = New System.Drawing.Size(100, 20)
        Me.txtTarifaAplicada.TabIndex = 35
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(339, 230)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(34, 13)
        Me.Label26.TabIndex = 34
        Me.Label26.Text = "Tarifa"
        '
        'txtInfraAplicado
        '
        Me.txtInfraAplicado.Enabled = False
        Me.txtInfraAplicado.Location = New System.Drawing.Point(537, 226)
        Me.txtInfraAplicado.Name = "txtInfraAplicado"
        Me.txtInfraAplicado.Size = New System.Drawing.Size(100, 20)
        Me.txtInfraAplicado.TabIndex = 33
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(497, 230)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(28, 13)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Infra"
        '
        'txtRecargoAplicado
        '
        Me.txtRecargoAplicado.Enabled = False
        Me.txtRecargoAplicado.Location = New System.Drawing.Point(227, 226)
        Me.txtRecargoAplicado.Name = "txtRecargoAplicado"
        Me.txtRecargoAplicado.Size = New System.Drawing.Size(100, 20)
        Me.txtRecargoAplicado.TabIndex = 31
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(167, 230)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 13)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Recargo"
        '
        'txtCuotaAplicada
        '
        Me.txtCuotaAplicada.Enabled = False
        Me.txtCuotaAplicada.Location = New System.Drawing.Point(55, 226)
        Me.txtCuotaAplicada.Name = "txtCuotaAplicada"
        Me.txtCuotaAplicada.Size = New System.Drawing.Size(100, 20)
        Me.txtCuotaAplicada.TabIndex = 29
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 230)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 13)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Cuota"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(284, 198)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(174, 18)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Pago correspondiente"
        '
        'cboMesFinal
        '
        Me.cboMesFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMesFinal.Enabled = False
        Me.cboMesFinal.FormattingEnabled = True
        Me.cboMesFinal.Location = New System.Drawing.Point(437, 158)
        Me.cboMesFinal.Name = "cboMesFinal"
        Me.cboMesFinal.Size = New System.Drawing.Size(121, 21)
        Me.cboMesFinal.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(380, 162)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Mes final"
        '
        'cboMesInicial
        '
        Me.cboMesInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMesInicial.Enabled = False
        Me.cboMesInicial.FormattingEnabled = True
        Me.cboMesInicial.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cboMesInicial.Location = New System.Drawing.Point(177, 158)
        Me.cboMesInicial.Name = "cboMesInicial"
        Me.cboMesInicial.Size = New System.Drawing.Size(121, 21)
        Me.cboMesInicial.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(120, 162)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Mes inicial"
        '
        'txtInfra
        '
        Me.txtInfra.Enabled = False
        Me.txtInfra.Location = New System.Drawing.Point(645, 102)
        Me.txtInfra.Name = "txtInfra"
        Me.txtInfra.Size = New System.Drawing.Size(100, 20)
        Me.txtInfra.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(595, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Infra"
        '
        'txtTarifa
        '
        Me.txtTarifa.Enabled = False
        Me.txtTarifa.Location = New System.Drawing.Point(467, 102)
        Me.txtTarifa.Name = "txtTarifa"
        Me.txtTarifa.Size = New System.Drawing.Size(100, 20)
        Me.txtTarifa.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(424, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Tarifa"
        '
        'txtRecargo
        '
        Me.txtRecargo.Enabled = False
        Me.txtRecargo.Location = New System.Drawing.Point(277, 102)
        Me.txtRecargo.Name = "txtRecargo"
        Me.txtRecargo.Size = New System.Drawing.Size(100, 20)
        Me.txtRecargo.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(223, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Recargo"
        '
        'txtCuota
        '
        Me.txtCuota.Enabled = False
        Me.txtCuota.Location = New System.Drawing.Point(77, 102)
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.Size = New System.Drawing.Size(121, 20)
        Me.txtCuota.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Cuota"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Año tarifa"
        '
        'txtDescuento
        '
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Location = New System.Drawing.Point(467, 24)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(402, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Descuento"
        '
        'txtIdSituacion
        '
        Me.txtIdSituacion.Enabled = False
        Me.txtIdSituacion.Location = New System.Drawing.Point(277, 24)
        Me.txtIdSituacion.Name = "txtIdSituacion"
        Me.txtIdSituacion.Size = New System.Drawing.Size(100, 20)
        Me.txtIdSituacion.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(215, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "IdSituacion"
        '
        'cboSituacion
        '
        Me.cboSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSituacion.FormattingEnabled = True
        Me.cboSituacion.Location = New System.Drawing.Point(77, 24)
        Me.cboSituacion.Name = "cboSituacion"
        Me.cboSituacion.Size = New System.Drawing.Size(121, 21)
        Me.cboSituacion.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Situación"
        '
        'cboTarifa
        '
        Me.cboTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTarifa.Enabled = False
        Me.cboTarifa.FormattingEnabled = True
        Me.cboTarifa.Location = New System.Drawing.Point(77, 68)
        Me.cboTarifa.Name = "cboTarifa"
        Me.cboTarifa.Size = New System.Drawing.Size(121, 21)
        Me.cboTarifa.TabIndex = 15
        '
        'txtTotalApagar
        '
        Me.txtTotalApagar.Enabled = False
        Me.txtTotalApagar.Location = New System.Drawing.Point(692, 336)
        Me.txtTotalApagar.Name = "txtTotalApagar"
        Me.txtTotalApagar.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalApagar.TabIndex = 41
        '
        'grupoServicio
        '
        Me.grupoServicio.Controls.Add(Me.txtIdEmpleado)
        Me.grupoServicio.Controls.Add(Me.Label21)
        Me.grupoServicio.Controls.Add(Me.cboEmpleado)
        Me.grupoServicio.Controls.Add(Me.Label22)
        Me.grupoServicio.Controls.Add(Me.txtPrecio)
        Me.grupoServicio.Controls.Add(Me.Label23)
        Me.grupoServicio.Controls.Add(Me.txtIdServicio)
        Me.grupoServicio.Controls.Add(Me.Label24)
        Me.grupoServicio.Controls.Add(Me.Label25)
        Me.grupoServicio.Controls.Add(Me.cboServicio)
        Me.grupoServicio.Location = New System.Drawing.Point(183, 300)
        Me.grupoServicio.Name = "grupoServicio"
        Me.grupoServicio.Size = New System.Drawing.Size(707, 112)
        Me.grupoServicio.TabIndex = 10
        Me.grupoServicio.TabStop = False
        Me.grupoServicio.Text = "Servicio"
        Me.grupoServicio.Visible = False
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Enabled = False
        Me.txtIdEmpleado.Location = New System.Drawing.Point(277, 72)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtIdEmpleado.TabIndex = 17
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(215, 76)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 13)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "IdEmpleado"
        '
        'cboEmpleado
        '
        Me.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpleado.FormattingEnabled = True
        Me.cboEmpleado.Location = New System.Drawing.Point(77, 68)
        Me.cboEmpleado.Name = "cboEmpleado"
        Me.cboEmpleado.Size = New System.Drawing.Size(121, 21)
        Me.cboEmpleado.TabIndex = 15
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(20, 76)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 13)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Empleado"
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(458, 24)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 13
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(415, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 13)
        Me.Label23.TabIndex = 12
        Me.Label23.Text = "Precio"
        '
        'txtIdServicio
        '
        Me.txtIdServicio.Enabled = False
        Me.txtIdServicio.Location = New System.Drawing.Point(277, 24)
        Me.txtIdServicio.Name = "txtIdServicio"
        Me.txtIdServicio.Size = New System.Drawing.Size(100, 20)
        Me.txtIdServicio.TabIndex = 11
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(215, 28)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(54, 13)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "IdServicio"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(20, 28)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Servicio"
        '
        'cboServicio
        '
        Me.cboServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboServicio.FormattingEnabled = True
        Me.cboServicio.Location = New System.Drawing.Point(77, 24)
        Me.cboServicio.Name = "cboServicio"
        Me.cboServicio.Size = New System.Drawing.Size(121, 21)
        Me.cboServicio.TabIndex = 1
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 418)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(161, 30)
        Me.cmdNuevo.TabIndex = 11
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabar.Location = New System.Drawing.Point(12, 452)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(161, 30)
        Me.cmdGrabar.TabIndex = 12
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Location = New System.Drawing.Point(12, 486)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(161, 30)
        Me.cmdImprimir.TabIndex = 13
        Me.cmdImprimir.Text = "Imprimir"
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(11, 520)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(162, 30)
        Me.cmdSalir.TabIndex = 14
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(64, 40)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(93, 20)
        Me.dtpFecha.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(21, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Fecha"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(662, 50)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(47, 13)
        Me.Label27.TabIndex = 16
        Me.Label27.Text = "Id_Pago"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(399, 9)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(121, 41)
        Me.Label31.TabIndex = 35
        Me.Label31.Text = "Pagos"
        '
        'frmMovimientoPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 685)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.grupoServicio)
        Me.Controls.Add(Me.txtIdPago)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grupoAgua)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMovimientoPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grupoAgua.ResumeLayout(False)
        Me.grupoAgua.PerformLayout()
        Me.grupoServicio.ResumeLayout(False)
        Me.grupoServicio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIdPago As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbServicio As RadioButton
    Friend WithEvents rbAgua As RadioButton
    Friend WithEvents grupoAgua As GroupBox
    Friend WithEvents grupoServicio As GroupBox
    Friend WithEvents txtIdEmpleado As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents cboEmpleado As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtIdServicio As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents cboServicio As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents cboMesFinal As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cboMesInicial As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtInfra As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTarifa As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtRecargo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCuota As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboTarifa As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIdSituacion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboSituacion As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdImprimir As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents txtTarifaAplicada As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtInfraAplicado As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtRecargoAplicado As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCuotaAplicada As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents dgCuenta As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdCuenta As TextBox
    Friend WithEvents txtTotalApagar As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtOtro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txtIdTarifa As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtDescuentoAplicado As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label31 As Label
End Class
