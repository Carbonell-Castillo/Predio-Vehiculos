Public Class FRMverClientes
    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Form1.Show()

    End Sub

    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem.Click
        FRMverVehiculos.Show()
    End Sub

    Private Sub BuscarVehiculosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarVehiculosToolStripMenuItem.Click

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        verClientes()
    End Sub

    Private Sub FRMverClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub verClientes()
        Dim bd As New BaseDeDatos()
        Dim qprocedure As String

        qprocedure = "verClientes"

        If (bd.ejecutarQuery(qprocedure)) Then
            grdDatos.Rows.Clear()
            While (bd.tabla.Read)
                grdDatos.Rows.Add(bd.tabla(0), bd.tabla(1), bd.tabla(2), bd.tabla(3), bd.tabla(4))
            End While
        Else
            MsgBox("Eror en la base de datos")
        End If
        bd.cerrarConexion()

    End Sub
    Private Sub VerClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerClientesToolStripMenuItem.Click

    End Sub

    Private Sub BuscarPorModeloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPorModeloToolStripMenuItem.Click
        FRMbuscarVehiculoModelo.Show()
    End Sub

    Private Sub BuscarPorMarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPorMarcaToolStripMenuItem.Click
        FRMbuscarVehiculoMarca.Show()
    End Sub

    Private Sub BuscarPorPropetarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPorPropetarioToolStripMenuItem.Click
        FRMbuscarVehiculoPropetario.Show()
    End Sub

    Private Sub FRMverClientes_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        verClientes()
    End Sub
End Class