Public Class Form2
    Dim ResourceFilePathPrefix As String

    Private Sub Parar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tirar.Click
        CJ = Cantidad_Jugadores.CJa()
        'DADO
        If CJ = 1 Then

            VT = True
            AT = True
        ElseIf CJ = 2 Then
            RT = True
            AmT = True
        End If
        CambiarDado()
        a = 0
        Dim aleatorio As New Random
        If EleIni = 0 Then
            i = aleatorio.Next(1, 5)
            EleIni = 1
        End If
        'TURNOS

        If i = 4 Then
            If RT = False Then
                i = 1
            ElseIf RT = True And VT = False Then
                i = 2
                'ElseIf VT = True Then
                'i = 3
                'ElseIf AmT = True Then
                'i = 4

            End If

        ElseIf i < 5 Then
            i = i + 1

            If i = 2 And VT = True Then
                i = 3
            End If
            If i = 3 And AmT = True Then
                i = 4
            End If
            If i = 4 And AT = True And RT = False Then
                i = 1
            ElseIf i = 4 And AT = True And RT = True And VT = False Then
                i = 2
            ElseIf i = 4 And AT = True And RT = True And VT = True Then
                i = 3
            End If

        End If

        If i = 1 Then
            z = 0
            l = 0
            habilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)

            deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
            deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
            deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            Rojo1.BringToFront()
            Rojo2.BringToFront()
            Rojo3.BringToFront()
            Rojo4.BringToFront()
            NombreJugador.Text = Jugador1.Text
            Dado.BackColor = Color.Red
            'NroJugador.Text = i

            If Rojo1.Top = 358 And Rojo1.Left = 219 Then
                deshabilitarFichas(Rojo1, Rojo1, Rojo1, Rojo1)
                GR1 = 1

            ElseIf Rojo1.Top = 424 And Rojo1.Left = 76 And n = 6 Then
                l = l + 1

            ElseIf Rojo1.Top <> 424 And Rojo1.Left <> 76 Then
                z = z + 1
            End If

            If Rojo2.Top = 347 And Rojo2.Left = 231 Then
                deshabilitarFichas(Rojo2, Rojo2, Rojo2, Rojo2)

            ElseIf Rojo2.Top = 424 And Rojo2.Left = 137 And n = 6 Then
                l = l + 1

            ElseIf Rojo2.Top <> 424 And Rojo2.Left <> 137 Then
                z = z + 1
            End If

            If Rojo3.Top = 347 And Rojo3.Left = 249 Then
                deshabilitarFichas(Rojo3, Rojo3, Rojo3, Rojo3)

            ElseIf Rojo3.Top = 475 And Rojo3.Left = 76 And n = 6 Then
                l = l + 1

            ElseIf Rojo3.Top <> 475 And Rojo3.Left <> 76 Then
                z = z + 1
            End If


            If Rojo4.Top = 358 And Rojo4.Left = 260 Then
                deshabilitarFichas(Rojo4, Rojo4, Rojo4, Rojo4)

            ElseIf Rojo4.Top = 475 And Rojo4.Left = 137 And n = 6 Then
                l = l + 1

            ElseIf Rojo4.Top <> 475 And Rojo4.Left <> 137 Then
                z = z + 1
            End If


            If z <> 0 Or l <> 0 Then
                desabilitarTirar(Tirar)

            ElseIf z = 0 Or l = 0 Then
                habilitarTirar(Tirar)
            End If


        ElseIf i = 2 Then
            z = 0
            l = 0
            habilitarFichas(Verde1, Verde2, Verde3, Verde4)

            deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
            deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
            deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            Verde1.BringToFront()
            Verde2.BringToFront()
            Verde3.BringToFront()
            Verde4.BringToFront()
            NombreJugador.Text = Jugador2.Text
            Dado.BackColor = Color.LimeGreen
            'NroJugador.Text = i

            If Verde1.Top = 308 And Verde1.Left = 206 Then
                deshabilitarFichas(Verde1, Verde1, Verde1, Verde1)

            ElseIf Verde1.Top = 181 And Verde1.Left = 76 And n = 6 Then
                l = l + 1

            ElseIf Verde1.Top <> 181 And Verde1.Left <> 76 Then
                z = z + 1
            End If


            If Verde2.Top = 320 And Verde2.Left = 217 Then
                deshabilitarFichas(Verde2, Verde2, Verde2, Verde2)

            ElseIf Verde2.Top = 181 And Verde2.Left = 137 And n = 6 Then
                l = l + 1

            ElseIf Verde2.Top <> 181 And Verde2.Left <> 137 Then
                z = z + 1
            End If


            If Verde3.Top = 335 And Verde3.Left = 217 Then
                deshabilitarFichas(Verde3, Verde3, Verde3, Verde3)

            ElseIf Verde3.Top = 231 And Verde3.Left = 76 And n = 6 Then
                l = l + 1

            ElseIf Verde3.Top <> 231 And Verde3.Left <> 76 Then
                z = z + 1
            End If


            If Verde4.Top = 346 And Verde4.Left = 206 Then
                deshabilitarFichas(Verde4, Verde4, Verde4, Verde4)

            ElseIf Verde4.Top = 231 And Verde4.Left = 137 And n = 6 Then
                l = l + 1

            ElseIf Verde4.Top <> 231 And Verde4.Left <> 137 Then
                z = z + 1
            End If

            If z <> 0 Or l <> 0 Then
                desabilitarTirar(Tirar)

            ElseIf z = 0 Or l = 0 Then
                habilitarTirar(Tirar)
            End If

        ElseIf i = 3 Then
            z = 0
            l = 0
            habilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)

            deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
            deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
            deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            Amarillo1.BringToFront()
            Amarillo2.BringToFront()
            Amarillo3.BringToFront()
            Amarillo4.BringToFront()
            NombreJugador.Text = Jugador3.Text
            Dado.BackColor = Color.Gold
            'NroJugador.Text = i

            If Amarillo1.Top = 297 And Amarillo1.Left = 260 Then
                deshabilitarFichas(Amarillo1, Amarillo1, Amarillo1, Amarillo1)

            ElseIf Amarillo1.Top = 181 And Amarillo1.Left = 342 And n = 6 Then
                l = l + 1

            ElseIf Amarillo1.Top <> 181 And Amarillo1.Left <> 342 Then
                z = z + 1
            End If

            If Amarillo2.Top = 307 And Amarillo2.Left = 249 Then
                deshabilitarFichas(Amarillo2, Amarillo2, Amarillo2, Amarillo2)

            ElseIf Amarillo2.Top = 181 And Amarillo2.Left = 403 And n = 6 Then
                l = l + 1

            ElseIf Amarillo2.Top <> 181 And Amarillo2.Left <> 403 Then
                z = z + 1
            End If

            If Amarillo3.Top = 307 And Amarillo3.Left = 231 Then
                deshabilitarFichas(Amarillo3, Amarillo3, Amarillo3, Amarillo3)

            ElseIf Amarillo3.Top = 231 And Amarillo3.Left = 342 And n = 6 Then
                l = l + 1

            ElseIf Amarillo3.Top <> 231 And Amarillo3.Left <> 34 Then
                z = z + 1
            End If

            If Amarillo4.Top = 219 And Amarillo4.Left = 297 Then
                deshabilitarFichas(Amarillo4, Amarillo4, Amarillo4, Amarillo4)

            ElseIf Amarillo4.Top = 231 And Amarillo4.Left = 403 And n = 6 Then
                l = l + 1

            ElseIf Amarillo4.Top <> 231 And Amarillo4.Left <> 403 Then
                z = z + 1
            End If

            If z <> 0 Or l <> 0 Then
                desabilitarTirar(Tirar)

            ElseIf z = 0 Or l = 0 Then
                habilitarTirar(Tirar)
            End If

        ElseIf i = 4 Then
            z = 0
            l = 0
            habilitarFichas(Azul1, Azul2, Azul3, Azul4)

            deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
            deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
            deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
            Azul1.BringToFront()
            Azul2.BringToFront()
            Azul3.BringToFront()
            Azul4.BringToFront()
            NombreJugador.Text = Jugador4.Text
            Dado.BackColor = Color.DarkBlue
            ' NroJugador.Text = i


            If Azul1.Top = 347 And Azul1.Left = 273 Then
                deshabilitarFichas(Azul1, Azul1, Azul1, Azul1)

            ElseIf Azul1.Top = 424 And Azul1.Left = 342 And n = 6 Then
                l = l + 1

            ElseIf Azul1.Top <> 424 And Azul1.Left <> 342 Then
                z = z + 1
            End If


            If Azul2.Top = 336 And Azul2.Left = 263 Then
                deshabilitarFichas(Azul2, Azul2, Azul2, Azul2)

            ElseIf Azul2.Top = 424 And Azul2.Left = 403 And n = 6 Then
                l = l + 1

            ElseIf Azul2.Top <> 424 And Azul2.Left <> 403 Then
                z = z + 1
            End If


            If Azul3.Top = 319 And Azul3.Left = 263 Then
                deshabilitarFichas(Azul3, Azul3, Azul3, Azul3)

            ElseIf Azul3.Top = 475 And Azul3.Left = 342 And n = 6 Then
                l = l + 1

            ElseIf Azul3.Top <> 475 And Azul3.Left <> 342 Then
                z = z + 1
            End If


            If Azul4.Top = 308 And Azul4.Left = 273 Then
                deshabilitarFichas(Azul4, Azul4, Azul4, Azul4)

            ElseIf Azul4.Top = 475 And Azul4.Left = 403 And n = 6 Then
                l = l + 1

            ElseIf Azul4.Top <> 475 And Azul4.Left <> 403 Then
                z = z + 1
            End If

            If z <> 0 Or l <> 0 Then
                desabilitarTirar(Tirar)

            ElseIf z = 0 Or l = 0 Then
                habilitarTirar(Tirar)
            End If
        End If
    End Sub

    'BOTONES

    Private Sub Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Volver.Click

        ' Reiniciará las posiciones de las fichas al apretar el botón para volver, tmb hace lo mismo con el botón empezar del form1

        ficha_inicio(Rojo1)
        ficha_inicio(Rojo2)
        ficha_inicio(Rojo3)
        ficha_inicio(Rojo4)

        ficha_inicio(Verde1)
        ficha_inicio(Verde2)
        ficha_inicio(Verde3)
        ficha_inicio(Verde4)


        ficha_inicio(Amarillo1)
        ficha_inicio(Amarillo2)
        ficha_inicio(Amarillo3)
        ficha_inicio(Amarillo4)


        ficha_inicio(Azul1)
        ficha_inicio(Azul2)
        ficha_inicio(Azul3)
        ficha_inicio(Azul4)

        Dado.Image = My.Resources.Dado__GIF_

        habilitarTirar(Tirar)
        Tirar.Enabled = True
        i = 0
        a = 0
        z = 0
        l = 0
        H = 0
        ContCom = 0
        EleIni = 0
        Dado.BackColor = Color.Transparent
        PuestoRojo.Enabled = False
        PuestoRojo.BackgroundImage = Nothing
        PuestoVerde.Enabled = False
        PuestoVerde.BackgroundImage = Nothing
        PuestoAmarillo.Enabled = False
        PuestoAmarillo.BackgroundImage = Nothing
        PuestoAzul.Enabled = False
        PuestoAzul.BackgroundImage = Nothing
        NombreJugador.Text = Nothing
        Fin.Enabled = False
        Fin.BackgroundImage = Nothing
        If CJ = 0 Then
            RT = False
            VT = False
            AmT = False
            AT = False
            GR1 = 0
            GR2 = 0
            GR3 = 0
            GR4 = 0
            GV1 = 0
            GV2 = 0
            GV3 = 0
            GV4 = 0
            GAm1 = 0
            GAm2 = 0
            GAm3 = 0
            GAm4 = 0
            GA1 = 0
            GA2 = 0
            GA3 = 0
            GA4 = 0
            MSG = 0
            Rojo1.Show()
            Rojo2.Show()
            Rojo3.Show()
            Rojo4.Show()
            Verde1.Show()
            Verde2.Show()
            Verde3.Show()
            Verde4.Show()
            Amarillo1.Show()
            Amarillo2.Show()
            Amarillo3.Show()
            Amarillo4.Show()
            Azul1.Show()
            Azul2.Show()
            Azul3.Show()
            Azul4.Show()
            Verde1.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAVERDE.png")
            Verde2.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAVERDE.png")
            Verde3.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAVERDE.png")
            Verde4.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAVERDE.png")
            Amarillo1.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAMARILLO.png")
            Amarillo2.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAMARILLO.png")
            Amarillo3.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAMARILLO.png")
            Amarillo4.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAMARILLO.png")
            Azul1.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAZUL.png")
            Azul2.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAZUL.png")
            Azul3.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAZUL.png")
            Azul4.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAZUL.png")
            Me.Close()
        ElseIf CJ = 1 Then
            RT = False
            AmT = False
            GR1 = 0
            GR2 = 0
            GR3 = 0
            GR4 = 0
            GAm1 = 0
            GAm2 = 0
            GAm3 = 0
            GAm4 = 0
            MSG = 0
            Rojo1.Show()
            Rojo2.Show()
            Rojo3.Show()
            Rojo4.Show()
            Amarillo1.Show()
            Amarillo2.Show()
            Amarillo3.Show()
            Amarillo4.Show()
            Amarillo1.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAMARILLO.png")
            Amarillo2.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAMARILLO.png")
            Amarillo3.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAMARILLO.png")
            Amarillo4.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAMARILLO.png")
            Me.Close()
        ElseIf CJ = 2 Then
            VT = False
            AT = False
            GV1 = 0
            GV2 = 0
            GV3 = 0
            GV4 = 0
            GA1 = 0
            GA2 = 0
            GA3 = 0
            GA4 = 0
            MSG = 0
            Verde1.Show()
            Verde2.Show()
            Verde3.Show()
            Verde4.Show()
            Azul1.Show()
            Azul2.Show()
            Azul3.Show()
            Azul4.Show()
            Verde1.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAVERDE.png")
            Verde2.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAVERDE.png")
            Verde3.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAVERDE.png")
            Verde4.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAVERDE.png")
            Azul1.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAZUL.png")
            Azul2.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAZUL.png")
            Azul3.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAZUL.png")
            Azul4.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAZUL.png")
            Me.Close()
        End If

    End Sub

    Private Sub Parar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Parar.MouseDown

        Parar.BackgroundImage = My.Resources.BOTONAMARILLOCLICK

    End Sub

    Private Sub Parar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Parar.MouseLeave

        Parar.BackgroundImage = My.Resources.AMARILLO

    End Sub

    Private Sub Volver_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Volver.MouseDown

        Volver.BackgroundImage = My.Resources.BOTONVERDE

    End Sub

    Private Sub Volver_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Volver.MouseLeave

        Volver.BackgroundImage = My.Resources.BOTONVERDECLICK

    End Sub
















    'REFERENCIAS

    ' TRAMOS

    ' Tramo 1 : x = 210
    ' Tramo 2 : y = 356
    ' Tramo 3 : x = 32
    ' Tramo 4 : y = 300
    ' Tramo 5 : x = 211
    ' Tramo 6 : y = 138
    ' Tramo 7 : x = 269
    ' Tramo 8 : y = 301
    ' Tramo 9 : x = 447
    ' Tramo 10 : y = 355
    ' Tramo 11 : x = 269
    ' Tramo 12 : y = 517


    'GIRO

    ' Tramo 1 a 2 : x = 211 / y = 356 ----> No funciona bien el giro (ArDer) / Tampoco con el 6 cuando hace Izq - Ar - Izq





    '----------------------------------------------------------------------------------------------------------------------------------------

    'Variables globales


    'Sol
    Dim MoverArriba As Boolean = True
    Dim MoverAbajo As Boolean = True
    Dim MoverDer As Boolean = True
    Dim MoverIzq As Boolean = True

    Dim MoverIzqDer As Integer = 30
    Dim MoverAbAr As Integer = 27
    Dim CJ As Integer
    Dim j, k, n, c As Integer
    Dim i As Integer = 0
    Dim a As Integer = 0
    Dim z As Integer = 0
    Dim l As Integer = 0
    Dim H As Integer = 0
    Dim porfavornotemuevas As Integer = 0
    Dim ContCom As Integer = 0
    Dim EleIni As Integer = 0
    Dim GR1 As Integer = 0
    Dim GR2 As Integer = 0
    Dim GR3 As Integer = 0
    Dim GR4 As Integer = 0
    Dim GV1 As Integer = 0
    Dim GV2 As Integer = 0
    Dim GV3 As Integer = 0
    Dim GV4 As Integer = 0
    Dim GAm1 As Integer = 0
    Dim GAm2 As Integer = 0
    Dim GAm3 As Integer = 0
    Dim GAm4 As Integer = 0
    Dim GA1 As Integer = 0
    Dim GA2 As Integer = 0
    Dim GA3 As Integer = 0
    Dim GA4 As Integer = 0
    Dim MSG As Integer = 0
    Dim cont As Boolean
    Dim RT As Boolean = False
    Dim VT As Boolean = False
    Dim AmT As Boolean = False
    Dim AT As Boolean = False
    Dim pos As Boolean


    'Dim l As Integer = 3

    Dim giroArIzq, giroArDer, giroAbIzq, giroAbDer, giroIzqAr, giroIzqAb, giroDerAr, giroDerAb, giroDerIzq, giroArAb, giroAbAr, giroIzqDer As Boolean




    ' -------------------------------- DADO --------------------------------

    Public Sub CambiarDado()

        Dim aleatorio As New Random
        If EleIni = 0 Then
            i = aleatorio.Next(1, 5)
            EleIni = 1
        End If
        k = 0
        n = aleatorio.Next(1, 7)

        If n = 1 Then

            Dado.Image = Image.FromFile(ResourceFilePathPrefix & "1.png")

        ElseIf n = 2 Then

            Dado.Image = Image.FromFile(ResourceFilePathPrefix & "2.png")

        ElseIf n = 3 Then

            Dado.Image = Image.FromFile(ResourceFilePathPrefix & "3.png")

        ElseIf n = 4 Then

            Dado.Image = Image.FromFile(ResourceFilePathPrefix & "4.png")

        ElseIf n = 5 Then

            Dado.Image = Image.FromFile(ResourceFilePathPrefix & "5.png")

        ElseIf n = 6 Then

            Dado.Image = Image.FromFile(ResourceFilePathPrefix & "6.png")

        End If

    End Sub









    Public Sub Movimiento(ByVal imagen As PowerPacks.RectangleShape, ByVal n As Integer)
        If (imagen.Top > 358 And imagen.Top < 517 And imagen.Left = 210) Or (imagen.Top < 354 And imagen.Top > 295 And imagen.Left = 32) Or (imagen.Top > 135 And imagen.Top < 277 And imagen.Left = 210) Or (imagen.Top > 355 And imagen.Top < 510 And imagen.Location.X = 239 And c = 1) Then


            j = Arriba(imagen, n, giroArIzq, giroArDer)


            If giroArIzq = True Then

                Izquierda(imagen, j, giroIzqAr, giroIzqAb)

            ElseIf giroArDer = True Then

                Dim m As Integer

                m = Derecha(imagen, j, giroDerAr, giroDerAb)

                If imagen.Location.Y = 188 And imagen.Location.X = 244 And m > 0 Then ' ???
                    Arriba(imagen, m, giroArIzq, giroArDer)

                ElseIf imagen.Location.Y = 300 And imagen.Location.X = 211 And m > 0 Then
                    Arriba(imagen, m, giroArIzq, giroArDer)
                ElseIf imagen.Location.X = 269 And imagen.Location.Y = 138 And m > 0 Then
                    Abajo(imagen, m, giroAbIzq, giroAbDer)

                ElseIf imagen.Location.X = 238 And imagen.Location.Y = 138 And c = 3 And m > 0 Then
                    Abajo(imagen, m, giroAbIzq, giroAbDer)

                End If

            ElseIf giroArAb = True Then
                Abajo(imagen, j, giroAbIzq, giroAbDer)

            End If


        ElseIf (imagen.Top = 356 And imagen.Left > 29 And imagen.Left < 211) Or (imagen.Top = 355 And imagen.Left > 288 And imagen.Left < 455) Or (imagen.Top = 517 And imagen.Left > 200 And imagen.Left < 280) Or (imagen.Top = 328 And imagen.Left > 288 And imagen.Left < 440 And c = 4) Then

            j = Izquierda(imagen, n, giroIzqAr, giroIzqAb)

            If giroIzqAr = True Then
                Dim m As Integer

                m = Arriba(imagen, j, giroArIzq, giroArDer)

                If imagen.Location.X = 32 And imagen.Location.Y = 300 And m > 0 Then
                    Derecha(imagen, m, giroDerAr, giroDerAb)

                ElseIf imagen.Location.X = 210 And imagen.Location.Y = 356 And m > 0 Then
                    Izquierda(imagen, m, giroIzqAr, giroIzqAb)

                ElseIf imagen.Location.X = 32 And imagen.Location.Y = 327 And c = 2 And m > 0 Then
                    Derecha(imagen, m, giroDerAr, giroDerAb)

                End If
            ElseIf giroIzqAb = True Then

                Abajo(imagen, j, giroAbIzq, giroAbDer)

            ElseIf giroIzqDer = True Then
                Derecha(imagen, j, giroDerAr, giroDerAb)

            End If


        ElseIf (imagen.Top = 300 And imagen.Left > 29 And imagen.Left < 200) Or (imagen.Top = 138 And imagen.Left > 205 And imagen.Left < 270) Or (imagen.Top = 301 And imagen.Left > 267 And imagen.Left < 455) Or (imagen.Left > 35 And imagen.Left < 205 And imagen.Location.Y = 327 And c = 2) Then

            j = Derecha(imagen, n, giroDerAr, giroDerAb)

            If giroDerAr = True Then

                Arriba(imagen, j, giroArIzq, giroArDer)

            ElseIf giroDerAb = True Then
                Dim m As Integer

                m = Abajo(imagen, j, giroAbIzq, giroAbDer)

                If imagen.Location.X = 268 And imagen.Location.Y = 301 And m > 0 Then
                    Derecha(imagen, m, giroDerAr, giroDerAb)

                ElseIf imagen.Location.X = 447 And imagen.Location.Y = 355 And m > 0 Then
                    Izquierda(imagen, m, giroIzqAr, giroIzqAb)

                ElseIf imagen.Location.X = 447 And imagen.Location.Y = 328 And c = 4 And m > 0 Then
                    Izquierda(imagen, m, giroIzqAr, giroIzqAb)

                End If

            ElseIf giroDerIzq = True Then
                Izquierda(imagen, j, giroIzqAr, giroIzqAb)
            End If




        ElseIf (imagen.Top > 135 And imagen.Top < 277 And imagen.Left = 269) Or (imagen.Top > 290 And imagen.Top < 355 And imagen.Left = 447) Or (imagen.Top > 365 And imagen.Top < 517 And imagen.Left = 270) Or (imagen.Location.X = 238 And imagen.Top > 140 And imagen.Top < 277 And c = 3) Then

            j = Abajo(imagen, n, giroAbIzq, giroAbDer)


            If giroAbIzq = True Then
                Dim m As Integer



                m = Izquierda(imagen, j, giroIzqAr, giroIzqAb)

                If imagen.Location.X = 210 And imagen.Location.Y = 517 And m > 0 Then
                    Arriba(imagen, m, giroArIzq, giroArDer)


                ElseIf imagen.Location.X = 269 And imagen.Location.Y = 355 And m > 0 Then

                    Abajo(imagen, m, giroAbIzq, giroAbDer)

                ElseIf imagen.Location.X = 239 And imagen.Location.Y = 517 And c = 1 And m > 0 Then
                    Arriba(imagen, m, giroArIzq, giroArDer)

                End If

            ElseIf giroAbDer = True Then

                Dim m As Integer

                m = Derecha(imagen, j, giroDerAr, giroDerAb)

            ElseIf giroAbAr = True Then
                Arriba(imagen, j, giroArIzq, giroArDer)

            End If

        End If

        'MsgBox("x:   " + imagen.Location.X.ToString + " " + "y:   " + imagen.Location.Y.ToString)

    End Sub









    ' ----------------------------------------- DIRECCIONES DE MOVIMIENTO ----------------------------------------------

    Public Function Izquierda(ByVal imagen As PowerPacks.RectangleShape, ByVal n As Integer, ByRef giroIzqAr As Boolean, ByRef giroIzqAb As Boolean) As Integer

        giroIzqAr = False
        giroIzqAb = False
        giroIzqDer = False
        imagen.Left -= MoverIzqDer * n

        Dim locOriginalX, locFinal As Integer


        'Caminos (Entrar/Movimientos)

        If imagen.Location.X < 235 And imagen.Location.Y = 517 And c = 1 Then 'Entrar rojo en su camino


            giroIzqAr = True
            locOriginalX = 230 - imagen.Location.X
            locFinal = locOriginalX / 30
            imagen.Left = 239



        ElseIf imagen.Location.X < 260 And imagen.Location.Y = 328 And c = 4 Then 'Mover Azul por su camino

            giroIzqDer = True

            locOriginalX = 260 - imagen.Location.X
            locFinal = locOriginalX / 30
            imagen.Left = 270

            ' AComodar fichitas

        ElseIf imagen.Location.X = 297 And imagen.Location.Y = 355 Then

            imagen.Left = 299

        ElseIf imagen.Location.X = 327 And imagen.Location.Y = 355 Then

            imagen.Left = 328

        ElseIf imagen.Location.X = 357 And imagen.Location.Y = 355 Then

            imagen.Left = 358

        ElseIf imagen.Location.X = 387 And imagen.Location.Y = 355 Then

            imagen.Left = 388

        ElseIf imagen.Location.X = 418 And imagen.Location.Y = 355 Then

            imagen.Left = 417

        ElseIf imagen.Location.X = 448 And imagen.Location.Y = 355 Then

            imagen.Left = 447

        ElseIf imagen.Top = 356 And imagen.Left = 150 Then

            imagen.Left = 151

        ElseIf imagen.Top = 356 And imagen.Left = 61 Then

            imagen.Left = 62

        ElseIf imagen.Top = 356 And imagen.Left = 90 Then

            imagen.Left = 91

        ElseIf imagen.Top = 356 And imagen.Left = 31 Then

            imagen.Left = 32
            ' Tramos Tablero




        ElseIf imagen.Location.X < 29 And imagen.Top = 356 Then

            ' Tramos Tablero

            'Tramo 2 a 3

            giroIzqAr = True

            locOriginalX = (imagen.Location.X * -1) + 30
            locFinal = locOriginalX / 30
            imagen.Top = 356
            imagen.Left = 32



        ElseIf imagen.Location.X < 288 And imagen.Location.X > 117 And imagen.Location.Y = 355 Then

            'Tramo 10 a 11

            locOriginalX = 288 - imagen.Location.X
            'MsgBox(locOriginalX.ToString)

            If locOriginalX <= 170 Then

                giroIzqAb = True

                locFinal = locOriginalX / 30
                imagen.Left = 270
                imagen.Top = 355

            End If


        ElseIf imagen.Location.X < 200 And imagen.Top = 517 Then

            'Tramo 12 a 1

            giroIzqAr = True

            locOriginalX = 205 - imagen.Location.X
            locFinal = locOriginalX / 30
            imagen.Left = 210
            imagen.Top = 517

        End If

        Return locFinal
    End Function








    Public Function Derecha(ByVal imagen As PowerPacks.RectangleShape, ByVal n As Integer, ByRef giroDerAr As Boolean, ByRef giroDerAb As Boolean) As Integer

        giroDerAr = False
        giroDerAb = False
        giroDerIzq = False
        imagen.Left += MoverIzqDer * n

        'If imagen.Location.Y = 138 Then
        'imagen.Left = imagen.Left - 2
        'End If




        Dim locOriginalX, locFinal As Integer


        ' -------- Caminitos (Entrar/Movimiento)  --------

        If imagen.Location.X > 240 And imagen.Location.Y = 138 And c = 3 Then 'Entrar ficha amarilla en su camino

            giroDerAb = True
            locOriginalX = imagen.Location.X - 240
            locFinal = locOriginalX / 30
            imagen.Left = 238
            imagen.Top = 138


        ElseIf imagen.Location.X > 205 And imagen.Location.Y = 327 And c = 2 Then

            ' Movimiento fichitas verdes

            giroDerIzq = True

            locOriginalX = imagen.Location.X - 205
            locFinal = locOriginalX / 30
            imagen.Left = 209




            ' -------- Acomodar fichitas --------


        ElseIf imagen.Top = 300 And imagen.Left = 92 Then

            imagen.Left = 91

        ElseIf imagen.Top = 300 And imagen.Left = 122 Then

            imagen.Left = 121

        ElseIf imagen.Top = 300 And imagen.Left = 152 Then

            imagen.Left = 151

        ElseIf (imagen.Top = 300) And imagen.Left = 182 Or imagen.Left = 181 Then

            imagen.Left = 180

        ElseIf imagen.Location.X = 270 And imagen.Top = 138 Then

            imagen.Left = 269

        ElseIf imagen.Location.X = 298 And imagen.Location.Y = 301 Then

            imagen.Left = 299

        ElseIf imagen.Location.X = 329 And imagen.Location.Y = 301 Then

            imagen.Left = 328

        ElseIf imagen.Location.X = 359 And imagen.Location.Y = 301 Then

            imagen.Left = 358

        ElseIf imagen.Location.X = 418 And imagen.Location.Y = 301 Then

            imagen.Left = 417

        ElseIf imagen.Location.X = 448 And imagen.Location.Y = 301 Then

            imagen.Left = 447


            ' -------- Tramos Tablero --------

        ElseIf imagen.Location.X > 195 And imagen.Top = 300 Then

            'Tramo 4 a 5

            giroDerAr = True

            locOriginalX = imagen.Location.X - 180
            locFinal = locOriginalX / 30
            imagen.Top = 300
            imagen.Left = 211

        ElseIf imagen.Location.X >= 269 And imagen.Top = 138 Then

            'Tramo 6 a 7

            giroDerAb = True

            locOriginalX = imagen.Location.X - 269
            locFinal = locOriginalX / 30
            imagen.Left = 269
            imagen.Top = 138


        ElseIf imagen.Location.X > 455 And imagen.Location.Y = 301 Then

            'Tramo 8 a 9

            giroDerAb = True

            locOriginalX = imagen.Location.X - 450
            locFinal = locOriginalX / 30
            imagen.Left = 447
            imagen.Top = 301


        End If

        Return locFinal
    End Function










    Public Function Arriba(ByVal imagen As PowerPacks.RectangleShape, ByVal n As Integer, ByRef giroArIzq As Boolean, ByRef giroArDer As Boolean) As Integer

        giroArDer = False
        giroArIzq = False
        giroArAb = False

        imagen.Top -= MoverAbAr * n

        'MsgBox("asdasdsads")

        Dim locOriginalY, locFinal As Integer

        ' Caminitos de color (Entrada/Movimiento)


        If imagen.Location.X = 32 And imagen.Location.Y < 320 And c = 2 Then

            'Entrar fichitas verdes en su camino

            giroArDer = True

            locOriginalY = 325 - imagen.Location.Y
            locFinal = locOriginalY / 28
            imagen.Top = 327

        ElseIf imagen.Location.Y < 340 And imagen.Left = 239 Then

            'Movimiento Fichita Roja

            giroArAb = True

            locOriginalY = 376 - imagen.Location.Y
            locFinal = locOriginalY / 35
            imagen.Top = 356

            ' Tramos Tablero

        ElseIf (imagen.Location.X = 211) And imagen.Top = 273 Or imagen.Top = 246 Or imagen.Top = 219 Or imagen.Top = 192 Or imagen.Top = 165 Then

            imagen.Left = 210


        ElseIf imagen.Location.Y < 382 And imagen.Location.Y > 219 And imagen.Left = 210 Then

            'Tramo 1 a 2

            locOriginalY = 383 - imagen.Location.Y
            'MsgBox(locOriginalY.ToString)

            If locOriginalY <= 162 Then

                ''MsgBox(locOriginalY.ToString)
                'MsgBox("porque se ejectua esto")
                giroArIzq = True
                locFinal = locOriginalY / 28
                imagen.Top = 356
                imagen.Left = 210

            End If




        ElseIf imagen.Location.Y < 296 And imagen.Left = 32 Then

            'Tramo 3 a 4
            giroArDer = True


            locOriginalY = 300 - imagen.Location.Y
            locFinal = locOriginalY / 28
            imagen.Top = 300

        ElseIf imagen.Location.Y < 136 And (imagen.Location.X = 210 Or imagen.Location.Y = 211) Then

            'Tramo 5 a 6

            giroArDer = True
            locOriginalY = 138 - imagen.Location.Y
            locFinal = locOriginalY / 28
            imagen.Top = 138
            imagen.Left = 210

        End If

        Return locFinal
    End Function






    Public Function Abajo(ByVal imagen As PowerPacks.RectangleShape, ByVal n As Integer, ByRef giroAbIzq As Boolean, ByRef giroAbDer As Boolean) As Integer

        giroAbDer = False
        giroAbIzq = False
        giroAbAr = False
        imagen.Top += MoverAbAr * n


        Dim locOriginalY, locFinal As Integer



        ' Caminitos de color (Entrada/Movimiento)

        If imagen.Location.X = 447 And imagen.Location.Y > 329 And c = 4 Then 'Entrar azul en su camino

            giroAbIzq = True
            locOriginalY = imagen.Location.Y - 326
            locFinal = locOriginalY / 28
            imagen.Top = 328

        ElseIf imagen.Location.X = 238 And imagen.Location.Y > 285 And c = 3 Then 'Volver amarillo por su camino

            giroAbAr = True

            locOriginalY = imagen.Location.Y - 290
            locFinal = locOriginalY / 30
            imagen.Top = 302

            'Acomodar fichitas

        ElseIf imagen.Location.X = 448 And imagen.Location.Y = 355 Then

            imagen.Left = 447

        ElseIf imagen.Location.X = 448 And imagen.Location.Y = 325 Then

            imagen.Left = 447

        ElseIf imagen.Location.X = 448 And imagen.Location.Y = 295 Then

            imagen.Left = 447

            'Tramos Tablero

        ElseIf imagen.Location.Y > 280 And imagen.Location.Y < 470 And imagen.Location.X = 269 Then

            'Tramo 7 a 8
            locOriginalY = imagen.Location.Y - 273
            'MsgBox(locOriginalY.ToString)

            If locOriginalY <= 162 Then

                giroAbDer = True
                'MsgBox(locOriginalY.ToString)
                'MsgBox(giroAbDer.ToString)
                locFinal = locOriginalY / 28
                imagen.Top = 301
                imagen.Left = 268
                'MsgBox(locFinal.ToString)

            End If



        ElseIf imagen.Top > 355 And imagen.Left = 447 Then

            'Tramo 9 a 10

            giroAbIzq = True

            'Con cualquiera de las dos funciona
            'locOriginalY = imagen.Location.Y - 355
            'locFinal = locOriginalY / 28

            locOriginalY = imagen.Location.Y - 348
            locFinal = locOriginalY / 30
            imagen.Top = 355
            imagen.Left = 447

            'MsgBox("X: " + imagen.Location.X.ToString + " " + "Y:" + imagen.Location.X.ToString + " " + locFinal.ToString + " " + locOriginalY.ToString)

        ElseIf imagen.Location.Y > 520 And imagen.Left = 270 Then

            'Tramo 11 a 126

            giroAbIzq = True

            locOriginalY = imagen.Location.Y - 510
            locFinal = locOriginalY / 30
            imagen.Top = 517
            imagen.Left = 269

        End If



        Return locFinal
    End Function








    ' ----------------------------------------------------- Colisiones -----------------------------------------------------

    Public Function colision_posiciones(ByVal imagen As PowerPacks.RectangleShape) As Boolean
        Dim colision As Boolean = False
        Dim x, y As Integer

        x = imagen.Location.X
        y = imagen.Location.Y


        'If (x = 88 And y = 356) Or (x = 60 And y = 300) Or (y = 192 And x = 209) Or (y = 164 And x = 270) Or (x = 385 And y = 301) Or (x = 414 And y = 355) Or (y = 460 And x = 269) Or (y = 488 And x = 211) Then
        'colision = True
        'End If

        If (x = 91 And y = 356) Or (x = 62 And y = 300) Or (y = 192 And x = 210) Or (y = 165 And x = 269) Or (x = 388 And y = 301) Or (x = 417 And y = 355) Or (y = 463 And x = 270) Or (y = 490 And x = 210) Or (x > 200 And x < 280 And y > 290 And y < 360) Then
            colision = True
        End If

        Return colision
    End Function


    Public Sub fichas_colision_comer(ByRef Ficha As PowerPacks.RectangleShape, ByRef F1 As PowerPacks.RectangleShape, ByRef F2 As PowerPacks.RectangleShape, ByRef F3 As PowerPacks.RectangleShape, ByRef F4 As PowerPacks.RectangleShape, ByRef F5 As PowerPacks.RectangleShape, ByRef F6 As PowerPacks.RectangleShape, ByRef F7 As PowerPacks.RectangleShape, ByRef F8 As PowerPacks.RectangleShape, ByRef F9 As PowerPacks.RectangleShape, ByRef F10 As PowerPacks.RectangleShape, ByRef F11 As PowerPacks.RectangleShape, ByRef F12 As PowerPacks.RectangleShape)

        If (Ficha.Bounds.IntersectsWith(F1.Bounds)) Then
            Dim f As String = F1.Name
            Dim fi1 As String = Ficha.Name
            ''msgbox(f + " " + fi1)
            ficha_inicio(F1)
            'ContCom = 1

        End If

        If (Ficha.Bounds.IntersectsWith(F2.Bounds)) Then
            Dim f As String = F2.Name
            Dim fi2 As String = Ficha.Name
            ''msgbox(f + " " + fi2)
            ficha_inicio(F2)
            'ContCom = 1

        End If

        If (Ficha.Bounds.IntersectsWith(F3.Bounds)) Then
            Dim f As String = F3.Name
            Dim fi3 As String = Ficha.Name
            ''msgbox(f + " " + fi3)
            ficha_inicio(F3)
            'ContCom = 1

        End If

        If (Ficha.Bounds.IntersectsWith(F4.Bounds)) Then
            Dim f As String = F4.Name
            Dim fi4 As String = Ficha.Name
            ''msgbox(f + " " + fi4)
            ficha_inicio(F4)
            'ContCom = 1

        End If


        If (Ficha.Bounds.IntersectsWith(F5.Bounds)) Then
            Dim f As String = F5.Name
            Dim fi5 As String = Ficha.Name
            ''msgbox(f + " " + fi5)
            ficha_inicio(F5)
            'ContCom = 1

        End If

        If (Ficha.Bounds.IntersectsWith(F6.Bounds)) Then
            Dim f As String = F6.Name
            Dim fi6 As String = Ficha.Name
            ''msgbox(f + " " + fi6)
            ficha_inicio(F6)
            'ContCom = 1

        End If

        If (Ficha.Bounds.IntersectsWith(F7.Bounds)) Then
            Dim f As String = F7.Name
            Dim fi7 As String = Ficha.Name
            ''msgbox(f + " " + fi7)
            ficha_inicio(F7)
            'ContCom = 1

        End If


        If (Ficha.Bounds.IntersectsWith(F8.Bounds)) Then
            Dim f As String = F8.Name
            Dim fi8 As String = Ficha.Name
            ''msgbox(f + " " + fi8)
            ficha_inicio(F8)
            'ContCom = 1

        End If


        If (Ficha.Bounds.IntersectsWith(F9.Bounds)) Then
            Dim f As String = F9.Name
            Dim fi9 As String = Ficha.Name
            ''msgbox(f + " " + fi9)
            ficha_inicio(F9)
            'ContCom = 1

        End If


        If (Ficha.Bounds.IntersectsWith(F10.Bounds)) Then
            Dim f As String = F10.Name
            Dim fi10 As String = Ficha.Name
            ''msgbox(f + " " + fi10)
            ficha_inicio(F10)
            'ContCom = 1

        End If


        If (Ficha.Bounds.IntersectsWith(F11.Bounds)) Then
            Dim f As String = F11.Name
            Dim fi11 As String = Ficha.Name
            ''msgbox(f + " " + fi11)
            ficha_inicio(F11)
            'ContCom = 1

        End If


        If (Ficha.Bounds.IntersectsWith(F12.Bounds)) Then
            Dim f As String = F12.Name
            Dim fi12 As String = Ficha.Name
            ''msgbox(f + " " + fi12)
            ficha_inicio(F12)
            'ContCom = 1

        End If

    End Sub


    Public Sub ficha_inicio(ByRef ficha As PowerPacks.RectangleShape)
        Dim x, y As Integer
        Dim nombreficha As String

        nombreficha = ficha.Name

        ' Fichas Rojas 
        If nombreficha.Equals("Rojo1") Then
            y = 424
            x = 76
            ContCom = 1
            ficha.Location = New Point(x, y)

        ElseIf nombreficha.Equals("Rojo2") Then
            y = 424
            x = 137
            ContCom = 1
            ficha.Location = New Point(x, y)

        ElseIf nombreficha.Equals("Rojo3") Then
            y = 475
            x = 76
            ContCom = 1
            ficha.Location = New Point(x, y)

        ElseIf nombreficha.Equals("Rojo4") Then
            y = 475
            x = 137
            ContCom = 1
            ficha.Location = New Point(x, y)

            ' Fichas Verdes
        ElseIf nombreficha.Equals("Verde1") Then
            y = 181
            x = 76
            ContCom = 1
            ficha.Location = New Point(x, y)

        ElseIf nombreficha.Equals("Verde2") Then
            y = 181
            x = 137
            ContCom = 1
            ficha.Location = New Point(x, y)

        ElseIf nombreficha.Equals("Verde3") Then
            y = 231
            x = 76
            ContCom = 1
            ficha.Location = New Point(x, y)

        ElseIf nombreficha.Equals("Verde4") Then
            y = 231
            x = 137
            ContCom = 1
            ficha.Location = New Point(x, y)

            ' Fichas Amarillas
        ElseIf nombreficha.Equals("Amarillo1") Then
            y = 181
            x = 342
            ContCom = 1
            ficha.Location = New Point(x, y)

        ElseIf nombreficha.Equals("Amarillo2") Then
            y = 181
            x = 403
            ContCom = 1
            ficha.Location = New Point(x, y)

        ElseIf nombreficha.Equals("Amarillo3") Then
            y = 231
            x = 342
            ContCom = 1
            ficha.Location = New Point(x, y)


        ElseIf nombreficha.Equals("Amarillo4") Then
            y = 231
            x = 403
            ContCom = 1
            ficha.Location = New Point(x, y)



            ' Fichas Azules
        ElseIf nombreficha.Equals("Azul1") Then
            y = 424
            x = 342
            ContCom = 1
            ficha.Location = New Point(x, y)

        ElseIf nombreficha.Equals("Azul2") Then
            y = 424
            x = 403
            ContCom = 1
            ficha.Location = New Point(x, y)

        ElseIf nombreficha.Equals("Azul3") Then
            y = 475
            x = 342
            ContCom = 1
            ficha.Location = New Point(x, y)

        ElseIf nombreficha.Equals("Azul4") Then
            y = 475
            x = 403
            ContCom = 1
            ficha.Location = New Point(x, y)

        End If





    End Sub


























    ' ----------------------------------------------------- SALIR -----------------------------------------------------------



    Public Sub Salir(ByVal imagen As PowerPacks.RectangleShape, ByVal n As Integer)

        'Rojo
        If (imagen.Name.Equals("Rojo1") Or imagen.Name.Equals("Rojo2") Or imagen.Name.Equals("Rojo3") Or imagen.Name.Equals("Rojo4")) And n = 6 Then

            imagen.Location = New Point(210, 491)

            'Verde
        ElseIf (imagen.Name.Equals("Verde1") Or imagen.Name.Equals("Verde2") Or imagen.Name.Equals("Verde3") Or imagen.Name.Equals("Verde4")) And n = 6 Then

            imagen.Location = New Point(62, 300)

            'Amarillo
        ElseIf (imagen.Name.Equals("Amarillo1") Or imagen.Name.Equals("Amarillo2") Or imagen.Name.Equals("Amarillo3") Or imagen.Name.Equals("Amarillo4")) And n = 6 Then

            imagen.Location = New Point(269, 165)

            'Azul
        ElseIf (imagen.Name.Equals("Azul1") Or imagen.Name.Equals("Azul2") Or imagen.Name.Equals("Azul3") Or imagen.Name.Equals("Azul4")) And n = 6 Then

            imagen.Location = New Point(417, 355)

        End If
    End Sub











    '--------------------------------------------- FICHAS ------------------------------------------------------



    'fichitas ROJAS :3

    Private Sub Rojo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rojo1.Click

        c = 1

        If Rojo1.Top = 424 And Rojo1.Left = 76 And n = 6 Then
            Salir(Rojo1, n)
            a = a + 1
        ElseIf Rojo1.Top <> 424 And Rojo1.Left <> 76 And GR1 = 0 Then

            Movimiento(Rojo1, n)
            pos = colision_posiciones(Rojo1)
            a = a + 1
            If pos = False Then
                fichas_colision_comer(Rojo1, Verde1, Verde2, Verde3, Verde4, Amarillo1, Amarillo2, Amarillo3, Amarillo4, Azul1, Azul2, Azul3, Azul4)
            End If
            If n < 6 And a < 3 And ContCom = 0 Then
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                habilitarTirar(Tirar)
            End If
        End If
        If Rojo1.Top > 330 And Rojo1.Top < 370 And Rojo1.Left = 239 Then
            Rojo1.Top = 358
            Rojo1.Left = 219
            deshabilitarFichas(Rojo1, Rojo1, Rojo1, Rojo1)
            GR1 = 1
            ContCom = 1
            z = z - 1
            If GR1 = 1 And GR2 = 1 And GR3 = 1 And GR4 = 1 And MSG = 0 Then

                MSG = MSG + 1
                GR1 = 0 And GR2 = 0 And GR3 = 0 And GR4 = 0
                RT = True
                PuestoRojo.Enabled = False
                PuestoRojo.BackgroundImage = My.Resources.CORONA11
                ContCom = 0
                If CJ = 1 Then
                    Fin.Enabled = False
                    Fin.BackgroundImage = My.Resources.FIN
                    If RT = False Then
                        PuestoRojo.BackgroundImage = My.Resources.CORONA2
                    ElseIf AmT = False Then
                        PuestoAmarillo.BackgroundImage = My.Resources.CORONA2
                    End If
                    Rojo1.Hide()
                    Rojo2.Hide()
                    Rojo3.Hide()
                    Rojo4.Hide()
                    Amarillo1.Hide()
                    Amarillo2.Hide()
                    Amarillo3.Hide()
                    Amarillo4.Hide()
                    ContCom = 0
                    desabilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                    deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                    deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                    deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                End If
            ElseIf GR1 = 1 And GR2 = 1 And GR3 = 1 And GR4 = 1 And MSG = 1 Then
                MSG = MSG + 1
                GR1 = 0 And GR2 = 0 And GR3 = 0 And GR4 = 0
                RT = True
                PuestoRojo.Enabled = False
                PuestoRojo.BackgroundImage = My.Resources.CORONA2
                ContCom = 0
                
            ElseIf GR1 = 1 And GR2 = 1 And GR3 = 1 And GR4 = 1 And MSG = 2 Then
                MSG = MSG + 1
                GR1 = 0 And GR2 = 0 And GR3 = 0 And GR4 = 0
                RT = True
                PuestoRojo.Enabled = False
                PuestoRojo.BackgroundImage = My.Resources.CORONA3
                Fin.Enabled = False
                Fin.BackgroundImage = My.Resources.FIN
                H = 1
                If RT = False Then
                    PuestoRojo.BackgroundImage = My.Resources.CORONA4
                ElseIf VT = False Then
                    PuestoVerde.BackgroundImage = My.Resources.CORONA4
                ElseIf AmT = False Then
                    PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
                ElseIf AT = False Then
                    PuestoAzul.BackgroundImage = My.Resources.CORONA4
                End If
                Rojo1.Hide()
                Rojo2.Hide()
                Rojo3.Hide()
                Rojo4.Hide()
                Verde1.Hide()
                Verde2.Hide()
                Verde3.Hide()
                Verde4.Hide()
                Amarillo1.Hide()
                Amarillo2.Hide()
                Amarillo3.Hide()
                Amarillo4.Hide()
                Azul1.Hide()
                Azul2.Hide()
                Azul3.Hide()
                Azul4.Hide()
                ContCom = 0
                desabilitarTirar(Tirar)
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            End If
        End If
        If (n = 6 And a < 3 Or ContCom = 1) And RT = False Then
            CambiarDado()
            If ContCom = 1 Then
                a = a - 1
                ContCom = 0
                If H = 1 Then
                    desabilitarTirar(Tirar)
                ElseIf z < 1 And n <> 6 And GR1 = 1 Then
                    habilitarTirar(Tirar)
                    deshabilitarFichas(Rojo2, Rojo2, Rojo3, Rojo4)
                ElseIf z > 0 Or n = 6 Then
                    desabilitarTirar(Tirar)
                    habilitarFichas(Rojo2, Rojo2, Rojo3, Rojo4)
                End If
            End If
        ElseIf a = 3 Or RT = True Or H = 1 Then
            If H = 1 Then
                desabilitarTirar(Tirar)
            End If
            deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
            habilitarTirar(Tirar)
        End If
        ''msgbox("x:" + Rojo1.Location.X.ToString + " " + "y:" + Rojo1.Location.Y.ToString)



        'deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
    End Sub

    Private Sub Rojo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rojo2.Click

        c = 1

        If Rojo2.Top = 424 And Rojo2.Left = 137 And n = 6 Then
            Salir(Rojo2, n)
            a = a + 1
        ElseIf Rojo2.Top <> 424 And Rojo2.Left <> 137 And GR2 = 0 Then
            Movimiento(Rojo2, n)
            pos = colision_posiciones(Rojo2)
            a = a + 1
            If pos = False Then
                fichas_colision_comer(Rojo2, Verde1, Verde2, Verde3, Verde4, Amarillo1, Amarillo2, Amarillo3, Amarillo4, Azul1, Azul2, Azul3, Azul4)
            End If
            If n < 6 And a < 3 And ContCom = 0 Then
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                habilitarTirar(Tirar)
            End If
        End If
        If Rojo2.Top > 330 And Rojo2.Top < 370 And Rojo2.Left = 239 Then
            Rojo2.Top = 347
            Rojo2.Left = 231
            deshabilitarFichas(Rojo2, Rojo2, Rojo2, Rojo2)
            GR2 = 1
            ContCom = 1
            z = z - 1
            If GR1 = 1 And GR2 = 1 And GR3 = 1 And GR4 = 1 And MSG = 0 Then

                MSG = MSG + 1
                GR1 = 0 And GR2 = 0 And GR3 = 0 And GR4 = 0
                RT = True
                PuestoRojo.Enabled = False
                PuestoRojo.BackgroundImage = My.Resources.CORONA11
                ContCom = 0
                If CJ = 1 Then
                    Fin.Enabled = False
                    Fin.BackgroundImage = My.Resources.FIN
                    If RT = False Then
                        PuestoRojo.BackgroundImage = My.Resources.CORONA2
                    ElseIf AmT = False Then
                        PuestoAmarillo.BackgroundImage = My.Resources.CORONA2
                    End If
                    Rojo1.Hide()
                    Rojo2.Hide()
                    Rojo3.Hide()
                    Rojo4.Hide()
                    Amarillo1.Hide()
                    Amarillo2.Hide()
                    Amarillo3.Hide()
                    Amarillo4.Hide()
                    ContCom = 0
                    desabilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                    deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                    deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                    deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                End If
            ElseIf GR1 = 1 And GR2 = 1 And GR3 = 1 And GR4 = 1 And MSG = 1 Then
                MSG = MSG + 1
                GR1 = 0 And GR2 = 0 And GR3 = 0 And GR4 = 0
                RT = True
                PuestoRojo.Enabled = False
                PuestoRojo.BackgroundImage = My.Resources.CORONA2
                ContCom = 0
            ElseIf GR1 = 1 And GR2 = 1 And GR3 = 1 And GR4 = 1 And MSG = 2 Then
                MSG = MSG + 1
                GR1 = 0 And GR2 = 0 And GR3 = 0 And GR4 = 0
                RT = True
                PuestoRojo.Enabled = False
                PuestoRojo.BackgroundImage = My.Resources.CORONA3
                Fin.Enabled = False
                Fin.BackgroundImage = My.Resources.FIN
                H = 1
                If RT = False Then
                    PuestoRojo.BackgroundImage = My.Resources.CORONA4
                ElseIf VT = False Then
                    PuestoVerde.BackgroundImage = My.Resources.CORONA4
                ElseIf AmT = False Then
                    PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
                ElseIf AT = False Then
                    PuestoAzul.BackgroundImage = My.Resources.CORONA4
                End If
                Rojo1.Hide()
                Rojo2.Hide()
                Rojo3.Hide()
                Rojo4.Hide()
                Verde1.Hide()
                Verde2.Hide()
                Verde3.Hide()
                Verde4.Hide()
                Amarillo1.Hide()
                Amarillo2.Hide()
                Amarillo3.Hide()
                Amarillo4.Hide()
                Azul1.Hide()
                Azul2.Hide()
                Azul3.Hide()
                Azul4.Hide()
                ContCom = 0
                desabilitarTirar(Tirar)
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            End If
        End If
        If (n = 6 And a < 3 Or ContCom = 1) And RT = False Then
            CambiarDado()
            If ContCom = 1 Then
                a = a - 1
                ContCom = 0
                If H = 1 Then
                    desabilitarTirar(Tirar)
                ElseIf z < 1 And n <> 6 And GR2 = 1 Then
                    habilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo1, Rojo3, Rojo4)
                ElseIf z > 0 Or n = 6 Then
                    desabilitarTirar(Tirar)
                    habilitarFichas(Rojo1, Rojo1, Rojo3, Rojo4)
                End If
            End If
        ElseIf a = 3 Or RT = True Or H = 1 Then
            If H = 1 Then
                desabilitarTirar(Tirar)
            End If
            deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
            habilitarTirar(Tirar)
        End If
        'deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
    End Sub

    Private Sub Rojo3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rojo3.Click

        c = 1

        If Rojo3.Top = 475 And Rojo3.Left = 76 And n = 6 Then
            Salir(Rojo3, n)
            a = a + 1
        ElseIf Rojo3.Top <> 475 And Rojo3.Left <> 76 And GR3 = 0 Then
            Movimiento(Rojo3, n)
            pos = colision_posiciones(Rojo3)
            a = a + 1
            If pos = False Then
                fichas_colision_comer(Rojo3, Verde1, Verde2, Verde3, Verde4, Amarillo1, Amarillo2, Amarillo3, Amarillo4, Azul1, Azul2, Azul3, Azul4)
            End If
            If n < 6 And a < 3 And ContCom = 0 Then
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                habilitarTirar(Tirar)
            End If
        End If
        If Rojo3.Top > 330 And Rojo3.Top < 370 And Rojo3.Left = 239 Then
            Rojo3.Top = 347
            Rojo3.Left = 249
            deshabilitarFichas(Rojo3, Rojo3, Rojo3, Rojo3)
            GR3 = 1
            ContCom = 1
            z = z - 1
            If GR1 = 1 And GR2 = 1 And GR3 = 1 And GR4 = 1 And MSG = 0 Then

                MSG = MSG + 1
                GR1 = 0 And GR2 = 0 And GR3 = 0 And GR4 = 0
                RT = True
                PuestoRojo.Enabled = False
                PuestoRojo.BackgroundImage = My.Resources.CORONA11
                ContCom = 0
                If CJ = 1 Then
                    Fin.Enabled = False
                    Fin.BackgroundImage = My.Resources.FIN
                    If RT = False Then
                        PuestoRojo.BackgroundImage = My.Resources.CORONA2
                    ElseIf AmT = False Then
                        PuestoAmarillo.BackgroundImage = My.Resources.CORONA2
                    End If
                    Rojo1.Hide()
                    Rojo2.Hide()
                    Rojo3.Hide()
                    Rojo4.Hide()
                    Amarillo1.Hide()
                    Amarillo2.Hide()
                    Amarillo3.Hide()
                    Amarillo4.Hide()
                    ContCom = 0
                    desabilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                    deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                    deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                    deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                End If
            ElseIf GR1 = 1 And GR2 = 1 And GR3 = 1 And GR4 = 1 And MSG = 1 Then
                MSG = MSG + 1
                GR1 = 0 And GR2 = 0 And GR3 = 0 And GR4 = 0
                RT = True
                PuestoRojo.Enabled = False
                PuestoRojo.BackgroundImage = My.Resources.CORONA2
                ContCom = 0
            ElseIf GR1 = 1 And GR2 = 1 And GR3 = 1 And GR4 = 1 And MSG = 2 Then
                MSG = MSG + 1
                GR1 = 0 And GR2 = 0 And GR3 = 0 And GR4 = 0
                RT = True
                PuestoRojo.Enabled = False
                PuestoRojo.BackgroundImage = My.Resources.CORONA3
                Fin.Enabled = False
                Fin.BackgroundImage = My.Resources.FIN
                H = 1
                If RT = False Then
                    PuestoRojo.BackgroundImage = My.Resources.CORONA4
                ElseIf VT = False Then
                    PuestoVerde.BackgroundImage = My.Resources.CORONA4
                ElseIf AmT = False Then
                    PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
                ElseIf AT = False Then
                    PuestoAzul.BackgroundImage = My.Resources.CORONA4
                End If
                Rojo1.Hide()
                Rojo2.Hide()
                Rojo3.Hide()
                Rojo4.Hide()
                Verde1.Hide()
                Verde2.Hide()
                Verde3.Hide()
                Verde4.Hide()
                Amarillo1.Hide()
                Amarillo2.Hide()
                Amarillo3.Hide()
                Amarillo4.Hide()
                Azul1.Hide()
                Azul2.Hide()
                Azul3.Hide()
                Azul4.Hide()
                ContCom = 0
                desabilitarTirar(Tirar)
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            End If
        End If
        If (n = 6 And a < 3 Or ContCom = 1) And RT = False Then
            CambiarDado()
            If ContCom = 1 Then
                a = a - 1
                ContCom = 0
            End If
        ElseIf a = 3 Or RT = True Or H = 1 Then
            If H = 1 Then
                desabilitarTirar(Tirar)
            End If
            deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
            habilitarTirar(Tirar)
        End If
        'deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
    End Sub

    Private Sub Rojo4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rojo4.Click

        c = 1

        If Rojo4.Top = 475 And Rojo4.Left = 137 And n = 6 Then
            Salir(Rojo4, n)
            a = a + 1
        ElseIf Rojo4.Top <> 475 And Rojo4.Left <> 137 And GR4 = 0 Then
            Movimiento(Rojo4, n)
            pos = colision_posiciones(Rojo4)
            a = a + 1
            If pos = False Then
                fichas_colision_comer(Rojo4, Verde1, Verde2, Verde3, Verde4, Amarillo1, Amarillo2, Amarillo3, Amarillo4, Azul1, Azul2, Azul3, Azul4)
            End If
            If n < 6 And a < 3 And ContCom = 0 Then
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                habilitarTirar(Tirar)
            End If
        End If
        If Rojo4.Top > 330 And Rojo4.Top < 370 And Rojo4.Left = 239 Then
            Rojo4.Top = 358
            Rojo4.Left = 260
            deshabilitarFichas(Rojo4, Rojo4, Rojo4, Rojo4)
            GR4 = 1
            ContCom = 1
            z = z - 1
            If GR1 = 1 And GR2 = 1 And GR3 = 1 And GR4 = 1 And MSG = 0 Then

                MSG = MSG + 1
                GR1 = 0 And GR2 = 0 And GR3 = 0 And GR4 = 0
                RT = True
                PuestoRojo.Enabled = False
                PuestoRojo.BackgroundImage = My.Resources.CORONA11
                ContCom = 0
                If CJ = 1 Then
                    Fin.Enabled = False
                    Fin.BackgroundImage = My.Resources.FIN
                    If RT = False Then
                        PuestoRojo.BackgroundImage = My.Resources.CORONA2
                    ElseIf AmT = False Then
                        PuestoAmarillo.BackgroundImage = My.Resources.CORONA2
                    End If
                    Rojo1.Hide()
                    Rojo2.Hide()
                    Rojo3.Hide()
                    Rojo4.Hide()
                    Amarillo1.Hide()
                    Amarillo2.Hide()
                    Amarillo3.Hide()
                    Amarillo4.Hide()
                    ContCom = 0
                    desabilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                    deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                    deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                    deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                End If
            ElseIf GR1 = 1 And GR2 = 1 And GR3 = 1 And GR4 = 1 And MSG = 1 Then
                MSG = MSG + 1
                GR1 = 0 And GR2 = 0 And GR3 = 0 And GR4 = 0
                RT = True
                PuestoRojo.Enabled = False
                PuestoRojo.BackgroundImage = My.Resources.CORONA2
                ContCom = 0
            ElseIf GR1 = 1 And GR2 = 1 And GR3 = 1 And GR4 = 1 And MSG = 2 Then
                MSG = MSG + 1
                GR1 = 0 And GR2 = 0 And GR3 = 0 And GR4 = 0
                RT = True
                PuestoRojo.Enabled = False
                PuestoRojo.BackgroundImage = My.Resources.CORONA3
                Fin.Enabled = False
                Fin.BackgroundImage = My.Resources.FIN
                H = 1
                If RT = False Then
                    PuestoRojo.BackgroundImage = My.Resources.CORONA4
                ElseIf VT = False Then
                    PuestoVerde.BackgroundImage = My.Resources.CORONA4
                ElseIf AmT = False Then
                    PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
                ElseIf AT = False Then
                    PuestoAzul.BackgroundImage = My.Resources.CORONA4
                End If
                Rojo1.Hide()
                Rojo2.Hide()
                Rojo3.Hide()
                Rojo4.Hide()
                Verde1.Hide()
                Verde2.Hide()
                Verde3.Hide()
                Verde4.Hide()
                Amarillo1.Hide()
                Amarillo2.Hide()
                Amarillo3.Hide()
                Amarillo4.Hide()
                Azul1.Hide()
                Azul2.Hide()
                Azul3.Hide()
                Azul4.Hide()
                ContCom = 0
                desabilitarTirar(Tirar)
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            End If
        End If
        If (n = 6 And a < 3 Or ContCom = 1) And RT = False Then
            CambiarDado()
            If ContCom = 1 Then
                a = a - 1
                ContCom = 0
                If H = 1 Then
                    desabilitarTirar(Tirar)
                ElseIf z < 1 And n <> 6 And GR4 = 1 Then
                    habilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo1, Rojo2, Rojo3)
                ElseIf z > 0 Or n = 6 And RT = False Then
                    desabilitarTirar(Tirar)
                    habilitarFichas(Rojo1, Rojo1, Rojo2, Rojo3)
                End If
            End If
        ElseIf a = 3 Or RT = True Or H = 1 Then
            If H = 1 Then
                desabilitarTirar(Tirar)
            End If
            deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
            habilitarTirar(Tirar)
        End If
        ' deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
    End Sub

    Private Sub Verde1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Verde1.Click

        c = 2
        If Verde1.Top = 181 And Verde1.Left = 76 And n = 6 Then
            Salir(Verde1, n)
            a = a + 1
        ElseIf Verde1.Top <> 181 And Verde1.Left <> 76 And GV1 = 0 Then
            Movimiento(Verde1, n)
            pos = colision_posiciones(Verde1)
            a = a + 1
            If pos = False Then
                fichas_colision_comer(Verde1, Rojo1, Rojo2, Rojo3, Rojo4, Amarillo1, Amarillo2, Amarillo3, Amarillo4, Azul1, Azul2, Azul3, Azul4)
            End If
            ' 'msgbox("x:" + Verde1.Location.X.ToString + " " + "y:" + Verde1.Location.Y.ToString)
            If n < 6 And a < 3 And ContCom = 0 Then
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                habilitarTirar(Tirar)
            End If
        End If
        If Verde1.Top = 327 And Verde1.Left > 195 And Verde1.Left < 240 Then
            Verde1.Top = 308
            Verde1.Left = 206
            deshabilitarFichas(Verde1, Verde1, Verde1, Verde1)
            GV1 = 1
            ContCom = 1
            z = z - 1
            Verde1.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAVERDERotado.png")
            If GV1 = 1 And GV2 = 1 And GV3 = 1 And GV4 = 1 And MSG = 0 Then
                MSG = MSG + 1
                GV1 = 0 And GV2 = 0 And GV3 = 0 And GV4 = 0
                VT = True
                PuestoVerde.Enabled = False
                PuestoVerde.BackgroundImage = My.Resources.CORONA11
                ContCom = 0
                If CJ = 2 Then
                    Fin.Enabled = False
                    Fin.BackgroundImage = My.Resources.FIN
                    If VT = False Then
                        PuestoVerde.BackgroundImage = My.Resources.CORONA2
                    ElseIf AT = False Then
                        PuestoAzul.BackgroundImage = My.Resources.CORONA2
                    End If
                    Verde1.Hide()
                    Verde2.Hide()
                    Verde3.Hide()
                    Verde4.Hide()
                    Azul1.Hide()
                    Azul2.Hide()
                    Azul3.Hide()
                    Azul4.Hide()
                    ContCom = 0
                    desabilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                    deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                    deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                    deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                End If
            ElseIf GV1 = 1 And GV2 = 1 And GV3 = 1 And GV4 = 1 And MSG = 1 Then

                MSG = MSG + 1
                GV1 = 0 And GV2 = 0 And GV3 = 0 And GV4 = 0
                VT = True
                PuestoVerde.Enabled = False
                PuestoVerde.BackgroundImage = My.Resources.CORONA2
                ContCom = 0
            ElseIf GV1 = 1 And GV2 = 1 And GV3 = 1 And GV4 = 1 And MSG = 2 Then
                MSG = MSG + 1
                GV1 = 0 And GV2 = 0 And GV3 = 0 And GV4 = 0
                VT = True
                PuestoVerde.Enabled = False
                PuestoVerde.BackgroundImage = My.Resources.CORONA3
                Fin.Enabled = False
                Fin.BackgroundImage = My.Resources.FIN
                H = 1
                If RT = False Then
                    PuestoRojo.BackgroundImage = My.Resources.CORONA4
                ElseIf VT = False Then
                    PuestoVerde.BackgroundImage = My.Resources.CORONA4
                ElseIf AmT = False Then
                    PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
                ElseIf AT = False Then
                    PuestoAzul.BackgroundImage = My.Resources.CORONA4
                End If
                Rojo1.Hide()
                Rojo2.Hide()
                Rojo3.Hide()
                Rojo4.Hide()
                Verde1.Hide()
                Verde2.Hide()
                Verde3.Hide()
                Verde4.Hide()
                Amarillo1.Hide()
                Amarillo2.Hide()
                Amarillo3.Hide()
                Amarillo4.Hide()
                Azul1.Hide()
                Azul2.Hide()
                Azul3.Hide()
                Azul4.Hide()
                ContCom = 0
                desabilitarTirar(Tirar)
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            ElseIf H = 1 Then
                PuestoVerde.BackgroundImage = My.Resources.CORONA4
            End If
        End If
        If (n = 6 And a < 3 Or ContCom = 1) And VT = False Then
            CambiarDado()
            If ContCom = 1 Then
                a = a - 1
                ContCom = 0
                If H = 1 Then
                    desabilitarTirar(Tirar)
                ElseIf z < 1 And n <> 6 And GV1 = 1 Then
                    habilitarTirar(Tirar)
                    deshabilitarFichas(Verde2, Verde2, Verde3, Verde4)
                ElseIf z > 1 Or n = 6 Then
                    desabilitarTirar(Tirar)
                    habilitarFichas(Verde2, Verde2, Verde3, Verde4)
                End If
            End If
        ElseIf a = 3 Or VT = True Or H = 1 Then
            If H = 1 Then
                desabilitarTirar(Tirar)
            End If
            deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
            habilitarTirar(Tirar)
        End If
        ' deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
    End Sub

    Private Sub Verde2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Verde2.Click

        c = 2

        If Verde2.Top = 181 And Verde2.Left = 137 And n = 6 Then
            Salir(Verde2, n)
            a = a + 1
        ElseIf Verde2.Top <> 181 And Verde2.Left <> 137 And GV2 = 0 Then
            Movimiento(Verde2, n)
            pos = colision_posiciones(Verde2)
            a = a + 1
            If pos = False Then
                fichas_colision_comer(Verde2, Rojo1, Rojo2, Rojo3, Rojo4, Amarillo1, Amarillo2, Amarillo3, Amarillo4, Azul1, Azul2, Azul3, Azul4)
            End If
            If n < 6 And a < 3 And ContCom = 0 Then
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                habilitarTirar(Tirar)
            End If
        End If
        If Verde2.Top = 327 And Verde2.Left > 195 And Verde2.Left < 240 Then
            Verde2.Top = 320
            Verde2.Left = 217
            deshabilitarFichas(Verde2, Verde2, Verde2, Verde2)
            GV2 = 1
            ContCom = 1
            z = z - 1
            Verde2.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAVERDERotado.png")
            If GV1 = 1 And GV2 = 1 And GV3 = 1 And GV4 = 1 And MSG = 0 Then
                MSG = MSG + 1
                GV1 = 0 And GV2 = 0 And GV3 = 0 And GV4 = 0
                VT = True
                PuestoVerde.Enabled = False
                PuestoVerde.BackgroundImage = My.Resources.CORONA11
                ContCom = 0
                If CJ = 2 Then
                    Fin.Enabled = False
                    Fin.BackgroundImage = My.Resources.FIN
                    If VT = False Then
                        PuestoVerde.BackgroundImage = My.Resources.CORONA2
                    ElseIf AT = False Then
                        PuestoAzul.BackgroundImage = My.Resources.CORONA2
                    End If
                    Verde1.Hide()
                    Verde2.Hide()
                    Verde3.Hide()
                    Verde4.Hide()
                    Azul1.Hide()
                    Azul2.Hide()
                    Azul3.Hide()
                    Azul4.Hide()
                    ContCom = 0
                    desabilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                    deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                    deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                    deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                End If
            ElseIf GV1 = 1 And GV2 = 1 And GV3 = 1 And GV4 = 1 And MSG = 1 Then
                MSG = MSG + 1
                GV1 = 0 And GV2 = 0 And GV3 = 0 And GV4 = 0
                VT = True
                PuestoVerde.Enabled = False
                PuestoVerde.BackgroundImage = My.Resources.CORONA2
                ContCom = 0
            ElseIf GV1 = 1 And GV2 = 1 And GV3 = 1 And GV4 = 1 And MSG = 2 Then
                MSG = MSG + 1
                GV1 = 0 And GV2 = 0 And GV3 = 0 And GV4 = 0
                VT = True
                PuestoVerde.Enabled = False
                PuestoVerde.BackgroundImage = My.Resources.CORONA3
                Fin.Enabled = False
                Fin.BackgroundImage = My.Resources.FIN
                H = 1
                If RT = False Then
                    PuestoRojo.BackgroundImage = My.Resources.CORONA4
                ElseIf VT = False Then
                    PuestoVerde.BackgroundImage = My.Resources.CORONA4
                ElseIf AmT = False Then
                    PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
                ElseIf AT = False Then
                    PuestoAzul.BackgroundImage = My.Resources.CORONA4
                End If
                Rojo1.Hide()
                Rojo2.Hide()
                Rojo3.Hide()
                Rojo4.Hide()
                Verde1.Hide()
                Verde2.Hide()
                Verde3.Hide()
                Verde4.Hide()
                Amarillo1.Hide()
                Amarillo2.Hide()
                Amarillo3.Hide()
                Amarillo4.Hide()
                Azul1.Hide()
                Azul2.Hide()
                Azul3.Hide()
                Azul4.Hide()
                ContCom = 0
                desabilitarTirar(Tirar)
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            ElseIf H = 1 Then
                PuestoVerde.BackgroundImage = My.Resources.CORONA4
            End If
        End If
        If (n = 6 And a < 3 Or ContCom = 1) And VT = False Then
            CambiarDado()
            If ContCom = 1 Then
                a = a - 1
                ContCom = 0
                If H = 1 Then
                    desabilitarTirar(Tirar)
                ElseIf z < 1 And n <> 6 And GV2 = 1 Then
                    habilitarTirar(Tirar)
                    deshabilitarFichas(Verde1, Verde1, Verde3, Verde4)
                ElseIf z > 0 Or n = 6 Then
                    desabilitarTirar(Tirar)
                    habilitarFichas(Verde1, Verde1, Verde3, Verde4)
                End If
            End If
        ElseIf a = 3 Or VT = True Or H = 1 Then
            If H = 1 Then
                desabilitarTirar(Tirar)
            End If
            deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
            habilitarTirar(Tirar)
        End If
        'deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
    End Sub

    Private Sub Verde3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Verde3.Click
        c = 2

        If Verde3.Top = 231 And Verde3.Left = 76 And n = 6 Then
            Salir(Verde3, n)
            a = a + 1
        ElseIf Verde3.Top <> 231 And Verde3.Left <> 76 And GV3 = 0 Then
            Movimiento(Verde3, n)
            pos = colision_posiciones(Verde3)
            a = a + 1
            If pos = False Then
                fichas_colision_comer(Verde3, Rojo1, Rojo2, Rojo3, Rojo4, Amarillo1, Amarillo2, Amarillo3, Amarillo4, Azul1, Azul2, Azul3, Azul4)
            End If
            If n < 6 And a < 3 And ContCom = 0 Then
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                habilitarTirar(Tirar)
            End If
        End If
        If Verde3.Top = 327 And Verde3.Left > 195 And Verde3.Left < 240 Then
            Verde3.Top = 335
            Verde3.Left = 217
            deshabilitarFichas(Verde3, Verde3, Verde3, Verde3)
            GV3 = 1
            ContCom = 1
            z = z - 1
            Verde3.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAVERDERotado.png")
            If GV1 = 1 And GV2 = 1 And GV3 = 1 And GV4 = 1 And MSG = 0 Then
                MSG = MSG + 1
                GV1 = 0 And GV2 = 0 And GV3 = 0 And GV4 = 0
                VT = True
                PuestoVerde.Enabled = False
                PuestoVerde.BackgroundImage = My.Resources.CORONA11
                ContCom = 0
                If CJ = 2 Then
                    Fin.Enabled = False
                    Fin.BackgroundImage = My.Resources.FIN
                    If VT = False Then
                        PuestoVerde.BackgroundImage = My.Resources.CORONA2
                    ElseIf AT = False Then
                        PuestoAzul.BackgroundImage = My.Resources.CORONA2
                    End If
                    Verde1.Hide()
                    Verde2.Hide()
                    Verde3.Hide()
                    Verde4.Hide()
                    Azul1.Hide()
                    Azul2.Hide()
                    Azul3.Hide()
                    Azul4.Hide()
                    ContCom = 0
                    desabilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                    deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                    deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                    deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                End If
            ElseIf GV1 = 1 And GV2 = 1 And GV3 = 1 And GV4 = 1 And MSG = 1 Then
                MSG = MSG + 1
                GV1 = 0 And GV2 = 0 And GV3 = 0 And GV4 = 0
                VT = True
                PuestoVerde.Enabled = False
                PuestoVerde.BackgroundImage = My.Resources.CORONA2
                ContCom = 0
            ElseIf GV1 = 1 And GV2 = 1 And GV3 = 1 And GV4 = 1 And MSG = 2 Then
                MSG = MSG + 1
                GV1 = 0 And GV2 = 0 And GV3 = 0 And GV4 = 0
                VT = True
                PuestoVerde.Enabled = False
                PuestoVerde.BackgroundImage = My.Resources.CORONA3
                Fin.Enabled = False
                Fin.BackgroundImage = My.Resources.FIN
                H = 1
                If RT = False Then
                    PuestoRojo.BackgroundImage = My.Resources.CORONA4
                ElseIf VT = False Then
                    PuestoVerde.BackgroundImage = My.Resources.CORONA4
                ElseIf AmT = False Then
                    PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
                ElseIf AT = False Then
                    PuestoAzul.BackgroundImage = My.Resources.CORONA4
                End If
                Rojo1.Hide()
                Rojo2.Hide()
                Rojo3.Hide()
                Rojo4.Hide()
                Verde1.Hide()
                Verde2.Hide()
                Verde3.Hide()
                Verde4.Hide()
                Amarillo1.Hide()
                Amarillo2.Hide()
                Amarillo3.Hide()
                Amarillo4.Hide()
                Azul1.Hide()
                Azul2.Hide()
                Azul3.Hide()
                Azul4.Hide()
                ContCom = 0
                desabilitarTirar(Tirar)
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            ElseIf H = 1 Then
                PuestoVerde.BackgroundImage = My.Resources.CORONA4
            End If
        End If
        If (n = 6 And a < 3 Or ContCom = 1) And VT = False Then
            CambiarDado()
            If ContCom = 1 Then
                a = a - 1
                ContCom = 0
                If H = 1 Then
                    desabilitarTirar(Tirar)
                ElseIf z < 1 And n <> 6 And GV3 = 1 Then
                    habilitarTirar(Tirar)
                    deshabilitarFichas(Verde1, Verde1, Verde2, Verde4)
                ElseIf z > 0 Or n = 6 Then
                    desabilitarTirar(Tirar)
                    habilitarFichas(Verde1, Verde1, Verde2, Verde4)
                End If
            End If
        ElseIf a = 3 Or VT = True Or H = 1 Then
            If H = 1 Then
                desabilitarTirar(Tirar)
            End If
            deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
            habilitarTirar(Tirar)
        End If
        'deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
    End Sub

    Private Sub Verde4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Verde4.Click

        c = 2

        If Verde4.Top = 231 And Verde4.Left = 137 And n = 6 Then
            Salir(Verde4, n)
            a = a + 1
        ElseIf Verde4.Top <> 231 And Verde4.Left <> 137 And GV4 = 0 Then
            Movimiento(Verde4, n)
            pos = colision_posiciones(Verde4)
            a = a + 1
            If pos = False Then
                fichas_colision_comer(Verde4, Rojo1, Rojo2, Rojo3, Rojo4, Amarillo1, Amarillo2, Amarillo3, Amarillo4, Azul1, Azul2, Azul3, Azul4)
            End If
            If n < 6 And a < 3 And ContCom = 0 Then
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                habilitarTirar(Tirar)
            End If
        End If
        If Verde4.Top = 327 And Verde4.Left > 195 And Verde4.Left < 240 Then
            Verde4.Top = 346
            Verde4.Left = 206
            deshabilitarFichas(Verde4, Verde4, Verde4, Verde4)
            GV4 = 1
            ContCom = 1
            z = z - 1
            Verde4.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAVERDERotado.png")
            If GV1 = 1 And GV2 = 1 And GV3 = 1 And GV4 = 1 And MSG = 0 Then
                MSG = MSG + 1
                GV1 = 0 And GV2 = 0 And GV3 = 0 And GV4 = 0
                VT = True
                PuestoVerde.Enabled = False
                PuestoVerde.BackgroundImage = My.Resources.CORONA11
                ContCom = 0
                If CJ = 2 Then
                    Fin.Enabled = False
                    Fin.BackgroundImage = My.Resources.FIN
                    If VT = False Then
                        PuestoVerde.BackgroundImage = My.Resources.CORONA2
                    ElseIf AT = False Then
                        PuestoAzul.BackgroundImage = My.Resources.CORONA2
                    End If
                    Verde1.Hide()
                    Verde2.Hide()
                    Verde3.Hide()
                    Verde4.Hide()
                    Azul1.Hide()
                    Azul2.Hide()
                    Azul3.Hide()
                    Azul4.Hide()
                    ContCom = 0
                    desabilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                    deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                    deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                    deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                End If
            ElseIf GV1 = 1 And GV2 = 1 And GV3 = 1 And GV4 = 1 And MSG = 1 Then

                MSG = MSG + 1
                GV1 = 0 And GV2 = 0 And GV3 = 0 And GV4 = 0
                VT = True
                PuestoVerde.Enabled = False
                PuestoVerde.BackgroundImage = My.Resources.CORONA2
                ContCom = 0
            ElseIf GV1 = 1 And GV2 = 1 And GV3 = 1 And GV4 = 1 And MSG = 2 Then

                MSG = MSG + 1
                GV1 = 0 And GV2 = 0 And GV3 = 0 And GV4 = 0
                VT = True
                PuestoVerde.Enabled = False
                PuestoVerde.BackgroundImage = My.Resources.CORONA3
                Fin.Enabled = False
                Fin.BackgroundImage = My.Resources.FIN
                H = 1
                If RT = False Then
                    PuestoRojo.BackgroundImage = My.Resources.CORONA4
                ElseIf VT = False Then
                    PuestoVerde.BackgroundImage = My.Resources.CORONA4
                ElseIf AmT = False Then
                    PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
                ElseIf AT = False Then
                    PuestoAzul.BackgroundImage = My.Resources.CORONA4
                End If
                Rojo1.Hide()
                Rojo2.Hide()
                Rojo3.Hide()
                Rojo4.Hide()
                Verde1.Hide()
                Verde2.Hide()
                Verde3.Hide()
                Verde4.Hide()
                Amarillo1.Hide()
                Amarillo2.Hide()
                Amarillo3.Hide()
                Amarillo4.Hide()
                Azul1.Hide()
                Azul2.Hide()
                Azul3.Hide()
                Azul4.Hide()
                ContCom = 0
                desabilitarTirar(Tirar)
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            ElseIf H = 1 Then
                PuestoVerde.BackgroundImage = My.Resources.CORONA4
            End If
        End If
        If (n = 6 And a < 3 Or ContCom = 1) And VT = False Then
            CambiarDado()
            If ContCom = 1 Then
                a = a - 1
                ContCom = 0
                If H = 1 Then
                    desabilitarTirar(Tirar)
                ElseIf z < 1 And n <> 6 And GV4 = 1 Then
                    habilitarTirar(Tirar)
                    deshabilitarFichas(Verde1, Verde1, Verde2, Verde3)
                ElseIf z > 0 Or n = 6 Then
                    desabilitarTirar(Tirar)
                    habilitarFichas(Verde1, Verde1, Verde2, Verde3)
                End If
            End If
        ElseIf a = 3 Or VT = True Or H = 1 Then
            If H = 1 Then
                desabilitarTirar(Tirar)
            End If
            deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
            habilitarTirar(Tirar)
        End If
        'deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
    End Sub

    ' fichitas AMARILLAS ^u^

    Private Sub Amarillo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Amarillo1.Click, PuestoAzul.Click, PuestoAmarillo.Click, PuestoAmarillo.Click, PuestoVerde.Click, Fin.Click

        c = 3

        If Amarillo1.Top = 181 And Amarillo1.Left = 342 And n = 6 Then
            Salir(Amarillo1, n)
            a = a + 1
        ElseIf Amarillo1.Top <> 181 And Amarillo1.Left <> 342 And GAm1 = 0 Then
            Movimiento(Amarillo1, n)
            pos = colision_posiciones(Amarillo1)
            a = a + 1
            If pos = False Then
                fichas_colision_comer(Amarillo1, Rojo1, Rojo2, Rojo3, Rojo4, Verde1, Verde2, Verde3, Verde4, Azul1, Azul2, Azul3, Azul4)
            End If
            If n < 6 And a < 3 And ContCom = 0 Then
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                habilitarTirar(Tirar)
            End If
        End If
        If Amarillo1.Top > 290 And Amarillo1.Top < 330 And Amarillo1.Left = 238 Then
            Amarillo1.Top = 297
            Amarillo1.Left = 260
            deshabilitarFichas(Amarillo1, Amarillo1, Amarillo1, Amarillo1)
            GAm1 = 1
            ContCom = 1
            z = z - 1
            Amarillo1.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAMARILLORotado.png")
            If GAm1 = 1 And GAm2 = 1 And GAm3 = 1 And GAm4 = 1 And MSG = 0 Then
                MSG = MSG + 1
                GAm1 = 0 And GAm2 = 0 And GAm3 = 0 And GAm4 = 0
                AmT = True
                PuestoAmarillo.Enabled = False
                PuestoAmarillo.BackgroundImage = My.Resources.CORONA11
                ContCom = 0
                If CJ = 1 Then
                    Fin.Enabled = False
                    Fin.BackgroundImage = My.Resources.FIN
                    If RT = False Then
                        PuestoRojo.BackgroundImage = My.Resources.CORONA2
                    ElseIf AmT = False Then
                        PuestoAmarillo.BackgroundImage = My.Resources.CORONA2
                    End If
                    Rojo1.Hide()
                    Rojo2.Hide()
                    Rojo3.Hide()
                    Rojo4.Hide()
                    Amarillo1.Hide()
                    Amarillo2.Hide()
                    Amarillo3.Hide()
                    Amarillo4.Hide()
                    ContCom = 0
                    desabilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                    deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                    deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                    deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                End If
            ElseIf GAm1 = 1 And GAm2 = 1 And GAm3 = 1 And GAm4 = 1 And MSG = 1 Then

                MSG = MSG + 1
                GAm1 = 0 And GAm2 = 0 And GAm3 = 0 And GAm4 = 0
                AmT = True
                PuestoAmarillo.Enabled = False
                PuestoAmarillo.BackgroundImage = My.Resources.CORONA2
                ContCom = 0
            ElseIf GAm1 = 1 And GAm2 = 1 And GAm3 = 1 And GAm4 = 1 And MSG = 2 Then

                MSG = MSG + 1
                GAm1 = 0 And GAm2 = 0 And GAm3 = 0 And GAm4 = 0
                AmT = True
                PuestoAmarillo.Enabled = False
                PuestoAmarillo.BackgroundImage = My.Resources.CORONA3
                Fin.Enabled = False
                Fin.BackgroundImage = My.Resources.FIN
                H = 1
                If RT = False Then
                    PuestoRojo.BackgroundImage = My.Resources.CORONA4
                ElseIf VT = False Then
                    PuestoVerde.BackgroundImage = My.Resources.CORONA4
                ElseIf AmT = False Then
                    PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
                ElseIf AT = False Then
                    PuestoAzul.BackgroundImage = My.Resources.CORONA4
                End If
                Rojo1.Hide()
                Rojo2.Hide()
                Rojo3.Hide()
                Rojo4.Hide()
                Verde1.Hide()
                Verde2.Hide()
                Verde3.Hide()
                Verde4.Hide()
                Amarillo1.Hide()
                Amarillo2.Hide()
                Amarillo3.Hide()
                Amarillo4.Hide()
                Azul1.Hide()
                Azul2.Hide()
                Azul3.Hide()
                Azul4.Hide()
                ContCom = 0
                desabilitarTirar(Tirar)
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            ElseIf H = 1 Then
                PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
            End If
        End If
        If (n = 6 And a < 3 Or ContCom = 1) And AmT = False Then
            CambiarDado()
            If ContCom = 1 Then
                a = a - 1
                ContCom = 0
                If H = 1 Then
                    desabilitarTirar(Tirar)
                ElseIf z < 1 And n <> 6 And GAm1 = 1 Then
                    habilitarTirar(Tirar)
                    deshabilitarFichas(Amarillo2, Amarillo2, Amarillo3, Amarillo4)
                ElseIf z > 0 Or n = 6 Then
                    desabilitarTirar(Tirar)
                    habilitarFichas(Amarillo2, Amarillo2, Amarillo3, Amarillo4)
                End If
            End If
        ElseIf a = 3 Or AmT = True Or H = 1 Then
            If H = 1 Then
                desabilitarTirar(Tirar)
            End If
            deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
            habilitarTirar(Tirar)
        End If
        ' deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
    End Sub

    Private Sub Amarillo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Amarillo2.Click

        c = 3

        If Amarillo2.Top = 181 And Amarillo2.Left = 403 And n = 6 Then
            Salir(Amarillo2, n)
            a = a + 1
        ElseIf Amarillo2.Top <> 181 And Amarillo2.Left <> 403 And GAm2 = 0 Then
            Movimiento(Amarillo2, n)
            pos = colision_posiciones(Amarillo2)
            a = a + 1
            If pos = False Then
                fichas_colision_comer(Amarillo2, Rojo1, Rojo2, Rojo3, Rojo4, Verde1, Verde2, Verde3, Verde4, Azul1, Azul2, Azul3, Azul4)
            End If
            If n < 6 And a < 3 And ContCom = 0 Then
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                habilitarTirar(Tirar)
            End If
        End If
        If Amarillo2.Top > 290 And Amarillo2.Top < 330 And Amarillo2.Left = 238 Then
            Amarillo2.Top = 307
            Amarillo2.Left = 249
            deshabilitarFichas(Amarillo2, Amarillo2, Amarillo2, Amarillo2)
            GAm2 = 1
            ContCom = 1
            z = z - 1
            Amarillo2.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAMARILLORotado.png")
            If GAm1 = 1 And GAm2 = 1 And GAm3 = 1 And GAm4 = 1 And MSG = 0 Then

                MSG = MSG + 1
                GAm1 = 0 And GAm2 = 0 And GAm3 = 0 And GAm4 = 0
                AmT = True
                PuestoAmarillo.Enabled = False
                PuestoAmarillo.BackgroundImage = My.Resources.CORONA11
                ContCom = 0
                If CJ = 1 Then
                    Fin.Enabled = False
                    Fin.BackgroundImage = My.Resources.FIN
                    If RT = False Then
                        PuestoRojo.BackgroundImage = My.Resources.CORONA2
                    ElseIf AmT = False Then
                        PuestoAmarillo.BackgroundImage = My.Resources.CORONA2
                    End If
                    Rojo1.Hide()
                    Rojo2.Hide()
                    Rojo3.Hide()
                    Rojo4.Hide()
                    Amarillo1.Hide()
                    Amarillo2.Hide()
                    Amarillo3.Hide()
                    Amarillo4.Hide()
                    ContCom = 0
                    desabilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                    deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                    deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                    deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                End If
            ElseIf GAm1 = 1 And GAm2 = 1 And GAm3 = 1 And GAm4 = 1 And MSG = 1 Then

                MSG = MSG + 1
                GAm1 = 0 And GAm2 = 0 And GAm3 = 0 And GAm4 = 0
                AmT = True
                PuestoAmarillo.Enabled = False
                PuestoAmarillo.BackgroundImage = My.Resources.CORONA2
                ContCom = 0
            ElseIf GAm1 = 1 And GAm2 = 1 And GAm3 = 1 And GAm4 = 1 And MSG = 2 Then

                MSG = MSG + 1
                GAm1 = 0 And GAm2 = 0 And GAm3 = 0 And GAm4 = 0
                AmT = True
                PuestoAmarillo.Enabled = False
                PuestoAmarillo.BackgroundImage = My.Resources.CORONA3
                Fin.Enabled = False
                Fin.BackgroundImage = My.Resources.FIN
                H = 1
                If RT = False Then
                    PuestoRojo.BackgroundImage = My.Resources.CORONA4
                ElseIf VT = False Then
                    PuestoVerde.BackgroundImage = My.Resources.CORONA4
                ElseIf AmT = False Then
                    PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
                ElseIf AT = False Then
                    PuestoAzul.BackgroundImage = My.Resources.CORONA4
                End If
                Rojo1.Hide()
                Rojo2.Hide()
                Rojo3.Hide()
                Rojo4.Hide()
                Verde1.Hide()
                Verde2.Hide()
                Verde3.Hide()
                Verde4.Hide()
                Amarillo1.Hide()
                Amarillo2.Hide()
                Amarillo3.Hide()
                Amarillo4.Hide()
                Azul1.Hide()
                Azul2.Hide()
                Azul3.Hide()
                Azul4.Hide()
                ContCom = 0
                desabilitarTirar(Tirar)
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            ElseIf H = 1 Then
                PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
            End If
        End If
        If (n = 6 And a < 3 Or ContCom = 1) And AmT = False Then
            CambiarDado()
            If ContCom = 1 Then
                a = a - 1
                ContCom = 0
                If H = 1 Then
                    desabilitarTirar(Tirar)
                ElseIf z < 1 And n <> 6 And GAm2 = 1 Then
                    habilitarTirar(Tirar)
                    deshabilitarFichas(Amarillo1, Amarillo1, Amarillo3, Amarillo4)
                ElseIf z > 0 Or n = 6 Then
                    desabilitarTirar(Tirar)
                    habilitarFichas(Amarillo1, Amarillo1, Amarillo3, Amarillo4)
                End If
            End If
        ElseIf a = 3 Or AmT = True Or H = 1 Then
            If H = 1 Then
                desabilitarTirar(Tirar)
            End If
            deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
            habilitarTirar(Tirar)
        End If
        'deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
    End Sub

    Private Sub Amarillo3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Amarillo3.Click

        c = 3

        If Amarillo3.Top = 231 And Amarillo3.Left = 342 And n = 6 Then
            Salir(Amarillo3, n)
            a = a + 1
        ElseIf Amarillo3.Top <> 231 And Amarillo3.Left <> 342 And GAm3 = 0 Then
            Movimiento(Amarillo3, n)
            pos = colision_posiciones(Amarillo3)
            a = a + 1
            If pos = False Then
                fichas_colision_comer(Amarillo3, Rojo1, Rojo2, Rojo3, Rojo4, Verde1, Verde2, Verde3, Verde4, Azul1, Azul2, Azul3, Azul4)
            End If
            If n < 6 And a < 3 And ContCom = 0 Then
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                habilitarTirar(Tirar)
            End If
        End If
        If Amarillo3.Top > 290 And Amarillo3.Top < 330 And Amarillo3.Left = 238 Then
            Amarillo3.Top = 307
            Amarillo3.Left = 231
            deshabilitarFichas(Amarillo3, Amarillo3, Amarillo3, Amarillo3)
            GAm3 = 1
            ContCom = 1
            z = z - 1
            Amarillo3.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAMARILLORotado.png")
            If GAm1 = 1 And GAm2 = 1 And GAm3 = 1 And GAm4 = 1 And MSG = 0 Then

                MSG = MSG + 1
                GAm1 = 0 And GAm2 = 0 And GAm3 = 0 And GAm4 = 0
                AmT = True
                PuestoAmarillo.Enabled = False
                PuestoAmarillo.BackgroundImage = My.Resources.CORONA11
                ContCom = 0
                If CJ = 1 Then
                    Fin.Enabled = False
                    Fin.BackgroundImage = My.Resources.FIN
                    If RT = False Then
                        PuestoRojo.BackgroundImage = My.Resources.CORONA2
                    ElseIf AmT = False Then
                        PuestoAmarillo.BackgroundImage = My.Resources.CORONA2
                    End If
                    Rojo1.Hide()
                    Rojo2.Hide()
                    Rojo3.Hide()
                    Rojo4.Hide()
                    Amarillo1.Hide()
                    Amarillo2.Hide()
                    Amarillo3.Hide()
                    Amarillo4.Hide()
                    ContCom = 0
                    desabilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                    deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                    deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                    deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                End If
            ElseIf GAm1 = 1 And GAm2 = 1 And GAm3 = 1 And GAm4 = 1 And MSG = 1 Then

                MSG = MSG + 1
                GAm1 = 0 And GAm2 = 0 And GAm3 = 0 And GAm4 = 0
                AmT = True
                PuestoAmarillo.Enabled = False
                PuestoAmarillo.BackgroundImage = My.Resources.CORONA2
                ContCom = 0
            ElseIf GAm1 = 1 And GAm2 = 1 And GAm3 = 1 And GAm4 = 1 And MSG = 2 Then

                MSG = MSG + 1
                GAm1 = 0 And GAm2 = 0 And GAm3 = 0 And GAm4 = 0
                AmT = True
                PuestoAmarillo.Enabled = False
                PuestoAmarillo.BackgroundImage = My.Resources.CORONA3
                Fin.Enabled = False
                Fin.BackgroundImage = My.Resources.FIN
                H = 1
                If RT = False Then
                    PuestoRojo.BackgroundImage = My.Resources.CORONA4
                ElseIf VT = False Then
                    PuestoVerde.BackgroundImage = My.Resources.CORONA4
                ElseIf AmT = False Then
                    PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
                ElseIf AT = False Then
                    PuestoAzul.BackgroundImage = My.Resources.CORONA4
                End If
                Rojo1.Hide()
                Rojo2.Hide()
                Rojo3.Hide()
                Rojo4.Hide()
                Verde1.Hide()
                Verde2.Hide()
                Verde3.Hide()
                Verde4.Hide()
                Amarillo1.Hide()
                Amarillo2.Hide()
                Amarillo3.Hide()
                Amarillo4.Hide()
                Azul1.Hide()
                Azul2.Hide()
                Azul3.Hide()
                Azul4.Hide()
                ContCom = 0
                desabilitarTirar(Tirar)
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            ElseIf H = 1 Then
                PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
            End If
        End If
        If (n = 6 And a < 3 Or ContCom = 1) And AmT = False Then
            CambiarDado()
            If ContCom = 1 Then
                a = a - 1
                ContCom = 0
                If H = 1 Then
                    desabilitarTirar(Tirar)
                ElseIf z < 1 And n <> 6 And GAm3 = 1 Then
                    habilitarTirar(Tirar)
                    deshabilitarFichas(Amarillo1, Amarillo1, Amarillo2, Amarillo4)
                ElseIf z > 0 Or n = 6 Then
                    desabilitarTirar(Tirar)
                    habilitarFichas(Amarillo1, Amarillo1, Amarillo2, Amarillo4)
                End If
            End If
        ElseIf a = 3 Or AmT = True Or H = 1 Then
            If H = 1 Then
                desabilitarTirar(Tirar)
            End If
            deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
            habilitarTirar(Tirar)
        End If
        'deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
    End Sub

    Private Sub Amarillo4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Amarillo4.Click

        c = 3

        If Amarillo4.Top = 231 And Amarillo4.Left = 403 And n = 6 Then
            Salir(Amarillo4, n)
            a = a + 1
        ElseIf Amarillo4.Top <> 231 And Amarillo4.Left <> 403 And GAm4 = 0 Then
            Movimiento(Amarillo4, n)
            pos = colision_posiciones(Amarillo4)
            a = a + 1
            If pos = False Then
                fichas_colision_comer(Amarillo4, Rojo1, Rojo2, Rojo3, Rojo4, Verde1, Verde2, Verde3, Verde4, Azul1, Azul2, Azul3, Azul4)
            End If
            If n < 6 And a < 3 And ContCom = 0 Then
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                habilitarTirar(Tirar)
            End If
        End If
        If Amarillo4.Top > 290 And Amarillo4.Top < 330 And Amarillo4.Left = 238 Then
            Amarillo4.Top = 297
            Amarillo4.Left = 219
            deshabilitarFichas(Amarillo4, Amarillo4, Amarillo4, Amarillo4)
            GAm4 = 1
            ContCom = 1
            z = z - 1
            Amarillo4.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAMARILLORotado.png")
            If GAm1 = 1 And GAm2 = 1 And GAm3 = 1 And GAm4 = 1 And MSG = 0 Then

                MSG = MSG + 1
                GAm1 = 0 And GAm2 = 0 And GAm3 = 0 And GAm4 = 0
                AmT = True
                PuestoAmarillo.Enabled = False
                PuestoAmarillo.BackgroundImage = My.Resources.CORONA11
                ContCom = 0
                If CJ = 1 Then
                    Fin.Enabled = False
                    Fin.BackgroundImage = My.Resources.FIN
                    If RT = False Then
                        PuestoRojo.BackgroundImage = My.Resources.CORONA2
                    ElseIf AmT = False Then
                        PuestoAmarillo.BackgroundImage = My.Resources.CORONA2
                    End If
                    Rojo1.Hide()
                    Rojo2.Hide()
                    Rojo3.Hide()
                    Rojo4.Hide()
                    Amarillo1.Hide()
                    Amarillo2.Hide()
                    Amarillo3.Hide()
                    Amarillo4.Hide()
                    ContCom = 0
                    desabilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                    deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                    deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                    deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                End If
            ElseIf GAm1 = 1 And GAm2 = 1 And GAm3 = 1 And GAm4 = 1 And MSG = 1 Then

                MSG = MSG + 1
                GAm1 = 0 And GAm2 = 0 And GAm3 = 0 And GAm4 = 0
                AmT = True
                PuestoAmarillo.Enabled = False
                PuestoAmarillo.BackgroundImage = My.Resources.CORONA2
                ContCom = 0
            ElseIf GAm1 = 1 And GAm2 = 1 And GAm3 = 1 And GAm4 = 1 And MSG = 2 Then

                MSG = MSG + 1
                GAm1 = 0 And GAm2 = 0 And GAm3 = 0 And GAm4 = 0
                AmT = True
                PuestoAmarillo.Enabled = False
                PuestoAmarillo.BackgroundImage = My.Resources.CORONA3
                Fin.Enabled = False
                Fin.BackgroundImage = My.Resources.FIN
                H = 1
                If RT = False Then
                    PuestoRojo.BackgroundImage = My.Resources.CORONA4
                ElseIf VT = False Then
                    PuestoVerde.BackgroundImage = My.Resources.CORONA4
                ElseIf AmT = False Then
                    PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
                ElseIf AT = False Then
                    PuestoAzul.BackgroundImage = My.Resources.CORONA4
                End If
                Rojo1.Hide()
                Rojo2.Hide()
                Rojo3.Hide()
                Rojo4.Hide()
                Verde1.Hide()
                Verde2.Hide()
                Verde3.Hide()
                Verde4.Hide()
                Amarillo1.Hide()
                Amarillo2.Hide()
                Amarillo3.Hide()
                Amarillo4.Hide()
                Azul1.Hide()
                Azul2.Hide()
                Azul3.Hide()
                Azul4.Hide()
                ContCom = 0
                desabilitarTirar(Tirar)
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            ElseIf H = 1 Then
                PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
            End If
        End If
        If (n = 6 And a < 3 Or ContCom = 1) And AmT = False Then
            CambiarDado()
            If ContCom = 1 Then
                a = a - 1
                ContCom = 0
                If H = 1 Then
                    desabilitarTirar(Tirar)
                ElseIf z < 1 And n <> 6 And GAm4 = 1 Then
                    habilitarTirar(Tirar)
                    deshabilitarFichas(Amarillo1, Amarillo1, Amarillo2, Amarillo3)
                ElseIf z > 0 Or n = 6 Then
                    desabilitarTirar(Tirar)
                    habilitarFichas(Amarillo1, Amarillo1, Amarillo2, Amarillo3)
                End If
            End If
        ElseIf a = 3 Or AmT = True Or H = 1 Then
            If H = 1 Then
                desabilitarTirar(Tirar)
            End If
            deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
            habilitarTirar(Tirar)
        End If
        'deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
    End Sub

    ' fichitas AZULES n.n

    Private Sub Azul1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Azul1.Click

        c = 4

        If Azul1.Top = 424 And Azul1.Left = 342 And n = 6 Then
            Salir(Azul1, n)
            a = a + 1
        ElseIf Azul1.Top <> 424 And Azul1.Left <> 342 And GA1 = 0 Then
            Movimiento(Azul1, n)
            pos = colision_posiciones(Azul1)
            a = a + 1
            If pos = False Then
                fichas_colision_comer(Azul1, Rojo1, Rojo2, Rojo3, Rojo4, Verde1, Verde2, Verde3, Verde4, Amarillo1, Amarillo2, Amarillo3, Amarillo4)
            End If
            If n < 6 And a < 3 And ContCom = 0 Then
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                habilitarTirar(Tirar)
            End If
        End If
        If Azul1.Top = 328 And Azul1.Left < 285 And Azul1.Left > 240 Then
            Azul1.Top = 347
            Azul1.Left = 273
            deshabilitarFichas(Azul1, Azul1, Azul1, Azul1)
            GA1 = 1
            ContCom = 1
            z = z - 1
            Azul1.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAZULRotado.png")
            If GA1 = 1 And GA2 = 1 And GA3 = 1 And GA4 And MSG = 0 Then
                MSG = MSG + 1
                GA1 = 0 And GA2 = 0 And GA3 = 0 And GA4 = 0
                AT = True
                PuestoAzul.Enabled = False
                PuestoAzul.BackgroundImage = My.Resources.CORONA11
                ContCom = 0
                If CJ = 2 Then
                    Fin.Enabled = False
                    Fin.BackgroundImage = My.Resources.FIN
                    If VT = False Then
                        PuestoVerde.BackgroundImage = My.Resources.CORONA2
                    ElseIf AT = False Then
                        PuestoAzul.BackgroundImage = My.Resources.CORONA2
                    End If
                    Verde1.Hide()
                    Verde2.Hide()
                    Verde3.Hide()
                    Verde4.Hide()
                    Azul1.Hide()
                    Azul2.Hide()
                    Azul3.Hide()
                    Azul4.Hide()
                    ContCom = 0
                    desabilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                    deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                    deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                    deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                End If
            ElseIf GA1 = 1 And GA2 = 1 And GA3 = 1 And GA4 And MSG = 1 Then
                MSG = MSG + 1
                GA1 = 0 And GA2 = 0 And GA3 = 0 And GA4 = 0
                AT = True
                PuestoAzul.Enabled = False
                PuestoAzul.BackgroundImage = My.Resources.CORONA2
                ContCom = 0
            ElseIf GA1 = 1 And GA2 = 1 And GA3 = 1 And GA4 And MSG = 2 Then
                MSG = MSG + 1
                GA1 = 0 And GA2 = 0 And GA3 = 0 And GA4 = 0
                AT = True
                PuestoAzul.Enabled = False
                PuestoAzul.BackgroundImage = My.Resources.CORONA3
                Fin.Enabled = False
                Fin.BackgroundImage = My.Resources.FIN
                H = 1
                If RT = False Then
                    PuestoRojo.BackgroundImage = My.Resources.CORONA4
                ElseIf VT = False Then
                    PuestoVerde.BackgroundImage = My.Resources.CORONA4
                ElseIf AmT = False Then
                    PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
                ElseIf AT = False Then
                    PuestoAzul.BackgroundImage = My.Resources.CORONA4
                End If
                Rojo1.Hide()
                Rojo2.Hide()
                Rojo3.Hide()
                Rojo4.Hide()
                Verde1.Hide()
                Verde2.Hide()
                Verde3.Hide()
                Verde4.Hide()
                Amarillo1.Hide()
                Amarillo2.Hide()
                Amarillo3.Hide()
                Amarillo4.Hide()
                Azul1.Hide()
                Azul2.Hide()
                Azul3.Hide()
                Azul4.Hide()
                ContCom = 0
                desabilitarTirar(Tirar)
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            ElseIf H = 1 Then
                PuestoAzul.BackgroundImage = My.Resources.CORONA4
            End If
        End If
        If (n = 6 And a < 3 Or ContCom = 1) And AT = False Then
            CambiarDado()
            If ContCom = 1 Then
                a = a - 1
                ContCom = 0
                If H = 1 Then
                    desabilitarTirar(Tirar)
                ElseIf z < 1 And n <> 6 And GA1 = 1 Then
                    habilitarTirar(Tirar)
                    deshabilitarFichas(Azul2, Azul2, Azul3, Azul4)
                ElseIf z > 0 Or n = 6 Then
                    desabilitarTirar(Tirar)
                    habilitarFichas(Azul2, Azul2, Azul3, Azul4)
                End If
            End If
        ElseIf a = 3 Or AT = True Or H = 1 Then
            If H = 1 Then
                desabilitarTirar(Tirar)
            End If
            deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            habilitarTirar(Tirar)
        End If
        'deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
    End Sub

    Private Sub Azul2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Azul2.Click

        c = 4

        If Azul2.Top = 424 And Azul2.Left = 403 And n = 6 Then
            Salir(Azul2, n)
            a = a + 1
        ElseIf Azul2.Top <> 424 And Azul2.Left <> 403 And GA2 = 0 Then
            Movimiento(Azul2, n)
            pos = colision_posiciones(Azul2)
            a = a + 1
            If pos = False Then
                fichas_colision_comer(Azul2, Rojo1, Rojo2, Rojo3, Rojo4, Verde1, Verde2, Verde3, Verde4, Amarillo1, Amarillo2, Amarillo3, Amarillo4)
            End If
            If n < 6 And a < 3 And ContCom = 0 Then
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                habilitarTirar(Tirar)
            End If
        End If
        If Azul2.Top = 328 And Azul2.Left < 285 And Azul2.Left > 240 Then
            Azul2.Top = 336
            Azul2.Left = 263
            deshabilitarFichas(Azul2, Azul2, Azul2, Azul2)
            GA2 = 1
            ContCom = 1
            z = z - 1
            Azul2.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAZULRotado.png")
            If GA1 = 1 And GA2 = 1 And GA3 = 1 And GA4 And MSG = 0 Then
                MSG = MSG + 1
                GA1 = 0 And GA2 = 0 And GA3 = 0 And GA4 = 0
                AT = True
                PuestoAzul.Enabled = False
                PuestoAzul.BackgroundImage = My.Resources.CORONA11
                ContCom = 0
                If CJ = 2 Then
                    Fin.Enabled = False
                    Fin.BackgroundImage = My.Resources.FIN
                    If VT = False Then
                        PuestoVerde.BackgroundImage = My.Resources.CORONA2
                    ElseIf AT = False Then
                        PuestoAzul.BackgroundImage = My.Resources.CORONA2
                    End If
                    Verde1.Hide()
                    Verde2.Hide()
                    Verde3.Hide()
                    Verde4.Hide()
                    Azul1.Hide()
                    Azul2.Hide()
                    Azul3.Hide()
                    Azul4.Hide()
                    ContCom = 0
                    desabilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                    deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                    deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                    deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                End If
            ElseIf GA1 = 1 And GA2 = 1 And GA3 = 1 And GA4 And MSG = 1 Then
                MSG = MSG + 1
                GA1 = 0 And GA2 = 0 And GA3 = 0 And GA4 = 0
                AT = True
                PuestoAzul.Enabled = False
                PuestoAzul.BackgroundImage = My.Resources.CORONA2
                ContCom = 0
            ElseIf GA1 = 1 And GA2 = 1 And GA3 = 1 And GA4 And MSG = 2 Then
                MSG = MSG + 1
                GA1 = 0 And GA2 = 0 And GA3 = 0 And GA4 = 0
                AT = True
                PuestoAzul.Enabled = False
                PuestoAzul.BackgroundImage = My.Resources.CORONA3
                Fin.Enabled = False
                Fin.BackgroundImage = My.Resources.FIN
                H = 1
                If RT = False Then
                    PuestoRojo.BackgroundImage = My.Resources.CORONA4
                ElseIf VT = False Then
                    PuestoVerde.BackgroundImage = My.Resources.CORONA4
                ElseIf AmT = False Then
                    PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
                ElseIf AT = False Then
                    PuestoAzul.BackgroundImage = My.Resources.CORONA4
                End If
                Rojo1.Hide()
                Rojo2.Hide()
                Rojo3.Hide()
                Rojo4.Hide()
                Verde1.Hide()
                Verde2.Hide()
                Verde3.Hide()
                Verde4.Hide()
                Amarillo1.Hide()
                Amarillo2.Hide()
                Amarillo3.Hide()
                Amarillo4.Hide()
                Azul1.Hide()
                Azul2.Hide()
                Azul3.Hide()
                Azul4.Hide()
                ContCom = 0
                desabilitarTirar(Tirar)
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            ElseIf H = 1 Then
                PuestoAzul.BackgroundImage = My.Resources.CORONA4
            End If
        End If
        If (n = 6 And a < 3 Or ContCom = 1) And AT = False Then
            CambiarDado()
            If ContCom = 1 Then
                a = a - 1
                ContCom = 0
                If H = 1 Then
                    desabilitarTirar(Tirar)
                ElseIf z < 1 And n <> 6 And GA2 = 1 Then
                    habilitarTirar(Tirar)
                    deshabilitarFichas(Azul1, Azul1, Azul3, Azul4)
                ElseIf z > 0 Or n = 6 Then
                    desabilitarTirar(Tirar)
                    habilitarFichas(Azul1, Azul1, Azul3, Azul4)
                End If
            End If
        ElseIf a = 3 Or AT = True Or H = 1 Then
            If H = 1 Then
                desabilitarTirar(Tirar)
            End If
            deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            habilitarTirar(Tirar)
        End If
        'deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
    End Sub

    Private Sub Azul3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Azul3.Click

        c = 4

        If Azul3.Top = 475 And Azul3.Left = 342 And n = 6 Then
            Salir(Azul3, n)
            a = a + 1
        ElseIf Azul3.Top <> 475 And Azul3.Left <> 342 And GA3 = 0 Then
            Movimiento(Azul3, n)
            pos = colision_posiciones(Azul3)
            a = a + 1
            If pos = False Then
                fichas_colision_comer(Azul3, Rojo1, Rojo2, Rojo3, Rojo4, Verde1, Verde2, Verde3, Verde4, Amarillo1, Amarillo2, Amarillo3, Amarillo4)
            End If
            If n < 6 And a < 3 And ContCom = 0 Then
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                habilitarTirar(Tirar)
            End If
        End If
        If Azul3.Top = 328 And Azul3.Left < 285 And Azul3.Left > 240 Then
            Azul3.Top = 319
            Azul3.Left = 263
            deshabilitarFichas(Azul3, Azul3, Azul3, Azul3)
            GA3 = 1
            ContCom = 1
            z = z - 1
            Azul3.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAZULRotado.png")
            If GA1 = 1 And GA2 = 1 And GA3 = 1 And GA4 And MSG = 0 Then
                MSG = MSG + 1
                GA1 = 0 And GA2 = 0 And GA3 = 0 And GA4 = 0
                AT = True
                PuestoAzul.Enabled = False
                PuestoAzul.BackgroundImage = My.Resources.CORONA11
                ContCom = 0
                If CJ = 2 Then
                    Fin.Enabled = False
                    Fin.BackgroundImage = My.Resources.FIN
                    If VT = False Then
                        PuestoVerde.BackgroundImage = My.Resources.CORONA2
                    ElseIf AT = False Then
                        PuestoAzul.BackgroundImage = My.Resources.CORONA2
                    End If
                    Verde1.Hide()
                    Verde2.Hide()
                    Verde3.Hide()
                    Verde4.Hide()
                    Azul1.Hide()
                    Azul2.Hide()
                    Azul3.Hide()
                    Azul4.Hide()
                    ContCom = 0
                    desabilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                    deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                    deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                    deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                End If
            ElseIf GA1 = 1 And GA2 = 1 And GA3 = 1 And GA4 And MSG = 1 Then
                MSG = MSG + 1
                GA1 = 0 And GA2 = 0 And GA3 = 0 And GA4 = 0
                AT = True
                PuestoAzul.Enabled = False
                PuestoAzul.BackgroundImage = My.Resources.CORONA2
                ContCom = 0
            ElseIf GA1 = 1 And GA2 = 1 And GA3 = 1 And GA4 And MSG = 2 Then
                MSG = MSG + 1
                GA1 = 0 And GA2 = 0 And GA3 = 0 And GA4 = 0
                AT = True
                PuestoAzul.Enabled = False
                PuestoAzul.BackgroundImage = My.Resources.CORONA3
                Fin.Enabled = False
                Fin.BackgroundImage = My.Resources.FIN
                H = 1
                If RT = False Then
                    PuestoRojo.BackgroundImage = My.Resources.CORONA4
                ElseIf VT = False Then
                    PuestoVerde.BackgroundImage = My.Resources.CORONA4
                ElseIf AmT = False Then
                    PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
                ElseIf AT = False Then
                    PuestoAzul.BackgroundImage = My.Resources.CORONA4
                End If
                Rojo1.Hide()
                Rojo2.Hide()
                Rojo3.Hide()
                Rojo4.Hide()
                Verde1.Hide()
                Verde2.Hide()
                Verde3.Hide()
                Verde4.Hide()
                Amarillo1.Hide()
                Amarillo2.Hide()
                Amarillo3.Hide()
                Amarillo4.Hide()
                Azul1.Hide()
                Azul2.Hide()
                Azul3.Hide()
                Azul4.Hide()
                ContCom = 0
                desabilitarTirar(Tirar)
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            ElseIf H = 1 Then
                PuestoAzul.BackgroundImage = My.Resources.CORONA4
            End If
        End If
        If (n = 6 And a < 3 Or ContCom = 1) And AT = False Then
            CambiarDado()
            If ContCom = 1 Then
                a = a - 1
                ContCom = 0
                If H = 1 Then
                    desabilitarTirar(Tirar)
                ElseIf z < 1 And n <> 6 And GA3 = 1 Then
                    habilitarTirar(Tirar)
                    deshabilitarFichas(Azul1, Azul1, Azul2, Azul4)
                ElseIf z > 0 Or n = 6 Then
                    desabilitarTirar(Tirar)
                    habilitarFichas(Azul1, Azul1, Azul2, Azul4)
                End If
            End If
        ElseIf a = 3 Or AT = True Or H = 1 Then
            If H = 1 Then
                desabilitarTirar(Tirar)
            End If
            deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            habilitarTirar(Tirar)
        End If
        'deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
    End Sub

    Private Sub Azul4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Azul4.Click

        c = 4

        If Azul4.Top = 475 And Azul4.Left = 403 And n = 6 Then
            Salir(Azul4, n)
            a = a + 1
        ElseIf Azul4.Top <> 475 And Azul4.Left <> 403 And GA4 = 0 Then
            Movimiento(Azul4, n)
            pos = colision_posiciones(Azul4)
            a = a + 1
            If pos = False Then
                fichas_colision_comer(Azul4, Rojo1, Rojo2, Rojo3, Rojo4, Verde1, Verde2, Verde3, Verde4, Amarillo1, Amarillo2, Amarillo3, Amarillo4)
            End If
            If n < 6 And a < 3 And ContCom = 0 Then
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                habilitarTirar(Tirar)
            End If
        End If
        If Azul4.Top = 328 And Azul4.Left < 285 And Azul4.Left > 240 Then
            Azul4.Top = 308
            Azul4.Left = 273
            deshabilitarFichas(Azul4, Azul4, Azul4, Azul4)
            GA4 = 1
            ContCom = 1
            z = z - 1
            Azul4.BackgroundImage = Image.FromFile(ResourceFilePathPrefix & "FICHAAZULRotado.png")
            If GA1 = 1 And GA2 = 1 And GA3 = 1 And GA4 And MSG = 0 Then
                MSG = MSG + 1
                GA1 = 0 And GA2 = 0 And GA3 = 0 And GA4 = 0
                AT = True
                PuestoAzul.Enabled = False
                PuestoAzul.BackgroundImage = My.Resources.CORONA11
                ContCom = 0
                If CJ = 2 Then
                    Fin.Enabled = False
                    Fin.BackgroundImage = My.Resources.FIN
                    If VT = False Then
                        PuestoVerde.BackgroundImage = My.Resources.CORONA2
                    ElseIf AT = False Then
                        PuestoAzul.BackgroundImage = My.Resources.CORONA2
                    End If
                    Verde1.Hide()
                    Verde2.Hide()
                    Verde3.Hide()
                    Verde4.Hide()
                    Azul1.Hide()
                    Azul2.Hide()
                    Azul3.Hide()
                    Azul4.Hide()
                    ContCom = 0
                    desabilitarTirar(Tirar)
                    deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                    deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                    deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                    deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
                End If
            ElseIf GA1 = 1 And GA2 = 1 And GA3 = 1 And GA4 And MSG = 1 Then
                MSG = MSG + 1
                GA1 = 0 And GA2 = 0 And GA3 = 0 And GA4 = 0
                AT = True
                PuestoAzul.Enabled = False
                PuestoAzul.BackgroundImage = My.Resources.CORONA2
                ContCom = 0
            ElseIf GA1 = 1 And GA2 = 1 And GA3 = 1 And GA4 And MSG = 2 Then
                MSG = MSG + 1
                GA1 = 0 And GA2 = 0 And GA3 = 0 And GA4 = 0
                AT = True
                PuestoAzul.Enabled = False
                PuestoAzul.BackgroundImage = My.Resources.CORONA3
                Fin.Enabled = False
                Fin.BackgroundImage = My.Resources.FIN
                H = 1
                If RT = False Then
                    PuestoRojo.BackgroundImage = My.Resources.CORONA4
                ElseIf VT = False Then
                    PuestoVerde.BackgroundImage = My.Resources.CORONA4
                ElseIf AmT = False Then
                    PuestoAmarillo.BackgroundImage = My.Resources.CORONA4
                ElseIf AT = False Then
                    PuestoAzul.BackgroundImage = My.Resources.CORONA4
                End If
                Rojo1.Hide()
                Rojo2.Hide()
                Rojo3.Hide()
                Rojo4.Hide()
                Verde1.Hide()
                Verde2.Hide()
                Verde3.Hide()
                Verde4.Hide()
                Amarillo1.Hide()
                Amarillo2.Hide()
                Amarillo3.Hide()
                Amarillo4.Hide()
                Azul1.Hide()
                Azul2.Hide()
                Azul3.Hide()
                Azul4.Hide()
                ContCom = 0
                desabilitarTirar(Tirar)
                deshabilitarFichas(Rojo1, Rojo2, Rojo3, Rojo4)
                deshabilitarFichas(Verde1, Verde2, Verde3, Verde4)
                deshabilitarFichas(Amarillo1, Amarillo2, Amarillo3, Amarillo4)
                deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            ElseIf H = 1 Then

            End If
        End If
        If (n = 6 And a < 3 Or ContCom = 1) And AT = False Then
            CambiarDado()
            If ContCom = 1 Then
                a = a - 1
                ContCom = 0
                If H = 1 Then
                    desabilitarTirar(Tirar)
                ElseIf z < 1 And n <> 6 And GA4 = 1 Then
                    habilitarTirar(Tirar)
                    deshabilitarFichas(Azul1, Azul1, Azul2, Azul3)
                ElseIf z > 0 Or n = 6 Then
                    desabilitarTirar(Tirar)
                    habilitarFichas(Azul1, Azul1, Azul2, Azul3)
                End If
            End If
        ElseIf a = 3 Or AT = True Or H = 1 Then
            If H = 1 Then
                desabilitarTirar(Tirar)
            End If
            deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
            habilitarTirar(Tirar)
        End If
        'deshabilitarFichas(Azul1, Azul2, Azul3, Azul4)
    End Sub



    '---------------------------------- HABILITAR Y TRAER AL FRENTE / DESHABILITAR FICHAS --------------------------------


    Public Sub habilitarFichas(ByRef F1 As PowerPacks.RectangleShape, ByRef F2 As PowerPacks.RectangleShape, ByRef F3 As PowerPacks.RectangleShape, ByRef F4 As PowerPacks.RectangleShape)
        F1.Enabled = True
        F2.Enabled = True
        F3.Enabled = True
        F4.Enabled = True

        F1.BringToFront()
        F2.BringToFront()
        F3.BringToFront()
        F4.BringToFront()

    End Sub

    Public Sub deshabilitarFichas(ByRef F1 As PowerPacks.RectangleShape, ByRef F2 As PowerPacks.RectangleShape, ByRef F3 As PowerPacks.RectangleShape, ByRef F4 As PowerPacks.RectangleShape)
        F1.Enabled = False
        F2.Enabled = False
        F3.Enabled = False
        F4.Enabled = False
    End Sub

    Public Sub habilitarTirar(ByRef T As Button)
        If H = 0 Then
            T.Enabled = True
        End If
    End Sub

    Public Sub desabilitarTirar(ByRef T As Button)
            T.Enabled = False
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.Diagnostics.Debugger.IsAttached() Then

            'In Debugging mode  

            ResourceFilePathPrefix = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\")

        Else

            'In Published mode  

            ResourceFilePathPrefix = Application.StartupPath & "\Resources\"

        End If
    End Sub
End Class