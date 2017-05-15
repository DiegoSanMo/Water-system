Public Class frmCatalogoGastos
    Private Sub frmCatalogoGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.gastos' Puede moverla o quitarla según sea necesario.
        Me.GastosTableAdapter.Fill(Me.DataSetSistema.gastos)
        dgGasto.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        GastosBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        GastosBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        GastosBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        GastosBindingSource.MoveLast()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim num As Integer

        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False

        cmdNuevo.Enabled = False
        cmdSalir.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        dgGasto.Enabled = False

        num = GastosBindingSource.Count + 1
        GastosBindingSource.AddNew()
        txtIdGasto.Text = num
        txtConcepto.Enabled = True
        txtConcepto.Focus()

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click

        If String.IsNullOrWhiteSpace(txtConcepto.Text) Then
            txtConcepto.Focus()
            MsgBox("NO SE HA INGRESADO CONCEPTO")
        Else
            If txtConcepto.TextLength < 5 Then
                txtConcepto.Focus()
                MsgBox("Se deben almacenar al menos 5 caracteres")
            Else
                txtConcepto.Enabled = False
                cmdGrabar.Enabled = False
                cmdCancelar.Enabled = False
                cmdNuevo.Enabled = True
                cmdSalir.Enabled = True


                cmdInicio.Enabled = True
                cmdSiguiente.Enabled = True
                cmdAnterior.Enabled = True
                cmdUltimo.Enabled = True
                dgGasto.Refresh()
            End If
        End If
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        GastosBindingSource.EndEdit()
        GastosTableAdapter.Update(DataSetSistema.gastos)
        Me.Dispose()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdNuevo.Enabled = True
        cmdSalir.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False

        cmdInicio.Enabled = True
        cmdSiguiente.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True

        dgGasto.Enabled = True
        txtConcepto.Enabled = False

        GastosBindingSource.CancelEdit()
    End Sub

    Private Sub txtConcepto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConcepto.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
End Class