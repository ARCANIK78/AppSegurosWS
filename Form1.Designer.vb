<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.GruoBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEstado = New System.Windows.Forms.Label()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DatosAfiliaciones = New System.Windows.Forms.DataGridView()
        Me.ColFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSeguro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnOpcion = New System.Windows.Forms.Button()
        Me.GruoBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DatosAfiliaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ingresar CI Asegurado:"
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(145, 13)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(278, 20)
        Me.txtCI.TabIndex = 1
        '
        'GruoBox
        '
        Me.GruoBox.Controls.Add(Me.GroupBox2)
        Me.GruoBox.Controls.Add(Me.txtSexo)
        Me.GruoBox.Controls.Add(Me.Label5)
        Me.GruoBox.Controls.Add(Me.txtFechaNac)
        Me.GruoBox.Controls.Add(Me.txtNombre)
        Me.GruoBox.Controls.Add(Me.Label3)
        Me.GruoBox.Controls.Add(Me.Label2)
        Me.GruoBox.Location = New System.Drawing.Point(26, 39)
        Me.GruoBox.Name = "GruoBox"
        Me.GruoBox.Size = New System.Drawing.Size(523, 185)
        Me.GruoBox.TabIndex = 2
        Me.GruoBox.TabStop = False
        Me.GruoBox.Text = "Datos del Asegurado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtEstado)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 74)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado"
        '
        'txtEstado
        '
        Me.txtEstado.AutoSize = True
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(66, 26)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(87, 16)
        Me.txtEstado.TabIndex = 9
        Me.txtEstado.Text = "Esperando."
        '
        'txtSexo
        '
        Me.txtSexo.Enabled = False
        Me.txtSexo.Location = New System.Drawing.Point(135, 79)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.ReadOnly = True
        Me.txtSexo.Size = New System.Drawing.Size(130, 20)
        Me.txtSexo.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fecha de Nacimiento:"
        '
        'txtFechaNac
        '
        Me.txtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaNac.Location = New System.Drawing.Point(135, 52)
        Me.txtFechaNac.MaxDate = New Date(9998, 12, 1, 0, 0, 0, 0)
        Me.txtFechaNac.Name = "txtFechaNac"
        Me.txtFechaNac.Size = New System.Drawing.Size(130, 20)
        Me.txtFechaNac.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(135, 26)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(378, 20)
        Me.txtNombre.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sexo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Completo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DatosAfiliaciones)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 230)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 288)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Historial de altas y bajs"
        '
        'DatosAfiliaciones
        '
        Me.DatosAfiliaciones.AllowUserToAddRows = False
        Me.DatosAfiliaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosAfiliaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColFecha, Me.ColAccion, Me.ColSeguro})
        Me.DatosAfiliaciones.Location = New System.Drawing.Point(17, 19)
        Me.DatosAfiliaciones.Name = "DatosAfiliaciones"
        Me.DatosAfiliaciones.RowHeadersVisible = False
        Me.DatosAfiliaciones.Size = New System.Drawing.Size(496, 263)
        Me.DatosAfiliaciones.TabIndex = 0
        '
        'ColFecha
        '
        Me.ColFecha.DataPropertyName = "fecha"
        Me.ColFecha.HeaderText = "FECHA DE ALTA/BAJAS"
        Me.ColFecha.Name = "ColFecha"
        '
        'ColAccion
        '
        Me.ColAccion.DataPropertyName = "EstadoT"
        Me.ColAccion.HeaderText = "ALTAS/BAJAS"
        Me.ColAccion.Name = "ColAccion"
        '
        'ColSeguro
        '
        Me.ColSeguro.DataPropertyName = "Seguros"
        Me.ColSeguro.HeaderText = "SEGUROS DE SALUD"
        Me.ColSeguro.Name = "ColSeguro"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(429, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnOpcion
        '
        Me.btnOpcion.Location = New System.Drawing.Point(207, 525)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(142, 23)
        Me.btnOpcion.TabIndex = 5
        Me.btnOpcion.Text = "Button2"
        Me.btnOpcion.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(572, 555)
        Me.Controls.Add(Me.btnOpcion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GruoBox)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Asegurado"
        Me.GruoBox.ResumeLayout(False)
        Me.GruoBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DatosAfiliaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCI As TextBox
    Friend WithEvents GruoBox As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSexo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFechaNac As DateTimePicker
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DatosAfiliaciones As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtEstado As Label
    Friend WithEvents ColFecha As DataGridViewTextBoxColumn
    Friend WithEvents ColAccion As DataGridViewTextBoxColumn
    Friend WithEvents ColSeguro As DataGridViewTextBoxColumn
    Friend WithEvents btnOpcion As Button
End Class
