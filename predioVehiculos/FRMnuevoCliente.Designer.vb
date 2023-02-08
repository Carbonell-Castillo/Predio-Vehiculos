<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMnuevoCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnAlmacenar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDPI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNIT = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarVehiculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPorMarcaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPorModeloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPorPropetarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoDeVehiculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstVistaPrevia = New System.Windows.Forms.ListView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbVistaPrevia = New System.Windows.Forms.GroupBox()
        Me.gbDatos.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.gbVistaPrevia.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.btnLimpiar)
        Me.gbDatos.Controls.Add(Me.txtTelefono)
        Me.gbDatos.Controls.Add(Me.btnAlmacenar)
        Me.gbDatos.Controls.Add(Me.Label5)
        Me.gbDatos.Controls.Add(Me.txtDireccion)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.txtNombre)
        Me.gbDatos.Enabled = False
        Me.gbDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbDatos.Location = New System.Drawing.Point(27, 106)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(444, 105)
        Me.gbDatos.TabIndex = 48
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Complete los campos"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Red
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(318, 63)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(89, 30)
        Me.btnLimpiar.TabIndex = 45
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(87, 69)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(121, 20)
        Me.txtTelefono.TabIndex = 25
        '
        'btnAlmacenar
        '
        Me.btnAlmacenar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAlmacenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlmacenar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlmacenar.ForeColor = System.Drawing.Color.White
        Me.btnAlmacenar.Location = New System.Drawing.Point(223, 63)
        Me.btnAlmacenar.Name = "btnAlmacenar"
        Me.btnAlmacenar.Size = New System.Drawing.Size(89, 30)
        Me.btnAlmacenar.TabIndex = 44
        Me.btnAlmacenar.Text = "Almacenar"
        Me.btnAlmacenar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "T&elefono:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(307, 33)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(119, 20)
        Me.txtDireccion.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 18)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "N&ombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(220, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "D&ireccion:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(87, 33)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(121, 20)
        Me.txtNombre.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&DPI:"
        '
        'txtDPI
        '
        Me.txtDPI.Location = New System.Drawing.Point(101, 73)
        Me.txtDPI.Name = "txtDPI"
        Me.txtDPI.Size = New System.Drawing.Size(115, 20)
        Me.txtDPI.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(251, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "&NIT:"
        '
        'txtNIT
        '
        Me.txtNIT.Location = New System.Drawing.Point(332, 72)
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.Size = New System.Drawing.Size(121, 20)
        Me.txtNIT.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.IngresosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(141, 12)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(223, 25)
        Me.MenuStrip1.TabIndex = 47
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(53, 21)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerClientesToolStripMenuItem, Me.VerToolStripMenuItem, Me.BuscarVehiculosToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(86, 21)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'VerClientesToolStripMenuItem
        '
        Me.VerClientesToolStripMenuItem.Name = "VerClientesToolStripMenuItem"
        Me.VerClientesToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.VerClientesToolStripMenuItem.Text = "Ver Clientes"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.VerToolStripMenuItem.Text = "Ver Vehiculos"
        '
        'BuscarVehiculosToolStripMenuItem
        '
        Me.BuscarVehiculosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarPorMarcaToolStripMenuItem, Me.BuscarPorModeloToolStripMenuItem, Me.BuscarPorPropetarioToolStripMenuItem})
        Me.BuscarVehiculosToolStripMenuItem.Name = "BuscarVehiculosToolStripMenuItem"
        Me.BuscarVehiculosToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.BuscarVehiculosToolStripMenuItem.Text = "Buscar Vehiculos"
        '
        'BuscarPorMarcaToolStripMenuItem
        '
        Me.BuscarPorMarcaToolStripMenuItem.Name = "BuscarPorMarcaToolStripMenuItem"
        Me.BuscarPorMarcaToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.BuscarPorMarcaToolStripMenuItem.Text = "Buscar por Marca"
        '
        'BuscarPorModeloToolStripMenuItem
        '
        Me.BuscarPorModeloToolStripMenuItem.Name = "BuscarPorModeloToolStripMenuItem"
        Me.BuscarPorModeloToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.BuscarPorModeloToolStripMenuItem.Text = "Buscar por Modelo"
        '
        'BuscarPorPropetarioToolStripMenuItem
        '
        Me.BuscarPorPropetarioToolStripMenuItem.Name = "BuscarPorPropetarioToolStripMenuItem"
        Me.BuscarPorPropetarioToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.BuscarPorPropetarioToolStripMenuItem.Text = "Buscar por propetario"
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoDeVehiculosToolStripMenuItem, Me.IngresoDeClientesToolStripMenuItem})
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(76, 21)
        Me.IngresosToolStripMenuItem.Text = "Ingresos"
        '
        'IngresoDeVehiculosToolStripMenuItem
        '
        Me.IngresoDeVehiculosToolStripMenuItem.Name = "IngresoDeVehiculosToolStripMenuItem"
        Me.IngresoDeVehiculosToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.IngresoDeVehiculosToolStripMenuItem.Text = "Ingreso de vehiculos"
        '
        'IngresoDeClientesToolStripMenuItem
        '
        Me.IngresoDeClientesToolStripMenuItem.Name = "IngresoDeClientesToolStripMenuItem"
        Me.IngresoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.IngresoDeClientesToolStripMenuItem.Text = "Ingreso de clientes"
        '
        'lstVistaPrevia
        '
        Me.lstVistaPrevia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstVistaPrevia.CheckBoxes = True
        Me.lstVistaPrevia.HideSelection = False
        Me.lstVistaPrevia.Location = New System.Drawing.Point(6, 22)
        Me.lstVistaPrevia.Name = "lstVistaPrevia"
        Me.lstVistaPrevia.Size = New System.Drawing.Size(374, 97)
        Me.lstVistaPrevia.TabIndex = 49
        Me.lstVistaPrevia.UseCompatibleStateImageBehavior = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Red
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(114, 128)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 30)
        Me.btnCancelar.TabIndex = 46
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'gbVistaPrevia
        '
        Me.gbVistaPrevia.Controls.Add(Me.lstVistaPrevia)
        Me.gbVistaPrevia.Controls.Add(Me.btnCancelar)
        Me.gbVistaPrevia.Location = New System.Drawing.Point(27, 238)
        Me.gbVistaPrevia.Name = "gbVistaPrevia"
        Me.gbVistaPrevia.Size = New System.Drawing.Size(444, 187)
        Me.gbVistaPrevia.TabIndex = 50
        Me.gbVistaPrevia.TabStop = False
        Me.gbVistaPrevia.Text = "Verificar Datos"
        '
        'FRMnuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(517, 450)
        Me.Controls.Add(Me.gbVistaPrevia)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtDPI)
        Me.Controls.Add(Me.txtNIT)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FRMnuevoCliente"
        Me.Text = "FRMnuevoCliente"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbVistaPrevia.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDPI As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNIT As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarVehiculosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarPorMarcaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarPorModeloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarPorPropetarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoDeVehiculosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstVistaPrevia As ListView
    Friend WithEvents btnAlmacenar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents gbVistaPrevia As GroupBox
End Class
