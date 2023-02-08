Public Class FRMnuevoVehiculo


    Private Sub txtPlaca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPlaca.KeyPress
        Dim vehiculo As New Vehiculo
        Dim placa As String = txtPlaca.Text
        'datos
        If (e.KeyChar = Chr(13)) Then
            If (vehiculo.buscarPlaca(placa)) Then
                txtModelo.Text = vehiculo.Modelo
                txtNcilindros.Text = vehiculo.NCilindros
                txtMarca.Text = vehiculo.Marca
            Else
                gbDatosAuto.Enabled = True
            End If
        End If
    End Sub



    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Public Sub limpiar()
        'datos del cliente
        gbDatos.Enabled = False
        txtDireccion.Text = ""
        txtNIT.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        'datos del carro
        txtPlaca.Enabled = False
        gbDatosAuto.Enabled = False
        txtMarca.Text = ""
        txtModelo.Text = ""
        txtNIT.Text = ""
        txtPlaca.Text = ""
        txtNcilindros.Text = ""

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        limpiar()
    End Sub


    Private Sub txtDPI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDPI.KeyPress
        Dim propetario As New Propetario
        Dim dpi As String = txtDPI.Text
        Dim nit As String = txtNIT.Text
        'datos

        If (e.KeyChar = Chr(13)) Then
            If (propetario.buscarDpi(dpi)) Then
                'Mostrar los datos
                txtNIT.Text = propetario.Nit
                txtNombre.Text = propetario.Nombre
                txtDireccion.Text = propetario.Direccion
                txtTelefono.Text = propetario.Telefono
                txtPlaca.Enabled = True
            Else
                'Limpiar textos y permitir el ingreso

                limpiar()
                MsgBox("Lo sentimos DPI, invalido")
            End If
        End If
    End Sub

    Private Sub txtPlaca_TextChanged(sender As Object, e As EventArgs) Handles txtPlaca.TextChanged

    End Sub

    Private Sub btnAlmacenar_Click(sender As Object, e As EventArgs) Handles btnAlmacenar.Click
        Dim vehiculo As New Vehiculo()
        vehiculo.Placa = txtPlaca.Text
        vehiculo.Nit = txtNIT.Text
        vehiculo.Modelo = txtModelo.Text
        vehiculo.NCilindros = txtNcilindros.Text
        vehiculo.Marca = txtMarca.Text

        If (vehiculo.guardar()) Then
            MsgBox("Registro guardado")
            txtDPI.Text = ""
            limpiar()
        End If

    End Sub
End Class