Imports System.Data.SqlClient

Public Class frmMovimientosGastosRealizados

    Dim conexionsql As New SqlConnection("Data Source='PRO'; Initial Catalog='sistemaAguaPotable'; integrated security= true")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader
    Dim r As String
    Dim banTodos As Boolean = False
    Dim banEmple As Boolean = False
    Dim banFecha As Boolean = False
    Dim banConce As Boolean = False

    Private Sub frmMovimientosGastosRealizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexionsql.Open()

        comando.CommandText = "Select * from empleados"
        lector = comando.ExecuteReader

        While lector.Read
            cboEmpleado.Items.Add(lector(1))
            cboEmpleBus.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "Select * from gastos"
        lector = comando.ExecuteReader
        While lector.Read
            cboConcepto.Items.Add(lector(1))
            cboConceptoGR.Items.Add(lector(1))
        End While
        lector.Close()


    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        'activacion y desactivacion de botones
        cmdGrabar.Enabled = True
        cmdNuevo.Enabled = False
        cmdSalir.Enabled = False
        cmdConsultar.Enabled = False

        'desactivación del grupo de consulta
        grupoBusqueda.Enabled = False

        'se habilitan el datatime y comboBox
        dtpFecha.Enabled = True
        cboEmpleado.Enabled = True

        'se habilitan las mascaras
        cboConceptoGR.Enabled = True
        mskImporte.Enabled = True
        mskObservaciones.Enabled = True

        'se habilitan los radioButton
        rbConcepto.Enabled = False
        rbEmpleado.Enabled = False
        rbFecha.Enabled = False
        rbTodos.Enabled = False

        'se habilitan el boton de aceptar para realizar busquedas
        cmdAceptar.Enabled = False

        'Se abre conexión
        comando.CommandText = "Select count(*) from gastosRealizados"
        Dim n As Integer
        n = comando.ExecuteScalar + 1
        txtIdGastoRealizado.Text = n

        dgGastos.Enabled = False

    End Sub

    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFecha.CheckedChanged
        If rbFecha.Checked = True Then
            dtpFechaBus.Visible = True
            dtpFechaBus.Enabled = True
        Else
            dtpFechaBus.Visible = False
        End If


    End Sub

    Private Sub rbConcepto_CheckedChanged(sender As Object, e As EventArgs) Handles rbConcepto.CheckedChanged
        If rbConcepto.Checked = True Then
            cboConcepto.Visible = True
            cboConcepto.Enabled = True
        Else
            cboConcepto.Visible = False
        End If
    End Sub

    Private Sub rbEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbEmpleado.CheckedChanged
        If rbEmpleado.Checked = True Then
            cboEmpleBus.Visible = True
            cboEmpleBus.Enabled = True
        Else
            cboEmpleBus.Visible = False
            cboEmpleBus.Enabled = False
        End If
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click

        'se activacion y desactivacion botones 
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdSalir.Enabled = True
        cmdConsultar.Enabled = True


        Dim c1 As Integer 'IdGastoR
        Dim c2 As Integer 'IdEmpleado
        Dim c3 As Integer 'IdGasto
        Dim c4 As Date  'Fecha
        Dim c5 As Decimal  'importe
        Dim c6 As String  'Observaciones

        c1 = Val(txtIdGastoRealizado.Text)
        c2 = Val(txtIdEmpleado.Text)
        c3 = Val(mskIdGasto.Text)
        c4 = dtpFecha.Text
        c5 = CDec(mskImporte.Text)
        c6 = mskObservaciones.Text

        comando.CommandText = "insert into gastosRealizados(id_GastoRealizado, id_Empleado, id_Gasto, fecha, importe, observaciones) values(" & c1 & "," & c2 & "," & c3 & ",'" & c4 & "', " & c5 & ",'" & c6 & "')"
        comando.ExecuteNonQuery()

        grupoGastos.Enabled = False



        txtDomicilio.Text = ""
        txtIdEmpleado.Text = ""
        txtIdGastoRealizado.Text = ""
        mskIdGasto.Text = ""
        mskImporte.Text = ""
        mskObservaciones.Text = ""
        txtTel.Text = ""



        dgGastos.Refresh()

        'se habilitan el datatime y comboBox
        dtpFecha.Enabled = False
        cboEmpleado.Enabled = False

        'se habilitan las mascaras
        cboConceptoGR.Enabled = False
        mskImporte.Enabled = False
        mskObservaciones.Enabled = False

        grupoBusqueda.Enabled = False
        rbConcepto.Enabled = True
        rbFecha.Enabled = True
        rbTodos.Enabled = True
        rbEmpleado.Enabled = True
        cmdAceptar.Enabled = True
        dgGastos.Enabled = True

    End Sub


    Private Sub cboConceptoGR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboConceptoGR.SelectedIndexChanged
        comando.CommandText = "select* from gastos where Concepto = '" & cboConceptoGR.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        mskIdGasto.Text = lector(0)
        lector.Close()

    End Sub

    Private Sub cboEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpleado.SelectedIndexChanged
        comando.CommandText = "select* from empleados where nombre = '" & cboEmpleado.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdEmpleado.Text = lector(0)
        txtDomicilio.Text = lector(2)
        txtTel.Text = lector(6)
        lector.Close()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click

        dgGastos.Rows.Clear()


        If banConce = True Then

            Dim concep As String

            concep = cboConcepto.SelectedItem
            comando.CommandText = "Select gastosRealizados.id_GastoRealizado, gastosRealizados.fecha, gastosRealizados.id_Empleado, empleados.nombre, gastos.Concepto, gastosRealizados.importe from gastosRealizados inner join empleados on gastosRealizados.id_Empleado = empleados.id_empleado inner join gastos on gastosRealizados.id_Gasto = gastos.id_gasto where gastos.Concepto = '" & concep & "'"
            lector = comando.ExecuteReader
            While lector.Read
                dgGastos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            End While
            lector.Close()
            banConce = False

        ElseIf banEmple = True Then
            Dim nomEm As String
            nomEm = cboEmpleBus.SelectedItem
            comando.CommandText = "Select gastosRealizados.id_GastoRealizado, gastosRealizados.fecha, gastosRealizados.id_Empleado, empleados.nombre, gastos.Concepto, gastosRealizados.importe from gastosRealizados inner join empleados on gastosRealizados.id_Empleado = empleados.id_empleado inner join gastos on gastosRealizados.id_Gasto = gastos.id_gasto where empleados.nombre = '" & nomEm & "'"
            lector = comando.ExecuteReader
            While lector.Read
                dgGastos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            End While
            banEmple = False

        ElseIf banTodos = True Then
            comando.CommandText = "Select gastosRealizados.id_GastoRealizado, gastosRealizados.fecha, gastosRealizados.id_Empleado, empleados.nombre, gastos.Concepto, gastosRealizados.importe from gastosRealizados inner join empleados on gastosRealizados.id_Empleado = empleados.id_empleado inner join gastos on gastosRealizados.id_Gasto = gastos.id_gasto"
            lector = comando.ExecuteReader
            While lector.Read
                dgGastos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            End While
            banTodos = False

        ElseIf banFecha = True Then
            comando.CommandText = "Select gastosRealizados.id_GastoRealizado, gastosRealizados.fecha, gastosRealizados.id_Empleado, empleados.nombre, gastos.Concepto, gastosRealizados.importe from gastosRealizados inner join empleados on gastosRealizados.id_Empleado = empleados.id_empleado inner join gastos on gastosRealizados.id_Gasto = gastos.id_gasto where gastosRealizados.fecha = '" & dtpFechaBus.Value.Date & "'"
            lector = comando.ExecuteReader
            While lector.Read
                dgGastos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            End While
            banFecha = False

        End If
        lector.Close()


    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        If rbTodos.Checked Then
            banTodos = True
        Else
            banTodos = False

        End If
    End Sub

    Private Sub dtpFechaBus_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaBus.ValueChanged
        If rbFecha.Checked Then
            banFecha = True
        Else
            banFecha = False
        End If

    End Sub

    Private Sub cboConcepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboConcepto.SelectedIndexChanged

        If cboConcepto.SelectedIndex > -1 Then
            banConce = True
        Else
            banConce = False

        End If
    End Sub

    Private Sub cboEmpleBus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpleBus.SelectedIndexChanged

        If cboEmpleBus.SelectedIndex > -1 Then
            banEmple = True
        Else
            banEmple = False

        End If

    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        'activacion de el grupo para buscar
        grupoBusqueda.Enabled = True
        cmdGrabar.Enabled = False
        cmdSalir.Enabled = True

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub
End Class