Public Class TelaPrincipal
    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        End 'finaliza o jogo'
    End Sub

    Private Sub BtnJogar_Click(sender As Object, e As EventArgs) Handles BtnJogar.Click
        PbResult.Visible = False
        Randomize()
        Dim numero1 As String = CStr(Int(Rnd() * 10))
        Num1.Text = numero1

        Dim numero2 As String = CStr(Int(Rnd() * 10))
        Num2.Text = numero2

        Dim numero3 As String = CStr(Int(Rnd() * 10))
        Num3.Text = numero3
        'Se todas as casas derem 7'
        If (Num1.Text = "7") And (Num2.Text = "7") And (Num3.Text = "7") Then
            PbResult.Image = Image.FromFile("E:\Projetos testes\SeteDaSorteSln\image\imagem2.jpg")
            PbResult.Visible = True
            Beep()
            'Se der parcialmente'
        ElseIf (Num1.Text = "7") Or (Num2.Text = "7") Or (Num3.Text = "7") Then
            PbResult.Image = Image.FromFile("E:\Projetos testes\SeteDaSorteSln\image\imagem1.jpg")
            PbResult.Visible = True
            Beep()
            'Sefor diferente de 7'
        Else
            PbResult.Image = Image.FromFile("E:\Projetos testes\SeteDaSorteSln\image\game-over.jpg")
            PbResult.Visible = True
            Beep()
        End If


    End Sub
End Class
