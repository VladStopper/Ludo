<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Inicio = New System.Windows.Forms.Button()
        Me.Info = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo
        '
        Me.Logo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.BackgroundImage = Global.Diseño_1._5.My.Resources.Resources.LOGOHD
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Logo.Location = New System.Drawing.Point(97, 77)
        Me.Logo.Margin = New System.Windows.Forms.Padding(2)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(314, 251)
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'Inicio
        '
        Me.Inicio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Inicio.BackColor = System.Drawing.Color.Transparent
        Me.Inicio.BackgroundImage = Global.Diseño_1._5.My.Resources.Resources.BOTONVERDE
        Me.Inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Inicio.FlatAppearance.BorderSize = 0
        Me.Inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Inicio.Font = New System.Drawing.Font("Cooper Black", 29.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inicio.ForeColor = System.Drawing.Color.White
        Me.Inicio.Location = New System.Drawing.Point(55, 375)
        Me.Inicio.Margin = New System.Windows.Forms.Padding(2)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(175, 87)
        Me.Inicio.TabIndex = 1
        Me.Inicio.Text = "▶"
        Me.Inicio.UseVisualStyleBackColor = False
        '
        'Info
        '
        Me.Info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Info.BackColor = System.Drawing.Color.Transparent
        Me.Info.BackgroundImage = Global.Diseño_1._5.My.Resources.Resources.AMARILLO
        Me.Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Info.FlatAppearance.BorderSize = 0
        Me.Info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Info.Font = New System.Drawing.Font("Cooper Black", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info.ForeColor = System.Drawing.Color.White
        Me.Info.Location = New System.Drawing.Point(285, 375)
        Me.Info.Margin = New System.Windows.Forms.Padding(2)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(167, 87)
        Me.Info.TabIndex = 2
        Me.Info.Text = "?"
        Me.Info.UseVisualStyleBackColor = False
        '
        'Salir
        '
        Me.Salir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Salir.BackColor = System.Drawing.Color.Transparent
        Me.Salir.BackgroundImage = Global.Diseño_1._5.My.Resources.Resources.ROJO
        Me.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Salir.FlatAppearance.BorderSize = 0
        Me.Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Salir.Font = New System.Drawing.Font("Cooper Black", 49.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.ForeColor = System.Drawing.Color.White
        Me.Salir.Location = New System.Drawing.Point(168, 518)
        Me.Salir.Margin = New System.Windows.Forms.Padding(2)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(175, 87)
        Me.Salir.TabIndex = 3
        Me.Salir.Text = "×"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Diseño_1._5.My.Resources.Resources.INICIO
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(504, 681)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Info)
        Me.Controls.Add(Me.Inicio)
        Me.Controls.Add(Me.Logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents Inicio As System.Windows.Forms.Button
    Friend WithEvents Info As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button

End Class
