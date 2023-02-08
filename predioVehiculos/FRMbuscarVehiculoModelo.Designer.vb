<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMbuscarVehiculoModelo
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
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdDatos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.txtInicio = New System.Windows.Forms.TextBox()
        Me.Inicio = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(380, 121)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(89, 30)
        Me.btnActualizar.TabIndex = 37
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Red
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(308, 121)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(66, 30)
        Me.btnBuscar.TabIndex = 36
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(355, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 33)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Vehiculos Modelo"
        '
        'grdDatos
        '
        Me.grdDatos.AccessibleName = "grdDatos"
        Me.grdDatos.BackgroundColor = System.Drawing.Color.White
        Me.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column3, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.grdDatos.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.grdDatos.Location = New System.Drawing.Point(12, 170)
        Me.grdDatos.Name = "grdDatos"
        Me.grdDatos.Size = New System.Drawing.Size(852, 209)
        Me.grdDatos.TabIndex = 33
        '
        'Column1
        '
        Me.Column1.HeaderText = "DPI"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 90
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Direccion"
        Me.Column4.Name = "Column4"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Telefono"
        Me.Column3.Name = "Column3"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Placa"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Modelo"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Cilindros"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Marca"
        Me.Column8.Name = "Column8"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.IngresosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(347, 20)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(343, 25)
        Me.MenuStrip1.TabIndex = 32
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
        'txtFinal
        '
        Me.txtFinal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinal.Location = New System.Drawing.Point(153, 125)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(133, 22)
        Me.txtFinal.TabIndex = 38
        '
        'txtInicio
        '
        Me.txtInicio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicio.Location = New System.Drawing.Point(14, 125)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.Size = New System.Drawing.Size(133, 22)
        Me.txtInicio.TabIndex = 35
        '
        'Inicio
        '
        Me.Inicio.AutoSize = True
        Me.Inicio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inicio.Location = New System.Drawing.Point(12, 104)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(44, 18)
        Me.Inicio.TabIndex = 39
        Me.Inicio.Text = "Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Final:"
        '
        'FRMbuscarVehiculoModelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(876, 398)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Inicio)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtInicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdDatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FRMbuscarVehiculoModelo"
        Me.Text = "FRMbuscarVehiculoModelo"
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents grdDatos As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
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
    Friend WithEvents txtFinal As TextBox
    Friend WithEvents txtInicio As TextBox
    Friend WithEvents Inicio As Label
    Friend WithEvents Label2 As Label
End Class
