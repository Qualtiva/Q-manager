<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.LContraseña = New System.Windows.Forms.Label()
        Me.TBUsuario = New System.Windows.Forms.TextBox()
        Me.TBContraseña = New System.Windows.Forms.TextBox()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsuario.Location = New System.Drawing.Point(12, 26)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(68, 20)
        Me.LUsuario.TabIndex = 0
        Me.LUsuario.Text = "Usuario:"
        '
        'LContraseña
        '
        Me.LContraseña.AutoSize = True
        Me.LContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LContraseña.Location = New System.Drawing.Point(15, 58)
        Me.LContraseña.Name = "LContraseña"
        Me.LContraseña.Size = New System.Drawing.Size(96, 20)
        Me.LContraseña.TabIndex = 1
        Me.LContraseña.Text = "Contraseña:"
        '
        'TBUsuario
        '
        Me.TBUsuario.Location = New System.Drawing.Point(128, 25)
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TBUsuario.TabIndex = 2
        '
        'TBContraseña
        '
        Me.TBContraseña.Location = New System.Drawing.Point(128, 57)
        Me.TBContraseña.Name = "TBContraseña"
        Me.TBContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBContraseña.Size = New System.Drawing.Size(100, 20)
        Me.TBContraseña.TabIndex = 3
        '
        'BAceptar
        '
        Me.BAceptar.Location = New System.Drawing.Point(45, 96)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BAceptar.TabIndex = 4
        Me.BAceptar.Text = "Aceptar"
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(140, 96)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(75, 23)
        Me.BSalir.TabIndex = 5
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 143)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.TBContraseña)
        Me.Controls.Add(Me.TBUsuario)
        Me.Controls.Add(Me.LContraseña)
        Me.Controls.Add(Me.LUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(267, 181)
        Me.MinimumSize = New System.Drawing.Size(267, 181)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LUsuario As System.Windows.Forms.Label
    Friend WithEvents LContraseña As System.Windows.Forms.Label
    Friend WithEvents TBUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TBContraseña As System.Windows.Forms.TextBox
    Friend WithEvents BAceptar As System.Windows.Forms.Button
    Friend WithEvents BSalir As System.Windows.Forms.Button

End Class
