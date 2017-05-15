Public Class frmCatalogoPozos
    Private Sub frmCatalogoPozos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.pozos' Puede moverla o quitarla según sea necesario.
        Me.PozosTableAdapter.Fill(Me.DataSetSistema.pozos)
        dgPozos.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If String.IsNullOrWhiteSpace(txtUbicacion.Text) Then
            txtUbicacion.Focus()
            MsgBox("No se ha ingresado ubicación")
        Else
            If txtUbicacion.TextLength < 5 Then
                txtUbicacion.Focus()
                MsgBox("Se deben almacenar al menos 5 caracteres")
            Else
                PozosBindingSource.Current(0) = txtIdPozo.Text
                PozosBindingSource.Current(1) = txtUbicacion.Text

                txtIdPozo.Enabled = False
                txtUbicacion.Enabled = False

                cmdInicio.Enabled = True
                cmdSiguiente.Enabled = True
                cmdAnterior.Enabled = True
                cmdUltimo.Enabled = True

                cmdGrabar.Enabled = False
                cmdCancelar.Enabled = False
                cmdSalir.Enabled = True
                cmdNuevo.Enabled = True

                dgPozos.Refresh()
                dgPozos.Enabled = True
            End If
        End If

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim numPozo As Integer
        txtIdPozo.Text = ""
        txtUbicacion.Text = ""

        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False

        cmdNuevo.Enabled = False
        cmdSalir.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True

        numPozo = PozosBindingSource.Count + 1
        PozosBindingSource.AddNew()
        txtIdPozo.Text = numPozo
        txtUbicacion.Enabled = True

        dgPozos.Enabled = False

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        PozosBindingSource.EndEdit()
        PozosTableAdapter.Update(DataSetSistema.pozos)
        Me.Dispose()
    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        PozosBindingSource.MoveFirst()
        asignarText()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        PozosBindingSource.MovePrevious()
        asignarText()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        PozosBindingSource.MoveNext()
        asignarText()
    End Sub

    Private Sub asignarText()
        txtIdPozo.Text = PozosBindingSource.Current(0)
        txtUbicacion.Text = PozosBindingSource.Current(1)
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        PozosBindingSource.MoveLast()
        asignarText()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        PozosBindingSource.CancelEdit()

        cmdInicio.Enabled = True
        cmdSiguiente.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True

        cmdNuevo.Enabled = True
        cmdSalir.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        dgPozos.Enabled = True

        txtUbicacion.Enabled = False
        txtIdPozo.Text = ""
        txtUbicacion.Text = ""
    End Sub

    Private Sub txtUbicacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUbicacion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
End Class