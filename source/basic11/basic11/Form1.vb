Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dice, i, a, b, awin, bwin, v
        i = True
        a = 100
        b = 100
        awin = 0
        bwin = 0
        Randomize()

        For index = 1 To 1000

            Do While i = True
                dice = Int(Rnd() * 6 + 1)
                a -= dice

                If a > 0 Then
                    dice = Int(Rnd() * 6 + 1)
                    b -= dice

                    If b > 0 Then
                        i = True
                    Else
                        i = False
                        bwin += 1
                    End If

                Else
                    i = False
                    awin += 1
                End If

            Loop
            i = True
        Next index

        v = awin - bwin
        If v > 0 Then
            TextBox1Result.Text = "Aの勝ち"
        ElseIf v < 0 Then
            TextBox1Result.Text = "Bの勝ち"
        Else
            TextBox1Result.Text = "引き分け"
        End If

        TextBox1A.Text = awin
        TextBox1B.Text = bwin

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim userSuit, cpSuit, v, userNum, cpNum, i
        i = True
        cpNum = 0
        userNum = 0
        userSuit = 0
        cpSuit = 0
        Randomize()


        Do While i = True
            userSuit = Int(Rnd() * 3)
            cpSuit = Int(Rnd() * 3)
            userNum = Int(Rnd() * 13 + 1)
            cpNum = Int(Rnd() * 13 + 1)

            v = userSuit - cpSuit

            If v > 0 Then
                TextBox2Result.Text = "ユーザの勝ち"
                i = False
            ElseIf v < 0 Then
                TextBox2Result.Text = "CPUの勝ち"
                i = False
            Else
                v = userNum - cpNum

                If v > 0 Then
                    TextBox2Result.Text = "ユーザの勝ち"
                    i = False
                ElseIf v < 0 Then
                    TextBox2Result.Text = "CPUの勝ち"
                    i = False
                Else
                    i = True
                End If

            End If
        Loop

        Dim arrSuit() As String = {"スペード", "クラブ", "ダイヤ", "ハート"}
        Dim userNumToString, cpNumToString
        userNumToString = CType(userNum, String)
        cpNumToString = CType(cpNum, String)
        TextBox2User.Text = arrSuit(userSuit) + userNumToString
        TextBox2Cp.Text = arrSuit(cpSuit) + cpNumToString

    End Sub
End Class
