Public Class frmCatalogoServicios
    Private Sub frmCatalogoServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.DataSetSistema.servicios)
        dgServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim numServicio As Integer

        txtIdServicio.Text = ""
        txtDescripcion.Text = ""
        txtPrecio.Text = ""

        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False

        cmdNuevo.Enabled = False
        cmdSalir.Enabled = False
        cmdCancelar.Enabled = True
        cmdGrabar.Enabled = True

        numServicio = ServiciosBindingSource.Count + 1
        ServiciosBindingSource.AddNew()
        txtIdServicio.Text = numServicio
        txtDescripcion.Enabled = True
        txtPrecio.Enabled = True
        dgServicios.Enabled = False
        txtDescripcion.Focus()


    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If String.IsNullOrWhiteSpace(txtDescripcion.Text) Or String.IsNullOrWhiteSpace(txtPrecio.Text) Then
            MsgBox("AÚN HAY CAMPOS EN BLANCO")
            txtDescripcion.Focus()
        Else
            If txtDescripcion.TextLength < 5 Then
                MsgBox("LA DESCRIPCIÓN DEBE DE TENER AL MENOS 5 CARACTERES")
                txtDescripcion.Focus()
            Else

            End If
            ServiciosBindingSource.Current(0) = txtIdServicio.Text
            ServiciosBindingSource.Current(1) = txtDescripcion.Text
            ServiciosBindingSource.Current(2) = txtPrecio.Text

            txtIdServicio.Enabled = False
            txtDescripcion.Enabled = False
            txtPrecio.Enabled = False

            dgServicios.Enabled = True

            txtIdServicio.Text = ""
            txtDescripcion.Text = ""
            txtPrecio.Text = ""

            cmdNuevo.Enabled = True
            cmdSalir.Enabled = True
            cmdCancelar.Enabled = False
            cmdGrabar.Enabled = False

            cmdInicio.Enabled = True
            cmdSiguiente.Enabled = True
            cmdAnterior.Enabled = True
            cmdUltimo.Enabled = True
            dgServicios.Refresh()
        End If


    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        ServiciosBindingSource.EndEdit()
        ServiciosTableAdapter.Update(DataSetSistema.servicios)
        Me.Dispose()
    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        ServiciosBindingSource.MoveFirst()
        asignarMovimiento()

    End Sub
    Private Sub asignarMovimiento()
        txtIdServicio.Text = ServiciosBindingSource.Current(0)
        txtDescripcion.Text = ServiciosBindingSource.Current(1)
        txtPrecio.Text = ServiciosBindingSource.Current(2)
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        ServiciosBindingSource.MovePrevious()
        asignarMovimiento()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        ServiciosBindingSource.MoveNext()
        asignarMovimiento()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        ServiciosBindingSource.MoveLast()
        asignarMovimiento()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        txtIdServicio.Enabled = False
        txtDescripcion.Enabled = False
        txtPrecio.Enabled = False

        dgServicios.Enabled = True

        txtIdServicio.Text = ""
        txtDescripcion.Text = ""
        txtPrecio.Text = ""

        cmdNuevo.Enabled = True
        cmdSalir.Enabled = True
        cmdCancelar.Enabled = False
        cmdGrabar.Enabled = False
        ServiciosBindingSource.CancelEdit()

    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(cadenaPrecios, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
End Class