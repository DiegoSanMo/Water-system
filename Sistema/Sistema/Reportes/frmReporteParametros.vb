Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmReporteParametros

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click

        'Dim fecha1 As String
        'Dim fecha2 As String

        'fecha1 = dtpFechaInicial.Value.Day & "/" & dtpFechaInicial.Value.Month & "/" & dtpFechaInicial.Value.Year
        'fecha2 = dtpFechaFinal.Value.Day & "/" & dtpFechaFinal.Value.Month & "/" & dtpFechaFinal.Value.Year

        Dim conexion As New SqlConnection("Data source= 'PRO'; Initial Catalog = sistemaAguaPotable; integrated security= true")

        If lblGastosPorPeriodo.Visible = True Then
            conexion.Open()
            Dim cmd As New SqlCommand("ReporteGastosPorPeriodo", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter()
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.CommandText = "ReporteGastosPorPeriodo"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@fecha1", SqlDbType.Date)
            Dim param2 = New SqlParameter("@fecha2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(dtpFechaInicial.Text)
            param2.Value = CDate(dtpFechaFinal.Text)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", CDate(dtpFechaInicial.Text))
            Dim p2 As New ReportParameter("P2", CDate(dtpFechaFinal.Text))

            frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer2.LocalReport.DataSources.Add(datasource)
            frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\ReporteGastosPorPer.rdlc"
            frmReportes.ReportViewer2.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer2.RefreshReport()
            frmReportes.ShowDialog()
            conexion.Close()

        ElseIf lblHistorial.Visible = True Then
            If String.IsNullOrWhiteSpace(txtNombreCliente.Text) Then
                MsgBox("No se ha ingresado cuenta")
                btnBuscarCliente.Focus()
            Else
                conexion.Open()
                Dim cmd As New SqlCommand("ReporteHistorialClientes", conexion)
                cmd.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter()
                adaptador.SelectCommand = New SqlCommand
                adaptador.SelectCommand.Connection = conexion
                adaptador.SelectCommand.CommandText = "ReporteHistorialClientes"
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim param1 = New SqlParameter("@nombre", SqlDbType.NVarChar)
                param1.Direction = ParameterDirection.Input
                param1.Value = CStr(txtNombreCliente.Text)
                adaptador.SelectCommand.Parameters.Add(param1)
                Dim dataset As New DataSet
                adaptador.Fill(dataset)
                dataset.DataSetName = "DataSet1"
                Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                datasource.Name = "DataSet1"
                datasource.Value = dataset.Tables(0)
                Dim p1 As New ReportParameter("P1", CStr(txtNombreCliente.Text))

                frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
                frmReportes.ReportViewer2.LocalReport.DataSources.Add(datasource)
                frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\HistorialPagoCliente.rdlc"
                frmReportes.ReportViewer2.LocalReport.SetParameters(New ReportParameter() {p1})
                frmReportes.ReportViewer2.RefreshReport()
                frmReportes.ShowDialog()
                conexion.Close()

            End If
        ElseIf lblEntradasPeriodo.Visible = True Then

            conexion.Open()
            Dim cmd As New SqlCommand("ReporteEntradasMaterialPer", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter()
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.CommandText = "ReporteEntradasMaterialPer"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@fecha1", SqlDbType.Date)
            Dim param2 = New SqlParameter("@fecha2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(dtpFechaInicial.Text)
            param2.Value = CDate(dtpFechaFinal.Text)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", CDate(dtpFechaInicial.Text))
            Dim p2 As New ReportParameter("P2", CDate(dtpFechaFinal.Text))

            frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer2.LocalReport.DataSources.Add(datasource)
            frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\EntradasPorPeriodo.rdlc"
            frmReportes.ReportViewer2.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer2.RefreshReport()
            frmReportes.ShowDialog()
            conexion.Close()

        ElseIf lblSalidaMaterial.Visible = True Then
            conexion.Open()
            Dim cmd As New SqlCommand("ReporteSalidaMaterialesPeriodo", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter()
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.CommandText = "ReporteSalidaMaterialesPeriodo"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@fecha1", SqlDbType.Date)
            Dim param2 = New SqlParameter("@fecha2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(dtpFechaInicial.Text)
            param2.Value = CDate(dtpFechaFinal.Text)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", CDate(dtpFechaInicial.Text))
            Dim p2 As New ReportParameter("P2", CDate(dtpFechaFinal.Text))

            frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer2.LocalReport.DataSources.Add(datasource)
            frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\SalidaMaterialesPer.rdlc"
            frmReportes.ReportViewer2.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer2.RefreshReport()
            frmReportes.ShowDialog()
            conexion.Close()

        ElseIf lblPagosPer.Visible = True Then
            conexion.Open()
            Dim cmd As New SqlCommand("PagosPorPeriodo", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter()
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.CommandText = "PagosPorPeriodo"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@fecha1", SqlDbType.Date)
            Dim param2 = New SqlParameter("@fecha2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(dtpFechaInicial.Text)
            param2.Value = CDate(dtpFechaFinal.Text)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", CDate(dtpFechaInicial.Text))
            Dim p2 As New ReportParameter("P2", CDate(dtpFechaFinal.Text))

            frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer2.LocalReport.DataSources.Add(datasource)
            frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\ReportePagosPer.rdlc"
            frmReportes.ReportViewer2.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer2.RefreshReport()
            frmReportes.ShowDialog()
            conexion.Close()

        ElseIf lblactividadPozos.Visible = True Then

            conexion.Open()
            Dim cmd As New SqlCommand("ActividadPozosPeriodo", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter()
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.CommandText = "ActividadPozosPeriodo"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@fecha1", SqlDbType.Date)
            Dim param2 = New SqlParameter("@fecha2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(dtpFechaInicial.Text)
            param2.Value = CDate(dtpFechaFinal.Text)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", CDate(dtpFechaInicial.Text))
            Dim p2 As New ReportParameter("P2", CDate(dtpFechaFinal.Text))

            frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer2.LocalReport.DataSources.Add(datasource)
            frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\ActPozosPer.rdlc"
            frmReportes.ReportViewer2.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer2.RefreshReport()
            frmReportes.ShowDialog()
            conexion.Close()
        ElseIf lblServiciosPeriodo.Visible = True Then
            conexion.Open()
            Dim cmd As New SqlCommand("ServicioPeriodo ", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter()
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.CommandText = "ServicioPeriodo "
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@fecha1", SqlDbType.Date)
            Dim param2 = New SqlParameter("@fecha2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(dtpFechaInicial.Text)
            param2.Value = CDate(dtpFechaFinal.Text)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", CDate(dtpFechaInicial.Text))
            Dim p2 As New ReportParameter("P2", CDate(dtpFechaFinal.Text))

            frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer2.LocalReport.DataSources.Add(datasource)
            frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\ServiciosPer.rdlc"
            frmReportes.ReportViewer2.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer2.RefreshReport()
            frmReportes.ShowDialog()
            conexion.Close()

        End If

    End Sub

    Private Sub frmReporteParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        BuscarCliente.ShowDialog()
    End Sub
End Class