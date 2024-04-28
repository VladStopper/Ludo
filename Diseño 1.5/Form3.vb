Public Class Regla4


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Regla1.Visible = True
        Regla2.Visible = False
        Regla3.Visible = False
        Reglaa4.Visible = False
        Regla5.Visible = False
        Regla6.Visible = False

    End Sub

    Private Sub Volver1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Volver1.Click

        Me.Close()

    End Sub

    Private Sub Volver1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Volver1.MouseDown

        Volver2.BackgroundImage = My.Resources.BOTONROJOCLIK

    End Sub

    Private Sub Volver1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Volver1.MouseLeave

        Volver2.BackgroundImage = My.Resources.ROJO

    End Sub


    Private Sub Adelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Adelante.Click


        If Regla1.Visible = True Then

            Regla1.Visible = False
            Regla2.Visible = True
            Regla3.Visible = False
            Reglaa4.Visible = False
            Regla5.Visible = False
            Regla6.Visible = False

        ElseIf Regla2.Visible = True Then

            Regla1.Visible = False
            Regla2.Visible = False
            Regla3.Visible = True
            Reglaa4.Visible = False
            Regla5.Visible = False
            Regla6.Visible = False

        ElseIf Regla3.Visible = True Then

            Regla1.Visible = False
            Regla2.Visible = False
            Regla3.Visible = False
            Reglaa4.Visible = True
            Regla5.Visible = False
            Regla6.Visible = False

        ElseIf Reglaa4.Visible = True Then

            Regla1.Visible = False
            Regla2.Visible = False
            Regla3.Visible = False
            Reglaa4.Visible = False
            Regla5.Visible = True
            Regla6.Visible = False

        ElseIf Regla5.Visible = True Then

            Regla1.Visible = False
            Regla2.Visible = False
            Regla3.Visible = False
            Reglaa4.Visible = False
            Regla5.Visible = False
            Regla6.Visible = True


        End If

    End Sub

    Private Sub Atras_Click(sender As System.Object, e As System.EventArgs) Handles Atras.Click

        If Regla2.Visible = True Then

            Regla1.Visible = True
            Regla2.Visible = False
            Regla3.Visible = False
            Reglaa4.Visible = False
            Regla5.Visible = False
            Regla6.Visible = False

        ElseIf Regla3.Visible = True Then

            Regla1.Visible = False
            Regla2.Visible = True
            Regla3.Visible = False
            Reglaa4.Visible = False
            Regla5.Visible = False
            Regla6.Visible = False

        ElseIf Reglaa4.Visible = True Then

            Regla1.Visible = False
            Regla2.Visible = False
            Regla3.Visible = True
            Reglaa4.Visible = False
            Regla5.Visible = False
            Regla6.Visible = False

        ElseIf Regla5.Visible = True Then

            Regla1.Visible = False
            Regla2.Visible = False
            Regla3.Visible = False
            Reglaa4.Visible = True
            Regla5.Visible = False
            Regla6.Visible = False

        ElseIf Regla6.Visible = True Then

            Regla1.Visible = False
            Regla2.Visible = False
            Regla3.Visible = False
            Reglaa4.Visible = False
            Regla5.Visible = True
            Regla6.Visible = False


        End If


    End Sub


End Class