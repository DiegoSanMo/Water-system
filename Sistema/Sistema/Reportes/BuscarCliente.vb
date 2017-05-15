Imports System.Data.SqlClient
Public Class BuscarCliente
    Dim conexionsql As New SqlConnection("Data source= 'PRO'; Initial Catalog = sistemaAguaPotable; integrated security= true")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader
    Dim n As Integer
    Private Sub BuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        conexionsql.Open()

        comando.CommandText = "Select count(*) from cuentas"
        n = comando.ExecuteScalar + 1

        If n > 1 Then
            comando.CommandText = "select cuentas.id_cuenta, cuentas.nombre, calles.nombre, cuentas.ultimoPagoA, cuentas.ultimoPagoM from cuentas inner join calles on calles.id_calle = cuentas.id_calle"
            lector = comando.ExecuteReader
            dgBusqueda.Rows.Clear()
            While lector.Read
                dgBusqueda.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
            lector.Close()

        End If

    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If n > 1 Then
            comando.CommandText = "select cuentas.id_cuenta, cuentas.nombre, calles.nombre, cuentas.ultimoPagoA, cuentas.ultimoPagoM from cuentas inner join calles on calles.id_calle = cuentas.id_calle where cuentas.nombre like '%" & txtNombre.Text & "%'"
            lector = comando.ExecuteReader
            dgBusqueda.Rows.Clear()
            While lector.Read
                dgBusqueda.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
            lector.Close()

        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim fila As Integer = dgBusqueda.CurrentCell.RowIndex
        MsgBox(fila)
        frmReporteParametros.txtNombreCliente.Text = dgBusqueda(1, fila).Value
        Me.Close()
        conexionsql.Close()

    End Sub
End Class