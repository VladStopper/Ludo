Public Class Cantidad_Jugadores
    Dim RyA As Boolean
    Dim VyA As Boolean
    Dim RyAyVyA As Boolean
    Dim CJ As Integer = 0
    Dim a As Integer = 0

    Private Sub ROJOyAMARILLO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ROJOyAMARILLO.Click
        Form4.Show()
        CJa()
        a = 1
        RojosAmarillos()
        Form4.Azul.Hide()
        Form4.Verde.Hide()
        Form4.Jugador2.Hide()
        Form4.Jugador4.Hide()
        Form2.Verde1.Hide()
        Form2.Verde2.Hide()
        Form2.Verde3.Hide()
        Form2.Verde4.Hide()
        Form2.Azul1.Hide()
        Form2.Azul2.Hide()
        Form2.Azul3.Hide()
        Form2.Azul4.Hide()
        Form4.Nombre2.Hide()
        Form4.Nombre4.Hide()
        Form4.Amarillo.Location = New Point(Form4.Verde.Location)
        Form4.Jugador3.Location = New Point(Form4.Jugador2.Location)
        Form4.Nombre3.Location = New Point(Form4.Nombre2.Location)
        Form4.Jugador3.Text = "JUGADOR 2"
    End Sub

    Private Sub VERDEyAZUL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VERDEyAZUL.Click
        Form4.Show()
        CJa()
        a = 2
        VerdesAzules()
        Form4.Amarillo.Hide()
        Form4.Rojo.Hide()
        Form4.Jugador1.Hide()
        Form4.Jugador3.Hide()
        VerdesAzules()
        Form2.Rojo1.Hide()
        Form2.Rojo2.Hide()
        Form2.Rojo3.Hide()
        Form2.Rojo4.Hide()
        Form2.Amarillo1.Hide()
        Form2.Amarillo2.Hide()
        Form2.Amarillo3.Hide()
        Form2.Amarillo4.Hide()
        Form4.Nombre1.Hide()
        Form4.Nombre3.Hide()
        Form4.Azul.Location = New Point(Form4.Verde.Location)
        Form4.Verde.Location = New Point(Form4.Rojo.Location)
        Form4.Jugador4.Location = New Point(Form4.Jugador2.Location)
        Form4.Jugador2.Location = New Point(Form4.Jugador1.Location)
        Form4.Nombre4.Location = New Point(Form4.Nombre2.Location)
        Form4.Nombre2.Location = New Point(Form4.Nombre1.Location)
        Form4.Jugador4.Text = "JUGADOR 2"
        Form4.Jugador2.Text = "JUGADOR 1"

    End Sub

    Private Sub TODOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TODOS.Click
        Form4.Show()
        CJa()
        Cuatro()
    End Sub

    Public Function RojosAmarillos()

        RyA = True

        Return RyA
    End Function

    Public Function CJa()
        If a = 1 Then

            CJ = 1

        ElseIf a = 2 Then

            CJ = 2

        ElseIf a = 0 Then

            CJ = 0

        End If


        Return CJ
    End Function

    Public Function VerdesAzules()
        VyA = True
        Return VyA
    End Function



    Public Function Cuatro()
        RyAyVyA = True
        Return RyAyVyA
    End Function

    
    Private Sub Cantidad_Jugadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class