Public Class FRMbuscarVehiculoModelo
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim bd As New BaseDeDatos()
        Dim qprocedure As String

        qprocedure = "verVehiculos"

        If (bd.ejecutarQuery(qprocedure)) Then
            grdDatos.Rows.Clear()
            While (bd.tabla.Read)
                grdDatos.Rows.Add(bd.tabla(0), bd.tabla(1), bd.tabla(2), bd.tabla(3), bd.tabla(4), bd.tabla(5), bd.tabla(6), bd.tabla(7))
            End While
        Else
            MsgBox("Eror en la base de datos")
        End If
        bd.cerrarConexion()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim bd As New BaseDeDatos()
        Dim qprocedure As String
        Dim valorInicial As Integer
        Dim valorFinal As Integer
        Dim validacion As Boolean

        Try
            valorInicial = CInt(txtInicio.Text)
            valorFinal = CInt(txtFinal.Text)
            validacion = True
        Catch ex As Exception
            validacion = False
            MsgBox("Datos invalidos")
        End Try

        If (validacion) Then
            qprocedure = "verVehiculoModelo @inicio=" + valorInicial.ToString() + ", @final=" + valorFinal.ToString
            If (bd.ejecutarQuery(qprocedure)) Then
                grdDatos.Rows.Clear()
                While (bd.tabla.Read)
                    grdDatos.Rows.Add(bd.tabla(0), bd.tabla(1), bd.tabla(2), bd.tabla(3), bd.tabla(4), bd.tabla(5), bd.tabla(6), bd.tabla(7))
                End While
            Else
                MsgBox("Error en la base de datos")
            End If
            bd.cerrarConexion()
        End If
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub VerClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerClientesToolStripMenuItem.Click
        FRMverClientes.Show()
    End Sub

    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem.Click
        FRMverVehiculos.Show()
    End Sub

    Private Sub BuscarPorMarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPorMarcaToolStripMenuItem.Click
        FRMbuscarVehiculoMarca.Show()
    End Sub

    Private Sub BuscarPorPropetarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPorPropetarioToolStripMenuItem.Click
        FRMbuscarVehiculoPropetario.Show()
    End Sub
End Class