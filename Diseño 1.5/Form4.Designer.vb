<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Amarillo = New System.Windows.Forms.PictureBox()
        Me.Azul = New System.Windows.Forms.PictureBox()
        Me.Rojo = New System.Windows.Forms.PictureBox()
        Me.Verde = New System.Windows.Forms.PictureBox()
        Me.Nombre1 = New System.Windows.Forms.TextBox()
        Me.Nombre2 = New System.Windows.Forms.TextBox()
        Me.Nombre3 = New System.Windows.Forms.TextBox()
        Me.Nombre4 = New System.Windows.Forms.TextBox()
        Me.Iniciar = New System.Windows.Forms.Button()
        Me.Jugador2 = New System.Windows.Forms.Label()
        Me.Jugador3 = New System.Windows.Forms.Label()
        Me.Jugador1 = New System.Windows.Forms.Label()
        Me.Jugador4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Amarillo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Azul, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rojo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Verde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(137, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ESCRIBA EL NOMBRE DE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LOS JUGADORES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Amarillo
        '
        Me.Amarillo.BackColor = System.Drawing.Color.Transparent
        Me.Amarillo.BackgroundImage = Global.Diseño_1._5.My.Resources.Resources.FICHAAMARILLO
        Me.Amarillo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Amarillo.Location = New System.Drawing.Point(91, 364)
        Me.Amarillo.Name = "Amarillo"
        Me.Amarillo.Size = New System.Drawing.Size(88, 105)
        Me.Amarillo.TabIndex = 1
        Me.Amarillo.TabStop = False
        '
        'Azul
        '
        Me.Azul.BackColor = System.Drawing.Color.Transparent
        Me.Azul.BackgroundImage = Global.Diseño_1._5.My.Resources.Resources.FICHAAZUL
        Me.Azul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Azul.Location = New System.Drawing.Point(313, 364)
        Me.Azul.Name = "Azul"
        Me.Azul.Size = New System.Drawing.Size(88, 105)
        Me.Azul.TabIndex = 2
        Me.Azul.TabStop = False
        '
        'Rojo
        '
        Me.Rojo.BackColor = System.Drawing.Color.Transparent
        Me.Rojo.BackgroundImage = Global.Diseño_1._5.My.Resources.Resources.FICHAROJO
        Me.Rojo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Rojo.Location = New System.Drawing.Point(92, 144)
        Me.Rojo.Name = "Rojo"
        Me.Rojo.Size = New System.Drawing.Size(88, 105)
        Me.Rojo.TabIndex = 3
        Me.Rojo.TabStop = False
        '
        'Verde
        '
        Me.Verde.BackColor = System.Drawing.Color.Transparent
        Me.Verde.BackgroundImage = Global.Diseño_1._5.My.Resources.Resources.FICHAVERDE
        Me.Verde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Verde.Location = New System.Drawing.Point(313, 150)
        Me.Verde.Name = "Verde"
        Me.Verde.Size = New System.Drawing.Size(88, 105)
        Me.Verde.TabIndex = 4
        Me.Verde.TabStop = False
        '
        'Nombre1
        '
        Me.Nombre1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Nombre1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre1.Location = New System.Drawing.Point(66, 297)
        Me.Nombre1.Name = "Nombre1"
        Me.Nombre1.Size = New System.Drawing.Size(150, 21)
        Me.Nombre1.TabIndex = 5
        Me.Nombre1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nombre2
        '
        Me.Nombre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre2.Location = New System.Drawing.Point(282, 298)
        Me.Nombre2.Name = "Nombre2"
        Me.Nombre2.Size = New System.Drawing.Size(150, 21)
        Me.Nombre2.TabIndex = 6
        Me.Nombre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nombre3
        '
        Me.Nombre3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nombre3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre3.Location = New System.Drawing.Point(60, 497)
        Me.Nombre3.Name = "Nombre3"
        Me.Nombre3.Size = New System.Drawing.Size(150, 21)
        Me.Nombre3.TabIndex = 7
        Me.Nombre3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nombre4
        '
        Me.Nombre4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nombre4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre4.Location = New System.Drawing.Point(282, 497)
        Me.Nombre4.Name = "Nombre4"
        Me.Nombre4.Size = New System.Drawing.Size(150, 21)
        Me.Nombre4.TabIndex = 8
        Me.Nombre4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Iniciar
        '
        Me.Iniciar.BackColor = System.Drawing.Color.Transparent
        Me.Iniciar.BackgroundImage = Global.Diseño_1._5.My.Resources.Resources.BOTONVERDE
        Me.Iniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Iniciar.FlatAppearance.BorderSize = 0
        Me.Iniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Iniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Iniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iniciar.ForeColor = System.Drawing.Color.White
        Me.Iniciar.Location = New System.Drawing.Point(70, 577)
        Me.Iniciar.Name = "Iniciar"
        Me.Iniciar.Size = New System.Drawing.Size(130, 51)
        Me.Iniciar.TabIndex = 9
        Me.Iniciar.Text = "&¡ Jugar !"
        Me.Iniciar.UseVisualStyleBackColor = False
        '
        'Jugador2
        '
        Me.Jugador2.AutoSize = True
        Me.Jugador2.BackColor = System.Drawing.Color.Transparent
        Me.Jugador2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jugador2.ForeColor = System.Drawing.Color.White
        Me.Jugador2.Location = New System.Drawing.Point(325, 263)
        Me.Jugador2.Name = "Jugador2"
        Me.Jugador2.Size = New System.Drawing.Size(59, 12)
        Me.Jugador2.TabIndex = 10
        Me.Jugador2.Text = "JUGADOR 2"
        '
        'Jugador3
        '
        Me.Jugador3.AutoSize = True
        Me.Jugador3.BackColor = System.Drawing.Color.Transparent
        Me.Jugador3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jugador3.ForeColor = System.Drawing.Color.White
        Me.Jugador3.Location = New System.Drawing.Point(103, 472)
        Me.Jugador3.Name = "Jugador3"
        Me.Jugador3.Size = New System.Drawing.Size(59, 12)
        Me.Jugador3.TabIndex = 11
        Me.Jugador3.Text = "JUGADOR 3"
        '
        'Jugador1
        '
        Me.Jugador1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Jugador1.AutoSize = True
        Me.Jugador1.BackColor = System.Drawing.Color.Transparent
        Me.Jugador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jugador1.ForeColor = System.Drawing.Color.White
        Me.Jugador1.Location = New System.Drawing.Point(104, 257)
        Me.Jugador1.Name = "Jugador1"
        Me.Jugador1.Size = New System.Drawing.Size(59, 12)
        Me.Jugador1.TabIndex = 16
        Me.Jugador1.Text = "JUGADOR 1"
        '
        'Jugador4
        '
        Me.Jugador4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Jugador4.AutoSize = True
        Me.Jugador4.BackColor = System.Drawing.Color.Transparent
        Me.Jugador4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jugador4.ForeColor = System.Drawing.Color.White
        Me.Jugador4.Location = New System.Drawing.Point(325, 477)
        Me.Jugador4.Name = "Jugador4"
        Me.Jugador4.Size = New System.Drawing.Size(59, 12)
        Me.Jugador4.TabIndex = 17
        Me.Jugador4.Text = "JUGADOR 4"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Diseño_1._5.My.Resources.Resources.AMARILLO
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(296, 577)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 51)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Diseño_1._5.My.Resources.Resources.FONDO
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(504, 681)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Jugador4)
        Me.Controls.Add(Me.Jugador1)
        Me.Controls.Add(Me.Jugador3)
        Me.Controls.Add(Me.Jugador2)
        Me.Controls.Add(Me.Iniciar)
        Me.Controls.Add(Me.Nombre4)
        Me.Controls.Add(Me.Nombre3)
        Me.Controls.Add(Me.Nombre2)
        Me.Controls.Add(Me.Nombre1)
        Me.Controls.Add(Me.Verde)
        Me.Controls.Add(Me.Rojo)
        Me.Controls.Add(Me.Azul)
        Me.Controls.Add(Me.Amarillo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.Amarillo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Azul, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rojo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Verde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Amarillo As System.Windows.Forms.PictureBox
    Friend WithEvents Azul As System.Windows.Forms.PictureBox
    Friend WithEvents Rojo As System.Windows.Forms.PictureBox
    Friend WithEvents Verde As System.Windows.Forms.PictureBox
    Friend WithEvents Nombre1 As System.Windows.Forms.TextBox
    Friend WithEvents Nombre2 As System.Windows.Forms.TextBox
    Friend WithEvents Nombre3 As System.Windows.Forms.TextBox
    Friend WithEvents Nombre4 As System.Windows.Forms.TextBox
    Friend WithEvents Iniciar As System.Windows.Forms.Button
    Friend WithEvents Jugador2 As System.Windows.Forms.Label
    Friend WithEvents Jugador3 As System.Windows.Forms.Label
    Friend WithEvents Jugador1 As System.Windows.Forms.Label
    Friend WithEvents Jugador4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
