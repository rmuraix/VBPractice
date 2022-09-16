Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim predict, dice, diff
        predict = Val(InputBox("予想を入力"))
        LabelOutPredict.Text = predict
        Randomize()
        dice = Int(Rnd() * 13 + 1)
        LabelOutDice.Text = dice
        diff = dice - predict
        If diff = 0 Then
            LabelOutJudge.Text = "大当たり"
        ElseIf Math.Abs(diff) <= 3 Then
            LabelOutJudge.Text = "小当たり"
        Else
            LabelOutJudge.Text = "ハズレ"
        End If
    End Sub
End Class
