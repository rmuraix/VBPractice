Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, a
        x = 3
        a = 3
        For n = 3 To 97 Step 2
            x += 2
            a += x
        Next n
        TextBox1.Text = a
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dice, a, n
        a = 0
        n = 0
        Randomize()
        Do While a < 100
            dice = Int(Rnd() * 6 + 1)
            If dice = 1 Then
                a += 0
            ElseIf dice = 6 Then
                a -= 1
            Else
                a += dice
            End If
            n += 1
        Loop
        TextBox2.Text = n
    End Sub
End Class
