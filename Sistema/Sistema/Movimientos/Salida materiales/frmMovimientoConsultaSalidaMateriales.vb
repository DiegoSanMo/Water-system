Imports System.Data.SqlClient

Public Class frmMovimientoConsultaSalidaMateriales
    Dim conexionsql As New SqlConnection("Data Source = 'PRO'; Initial Catalog = 'sistemaAguaPotable'; integrated security = true")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader

    Private Sub frmMovimientoConsultaSalidaMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()

        comando.CommandText = "Select * from empleados"
        lector = comando.ExecuteReader
        While lector.Read
            cboEmpleado.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "Select * from calles"
        lector = comando.ExecuteReader
        While lector.Read
            cboCalle.Items.Add(lector(1))
        End While
        lector.Close()

    End Sub

    Private Sub rbSalida_CheckedChanged(sender As Object, e As EventArgs) Handles rbSalida.CheckedChanged
        If rbSalida.Checked Then
            txtNoSalida.Visible = True
        Else
            txtNoSalida.Visible = False
        End If


    End Sub

    Private Sub rbEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbEmpleado.CheckedChanged
        If rbEmpleado.Checked Then
            cboEmpleado.Visible = True
        Else
            cboEmpleado.Visible = False
        End If
    End Sub

    Private Sub rbCalle_CheckedChanged(sender As Object, e As EventArgs) Handles rbCalle.CheckedChanged
        If rbCalle.Checked Then
            cboCalle.Visible = True
        Else
            cboCalle.Visible = False
        End If
    End Sub

    Private Sub rbPeriodo_CheckedChanged(sender As Object, e As EventArgs) Handles rbPeriodo.CheckedChanged
        If rbPeriodo.Checked Then
            lblInicial.Visible = True
            lblFinal.Visible = True
            dtpFechaInicial.Visible = True
            dtpFechaFinal.Visible = True
        Else
            lblInicial.Visible = False
            lblFinal.Visible = False
            dtpFechaInicial.Visible = False
            dtpFechaFinal.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgConsultaS.Rows.Clear()


        If rbEmpleado.Checked Then

            '/////////////////////////////////////////////////////////////////
            comando.CommandText = "Select salidasMaterial.id_Salida, empleados.nombre, calles.nombre, salidasMaterial.fecha from salidasMaterial inner join empleados on empleados.id_empleado = salidasMaterial.id_Empleado inner join calles on calles.id_calle = salidasMaterial.id_Calle  where  empleados.nombre = '" & cboEmpleado.Text & "'"
            lector = comando.ExecuteReader

            While lector.Read
                dgConsultaS.Rows.Add(lector(0), lector(1), lector(2), lector(3))
            End While
            lector.Close()



        ElseIf rbCalle.Checked Then

            '/////////////////////////////////////////////////////////////////
            comando.CommandText = "Select salidasMaterial.id_Salida, empleados.nombre, calles.nombre, salidasMaterial.fecha from salidasMaterial inner join empleados on empleados.id_empleado = salidasMaterial.id_Empleado inner join calles on calles.id_calle = salidasMaterial.id_Calle  where  calles.nombre = '" & cboCalle.Text & "'"
            lector = comando.ExecuteReader

            While lector.Read
                dgConsultaS.Rows.Add(lector(0), lector(1), lector(2), lector(3))
            End While
            lector.Close()

        ElseIf rbSalida.Checked Then


            '/////////////////////////////////////////////////////////////////
            comando.CommandText = "Select salidasMaterial.id_Salida, empleados.nombre, calles.nombre, salidasMaterial.fecha from salidasMaterial inner join empleados on empleados.id_empleado = salidasMaterial.id_Empleado inner join calles on calles.id_calle = salidasMaterial.id_Calle  where  salidasMaterial.id_Salida = '" & Val(txtNoSalida.Text) & "'"
            lector = comando.ExecuteReader

            While lector.Read
                dgConsultaS.Rows.Add(lector(0), lector(1), lector(2), lector(3))
            End While
            lector.Close()



        ElseIf rbPeriodo.Checked Then


            comando.CommandText = "Select salidasMaterial.id_Salida, empleados.nombre, calles.nombre, salidasMaterial.fecha from salidasMaterial inner join empleados on empleados.id_empleado = salidasMaterial.id_Empleado inner join calles on calles.id_calle = salidasMaterial.id_Calle  where  salidasMaterial.fecha BETWEEN  '" & dtpFechaInicial.Value.Date & "' and '" & dtpFechaFinal.Value.Date & "'"
            lector = comando.ExecuteReader

            While lector.Read
                dgConsultaS.Rows.Add(lector(0), lector(1), lector(2), lector(3))
            End While
            lector.Close()



        ElseIf rbGeneral.Checked Then

            comando.CommandText = "Select salidasMaterial.id_Salida, empleados.nombre, calles.nombre, salidasMaterial.fecha from salidasMaterial inner join empleados on empleados.id_empleado = salidasMaterial.id_Empleado inner join calles on calles.id_calle = salidasMaterial.id_Calle "
            lector = comando.ExecuteReader

            While lector.Read
                dgConsultaS.Rows.Add(lector(0), lector(1), lector(2), lector(3))
            End While
            lector.Close()
        End If
    End Sub

    Private Sub btnDetalles_Click(sender As Object, e As EventArgs) Handles btnDetalles.Click
        Dim detalle As New frmDetalleSalidaMateriales
        detalle.dgDetalleSalida.Rows.Clear()
        Dim fila As Integer = dgConsultaS.CurrentRow.Index
        Dim salida As Integer = dgConsultaS.Item(0, fila).Value

        detalle.txtEmpleado.Text = dgConsultaS.Item(1, fila).Value
        detalle.txtCalle.Text = dgConsultaS.Item(2, fila).Value

        comando.CommandText = "Select * from salidasMaterial where id_Salida = " & dgConsultaS.Item(0, fila).Value & ""
        lector = comando.ExecuteReader
        lector.Read()
        detalle.txtIdSalida.Text = lector(0)
        detalle.txtConcepto.Text = lector(4)
        lector.Close()


        comando.CommandText = "Select * from empleados where nombre = '" & dgConsultaS.Item(1, fila).Value & "'"
        lector = comando.ExecuteReader
        lector.Read()

        detalle.txtidEmpleado.Text = lector(0)
        lector.Close()


        comando.CommandText = "Select * from calles where nombre = '" & dgConsultaS.Item(2, fila).Value & "'"
        lector = comando.ExecuteReader
        lector.Read()
        detalle.txtIdCalle.Text = lector(0)
        lector.Close()

        comando.CommandText = "Select * from detSalidaMateriales where id_Salida = " & Val(detalle.txtIdSalida.Text) & ""
        lector = comando.ExecuteReader

        While lector.Read
            detalle.dgDetalleSalida.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(2) * lector(3))
        End While
        lector.Close()

        detalle.ShowDialog()
    End Sub


    Private Sub dgConsultaS_SelectionChanged(sender As Object, e As EventArgs) Handles dgConsultaS.SelectionChanged
        btnDetalles.Visible = True
    End Sub
End Class