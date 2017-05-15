Imports System.Data.SqlClient

Public Class frmMovimientosActividadPozos
    'variable que se encarga de realizar la conexión con la base de datos de sql de nuestro sistema de agua potable
    Dim conexionsql As New SqlConnection("Data Source='PRO'; Initial Catalog='sistemaAguaPotable'; integrated security= true")


    Private Sub frmMovimientosActividadPozos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se abré la conexión con la base de datos por medio del comando del conexionsql.open()
        conexionsql.Open()

        'Variable que se encarga de escribir la instrucción o colocar la instrucción pero no ejecutarla
        Dim comando As New SqlCommand("Select * from pozos", conexionsql)

        'Variable que se encarga de guardar la consulta  que se realizo anteriormente (lee los datos y los guarda)
        Dim lector As SqlDataReader

        'Con esta instrucción leemos todos los datos que han sido leídos
        lector = comando.ExecuteReader()

        'ciclo que nos permite leer todos los registros almacenados en la base de datos o tabla seleccionada.
        dgActividades.Rows.Clear()
        While lector.Read
            'agrega la ubicación de los pozos a nuestro comboBox
            cboPozo.Items.Add(lector(1))
        End While
        'Cierra el flujo de lectura
        lector.Close()

        'Se unen 2 tablas y obtenemos los datos de dichas tablas
        comando.CommandText = "Select actividadPozos.id_Actividad, actividadPozos.id_pozo, pozos.ubicacion, actividadPozos.fecha, actividadPozos.hora, actividadPozos.lectura, actividadPozos.obs from actividadPozos inner join pozos on actividadPozos.id_Pozo = pozos.id_pozo"
        lector = comando.ExecuteReader


        While lector.Read
            'se agregan los datos obtenidos de las consultas a nuestro datagriWied 
            dgActividades.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
        End While
        lector.Close()


    End Sub
    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim comando As New SqlCommand("Select count(*) from actividadPozos", conexionsql)
        Dim n As Integer
        n = comando.ExecuteScalar + 1
        txtIdActividad.Text = n
        cmdNuevo.Enabled = False
        txtLectura.Enabled = True
        cboPozo.Enabled = True
        cmdNuevo.Enabled = True
        dtpFecha.Enabled = True
        mskHora.Enabled = True
        txtObservaciones.Enabled = True
        cboPozo.SelectedIndex = 0


    End Sub

    Private Sub cmbGrabar_Click(sender As Object, e As EventArgs) Handles cmbGrabar.Click
        txtLectura.Enabled = True
        cboPozo.Enabled = True
        cmdNuevo.Enabled = True
        dtpFecha.Enabled = True
        cmbGrabar.Enabled = True

        Dim c1 As Integer
        Dim c2 As Integer
        Dim c3 As Date
        Dim c4 As String
        Dim c5 As String
        Dim c6 As String

        c1 = Val(txtIdActividad.Text)
        c2 = Val(txtIdPoz.Text)
        c3 = dtpFecha.Text
        c4 = mskHora.Text
        c5 = txtLectura.Text
        c6 = txtObservaciones.Text
        Dim r As String
        r = "insert into actividadPozos(id_Actividad, id_Pozo, fecha, hora, lectura, obs) values(" & c1 & "," & c2 & ",'" & c3 & "','" & c4 & "','" & c5 & "','" & c6 & "')"
        MessageBox.Show(r)
        Dim comando As New SqlCommand(r, conexionsql)
        comando.ExecuteNonQuery()



    End Sub

    Private Sub cboPozo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPozo.SelectedIndexChanged
        Dim r As String
        r = "select* from pozos where ubicacion= '" & cboPozo.Text & "'"
        Dim comando As New SqlCommand(r, conexionsql)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        lector.Read()
        txtIdPoz.Text = lector(0)
        lector.Close()

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        conexionsql.Close()
        Me.Close()

    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) 
    End Sub

    Private Sub txtObservaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObservaciones.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
End Class