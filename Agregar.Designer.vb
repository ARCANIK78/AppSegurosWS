<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar
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
        Me.txtCIR = New System.Windows.Forms.TextBox()
        Me.txtNombreR = New System.Windows.Forms.TextBox()
        Me.txtFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.txtMaternoR = New System.Windows.Forms.TextBox()
        Me.txtPaternoR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSegurosR = New System.Windows.Forms.ComboBox()
        Me.txtSexoR = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCIR
        '
        Me.txtCIR.Location = New System.Drawing.Point(136, 34)
        Me.txtCIR.Name = "txtCIR"
        Me.txtCIR.Size = New System.Drawing.Size(268, 20)
        Me.txtCIR.TabIndex = 0
        '
        'txtNombreR
        '
        Me.txtNombreR.Location = New System.Drawing.Point(136, 60)
        Me.txtNombreR.Name = "txtNombreR"
        Me.txtNombreR.Size = New System.Drawing.Size(268, 20)
        Me.txtNombreR.TabIndex = 1
        '
        'txtFechaNac
        '
        Me.txtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaNac.Location = New System.Drawing.Point(136, 145)
        Me.txtFechaNac.MaxDate = New Date(9998, 12, 1, 0, 0, 0, 0)
        Me.txtFechaNac.Name = "txtFechaNac"
        Me.txtFechaNac.Size = New System.Drawing.Size(153, 20)
        Me.txtFechaNac.TabIndex = 6
        '
        'txtMaternoR
        '
        Me.txtMaternoR.Location = New System.Drawing.Point(136, 119)
        Me.txtMaternoR.Name = "txtMaternoR"
        Me.txtMaternoR.Size = New System.Drawing.Size(268, 20)
        Me.txtMaternoR.TabIndex = 7
        '
        'txtPaternoR
        '
        Me.txtPaternoR.Location = New System.Drawing.Point(136, 86)
        Me.txtPaternoR.Name = "txtPaternoR"
        Me.txtPaternoR.Size = New System.Drawing.Size(268, 20)
        Me.txtPaternoR.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Numero de CI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Apellido Paterno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Ingrese Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Apellido Materno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Fecha de Nacimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Sexo"
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.White
        Me.IconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconSize = 25
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(225, 266)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(84, 29)
        Me.IconButton1.TabIndex = 18
        Me.IconButton1.Text = "Cancelar"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconSize = 25
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(315, 266)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(106, 29)
        Me.IconButton2.TabIndex = 19
        Me.IconButton2.Text = "Rgistrar Nuevo"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSegurosR)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 198)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 62)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar el Seguro para la Alta"
        '
        'txtSegurosR
        '
        Me.txtSegurosR.DisplayMember = "nombre"
        Me.txtSegurosR.FormattingEnabled = True
        Me.txtSegurosR.Location = New System.Drawing.Point(10, 19)
        Me.txtSegurosR.Name = "txtSegurosR"
        Me.txtSegurosR.Size = New System.Drawing.Size(386, 21)
        Me.txtSegurosR.TabIndex = 16
        Me.txtSegurosR.ValueMember = "SegurosID"
        '
        'txtSexoR
        '
        Me.txtSexoR.DisplayMember = "sexo"
        Me.txtSexoR.FormattingEnabled = True
        Me.txtSexoR.Items.AddRange(New Object() {"F", "M"})
        Me.txtSexoR.Location = New System.Drawing.Point(136, 171)
        Me.txtSexoR.Name = "txtSexoR"
        Me.txtSexoR.Size = New System.Drawing.Size(114, 21)
        Me.txtSexoR.TabIndex = 14
        '
        'Agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(431, 302)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSexoR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPaternoR)
        Me.Controls.Add(Me.txtMaternoR)
        Me.Controls.Add(Me.txtFechaNac)
        Me.Controls.Add(Me.txtNombreR)
        Me.Controls.Add(Me.txtCIR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Agregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Nuevo Asegurado"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCIR As TextBox
    Friend WithEvents txtNombreR As TextBox
    Friend WithEvents txtFechaNac As DateTimePicker
    Friend WithEvents txtMaternoR As TextBox
    Friend WithEvents txtPaternoR As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSegurosR As ComboBox
    Friend WithEvents txtSexoR As ComboBox
End Class
