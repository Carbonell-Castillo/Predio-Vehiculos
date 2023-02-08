Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bd As New BaseDeDatos()
        If bd.conectar() Then
            lblEstado.Text = "Base de datos conectada"
        Else
            lblEstado.Text = "Fallo en la Base de datos"
        End If
        bd.cerrarConexion()
    End Sub

    Private Sub VerClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerClientesToolStripMenuItem.Click
        FRMverClientes.Show()
    End Sub

    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem.Click
        FRMverVehiculos.Show()
    End Sub

    Private Sub BuscarVehiculosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarVehiculosToolStripMenuItem.Click

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

    Private Sub IngresoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeClientesToolStripMenuItem.Click
        FRMnuevoCliente.Show()
    End Sub

    Private Sub IngresoDeVehiculosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeVehiculosToolStripMenuItem.Click
        FRMnuevoVehiculo.Show()
    End Sub
End Class
