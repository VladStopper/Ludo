Public Class Form4

    Private Sub Iniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Iniciar.Click

        Form2.Show()

        Form2.Jugador1.Text = Nombre1.Text
        Form2.Jugador2.Text = Nombre2.Text
        Form2.Jugador3.Text = Nombre3.Text
        Form2.Jugador4.Text = Nombre4.Text

        If Nombre1.Text = "" Then

            Form2.Jugador1.Text = "JUGADOR 1"

        End If


        If Nombre2.Text = "" Then

            Form2.Jugador2.Text = "JUGADOR 2"

        End If

        If Nombre3.Text = "" Then

            Form2.Jugador3.Text = "JUGADOR 3"

        End If

        If Nombre4.Text = "" Then

            Form2.Jugador4.Text = "JUGADOR 4"

        End If






        Form2.ficha_inicio(Form2.Rojo1)
        Form2.ficha_inicio(Form2.Rojo2)
        Form2.ficha_inicio(Form2.Rojo3)
        Form2.ficha_inicio(Form2.Rojo4)

        Form2.ficha_inicio(Form2.Verde1)
        Form2.ficha_inicio(Form2.Verde2)
        Form2.ficha_inicio(Form2.Verde3)
        Form2.ficha_inicio(Form2.Verde4)


        Form2.ficha_inicio(Form2.Amarillo1)
        Form2.ficha_inicio(Form2.Amarillo2)
        Form2.ficha_inicio(Form2.Amarillo3)
        Form2.ficha_inicio(Form2.Amarillo4)


        Form2.ficha_inicio(Form2.Azul1)
        Form2.ficha_inicio(Form2.Azul2)
        Form2.ficha_inicio(Form2.Azul3)
        Form2.ficha_inicio(Form2.Azul4)

        Form2.Dado.Image = My.Resources.Dado__GIF_

    End Sub

    Private Sub Iniciar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Iniciar.MouseDown

        Iniciar.BackgroundImage = My.Resources.BOTONVERDECLICK

    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub Nombre1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nombre1.TextChanged

    End Sub
End Class