<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMnuevoVehiculoV2
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
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDPI = New System.Windows.Forms.TextBox()
        Me.txtNIT = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gbDatosAuto = New System.Windows.Forms.GroupBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtNcilindros = New System.Windows.Forms.TextBox()
        Me.btnAlmacenar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.gbDatos.SuspendLayout()
        Me.gbDatosAuto.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.txtTelefono)
        Me.gbDatos.Controls.Add(Me.Label11)
        Me.gbDatos.Controls.Add(Me.txtDireccion)
        Me.gbDatos.Controls.Add(Me.Label12)
        Me.gbDatos.Controls.Add(Me.Label13)
        Me.gbDatos.Controls.Add(Me.txtNombre)
        Me.gbDatos.Enabled = False
        Me.gbDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbDatos.Location = New System.Drawing.Point(12, 127)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(534, 105)
        Me.gbDatos.TabIndex = 69
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Complete los campos"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(87, 69)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(121, 20)
        Me.txtTelefono.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 18)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "T&elefono:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(308, 33)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(119, 20)
        Me.txtDireccion.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 18)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "N&ombre:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(220, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 18)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "D&ireccion:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(87, 33)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(121, 20)
        Me.txtNombre.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(28, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 18)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "&DPI:"
        '
        'txtDPI
        '
        Me.txtDPI.Location = New System.Drawing.Point(104, 94)
        Me.txtDPI.Name = "txtDPI"
        Me.txtDPI.Size = New System.Drawing.Size(115, 20)
        Me.txtDPI.TabIndex = 66
        '
        'txtNIT
        '
        Me.txtNIT.Enabled = False
        Me.txtNIT.Location = New System.Drawing.Point(318, 95)
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.Size = New System.Drawing.Size(121, 20)
        Me.txtNIT.TabIndex = 68
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(237, 95)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 18)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "&NIT:"
        '
        'gbDatosAuto
        '
        Me.gbDatosAuto.Controls.Add(Me.txtMarca)
        Me.gbDatosAuto.Controls.Add(Me.Label10)
        Me.gbDatosAuto.Controls.Add(Me.btnLimpiar)
        Me.gbDatosAuto.Controls.Add(Me.txtNcilindros)
        Me.gbDatosAuto.Controls.Add(Me.btnAlmacenar)
        Me.gbDatosAuto.Controls.Add(Me.Label6)
        Me.gbDatosAuto.Controls.Add(Me.txtModelo)
        Me.gbDatosAuto.Controls.Add(Me.Label8)
        Me.gbDatosAuto.Enabled = False
        Me.gbDatosAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbDatosAuto.Location = New System.Drawing.Point(9, 287)
        Me.gbDatosAuto.Name = "gbDatosAuto"
        Me.gbDatosAuto.Size = New System.Drawing.Size(537, 166)
        Me.gbDatosAuto.TabIndex = 64
        Me.gbDatosAuto.TabStop = False
        Me.gbDatosAuto.Text = "Complete los campos"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(92, 73)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(119, 20)
        Me.txtMarca.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 18)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Marca:"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Red
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(328, 68)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(89, 30)
        Me.btnLimpiar.TabIndex = 45
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'txtNcilindros
        '
        Me.txtNcilindros.Location = New System.Drawing.Point(392, 33)
        Me.txtNcilindros.Name = "txtNcilindros"
        Me.txtNcilindros.Size = New System.Drawing.Size(121, 20)
        Me.txtNcilindros.TabIndex = 43
        '
        'btnAlmacenar
        '
        Me.btnAlmacenar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAlmacenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlmacenar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlmacenar.ForeColor = System.Drawing.Color.White
        Me.btnAlmacenar.Location = New System.Drawing.Point(231, 70)
        Me.btnAlmacenar.Name = "btnAlmacenar"
        Me.btnAlmacenar.Size = New System.Drawing.Size(89, 30)
        Me.btnAlmacenar.TabIndex = 44
        Me.btnAlmacenar.Text = "Almacenar"
        Me.btnAlmacenar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(230, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 18)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Numero de Ciindros:"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(94, 33)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(119, 20)
        Me.txtModelo.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 18)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Modelo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 18)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Placa:"
        '
        'txtPlaca
        '
        Me.txtPlaca.Enabled = False
        Me.txtPlaca.Location = New System.Drawing.Point(101, 254)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(115, 20)
        Me.txtPlaca.TabIndex = 63
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.IngresosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(137, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(223, 25)
        Me.MenuStrip1.TabIndex = 61
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "&Nombre:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(104, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(116, 21)
        Me.ComboBox1.TabIndex = 71
        '
        'FRMnuevoVehiculoV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(560, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtDPI)
        Me.Controls.Add(Me.txtNIT)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.gbDatosAuto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPlaca)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FRMnuevoVehiculoV2"
        Me.Text = "FRMnuevoVehiculoV2"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.gbDatosAuto.ResumeLayout(False)
        Me.gbDatosAuto.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDPI As TextBox
    Friend WithEvents txtNIT As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents gbDatosAuto As GroupBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtNcilindros As TextBox
    Friend WithEvents btnAlmacenar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPlaca As TextBox
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
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
