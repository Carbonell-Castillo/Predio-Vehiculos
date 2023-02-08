Public Class FRMnuevoCliente


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
                gbDatos.Enabled = False
            Else
                'Limpiar textos y permitir el ingreso
                limpiar()
                gbDatos.Enabled = True
            End If
        End If

    End Sub
    Private Sub txtNIT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIT.KeyPress
        Dim propetario As New Propetario
        Dim dpi As String = txtDPI.Text
        Dim nit As String = txtNIT.Text
        'datos

        If (e.KeyChar = Chr(13)) Then



            If (dpi = "" Or nit = "") Then
                MsgBox("Datos vacios o invalidos")
            Else

                If (propetario.buscarNit(nit) Or propetario.buscarDpi(dpi)) Then
                    MsgBox("Datos ya existentes")
                    limpiar()
                    gbDatos.Enabled = False
                Else

                    gbDatos.Enabled = True

                End If

            End If
        End If
    End Sub




    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Public Sub limpiar()

        gbDatos.Enabled = False
        txtDireccion.Text = ""
        txtNIT.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""

    End Sub

    Private Sub FRMnuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbVistaPrevia.Hide()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub txtDPI_TextChanged(sender As Object, e As EventArgs) Handles txtDPI.TextChanged

    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub btnAlmacenar_Click(sender As Object, e As EventArgs) Handles btnAlmacenar.Click
        Dim propetario As New Propetario()
        propetario.Dpi = CInt(txtDPI.Text)
        propetario.Nit = txtNIT.Text
        propetario.Nombre = txtNombre.Text
        propetario.Direccion = txtDireccion.Text
        propetario.Telefono = txtTelefono.Text

        If (propetario.guardar()) Then
            MsgBox("Registro guardado")
            txtDPI.Text = ""
            limpiar()
        End If

    End Sub

    Private Sub gbVistaPrevia_Enter(sender As Object, e As EventArgs) Handles gbVistaPrevia.Enter

    End Sub

    Private Sub gbDatos_Enter(sender As Object, e As EventArgs) Handles gbDatos.Enter

    End Sub
End Class