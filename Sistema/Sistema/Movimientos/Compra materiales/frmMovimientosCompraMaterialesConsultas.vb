Imports System.Data.SqlClient


Public Class frmMovimientosCompraMaterialesConsultas
    Dim conexionsql As New SqlConnection("Data Source='PRO'; Initial Catalog='sistemaAguaPotable'; integrated security= true")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader


    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFecha.CheckedChanged
        If rbFecha.Checked Then
            dtpFecha.Visible = True
            btnAceptar.Visible = True
        Else
            dtpFecha.Visible = False
            btnAceptar.Visible = False
        End If
    End Sub

    Private Sub rbProveedor_CheckedChanged(sender As Object, e As EventArgs) Handles rbProveedor.CheckedChanged
        If rbProveedor.Checked Then
            cboProveedor.Visible = True
            btnAceptar.Visible = True

        Else
            cboProveedor.Visible = False
            btnAceptar.Visible = False
        End If
    End Sub

    Private Sub frmMovimientosCompraMaterialesConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()

        comando.CommandText = "Select * from proveedores"
        lector = comando.ExecuteReader

        While lector.Read
            cboProveedor.Items.Add(lector(1))
        End While
        lector.Close()



    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        dgConsulta.Rows.Clear()

        If rbFecha.Checked Then
            Dim fechBus As String
            fechBus = dtpFecha.Value.Date
            comando.CommandText = "Select comprasMateriales.id_Compra, proveedores.nombre, comprasMateriales.fecha, comprasMateriales.total from comprasMateriales inner join proveedores on comprasMateriales.id_Proveedor = proveedores.id_proveedor where comprasMateriales.fecha = '" & fechBus & "'"
            lector = comando.ExecuteReader

            While lector.Read
                dgConsulta.Rows.Add(lector(0), lector(1), lector(2), lector(3))
            End While
            lector.Close()

        Else
            comando.CommandText = "Select comprasMateriales.id_Compra, proveedores.nombre, comprasMateriales.fecha, comprasMateriales.total from comprasMateriales inner join proveedores on comprasMateriales.id_Proveedor = proveedores.id_proveedor where proveedores.nombre = '" & cboProveedor.SelectedItem & "'"
            lector = comando.ExecuteReader

            While lector.Read
                dgConsulta.Rows.Add(lector(0), lector(1), lector(2), lector(3))
            End While
            lector.Close()

        End If
    End Sub
End Class