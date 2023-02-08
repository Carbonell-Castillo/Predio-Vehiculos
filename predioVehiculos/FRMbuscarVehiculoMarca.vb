Public Class FRMbuscarVehiculoMarca
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

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
        Dim buscar As String
        Dim validacion As Boolean

        Try
            buscar = txtBuscar.Text
            validacion = True
        Catch ex As Exception
            validacion = False
            MsgBox("Datos invalidos")
        End Try

        If (validacion) Then
            qprocedure = "verVehiculoMarca @marca='%" + buscar + "%'"
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

    Private Sub buscarNombre(nombre As String)
        Dim bd As New BaseDeDatos()
        Dim qprocedure As String
        Dim buscar As String

        buscar = nombre

        qprocedure = "verVehiculoPropetario @nombre='%" + buscar + "%'"
        If (bd.ejecutarQuery(qprocedure)) Then
                grdDatos.Rows.Clear()
                While (bd.tabla.Read)
                    grdDatos.Rows.Add(bd.tabla(0), bd.tabla(1), bd.tabla(2), bd.tabla(3), bd.tabla(4), bd.tabla(5), bd.tabla(6), bd.tabla(7))
                End While
            Else
                MsgBox("Error en la base de datos")
            End If
            bd.cerrarConexion()

    End Sub



    Private Sub FRMbuscarVehiculoMarca_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        cbPropetario.Items.Clear()
        Dim bd As New BaseDeDatos()
        If (bd.ejecutarQuery("verClientes")) Then
            While (bd.tabla.Read)
                cbPropetario.Items.Add(bd.tabla(2))
            End While
        End If

    End Sub

    Private Sub cbPropetario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPropetario.SelectedIndexChanged
        Dim nombre As String
        nombre = cbPropetario.Text
        buscarNombre(nombre)
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

    End Sub

    Private Sub BuscarPorModeloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPorModeloToolStripMenuItem.Click
        FRMbuscarVehiculoModelo.Show()
    End Sub

    Private Sub BuscarPorPropetarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPorPropetarioToolStripMenuItem.Click
        FRMbuscarVehiculoPropetario.Show()
    End Sub

    Private Sub FRMbuscarVehiculoMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class