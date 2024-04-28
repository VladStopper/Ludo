Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    
    Private Sub Inicio_Click(sender As System.Object, e As System.EventArgs) Handles Inicio.Click

        'Form2.ShowDialog()
        'Form4.ShowDialog()
        Cantidad_Jugadores.ShowDialog()

    End Sub


    Private Sub Salir_Click(sender As System.Object, e As System.EventArgs) Handles Salir.Click

        Me.Close()

    End Sub

    Private Sub Inicio_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Inicio.MouseDown

        Inicio.BackgroundImage = My.Resources.BOTONVERDECLICK

    End Sub

    Private Sub Inicio_MouseLeave(sender As Object, e As System.EventArgs) Handles Inicio.MouseLeave

        Inicio.BackgroundImage = My.Resources.BOTONVERDE

    End Sub


    Private Sub Salir_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Salir.MouseDown

        Salir.BackgroundImage = My.Resources.BOTONROJOCLIK

    End Sub

    Private Sub Salir_MouseLeave(sender As Object, e As System.EventArgs) Handles Salir.MouseLeave


        Salir.BackgroundImage = My.Resources.ROJO

    End Sub

    Private Sub Info_Click(sender As System.Object, e As System.EventArgs) Handles Info.Click

        Regla4.ShowDialog()

    End Sub

    Private Sub Info_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Info.MouseDown

        Info.BackgroundImage = My.Resources.BOTONAMARILLOCLICK

    End Sub

    Private Sub Info_MouseLeave(sender As Object, e As System.EventArgs) Handles Info.MouseLeave

        Info.BackgroundImage = My.Resources.AMARILLO


    End Sub
End Class